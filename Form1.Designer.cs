namespace Remembering_Numbers
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNew = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbNumOfDigits = new System.Windows.Forms.ComboBox();
            this.lbTimeLeft = new System.Windows.Forms.Label();
            this.btnStats = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRandNumber = new System.Windows.Forms.MaskedTextBox();
            this.txtPlayerAnswer = new System.Windows.Forms.MaskedTextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.panelNumbers = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panelNumbers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbNumOfDigits);
            this.panel1.Controls.Add(this.lbTimeLeft);
            this.panel1.Controls.Add(this.btnStats);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-9, -13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 120);
            this.panel1.TabIndex = 0;
            // 
            // btnNew
            // 
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(313, 19);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(127, 31);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "NEW";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(373, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "DIGITS";
            // 
            // cbNumOfDigits
            // 
            this.cbNumOfDigits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNumOfDigits.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNumOfDigits.FormattingEnabled = true;
            this.cbNumOfDigits.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "8"});
            this.cbNumOfDigits.Location = new System.Drawing.Point(471, 77);
            this.cbNumOfDigits.Name = "cbNumOfDigits";
            this.cbNumOfDigits.Size = new System.Drawing.Size(102, 28);
            this.cbNumOfDigits.TabIndex = 1;
            this.cbNumOfDigits.SelectedIndexChanged += new System.EventHandler(this.cbNumOfDigits_SelectedIndexChanged);
            // 
            // lbTimeLeft
            // 
            this.lbTimeLeft.AutoSize = true;
            this.lbTimeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeLeft.Location = new System.Drawing.Point(21, 80);
            this.lbTimeLeft.Name = "lbTimeLeft";
            this.lbTimeLeft.Size = new System.Drawing.Size(93, 25);
            this.lbTimeLeft.TabIndex = 2;
            this.lbTimeLeft.Text = "Time Left";
            // 
            // btnStats
            // 
            this.btnStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStats.Location = new System.Drawing.Point(446, 19);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(127, 31);
            this.btnStats.TabIndex = 1;
            this.btnStats.Text = "STATS";
            this.btnStats.UseVisualStyleBackColor = true;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number Blink";
            // 
            // txtRandNumber
            // 
            this.txtRandNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRandNumber.Location = new System.Drawing.Point(130, 137);
            this.txtRandNumber.Name = "txtRandNumber";
            this.txtRandNumber.ReadOnly = true;
            this.txtRandNumber.Size = new System.Drawing.Size(302, 45);
            this.txtRandNumber.TabIndex = 1;
            this.txtRandNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRandNumber.ValidatingType = typeof(System.DateTime);
            // 
            // txtPlayerAnswer
            // 
            this.txtPlayerAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerAnswer.Location = new System.Drawing.Point(130, 205);
            this.txtPlayerAnswer.Name = "txtPlayerAnswer";
            this.txtPlayerAnswer.Size = new System.Drawing.Size(302, 45);
            this.txtPlayerAnswer.TabIndex = 2;
            this.txtPlayerAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPlayerAnswer.ValidatingType = typeof(System.DateTime);
            // 
            // btnShow
            // 
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(59, 489);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(127, 48);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "SHOW";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnHide
            // 
            this.btnHide.Enabled = false;
            this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHide.Location = new System.Drawing.Point(227, 489);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(127, 48);
            this.btnHide.TabIndex = 4;
            this.btnHide.Text = "HIDE";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnDone
            // 
            this.btnDone.Enabled = false;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Location = new System.Drawing.Point(395, 489);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(127, 48);
            this.btnDone.TabIndex = 5;
            this.btnDone.Text = "DONE";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // panelNumbers
            // 
            this.panelNumbers.Controls.Add(this.btnDelete);
            this.panelNumbers.Controls.Add(this.btnClear);
            this.panelNumbers.Controls.Add(this.btn0);
            this.panelNumbers.Controls.Add(this.btn9);
            this.panelNumbers.Controls.Add(this.btn8);
            this.panelNumbers.Controls.Add(this.btn7);
            this.panelNumbers.Controls.Add(this.btn6);
            this.panelNumbers.Controls.Add(this.btn5);
            this.panelNumbers.Controls.Add(this.btn4);
            this.panelNumbers.Controls.Add(this.btn3);
            this.panelNumbers.Controls.Add(this.btn2);
            this.panelNumbers.Controls.Add(this.btn1);
            this.panelNumbers.Location = new System.Drawing.Point(108, 270);
            this.panelNumbers.Name = "panelNumbers";
            this.panelNumbers.Size = new System.Drawing.Size(348, 192);
            this.panelNumbers.TabIndex = 6;
            this.panelNumbers.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Goldenrod;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(44, 134);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 39);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Goldenrod;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(196, 134);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(105, 39);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.Goldenrod;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Location = new System.Drawing.Point(281, 71);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(44, 44);
            this.btn0.TabIndex = 9;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Goldenrod;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Location = new System.Drawing.Point(217, 71);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(44, 44);
            this.btn9.TabIndex = 8;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Goldenrod;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Location = new System.Drawing.Point(151, 71);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(44, 44);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Goldenrod;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Location = new System.Drawing.Point(86, 71);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(44, 44);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Goldenrod;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Location = new System.Drawing.Point(21, 71);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(44, 44);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Goldenrod;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Location = new System.Drawing.Point(281, 16);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(44, 44);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Goldenrod;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Location = new System.Drawing.Point(216, 16);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(44, 44);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Goldenrod;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Location = new System.Drawing.Point(151, 16);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(44, 44);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Goldenrod;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Location = new System.Drawing.Point(86, 16);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(44, 44);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Goldenrod;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Location = new System.Drawing.Point(21, 16);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(44, 44);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 575);
            this.Controls.Add(this.panelNumbers);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.txtPlayerAnswer);
            this.Controls.Add(this.txtRandNumber);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelNumbers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.Label lbTimeLeft;
        private System.Windows.Forms.ComboBox cbNumOfDigits;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.MaskedTextBox txtRandNumber;
        private System.Windows.Forms.MaskedTextBox txtPlayerAnswer;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Panel panelNumbers;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

