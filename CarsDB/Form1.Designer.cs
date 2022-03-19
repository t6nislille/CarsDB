namespace CarsDB
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
            this.label1 = new System.Windows.Forms.Label();
            this.listCarsInGarage = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listCarNames = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "CarsInGarage";
            // 
            // listCarsInGarage
            // 
            this.listCarsInGarage.FormattingEnabled = true;
            this.listCarsInGarage.ItemHeight = 16;
            this.listCarsInGarage.Location = new System.Drawing.Point(118, 141);
            this.listCarsInGarage.Name = "listCarsInGarage";
            this.listCarsInGarage.Size = new System.Drawing.Size(120, 84);
            this.listCarsInGarage.TabIndex = 1;
            this.listCarsInGarage.SelectedIndexChanged += new System.EventHandler(this.listCarsInGarage_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Car Names";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // listCarNames
            // 
            this.listCarNames.FormattingEnabled = true;
            this.listCarNames.ItemHeight = 16;
            this.listCarNames.Location = new System.Drawing.Point(354, 141);
            this.listCarNames.Name = "listCarNames";
            this.listCarNames.Size = new System.Drawing.Size(120, 84);
            this.listCarNames.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listCarNames);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listCarsInGarage);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listCarsInGarage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listCarNames;
    }
}

