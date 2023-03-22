
namespace BaiTapLyThuyetBuoi2
{
    partial class frmListBox
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
            this.lblDanhSach = new System.Windows.Forms.Label();
            this.lblDanhSachChon = new System.Windows.Forms.Label();
            this.lbDanhSach = new System.Windows.Forms.ListBox();
            this.lbDanhSachChon = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDanhSach
            // 
            this.lblDanhSach.AutoSize = true;
            this.lblDanhSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblDanhSach.Location = new System.Drawing.Point(51, 46);
            this.lblDanhSach.Name = "lblDanhSach";
            this.lblDanhSach.Size = new System.Drawing.Size(176, 20);
            this.lblDanhSach.TabIndex = 0;
            this.lblDanhSach.Text = "Danh sách sinh viên lớp";
            // 
            // lblDanhSachChon
            // 
            this.lblDanhSachChon.AutoSize = true;
            this.lblDanhSachChon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblDanhSachChon.Location = new System.Drawing.Point(428, 46);
            this.lblDanhSachChon.Name = "lblDanhSachChon";
            this.lblDanhSachChon.Size = new System.Drawing.Size(278, 20);
            this.lblDanhSachChon.TabIndex = 1;
            this.lblDanhSachChon.Text = "Danh sách sinh viên tham gia bóng đá";
            // 
            // lbDanhSach
            // 
            this.lbDanhSach.FormattingEnabled = true;
            this.lbDanhSach.ItemHeight = 20;
            this.lbDanhSach.Items.AddRange(new object[] {
            "Pham Vu Ngoc Ha",
            "Hoang Van Hung",
            "Le Thi Van",
            "Nguyen Thi Thu",
            "Le Van Quoc",
            "Le Van Phuoc",
            "Truong Van Dung",
            "Tran The Anh",
            "Nguyen Thi Lan Huong"});
            this.lbDanhSach.Location = new System.Drawing.Point(12, 69);
            this.lbDanhSach.Name = "lbDanhSach";
            this.lbDanhSach.Size = new System.Drawing.Size(266, 344);
            this.lbDanhSach.TabIndex = 2;
            // 
            // lbDanhSachChon
            // 
            this.lbDanhSachChon.FormattingEnabled = true;
            this.lbDanhSachChon.ItemHeight = 20;
            this.lbDanhSachChon.Location = new System.Drawing.Point(432, 69);
            this.lbDanhSachChon.Name = "lbDanhSachChon";
            this.lbDanhSachChon.Size = new System.Drawing.Size(266, 344);
            this.lbDanhSachChon.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(305, 132);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 45);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Chọn";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(305, 234);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(92, 45);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // frmListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbDanhSachChon);
            this.Controls.Add(this.lbDanhSach);
            this.Controls.Add(this.lblDanhSachChon);
            this.Controls.Add(this.lblDanhSach);
            this.Name = "frmListBox";
            this.Text = "Demo ListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDanhSach;
        private System.Windows.Forms.Label lblDanhSachChon;
        private System.Windows.Forms.ListBox lbDanhSach;
        private System.Windows.Forms.ListBox lbDanhSachChon;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnXoa;
    }
}