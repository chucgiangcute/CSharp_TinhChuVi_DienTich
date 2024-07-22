namespace CSharp_TinhChuVi_DienTich
{
    partial class HINHTRON
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
            label1 = new Label();
            r = new Label();
            bankinhr = new TextBox();
            CV = new Label();
            DT = new Label();
            kqcv = new TextBox();
            kqdt = new TextBox();
            button2 = new Button();
            btncv = new Button();
            btndt = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(189, 44);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(1004, 48);
            label1.TabIndex = 0;
            label1.Text = "CHƯƠNG TRÌNH TÍNH CHU VI, DIỆN TÍCH HÌNH TRÒN";
            // 
            // r
            // 
            r.AutoSize = true;
            r.BackColor = Color.FromArgb(255, 128, 128);
            r.Location = new Point(46, 223);
            r.Name = "r";
            r.Size = new Size(333, 48);
            r.TabIndex = 1;
            r.Text = "Nhập bán kính (r)";
            // 
            // bankinhr
            // 
            bankinhr.Location = new Point(485, 215);
            bankinhr.Name = "bankinhr";
            bankinhr.Size = new Size(326, 56);
            bankinhr.TabIndex = 2;
            // 
            // CV
            // 
            CV.AutoSize = true;
            CV.Location = new Point(46, 391);
            CV.Name = "CV";
            CV.Size = new Size(233, 48);
            CV.TabIndex = 3;
            CV.Text = "CHU VI LÀ :";
            CV.Click += CV_Click;
            // 
            // DT
            // 
            DT.AutoSize = true;
            DT.Location = new Point(46, 525);
            DT.Name = "DT";
            DT.Size = new Size(297, 48);
            DT.TabIndex = 3;
            DT.Text = "DIỆN TÍCH LÀ :";
            // 
            // kqcv
            // 
            kqcv.Location = new Point(485, 383);
            kqcv.Name = "kqcv";
            kqcv.Size = new Size(326, 56);
            kqcv.TabIndex = 4;
            kqcv.TextChanged += kqcv_TextChanged;
            // 
            // kqdt
            // 
            kqdt.Location = new Point(485, 517);
            kqdt.Name = "kqdt";
            kqdt.Size = new Size(326, 56);
            kqdt.TabIndex = 4;
            // 
            // button2
            // 
            button2.ForeColor = Color.Black;
            button2.Location = new Point(954, 211);
            button2.Name = "button2";
            button2.Size = new Size(249, 60);
            button2.TabIndex = 7;
            button2.Text = "THOÁT";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btncv
            // 
            btncv.ForeColor = Color.Black;
            btncv.Location = new Point(954, 383);
            btncv.Name = "btncv";
            btncv.Size = new Size(249, 62);
            btncv.TabIndex = 8;
            btncv.Text = "Tính chu vi";
            btncv.UseVisualStyleBackColor = true;
            btncv.Click += btncv_Click;
            // 
            // btndt
            // 
            btndt.ForeColor = Color.Black;
            btndt.Location = new Point(954, 511);
            btndt.Name = "btndt";
            btndt.Size = new Size(289, 62);
            btndt.TabIndex = 8;
            btndt.Text = "Tính diện tích";
            btndt.UseVisualStyleBackColor = true;
            btndt.Click += btndt_Click;
            // 
            // HINHTRON
            // 
            AutoScaleDimensions = new SizeF(22F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 0);
            ClientSize = new Size(1353, 676);
            Controls.Add(btndt);
            Controls.Add(btncv);
            Controls.Add(button2);
            Controls.Add(kqdt);
            Controls.Add(kqcv);
            Controls.Add(DT);
            Controls.Add(CV);
            Controls.Add(bankinhr);
            Controls.Add(r);
            Controls.Add(label1);
            Font = new Font("Tahoma", 15F);
            ForeColor = Color.White;
            Margin = new Padding(6, 5, 6, 5);
            Name = "HINHTRON";
            Text = "HINHTRON";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label r;
        private TextBox bankinhr;
        private Label CV;
        private Label DT;
        private TextBox kqcv;
        private TextBox kqdt;
        private Button button2;
        private Button btncv;
        private Button btndt;
    }
}