
namespace guiZad_9
{
    partial class Form2
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
            this.tbLen = new System.Windows.Forms.TextBox();
            this.labS = new System.Windows.Forms.Label();
            this.labRes = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(42, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите длину нужной строки";
            // 
            // tbLen
            // 
            this.tbLen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLen.Location = new System.Drawing.Point(103, 70);
            this.tbLen.Name = "tbLen";
            this.tbLen.Size = new System.Drawing.Size(100, 27);
            this.tbLen.TabIndex = 1;
            // 
            // labS
            // 
            this.labS.AutoSize = true;
            this.labS.Location = new System.Drawing.Point(36, 163);
            this.labS.Name = "labS";
            this.labS.Size = new System.Drawing.Size(0, 17);
            this.labS.TabIndex = 2;
            // 
            // labRes
            // 
            this.labRes.AutoSize = true;
            this.labRes.Location = new System.Drawing.Point(417, 163);
            this.labRes.Name = "labRes";
            this.labRes.Size = new System.Drawing.Size(0, 17);
            this.labRes.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(502, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(268, 77);
            this.button1.TabIndex = 4;
            this.button1.Text = "Показать результат";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labRes);
            this.Controls.Add(this.labS);
            this.Controls.Add(this.tbLen);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLen;
        private System.Windows.Forms.Label labS;
        private System.Windows.Forms.Label labRes;
        private System.Windows.Forms.Button button1;
    }
}