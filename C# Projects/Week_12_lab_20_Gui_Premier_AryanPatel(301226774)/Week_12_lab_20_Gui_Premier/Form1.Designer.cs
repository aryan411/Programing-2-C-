
namespace Week_12_lab_20_Gui_Premier
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picPremier = new System.Windows.Forms.PictureBox();
            this.lstPremier = new System.Windows.Forms.ListBox();
            this.name = new System.Windows.Forms.Label();
            this.lifeLable = new System.Windows.Forms.Label();
            this.startEndLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPremier)).BeginInit();
            this.SuspendLayout();
            // 
            // picPremier
            // 
            this.picPremier.Image = ((System.Drawing.Image)(resources.GetObject("picPremier.Image")));
            this.picPremier.Location = new System.Drawing.Point(41, 69);
            this.picPremier.Name = "picPremier";
            this.picPremier.Size = new System.Drawing.Size(113, 141);
            this.picPremier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPremier.TabIndex = 0;
            this.picPremier.TabStop = false;
            this.picPremier.Click += new System.EventHandler(this.picPremier_Click);
            // 
            // lstPremier
            // 
            this.lstPremier.FormattingEnabled = true;
            this.lstPremier.ItemHeight = 15;
            this.lstPremier.Location = new System.Drawing.Point(587, 27);
            this.lstPremier.Name = "lstPremier";
            this.lstPremier.Size = new System.Drawing.Size(292, 364);
            this.lstPremier.TabIndex = 1;
            this.lstPremier.SelectedIndexChanged += new System.EventHandler(this.lstPremier_SelectedIndexChanged);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(41, 27);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(38, 15);
            this.name.TabIndex = 2;
            this.name.Text = "label1";
            // 
            // lifeLable
            // 
            this.lifeLable.AutoSize = true;
            this.lifeLable.Location = new System.Drawing.Point(41, 228);
            this.lifeLable.Name = "lifeLable";
            this.lifeLable.Size = new System.Drawing.Size(38, 15);
            this.lifeLable.TabIndex = 3;
            this.lifeLable.Text = "label1";
            // 
            // startEndLabel
            // 
            this.startEndLabel.AutoSize = true;
            this.startEndLabel.Location = new System.Drawing.Point(41, 260);
            this.startEndLabel.Name = "startEndLabel";
            this.startEndLabel.Size = new System.Drawing.Size(38, 15);
            this.startEndLabel.TabIndex = 4;
            this.startEndLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 510);
            this.Controls.Add(this.startEndLabel);
            this.Controls.Add(this.lifeLable);
            this.Controls.Add(this.name);
            this.Controls.Add(this.lstPremier);
            this.Controls.Add(this.picPremier);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPremier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPremier;
        private System.Windows.Forms.ListBox lstPremier;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label lifeLable;
        private System.Windows.Forms.Label startEndLabel;
    }
}

