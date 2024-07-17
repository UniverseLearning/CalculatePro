using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatePro
{
    public partial class FormContract : Form
    {
        public FormContract()
        {
            InitializeComponent();
        }

        private void FormContract_Load(object sender, EventArgs e)
        {
            // EntityContract Load
            List<EntityContract> entitys = EntityContract.ReadData();
            int no = 0;
            foreach (var item in entitys)
            {
                contract_dgv.Rows.Add(item.Id, ++no, item.ContractNo, item.ContractName, item.ClientName, item.ClientPhone, item.LogisticsCost, item.OtherCost, item.TotalCost);
            }
        }

        private void contract_btn_search_Click(object sender, EventArgs e)
        {
            List<EntityContract> entitys = EntityContract.ReadData();
            string hth = contract_tb_hth.Text;
            string htmc = contract_tb_htmc.Text;
            string khmc = contract_tb_khmc.Text;
            contract_dgv.Rows.Clear();
            if (hth != null && hth.Length > 0)
            {
                entitys = entitys.Where(p => p.ContractNo.Contains(hth)).ToList();
            }
            if (htmc != null && htmc.Length > 0)
            {
                entitys = entitys.Where(p => p.ContractName.Contains(htmc)).ToList();
            }
            if (khmc != null && khmc.Length > 0)
            {
                entitys = entitys.Where(p => p.ClientName.Contains(khmc)).ToList();
            }
            int no = 0;
            foreach (var item in entitys)
            {
                contract_dgv.Rows.Add(item.Id, ++no, item.ContractNo, item.ContractName, item.ClientName, item.ClientPhone, item.LogisticsCost, item.OtherCost, item.TotalCost);
            }
        }
    }
}
