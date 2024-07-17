using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatePro
{
    public partial class FormCalculate : Form
    {
        public FormCalculate()
        {
            InitializeComponent();
        }

        public FormCalculate(int? defaultContractId, int? defaultMaterielId)
        {
            InitializeComponent();
            this.defaultContractId = defaultContractId;
            this.defaultMaterielId = defaultMaterielId;
        }

        private int? defaultContractId;

        private int? defaultMaterielId;

        private EntityContract currentContract;

        private EntityMateriel currentMateriel;

        private void FormCalculate_Load(object sender, EventArgs e)
        {
            // 初始化 合同号 下拉列表
            this.cal_cb_hth.Items.Clear();
            this.cal_cb_hth.DataSource = EntityContract.ReadData();
            this.cal_cb_hth.DisplayMember = "ContractNo";
            this.cal_cb_hth.ValueMember = "Id";

            // 初始化 图号 下拉列表
            object selectedObj = this.cal_cb_hth.SelectedValue;
            if (null != selectedObj)
            {
                List<EntityMateriel> Materiels = EntityMateriel.ReadDataByContractId(CommonUtil.ConvertToType<int>(selectedObj));
                if (null != Materiels && Materiels.Count > 0)
                {
                    if (this.cal_cb_th.Items.Count > 0)
                    {
                        this.cal_cb_th.DataSource = null;
                        this.cal_cb_th.Items.Clear();
                    }
                    this.cal_cb_th.DataSource = Materiels;
                    this.cal_cb_th.DisplayMember = "MaterialNo";
                    this.cal_cb_th.ValueMember = "Id";
                }
            }

            // 下拉列表 合同号、图号 默认选中
            if (defaultContractId != null && defaultMaterielId != null)
            {
                this.cal_cb_hth.SelectedValue = defaultContractId;
                this.cal_cb_th.SelectedValue = defaultMaterielId;
            }


           // 材料费初始化
           List <ConstantElement> listsMateriel = ConstantElement.InitData();
            foreach (var item in listsMateriel)
            {
                cal11_dgv.Rows.Add(item.Id, item.Type, item.Name, item.Density, item.Strength, item.Thermal);
            }
            // 加工费初始化
            List<ConstantProcess> listsProcess = ConstantProcess.InitData();
            foreach (var item in listsProcess)
            {
                cal21_dgv.Rows.Add(item.Id, item.Name, item.HourCost);
            }
            // 表面处理费初始化
            List<ConstantInterface> listsInterface = ConstantInterface.InitData();
            foreach (var item in listsInterface)
            {
                cal31_dgv.Rows.Add(item.Id, item.Name, item.FaceCost);
            }
            // 检查费初始化
            List<ConstantCheck> listsCheck = ConstantCheck.InitData();
            foreach (var item in listsCheck)
            {
                cal41_dgv.Rows.Add(item.Id, item.Name, item.CheckCost);
            }
            // 采购件初始化
            List<ConstantPart> listsPart = ConstantPart.InitData();
            foreach (var item in listsPart)
            {
                cal51_dgv.Rows.Add(item.Id, item.Name, item.PartCost);
            }
        }

        private void cal_tb_clf_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CommonUtil.CheckDigitFormat(this.cal_tb_clf, e);
        }

        private void cal_tb_jgf_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CommonUtil.CheckDigitFormat(this.cal_tb_jgf, e);
        }

        private void cal_tb_bmclf_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CommonUtil.CheckDigitFormat(this.cal_tb_bmclf, e);
        }

        private void cal_tb_jyf_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CommonUtil.CheckDigitFormat(this.cal_tb_jyf, e);
        }

        private void cal_tb_cgjf_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CommonUtil.CheckDigitFormat(this.cal_tb_cgjf, e);
        }

        /// <summary>
        /// 合同号 下拉 切换事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cal_cb_hth_SelectedIndexChanged(object sender, EventArgs e)
        {
            object selectedObj = this.cal_cb_hth.SelectedValue;
            int selectedId;
            if (selectedObj != null)
            {
                if (selectedObj.GetType() == typeof(EntityContract))
                {
                    EntityContract contractObj = CommonUtil.ConvertToType<EntityContract>(selectedObj);
                    selectedId = contractObj.Id;
                }
                else
                {
                    selectedId = CommonUtil.ConvertToType<int>(selectedObj);
                }
                EntityContract contract = EntityContract.ReadData(selectedId);
                this.currentContract = contract;
                this.cal_value_htmc.Text = contract.ContractName;
                this.cal_value_lxdh.Text = contract.ClientPhone;

                List<EntityMateriel> Materiels = EntityMateriel.ReadDataByContractId(selectedId);
                if (null != Materiels && Materiels.Count > 0)
                {
                    if (this.cal_cb_th.Items.Count > 0)
                    {
                        this.cal_cb_th.DataSource = null;
                        this.cal_cb_th.Items.Clear();
                    }
                    this.cal_cb_th.DataSource = Materiels;
                    this.cal_cb_th.DisplayMember = "MaterialNo";
                    this.cal_cb_th.ValueMember = "Id";
                }
            }
            else
            {
                this.cal_value_htmc.Text = string.Empty;
                this.cal_value_lxdh.Text = string.Empty;
            }
        }
        /// <summary>
        /// 图号 下拉 切换事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cal_cb_th_SelectedIndexChanged(object sender, EventArgs e)
        {
            object selectedObj = this.cal_cb_th.SelectedValue;
            int selectedId;
            if (selectedObj != null)
            {
                if (selectedObj.GetType() == typeof(EntityMateriel))
                {
                    EntityMateriel materielObj = CommonUtil.ConvertToType<EntityMateriel>(selectedObj);
                    selectedId = materielObj.Id;
                }
                else
                {
                    selectedId = CommonUtil.ConvertToType<int>(selectedObj);
                }
                EntityMateriel materiel = EntityMateriel.ReadData(selectedId);
                this.currentMateriel = materiel;
                this.cal_value_wlmc.Text = materiel.MaterialName;

                this.cal_tb_clf.Text = materiel.ElementCost.ToString();
                this.cal_tb_jgf.Text = materiel.ProcessCost.ToString();
                this.cal_tb_bmclf.Text = materiel.InterfaceCost.ToString();
                this.cal_tb_jyf.Text = materiel.CheckCost.ToString();
                this.cal_tb_cgjf.Text = materiel.PartCost.ToString();

            }
            else
            {
                this.cal_value_wlmc.Text = string.Empty;
            }
        }

        private void cal_tb_clf_TextChanged(object sender, EventArgs e)
        {
            this.total_value.Text = CalTotal().ToString();
        }

        private void cal_tb_jgf_TextChanged(object sender, EventArgs e)
        {
            this.total_value.Text = CalTotal().ToString();
        }

        private void cal_tb_bmclf_TextChanged(object sender, EventArgs e)
        {
            this.total_value.Text = CalTotal().ToString();
        }

        private void cal_tb_jyf_TextChanged(object sender, EventArgs e)
        {
            this.total_value.Text = CalTotal().ToString();
        }

        private void cal_tb_cgjf_TextChanged(object sender, EventArgs e)
        {
            this.total_value.Text = CalTotal().ToString();
        }
        private decimal? CalTotal()
        {
            decimal? Total = 0M;

            string clf = this.cal_tb_clf.Text;
            if (clf != null && clf.Length > 0)
            {
                Total += CommonUtil.ConvertToType<decimal>(clf);
            }
            string jgf = this.cal_tb_jgf.Text;
            if (jgf != null && jgf.Length > 0)
            {
                Total += CommonUtil.ConvertToType<decimal>(jgf);
            }
            string bmclf = this.cal_tb_bmclf.Text;
            if (bmclf != null && bmclf.Length > 0)
            {
                Total += CommonUtil.ConvertToType<decimal>(bmclf);
            }
            string jyf = this.cal_tb_jyf.Text;
            if (jyf != null && jyf.Length > 0)
            {
                Total += CommonUtil.ConvertToType<decimal>(jyf);
            }
            string cgjf = this.cal_tb_cgjf.Text;
            if (cgjf != null && cgjf.Length > 0)
            {
                Total += CommonUtil.ConvertToType<decimal>(cgjf);
            }
            return Total;
        }
        /// <summary>
        /// 写入部件 按钮 点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cal_btn_write_Click(object sender, EventArgs e)
        {
            EntityMateriel write = this.currentMateriel;
            if (write != null)
            {
                if (this.cal_tb_clf.Text != null && this.cal_tb_clf.Text.Length > 0)
                {
                    write.ElementCost = CommonUtil.ConvertToType<decimal>(this.cal_tb_clf.Text);
                }
                if (this.cal_tb_jgf.Text != null && this.cal_tb_jgf.Text.Length > 0)
                {
                    write.ProcessCost = CommonUtil.ConvertToType<decimal>(this.cal_tb_jgf.Text);
                }
                if (this.cal_tb_bmclf.Text != null && this.cal_tb_bmclf.Text.Length > 0)
                {
                    write.InterfaceCost = CommonUtil.ConvertToType<decimal>(this.cal_tb_bmclf.Text);
                }
                if (this.cal_tb_jyf.Text != null && this.cal_tb_jyf.Text.Length > 0)
                {
                    write.CheckCost = CommonUtil.ConvertToType<decimal>(this.cal_tb_jyf.Text);
                }
                if (this.cal_tb_cgjf.Text != null && this.cal_tb_cgjf.Text.Length > 0)
                {
                    write.PartCost = CommonUtil.ConvertToType<decimal>(this.cal_tb_cgjf.Text);
                }
                if (this.total_value.Text != null && this.total_value.Text.Length > 0)
                {
                    write.SubTotalCost = CommonUtil.ConvertToType<decimal>(this.total_value.Text);
                }
                EntityMateriel.UpdateData(write);
                MessageBox.Show("写入部件成功！", "Success!", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("未选中部件！", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        // ===============================================================================================
        // ====================== 材料费 =================================================================
        // ===============================================================================================
        /// <summary>
        /// 长度 校验 只能输入数字
        /// </summary>
        private void cal11_tb_length_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CommonUtil.CheckDigitFormat(this.cal11_tb_length, e);
        }
        /// <summary>
        /// 宽度 校验 只能输入数字
        /// </summary>
        private void cal11_tb_width_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CommonUtil.CheckDigitFormat(this.cal11_tb_width, e);
        }
        /// <summary>
        /// 高度 校验 只能输入数字
        /// </summary>
        private void cal11_tb_height_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CommonUtil.CheckDigitFormat(this.cal11_tb_height, e);
        }
        /// <summary>
        /// 重量 校验 只能输入数字
        /// </summary>
        private void cal11_tb_weight_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CommonUtil.CheckDigitFormat(this.cal11_tb_weight, e);
        }
        /// <summary>
        /// 价格 校验 只能输入数字
        /// </summary>
        private void cal11_tb_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CommonUtil.CheckDigitFormat(this.cal11_tb_price, e);
        }
        /// <summary>
        /// 计算 总重量
        /// </summary>
        private void cal11_tb_length_TextChanged(object sender, EventArgs e)
        {
            this.cal11_tb_weight.Text = CalWeight().ToString();
        }
        /// <summary>
        /// 计算 总重量
        /// </summary>
        private void cal11_tb_width_TextChanged(object sender, EventArgs e)
        {
            this.cal11_tb_weight.Text = CalWeight().ToString();
        }
        /// <summary>
        /// 计算 总重量
        /// </summary>
        private void cal11_tb_height_TextChanged(object sender, EventArgs e)
        {
            this.cal11_tb_weight.Text = CalWeight().ToString();
        }
        /// <summary>
        /// 计算 总重量
        /// </summary>
        private void cal11_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.cal11_tb_weight.Text = CalWeight().ToString();
        }
        private decimal? CalWeight()
        {
            decimal? Weight = 0M;

            string length = this.cal11_tb_length.Text;
            string width = this.cal11_tb_width.Text;
            string height = this.cal11_tb_height.Text;
            DataGridViewRow currentRow = cal11_dgv.CurrentRow;


            if ((length != null && length.Length > 0) && 
                (width != null && width.Length > 0) && 
                (height != null && height.Length > 0) && 
                (currentRow != null || currentRow.Cells[3].Value != null))
            {
                Weight = CommonUtil.ConvertToType<decimal>(length) *
                    CommonUtil.ConvertToType<decimal>(width) *
                    CommonUtil.ConvertToType<decimal>(height) *
                    0.000000001M *                                  // 立方毫米 转 立方米
                    CommonUtil.ConvertToType<decimal>(currentRow.Cells[3].Value);
            }
            
            return Weight;
        }
        /// <summary>
        /// 跳转 单价查询 网址
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cal11_price_search_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.baidu.com");
        }
        /// <summary>
        /// 计算材料费
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cal1_btn_cal_Click(object sender, EventArgs e)
        {
            string weight = this.cal11_tb_weight.Text;
            string price = this.cal11_tb_price.Text;
            decimal? Sum = 0M;
            if ((weight != null && weight.Length > 0) &&
                (price != null && price.Length > 0))
            {
                Sum = CommonUtil.ConvertToType<decimal>(weight) *
                   CommonUtil.ConvertToType<decimal>(price);
            }
            this.cal11_value_total.Text = Sum.ToString();
            this.cal_tb_clf.Text = Sum.ToString();
        }
        // ===============================================================================================
        // ====================== 加工费 =================================================================
        // ===============================================================================================
        /// <summary>
        /// 单价 校验 只能输入数字
        /// </summary>
        private void cal21_tb_dj_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CommonUtil.CheckDigitFormat(this.cal21_tb_dj, e);
        }
        /// <summary>
        /// 工时 校验 只能输入数字
        /// </summary>
        private void cal21_tb_gs_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CommonUtil.CheckDigitFormat(this.cal21_tb_gs, e);
        }
        /// <summary>
        /// 计算工时费
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cal2_btn_cal_Click(object sender, EventArgs e)
        {
            decimal? Sum = 0M;
            // 按单价计费
            if (this.cal21_rb_anjj.Checked)
            {
                string price = this.cal21_tb_dj.Text;
                if (price != null && price.Length > 0)
                {
                    Sum = CommonUtil.ConvertToType<decimal>(price);
                }
            }
            // 按工时计费
            if (this.cal21_rb_agsjf.Checked)
            {
                string gs = this.cal21_tb_gs.Text;
                DataGridViewRow currentRow = cal21_dgv.CurrentRow;
                if ((gs != null && gs.Length > 0) &&
                (currentRow != null && currentRow.Cells[2].Value != null))
                {
                    Sum = CommonUtil.ConvertToType<decimal>(gs) *
                        CommonUtil.ConvertToType<decimal>(currentRow.Cells[2].Value);
                }

            }
            this.cal21_value_total.Text = Sum.ToString();
            this.cal_tb_jgf.Text = Sum.ToString();
        }
        // ===============================================================================================
        // ====================== 表面处理费 =============================================================
        // ===============================================================================================
        /// <summary>
        /// 单价 校验 只能输入数字
        /// </summary>
        private void cal31_tb_dj_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CommonUtil.CheckDigitFormat(this.cal31_tb_dj, e);
        }
        /// <summary>
        /// 面积 校验 只能输入数字
        /// </summary>
        private void cal31_tb_mj_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CommonUtil.CheckDigitFormat(this.cal31_tb_mj, e);
        }
        /// <summary>
        /// 计算表面处理费
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cal3_btn_cal_Click(object sender, EventArgs e)
        {
            decimal? Sum = 0M;
            // 按单价计费
            if (this.cal31_rb_ajjf.Checked)
            {
                string price = this.cal31_tb_dj.Text;
                if (price != null && price.Length > 0)
                {
                    Sum = CommonUtil.ConvertToType<decimal>(price);
                }
            }
            // 按工时计费
            if (this.cal31_rb_amjjf.Checked)
            {
                string mj = this.cal31_tb_mj.Text;
                DataGridViewRow currentRow = cal31_dgv.CurrentRow;
                if ((mj != null && mj.Length > 0) &&
                (currentRow != null && currentRow.Cells[2].Value != null))
                {
                    Sum = CommonUtil.ConvertToType<decimal>(mj) *
                        CommonUtil.ConvertToType<decimal>(currentRow.Cells[2].Value);
                }

            }
            this.cal31_value_total.Text = Sum.ToString();
            this.cal_tb_bmclf.Text = Sum.ToString();
        }
        // ===============================================================================================
        // ====================== 检验费 =================================================================
        // ===============================================================================================
        private void button5_Click(object sender, EventArgs e)
        {
            decimal? Sum = 0M;
            DataGridViewRow currentRow = cal41_dgv.CurrentRow;
            if (currentRow != null && currentRow.Cells[2].Value != null)
            {
                Sum = CommonUtil.ConvertToType<decimal>(currentRow.Cells[2].Value);
            }
            this.cal41_value_total.Text = Sum.ToString();
            this.cal_tb_jyf.Text = Sum.ToString();
        }
        // ===============================================================================================
        // ====================== 采购件费 ===============================================================
        // ===============================================================================================
        private void cal5_btn_cal_Click(object sender, EventArgs e)
        {
            decimal? Sum = 0M;
            DataGridViewRow currentRow = cal51_dgv.CurrentRow;
            if (currentRow != null && currentRow.Cells[2].Value != null)
            {
                Sum = CommonUtil.ConvertToType<decimal>(currentRow.Cells[2].Value);
            }
            this.cal51_value_total.Text = Sum.ToString();
            this.cal_tb_cgjf.Text = Sum.ToString();
        }
    }
}
