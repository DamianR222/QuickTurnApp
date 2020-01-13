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
    public partial class inventoryform : Form
    {
        public inventoryform()
        {
            InitializeComponent();
        }

        private void inventoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.inventoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quickTurnDataSet);

        }

        private void inventoryform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quickTurnDataSet.inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.quickTurnDataSet.inventory);

        }
        public static string tblname = "inventory";
        public static string materialsize;
        public static string materialgrade;
        public static string materiallength;
        public static string heatnum;

        private void button2_Click(object sender, EventArgs e)
        {
            //*** Collecting Inputs***

            materialsize = materialSizeTextBox.Text;
            materialgrade = materialGradeTextBox.Text;
            materiallength = materialLengthTextBox.Text;
            heatnum = heat_TextBox.Text;
            DialogResult = DialogResult.OK;
            String connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = 'C:\\Users\\IU Student\\Source\\Repos\\Quick_Turn_App\\Quick_Turn_App\\QuickTurn.mdf'; Integrated Security = True";
            try
            {
                //-< Database >
                using (SqlConnection cn_connection = new SqlConnection(connectionString))
                {
                    if (cn_connection.State != ConnectionState.Open) cn_connection.Open();
                    string matsize = inventoryform.materialsize;
                    string matgrade = inventoryform.materialgrade.ToString();
                    string matlength = inventoryform.materiallength;
                    string heatnum = inventoryform.heatnum;
                    string sql_Text = "INSERT INTO " + inventoryform.tblname + "(MaterialSize, MaterialGrade, MaterialLength, Heat#) VALUES('" + materialsize + "','" + materialgrade + "','" + materiallength + "','" + heatnum + "')";
                    SqlCommand cmd_Command = new SqlCommand(sql_Text, cn_connection);
                    cmd_Command.ExecuteNonQuery();
                    cn_connection.Close();
                    
                }
                Dispose();
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not Updated.:" + ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Dispose();
        }
    }
}
