namespace CalculatePro
{
    partial class FormContract
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contract_dgv = new System.Windows.Forms.DataGridView();
            this.contract_btn_add = new System.Windows.Forms.Button();
            this.contract_btn_update = new System.Windows.Forms.Button();
            this.contract_btn_delete = new System.Windows.Forms.Button();
            this.contract_lbl_hth = new System.Windows.Forms.Label();
            this.contract_lbl_htmc = new System.Windows.Forms.Label();
            this.contract_lbl_khmc = new System.Windows.Forms.Label();
            this.contract_tb_hth = new System.Windows.Forms.TextBox();
            this.contract_tb_htmc = new System.Windows.Forms.TextBox();
            this.contract_tb_khmc = new System.Windows.Forms.TextBox();
            this.contract_btn_search = new System.Windows.Forms.Button();
            this.contract_col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contract_col_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contract_col_ContractNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contract_col_ContractName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contract_col_ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contract_col_ClientPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contract_col_LogisticsCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contract_col_OtherCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contract_col_TotalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.contract_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // contract_dgv
            // 
            this.contract_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.contract_dgv.BackgroundColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.contract_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.contract_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contract_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contract_col_id,
            this.contract_col_no,
            this.contract_col_ContractNo,
            this.contract_col_ContractName,
            this.contract_col_ClientName,
            this.contract_col_ClientPhone,
            this.contract_col_LogisticsCost,
            this.contract_col_OtherCost,
            this.contract_col_TotalCost});
            this.contract_dgv.Location = new System.Drawing.Point(12, 141);
            this.contract_dgv.Name = "contract_dgv";
            this.contract_dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.contract_dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.contract_dgv.RowTemplate.Height = 23;
            this.contract_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.contract_dgv.Size = new System.Drawing.Size(1210, 462);
            this.contract_dgv.TabIndex = 99;
            // 
            // contract_btn_add
            // 
            this.contract_btn_add.BackColor = System.Drawing.Color.Green;
            this.contract_btn_add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.contract_btn_add.Location = new System.Drawing.Point(25, 610);
            this.contract_btn_add.Name = "contract_btn_add";
            this.contract_btn_add.Size = new System.Drawing.Size(75, 34);
            this.contract_btn_add.TabIndex = 5;
            this.contract_btn_add.Text = "添加";
            this.contract_btn_add.UseVisualStyleBackColor = false;
            // 
            // contract_btn_update
            // 
            this.contract_btn_update.BackColor = System.Drawing.Color.Goldenrod;
            this.contract_btn_update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.contract_btn_update.Location = new System.Drawing.Point(106, 611);
            this.contract_btn_update.Name = "contract_btn_update";
            this.contract_btn_update.Size = new System.Drawing.Size(75, 34);
            this.contract_btn_update.TabIndex = 6;
            this.contract_btn_update.Text = "修改";
            this.contract_btn_update.UseVisualStyleBackColor = false;
            // 
            // contract_btn_delete
            // 
            this.contract_btn_delete.BackColor = System.Drawing.Color.DarkRed;
            this.contract_btn_delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.contract_btn_delete.Location = new System.Drawing.Point(187, 611);
            this.contract_btn_delete.Name = "contract_btn_delete";
            this.contract_btn_delete.Size = new System.Drawing.Size(75, 34);
            this.contract_btn_delete.TabIndex = 7;
            this.contract_btn_delete.Text = "删除";
            this.contract_btn_delete.UseVisualStyleBackColor = false;
            // 
            // contract_lbl_hth
            // 
            this.contract_lbl_hth.AutoSize = true;
            this.contract_lbl_hth.Location = new System.Drawing.Point(57, 20);
            this.contract_lbl_hth.Name = "contract_lbl_hth";
            this.contract_lbl_hth.Size = new System.Drawing.Size(74, 22);
            this.contract_lbl_hth.TabIndex = 0;
            this.contract_lbl_hth.Text = "合同号：";
            this.contract_lbl_hth.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // contract_lbl_htmc
            // 
            this.contract_lbl_htmc.AutoSize = true;
            this.contract_lbl_htmc.Location = new System.Drawing.Point(41, 59);
            this.contract_lbl_htmc.Name = "contract_lbl_htmc";
            this.contract_lbl_htmc.Size = new System.Drawing.Size(90, 22);
            this.contract_lbl_htmc.TabIndex = 0;
            this.contract_lbl_htmc.Text = "合同名称：";
            this.contract_lbl_htmc.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // contract_lbl_khmc
            // 
            this.contract_lbl_khmc.AutoSize = true;
            this.contract_lbl_khmc.Location = new System.Drawing.Point(41, 98);
            this.contract_lbl_khmc.Name = "contract_lbl_khmc";
            this.contract_lbl_khmc.Size = new System.Drawing.Size(90, 22);
            this.contract_lbl_khmc.TabIndex = 0;
            this.contract_lbl_khmc.Text = "客户名称：";
            this.contract_lbl_khmc.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // contract_tb_hth
            // 
            this.contract_tb_hth.Location = new System.Drawing.Point(127, 17);
            this.contract_tb_hth.Name = "contract_tb_hth";
            this.contract_tb_hth.Size = new System.Drawing.Size(200, 29);
            this.contract_tb_hth.TabIndex = 1;
            // 
            // contract_tb_htmc
            // 
            this.contract_tb_htmc.Location = new System.Drawing.Point(127, 56);
            this.contract_tb_htmc.Name = "contract_tb_htmc";
            this.contract_tb_htmc.Size = new System.Drawing.Size(200, 29);
            this.contract_tb_htmc.TabIndex = 2;
            // 
            // contract_tb_khmc
            // 
            this.contract_tb_khmc.Location = new System.Drawing.Point(127, 98);
            this.contract_tb_khmc.Name = "contract_tb_khmc";
            this.contract_tb_khmc.Size = new System.Drawing.Size(200, 29);
            this.contract_tb_khmc.TabIndex = 3;
            // 
            // contract_btn_search
            // 
            this.contract_btn_search.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.contract_btn_search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.contract_btn_search.Location = new System.Drawing.Point(1089, 87);
            this.contract_btn_search.Name = "contract_btn_search";
            this.contract_btn_search.Size = new System.Drawing.Size(121, 38);
            this.contract_btn_search.TabIndex = 4;
            this.contract_btn_search.Text = "搜索";
            this.contract_btn_search.UseVisualStyleBackColor = false;
            this.contract_btn_search.Click += new System.EventHandler(this.contract_btn_search_Click);
            // 
            // contract_col_id
            // 
            this.contract_col_id.HeaderText = "ID";
            this.contract_col_id.Name = "contract_col_id";
            this.contract_col_id.Visible = false;
            // 
            // contract_col_no
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.contract_col_no.DefaultCellStyle = dataGridViewCellStyle2;
            this.contract_col_no.FillWeight = 30F;
            this.contract_col_no.HeaderText = "序号";
            this.contract_col_no.Name = "contract_col_no";
            // 
            // contract_col_ContractNo
            // 
            this.contract_col_ContractNo.FillWeight = 60F;
            this.contract_col_ContractNo.HeaderText = "合同号";
            this.contract_col_ContractNo.Name = "contract_col_ContractNo";
            // 
            // contract_col_ContractName
            // 
            this.contract_col_ContractName.HeaderText = "合同名称";
            this.contract_col_ContractName.Name = "contract_col_ContractName";
            // 
            // contract_col_ClientName
            // 
            this.contract_col_ClientName.HeaderText = "客户名称";
            this.contract_col_ClientName.Name = "contract_col_ClientName";
            // 
            // contract_col_ClientPhone
            // 
            this.contract_col_ClientPhone.FillWeight = 75F;
            this.contract_col_ClientPhone.HeaderText = "联系电话";
            this.contract_col_ClientPhone.Name = "contract_col_ClientPhone";
            // 
            // contract_col_LogisticsCost
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.contract_col_LogisticsCost.DefaultCellStyle = dataGridViewCellStyle3;
            this.contract_col_LogisticsCost.HeaderText = "物流费用";
            this.contract_col_LogisticsCost.Name = "contract_col_LogisticsCost";
            this.contract_col_LogisticsCost.Visible = false;
            // 
            // contract_col_OtherCost
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.contract_col_OtherCost.DefaultCellStyle = dataGridViewCellStyle4;
            this.contract_col_OtherCost.HeaderText = "其它费用";
            this.contract_col_OtherCost.Name = "contract_col_OtherCost";
            this.contract_col_OtherCost.Visible = false;
            // 
            // contract_col_TotalCost
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.contract_col_TotalCost.DefaultCellStyle = dataGridViewCellStyle5;
            this.contract_col_TotalCost.FillWeight = 50F;
            this.contract_col_TotalCost.HeaderText = "总费用";
            this.contract_col_TotalCost.Name = "contract_col_TotalCost";
            // 
            // FormContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 657);
            this.Controls.Add(this.contract_btn_search);
            this.Controls.Add(this.contract_tb_khmc);
            this.Controls.Add(this.contract_tb_htmc);
            this.Controls.Add(this.contract_tb_hth);
            this.Controls.Add(this.contract_lbl_khmc);
            this.Controls.Add(this.contract_lbl_htmc);
            this.Controls.Add(this.contract_lbl_hth);
            this.Controls.Add(this.contract_btn_delete);
            this.Controls.Add(this.contract_btn_update);
            this.Controls.Add(this.contract_btn_add);
            this.Controls.Add(this.contract_dgv);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormContract";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "合同管理";
            this.Load += new System.EventHandler(this.FormContract_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contract_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView contract_dgv;
        private System.Windows.Forms.Button contract_btn_add;
        private System.Windows.Forms.Button contract_btn_update;
        private System.Windows.Forms.Button contract_btn_delete;
        private System.Windows.Forms.Label contract_lbl_hth;
        private System.Windows.Forms.Label contract_lbl_htmc;
        private System.Windows.Forms.Label contract_lbl_khmc;
        private System.Windows.Forms.TextBox contract_tb_hth;
        private System.Windows.Forms.TextBox contract_tb_htmc;
        private System.Windows.Forms.TextBox contract_tb_khmc;
        private System.Windows.Forms.Button contract_btn_search;
        private System.Windows.Forms.DataGridViewTextBoxColumn contract_col_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn contract_col_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn contract_col_ContractNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn contract_col_ContractName;
        private System.Windows.Forms.DataGridViewTextBoxColumn contract_col_ClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn contract_col_ClientPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn contract_col_LogisticsCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn contract_col_OtherCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn contract_col_TotalCost;
    }
}