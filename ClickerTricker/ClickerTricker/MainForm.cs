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
                Random numRandGen = new Random();

                string answerString = "ABCDEF1234567890";

                string randomAnswer = "1";
                //for each MAC address in the list that is checked send a randomized answer
                foreach (object currentMAC in MACListBox.CheckedItems)
                {
                    //generate the random index
                    int randomNumber = numRandGen.Next(answerString.Length);

                    //pick a random answer
                    randomAnswer = answerString.Substring(randomNumber, 1);
                    tricker.Write("b" + currentMAC.ToString() + randomAnswer + ".");
                }

                if (UseDefaultMACCheckBox.Checked == true)
                {
                    tricker.Write("b" + DefaultMACAddressTextBox.ToString() + randomAnswer + ".");
                }
                
            }
            else //do the selected answer
            {

                string answer = AnswerGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;//  "1";

                // MACListBox.
                foreach (object currentMAC in MACListBox.CheckedItems)
                {
                    tricker.Write("b" + currentMAC.ToString() + answer + ".");
                }
                if (UseDefaultMACCheckBox.Checked == true)
                {
                    tricker.Write("b" + DefaultMACAddressTextBox.ToString() + answer + ".");
                }
            }
        }

        private void MACRemoveFromList_Click(object sender, EventArgs e)
        {
            //remove the stuff from the list if selected
        }

        private void JamButton_Click(object sender, EventArgs e)
        {
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
            tricker.Write("f" + channelTextBox.Text + ".");
            System.Threading.Thread.Sleep(100);
            System.Console.Write(tricker.ReadExisting());
        }

        //parse from the returned data what are the new MACs to add to our list
        private void ScanForMACs_Click(object sender, EventArgs e)
        {
            tricker.Write("p.");
            Thread.Sleep(100);
            //System.Console.Write(tricker.ReadExisting());

            string MacString = tricker.ReadExisting();

            //while MACS are still in the string of returned characters find the MAC at the start and parse it out
            //afterwards remove the MAC from the string and search again.
            //if the MAC found is not already in the list of macs then add it.
            while (MacString.Length > 0)
            {
                int startPos = MacString.IndexOf("<MAC>");
                int endPos = MacString.IndexOf("</MAC>");
                if (endPos < 0 || startPos < 0)
                {
                    break;
                }
                int numOfMACHex = 6;

                //the plus 5 is for getting past the <MAC> in the substring positions
                string currentMAC = MacString.Substring(startPos+5,numOfMACHex);

                //add to the list if it is not already there
                if (MACListBox.Items.Contains(currentMAC) == false)
                {
                    MACListBox.Items.Add(currentMAC);
                    MACListBox.Sorted = true;
                }
                MacString.Remove(0, endPos);
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
            SurveyTextBox.Text = tricker.ReadExisting();
        }

    }
}
