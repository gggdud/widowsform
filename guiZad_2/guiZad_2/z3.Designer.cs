
namespace guiZad_2
{
    partial class z3
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
            this.labA = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbA = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labRes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labA
            // 
            this.labA.AutoSize = true;
            this.labA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labA.Location = new System.Drawing.Point(178, 32);
            this.labA.Name = "labA";
            this.labA.Size = new System.Drawing.Size(28, 29);
            this.labA.TabIndex = 0;
            this.labA.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(550, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "B";
            // 
            // tbA
            // 
            this.tbA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbA.Location = new System.Drawing.Point(141, 75);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(100, 34);
            this.tbA.TabIndex = 2;
            // 
            // tbB
            // 
            this.tbB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbB.Location = new System.Drawing.Point(516, 75);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(100, 34);
            this.tbB.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(288, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 87);
            this.button1.TabIndex = 4;
            this.button1.Text = "Результат";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labRes
            // 
            this.labRes.AutoSize = true;
            this.labRes.Location = new System.Drawing.Point(285, 258);
            this.labRes.Name = "labRes";
            this.labRes.Size = new System.Drawing.Size(0, 17);
            this.labRes.TabIndex = 5;
            // 
            // z3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labRes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labA);
            this.Name = "z3";
            this.Text = "z3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labRes;
    }
}