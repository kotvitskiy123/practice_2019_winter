namespace WindowsFormsApp1
{
    partial class fTown
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbSquare = new System.Windows.Forms.TextBox();
            this.tbYearIncome = new System.Windows.Forms.TextBox();
            this.tbPopulation = new System.Windows.Forms.TextBox();
            this.tbRegion = new System.Windows.Forms.TextBox();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chbHasPort = new System.Windows.Forms.CheckBox();
            this.chbHasAirport = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(337, 45);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(337, 96);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbSquare);
            this.groupBox1.Controls.Add(this.tbYearIncome);
            this.groupBox1.Controls.Add(this.tbPopulation);
            this.groupBox1.Controls.Add(this.tbRegion);
            this.groupBox1.Controls.Add(this.tbCountry);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 292);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "general data";
            // 
            // tbSquare
            // 
            this.tbSquare.Location = new System.Drawing.Point(171, 249);
            this.tbSquare.Name = "tbSquare";
            this.tbSquare.Size = new System.Drawing.Size(100, 20);
            this.tbSquare.TabIndex = 6;
            // 
            // tbYearIncome
            // 
            this.tbYearIncome.Location = new System.Drawing.Point(171, 208);
            this.tbYearIncome.Name = "tbYearIncome";
            this.tbYearIncome.Size = new System.Drawing.Size(100, 20);
            this.tbYearIncome.TabIndex = 5;
            // 
            // tbPopulation
            // 
            this.tbPopulation.Location = new System.Drawing.Point(171, 165);
            this.tbPopulation.Name = "tbPopulation";
            this.tbPopulation.Size = new System.Drawing.Size(100, 20);
            this.tbPopulation.TabIndex = 4;
            // 
            // tbRegion
            // 
            this.tbRegion.Location = new System.Drawing.Point(171, 111);
            this.tbRegion.Name = "tbRegion";
            this.tbRegion.Size = new System.Drawing.Size(100, 20);
            this.tbRegion.TabIndex = 3;
            // 
            // tbCountry
            // 
            this.tbCountry.Location = new System.Drawing.Point(171, 71);
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.Size = new System.Drawing.Size(100, 20);
            this.tbCountry.TabIndex = 2;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(171, 20);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = " Square кв.км";
           
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Year income. грн";
         
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Count of habitants";
         
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Region";
        
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Country";
     
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "City name";
       
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chbHasAirport);
            this.groupBox2.Controls.Add(this.chbHasPort);
            this.groupBox2.Location = new System.Drawing.Point(12, 350);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 162);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transport";
            // 
            // chbHasPort
            // 
            this.chbHasPort.AutoSize = true;
            this.chbHasPort.Location = new System.Drawing.Point(24, 43);
            this.chbHasPort.Name = "chbHasPort";
            this.chbHasPort.Size = new System.Drawing.Size(94, 17);
            this.chbHasPort.TabIndex = 0;
            this.chbHasPort.Text = "Town has port";
            this.chbHasPort.UseVisualStyleBackColor = true;
            // 
            // chbHasAirport
            // 
            this.chbHasAirport.AutoSize = true;
            this.chbHasAirport.Location = new System.Drawing.Point(24, 107);
            this.chbHasAirport.Name = "chbHasAirport";
            this.chbHasAirport.Size = new System.Drawing.Size(105, 17);
            this.chbHasAirport.TabIndex = 1;
            this.chbHasAirport.Text = "Town has airport";
            this.chbHasAirport.UseVisualStyleBackColor = true;
            // 
            // fTown
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(435, 542);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.MaximizeBox = false;
            this.Name = "fTown";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data about a new city";
            this.Load += new System.EventHandler(this.fTown_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSquare;
        private System.Windows.Forms.TextBox tbYearIncome;
        private System.Windows.Forms.TextBox tbPopulation;
        private System.Windows.Forms.TextBox tbRegion;
        private System.Windows.Forms.TextBox tbCountry;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chbHasAirport;
        private System.Windows.Forms.CheckBox chbHasPort;
    }
}