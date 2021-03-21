
namespace Interface
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
            this.lbplants = new System.Windows.Forms.ListBox();
            this.btnShowPlants = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbplants
            // 
            this.lbplants.FormattingEnabled = true;
            this.lbplants.ItemHeight = 16;
            this.lbplants.Location = new System.Drawing.Point(52, 47);
            this.lbplants.Name = "lbplants";
            this.lbplants.Size = new System.Drawing.Size(234, 308);
            this.lbplants.TabIndex = 0;
            // 
            // btnShowPlants
            // 
            this.btnShowPlants.Location = new System.Drawing.Point(470, 113);
            this.btnShowPlants.Name = "btnShowPlants";
            this.btnShowPlants.Size = new System.Drawing.Size(141, 58);
            this.btnShowPlants.TabIndex = 1;
            this.btnShowPlants.Text = "Show Plants";
            this.btnShowPlants.UseVisualStyleBackColor = true;
            this.btnShowPlants.Click += new System.EventHandler(this.btnShowPlants_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowPlants);
            this.Controls.Add(this.lbplants);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbplants;
        private System.Windows.Forms.Button btnShowPlants;
    }
}

