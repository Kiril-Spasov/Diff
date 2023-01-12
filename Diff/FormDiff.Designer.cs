namespace Diff
{
    partial class FormDiff
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
            this.BtnCalculateDiff = new System.Windows.Forms.Button();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnCalculateDiff
            // 
            this.BtnCalculateDiff.Location = new System.Drawing.Point(62, 58);
            this.BtnCalculateDiff.Name = "BtnCalculateDiff";
            this.BtnCalculateDiff.Size = new System.Drawing.Size(174, 58);
            this.BtnCalculateDiff.TabIndex = 0;
            this.BtnCalculateDiff.Text = "Calculate Difference";
            this.BtnCalculateDiff.UseVisualStyleBackColor = true;
            this.BtnCalculateDiff.Click += new System.EventHandler(this.BtnCalculateDiff_Click);
            // 
            // TxtResult
            // 
            this.TxtResult.Location = new System.Drawing.Point(277, 58);
            this.TxtResult.Multiline = true;
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.Size = new System.Drawing.Size(458, 318);
            this.TxtResult.TabIndex = 1;
            // 
            // FormDiff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtResult);
            this.Controls.Add(this.BtnCalculateDiff);
            this.Name = "FormDiff";
            this.Text = "Difference Count";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCalculateDiff;
        private System.Windows.Forms.TextBox TxtResult;
    }
}

