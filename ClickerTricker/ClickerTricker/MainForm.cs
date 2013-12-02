using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Text.RegularExpressions;

namespace ClickerTricker
{
    public partial class MainForm : Form
    {
        SerialPort tricker = new SerialPort();
        //initialize values
        public MainForm()
        {
            InitializeComponent();

            //startup a COM Port
            tricker.BaudRate = 115200;
            //default com port for my laptop
            tricker.PortName = "COM4";

            //changing the text here will call the function below that closes and opens the com port.
            ComPortToUse.Text = "4";


            //set starting values
            TransOptSendSelected.Select();
            AnswerA.Select();

            //not needed if there is a default
            if (MACListBox.Items.Count > 0)
            {
                MACListBox.SetItemCheckState(0, CheckState.Checked);
            }
        }

        //selects all or none of the extra MAC addresses.
        private void SelectAllOrNone_Click(object sender, EventArgs e)
        {
            if (MACListBox.CheckedItems.Count >= MACListBox.Items.Count)
            {
                for (int i = 0; i < MACListBox.Items.Count; i++)
                {
                    MACListBox.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
            else
            {
                for (int i = 0; i < MACListBox.Items.Count; i++)
                {
                    MACListBox.SetItemCheckState(i, CheckState.Checked);
                }
            }

            string test = "";
            foreach (string mac in MACListBox.Items)
            {
                test += "\n\r " + mac;
            }
            int num = MACListBox.Items.Count;
            warningOutputBox.Text = test + "\r\n number found is:" + num;
        }

        private void transmitMessage_Click(object sender, EventArgs e)
        {
            //make sure at least one MAC address is selected
            if (MACListBox.CheckedItems.Count <= 0 && UseDefaultMACCheckBox.Checked == false)
            {
                warningOutputBox.Text = "Select a MAC to send with";
                return;
            }

            //needs to have the tricker already open
            if (tricker.IsOpen != true)
            {
                warningOutputBox.Text = "COM port is not open";
                return;
            }

            //if true do a random answer
            if (TransOptSendRandom.Checked == true)
            {
                //create a random answer choice for specified MACs
                Random numRandGen = new Random(DateTimeOffset.Now.Minute);

                string answerString = randomAnswerTextBox.Text;

                string randomAnswer = "a";
                //for each MAC address in the list that is checked send a randomized answer
                foreach (object currentMAC in MACListBox.CheckedItems)
                {
                    
                        //generate the random index
                        int randomNumber = numRandGen.Next(answerString.Length);
                    //pick a random answer
                    randomAnswer = answerString.Substring(randomNumber, 1);
                    tricker.Write("b" + currentMAC.ToString() + randomAnswer + ".");
                    Thread.Sleep(20);
                }

                if (UseDefaultMACCheckBox.Checked == true)
                {
                    tricker.Write("b" + DefaultMACAddressTextBox.ToString() + randomAnswer + ".");
                }
                
            }
            else //do the selected answer
            {

                string answer = AnswerGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;//  "1";
                char letterAnswer = answer[0];
                // MACListBox.
                foreach (object currentMAC in MACListBox.CheckedItems)
                {
                    string mac = currentMAC.ToString();
                    tricker.Write("b" + mac + letterAnswer + ".");
                    Thread.Sleep(20);
                }
                if (UseDefaultMACCheckBox.Checked == true)
                {
                    tricker.Write("b" + DefaultMACAddressTextBox.ToString() + letterAnswer + ".");
                }
            }
        }

        private void MACRemoveFromList_Click(object sender, EventArgs e)
        {
            //get a list of all the checked items in the list box.
            CheckedListBox.CheckedItemCollection checkedItems = MACListBox.CheckedItems;
            
            //for the number of times that it exists remove each one.  The object is linked back to the MACListBox 
            // so as you remove them the count of the box also decrements.  This is why we only tell it to remove the first
            // one each time for the total number of times instead of trying to remove them at index 0, 1, 2, 3, etc...
            int numberOfMACsToRemove = checkedItems.Count;
            for(int i = 0; i < numberOfMACsToRemove ; i++)
            {
                MACListBox.Items.Remove(checkedItems[0]);
            }
        }

        private void JamButton_Click(object sender, EventArgs e)
        {
            if (!tricker.IsOpen)
            {
                warningOutputBox.Text = "tricker port is not open";
                return;
            }

            tricker.Write("j.");
            Thread.Sleep(100);

            string MacString = tricker.ReadExisting();
            //send a jamming signal

            
        }

        private void ComPortToUse_TextChanged(object sender, EventArgs e)
        {
            tricker.Close();
            tricker.PortName = "COM" + ComPortToUse.Text;
            try
            {
                tricker.Open();
                warningOutputBox.Text = "";
            }
            catch
            {
                warningOutputBox.Text = "Bad Comm Port selected, No Port is open right now";
            }
        }


        //allows the user to directly control the arduino instead of using the interface we made.
        private void consoleEnter_Click(object sender, EventArgs e)
        {
            if (!tricker.IsOpen)
            {
                warningOutputBox.Text = "clicker port not open";
                return;

            }
            //send command
            tricker.Write(consoleTextBox.Text);
            System.Threading.Thread.Sleep(500);
            
            //clean the message of just line feeds.
            string returnMessage = "";
            returnMessage = tricker.ReadExisting();
            returnMessage = Regex.Replace(returnMessage, "(?<!\r)\n", "\r\n");

            //place any output into the window
            warningOutputBox.Text = returnMessage;
        }

        //if the user just presses enter after typing into the console line then still trigger the console functionality.
        private void consoleTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                consoleEnter_Click(null, null);
            }
        }


