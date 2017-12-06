namespace Test
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
            this.btStart = new System.Windows.Forms.Button();
            this.lbText = new System.Windows.Forms.Label();
            this.bt_test = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(56, 106);
            this.btStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(101, 19);
            this.btStart.TabIndex = 0;
            this.btStart.Text = "Pokaż tekst";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.Location = new System.Drawing.Point(56, 41);
            this.lbText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(0, 13);
            this.lbText.TabIndex = 1;
            // 
            // bt_test
            // 
            this.bt_test.Location = new System.Drawing.Point(81, 228);
            this.bt_test.Name = "bt_test";
            this.bt_test.Size = new System.Drawing.Size(113, 23);
            this.bt_test.TabIndex = 2;
            this.bt_test.Text = "Koniec swiata";
            this.bt_test.UseVisualStyleBackColor = true;
            this.bt_test.Click += new System.EventHandler(this.bt_test_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 293);
            this.Controls.Add(this.bt_test);
            this.Controls.Add(this.lbText);
            this.Controls.Add(this.btStart);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.Button bt_test;
    }
}

