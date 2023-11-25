namespace COD4_Zonetool_Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dllSelButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dllInjButton = new System.Windows.Forms.Button();
            this.refreshProcButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.instruction2Label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 68);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(92, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "COD4 Zonetool Manager";
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.SystemColors.Window;
            this.exit.Location = new System.Drawing.Point(349, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(26, 29);
            this.exit.TabIndex = 1;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(6, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(273, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Path to zonetoolDLL";
            // 
            // dllSelButton
            // 
            this.dllSelButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.dllSelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dllSelButton.ForeColor = System.Drawing.SystemColors.Window;
            this.dllSelButton.Location = new System.Drawing.Point(285, 76);
            this.dllSelButton.Name = "dllSelButton";
            this.dllSelButton.Size = new System.Drawing.Size(95, 26);
            this.dllSelButton.TabIndex = 2;
            this.dllSelButton.Text = "Choose DLL";
            this.dllSelButton.UseVisualStyleBackColor = false;
            this.dllSelButton.Click += new System.EventHandler(this.dllSelButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 108);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(374, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // dllInjButton
            // 
            this.dllInjButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.dllInjButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dllInjButton.ForeColor = System.Drawing.SystemColors.Window;
            this.dllInjButton.Location = new System.Drawing.Point(6, 138);
            this.dllInjButton.Name = "dllInjButton";
            this.dllInjButton.Size = new System.Drawing.Size(374, 28);
            this.dllInjButton.TabIndex = 4;
            this.dllInjButton.Text = "Inject DLL";
            this.dllInjButton.UseVisualStyleBackColor = false;
            this.dllInjButton.Click += new System.EventHandler(this.dllInjButton_Click);
            // 
            // refreshProcButton
            // 
            this.refreshProcButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.refreshProcButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshProcButton.ForeColor = System.Drawing.SystemColors.Window;
            this.refreshProcButton.Location = new System.Drawing.Point(6, 172);
            this.refreshProcButton.Name = "refreshProcButton";
            this.refreshProcButton.Size = new System.Drawing.Size(374, 26);
            this.refreshProcButton.TabIndex = 5;
            this.refreshProcButton.Text = "Refresh Process List";
            this.refreshProcButton.UseVisualStyleBackColor = false;
            this.refreshProcButton.Click += new System.EventHandler(this.refreshProcButton_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.infoLabel.Location = new System.Drawing.Point(12, 425);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(142, 16);
            this.infoLabel.TabIndex = 6;
            this.infoLabel.Text = "zonetool manager v1.0";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.Location = new System.Drawing.Point(12, 368);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(140, 16);
            this.instructionLabel.TabIndex = 7;
            this.instructionLabel.Text = "Supported processes:";
            // 
            // instruction2Label
            // 
            this.instruction2Label.AutoSize = true;
            this.instruction2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruction2Label.Location = new System.Drawing.Point(12, 392);
            this.instruction2Label.Name = "instruction2Label";
            this.instruction2Label.Size = new System.Drawing.Size(100, 16);
            this.instruction2Label.TabIndex = 8;
            this.instruction2Label.Text = "Supported dll\'s:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 450);
            this.Controls.Add(this.instruction2Label);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.refreshProcButton);
            this.Controls.Add(this.dllInjButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dllSelButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zonetool Manager";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button dllSelButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button dllInjButton;
        private System.Windows.Forms.Button refreshProcButton;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label instruction2Label;
    }
}

