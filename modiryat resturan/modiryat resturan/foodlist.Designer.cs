namespace modiryat_resturan
{
    partial class foodlist
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.butten1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(354, 342);
            this.listBox1.TabIndex = 0;
            // 
            // butten1
            // 
            this.butten1.Location = new System.Drawing.Point(13, 375);
            this.butten1.Name = "butten1";
            this.butten1.Size = new System.Drawing.Size(354, 63);
            this.butten1.TabIndex = 1;
            this.butten1.Text = "حذف";
            this.butten1.UseVisualStyleBackColor = true;
            this.butten1.Click += new System.EventHandler(this.butten1_Click);
            // 
            // foodlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butten1);
            this.Controls.Add(this.listBox1);
            this.Name = "foodlist";
            this.Text = "foodlist";
            this.Load += new System.EventHandler(this.foodlist_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button butten1;
    }
}