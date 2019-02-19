namespace WindowsFormsApp1
{
    partial class fMain
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
            this.btnAddTown = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbTownsInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAddTown
            // 
            this.btnAddTown.Location = new System.Drawing.Point(659, 33);
            this.btnAddTown.Name = "btnAddTown";
            this.btnAddTown.Size = new System.Drawing.Size(75, 23);
            this.btnAddTown.TabIndex = 0;
            this.btnAddTown.Text = "Add town";
            this.btnAddTown.UseVisualStyleBackColor = true;
            this.btnAddTown.Click += new System.EventHandler(this.btnAddTown_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(659, 343);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbTownsInfo
            // 
            this.tbTownsInfo.Location = new System.Drawing.Point(53, 33);
            this.tbTownsInfo.Multiline = true;
            this.tbTownsInfo.Name = "tbTownsInfo";
            this.tbTownsInfo.ReadOnly = true;
            this.tbTownsInfo.Size = new System.Drawing.Size(547, 333);
            this.tbTownsInfo.TabIndex = 2;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 409);
            this.Controls.Add(this.tbTownsInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddTown);
            this.MaximizeBox = false;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddTown;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tbTownsInfo;
    }
}

