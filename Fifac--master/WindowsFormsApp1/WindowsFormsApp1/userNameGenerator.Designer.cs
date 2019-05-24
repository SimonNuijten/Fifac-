namespace WindowsFormsApp1
{
    partial class userNameGenerator
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
            this.label1 = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.generator = new System.Windows.Forms.Button();
            this.nameController = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Uw Username Is :";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.userNameLabel.Location = new System.Drawing.Point(8, 31);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(35, 13);
            this.userNameLabel.TabIndex = 1;
            this.userNameLabel.Text = "label2";
            // 
            // generator
            // 
            this.generator.BackColor = System.Drawing.Color.Silver;
            this.generator.Location = new System.Drawing.Point(11, 54);
            this.generator.Name = "generator";
            this.generator.Size = new System.Drawing.Size(217, 20);
            this.generator.TabIndex = 2;
            this.generator.Text = "Genereer Account";
            this.generator.UseVisualStyleBackColor = false;
            this.generator.Click += new System.EventHandler(this.generator_Click);
            // 
            // nameController
            // 
            this.nameController.Tick += new System.EventHandler(this.nameController_Tick);
            // 
            // userNameGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Naamloos1;
            this.ClientSize = new System.Drawing.Size(244, 85);
            this.Controls.Add(this.generator);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.label1);
            this.Name = "userNameGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "userNameGenerator";
            this.Load += new System.EventHandler(this.userNameGenerator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Button generator;
        public System.Windows.Forms.Timer nameController;
    }
}