namespace QuanTriHeThong
{
    partial class TrangChuSA_Form
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
            this.btnQLDanhMucNgheNghiep = new System.Windows.Forms.Button();
            this.btnQLTaiKhoanNhanVien = new System.Windows.Forms.Button();
            this.btnQLQuyenHan = new System.Windows.Forms.Button();
            this.btnTraCuuDuLieu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Trị Hệ Thống (SA)";
            // 
            // btnQLDanhMucNgheNghiep
            // 
            this.btnQLDanhMucNgheNghiep.Location = new System.Drawing.Point(63, 59);
            this.btnQLDanhMucNgheNghiep.Name = "btnQLDanhMucNgheNghiep";
            this.btnQLDanhMucNgheNghiep.Size = new System.Drawing.Size(152, 66);
            this.btnQLDanhMucNgheNghiep.TabIndex = 1;
            this.btnQLDanhMucNgheNghiep.Text = "Quản lý danh mục nghề nghiệp";
            this.btnQLDanhMucNgheNghiep.UseVisualStyleBackColor = true;
            this.btnQLDanhMucNgheNghiep.Click += new System.EventHandler(this.btnQLDanhMucNgheNghiep_Click);
            // 
            // btnQLTaiKhoanNhanVien
            // 
            this.btnQLTaiKhoanNhanVien.Location = new System.Drawing.Point(63, 149);
            this.btnQLTaiKhoanNhanVien.Name = "btnQLTaiKhoanNhanVien";
            this.btnQLTaiKhoanNhanVien.Size = new System.Drawing.Size(152, 66);
            this.btnQLTaiKhoanNhanVien.TabIndex = 2;
            this.btnQLTaiKhoanNhanVien.Text = "Quản lý tài khoản nhân viên";
            this.btnQLTaiKhoanNhanVien.UseVisualStyleBackColor = true;
            this.btnQLTaiKhoanNhanVien.Click += new System.EventHandler(this.btnQLTaiKhoanNhanVien_Click);
            // 
            // btnQLQuyenHan
            // 
            this.btnQLQuyenHan.Location = new System.Drawing.Point(63, 245);
            this.btnQLQuyenHan.Name = "btnQLQuyenHan";
            this.btnQLQuyenHan.Size = new System.Drawing.Size(152, 66);
            this.btnQLQuyenHan.TabIndex = 3;
            this.btnQLQuyenHan.Text = "Quản lý quyền hạn sử dụng chức năng";
            this.btnQLQuyenHan.UseVisualStyleBackColor = true;
            this.btnQLQuyenHan.Click += new System.EventHandler(this.btnQLQuyenHan_Click);
            // 
            // btnTraCuuDuLieu
            // 
            this.btnTraCuuDuLieu.Location = new System.Drawing.Point(63, 327);
            this.btnTraCuuDuLieu.Name = "btnTraCuuDuLieu";
            this.btnTraCuuDuLieu.Size = new System.Drawing.Size(152, 66);
            this.btnTraCuuDuLieu.TabIndex = 4;
            this.btnTraCuuDuLieu.Text = "Tra cứu toàn bộ dữ liệu";
            this.btnTraCuuDuLieu.UseVisualStyleBackColor = true;
            this.btnTraCuuDuLieu.Click += new System.EventHandler(this.btnTraCuuDuLieu_Click);
            // 
            // TrangChuSA_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTraCuuDuLieu);
            this.Controls.Add(this.btnQLQuyenHan);
            this.Controls.Add(this.btnQLTaiKhoanNhanVien);
            this.Controls.Add(this.btnQLDanhMucNgheNghiep);
            this.Controls.Add(this.label1);
            this.Name = "TrangChuSA_Form";
            this.Text = "Quản trị hệ thống";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQLDanhMucNgheNghiep;
        private System.Windows.Forms.Button btnQLTaiKhoanNhanVien;
        private System.Windows.Forms.Button btnQLQuyenHan;
        private System.Windows.Forms.Button btnTraCuuDuLieu;
    }
}

