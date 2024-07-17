using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CalculatePro
{
    public partial class FormMateriel : Form
    {
        public FormMateriel()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 页面加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMateriel_Load(object sender, EventArgs e)
        {
            // 初始化 合同号 下拉列表
            this.materiel_cb_hth.Items.Clear();
            this.materiel_cb_hth.DataSource = EntityContract.ReadData();
            this.materiel_cb_hth.DisplayMember = "ContractNo";
            this.materiel_cb_hth.ValueMember = "Id";
            // 初始化列表
            object selectedObj = this.materiel_cb_hth.SelectedValue;
            if (null != selectedObj)
            {
                List<EntityMateriel> listsMateriel = EntityMateriel.ReadDataByContractId(CommonUtil.ConvertToType<int>(selectedObj));
                if (null != listsMateriel && listsMateriel.Count > 0)
                {
                    int no = 0;
                    string firstId = string.Empty;
                    string firstMaterialNo = string.Empty;
                    string firstMaterialName = string.Empty;
                    foreach (var item in listsMateriel)
                    {
                        if (no == 0)
                        {
                            firstId = item.Id.ToString();
                            firstMaterialNo = item.MaterialNo;
                            firstMaterialName = item.MaterialName;
                        }
                        materiel_dgv.Rows.Add(item.Id, ++no, item.MaterialNo, item.MaterialName, item.Count, item.ElementCost, item.ProcessCost, item.InterfaceCost, item.CheckCost, item.ProcessCost, item.SubTotalCost);
                    }
                    this.materiel_value_id.Text = firstId;
                    this.materiel_value_th.Text = firstMaterialNo;
                    this.materiel_value_wlmc.Text = firstMaterialName;
                }
            }
        }
        /// <summary>
        /// 物流费 校验 只能输入数字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void materiel_tb_wlf_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CommonUtil.CheckDigitFormat(this.materiel_tb_wlf, e);
        }
        /// <summary>
        /// 其它费用 校验 只能输入数字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void materiel_tb_qt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CommonUtil.CheckDigitFormat(this.materiel_tb_qt, e);
        }
        /// <summary>
        /// 合同号 下拉列表 切换事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void materiel_cb_hth_SelectedIndexChanged(object sender, EventArgs e)
        {
            object selectedObj = this.materiel_cb_hth.SelectedValue;
            int selectedId;
            if (selectedObj != null) {
                if (selectedObj.GetType() == typeof(EntityContract))
                {
                    EntityContract contractObj = CommonUtil.ConvertToType<EntityContract>(selectedObj);
                    selectedId = contractObj.Id;
                } else {
                    selectedId = CommonUtil.ConvertToType<int>(selectedObj);
                }
                EntityContract contract = EntityContract.ReadData(selectedId);
                this.materiel_value_htmc.Text = contract.ContractName;
                this.materiel_value_lxdh.Text = contract.ClientPhone;
                this.materiel_value_khmc.Text = contract.ClientName;
                this.materiel_tb_wlf.Text = Convert.ToString(contract.LogisticsCost);
                this.materiel_tb_qt.Text = Convert.ToString(contract.OtherCost);
                this.materiel_value_zj.Text = Convert.ToString(contract.TotalCost);
                // 重载列表
                materiel_dgv.Rows.Clear();
                List<EntityMateriel> listsMateriel = EntityMateriel.ReadDataByContractId(CommonUtil.ConvertToType<int>(selectedObj));
                if (null != listsMateriel && listsMateriel.Count > 0)
                {
                    int no = 0;
                    string firstId = string.Empty;
                    string firstMaterialNo = string.Empty;
                    string firstMaterialName = string.Empty;
                    foreach (var item in listsMateriel)
                    {
                        if (no == 0)
                        {
                            firstId = item.Id.ToString();
                            firstMaterialNo = item.MaterialNo;
                            firstMaterialName = item.MaterialName;
                        }
                        materiel_dgv.Rows.Add(item.Id, ++no, item.MaterialNo, item.MaterialName, item.Count, item.ElementCost, item.ProcessCost, item.InterfaceCost, item.CheckCost, item.ProcessCost, item.SubTotalCost);
                    }
                    this.materiel_value_id.Text = firstId;
                    this.materiel_value_th.Text = firstMaterialNo;
                    this.materiel_value_wlmc.Text = firstMaterialName;
                }
            }
            else {
                this.materiel_value_htmc.Text = string.Empty;
                this.materiel_value_lxdh.Text = string.Empty;
                this.materiel_value_khmc.Text = string.Empty;
                this.materiel_tb_wlf.Text = string.Empty;
                this.materiel_tb_qt.Text = string.Empty;
            }
        }
        /// <summary>
        /// 列表行选中事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void materiel_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (materiel_dgv.CurrentRow == null || materiel_dgv.CurrentRow.Cells[0].Value == null)
            {
                this.materiel_value_th.Text = string.Empty;
                this.materiel_value_wlmc.Text = string.Empty;
                return;
            }
            this.materiel_value_th.Text = materiel_dgv.CurrentRow.Cells[2].Value.ToString();
            this.materiel_value_wlmc.Text = materiel_dgv.CurrentRow.Cells[3].Value.ToString();

            if (e.ColumnIndex == 11 && e.RowIndex >= 0) // yourButtonColumnIndex是按钮所在的列索引
            {
                int? defaultContractId = CommonUtil.ConvertToType<EntityContract>(this.materiel_cb_hth.SelectedItem).Id;
                int? defaultMaterielId = CommonUtil.ConvertToType<int>(materiel_dgv.CurrentRow.Cells[0].Value.ToString());
                FormCalculate form = new FormCalculate(defaultContractId, defaultMaterielId);
                form.ShowDialog();
                
            }
        }
        /// <summary>
        /// 总计按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void materiel_btn_cal_Click(object sender, EventArgs e)
        {
            string LogisticsCostStr = this.materiel_tb_wlf.Text;
            string OtherCostStr = this.materiel_tb_qt.Text;
            decimal Total = 0M;
            if (LogisticsCostStr != null && LogisticsCostStr.Length > 0)
            {
                Total += CommonUtil.ConvertToType<decimal>(LogisticsCostStr);
            }
            if (OtherCostStr != null && OtherCostStr.Length > 0)
            {
                Total += CommonUtil.ConvertToType<decimal>(OtherCostStr);
            }
            // 循环取列表中的小计
            int count = materiel_dgv.Rows.Count;
            if (count > 0)
            {
                foreach (DataGridViewRow dr in materiel_dgv.Rows)
                {
                    object subTotalObj = dr.Cells["materiel_col_SubTotalCost"].Value;
                    if (subTotalObj != null)
                    {
                        Total += CommonUtil.ConvertToType<decimal>(subTotalObj);
                    }
                }
            }
            this.materiel_value_zj.Text = Total.ToString();
        }
        /// <summary>
        /// 写入合同按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void materiel_btn_write_Click(object sender, EventArgs e)
        {
            object selectedObj = this.materiel_cb_hth.SelectedValue;

            if (selectedObj != null)
            {
                EntityContract entityContract = new EntityContract();
                entityContract.Id = CommonUtil.ConvertToType<int>(selectedObj);
                entityContract.ContractNo = CommonUtil.ConvertToType<EntityContract>(this.materiel_cb_hth.SelectedItem).ContractNo;
                entityContract.ContractName = this.materiel_value_htmc.Text;
                entityContract.ClientName = this.materiel_value_khmc.Text;
                entityContract.ClientPhone = this.materiel_value_lxdh.Text;
                if (this.materiel_tb_wlf.Text != null && this.materiel_tb_wlf.Text.Length > 0)
                {
                    entityContract.LogisticsCost = CommonUtil.ConvertToType<decimal>(this.materiel_tb_wlf.Text);
                }
                if (this.materiel_tb_qt.Text != null && this.materiel_tb_qt.Text.Length > 0)
                {
                    entityContract.OtherCost = CommonUtil.ConvertToType<decimal>(this.materiel_tb_qt.Text);
                }
                if (this.materiel_value_zj.Text != null && this.materiel_value_zj.Text.Length > 0)
                {
                    entityContract.TotalCost = CommonUtil.ConvertToType<decimal>(this.materiel_value_zj.Text);
                }
                EntityContract.UpdateData(entityContract);
                MessageBox.Show("写入合同成功！", "Success!", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("未选中合同！", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
