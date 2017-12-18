using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KetshashRunner
{
    public partial class Form1 : Form
    {
        public string importModuleCommand = @"Import-Module .\Ketshash.ps1;";

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonFromFile_Click(object sender, EventArgs e)
        {
            browseToFile(this.textBoxComputersFromFile);
        }

        private void buttonLogFile_Click(object sender, EventArgs e)
        {
            browseToFile(this.textBoxLogFile);
        }

        private void browseToFile(TextBox textBox)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                textBox.Text = openFileDialog1.FileName;
            }
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            string arguments = "powershell.exe -ExecutionPolicy Bypass {" + importModuleCommand + getCommand() + "}";
            this.textBoxCommand.Text = arguments;

            Process.Start("powershell.exe", arguments);
        }

        private string getCommand()
        {
            string o_Command = "Invoke-DetectPTH";

            if (this.radioButtonComputers1.Checked)
            {
                o_Command += " -TargetComputers ";
                if (textBoxComputers.Text.Contains(","))
                {
                    o_Command += "@(";
                    string[] splitted = this.textBoxComputers.Text.Split(',');
                    foreach(string computer in splitted)
                    {
                        o_Command += "'" + computer.Trim() + "',";
                    }

                    o_Command = o_Command.Remove(o_Command.Length - 1);
                    o_Command += ")";
                }
                else
                {
                    o_Command += "\"" + this.textBoxComputers.Text.Trim() + "\"";
                }
            }
            else
            {
                o_Command += " -TargetComputersFile \"" + this.textBoxComputersFromFile.Text +"\"";
            }

            if (this.checkBoxStartTime.Checked)
            {
                o_Command += " -StartTime ([datetime]\"" + String.Join(" ", this.dateTimePicker1.Text, this.dateTimePicker2.Text) + "\")";
            }

            if (this.checkBoxLogFile.Checked)
            {
                o_Command += " -LogFile \"" + this.textBoxLogFile.Text +"\"";
            }

            if (this.checkBoxUseKerberosCheck.Checked)
            {
                o_Command += " -UseKerberosCheck";
            }

            if (this.checkBoxUseNewCredentialsCheck.Checked)
            {
                o_Command += " -UseNewCredentialsCheck";
            }

            o_Command += " -MaxHoursOfLegitLogonPriorToNTLMEvent " + numericUpDownMaxHourPriorToNTLM.Value;

            return o_Command;
        }

        private void buttonPreview_Click(object sender, EventArgs e)
        {
            this.textBoxCommand.Text = importModuleCommand + "\r\n" + getCommand();
        }

        private void checkBoxStartTime_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxStartTime.Checked)
            {
                this.dateTimePicker1.Enabled = true;
                this.dateTimePicker2.Enabled = true;
            }
            else
            {
                this.dateTimePicker1.Enabled = false;
                this.dateTimePicker2.Enabled = false;
            }
        }

        private void textBoxCommand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                if (sender != null)
                    ((TextBox)sender).SelectAll();
            }
        }

        private void radioButtonFromFile_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonFromFile.Checked)
            {
                this.textBoxComputersFromFile.Enabled = true;
                this.buttonFromFile.Enabled = true;
                this.textBoxComputers.Enabled = false;
            }
            else
            {
                this.textBoxComputersFromFile.Enabled = false;
                this.buttonFromFile.Enabled = false;
                this.textBoxComputers.Enabled = true;
            }
        }

        private void checkBoxLogFile_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxLogFile.Checked)
            {
                this.textBoxLogFile.Enabled = true;
                this.buttonLogFile.Enabled = true;
            }
            else
            {
                this.textBoxLogFile.Enabled = false;
                this.buttonLogFile.Enabled = false;
            }
        }
    }
}
