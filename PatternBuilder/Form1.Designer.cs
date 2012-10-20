namespace PatternBuilder
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
            this.btnUniver = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnWork = new System.Windows.Forms.Button();
            this.btnDisco = new System.Windows.Forms.Button();
            this.btnSleep = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUniver
            // 
            this.btnUniver.Location = new System.Drawing.Point(212, 12);
            this.btnUniver.Name = "btnUniver";
            this.btnUniver.Size = new System.Drawing.Size(138, 23);
            this.btnUniver.TabIndex = 0;
            this.btnUniver.Text = "В универ";
            this.btnUniver.UseVisualStyleBackColor = true;
            this.btnUniver.Click += new System.EventHandler(this.btnUniver_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 470);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnWork
            // 
            this.btnWork.Location = new System.Drawing.Point(212, 42);
            this.btnWork.Name = "btnWork";
            this.btnWork.Size = new System.Drawing.Size(138, 23);
            this.btnWork.TabIndex = 2;
            this.btnWork.Text = "На работу";
            this.btnWork.UseVisualStyleBackColor = true;
            this.btnWork.Click += new System.EventHandler(this.btnWork_Click);
            // 
            // btnDisco
            // 
            this.btnDisco.Location = new System.Drawing.Point(212, 71);
            this.btnDisco.Name = "btnDisco";
            this.btnDisco.Size = new System.Drawing.Size(138, 23);
            this.btnDisco.TabIndex = 3;
            this.btnDisco.Text = "На дискотеку";
            this.btnDisco.UseVisualStyleBackColor = true;
            this.btnDisco.Click += new System.EventHandler(this.btnDisco_Click);
            // 
            // btnSleep
            // 
            this.btnSleep.Location = new System.Drawing.Point(212, 100);
            this.btnSleep.Name = "btnSleep";
            this.btnSleep.Size = new System.Drawing.Size(138, 23);
            this.btnSleep.TabIndex = 4;
            this.btnSleep.Text = "Спать";
            this.btnSleep.UseVisualStyleBackColor = true;
            this.btnSleep.Click += new System.EventHandler(this.btnSleep_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 492);
            this.Controls.Add(this.btnSleep);
            this.Controls.Add(this.btnDisco);
            this.Controls.Add(this.btnWork);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnUniver);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUniver;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnWork;
        private System.Windows.Forms.Button btnDisco;
        private System.Windows.Forms.Button btnSleep;
    }
}

