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
            this.photoImage = new System.Windows.Forms.PictureBox();
            this.photoImage2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.photoImage3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.photoImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoImage3)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLabel1
            // 
            this.buttonLabel1.BackColor = System.Drawing.Color.Transparent;
            this.buttonLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLabel1.ForeColor = System.Drawing.Color.Red;
            this.buttonLabel1.Location = new System.Drawing.Point(12, 308);
            this.buttonLabel1.Name = "buttonLabel1";
            this.buttonLabel1.Size = new System.Drawing.Size(101, 38);
            this.buttonLabel1.TabIndex = 0;
            this.buttonLabel1.Text = "YES";
            this.buttonLabel1.UseVisualStyleBackColor = false;
            this.buttonLabel1.Click += new System.EventHandler(this.optionButton1_Click);
            // 
            // buttonLabel2
            // 
            this.buttonLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonLabel2.Location = new System.Drawing.Point(12, 384);
            this.buttonLabel2.Name = "buttonLabel2";
            this.buttonLabel2.Size = new System.Drawing.Size(101, 38);
            this.buttonLabel2.TabIndex = 1;
            this.buttonLabel2.Text = "NO";
            this.buttonLabel2.UseVisualStyleBackColor = true;
            this.buttonLabel2.Click += new System.EventHandler(this.optionBotton2_Click);
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.BackColor = System.Drawing.Color.Transparent;
            this.questionLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.ForeColor = System.Drawing.Color.Lime;
            this.questionLabel.Location = new System.Drawing.Point(12, 9);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(31, 15);
            this.questionLabel.TabIndex = 2;
            this.questionLabel.Text = "0000";
            this.questionLabel.Click += new System.EventHandler(this.questionLabel_Click);
            // 
            // photoImage
            // 
            this.photoImage.BackColor = System.Drawing.Color.Transparent;
            this.photoImage.Location = new System.Drawing.Point(12, 46);
            this.photoImage.Name = "photoImage";
            this.photoImage.Size = new System.Drawing.Size(597, 256);
            this.photoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photoImage.TabIndex = 3;
            this.photoImage.TabStop = false;
            this.photoImage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // photoImage2
            // 
            this.photoImage2.BackColor = System.Drawing.Color.Transparent;
            this.photoImage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.photoImage2.Location = new System.Drawing.Point(119, 315);
            this.photoImage2.Name = "photoImage2";
            this.photoImage2.Size = new System.Drawing.Size(209, 107);
            this.photoImage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photoImage2.TabIndex = 4;
            this.photoImage2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(12, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "TRY";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // photoImage3
            // 
            this.photoImage3.BackColor = System.Drawing.Color.Transparent;
            this.photoImage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.photoImage3.Location = new System.Drawing.Point(119, 315);
            this.photoImage3.Name = "photoImage3";
            this.photoImage3.Size = new System.Drawing.Size(209, 107);
            this.photoImage3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photoImage3.TabIndex = 6;
            this.photoImage3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::Project_Breakout.Properties.Resources.Bluerays_Image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(820, 434);
            this.Controls.Add(this.photoImage3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.photoImage2);
            this.Controls.Add(this.photoImage);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.buttonLabel2);
            this.Controls.Add(this.buttonLabel1);
            this.Name = "Form1";
            this.Text = "Project Breakout";
            ((System.ComponentModel.ISupportInitialize)(this.photoImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoImage3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLabel1;
        private System.Windows.Forms.Button buttonLabel2;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.PictureBox photoImage;
        private System.Windows.Forms.PictureBox photoImage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox photoImage3;
    }
}

