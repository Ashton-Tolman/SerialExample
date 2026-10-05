namespace SerialExample
{
    partial class SerialExampleForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ExitButton = new Button();
            ConnectButton = new Button();
            ReadButton = new Button();
            SendButton = new Button();
            SerialTextBox = new TextBox();
            statusStrip1 = new StatusStrip();
            StatusLabel = new ToolStripStatusLabel();
            StatusTimer = new System.Windows.Forms.Timer(components);
            PortsComboBox = new ComboBox();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ExitButton.Location = new Point(782, 297);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(112, 54);
            ExitButton.TabIndex = 0;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // ConnectButton
            // 
            ConnectButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ConnectButton.Location = new Point(664, 297);
            ConnectButton.Name = "ConnectButton";
            ConnectButton.Size = new Size(112, 54);
            ConnectButton.TabIndex = 1;
            ConnectButton.Text = "&Connect";
            ConnectButton.UseVisualStyleBackColor = true;
            ConnectButton.Click += ConnectButton_Click;
            // 
            // ReadButton
            // 
            ReadButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ReadButton.Location = new Point(546, 297);
            ReadButton.Name = "ReadButton";
            ReadButton.Size = new Size(112, 54);
            ReadButton.TabIndex = 2;
            ReadButton.Text = "&Read";
            ReadButton.UseVisualStyleBackColor = true;
            ReadButton.Click += ReadButton_Click;
            // 
            // SendButton
            // 
            SendButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SendButton.Location = new Point(428, 297);
            SendButton.Name = "SendButton";
            SendButton.Size = new Size(112, 54);
            SendButton.TabIndex = 3;
            SendButton.Text = "&Send";
            SendButton.UseVisualStyleBackColor = true;
            SendButton.Click += SendButton_Click;
            // 
            // SerialTextBox
            // 
            SerialTextBox.Location = new Point(12, 12);
            SerialTextBox.Name = "SerialTextBox";
            SerialTextBox.Size = new Size(285, 31);
            SerialTextBox.TabIndex = 4;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { StatusLabel });
            statusStrip1.Location = new Point(0, 354);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(902, 32);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(42, 25);
            StatusLabel.Text = "Text";
            // 
            // StatusTimer
            // 
            StatusTimer.Enabled = true;
            StatusTimer.Tick += StatusTimer_Tick;
            // 
            // PortsComboBox
            // 
            PortsComboBox.FormattingEnabled = true;
            PortsComboBox.Location = new Point(12, 49);
            PortsComboBox.Name = "PortsComboBox";
            PortsComboBox.Size = new Size(182, 33);
            PortsComboBox.TabIndex = 6;
            // 
            // SerialExampleForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 386);
            Controls.Add(PortsComboBox);
            Controls.Add(statusStrip1);
            Controls.Add(SerialTextBox);
            Controls.Add(SendButton);
            Controls.Add(ReadButton);
            Controls.Add(ConnectButton);
            Controls.Add(ExitButton);
            Name = "SerialExampleForm";
            Text = "SerialExampleForm";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Button ExitButton;
        private Button ConnectButton;
        private Button ReadButton;
        private Button SendButton;
        private TextBox SerialTextBox;
        private StatusStrip statusStrip1;
        private System.Windows.Forms.Timer StatusTimer;
        private ToolStripStatusLabel StatusLabel;
        private ComboBox PortsComboBox;
    }
}
