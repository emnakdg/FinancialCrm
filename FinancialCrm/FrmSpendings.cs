using FinancialCrm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmSpendings : Form
    {
        public FrmSpendings()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void FrmSpendings_Load(object sender, EventArgs e)
        {
            var values = db.Spendings.ToList();
            dataGridView1.DataSource = values;
            dataGridView1.Columns["CategoryId"].Visible = false;
            dataGridView1.Columns["Categories"].Visible = false;
        }

        private void btnBanks_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            frm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }

        private void btnSpendingsList_Click(object sender, EventArgs e)
        {
            var values = db.Spendings.ToList();
            dataGridView1.DataSource = values;
            dataGridView1.Columns["CategoryId"].Visible = false;
            dataGridView1.Columns["Categories"].Visible = false;
        }

        private void btCreateSpendings_Click(object sender, EventArgs e)
        {
            string title = txtSpendingsTitle.Text;
            decimal amount = decimal.Parse(txtSpendingsAmount.Text);
            string date = Convert.ToDateTime(txtSpendingsPeriod.Text).ToString("yyyy-MM-dd");

            Spendings spendings = new Spendings();
            spendings.SpendingTitle = title;
            spendings.SpendingAmount = amount;
            spendings.SpendingDate = Convert.ToDateTime(date);
            db.Spendings.Add(spendings);
            db.SaveChanges();
            MessageBox.Show("Gider Başarılı Bir Şekilde Sisteme Eklendi", "Giderler", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Spendings.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnDeleteSpendings_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtSpendingsId.Text);
            var removeValue = db.Spendings.Find(id);
            db.Spendings.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Gider Başarılı Bir Şekilde Sistemden Silindi", "Giderler", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Spendings.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnUpdateSpendings_Click(object sender, EventArgs e)
        {
            string title = txtSpendingsTitle.Text;
            decimal amount = decimal.Parse(txtSpendingsAmount.Text);
            string date = Convert.ToDateTime(txtSpendingsPeriod.Text).ToString("yyyy-MM-dd");
            int id = int.Parse(txtSpendingsId.Text);

            var values = db.Spendings.Find(id);

            values.SpendingTitle = title;
            values.SpendingAmount = amount;
            values.SpendingDate = Convert.ToDateTime(date);
            db.SaveChanges();
            MessageBox.Show("Ödeme Başarılı Bir Şekilde Sistemde Güncellendi", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values2 = db.Spendings.ToList();
            dataGridView1.DataSource = values2;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmBankProcesses frm = new FrmBankProcesses();
            frm.Show();
            this.Hide();
        }
    }
}
