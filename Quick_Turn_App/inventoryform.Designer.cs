namespace Quick_Turn_App
{
    partial class inventoryform
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
            System.Windows.Forms.Label materialSizeLabel;
            System.Windows.Forms.Label materialGradeLabel;
            System.Windows.Forms.Label materialLengthLabel;
            System.Windows.Forms.Label heat_Label;
            this.quickTurnDataSet = new Quick_Turn_App.QuickTurnDataSet();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryTableAdapter = new Quick_Turn_App.QuickTurnDataSetTableAdapters.inventoryTableAdapter();
            this.tableAdapterManager = new Quick_Turn_App.QuickTurnDataSetTableAdapters.TableAdapterManager();
            this.materialSizeTextBox = new System.Windows.Forms.TextBox();
            this.materialGradeTextBox = new System.Windows.Forms.TextBox();
            this.materialLengthTextBox = new System.Windows.Forms.TextBox();
            this.heat_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            materialSizeLabel = new System.Windows.Forms.Label();
            materialGradeLabel = new System.Windows.Forms.Label();
            materialLengthLabel = new System.Windows.Forms.Label();
            heat_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quickTurnDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // materialSizeLabel
            // 
            materialSizeLabel.AutoSize = true;
            materialSizeLabel.Location = new System.Drawing.Point(36, 69);
            materialSizeLabel.Name = "materialSizeLabel";
            materialSizeLabel.Size = new System.Drawing.Size(70, 13);
            materialSizeLabel.TabIndex = 1;
            materialSizeLabel.Text = "Material Size:";
            // 
            // materialGradeLabel
            // 
            materialGradeLabel.AutoSize = true;
            materialGradeLabel.Location = new System.Drawing.Point(36, 95);
            materialGradeLabel.Name = "materialGradeLabel";
            materialGradeLabel.Size = new System.Drawing.Size(79, 13);
            materialGradeLabel.TabIndex = 3;
            materialGradeLabel.Text = "Material Grade:";
            // 
            // materialLengthLabel
            // 
            materialLengthLabel.AutoSize = true;
            materialLengthLabel.Location = new System.Drawing.Point(36, 121);
            materialLengthLabel.Name = "materialLengthLabel";
            materialLengthLabel.Size = new System.Drawing.Size(83, 13);
            materialLengthLabel.TabIndex = 5;
            materialLengthLabel.Text = "Material Length:";
            // 
            // heat_Label
            // 
            heat_Label.AutoSize = true;
            heat_Label.Location = new System.Drawing.Point(36, 147);
            heat_Label.Name = "heat_Label";
            heat_Label.Size = new System.Drawing.Size(40, 13);
            heat_Label.TabIndex = 7;
            heat_Label.Text = "Heat#:";
            // 
            // quickTurnDataSet
            // 
            this.quickTurnDataSet.DataSetName = "QuickTurnDataSet";
            this.quickTurnDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "inventory";
            this.inventoryBindingSource.DataSource = this.quickTurnDataSet;
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bar_stock_pricesTableAdapter = null;
            this.tableAdapterManager.employeesTableAdapter = null;
            this.tableAdapterManager.inventoryTableAdapter = this.inventoryTableAdapter;
            this.tableAdapterManager.part_filesTableAdapter = null;
            this.tableAdapterManager.schedule_boardTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Quick_Turn_App.QuickTurnDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // materialSizeTextBox
            // 
            this.materialSizeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "MaterialSize", true));
            this.materialSizeTextBox.Location = new System.Drawing.Point(125, 66);
            this.materialSizeTextBox.Name = "materialSizeTextBox";
            this.materialSizeTextBox.Size = new System.Drawing.Size(100, 20);
            this.materialSizeTextBox.TabIndex = 2;
            // 
            // materialGradeTextBox
            // 
            this.materialGradeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "MaterialGrade", true));
            this.materialGradeTextBox.Location = new System.Drawing.Point(125, 92);
            this.materialGradeTextBox.Name = "materialGradeTextBox";
            this.materialGradeTextBox.Size = new System.Drawing.Size(100, 20);
            this.materialGradeTextBox.TabIndex = 4;
            // 
            // materialLengthTextBox
            // 
            this.materialLengthTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "MaterialLength", true));
            this.materialLengthTextBox.Location = new System.Drawing.Point(125, 118);
            this.materialLengthTextBox.Name = "materialLengthTextBox";
            this.materialLengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.materialLengthTextBox.TabIndex = 6;
            // 
            // heat_TextBox
            // 
            this.heat_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "Heat#", true));
            this.heat_TextBox.Location = new System.Drawing.Point(125, 144);
            this.heat_TextBox.Name = "heat_TextBox";
            this.heat_TextBox.Size = new System.Drawing.Size(100, 20);
            this.heat_TextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Enter Inventory Item:";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(44, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Location = new System.Drawing.Point(140, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // inventoryform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 240);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(materialSizeLabel);
            this.Controls.Add(this.materialSizeTextBox);
            this.Controls.Add(materialGradeLabel);
            this.Controls.Add(this.materialGradeTextBox);
            this.Controls.Add(materialLengthLabel);
            this.Controls.Add(this.materialLengthTextBox);
            this.Controls.Add(heat_Label);
            this.Controls.Add(this.heat_TextBox);
            this.Name = "inventoryform";
            this.Text = "Inventory Form";
            this.Load += new System.EventHandler(this.inventoryform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quickTurnDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QuickTurnDataSet quickTurnDataSet;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private QuickTurnDataSetTableAdapters.inventoryTableAdapter inventoryTableAdapter;
        private QuickTurnDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox materialSizeTextBox;
        private System.Windows.Forms.TextBox materialGradeTextBox;
        private System.Windows.Forms.TextBox materialLengthTextBox;
        private System.Windows.Forms.TextBox heat_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}