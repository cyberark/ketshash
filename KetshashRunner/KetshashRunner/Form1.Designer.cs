namespace KetshashRunner
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.checkBoxUseKerberosCheck = new System.Windows.Forms.CheckBox();
            this.checkBoxUseNewCredentialsCheck = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFromFile = new System.Windows.Forms.Button();
            this.textBoxComputersFromFile = new System.Windows.Forms.TextBox();
            this.textBoxComputers = new System.Windows.Forms.TextBox();
            this.radioButtonFromFile = new System.Windows.Forms.RadioButton();
            this.radioButtonComputers1 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonLogFile = new System.Windows.Forms.Button();
            this.textBoxLogFile = new System.Windows.Forms.TextBox();
            this.checkBoxLogFile = new System.Windows.Forms.CheckBox();
            this.buttonRun = new System.Windows.Forms.Button();
            this.textBoxCommand = new System.Windows.Forms.TextBox();
            this.buttonPreview = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.numericUpDownMaxHourPriorToNTLM = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.checkBoxStartTime = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxHourPriorToNTLM)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxUseKerberosCheck
            // 
            this.checkBoxUseKerberosCheck.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxUseKerberosCheck.AutoSize = true;
            this.checkBoxUseKerberosCheck.Location = new System.Drawing.Point(6, 28);
            this.checkBoxUseKerberosCheck.Name = "checkBoxUseKerberosCheck";
            this.checkBoxUseKerberosCheck.Size = new System.Drawing.Size(181, 17);
            this.checkBoxUseKerberosCheck.TabIndex = 0;
            this.checkBoxUseKerberosCheck.Text = "Use Kerberos (TGT\\TGS) check";
            this.checkBoxUseKerberosCheck.UseVisualStyleBackColor = true;
            // 
            // checkBoxUseNewCredentialsCheck
            // 
            this.checkBoxUseNewCredentialsCheck.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxUseNewCredentialsCheck.AutoSize = true;
            this.checkBoxUseNewCredentialsCheck.Location = new System.Drawing.Point(6, 19);
            this.checkBoxUseNewCredentialsCheck.Name = "checkBoxUseNewCredentialsCheck";
            this.checkBoxUseNewCredentialsCheck.Size = new System.Drawing.Size(202, 17);
            this.checkBoxUseNewCredentialsCheck.TabIndex = 1;
            this.checkBoxUseNewCredentialsCheck.Text = "Search for the use of NewCredentials";
            this.checkBoxUseNewCredentialsCheck.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.checkBoxUseKerberosCheck);
            this.groupBox1.Location = new System.Drawing.Point(12, 234);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 54);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Legitimate checks";
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.checkBoxUseNewCredentialsCheck);
            this.groupBox2.Location = new System.Drawing.Point(12, 309);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 44);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Illegitimate checks";
            this.groupBox2.UseCompatibleTextRendering = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.buttonFromFile);
            this.groupBox3.Controls.Add(this.textBoxComputersFromFile);
            this.groupBox3.Controls.Add(this.textBoxComputers);
            this.groupBox3.Controls.Add(this.radioButtonFromFile);
            this.groupBox3.Controls.Add(this.radioButtonComputers1);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(412, 216);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Traget computers";
            this.groupBox3.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Example: MARS-7, MARS-10";
            // 
            // buttonFromFile
            // 
            this.buttonFromFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonFromFile.Enabled = false;
            this.buttonFromFile.Location = new System.Drawing.Point(10, 185);
            this.buttonFromFile.Name = "buttonFromFile";
            this.buttonFromFile.Size = new System.Drawing.Size(68, 23);
            this.buttonFromFile.TabIndex = 8;
            this.buttonFromFile.Text = "Browse..";
            this.buttonFromFile.UseVisualStyleBackColor = true;
            this.buttonFromFile.Click += new System.EventHandler(this.buttonFromFile_Click);
            // 
            // textBoxComputersFromFile
            // 
            this.textBoxComputersFromFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxComputersFromFile.Enabled = false;
            this.textBoxComputersFromFile.Location = new System.Drawing.Point(6, 159);
            this.textBoxComputersFromFile.Name = "textBoxComputersFromFile";
            this.textBoxComputersFromFile.Size = new System.Drawing.Size(400, 20);
            this.textBoxComputersFromFile.TabIndex = 4;
            this.textBoxComputersFromFile.Text = "C:\\tmp\\computers.txt";
            // 
            // textBoxComputers
            // 
            this.textBoxComputers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxComputers.Location = new System.Drawing.Point(7, 66);
            this.textBoxComputers.Name = "textBoxComputers";
            this.textBoxComputers.Size = new System.Drawing.Size(399, 20);
            this.textBoxComputers.TabIndex = 3;
            this.textBoxComputers.Text = "ComputerName";
            // 
            // radioButtonFromFile
            // 
            this.radioButtonFromFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonFromFile.AutoSize = true;
            this.radioButtonFromFile.Location = new System.Drawing.Point(7, 136);
            this.radioButtonFromFile.Name = "radioButtonFromFile";
            this.radioButtonFromFile.Size = new System.Drawing.Size(53, 17);
            this.radioButtonFromFile.TabIndex = 2;
            this.radioButtonFromFile.Text = "By file";
            this.toolTip1.SetToolTip(this.radioButtonFromFile, "The format of the file should be:\r\nPC1\r\nPC2\r\n...\r\n");
            this.radioButtonFromFile.UseVisualStyleBackColor = true;
            this.radioButtonFromFile.CheckedChanged += new System.EventHandler(this.radioButtonFromFile_CheckedChanged);
            // 
            // radioButtonComputers1
            // 
            this.radioButtonComputers1.AutoSize = true;
            this.radioButtonComputers1.Checked = true;
            this.radioButtonComputers1.Location = new System.Drawing.Point(7, 31);
            this.radioButtonComputers1.Name = "radioButtonComputers1";
            this.radioButtonComputers1.Size = new System.Drawing.Size(71, 17);
            this.radioButtonComputers1.TabIndex = 0;
            this.radioButtonComputers1.TabStop = true;
            this.radioButtonComputers1.Text = "By names";
            this.radioButtonComputers1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.buttonLogFile);
            this.groupBox4.Controls.Add(this.textBoxLogFile);
            this.groupBox4.Controls.Add(this.checkBoxLogFile);
            this.groupBox4.Location = new System.Drawing.Point(266, 234);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(382, 119);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Log file";
            this.groupBox4.UseCompatibleTextRendering = true;
            // 
            // buttonLogFile
            // 
            this.buttonLogFile.Enabled = false;
            this.buttonLogFile.Location = new System.Drawing.Point(6, 90);
            this.buttonLogFile.Name = "buttonLogFile";
            this.buttonLogFile.Size = new System.Drawing.Size(75, 23);
            this.buttonLogFile.TabIndex = 9;
            this.buttonLogFile.Text = "Browse..";
            this.buttonLogFile.UseVisualStyleBackColor = true;
            this.buttonLogFile.Click += new System.EventHandler(this.buttonLogFile_Click);
            // 
            // textBoxLogFile
            // 
            this.textBoxLogFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLogFile.Enabled = false;
            this.textBoxLogFile.Location = new System.Drawing.Point(6, 60);
            this.textBoxLogFile.Name = "textBoxLogFile";
            this.textBoxLogFile.Size = new System.Drawing.Size(347, 20);
            this.textBoxLogFile.TabIndex = 1;
            this.textBoxLogFile.Text = "C:\\tmp\\log.txt";
            // 
            // checkBoxLogFile
            // 
            this.checkBoxLogFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxLogFile.AutoSize = true;
            this.checkBoxLogFile.Location = new System.Drawing.Point(6, 28);
            this.checkBoxLogFile.Name = "checkBoxLogFile";
            this.checkBoxLogFile.Size = new System.Drawing.Size(78, 17);
            this.checkBoxLogFile.TabIndex = 0;
            this.checkBoxLogFile.Text = "Use log file";
            this.checkBoxLogFile.UseVisualStyleBackColor = true;
            this.checkBoxLogFile.CheckedChanged += new System.EventHandler(this.checkBoxLogFile_CheckedChanged);
            // 
            // buttonRun
            // 
            this.buttonRun.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRun.Location = new System.Drawing.Point(298, 437);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(81, 23);
            this.buttonRun.TabIndex = 7;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseCompatibleTextRendering = true;
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // textBoxCommand
            // 
            this.textBoxCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCommand.Location = new System.Drawing.Point(9, 370);
            this.textBoxCommand.Multiline = true;
            this.textBoxCommand.Name = "textBoxCommand";
            this.textBoxCommand.Size = new System.Drawing.Size(639, 53);
            this.textBoxCommand.TabIndex = 8;
            this.textBoxCommand.Text = "Import-Module .\\Ketshash.ps1;\r\nInvoke-DetectPTH -TargetComputers \"ComputerName\"";
            this.textBoxCommand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCommand_KeyDown);
            // 
            // buttonPreview
            // 
            this.buttonPreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPreview.Location = new System.Drawing.Point(158, 437);
            this.buttonPreview.Name = "buttonPreview";
            this.buttonPreview.Size = new System.Drawing.Size(81, 23);
            this.buttonPreview.TabIndex = 9;
            this.buttonPreview.Text = "Preview";
            this.buttonPreview.UseCompatibleTextRendering = true;
            this.buttonPreview.UseVisualStyleBackColor = true;
            this.buttonPreview.Click += new System.EventHandler(this.buttonPreview_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 8000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            // 
            // numericUpDownMaxHourPriorToNTLM
            // 
            this.numericUpDownMaxHourPriorToNTLM.DecimalPlaces = 1;
            this.numericUpDownMaxHourPriorToNTLM.Location = new System.Drawing.Point(163, 24);
            this.numericUpDownMaxHourPriorToNTLM.Name = "numericUpDownMaxHourPriorToNTLM";
            this.numericUpDownMaxHourPriorToNTLM.Size = new System.Drawing.Size(37, 20);
            this.numericUpDownMaxHourPriorToNTLM.TabIndex = 0;
            this.toolTip1.SetToolTip(this.numericUpDownMaxHourPriorToNTLM, "When finding suspicious NTLM event, \r\nselect what is the maximum time to check fo" +
        "r legitimate logon\r\nprior to the NTLM event");
            this.numericUpDownMaxHourPriorToNTLM.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Max hours to check for Logon prior to NTLM event";
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.numericUpDownMaxHourPriorToNTLM);
            this.groupBox6.Location = new System.Drawing.Point(440, 156);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(206, 72);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Logon times";
            this.groupBox6.UseCompatibleTextRendering = true;
            // 
            // checkBoxStartTime
            // 
            this.checkBoxStartTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkBoxStartTime.AutoSize = true;
            this.checkBoxStartTime.Location = new System.Drawing.Point(6, 25);
            this.checkBoxStartTime.Name = "checkBoxStartTime";
            this.checkBoxStartTime.Size = new System.Drawing.Size(119, 17);
            this.checkBoxStartTime.TabIndex = 0;
            this.checkBoxStartTime.Text = "Start time to monitor";
            this.checkBoxStartTime.UseVisualStyleBackColor = true;
            this.checkBoxStartTime.CheckedChanged += new System.EventHandler(this.checkBoxStartTime_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 60);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(6, 87);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 11;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox5.Controls.Add(this.dateTimePicker2);
            this.groupBox5.Controls.Add(this.dateTimePicker1);
            this.groupBox5.Controls.Add(this.checkBoxStartTime);
            this.groupBox5.Location = new System.Drawing.Point(440, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(208, 122);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Start Time";
            this.groupBox5.UseCompatibleTextRendering = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 488);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.buttonPreview);
            this.Controls.Add(this.textBoxCommand);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Keshash";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxHourPriorToNTLM)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxUseKerberosCheck;
        private System.Windows.Forms.CheckBox checkBoxUseNewCredentialsCheck;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonFromFile;
        private System.Windows.Forms.TextBox textBoxComputersFromFile;
        private System.Windows.Forms.TextBox textBoxComputers;
        private System.Windows.Forms.RadioButton radioButtonFromFile;
        private System.Windows.Forms.RadioButton radioButtonComputers1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonLogFile;
        private System.Windows.Forms.TextBox textBoxLogFile;
        private System.Windows.Forms.CheckBox checkBoxLogFile;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCommand;
        private System.Windows.Forms.Button buttonPreview;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxHourPriorToNTLM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox checkBoxStartTime;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}

