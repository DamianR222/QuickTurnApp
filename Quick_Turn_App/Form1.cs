using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using Microsoft.Office.Interop.Excel;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Data.SqlClient;
using DataTable = System.Data.DataTable;
using System.Globalization;

namespace Quick_Turn_App
{
    public partial class Form1 : Form
    {

        String connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = 'C:\\Users\\IU Student\\Source\\Repos\\Quick_Turn_App\\Quick_Turn_App\\QuickTurn.mdf'; Integrated Security = True";
        string selectCommand = "SELECT * FROM " + employeesform.tblname + "";


        //Methods
        public void IR_Print(string ir)
        {
            //prints Inspection Report (.xlsx format)

            try
            {
                //string partNum = ir;
                //string firstArticle = Directory.GetFiles("C:\\", partNum + ".xlsx").ToString(); //@"C:\Users\IU Student\Desktop\QuickTurn\Inpection Reports (1st Articles)\IR_" + partNum + ".xlsx";
                string firstArticle = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\Inpection Reports(1st Articles)\\IR_" + /*partNum*/ ir + ".xlsx";

                
                if(firstArticle != null)
                {
                    using (PrintDialog Dialog = new PrintDialog())
                    {
                        Dialog.ShowDialog();

                        ProcessStartInfo printProcessInfo = new ProcessStartInfo()
                        {
                            Verb = "print",
                            CreateNoWindow = true,
                            FileName = firstArticle,
                            WindowStyle = ProcessWindowStyle.Hidden
                        };

                        Process printProcess = new Process();
                        printProcess.StartInfo = printProcessInfo;
                        printProcess.Start();

                        printProcess.WaitForInputIdle();

                        Thread.Sleep(3000);

                        if (false == printProcess.CloseMainWindow())
                        {
                            printProcess.Kill();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void PP_Print(string pp)
        {
            //prints part print (.pdf format)

            try
            {

                //string partNum = pp;
                //string partPrint = @"C:\Users\IU Student\Desktop\QuickTurn\Prints\GARDNER DENVER PRINTS\" + partNum + ".pdf";
                string partPrint = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\Prints\\GARDNER DENVER PRINTS\\" + /*partNum*/ pp + ".pdf";


                using (PrintDialog Dialog = new PrintDialog())
                {
                    Dialog.ShowDialog();

                    ProcessStartInfo printProcessInfo = new ProcessStartInfo()
                    {
                        Verb = "print",
                        CreateNoWindow = true,
                        FileName = partPrint,
                        WindowStyle = ProcessWindowStyle.Hidden
                    };

                    Process printProcess = new Process();
                    printProcess.StartInfo = printProcessInfo;
                    printProcess.Start();

                    printProcess.WaitForInputIdle();

                    Thread.Sleep(3000);

                    if (false == printProcess.CloseMainWindow())
                    {
                        printProcess.Kill();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void WO_Print(string wo, string orderNum, string dueDate, string qty)
        {
            string xlPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\Work Orders\\" + wo + ".xlsx";
            string FNFMsg = "File Not Found!";
            Microsoft.Office.Interop.Excel.Application xlApp;
            Microsoft.Office.Interop.Excel._Workbook xlWorkbook;
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet;
            
            xlApp = new Microsoft.Office.Interop.Excel.Application
                {
                    Visible = false,
                    UserControl = false
                };

            xlWorkbook = xlApp.Workbooks.Open(xlPath);
            if (File.Exists(xlPath))
            {
                try
                {
                    xlWorksheet = (Microsoft.Office.Interop.Excel._Worksheet)xlWorkbook.ActiveSheet;

                    xlWorksheet.Cells[2, 12] = qty;
                    xlWorksheet.Cells[2, 14] = dueDate;
                    xlWorksheet.Cells[2, 3] = orderNum;

                    xlApp.DisplayAlerts = false;
                    xlWorkbook.SaveAs(xlPath, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, false, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                    xlWorkbook.PrintOutEx(null, null, null, true);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(FNFMsg + " " + ex + " : " + ex.Message);
                }
                finally
                {
                    xlWorkbook.Close();
                    xlApp.Quit();
                }

            }
            else
            {
                MessageBox.Show(FNFMsg);
            }
            
        }

        private void dataGridView6_CellValueChanged(object sender, DataGridViewCellEventArgs l)
        {
            //String connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = 'C:\\Users\\IU Student\\Source\\Repos\\Quick_Turn_App\\Quick_Turn_App\\QuickTurn.mdf'; Integrated Security = True";
            if (dataGridView6.SelectedRows.Count != 0) 
            {
                string tbl = "schedule_board";

                var a = dataGridView6.SelectedRows[0].Cells[0].Value.ToString();
                var b = dataGridView6.SelectedRows[0].Cells[1].Value.ToString();
                var c = dataGridView6.SelectedRows[0].Cells[2].Value.ToString();
                var d = dataGridView6.SelectedRows[0].Cells[3].Value.ToString();
                var e = dataGridView6.SelectedRows[0].Cells[4].Value.ToString();
                var f = dataGridView6.SelectedRows[0].Cells[5].Value.ToString();
                var g = dataGridView6.SelectedRows[0].Cells[6].Value.ToString();
                var h = dataGridView6.SelectedRows[0].Cells[7].Value.ToString();
                var i = dataGridView6.SelectedRows[0].Cells[8].Value.ToString();
                var j = dataGridView6.SelectedRows[0].Cells[9].Value.ToString();
                var k = dataGridView6.SelectedRows[0].Cells[10].Value.ToString();

                SqlConnection cn_connection = new SqlConnection(connectionString);
                if (cn_connection.State != ConnectionState.Open) cn_connection.Open();
                string sql_Text = "UPDATE " + tbl + " SET Quantity = '" + a + "', PartNumber = '" + b + "', DueDate = '" + c + "', Destination = '" + d + "', Material = '" + e + "', PO# = '" + f + "', Description = '" + g + "', Cell = '" + h + "', MaterialSize = '" + i + "', Heat# = '" + j + "', Status = '" + k + "'  WHERE PartNumber = '" + dataGridView6.SelectedRows[0].Cells[1].Value.ToString() + "' AND PO# = '" + dataGridView6.SelectedRows[0].Cells[5].Value.ToString()+ "';";
                SqlCommand cmd_Command = new SqlCommand(sql_Text, cn_connection);
                cmd_Command.ExecuteNonQuery();
                cn_connection.Close();
                MessageBox.Show("Updated!");
            }
            else
            {
                MessageBox.Show("No Row Selected! Please select row to update!");
            }

        }

        private void dataGridView5_CellValueChanged(object sender, DataGridViewCellEventArgs l)
        {

        }


        //Start of Program

        private void button2_Click(object sender, EventArgs l)
        {

            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            
            string OrderNum = textBox2.Text;
            string Quantity = textBox3.Text;
            string DueDate = textBox4.Text;
            string PartNum = comboBox1.Text;

            WO_Print(PartNum, OrderNum, DueDate, PartNum);
            IR_Print(PartNum);
            PP_Print(PartNum);


            

            /*
             * Work Order Excel Values
             quantity 2,12
             part # 4,4
             due date 2,14
             destination 6,3
             material 3,3
             po# 3,2
             Description 6,13
             Cell 9,1
             MaterialSize 3,3
             Heat# 10,1
             Status
             */





        }

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quickTurnDataSet.part_files' table. You can move, or remove it, as needed.
            this.part_filesTableAdapter.Fill(this.quickTurnDataSet.part_files);
            // TODO: This line of code loads data into the 'quickTurnDataSet.inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.quickTurnDataSet.inventory);
            // TODO: This line of code loads data into the 'quickTurnDataSet.bar_stock_prices' table. You can move, or remove it, as needed.
            this.bar_stock_pricesTableAdapter.Fill(this.quickTurnDataSet.bar_stock_prices);
            // TODO: This line of code loads data into the 'quickTurnDataSet.schedule_board' table. You can move, or remove it, as needed.
            this.schedule_boardTableAdapter.Fill(this.quickTurnDataSet.schedule_board);
            // TODO: This line of code loads data into the 'quickTurnDataSet.employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.quickTurnDataSet.employees);

        }

        //Employees
        private void AddEmployee_MenuItem1_Click(object sender, EventArgs e)
        {
            employeesform popup = new employeesform();
            var result = popup.ShowDialog();
            if (popup.DialogResult == DialogResult.OK)
            {

                quickTurnDataSet.employees.Rows.Add(employeesform.fname,
                    employeesform.lname,
                    employeesform.curpayrate,
                    employeesform.email,
                    employeesform.phone,
                    employeesform.address,
                    employeesform.hdate,
                    employeesform.startpayrate);

                employeesBindingSource.EndEdit();
                this.Validate();

                MessageBox.Show("OK");

            }
            else if (popup.DialogResult == DialogResult.Cancel)
            {
                popup.Dispose();
            }





        }

        private void DeleteEmployee_MenuItem2_Click(object sender, EventArgs e)
        {
            //String connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = 'C:\\Users\\IU Student\\Source\\Repos\\Quick_Turn_App\\Quick_Turn_App\\QuickTurn.mdf'; Integrated Security = True";

            if (dataGridView5.SelectedRows.Count != 0)
            {
                try
                {
                    //*** Delete entry in Database *** 
                    SqlConnection cn_connection = new SqlConnection(connectionString);
                    if (cn_connection.State != ConnectionState.Open) cn_connection.Open();
                    string sql_Text = "DELETE FROM " + employeesform.tblname + " WHERE FirstName = '" + dataGridView5.SelectedRows[0].Cells[0].Value.ToString() + "' AND LastName = '" + dataGridView5.SelectedRows[0].Cells[1].Value.ToString() + "'";
                    SqlCommand cmd_Command = new SqlCommand(sql_Text, cn_connection);
                    cmd_Command.ExecuteNonQuery();
                    MessageBox.Show("Row Deleted");
                    cn_connection.Close();

                    //*** Delete entry in DataSet ***
                    quickTurnDataSet.employees.Rows.RemoveAt(dataGridView5.SelectedRows[0].Index);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); };

            }
            else
            {
                MessageBox.Show("Not Deleted");
                return;
            }

        }

        //Part Files
        private void AddPart_MenuItem1_Click(object sender, EventArgs e)
        {
            partfilesform popup = new partfilesform();

            var result = popup.ShowDialog();
            if (popup.DialogResult == DialogResult.OK)
            {
                //--------------< add_Entry_to_Database() >-------------
                quickTurnDataSet.part_files.Rows.Add(partfilesform.partnum,
                    partfilesform.printfile,
                    partfilesform.program,
                    partfilesform.inspectionreport);

                partfilesBindingSource.EndEdit();
                this.Validate();
                MessageBox.Show("OK");

            }
            else if (popup.DialogResult == DialogResult.Cancel)
            {
                popup.Dispose();
            }


        }

        private void DeletePart_MenuItem2_Click(object sender, EventArgs e)
        {
            //String connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = 'C:\\Users\\IU Student\\Source\\Repos\\Quick_Turn_App\\Quick_Turn_App\\QuickTurn.mdf'; Integrated Security = True";

            if (dataGridView2.SelectedRows.Count != 0)
            {
                try
                {
                    //*** Delete entry in Database *** 
                    SqlConnection cn_connection = new SqlConnection(connectionString);
                    if (cn_connection.State != ConnectionState.Open) cn_connection.Open();
                    string sql_Text = "DELETE FROM " + partfilesform.tblname + " WHERE PartNumber = '" + dataGridView2.SelectedRows[0].Cells[0].Value.ToString() + "'";
                    SqlCommand cmd_Command = new SqlCommand(sql_Text, cn_connection);
                    cmd_Command.ExecuteNonQuery();
                    MessageBox.Show("Row Deleted");
                    cn_connection.Close();

                    //*** Delete entry in DataSet ***
                    quickTurnDataSet.part_files.Rows.RemoveAt(dataGridView2.SelectedRows[0].Index);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); };

            }
            else
            {
                MessageBox.Show("Not Deleted");
                return;
            }
        }

        //Inventory
        private void AddInventoryItem_MenuItem1_Click(object sender, EventArgs e)
        {
            inventoryform popup = new inventoryform();
            var result = popup.ShowDialog();
            if (popup.DialogResult == DialogResult.OK)
            {

                quickTurnDataSet.inventory.Rows.Add(inventoryform.materialsize,
                    inventoryform.materiallength,
                    inventoryform.materialgrade,
                    inventoryform.heatnum);

                inventoryBindingSource.EndEdit();
                this.Validate();

                MessageBox.Show("OK");

            }
            else if (popup.DialogResult == DialogResult.Cancel)
            {
                popup.Dispose();
            }


        }

        private void RemoveInventoryItem_MenuItem2_Click(object sender, EventArgs e)
        {
            if (dataGridView4.SelectedRows.Count == 0)
            {
                return;
            }
            else
            {
                try
                {
                    //--------------< remove_Entry_to_Database() >-------------
                    //String connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = 'C:\\Users\\IU Student\\Source\\Repos\\Quick_Turn_App\\Quick_Turn_App\\QuickTurn.mdf'; Integrated Security = True";

                    //-< Database >
                    SqlConnection cn_connection = new SqlConnection(connectionString);
                    if (cn_connection.State != ConnectionState.Open) cn_connection.Open();
                    string sql_Text = "DELETE FROM " + inventoryform.tblname + " WHERE MaterialSize = '" + dataGridView4.SelectedRows[0].Cells[0].Value.ToString() + "' AND MaterialGrade = '" + dataGridView4.SelectedRows[0].Cells[1].Value.ToString() + "'";
                    SqlCommand cmd_Command = new SqlCommand(sql_Text, cn_connection);
                    cmd_Command.ExecuteNonQuery();
                    MessageBox.Show("Row Deleted");
                    cn_connection.Close();
                    //--------------</ remove_Entry_to_Database() >-------------

                    //*** Delete entry in DataSet ***
                    quickTurnDataSet.inventory.Rows.RemoveAt(dataGridView4.SelectedRows[0].Index);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Not Deleted :" + ex.Message);
                    
                };

            }


        }

        //Bar Stock Prices
        private void AddPricesItem_MenuItem1_Click(object sender, EventArgs e)
        {
            barstockpricesform popup = new barstockpricesform();
            if (popup.DialogResult == DialogResult.OK)
            {
                //--------------< add_Entry_to_Database() >-------------
                //string cn_string = Properties.Settings.Default.QuickTurnConnectionString;

                //-< Database >
                SqlConnection cn_connection = new SqlConnection(connectionString);
                if (cn_connection.State != ConnectionState.Open) cn_connection.Open();
                string barstockdiameter = barstockpricesform.bardiameter;
                string pricepaid = barstockpricesform.pricepaid;
                string prevpricepaid = barstockpricesform.prevprice;
                string lowpricepaid = barstockpricesform.lowprice;
                string highpricepaid = barstockpricesform.highprice;
                string company = barstockpricesform.company;
                string sql_Text = "INSERT INTO " + barstockpricesform.tblname + " VALUES(" + barstockdiameter + "," + pricepaid + "," + prevpricepaid + "," + lowpricepaid + "," + highpricepaid + "," + company + ")";
                SqlCommand cmd_Command = new SqlCommand(sql_Text, cn_connection);
                cmd_Command.ExecuteNonQuery();
            }
            else if (popup.DialogResult == DialogResult.Cancel)
            {
                barstockpricesform.ActiveForm.Dispose();
            }

            
        }

        private void DeletePricesItem_MenuItem2_Click(object sender, EventArgs e)
        {
            string table3 = "bar_stock_prices";
            if (dataGridView3.SelectedRows.Count == 0)
            {
                return;
            }
            else
            {
                //--------------< add_Entry_to_Database() >-------------
                //string cn_string = Properties.Settings.Default.QuickTurnConnectionString;

                //-< Database >
                SqlConnection cn_connection = new SqlConnection(connectionString);
                if (cn_connection.State != ConnectionState.Open) cn_connection.Open();
                string sql_Text = "DELETE FROM " + table3 + " WHERE BarStockDiameter = '" + dataGridView3.SelectedRows[0].Cells[0].Value.ToString() + "' AND PricePaid = '" + dataGridView3.SelectedRows[0].Cells[1].Value.ToString() + "'";
                SqlCommand cmd_Command = new SqlCommand(sql_Text, cn_connection);
                cmd_Command.ExecuteNonQuery();
                //-</ Database >
                //< reload >
                //load_list();
                //</ reload >
                //--------------</ add_Entry_to_Database() >-------------
            }


        }

        private void EditPricesItem_MenuItem3_Click(object sender, EventArgs e)
        {
            barstockpricesform popup = new barstockpricesform();
            popup.Show();
            DialogResult dialogresult = default(DialogResult);
            if (dialogresult == DialogResult.OK)
            {
                //--------------< add_Entry_to_Database() >-------------
                //string cn_string = Properties.Settings.Default.QuickTurnConnectionString;

                //-< Database >
                SqlConnection cn_connection = new SqlConnection(connectionString);
                if (cn_connection.State != ConnectionState.Open) cn_connection.Open();
                barstockpricesform.bardiameter = dataGridView3.SelectedRows[0].Cells[0].Value.ToString();
                barstockpricesform.pricepaid = dataGridView3.SelectedRows[0].Cells[0].Value.ToString();
                barstockpricesform.prevprice = dataGridView3.SelectedRows[0].Cells[0].Value.ToString();
                barstockpricesform.lowprice = dataGridView3.SelectedRows[0].Cells[0].Value.ToString();
                barstockpricesform.highprice = dataGridView3.SelectedRows[0].Cells[0].Value.ToString();
                barstockpricesform.company = dataGridView3.SelectedRows[0].Cells[0].Value.ToString();
                //employeesform.startpayrate = dataGridView3.SelectedRows[0].Cells[7].Value.ToString();
                string sql_Text = "UPDATE " + barstockpricesform.tblname + " SET BarStockDiameter = " + barstockpricesform.bardiameter + ", PricePaid = " + barstockpricesform.pricepaid + ", PrevPricePaid = " + barstockpricesform.prevprice + ", LowestPricePaid = " + barstockpricesform.lowprice + ", HighestPricePaid = " + barstockpricesform.highprice + ", Company = " + barstockpricesform.company + " WHERE BarStockDiameter = '" + dataGridView3.SelectedRows[0].Cells[0].Value.ToString() + "' AND PricePaid = '" + dataGridView3.SelectedRows[0].Cells[1].Value.ToString() + "";
                SqlCommand cmd_Command = new SqlCommand(sql_Text, cn_connection);
                cmd_Command.ExecuteNonQuery();
                //-</ Database >
                //< reload >
                //load_list();
                //</ reload >
                //--------------</ add_Entry_to_Database() >-------------
            }
            else if (dialogresult == DialogResult.Cancel)
            {
                employeesform.ActiveForm.Dispose();
            }

        }
    }
}
