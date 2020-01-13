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
    public partial class employeesform : Form
    {


        public employeesform()
        {
            InitializeComponent();

        }

        private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quickTurnDataSet);

        }

        private void employeesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quickTurnDataSet);

        }

        private void employeesform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quickTurnDataSet.employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.quickTurnDataSet.employees);

        }


        public static string tblname = "employees";
        public static string fname;
        public static string lname;
        public static decimal curpayrate;
        public static string email;
        public static string phone;
        public static string address;
        public static string hdate;
        public static decimal startpayrate;
        

        private void button2_Click(object sender, EventArgs e)
        {
            //***Collecting Inputs***

            fname = firstNameTextBox.Text;
            lname = lastNameTextBox.Text;
            try { curpayrate = decimal.Parse(currentPayRateTextBox.Text); } catch (Exception ex) { MessageBox.Show(ex.Message); };
            email = emailTextBox.Text;
            phone = phoneTextBox.Text;
            address = addressTextBox.Text;
            hdate = hireDateTextBox.Text;
            try { startpayrate = decimal.Parse(startingPayRateTextBox.Text); } catch (Exception ex) { MessageBox.Show(ex.Message); };

            //***Inserting Row into Database ***
            try
            {
                String connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = 'C:\\Users\\IU Student\\Source\\Repos\\Quick_Turn_App\\Quick_Turn_App\\QuickTurn.mdf'; Integrated Security = True";

                using (SqlConnection cn_connection = new SqlConnection(connectionString))
                {
                    if (cn_connection.State != ConnectionState.Open) cn_connection.Open();
                    string fname = employeesform.fname;
                    string lname = employeesform.lname;
                    decimal currentpayrate = employeesform.curpayrate;
                    string email = employeesform.email;
                    string phone = employeesform.phone;
                    string address = employeesform.address;
                    string hiredate = employeesform.hdate;
                    decimal startingpayrate = employeesform.startpayrate;
                    string sql_Text = "INSERT INTO " + employeesform.tblname + "(FirstName, LastName, CurrentPayRate, Email, Phone, Address, HireDate, StartingPayRate) VALUES('" + fname + "','" + lname + "','" + currentpayrate + "','" + email + "','" + phone + "','" + address + "','" + hiredate + "','" + startingpayrate + "');";
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
