namespace Quick_Turn_App
{
    partial class partfilesform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label partNumberLabel;
            System.Windows.Forms.Label printFileLabel;
            System.Windows.Forms.Label inspectionReportLabel;
            System.Windows.Forms.Label programLabel;
            this.quickTurnDataSet = new Quick_Turn_App.QuickTurnDataSet();
            this.part_filesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.part_filesTableAdapter = new Quick_Turn_App.QuickTurnDataSetTableAdapters.part_filesTableAdapter();
            this.tableAdapterManager = new Quick_Turn_App.QuickTurnDataSetTableAdapters.TableAdapterManager();
            this.partNumberTextBox = new System.Windows.Forms.TextBox();
            this.printFileTextBox = new System.Windows.Forms.TextBox();
            this.inspectionReportTextBox = new System.Windows.Forms.TextBox();
            this.programTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            partNumberLabel = new System.Windows.Forms.Label();
            printFileLabel = new System.Windows.Forms.Label();
            inspectionReportLabel = new System.Windows.Forms.Label();
            programLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quickTurnDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.part_filesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // partNumberLabel
            // 
            partNumberLabel.AutoSize = true;
            partNumberLabel.Location = new System.Drawing.Point(51, 56);
            partNumberLabel.Name = "partNumberLabel";
            partNumberLabel.Size = new System.Drawing.Size(69, 13);
            partNumberLabel.TabIndex = 1;
            partNumberLabel.Text = "Part Number:";
            // 
            // printFileLabel
            // 
            printFileLabel.AutoSize = true;
            printFileLabel.Location = new System.Drawing.Point(51, 82);
            printFileLabel.Name = "printFileLabel";
            printFileLabel.Size = new System.Drawing.Size(50, 13);
            printFileLabel.TabIndex = 3;
            printFileLabel.Text = "Print File:";
            // 
            // inspectionReportLabel
            // 
            inspectionReportLabel.AutoSize = true;
            inspectionReportLabel.Location = new System.Drawing.Point(51, 108);
            inspectionReportLabel.Name = "inspectionReportLabel";
            inspectionReportLabel.Size = new System.Drawing.Size(94, 13);
            inspectionReportLabel.TabIndex = 5;
            inspectionReportLabel.Text = "Inspection Report:";
            // 
            // programLabel
            // 
            programLabel.AutoSize = true;
            programLabel.Location = new System.Drawing.Point(51, 134);
            programLabel.Name = "programLabel";
            programLabel.Size = new System.Drawing.Size(49, 13);
            programLabel.TabIndex = 7;
            programLabel.Text = "Program:";
            // 
            // quickTurnDataSet
            // 
            this.quickTurnDataSet.DataSetName = "QuickTurnDataSet";
            this.quickTurnDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // part_filesBindingSource
            // 
            this.part_filesBindingSource.DataMember = "part_files";
            this.part_filesBindingSource.DataSource = this.quickTurnDataSet;
            // 
            // part_filesTableAdapter
            // 
            this.part_filesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bar_stock_pricesTableAdapter = null;
            this.tableAdapterManager.employeesTableAdapter = null;
            this.tableAdapterManager.inventoryTableAdapter = null;
            this.tableAdapterManager.part_filesTableAdapter = this.part_filesTableAdapter;
            this.tableAdapterManager.schedule_boardTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Quick_Turn_App.QuickTurnDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // partNumberTextBox
            // 
            this.partNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.part_filesBindingSource, "PartNumber", true));
            this.partNumberTextBox.Location = new System.Drawing.Point(151, 53);
            this.partNumberTextBox.Name = "partNumberTextBox";
            this.partNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.partNumberTextBox.TabIndex = 2;
            // 
            // printFileTextBox
            // 
            this.printFileTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.part_filesBindingSource, "PrintFile", true));
            this.printFileTextBox.Location = new System.Drawing.Point(151, 79);
            this.printFileTextBox.Name = "printFileTextBox";
            this.printFileTextBox.Size = new System.Drawing.Size(100, 20);
            this.printFileTextBox.TabIndex = 4;
            // 
            // inspectionReportTextBox
            // 
            this.inspectionReportTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.part_filesBindingSource, "InspectionReport", true));
            this.inspectionReportTextBox.Location = new System.Drawing.Point(151, 105);
            this.inspectionReportTextBox.Name = "inspectionReportTextBox";
            this.inspectionReportTextBox.Size = new System.Drawing.Size(100, 20);
            this.inspectionReportTextBox.TabIndex = 6;
            // 
            // programTextBox
            // 
            this.programTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.part_filesBindingSource, "Program", true));
            this.programTextBox.Location = new System.Drawing.Point(151, 131);
            this.programTextBox.Name = "programTextBox";
            this.programTextBox.Size = new System.Drawing.Size(100, 20);
            this.programTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Choose Part Programs:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(160, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // partfilesform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 227);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(partNumberLabel);
            this.Controls.Add(this.partNumberTextBox);
            this.Controls.Add(printFileLabel);
            this.Controls.Add(this.printFileTextBox);
            this.Controls.Add(inspectionReportLabel);
            this.Controls.Add(this.inspectionReportTextBox);
            this.Controls.Add(programLabel);
            this.Controls.Add(this.programTextBox);
            this.Name = "partfilesform";
            this.Text = "Part Files Form";
            this.Load += new System.EventHandler(this.partfilesform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quickTurnDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.part_filesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QuickTurnDataSet quickTurnDataSet;
        private System.Windows.Forms.BindingSource part_filesBindingSource;
        private QuickTurnDataSetTableAdapters.part_filesTableAdapter part_filesTableAdapter;
        private QuickTurnDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox partNumberTextBox;
        private System.Windows.Forms.TextBox printFileTextBox;
        private System.Windows.Forms.TextBox inspectionReportTextBox;
        private System.Windows.Forms.TextBox programTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}