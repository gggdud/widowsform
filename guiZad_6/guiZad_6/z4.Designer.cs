
namespace guiZad_6
{
    partial class z4
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbN = new System.Windows.Forms.TextBox();
            this.labArr = new System.Windows.Forms.Label();
            this.labNew = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(447, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(302, 93);
            this.button1.TabIndex = 0;
            this.button1.Text = "Показать результат";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(30, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите размер массива NxN";
            // 
            // tbN
            // 
            this.tbN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbN.Location = new System.Drawing.Point(154, 83);
            this.tbN.Name = "tbN";
            this.tbN.Size = new System.Drawing.Size(100, 38);
            this.tbN.TabIndex = 2;
            // 
            // labArr
            // 
            this.labArr.AutoSize = true;
            this.labArr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labArr.Location = new System.Drawing.Point(56, 225);
            this.labArr.Name = "labArr";
            this.labArr.Size = new System.Drawing.Size(0, 25);
            this.labArr.TabIndex = 3;
            // 
            // labNew
            // 
            this.labNew.AutoSize = true;
            this.labNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labNew.Location = new System.Drawing.Point(486, 225);
            this.labNew.Name = "labNew";
            this.labNew.Size = new System.Drawing.Size(0, 25);
            this.labNew.TabIndex = 4;
            // 
            // z4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labNew);
            this.Controls.Add(this.labArr);
            this.Controls.Add(this.tbN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "z4";
            this.Text = "z4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbN;
        private System.Windows.Forms.Label labArr;
        private System.Windows.Forms.Label labNew;
    }
}