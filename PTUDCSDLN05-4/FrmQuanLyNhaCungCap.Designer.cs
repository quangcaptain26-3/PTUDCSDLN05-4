namespace PTUDCSDLN05_4
{
    partial class FrmQuanLyNhaCungCap
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_supplier_name = new System.Windows.Forms.TextBox();
            this.txt_supplier_address = new System.Windows.Forms.TextBox();
            this.txt_supplier_phone = new System.Windows.Forms.TextBox();
            this.dgv_supplier_load = new System.Windows.Forms.DataGridView();
            this.btn_supplier_add = new System.Windows.Forms.Button();
            this.btn_supplier_update = new System.Windows.Forms.Button();
            this.btn_supplier_delete = new System.Windows.Forms.Button();
            this.erp_supplier_error = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txt_find_supplier_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_find_supplier_address = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_find_supplier_phone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_find_supplier = new System.Windows.Forms.Button();
            this.colMaNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChiNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDienThoaiNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_supplier_load)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_supplier_error)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Nhà Cung Cấp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Điện thoại:";
            // 
            // txt_supplier_name
            // 
            this.txt_supplier_name.Location = new System.Drawing.Point(421, 115);
            this.txt_supplier_name.Name = "txt_supplier_name";
            this.txt_supplier_name.Size = new System.Drawing.Size(224, 22);
            this.txt_supplier_name.TabIndex = 3;
            // 
            // txt_supplier_address
            // 
            this.txt_supplier_address.Location = new System.Drawing.Point(421, 143);
            this.txt_supplier_address.Name = "txt_supplier_address";
            this.txt_supplier_address.Size = new System.Drawing.Size(224, 22);
            this.txt_supplier_address.TabIndex = 4;
            // 
            // txt_supplier_phone
            // 
            this.txt_supplier_phone.Location = new System.Drawing.Point(421, 171);
            this.txt_supplier_phone.Name = "txt_supplier_phone";
            this.txt_supplier_phone.Size = new System.Drawing.Size(224, 22);
            this.txt_supplier_phone.TabIndex = 5;
            // 
            // dgv_supplier_load
            // 
            this.dgv_supplier_load.AllowUserToAddRows = false;
            this.dgv_supplier_load.AllowUserToDeleteRows = false;
            this.dgv_supplier_load.AllowUserToOrderColumns = true;
            this.dgv_supplier_load.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_supplier_load.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaNhaCungCap,
            this.colTenNhaCungCap,
            this.colDiaChiNhaCungCap,
            this.colDienThoaiNhaCungCap});
            this.dgv_supplier_load.Location = new System.Drawing.Point(271, 288);
            this.dgv_supplier_load.Name = "dgv_supplier_load";
            this.dgv_supplier_load.RowHeadersWidth = 51;
            this.dgv_supplier_load.RowTemplate.Height = 24;
            this.dgv_supplier_load.Size = new System.Drawing.Size(735, 332);
            this.dgv_supplier_load.TabIndex = 6;
            this.dgv_supplier_load.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_supplier_load_RowEnter);
            // 
            // btn_supplier_add
            // 
            this.btn_supplier_add.Location = new System.Drawing.Point(271, 215);
            this.btn_supplier_add.Name = "btn_supplier_add";
            this.btn_supplier_add.Size = new System.Drawing.Size(110, 46);
            this.btn_supplier_add.TabIndex = 7;
            this.btn_supplier_add.Text = "Add";
            this.btn_supplier_add.UseVisualStyleBackColor = true;
            this.btn_supplier_add.Click += new System.EventHandler(this.btn_supplier_add_Click);
            // 
            // btn_supplier_update
            // 
            this.btn_supplier_update.Location = new System.Drawing.Point(472, 215);
            this.btn_supplier_update.Name = "btn_supplier_update";
            this.btn_supplier_update.Size = new System.Drawing.Size(110, 46);
            this.btn_supplier_update.TabIndex = 8;
            this.btn_supplier_update.Text = "Update";
            this.btn_supplier_update.UseVisualStyleBackColor = true;
            this.btn_supplier_update.Click += new System.EventHandler(this.btn_supplier_update_Click);
            // 
            // btn_supplier_delete
            // 
            this.btn_supplier_delete.Location = new System.Drawing.Point(684, 215);
            this.btn_supplier_delete.Name = "btn_supplier_delete";
            this.btn_supplier_delete.Size = new System.Drawing.Size(110, 46);
            this.btn_supplier_delete.TabIndex = 9;
            this.btn_supplier_delete.Text = "Delete";
            this.btn_supplier_delete.UseVisualStyleBackColor = true;
            this.btn_supplier_delete.Click += new System.EventHandler(this.btn_supplier_delete_Click);
            // 
            // erp_supplier_error
            // 
            this.erp_supplier_error.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tìm kiếm:";
            // 
            // txt_find_supplier_name
            // 
            this.txt_find_supplier_name.Location = new System.Drawing.Point(12, 94);
            this.txt_find_supplier_name.Name = "txt_find_supplier_name";
            this.txt_find_supplier_name.Size = new System.Drawing.Size(202, 22);
            this.txt_find_supplier_name.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tên nhà cung cấp cần tìm:";
            // 
            // txt_find_supplier_address
            // 
            this.txt_find_supplier_address.Location = new System.Drawing.Point(12, 140);
            this.txt_find_supplier_address.Name = "txt_find_supplier_address";
            this.txt_find_supplier_address.Size = new System.Drawing.Size(202, 22);
            this.txt_find_supplier_address.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Địa chỉ:";
            // 
            // txt_find_supplier_phone
            // 
            this.txt_find_supplier_phone.Location = new System.Drawing.Point(12, 196);
            this.txt_find_supplier_phone.Name = "txt_find_supplier_phone";
            this.txt_find_supplier_phone.Size = new System.Drawing.Size(202, 22);
            this.txt_find_supplier_phone.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Điện thoại";
            // 
            // btn_find_supplier
            // 
            this.btn_find_supplier.Location = new System.Drawing.Point(12, 224);
            this.btn_find_supplier.Name = "btn_find_supplier";
            this.btn_find_supplier.Size = new System.Drawing.Size(110, 46);
            this.btn_find_supplier.TabIndex = 17;
            this.btn_find_supplier.Text = "Search";
            this.btn_find_supplier.UseVisualStyleBackColor = true;
            this.btn_find_supplier.Click += new System.EventHandler(this.btn_find_supplier_Click);
            // 
            // colMaNhaCungCap
            // 
            this.colMaNhaCungCap.DataPropertyName = "MaNhaCungCap";
            this.colMaNhaCungCap.HeaderText = "Mã Nhà Cung Cấp";
            this.colMaNhaCungCap.MinimumWidth = 6;
            this.colMaNhaCungCap.Name = "colMaNhaCungCap";
            this.colMaNhaCungCap.ReadOnly = true;
            this.colMaNhaCungCap.Width = 125;
            // 
            // colTenNhaCungCap
            // 
            this.colTenNhaCungCap.DataPropertyName = "TenNhaCungCap";
            this.colTenNhaCungCap.HeaderText = "Tên Nhà Cung Cấp";
            this.colTenNhaCungCap.MinimumWidth = 6;
            this.colTenNhaCungCap.Name = "colTenNhaCungCap";
            this.colTenNhaCungCap.ReadOnly = true;
            this.colTenNhaCungCap.Width = 125;
            // 
            // colDiaChiNhaCungCap
            // 
            this.colDiaChiNhaCungCap.DataPropertyName = "DiaChi";
            this.colDiaChiNhaCungCap.HeaderText = "Địa Chỉ";
            this.colDiaChiNhaCungCap.MinimumWidth = 6;
            this.colDiaChiNhaCungCap.Name = "colDiaChiNhaCungCap";
            this.colDiaChiNhaCungCap.ReadOnly = true;
            this.colDiaChiNhaCungCap.Width = 125;
            // 
            // colDienThoaiNhaCungCap
            // 
            this.colDienThoaiNhaCungCap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDienThoaiNhaCungCap.DataPropertyName = "DienThoai";
            this.colDienThoaiNhaCungCap.HeaderText = "Điện Thoại";
            this.colDienThoaiNhaCungCap.MinimumWidth = 6;
            this.colDienThoaiNhaCungCap.Name = "colDienThoaiNhaCungCap";
            this.colDienThoaiNhaCungCap.ReadOnly = true;
            // 
            // FrmQuanLyNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 674);
            this.Controls.Add(this.btn_find_supplier);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_find_supplier_phone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_find_supplier_address);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_find_supplier_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_supplier_delete);
            this.Controls.Add(this.btn_supplier_update);
            this.Controls.Add(this.btn_supplier_add);
            this.Controls.Add(this.dgv_supplier_load);
            this.Controls.Add(this.txt_supplier_phone);
            this.Controls.Add(this.txt_supplier_address);
            this.Controls.Add(this.txt_supplier_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmQuanLyNhaCungCap";
            this.Text = "FrmQuanLyNhaCungCap";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_supplier_load)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_supplier_error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_supplier_name;
        private System.Windows.Forms.TextBox txt_supplier_address;
        private System.Windows.Forms.TextBox txt_supplier_phone;
        private System.Windows.Forms.DataGridView dgv_supplier_load;
        private System.Windows.Forms.Button btn_supplier_add;
        private System.Windows.Forms.Button btn_supplier_update;
        private System.Windows.Forms.Button btn_supplier_delete;
        private System.Windows.Forms.ErrorProvider erp_supplier_error;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_find_supplier_phone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_find_supplier_address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_find_supplier_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_find_supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChiNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDienThoaiNhaCungCap;
    }
}