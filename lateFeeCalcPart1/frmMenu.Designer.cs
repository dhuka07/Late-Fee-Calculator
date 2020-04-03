namespace lateFeeCalcPart1
{
    partial class frmMenu
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
            this.Late_Fee_Calculator = new System.Windows.Forms.Label();
            this.btnNewRelease = new System.Windows.Forms.Button();
            this.btnLibraryMovie = new System.Windows.Forms.Button();
            this.btnKidsMovie = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Late_Fee_Calculator
            // 
            this.Late_Fee_Calculator.AutoSize = true;
            this.Late_Fee_Calculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Late_Fee_Calculator.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Late_Fee_Calculator.Location = new System.Drawing.Point(90, 42);
            this.Late_Fee_Calculator.Name = "Late_Fee_Calculator";
            this.Late_Fee_Calculator.Size = new System.Drawing.Size(219, 25);
            this.Late_Fee_Calculator.TabIndex = 0;
            this.Late_Fee_Calculator.Text = "Late Fee Calculator";
            // 
            // btnNewRelease
            // 
            this.btnNewRelease.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewRelease.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnNewRelease.Location = new System.Drawing.Point(128, 114);
            this.btnNewRelease.Name = "btnNewRelease";
            this.btnNewRelease.Size = new System.Drawing.Size(116, 44);
            this.btnNewRelease.TabIndex = 1;
            this.btnNewRelease.Text = "&New Release";
            this.btnNewRelease.UseVisualStyleBackColor = true;
            this.btnNewRelease.Click += new System.EventHandler(this.btnNewRelease_Click);
            // 
            // btnLibraryMovie
            // 
            this.btnLibraryMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibraryMovie.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnLibraryMovie.Location = new System.Drawing.Point(128, 198);
            this.btnLibraryMovie.Name = "btnLibraryMovie";
            this.btnLibraryMovie.Size = new System.Drawing.Size(116, 43);
            this.btnLibraryMovie.TabIndex = 2;
            this.btnLibraryMovie.Text = "&Library Movie";
            this.btnLibraryMovie.UseVisualStyleBackColor = true;
            this.btnLibraryMovie.Click += new System.EventHandler(this.btnLibraryMovie_Click);
            // 
            // btnKidsMovie
            // 
            this.btnKidsMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKidsMovie.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnKidsMovie.Location = new System.Drawing.Point(128, 283);
            this.btnKidsMovie.Name = "btnKidsMovie";
            this.btnKidsMovie.Size = new System.Drawing.Size(116, 44);
            this.btnKidsMovie.TabIndex = 3;
            this.btnKidsMovie.Text = "&Kids Movie";
            this.btnKidsMovie.UseVisualStyleBackColor = true;
            this.btnKidsMovie.Click += new System.EventHandler(this.btnKidsMovie_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnExit.Location = new System.Drawing.Point(128, 367);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(116, 42);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(404, 517);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnKidsMovie);
            this.Controls.Add(this.btnLibraryMovie);
            this.Controls.Add(this.btnNewRelease);
            this.Controls.Add(this.Late_Fee_Calculator);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Late_Fee_Calculator;
        private System.Windows.Forms.Button btnNewRelease;
        private System.Windows.Forms.Button btnLibraryMovie;
        private System.Windows.Forms.Button btnKidsMovie;
        private System.Windows.Forms.Button btnExit;
    }
}

