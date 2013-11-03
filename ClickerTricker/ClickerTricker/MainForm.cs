using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClickerTricker
{
    public partial class MainForm : Form
    {
        //initialize values
        public MainForm()
        {
            InitializeComponent();

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
            if (MACListBox.SelectedItems.Count <= 0)
            {
                return;
            }

        }

    }
}
