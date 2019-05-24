namespace WindowsFormsApp1
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
            this.phpdataLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.favCombobox = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.betButton = new System.Windows.Forms.Button();
            this.resultLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.VSlbl = new System.Windows.Forms.Label();
            this.rightteamCombobox = new System.Windows.Forms.ComboBox();
            this.leftteamCombobox = new System.Windows.Forms.ComboBox();
            this.rightteamGoalsTextBox = new System.Windows.Forms.TextBox();
            this.leftteamGoalsTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // phpdataLabel
            // 
            this.phpdataLabel.AutoSize = true;
            this.phpdataLabel.Location = new System.Drawing.Point(213, 76);
            this.phpdataLabel.Name = "phpdataLabel";
            this.phpdataLabel.Size = new System.Drawing.Size(0, 17);
            this.phpdataLabel.TabIndex = 0;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(17, 16);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(46, 17);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(684, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // favCombobox
            // 
            this.favCombobox.FormattingEnabled = true;
            this.favCombobox.Location = new System.Drawing.Point(467, 130);
            this.favCombobox.Name = "favCombobox";
            this.favCombobox.Size = new System.Drawing.Size(121, 24);
            this.favCombobox.TabIndex = 3;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(431, 194);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(190, 24);
            this.comboBox2.TabIndex = 5;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // betButton
            // 
            this.betButton.Location = new System.Drawing.Point(483, 279);
            this.betButton.Name = "betButton";
            this.betButton.Size = new System.Drawing.Size(75, 23);
            this.betButton.TabIndex = 6;
            this.betButton.Text = "Wedden";
            this.betButton.UseVisualStyleBackColor = true;
            this.betButton.Click += new System.EventHandler(this.betButton_Click);
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Location = new System.Drawing.Point(505, 238);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(0, 17);
            this.resultLbl.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Stand word:";
            // 
            // VSlbl
            // 
            this.VSlbl.AutoSize = true;
            this.VSlbl.BackColor = System.Drawing.Color.Transparent;
            this.VSlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VSlbl.Location = new System.Drawing.Point(511, 238);
            this.VSlbl.Name = "VSlbl";
            this.VSlbl.Size = new System.Drawing.Size(20, 25);
            this.VSlbl.TabIndex = 13;
            this.VSlbl.Text = "-";
            // 
            // rightteamCombobox
            // 
            this.rightteamCombobox.FormattingEnabled = true;
            this.rightteamCombobox.Location = new System.Drawing.Point(627, 238);
            this.rightteamCombobox.Name = "rightteamCombobox";
            this.rightteamCombobox.Size = new System.Drawing.Size(121, 24);
            this.rightteamCombobox.TabIndex = 11;
            // 
            // leftteamCombobox
            // 
            this.leftteamCombobox.FormattingEnabled = true;
            this.leftteamCombobox.Location = new System.Drawing.Point(304, 238);
            this.leftteamCombobox.Name = "leftteamCombobox";
            this.leftteamCombobox.Size = new System.Drawing.Size(121, 24);
            this.leftteamCombobox.TabIndex = 12;
            this.leftteamCombobox.SelectedIndexChanged += new System.EventHandler(this.leftteamCombobox_SelectedIndexChanged);
            // 
            // rightteamGoalsTextBox
            // 
            this.rightteamGoalsTextBox.Location = new System.Drawing.Point(596, 238);
            this.rightteamGoalsTextBox.Name = "rightteamGoalsTextBox";
            this.rightteamGoalsTextBox.Size = new System.Drawing.Size(25, 22);
            this.rightteamGoalsTextBox.TabIndex = 10;
            // 
            // leftteamGoalsTextBox
            // 
            this.leftteamGoalsTextBox.Location = new System.Drawing.Point(431, 238);
            this.leftteamGoalsTextBox.Name = "leftteamGoalsTextBox";
            this.leftteamGoalsTextBox.Size = new System.Drawing.Size(25, 22);
            this.leftteamGoalsTextBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(318, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Kies je favo team:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(331, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Wedstrijd:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Naamloos1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.VSlbl);
            this.Controls.Add(this.leftteamCombobox);
            this.Controls.Add(this.rightteamCombobox);
            this.Controls.Add(this.rightteamGoalsTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.leftteamGoalsTextBox);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.betButton);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.favCombobox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.phpdataLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label phpdataLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox favCombobox;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button betButton;
        private System.Windows.Forms.Label resultLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label VSlbl;
        private System.Windows.Forms.ComboBox rightteamCombobox;
        private System.Windows.Forms.ComboBox leftteamCombobox;
        private System.Windows.Forms.TextBox rightteamGoalsTextBox;
        private System.Windows.Forms.TextBox leftteamGoalsTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

