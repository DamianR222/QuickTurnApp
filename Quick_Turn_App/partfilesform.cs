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
    public partial class partfilesform : Form
    {
        public partfilesform()
        {
            InitializeComponent();
        }

        private void part_filesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.part_filesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quickTurnDataSet);

        }

        private void partfilesform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quickTurnDataSet.part_files' table. You can move, or remove it, as needed.
            this.part_filesTableAdapter.Fill(this.quickTurnDataSet.part_files);

        }
        public static string tblname = "part_files";
        public static string partnum;
        public static string printfile;
        public static string inspectionreport;
        public static string program;
        String connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = 'C:\\Users\\IU Student\\Source\\Repos\\Quick_Turn_App\\Quick_Turn_App\\QuickTurn.mdf'; Integrated Security = True";

        private void button2_Click(object sender, EventArgs e)
        {


            partnum = partNumberTextBox.Text;
            printfile = printFileTextBox.Text;
            inspectionreport = inspectionReportTextBox.Text;
            program = programTextBox.Text;
            DialogResult = DialogResult.OK;



            try
            {
                using (SqlConnection cn_connection = new SqlConnection(connectionString))
                {
                    if (cn_connection.State != ConnectionState.Open) cn_connection.Open();
                    string sql_Text = "INSERT INTO " + partfilesform.tblname + "(PartNumber, PrintFile, InspectionReport, Program) VALUES('" + partnum + "','" + printfile + "','" + inspectionreport + "','" + program + "')";
                    SqlCommand cmd_Command = new SqlCommand(sql_Text, cn_connection);
                    cmd_Command.ExecuteNonQuery();
                    cn_connection.Close();
                }
                Dispose();
                this.DialogResult = DialogResult.OK;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Not Updated. : " + ex.Message);
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Dispose();
        }
    }
}
