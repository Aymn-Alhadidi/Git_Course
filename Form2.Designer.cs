namespace Remembering_Numbers
{
    partial class StatsForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbNumOfQues = new System.Windows.Forms.Label();
            this.lbNumOfRightQues = new System.Windows.Forms.Label();
            this.lbNumOfWrongQues = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number Of Question: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(380, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number Of Right Question: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(399, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number Of Wrong Question: ";
            // 
            // lbNumOfQues
            // 
            this.lbNumOfQues.AutoSize = true;
            this.lbNumOfQues.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumOfQues.Location = new System.Drawing.Point(451, 85);
            this.lbNumOfQues.Name = "lbNumOfQues";
            this.lbNumOfQues.Size = new System.Drawing.Size(32, 36);
            this.lbNumOfQues.TabIndex = 3;
            this.lbNumOfQues.Text = "0";
            // 
            // lbNumOfRightQues
            // 
            this.lbNumOfRightQues.AutoSize = true;
            this.lbNumOfRightQues.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumOfRightQues.Location = new System.Drawing.Point(451, 170);
            this.lbNumOfRightQues.Name = "lbNumOfRightQues";
            this.lbNumOfRightQues.Size = new System.Drawing.Size(32, 36);
            this.lbNumOfRightQues.TabIndex = 4;
            this.lbNumOfRightQues.Text = "0";
            // 
            // lbNumOfWrongQues
            // 
            this.lbNumOfWrongQues.AutoSize = true;
            this.lbNumOfWrongQues.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumOfWrongQues.Location = new System.Drawing.Point(451, 255);
            this.lbNumOfWrongQues.Name = "lbNumOfWrongQues";
            this.lbNumOfWrongQues.Size = new System.Drawing.Size(32, 36);
            this.lbNumOfWrongQues.TabIndex = 5;
            this.lbNumOfWrongQues.Text = "0";
            // 
            // StatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(513, 404);
            this.Controls.Add(this.lbNumOfWrongQues);
            this.Controls.Add(this.lbNumOfRightQues);
            this.Controls.Add(this.lbNumOfQues);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StatsForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.StatsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbNumOfQues;
        private System.Windows.Forms.Label lbNumOfRightQues;
        private System.Windows.Forms.Label lbNumOfWrongQues;
    }
}