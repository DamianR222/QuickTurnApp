using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quick_Turn_App
{
    //table string


    public partial class barstockpricesform : Form
    {
        public barstockpricesform()
        {
            InitializeComponent();
        }

        private void bar_stock_pricesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bar_stock_pricesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quickTurnDataSet);

        }

        private void barstockpricesform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quickTurnDataSet.bar_stock_prices' table. You can move, or remove it, as needed.
            this.bar_stock_pricesTableAdapter.Fill(this.quickTurnDataSet.bar_stock_prices);

        }

        public static string tblname = "bar_stock_prices";
        public static string bardiameter;
        public static string pricepaid;
        public static string prevprice;
        public static string lowprice;
        public static string highprice;
        public static string company;



        private void button2_Click(object sender, EventArgs e)
        {
            string tblname = "bar_stock_prices";
            bardiameter = barStockDiameterTextBox.Text;
            pricepaid = pricePaidTextBox.Text;
            prevprice = prevPricePaidTextBox.Text;
            lowprice = lowestPricePaidTextBox.Text;
            highprice = highestPricePaidTextBox.Text;
            company = companyTextBox.Text;

        }

    }
}