        private void channelTextBox_Leave(object sender, EventArgs e)
        {
            if (!tricker.IsOpen)
            {
                warningOutputBox.Text = "tricker port is not open";
                return;
            }
            tricker.Write("f" + channelTextBox.Text + ".");
            System.Threading.Thread.Sleep(100);
            System.Console.Write(tricker.ReadExisting());
        }

        //parse from the returned data what are the new MACs to add to our list
        private void ScanForMACs_Click(object sender, EventArgs e)
        {
            if (!tricker.IsOpen)
            {
                warningOutputBox.Text = "tricker is not open right now";
                return;

            }
            tricker.Write("p.");
            Thread.Sleep(100);
            //System.Console.Write(tricker.ReadExisting());

            string MacString = tricker.ReadExisting();
            string[] test = MacString.Split('\n', '<', '>');

            foreach(string currentMAC in test)
            {
                if (!currentMAC.Equals("") && !currentMAC.Contains("m") && !currentMAC.Contains("/m"))
                {
                    try
                    {
                        string tempMac = currentMAC.Substring(0, 6);
                        if (MACListBox.Items.Contains(tempMac) == false)
                        {
                            MACListBox.Items.Add(tempMac);
                            MACListBox.Sorted = true;
                        }
                    }
                    catch
                    {
                        //length wasn't long enough
                    }
                }
            }
        }

        private void RefreshStat_Click(object sender, EventArgs e)
        {
            //restart the statistics
            tricker.Write("n.");


        }

        private void AnswerHighStat_Click(object sender, EventArgs e)
        {

            //call transmit after setting it correctly to answer with what is the most popular in the stats window
        }
        
        private void StartStat_Click(object sender, EventArgs e)
        {
            //get the current stats and place them in the window 
            tricker.Write("t.");
            Thread.Sleep(300);
            string statsBack = tricker.ReadExisting();
            
            if(statsBack.Contains("<stats>"))
            {
                int lengthOfFrontTag = 8;
                string reportInfo = statsBack.Substring(statsBack.IndexOf("<stats>") + lengthOfFrontTag, statsBack.IndexOf("</stats>") - (statsBack.IndexOf("<stats>") + lengthOfFrontTag));
                reportInfo = Regex.Replace(reportInfo, "(?<!\r)\n", "\r\n");
                SurveyTextBox.Text = reportInfo;
            }
            // = tricker.ReadExisting();
        }

    }
}
