using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ŞA___BridgeDP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ShipperBase _shipperBase = new ShipperBase
        {
            DataObject = new ShipperDatabaseObject()
        };

        private void btnFirst_Click(object sender, EventArgs e)
        {
            Shipper shipper = _shipperBase.First;

            txtId.Text = shipper.ShipperID.ToString();
            txtCompanyName.Text = shipper.CompanyName;
            txtPhone.Text = shipper.Phone;
        }

        private void btnPrior_Click(object sender, EventArgs e)
        {
            Shipper shipper = _shipperBase.Prior;

            txtId.Text = shipper.ShipperID.ToString();
            txtCompanyName.Text = shipper.CompanyName;
            txtPhone.Text = shipper.Phone;
        }

        private void btnCurrent_Click(object sender, EventArgs e)
        {
            Shipper shipper = _shipperBase.Current;

            txtId.Text = shipper.ShipperID.ToString();
            txtCompanyName.Text = shipper.CompanyName;
            txtPhone.Text = shipper.Phone;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Shipper shipper = _shipperBase.Next;

            txtId.Text = shipper.ShipperID.ToString();
            txtCompanyName.Text = shipper.CompanyName;
            txtPhone.Text = shipper.Phone;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {

            Shipper shipper = _shipperBase.Last;

            txtId.Text = shipper.ShipperID.ToString();
            txtCompanyName.Text = shipper.CompanyName;
            txtPhone.Text = shipper.Phone;
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = _shipperBase.ShowAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Shipper shipper = _shipperBase.Prior;

            txtId.Text = shipper.ShipperID.ToString();
            txtCompanyName.Text = shipper.CompanyName;
            txtPhone.Text = shipper.Phone;
        }
    }
}
