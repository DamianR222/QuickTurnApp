namespace Quick_Turn_App
{
    partial class barstockpricesform
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
            System.Windows.Forms.Label barStockDiameterLabel;
            System.Windows.Forms.Label pricePaidLabel;
            System.Windows.Forms.Label prevPricePaidLabel;
            System.Windows.Forms.Label lowestPricePaidLabel;
            System.Windows.Forms.Label highestPricePaidLabel;
            System.Windows.Forms.Label companyLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.quickTurnDataSet = new Quick_Turn_App.QuickTurnDataSet();
            this.bar_stock_pricesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bar_stock_pricesTableAdapter = new Quick_Turn_App.QuickTurnDataSetTableAdapters.bar_stock_pricesTableAdapter();
            this.tableAdapterManager = new Quick_Turn_App.QuickTurnDataSetTableAdapters.TableAdapterManager();
            this.barStockDiameterTextBox = new System.Windows.Forms.TextBox();
            this.pricePaidTextBox = new System.Windows.Forms.TextBox();
            this.prevPricePaidTextBox = new System.Windows.Forms.TextBox();
            this.lowestPricePaidTextBox = new System.Windows.Forms.TextBox();
            this.highestPricePaidTextBox = new System.Windows.Forms.TextBox();
            this.companyTextBox = new System.Windows.Forms.TextBox();
            barStockDiameterLabel = new System.Windows.Forms.Label();
            pricePaidLabel = new System.Windows.Forms.Label();
            prevPricePaidLabel = new System.Windows.Forms.Label();
            lowestPricePaidLabel = new System.Windows.Forms.Label();
            highestPricePaidLabel = new System.Windows.Forms.Label();
            companyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quickTurnDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar_stock_pricesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // barStockDiameterLabel
            // 
            barStockDiameterLabel.AutoSize = true;
            barStockDiameterLabel.Location = new System.Drawing.Point(46, 81);
            barStockDiameterLabel.Name = "barStockDiameterLabel";
            barStockDiameterLabel.Size = new System.Drawing.Size(102, 13);
            barStockDiameterLabel.TabIndex = 4;
            barStockDiameterLabel.Text = "Bar Stock Diameter:";
            // 
            // pricePaidLabel
            // 
            pricePaidLabel.AutoSize = true;
            pricePaidLabel.Location = new System.Drawing.Point(46, 107);
            pricePaidLabel.Name = "pricePaidLabel";
            pricePaidLabel.Size = new System.Drawing.Size(58, 13);
            pricePaidLabel.TabIndex = 6;
            pricePaidLabel.Text = "Price Paid:";
            // 
            // prevPricePaidLabel
            // 
            prevPricePaidLabel.AutoSize = true;
            prevPricePaidLabel.Location = new System.Drawing.Point(46, 133);
            prevPricePaidLabel.Name = "prevPricePaidLabel";
            prevPricePaidLabel.Size = new System.Drawing.Size(83, 13);
            prevPricePaidLabel.TabIndex = 8;
            prevPricePaidLabel.Text = "Prev Price Paid:";
            // 
            // lowestPricePaidLabel
            // 
            lowestPricePaidLabel.AutoSize = true;
            lowestPricePaidLabel.Location = new System.Drawing.Point(46, 159);
            lowestPricePaidLabel.Name = "lowestPricePaidLabel";
            lowestPricePaidLabel.Size = new System.Drawing.Size(95, 13);
            lowestPricePaidLabel.TabIndex = 10;
            lowestPricePaidLabel.Text = "Lowest Price Paid:";
            // 
            // highestPricePaidLabel
            // 
            highestPricePaidLabel.AutoSize = true;
            highestPricePaidLabel.Location = new System.Drawing.Point(46, 185);
            highestPricePaidLabel.Name = "highestPricePaidLabel";
            highestPricePaidLabel.Size = new System.Drawing.Size(97, 13);
            highestPricePaidLabel.TabIndex = 12;
            highestPricePaidLabel.Text = "Highest Price Paid:";
            // 
            // companyLabel
            // 
            companyLabel.AutoSize = true;
            companyLabel.Location = new System.Drawing.Point(46, 211);
            companyLabel.Name = "companyLabel";
            companyLabel.Size = new System.Drawing.Size(54, 13);
            companyLabel.TabIndex = 14;
            companyLabel.Text = "Company:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Bar Stock:";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(54, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Location = new System.Drawing.Point(165, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // quickTurnDataSet
            // 
            this.quickTurnDataSet.DataSetName = "QuickTurnDataSet";
            this.quickTurnDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bar_stock_pricesBindingSource
            // 
            this.bar_stock_pricesBindingSource.DataMember = "bar_stock_prices";
            this.bar_stock_pricesBindingSource.DataSource = this.quickTurnDataSet;
            // 
            // bar_stock_pricesTableAdapter
            // 
            this.bar_stock_pricesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bar_stock_pricesTableAdapter = this.bar_stock_pricesTableAdapter;
            this.tableAdapterManager.employeesTableAdapter = null;
            this.tableAdapterManager.inventoryTableAdapter = null;
            this.tableAdapterManager.part_filesTableAdapter = null;
            this.tableAdapterManager.schedule_boardTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Quick_Turn_App.QuickTurnDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // barStockDiameterTextBox
            // 
            this.barStockDiameterTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bar_stock_pricesBindingSource, "BarStockDiameter", true));
            this.barStockDiameterTextBox.Location = new System.Drawing.Point(154, 78);
            this.barStockDiameterTextBox.Name = "barStockDiameterTextBox";
            this.barStockDiameterTextBox.Size = new System.Drawing.Size(100, 20);
            this.barStockDiameterTextBox.TabIndex = 5;
            // 
            // pricePaidTextBox
            // 
            this.pricePaidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bar_stock_pricesBindingSource, "PricePaid", true));
            this.pricePaidTextBox.Location = new System.Drawing.Point(154, 104);
            this.pricePaidTextBox.Name = "pricePaidTextBox";
            this.pricePaidTextBox.Size = new System.Drawing.Size(100, 20);
            this.pricePaidTextBox.TabIndex = 7;
            // 
            // prevPricePaidTextBox
            // 
            this.prevPricePaidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bar_stock_pricesBindingSource, "PrevPricePaid", true));
            this.prevPricePaidTextBox.Location = new System.Drawing.Point(154, 130);
            this.prevPricePaidTextBox.Name = "prevPricePaidTextBox";
            this.prevPricePaidTextBox.Size = new System.Drawing.Size(100, 20);
            this.prevPricePaidTextBox.TabIndex = 9;
            // 
            // lowestPricePaidTextBox
            // 
            this.lowestPricePaidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bar_stock_pricesBindingSource, "LowestPricePaid", true));
            this.lowestPricePaidTextBox.Location = new System.Drawing.Point(154, 156);
            this.lowestPricePaidTextBox.Name = "lowestPricePaidTextBox";
            this.lowestPricePaidTextBox.Size = new System.Drawing.Size(100, 20);
            this.lowestPricePaidTextBox.TabIndex = 11;
            // 
            // highestPricePaidTextBox
            // 
            this.highestPricePaidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bar_stock_pricesBindingSource, "HighestPricePaid", true));
            this.highestPricePaidTextBox.Location = new System.Drawing.Point(154, 182);
            this.highestPricePaidTextBox.Name = "highestPricePaidTextBox";
            this.highestPricePaidTextBox.Size = new System.Drawing.Size(100, 20);
            this.highestPricePaidTextBox.TabIndex = 13;
            // 
            // companyTextBox
            // 
            this.companyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bar_stock_pricesBindingSource, "Company", true));
            this.companyTextBox.Location = new System.Drawing.Point(154, 208);
            this.companyTextBox.Name = "companyTextBox";
            this.companyTextBox.Size = new System.Drawing.Size(100, 20);
            this.companyTextBox.TabIndex = 15;
            // 
            // barstockpricesform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 311);
            this.Controls.Add(barStockDiameterLabel);
            this.Controls.Add(this.barStockDiameterTextBox);
            this.Controls.Add(pricePaidLabel);
            this.Controls.Add(this.pricePaidTextBox);
            this.Controls.Add(prevPricePaidLabel);
            this.Controls.Add(this.prevPricePaidTextBox);
            this.Controls.Add(lowestPricePaidLabel);
            this.Controls.Add(this.lowestPricePaidTextBox);
            this.Controls.Add(highestPricePaidLabel);
            this.Controls.Add(this.highestPricePaidTextBox);
            this.Controls.Add(companyLabel);
            this.Controls.Add(this.companyTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "barstockpricesform";
            this.Text = "Bar Stock Prices Form";
            this.Load += new System.EventHandler(this.barstockpricesform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quickTurnDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar_stock_pricesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private QuickTurnDataSet quickTurnDataSet;
        private System.Windows.Forms.BindingSource bar_stock_pricesBindingSource;
        private QuickTurnDataSetTableAdapters.bar_stock_pricesTableAdapter bar_stock_pricesTableAdapter;
        private QuickTurnDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox barStockDiameterTextBox;
        private System.Windows.Forms.TextBox pricePaidTextBox;
        private System.Windows.Forms.TextBox prevPricePaidTextBox;
        private System.Windows.Forms.TextBox lowestPricePaidTextBox;
        private System.Windows.Forms.TextBox highestPricePaidTextBox;
        private System.Windows.Forms.TextBox companyTextBox;
    }
}