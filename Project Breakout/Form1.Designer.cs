namespace Project_Breakout
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
            this.buttonLabel1 = new System.Windows.Forms.Button();
            this.buttonLabel2 = new System.Windows.Forms.Button();
            this.questionLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLabel1
            // 
            this.buttonLabel1.BackColor = System.Drawing.Color.Transparent;
            this.buttonLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLabel1.ForeColor = System.Drawing.Color.Red;
            this.buttonLabel1.Location = new System.Drawing.Point(12, 348);
            this.buttonLabel1.Name = "buttonLabel1";
            this.buttonLabel1.Size = new System.Drawing.Size(100, 29);
            this.buttonLabel1.TabIndex = 0;
            this.buttonLabel1.Text = "YES";
            this.buttonLabel1.UseVisualStyleBackColor = false;
            this.buttonLabel1.Click += new System.EventHandler(this.optionButton1_Click);
            // 
            // buttonLabel2
            // 
            this.buttonLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonLabel2.Location = new System.Drawing.Point(11, 383);
            this.buttonLabel2.Name = "buttonLabel2";
            this.buttonLabel2.Size = new System.Drawing.Size(101, 29);
            this.buttonLabel2.TabIndex = 1;
            this.buttonLabel2.Text = "NO";
            this.buttonLabel2.UseVisualStyleBackColor = true;
            this.buttonLabel2.Click += new System.EventHandler(this.optionBotton2_Click);
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.BackColor = System.Drawing.Color.Transparent;
            this.questionLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.Location = new System.Drawing.Point(12, 313);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(0, 17);
            this.questionLabel.TabIndex = 2;
            this.questionLabel.Click += new System.EventHandler(this.questionLabel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Project_Breakout.Properties.Resources.ProjectBreakout_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(-27, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1338, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImage = global::Project_Breakout.Properties.Resources.black_and_white;
            this.ClientSize = new System.Drawing.Size(1306, 474);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.buttonLabel2);
            this.Controls.Add(this.buttonLabel1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLabel1;
        private System.Windows.Forms.Button buttonLabel2;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

