namespace DormAndMealPlan
{
    partial class Plans
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
            this.radioButtonAllenHall = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonPikeHall = new System.Windows.Forms.RadioButton();
            this.radioButtonFarthingHall = new System.Windows.Forms.RadioButton();
            this.radioButtonUniversitySuites = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // radioButtonAllenHall
            // 
            this.radioButtonAllenHall.AutoSize = true;
            this.radioButtonAllenHall.Location = new System.Drawing.Point(94, 59);
            this.radioButtonAllenHall.Name = "radioButtonAllenHall";
            this.radioButtonAllenHall.Size = new System.Drawing.Size(168, 17);
            this.radioButtonAllenHall.TabIndex = 0;
            this.radioButtonAllenHall.TabStop = true;
            this.radioButtonAllenHall.Text = "Allen Hall $1,500 per semester";
            this.radioButtonAllenHall.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select a Dorm Plan:";
            // 
            // radioButtonPikeHall
            // 
            this.radioButtonPikeHall.AutoSize = true;
            this.radioButtonPikeHall.Location = new System.Drawing.Point(94, 93);
            this.radioButtonPikeHall.Name = "radioButtonPikeHall";
            this.radioButtonPikeHall.Size = new System.Drawing.Size(166, 17);
            this.radioButtonPikeHall.TabIndex = 2;
            this.radioButtonPikeHall.TabStop = true;
            this.radioButtonPikeHall.Text = "Pike Hall $1,600 per semester";
            this.radioButtonPikeHall.UseVisualStyleBackColor = true;
            // 
            // radioButtonFarthingHall
            // 
            this.radioButtonFarthingHall.AutoSize = true;
            this.radioButtonFarthingHall.Location = new System.Drawing.Point(94, 128);
            this.radioButtonFarthingHall.Name = "radioButtonFarthingHall";
            this.radioButtonFarthingHall.Size = new System.Drawing.Size(183, 17);
            this.radioButtonFarthingHall.TabIndex = 3;
            this.radioButtonFarthingHall.TabStop = true;
            this.radioButtonFarthingHall.Text = "Farthing Hall $1,800 per semester";
            this.radioButtonFarthingHall.UseVisualStyleBackColor = true;
            // 
            // radioButtonUniversitySuites
            // 
            this.radioButtonUniversitySuites.AutoSize = true;
            this.radioButtonUniversitySuites.Location = new System.Drawing.Point(94, 162);
            this.radioButtonUniversitySuites.Name = "radioButtonUniversitySuites";
            this.radioButtonUniversitySuites.Size = new System.Drawing.Size(202, 17);
            this.radioButtonUniversitySuites.TabIndex = 4;
            this.radioButtonUniversitySuites.TabStop = true;
            this.radioButtonUniversitySuites.Text = "University Suites $2,500 per semester";
            this.radioButtonUniversitySuites.UseVisualStyleBackColor = true;
            // 
            // Plans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButtonUniversitySuites);
            this.Controls.Add(this.radioButtonFarthingHall);
            this.Controls.Add(this.radioButtonPikeHall);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonAllenHall);
            this.Name = "Plans";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonAllenHall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonPikeHall;
        private System.Windows.Forms.RadioButton radioButtonFarthingHall;
        private System.Windows.Forms.RadioButton radioButtonUniversitySuites;
    }
}

