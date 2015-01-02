namespace DrgCalc
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
            this.strengthTextBox = new System.Windows.Forms.TextBox();
            this.strLabel = new System.Windows.Forms.Label();
            this.determinationLabel = new System.Windows.Forms.Label();
            this.criticalLabel = new System.Windows.Forms.Label();
            this.skillSpeedLabel = new System.Windows.Forms.Label();
            this.determinationTextBox = new System.Windows.Forms.TextBox();
            this.criticalTextBox = new System.Windows.Forms.TextBox();
            this.skillSpeedTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.damageTextBox = new System.Windows.Forms.TextBox();
            this.damageValueLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.drgButton = new System.Windows.Forms.RadioButton();
            this.mnkButton = new System.Windows.Forms.RadioButton();
            this.brdButton = new System.Windows.Forms.RadioButton();
            this.blmButton = new System.Windows.Forms.RadioButton();
            this.smnButton = new System.Windows.Forms.RadioButton();
            this.warButton = new System.Windows.Forms.RadioButton();
            this.helpButton = new System.Windows.Forms.Button();
            this.pldButton = new System.Windows.Forms.RadioButton();
            this.ninButton = new System.Windows.Forms.RadioButton();
            this.weaponDamageTextBox = new System.Windows.Forms.TextBox();
            this.weaponDamageLabel = new System.Windows.Forms.Label();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // strengthTextBox
            // 
            this.strengthTextBox.Location = new System.Drawing.Point(144, 170);
            this.strengthTextBox.Name = "strengthTextBox";
            this.strengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.strengthTextBox.TabIndex = 0;
            this.strengthTextBox.TextChanged += new System.EventHandler(this.strengthTextBox_TextChanged);
            this.strengthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.strengthTextBox_KeyPress);
            // 
            // strLabel
            // 
            this.strLabel.AutoSize = true;
            this.strLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strLabel.ForeColor = System.Drawing.Color.White;
            this.strLabel.Location = new System.Drawing.Point(55, 171);
            this.strLabel.Name = "strLabel";
            this.strLabel.Size = new System.Drawing.Size(83, 19);
            this.strLabel.TabIndex = 1;
            this.strLabel.Text = "Str/Dex/Int";
            this.strLabel.MouseHover += new System.EventHandler(this.strLabel_MouseHover);
            // 
            // determinationLabel
            // 
            this.determinationLabel.AutoSize = true;
            this.determinationLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.determinationLabel.ForeColor = System.Drawing.Color.White;
            this.determinationLabel.Location = new System.Drawing.Point(35, 196);
            this.determinationLabel.Name = "determinationLabel";
            this.determinationLabel.Size = new System.Drawing.Size(105, 19);
            this.determinationLabel.TabIndex = 2;
            this.determinationLabel.Text = "Determination";
            this.determinationLabel.MouseHover += new System.EventHandler(this.determinationLabel_MouseHover);
            // 
            // criticalLabel
            // 
            this.criticalLabel.AutoSize = true;
            this.criticalLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.criticalLabel.ForeColor = System.Drawing.Color.White;
            this.criticalLabel.Location = new System.Drawing.Point(84, 222);
            this.criticalLabel.Name = "criticalLabel";
            this.criticalLabel.Size = new System.Drawing.Size(56, 19);
            this.criticalLabel.TabIndex = 3;
            this.criticalLabel.Text = "Critical";
            this.criticalLabel.MouseHover += new System.EventHandler(this.criticalLabel_MouseHover);
            // 
            // skillSpeedLabel
            // 
            this.skillSpeedLabel.AutoSize = true;
            this.skillSpeedLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skillSpeedLabel.ForeColor = System.Drawing.Color.White;
            this.skillSpeedLabel.Location = new System.Drawing.Point(57, 248);
            this.skillSpeedLabel.Name = "skillSpeedLabel";
            this.skillSpeedLabel.Size = new System.Drawing.Size(83, 19);
            this.skillSpeedLabel.TabIndex = 4;
            this.skillSpeedLabel.Text = "Skill Speed";
            this.skillSpeedLabel.MouseHover += new System.EventHandler(this.skillSpeedLabel_MouseHover);
            // 
            // determinationTextBox
            // 
            this.determinationTextBox.Location = new System.Drawing.Point(144, 196);
            this.determinationTextBox.Name = "determinationTextBox";
            this.determinationTextBox.Size = new System.Drawing.Size(100, 20);
            this.determinationTextBox.TabIndex = 5;
            this.determinationTextBox.TextChanged += new System.EventHandler(this.determinationTextBox_TextChanged);
            this.determinationTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.determinationTextBox_KeyPress);
            // 
            // criticalTextBox
            // 
            this.criticalTextBox.Location = new System.Drawing.Point(144, 222);
            this.criticalTextBox.Name = "criticalTextBox";
            this.criticalTextBox.Size = new System.Drawing.Size(100, 20);
            this.criticalTextBox.TabIndex = 6;
            this.criticalTextBox.TextChanged += new System.EventHandler(this.criticalTextBox_TextChanged);
            this.criticalTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.criticalTextBox_KeyPress);
            // 
            // skillSpeedTextBox
            // 
            this.skillSpeedTextBox.Location = new System.Drawing.Point(144, 248);
            this.skillSpeedTextBox.Name = "skillSpeedTextBox";
            this.skillSpeedTextBox.Size = new System.Drawing.Size(100, 20);
            this.skillSpeedTextBox.TabIndex = 7;
            this.skillSpeedTextBox.TextChanged += new System.EventHandler(this.skillSpeedTextBox_TextChanged);
            this.skillSpeedTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.skillSpeedTextBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(54, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "XIV Stat Calculator";
            // 
            // damageTextBox
            // 
            this.damageTextBox.Location = new System.Drawing.Point(144, 286);
            this.damageTextBox.Name = "damageTextBox";
            this.damageTextBox.Size = new System.Drawing.Size(100, 20);
            this.damageTextBox.TabIndex = 10;
            // 
            // damageValueLabel
            // 
            this.damageValueLabel.AutoSize = true;
            this.damageValueLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.damageValueLabel.ForeColor = System.Drawing.Color.White;
            this.damageValueLabel.Location = new System.Drawing.Point(32, 287);
            this.damageValueLabel.Name = "damageValueLabel";
            this.damageValueLabel.Size = new System.Drawing.Size(106, 19);
            this.damageValueLabel.TabIndex = 9;
            this.damageValueLabel.Text = "Damage Value";
            // 
            // closeButton
            // 
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(268, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(23, 23);
            this.closeButton.TabIndex = 8;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // clearButton
            // 
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.White;
            this.clearButton.Location = new System.Drawing.Point(198, 312);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(46, 23);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // drgButton
            // 
            this.drgButton.AutoSize = true;
            this.drgButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drgButton.ForeColor = System.Drawing.Color.White;
            this.drgButton.Location = new System.Drawing.Point(46, 64);
            this.drgButton.Name = "drgButton";
            this.drgButton.Size = new System.Drawing.Size(48, 17);
            this.drgButton.TabIndex = 12;
            this.drgButton.TabStop = true;
            this.drgButton.Text = "DRG";
            this.drgButton.UseVisualStyleBackColor = true;
            this.drgButton.CheckedChanged += new System.EventHandler(this.drgButton_CheckedChanged);
            // 
            // mnkButton
            // 
            this.mnkButton.AutoSize = true;
            this.mnkButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnkButton.ForeColor = System.Drawing.Color.White;
            this.mnkButton.Location = new System.Drawing.Point(154, 64);
            this.mnkButton.Name = "mnkButton";
            this.mnkButton.Size = new System.Drawing.Size(49, 17);
            this.mnkButton.TabIndex = 13;
            this.mnkButton.TabStop = true;
            this.mnkButton.Text = "MNK";
            this.mnkButton.UseVisualStyleBackColor = true;
            this.mnkButton.CheckedChanged += new System.EventHandler(this.mnkButton_CheckedChanged);
            // 
            // brdButton
            // 
            this.brdButton.AutoSize = true;
            this.brdButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brdButton.ForeColor = System.Drawing.Color.White;
            this.brdButton.Location = new System.Drawing.Point(209, 64);
            this.brdButton.Name = "brdButton";
            this.brdButton.Size = new System.Drawing.Size(47, 17);
            this.brdButton.TabIndex = 14;
            this.brdButton.TabStop = true;
            this.brdButton.Text = "BRD";
            this.brdButton.UseVisualStyleBackColor = true;
            this.brdButton.CheckedChanged += new System.EventHandler(this.brdButton_CheckedChanged);
            // 
            // blmButton
            // 
            this.blmButton.AutoSize = true;
            this.blmButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blmButton.ForeColor = System.Drawing.Color.White;
            this.blmButton.Location = new System.Drawing.Point(100, 87);
            this.blmButton.Name = "blmButton";
            this.blmButton.Size = new System.Drawing.Size(47, 17);
            this.blmButton.TabIndex = 15;
            this.blmButton.TabStop = true;
            this.blmButton.Text = "BLM";
            this.blmButton.UseVisualStyleBackColor = true;
            this.blmButton.CheckedChanged += new System.EventHandler(this.blmButton_CheckedChanged);
            // 
            // smnButton
            // 
            this.smnButton.AutoSize = true;
            this.smnButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smnButton.ForeColor = System.Drawing.Color.White;
            this.smnButton.Location = new System.Drawing.Point(154, 87);
            this.smnButton.Name = "smnButton";
            this.smnButton.Size = new System.Drawing.Size(49, 17);
            this.smnButton.TabIndex = 16;
            this.smnButton.TabStop = true;
            this.smnButton.Text = "SMN";
            this.smnButton.UseVisualStyleBackColor = true;
            this.smnButton.CheckedChanged += new System.EventHandler(this.smnButton_CheckedChanged);
            // 
            // warButton
            // 
            this.warButton.AutoSize = true;
            this.warButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warButton.ForeColor = System.Drawing.Color.White;
            this.warButton.Location = new System.Drawing.Point(154, 110);
            this.warButton.Name = "warButton";
            this.warButton.Size = new System.Drawing.Size(50, 17);
            this.warButton.TabIndex = 17;
            this.warButton.TabStop = true;
            this.warButton.Text = "WAR";
            this.warButton.UseVisualStyleBackColor = true;
            this.warButton.CheckedChanged += new System.EventHandler(this.warButton_CheckedChanged);
            // 
            // helpButton
            // 
            this.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpButton.ForeColor = System.Drawing.Color.White;
            this.helpButton.Location = new System.Drawing.Point(246, 0);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(23, 23);
            this.helpButton.TabIndex = 18;
            this.helpButton.Text = "?";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // pldButton
            // 
            this.pldButton.AutoSize = true;
            this.pldButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pldButton.ForeColor = System.Drawing.Color.White;
            this.pldButton.Location = new System.Drawing.Point(100, 110);
            this.pldButton.Name = "pldButton";
            this.pldButton.Size = new System.Drawing.Size(44, 17);
            this.pldButton.TabIndex = 19;
            this.pldButton.TabStop = true;
            this.pldButton.Text = "PLD";
            this.pldButton.UseVisualStyleBackColor = true;
            this.pldButton.CheckedChanged += new System.EventHandler(this.pldButton_CheckedChanged);
            // 
            // ninButton
            // 
            this.ninButton.AutoSize = true;
            this.ninButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ninButton.ForeColor = System.Drawing.Color.White;
            this.ninButton.Location = new System.Drawing.Point(100, 64);
            this.ninButton.Name = "ninButton";
            this.ninButton.Size = new System.Drawing.Size(44, 17);
            this.ninButton.TabIndex = 20;
            this.ninButton.TabStop = true;
            this.ninButton.Text = "NIN";
            this.ninButton.UseVisualStyleBackColor = true;
            this.ninButton.CheckedChanged += new System.EventHandler(this.ninButton_CheckedChanged);
            // 
            // weaponDamageTextBox
            // 
            this.weaponDamageTextBox.Location = new System.Drawing.Point(144, 144);
            this.weaponDamageTextBox.Name = "weaponDamageTextBox";
            this.weaponDamageTextBox.Size = new System.Drawing.Size(100, 20);
            this.weaponDamageTextBox.TabIndex = 21;
            this.weaponDamageTextBox.TextChanged += new System.EventHandler(this.weaponDamageTextBox_TextChanged);
            this.weaponDamageTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.weaponDamageTextBox_KeyPress);
            // 
            // weaponDamageLabel
            // 
            this.weaponDamageLabel.AutoSize = true;
            this.weaponDamageLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weaponDamageLabel.ForeColor = System.Drawing.Color.White;
            this.weaponDamageLabel.Location = new System.Drawing.Point(13, 145);
            this.weaponDamageLabel.Name = "weaponDamageLabel";
            this.weaponDamageLabel.Size = new System.Drawing.Size(125, 19);
            this.weaponDamageLabel.TabIndex = 22;
            this.weaponDamageLabel.Text = "Weapon Damage";
            this.weaponDamageLabel.MouseHover += new System.EventHandler(this.weaponDamageLabel_MouseHover);
            // 
            // minimizeButton
            // 
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeButton.ForeColor = System.Drawing.Color.White;
            this.minimizeButton.Location = new System.Drawing.Point(224, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(23, 23);
            this.minimizeButton.TabIndex = 23;
            this.minimizeButton.Text = "_";
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(291, 351);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.weaponDamageTextBox);
            this.Controls.Add(this.weaponDamageLabel);
            this.Controls.Add(this.ninButton);
            this.Controls.Add(this.pldButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.warButton);
            this.Controls.Add(this.smnButton);
            this.Controls.Add(this.blmButton);
            this.Controls.Add(this.brdButton);
            this.Controls.Add(this.mnkButton);
            this.Controls.Add(this.drgButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.skillSpeedTextBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.strengthTextBox);
            this.Controls.Add(this.strLabel);
            this.Controls.Add(this.determinationLabel);
            this.Controls.Add(this.damageTextBox);
            this.Controls.Add(this.criticalLabel);
            this.Controls.Add(this.damageValueLabel);
            this.Controls.Add(this.criticalTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.skillSpeedLabel);
            this.Controls.Add(this.determinationTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox strengthTextBox;
        private System.Windows.Forms.Label strLabel;
        private System.Windows.Forms.Label determinationLabel;
        private System.Windows.Forms.Label criticalLabel;
        private System.Windows.Forms.Label skillSpeedLabel;
        private System.Windows.Forms.TextBox determinationTextBox;
        private System.Windows.Forms.TextBox criticalTextBox;
        private System.Windows.Forms.TextBox skillSpeedTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox damageTextBox;
        private System.Windows.Forms.Label damageValueLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.RadioButton drgButton;
        private System.Windows.Forms.RadioButton mnkButton;
        private System.Windows.Forms.RadioButton brdButton;
        private System.Windows.Forms.RadioButton blmButton;
        private System.Windows.Forms.RadioButton smnButton;
        private System.Windows.Forms.RadioButton warButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.RadioButton pldButton;
        private System.Windows.Forms.RadioButton ninButton;
        private System.Windows.Forms.TextBox weaponDamageTextBox;
        private System.Windows.Forms.Label weaponDamageLabel;
        private System.Windows.Forms.Button minimizeButton;
    }
}

