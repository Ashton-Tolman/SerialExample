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
            ExitButton = new Button();
            ConnectButton = new Button();
            ReadButton = new Button();
            SendButton = new Button();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(1330, 607);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(112, 54);
            ExitButton.TabIndex = 0;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // ConnectButton
            // 
            ConnectButton.Location = new Point(1212, 607);
            ConnectButton.Name = "ConnectButton";
            ConnectButton.Size = new Size(112, 54);
            ConnectButton.TabIndex = 1;
            ConnectButton.Text = "&Connect";
            ConnectButton.UseVisualStyleBackColor = true;
            ConnectButton.Click += ConnectButton_Click;
            // 
            // ReadButton
            // 
            ReadButton.Location = new Point(1094, 607);
            ReadButton.Name = "ReadButton";
            ReadButton.Size = new Size(112, 54);
            ReadButton.TabIndex = 2;
            ReadButton.Text = "&Read";
            ReadButton.UseVisualStyleBackColor = true;
            // 
            // SendButton
            // 
            SendButton.Location = new Point(976, 607);
            SendButton.Name = "SendButton";
            SendButton.Size = new Size(112, 54);
            SendButton.TabIndex = 3;
            SendButton.Text = "&Send";
            SendButton.UseVisualStyleBackColor = true;
            // 
            // SerialExampleForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1454, 673);
            Controls.Add(SendButton);
            Controls.Add(ReadButton);
            Controls.Add(ConnectButton);
            Controls.Add(ExitButton);
            Name = "SerialExampleForm";
            Text = "SerialExampleForm";
            ResumeLayout(false);
        }



        #endregion

        private Button ExitButton;
        private Button ConnectButton;
        private Button ReadButton;
        private Button SendButton;
    }
}
