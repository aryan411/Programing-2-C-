namespace Final_Dixit_Hihoriya
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
            this.lstCity = new System.Windows.Forms.ListBox();
            this.picCity = new System.Windows.Forms.PictureBox();
            this.sortL = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.Label();
            this.country = new System.Windows.Forms.Label();
            this.dec = new System.Windows.Forms.Label();
            this.preB = new System.Windows.Forms.Button();
            this.loadB = new System.Windows.Forms.Button();
            this.nextB = new System.Windows.Forms.Button();
            this.sortBox = new System.Windows.Forms.ComboBox();
            this.sort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCity)).BeginInit();
            this.SuspendLayout();
            // 
            // lstCity
            // 
            this.lstCity.FormattingEnabled = true;
            this.lstCity.ItemHeight = 15;
            this.lstCity.Location = new System.Drawing.Point(682, 91);
            this.lstCity.Name = "lstCity";
            this.lstCity.Size = new System.Drawing.Size(232, 259);
            this.lstCity.TabIndex = 0;
            this.lstCity.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // picCity
            // 
            this.picCity.Location = new System.Drawing.Point(81, 91);
            this.picCity.Name = "picCity";
            this.picCity.Size = new System.Drawing.Size(517, 432);
            this.picCity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picCity.TabIndex = 1;
            this.picCity.TabStop = false;
            // 
            // sortL
            // 
            this.sortL.AutoSize = true;
            this.sortL.Location = new System.Drawing.Point(682, 38);
            this.sortL.Name = "sortL";
            this.sortL.Size = new System.Drawing.Size(74, 15);
            this.sortL.TabIndex = 2;
            this.sortL.Text = "Sort cities by";
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.Location = new System.Drawing.Point(174, 38);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(28, 15);
            this.city.TabIndex = 3;
            this.city.Text = "City";
            // 
            // country
            // 
            this.country.AutoSize = true;
            this.country.Location = new System.Drawing.Point(81, 562);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(50, 15);
            this.country.TabIndex = 4;
            this.country.Text = "Country";
            // 
            // dec
            // 
            this.dec.AutoSize = true;
            this.dec.Location = new System.Drawing.Point(370, 562);
            this.dec.Name = "dec";
            this.dec.Size = new System.Drawing.Size(67, 15);
            this.dec.TabIndex = 5;
            this.dec.Text = "Description";
            this.dec.Click += new System.EventHandler(this.label4_Click);
            // 
            // preB
            // 
            this.preB.Location = new System.Drawing.Point(81, 634);
            this.preB.Name = "preB";
            this.preB.Size = new System.Drawing.Size(75, 23);
            this.preB.TabIndex = 6;
            this.preB.Text = "Prev";
            this.preB.UseVisualStyleBackColor = true;
            this.preB.Click += new System.EventHandler(this.preB_Click);
            // 
            // loadB
            // 
            this.loadB.Location = new System.Drawing.Point(314, 634);
            this.loadB.Name = "loadB";
            this.loadB.Size = new System.Drawing.Size(75, 23);
            this.loadB.TabIndex = 7;
            this.loadB.Text = "Load";
            this.loadB.UseVisualStyleBackColor = true;
            this.loadB.Click += new System.EventHandler(this.loadB_Click);
            // 
            // nextB
            // 
            this.nextB.Location = new System.Drawing.Point(523, 634);
            this.nextB.Name = "nextB";
            this.nextB.Size = new System.Drawing.Size(75, 23);
            this.nextB.TabIndex = 8;
            this.nextB.Text = "Next";
            this.nextB.UseVisualStyleBackColor = true;
            this.nextB.Click += new System.EventHandler(this.nextB_Click);
            // 
            // sortBox
            // 
            this.sortBox.FormattingEnabled = true;
            this.sortBox.Location = new System.Drawing.Point(771, 38);
            this.sortBox.Name = "sortBox";
            this.sortBox.Size = new System.Drawing.Size(121, 23);
            this.sortBox.TabIndex = 9;
            this.sortBox.SelectedIndexChanged += new System.EventHandler(this.sortBox_SelectedIndexChanged);
            // 
            // sort
            // 
            this.sort.Location = new System.Drawing.Point(780, 499);
            this.sort.Name = "sort";
            this.sort.Size = new System.Drawing.Size(75, 23);
            this.sort.TabIndex = 10;
            this.sort.Text = "Sort";
            this.sort.UseVisualStyleBackColor = true;
            this.sort.Click += new System.EventHandler(this.sort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 706);
            this.Controls.Add(this.sort);
            this.Controls.Add(this.sortBox);
            this.Controls.Add(this.nextB);
            this.Controls.Add(this.loadB);
            this.Controls.Add(this.preB);
            this.Controls.Add(this.dec);
            this.Controls.Add(this.country);
            this.Controls.Add(this.city);
            this.Controls.Add(this.sortL);
            this.Controls.Add(this.picCity);
            this.Controls.Add(this.lstCity);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picCity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox picCity;
        private System.Windows.Forms.Label sortL;
        private System.Windows.Forms.Label city;
        private System.Windows.Forms.Label country;
        private System.Windows.Forms.Label dec;
        private System.Windows.Forms.Button preB;
        private System.Windows.Forms.Button loadB;
        private System.Windows.Forms.Button nextB;
        private System.Windows.Forms.ComboBox sortBox;
        private System.Windows.Forms.ListBox lstCity;
        private System.Windows.Forms.Button sort;
    }
}

