namespace StatisticsApp
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
            this.lblMean = new System.Windows.Forms.Label();
            this.SDlbl = new System.Windows.Forms.Label();
            this.lblMeanResult = new System.Windows.Forms.Label();
            this.lblStdDeviation = new System.Windows.Forms.Label();
            this.lblHistogram = new System.Windows.Forms.Label();
            this.lblHistogramResults = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMean
            // 
            this.lblMean.AutoSize = true;
            this.lblMean.Location = new System.Drawing.Point(50, 47);
            this.lblMean.Name = "lblMean";
            this.lblMean.Size = new System.Drawing.Size(73, 29);
            this.lblMean.TabIndex = 0;
            this.lblMean.Text = "Mean";
            // 
            // SDlbl
            // 
            this.SDlbl.AutoSize = true;
            this.SDlbl.Location = new System.Drawing.Point(50, 127);
            this.SDlbl.Name = "SDlbl";
            this.SDlbl.Size = new System.Drawing.Size(213, 29);
            this.SDlbl.TabIndex = 1;
            this.SDlbl.Text = "Standard deviation";
            // 
            // lblMeanResult
            // 
            this.lblMeanResult.AutoSize = true;
            this.lblMeanResult.Location = new System.Drawing.Point(271, 47);
            this.lblMeanResult.Name = "lblMeanResult";
            this.lblMeanResult.Size = new System.Drawing.Size(0, 29);
            this.lblMeanResult.TabIndex = 4;
            // 
            // lblStdDeviation
            // 
            this.lblStdDeviation.AutoSize = true;
            this.lblStdDeviation.Location = new System.Drawing.Point(296, 127);
            this.lblStdDeviation.Name = "lblStdDeviation";
            this.lblStdDeviation.Size = new System.Drawing.Size(0, 29);
            this.lblStdDeviation.TabIndex = 5;
            // 
            // lblHistogram
            // 
            this.lblHistogram.AutoSize = true;
            this.lblHistogram.Location = new System.Drawing.Point(50, 226);
            this.lblHistogram.Name = "lblHistogram";
            this.lblHistogram.Size = new System.Drawing.Size(123, 29);
            this.lblHistogram.TabIndex = 6;
            this.lblHistogram.Text = "Histogram";
            // 
            // lblHistogramResults
            // 
            this.lblHistogramResults.AutoSize = true;
            this.lblHistogramResults.Location = new System.Drawing.Point(61, 283);
            this.lblHistogramResults.Name = "lblHistogramResults";
            this.lblHistogramResults.Size = new System.Drawing.Size(0, 29);
            this.lblHistogramResults.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 764);
            this.Controls.Add(this.lblHistogramResults);
            this.Controls.Add(this.lblHistogram);
            this.Controls.Add(this.lblStdDeviation);
            this.Controls.Add(this.lblMeanResult);
            this.Controls.Add(this.SDlbl);
            this.Controls.Add(this.lblMean);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMean;
        private System.Windows.Forms.Label SDlbl;
        private System.Windows.Forms.Label lblMeanResult;
        private System.Windows.Forms.Label lblStdDeviation;
        private System.Windows.Forms.Label lblHistogram;
        private System.Windows.Forms.Label lblHistogramResults;
    }
}

