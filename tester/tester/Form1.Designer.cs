namespace tester
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
            this.abutton = new System.Windows.Forms.Button();
            this.bbutton = new System.Windows.Forms.Button();
            this.cbutton = new System.Windows.Forms.Button();
            this.dbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dogrulabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.yanlıslabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sorulabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.digersoru = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // abutton
            // 
            this.abutton.Location = new System.Drawing.Point(31, 360);
            this.abutton.Name = "abutton";
            this.abutton.Size = new System.Drawing.Size(75, 23);
            this.abutton.TabIndex = 0;
            this.abutton.Text = "A";
            this.abutton.UseVisualStyleBackColor = true;
            this.abutton.Click += new System.EventHandler(this.abutton_Click);
            // 
            // bbutton
            // 
            this.bbutton.Location = new System.Drawing.Point(112, 360);
            this.bbutton.Name = "bbutton";
            this.bbutton.Size = new System.Drawing.Size(75, 23);
            this.bbutton.TabIndex = 1;
            this.bbutton.Text = "B";
            this.bbutton.UseVisualStyleBackColor = true;
            this.bbutton.Click += new System.EventHandler(this.bbutton_Click);
            // 
            // cbutton
            // 
            this.cbutton.Location = new System.Drawing.Point(193, 360);
            this.cbutton.Name = "cbutton";
            this.cbutton.Size = new System.Drawing.Size(75, 23);
            this.cbutton.TabIndex = 2;
            this.cbutton.Text = "C";
            this.cbutton.UseVisualStyleBackColor = true;
            this.cbutton.Click += new System.EventHandler(this.cbutton_Click);
            // 
            // dbutton
            // 
            this.dbutton.Location = new System.Drawing.Point(274, 360);
            this.dbutton.Name = "dbutton";
            this.dbutton.Size = new System.Drawing.Size(75, 23);
            this.dbutton.TabIndex = 3;
            this.dbutton.Text = "D";
            this.dbutton.UseVisualStyleBackColor = true;
            this.dbutton.Click += new System.EventHandler(this.dbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(17, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dogru:";
            // 
            // dogrulabel
            // 
            this.dogrulabel.AutoSize = true;
            this.dogrulabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dogrulabel.Location = new System.Drawing.Point(71, 48);
            this.dogrulabel.Name = "dogrulabel";
            this.dogrulabel.Size = new System.Drawing.Size(15, 16);
            this.dogrulabel.TabIndex = 5;
            this.dogrulabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(17, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Yanlış:";
            // 
            // yanlıslabel
            // 
            this.yanlıslabel.AutoSize = true;
            this.yanlıslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yanlıslabel.Location = new System.Drawing.Point(71, 64);
            this.yanlıslabel.Name = "yanlıslabel";
            this.yanlıslabel.Size = new System.Drawing.Size(15, 16);
            this.yanlıslabel.TabIndex = 7;
            this.yanlıslabel.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(17, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Soru No:";
            // 
            // sorulabel
            // 
            this.sorulabel.AutoSize = true;
            this.sorulabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sorulabel.Location = new System.Drawing.Point(71, 80);
            this.sorulabel.Name = "sorulabel";
            this.sorulabel.Size = new System.Drawing.Size(15, 16);
            this.sorulabel.TabIndex = 9;
            this.sorulabel.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(407, 455);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "label7";
            this.label7.Visible = false;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dogrulabel);
            this.groupBox1.Controls.Add(this.yanlıslabel);
            this.groupBox1.Controls.Add(this.sorulabel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(374, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 139);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Konfinaksiyon";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(42, 126);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(294, 203);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "";
            // 
            // digersoru
            // 
            this.digersoru.Location = new System.Drawing.Point(423, 407);
            this.digersoru.Name = "digersoru";
            this.digersoru.Size = new System.Drawing.Size(102, 50);
            this.digersoru.TabIndex = 15;
            this.digersoru.Text = "Diğer Soruya Geç";
            this.digersoru.UseVisualStyleBackColor = true;
            this.digersoru.Click += new System.EventHandler(this.digersoru_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::tester.Properties.Resources.unnamed;
            this.pictureBox3.Location = new System.Drawing.Point(235, 7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(148, 114);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::tester.Properties.Resources.Wrong_Transparent_Background;
            this.pictureBox2.Location = new System.Drawing.Point(497, 320);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(74, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::tester.Properties.Resources.Correct_Green_Check_Mark_PNG_Image;
            this.pictureBox1.Location = new System.Drawing.Point(389, 320);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(596, 457);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.digersoru);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dbutton);
            this.Controls.Add(this.cbutton);
            this.Controls.Add(this.bbutton);
            this.Controls.Add(this.abutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Bil ve Geç";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button abutton;
        private System.Windows.Forms.Button bbutton;
        private System.Windows.Forms.Button cbutton;
        private System.Windows.Forms.Button dbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dogrulabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label yanlıslabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label sorulabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button digersoru;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

