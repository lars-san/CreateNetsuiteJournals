namespace CreateNetsuiteJournals
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.dataBox1 = new System.Windows.Forms.TextBox();
            this.processButton = new System.Windows.Forms.Button();
            this.dataBox2 = new System.Windows.Forms.TextBox();
            this.dataBox3 = new System.Windows.Forms.TextBox();
            this.dataBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dataBox1
            // 
            this.dataBox1.AcceptsReturn = true;
            this.dataBox1.AcceptsTab = true;
            this.dataBox1.Location = new System.Drawing.Point(12, 12);
            this.dataBox1.Multiline = true;
            this.dataBox1.Name = "dataBox1";
            this.dataBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataBox1.Size = new System.Drawing.Size(360, 122);
            this.dataBox1.TabIndex = 0;
            // 
            // processButton
            // 
            this.processButton.Location = new System.Drawing.Point(496, 12);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(167, 41);
            this.processButton.TabIndex = 1;
            this.processButton.Text = "Process";
            this.processButton.UseVisualStyleBackColor = true;
            // 
            // dataBox2
            // 
            this.dataBox2.AcceptsReturn = true;
            this.dataBox2.AcceptsTab = true;
            this.dataBox2.Location = new System.Drawing.Point(12, 140);
            this.dataBox2.Multiline = true;
            this.dataBox2.Name = "dataBox2";
            this.dataBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataBox2.Size = new System.Drawing.Size(360, 122);
            this.dataBox2.TabIndex = 2;
            // 
            // dataBox3
            // 
            this.dataBox3.AcceptsReturn = true;
            this.dataBox3.AcceptsTab = true;
            this.dataBox3.Location = new System.Drawing.Point(12, 268);
            this.dataBox3.Multiline = true;
            this.dataBox3.Name = "dataBox3";
            this.dataBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataBox3.Size = new System.Drawing.Size(360, 122);
            this.dataBox3.TabIndex = 3;
            // 
            // dataBox4
            // 
            this.dataBox4.AcceptsReturn = true;
            this.dataBox4.AcceptsTab = true;
            this.dataBox4.Location = new System.Drawing.Point(12, 396);
            this.dataBox4.Multiline = true;
            this.dataBox4.Name = "dataBox4";
            this.dataBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataBox4.Size = new System.Drawing.Size(360, 122);
            this.dataBox4.TabIndex = 4;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 532);
            this.Controls.Add(this.dataBox4);
            this.Controls.Add(this.dataBox3);
            this.Controls.Add(this.dataBox2);
            this.Controls.Add(this.processButton);
            this.Controls.Add(this.dataBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.Text = "Netsuite Journal Utility";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dataBox1;
        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.TextBox dataBox2;
        private System.Windows.Forms.TextBox dataBox3;
        private System.Windows.Forms.TextBox dataBox4;
    }
}

