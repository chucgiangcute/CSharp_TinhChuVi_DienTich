namespace CSharp_TinhChuVi_DienTich
{
    partial class HINHCHUNHAT
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            chuvi = new Button();
            dientich = new Button();
            DT = new TextBox();
            CV = new TextBox();
            rong = new TextBox();
            dai = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Red;
            label1.Font = new Font("Tahoma", 10F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(333, 35);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(729, 33);
            label1.TabIndex = 0;
            label1.Text = "CHƯƠNG TRÌNH TÍNH CHU VI, DIỆN TÍCH HÌNH CHỮ NHẬT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 138);
            label2.Name = "label2";
            label2.Size = new Size(282, 48);
            label2.TabIndex = 1;
            label2.Text = "Nhập chiều dài";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 289);
            label3.Name = "label3";
            label3.Size = new Size(310, 48);
            label3.TabIndex = 1;
            label3.Text = "Nhập chiều rộng";
            label3.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(90, 432);
            label4.Name = "label4";
            label4.Size = new Size(233, 48);
            label4.TabIndex = 3;
            label4.Text = "CHU VI LÀ :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(90, 561);
            label5.Name = "label5";
            label5.Size = new Size(297, 48);
            label5.TabIndex = 3;
            label5.Text = "DIỆN TÍCH LÀ :";
            // 
            // chuvi
            // 
            chuvi.Location = new Point(983, 124);
            chuvi.Name = "chuvi";
            chuvi.Size = new Size(278, 62);
            chuvi.TabIndex = 4;
            chuvi.Text = "Tính chu vi";
            chuvi.UseVisualStyleBackColor = true;
            chuvi.Click += chuvi_Click;
            // 
            // dientich
            // 
            dientich.Location = new Point(983, 275);
            dientich.Name = "dientich";
            dientich.Size = new Size(278, 62);
            dientich.TabIndex = 4;
            dientich.Text = "Tính diện tích";
            dientich.UseVisualStyleBackColor = true;
            dientich.Click += dientich_Click;
            // 
            // DT
            // 
            DT.Location = new Point(404, 553);
            DT.Name = "DT";
            DT.Size = new Size(490, 56);
            DT.TabIndex = 5;
            // 
            // CV
            // 
            CV.Location = new Point(404, 424);
            CV.Name = "CV";
            CV.Size = new Size(490, 56);
            CV.TabIndex = 5;
            // 
            // rong
            // 
            rong.Location = new Point(481, 279);
            rong.Name = "rong";
            rong.Size = new Size(314, 56);
            rong.TabIndex = 5;
            // 
            // dai
            // 
            dai.Location = new Point(481, 138);
            dai.Name = "dai";
            dai.Size = new Size(314, 56);
            dai.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(983, 427);
            button1.Name = "button1";
            button1.Size = new Size(278, 58);
            button1.TabIndex = 6;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // HINHCHUNHAT
            // 
            AutoScaleDimensions = new SizeF(22F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1353, 676);
            Controls.Add(button1);
            Controls.Add(rong);
            Controls.Add(dai);
            Controls.Add(CV);
            Controls.Add(DT);
            Controls.Add(dientich);
            Controls.Add(chuvi);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 15F);
            Margin = new Padding(6, 5, 6, 5);
            Name = "HINHCHUNHAT";
            Text = "HINHCHUNHAT";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button chuvi;
        private Button dientich;
        private TextBox DT;
        private TextBox CV;
        private TextBox rong;
        private TextBox dai;
        private Button button1;
    }
}