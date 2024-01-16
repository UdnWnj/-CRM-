namespace 補單系統
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.TxtmodiFier = new System.Windows.Forms.TextBox();
            this.TxtsE001 = new System.Windows.Forms.TextBox();
            this.TxtsE007 = new System.Windows.Forms.TextBox();
            this.TxtsE008 = new System.Windows.Forms.TextBox();
            this.TxtsE006 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtsE020 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "顧問",
            "個案"});
            this.cmbType.Location = new System.Drawing.Point(25, 53);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(121, 23);
            this.cmbType.TabIndex = 0;
            // 
            // TxtmodiFier
            // 
            this.TxtmodiFier.Location = new System.Drawing.Point(353, 28);
            this.TxtmodiFier.Name = "TxtmodiFier";
            this.TxtmodiFier.Size = new System.Drawing.Size(154, 23);
            this.TxtmodiFier.TabIndex = 1;
            // 
            // TxtsE001
            // 
            this.TxtsE001.Location = new System.Drawing.Point(273, 141);
            this.TxtsE001.Name = "TxtsE001";
            this.TxtsE001.Size = new System.Drawing.Size(154, 23);
            this.TxtsE001.TabIndex = 2;
            // 
            // TxtsE007
            // 
            this.TxtsE007.Location = new System.Drawing.Point(273, 170);
            this.TxtsE007.Name = "TxtsE007";
            this.TxtsE007.Size = new System.Drawing.Size(154, 23);
            this.TxtsE007.TabIndex = 3;
            // 
            // TxtsE008
            // 
            this.TxtsE008.Location = new System.Drawing.Point(273, 199);
            this.TxtsE008.Name = "TxtsE008";
            this.TxtsE008.Size = new System.Drawing.Size(154, 23);
            this.TxtsE008.TabIndex = 4;
            // 
            // TxtsE006
            // 
            this.TxtsE006.Location = new System.Drawing.Point(273, 228);
            this.TxtsE006.Name = "TxtsE006";
            this.TxtsE006.Size = new System.Drawing.Size(154, 23);
            this.TxtsE006.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "寫入人員工號(顧問系統帳號)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "底稿單號";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "出貨單號";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "訂購單號";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "底稿單身序號(A)";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(620, 137);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(155, 23);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "送出更改";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(433, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "序號請用01、02...方式填入";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(276, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "*請確保所填內容與顧問頁面資料皆相同在按下更新";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 336);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(509, 105);
            this.label8.TabIndex = 14;
            this.label8.Text = "*情境說明\r\n1.如有出貨單號單純補訂單，出貨單也需在打一次\r\n2.如有訂購單號單純補出貨，訂購單號也需在打一次\r\n3.底稿單身及單身序號輸入格式請用 01、 0" +
    "2..等方式填入\r\n4.底稿單身及單身序號非必填欄位，可自行判斷輸入，如不保險可以請秘書依照格式完整傳給你\r\n\r\n更新完請馬上至顧問系統查單。如有問題歡迎來信。" +
    "\r\n";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "作業名稱";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(161, 264);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "單身的單身序號(B)";
            // 
            // TxtsE020
            // 
            this.TxtsE020.Location = new System.Drawing.Point(273, 261);
            this.TxtsE020.Name = "TxtsE020";
            this.TxtsE020.Size = new System.Drawing.Size(154, 23);
            this.TxtsE020.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(433, 269);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 15);
            this.label11.TabIndex = 18;
            this.label11.Text = "序號請用01、02...方式填入";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(620, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "補已出貨(Y)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtsE020);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtsE006);
            this.Controls.Add(this.TxtsE008);
            this.Controls.Add(this.TxtsE007);
            this.Controls.Add(this.TxtsE001);
            this.Controls.Add(this.TxtmodiFier);
            this.Controls.Add(this.cmbType);
            this.Name = "Form1";
            this.Text = "補單系統";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbType;
        private TextBox TxtmodiFier;
        private TextBox TxtsE001;
        private TextBox TxtsE007;
        private TextBox TxtsE008;
        private TextBox TxtsE006;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnSubmit;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox TxtsE020;
        private Label label11;
        private Button button1;
    }
}