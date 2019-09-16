namespace DormAndMealPlan
{
    partial class Charges
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
            this.labelTotalCost = new System.Windows.Forms.Label();
            this.labelCharges = new System.Windows.Forms.Label();
            this.textBoxCharges = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTotalCost
            // 
            this.labelTotalCost.AutoSize = true;
            this.labelTotalCost.Location = new System.Drawing.Point(283, 58);
            this.labelTotalCost.Name = "labelTotalCost";
            this.labelTotalCost.Size = new System.Drawing.Size(215, 13);
            this.labelTotalCost.TabIndex = 0;
            this.labelTotalCost.Text = "The total cost of your dorm and meal plan is:";
            this.labelTotalCost.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelCharges
            // 
            this.labelCharges.AutoSize = true;
            this.labelCharges.Location = new System.Drawing.Point(369, 111);
            this.labelCharges.Name = "labelCharges";
            this.labelCharges.Size = new System.Drawing.Size(0, 13);
            this.labelCharges.TabIndex = 1;
            // 
            // textBoxCharges
            // 
            this.textBoxCharges.Location = new System.Drawing.Point(340, 104);
            this.textBoxCharges.Name = "textBoxCharges";
            this.textBoxCharges.Size = new System.Drawing.Size(100, 20);
            this.textBoxCharges.TabIndex = 2;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(353, 186);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // Charges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.textBoxCharges);
            this.Controls.Add(this.labelCharges);
            this.Controls.Add(this.labelTotalCost);
            this.Name = "Charges";
            this.ShowIcon = false;
            this.Text = "Charges";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTotalCost;
        private System.Windows.Forms.Label labelCharges;
        public System.Windows.Forms.TextBox textBoxCharges;
        private System.Windows.Forms.Button buttonClose;
    }
}