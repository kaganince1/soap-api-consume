using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Soap_Winform.ServiceReference1;

namespace Soap_Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnGet_Click(object sender, EventArgs e)
        {
            if (txtboxConnStr.Text.Length == 0)
            {
                MessageBox.Show("Please enter connection string", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ServiceReference1.WebService1SoapClient client = new WebService1SoapClient();
                DataSet ds = new DataSet();
                ds = client.GetDataset(txtboxConnStr.Text);
                dgvSonuc.DataSource = ds.Tables[0];
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtboxConnStr.Text.Length == 0 || txtboxName.Text.Length == 0 || txtboxSurname.Text.Length == 0 || txtboxAge.Text.Length == 0 || txtboxLocation.Text.Length == 0)
            {
                MessageBox.Show("Please enter requested textboxes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ServiceReference1.WebService1SoapClient client = new WebService1SoapClient();
                client.AddData(txtboxConnStr.Text, txtboxName.Text, txtboxSurname.Text, int.Parse(txtboxAge.Text), txtboxLocation.Text);
                txtboxName.Text = "";
                txtboxSurname.Text = "";
                txtboxAge.Text = "";
                txtboxLocation.Text = "";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtboxConnStr.Text.Length == 0 || txtboxName2.Text.Length == 0 || txtboxSurname2.Text.Length == 0 || txtboxAge2.Text.Length == 0 || txtboxLocation2.Text.Length == 0 || txtboxId.Text.Length == 0)
            {
                MessageBox.Show("Please enter requested textboxes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ServiceReference1.WebService1SoapClient client = new WebService1SoapClient();
                client.UpdateData(txtboxConnStr.Text,int.Parse(txtboxId.Text), txtboxName2.Text, txtboxSurname2.Text, int.Parse(txtboxAge2.Text), txtboxLocation2.Text);
                txtboxId.Text = "";
                txtboxName2.Text = "";
                txtboxSurname2.Text = "";
                txtboxAge2.Text = "";
                txtboxLocation2.Text = "";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtboxConnStr.Text.Length == 0 || txtboxId2.Text.Length == 0)
            {
                MessageBox.Show("Please enter requested textboxes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ServiceReference1.WebService1SoapClient client = new WebService1SoapClient();
                client.DeleteData(txtboxConnStr.Text, int.Parse(txtboxId2.Text));
                txtboxId2.Text = "";
            }
        }

        private void btnGet2_Click(object sender, EventArgs e)
        {
            if (txtboxConnStr.Text.Length == 0 || txtboxId3.Text.Length == 0)
            {
                MessageBox.Show("Please enter requested textboxes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ServiceReference1.WebService1SoapClient client = new WebService1SoapClient();
                DataSet ds = new DataSet();
                ds = client.GetOneDataset(txtboxConnStr.Text, int.Parse(txtboxId3.Text));
                dgvSonuc.DataSource = ds.Tables[0];
                txtboxId3.Text = "";
            }
        }
    }
}
