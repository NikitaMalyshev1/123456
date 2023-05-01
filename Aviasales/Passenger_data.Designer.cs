namespace Aviasales
{
    partial class Passenger_data
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
            System.Windows.Forms.Label iD_LineLabel;
            System.Windows.Forms.Label service_IDLabel;
            System.Windows.Forms.Label totalLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Passenger_data));
            this.button1 = new System.Windows.Forms.Button();
            this.aviasalesDataSet = new Aviasales.AviasalesDataSet();
            this.passenger_dataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.passenger_dataTableAdapter = new Aviasales.AviasalesDataSetTableAdapters.Passenger_dataTableAdapter();
            this.tableAdapterManager = new Aviasales.AviasalesDataSetTableAdapters.TableAdapterManager();
            this.passenger_dataBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.passenger_dataBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.passenger_dataDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iD_LineTextBox = new System.Windows.Forms.TextBox();
            this.service_IDTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            iD_LineLabel = new System.Windows.Forms.Label();
            service_IDLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aviasalesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passenger_dataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passenger_dataBindingNavigator)).BeginInit();
            this.passenger_dataBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passenger_dataDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_LineLabel
            // 
            iD_LineLabel.AutoSize = true;
            iD_LineLabel.Location = new System.Drawing.Point(42, 110);
            iD_LineLabel.Name = "iD_LineLabel";
            iD_LineLabel.Size = new System.Drawing.Size(64, 20);
            iD_LineLabel.TabIndex = 3;
            iD_LineLabel.Text = "ID Line:";
            // 
            // service_IDLabel
            // 
            service_IDLabel.AutoSize = true;
            service_IDLabel.Location = new System.Drawing.Point(42, 163);
            service_IDLabel.Name = "service_IDLabel";
            service_IDLabel.Size = new System.Drawing.Size(86, 20);
            service_IDLabel.TabIndex = 5;
            service_IDLabel.Text = "Service ID:";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new System.Drawing.Point(42, 221);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(48, 20);
            totalLabel.TabIndex = 7;
            totalLabel.Text = "Total:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 619);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 72);
            this.button1.TabIndex = 0;
            this.button1.Text = "Main Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // aviasalesDataSet
            // 
            this.aviasalesDataSet.DataSetName = "AviasalesDataSet";
            this.aviasalesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // passenger_dataBindingSource
            // 
            this.passenger_dataBindingSource.DataMember = "Passenger_data";
            this.passenger_dataBindingSource.DataSource = this.aviasalesDataSet;
            // 
            // passenger_dataTableAdapter
            // 
            this.passenger_dataTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Line_AviaTableAdapter = null;
            this.tableAdapterManager.Passenger_dataTableAdapter = this.passenger_dataTableAdapter;
            this.tableAdapterManager.ServiceTableAdapter = null;
            this.tableAdapterManager.TicketTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Aviasales.AviasalesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // passenger_dataBindingNavigator
            // 
            this.passenger_dataBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.passenger_dataBindingNavigator.BindingSource = this.passenger_dataBindingSource;
            this.passenger_dataBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.passenger_dataBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.passenger_dataBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.passenger_dataBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.passenger_dataBindingNavigatorSaveItem});
            this.passenger_dataBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.passenger_dataBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.passenger_dataBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.passenger_dataBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.passenger_dataBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.passenger_dataBindingNavigator.Name = "passenger_dataBindingNavigator";
            this.passenger_dataBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.passenger_dataBindingNavigator.Size = new System.Drawing.Size(1075, 38);
            this.passenger_dataBindingNavigator.TabIndex = 1;
            this.passenger_dataBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(65, 33);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // passenger_dataBindingNavigatorSaveItem
            // 
            this.passenger_dataBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.passenger_dataBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("passenger_dataBindingNavigatorSaveItem.Image")));
            this.passenger_dataBindingNavigatorSaveItem.Name = "passenger_dataBindingNavigatorSaveItem";
            this.passenger_dataBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 33);
            this.passenger_dataBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.passenger_dataBindingNavigatorSaveItem.Click += new System.EventHandler(this.passenger_dataBindingNavigatorSaveItem_Click);
            // 
            // passenger_dataDataGridView
            // 
            this.passenger_dataDataGridView.AutoGenerateColumns = false;
            this.passenger_dataDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.passenger_dataDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.passenger_dataDataGridView.DataSource = this.passenger_dataBindingSource;
            this.passenger_dataDataGridView.Location = new System.Drawing.Point(484, 332);
            this.passenger_dataDataGridView.Name = "passenger_dataDataGridView";
            this.passenger_dataDataGridView.RowHeadersWidth = 62;
            this.passenger_dataDataGridView.RowTemplate.Height = 28;
            this.passenger_dataDataGridView.Size = new System.Drawing.Size(567, 359);
            this.passenger_dataDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Line";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Line";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Service_ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "Service_ID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Total";
            this.dataGridViewTextBoxColumn3.HeaderText = "Total";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // iD_LineTextBox
            // 
            this.iD_LineTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.passenger_dataBindingSource, "ID_Line", true));
            this.iD_LineTextBox.Location = new System.Drawing.Point(142, 110);
            this.iD_LineTextBox.Name = "iD_LineTextBox";
            this.iD_LineTextBox.Size = new System.Drawing.Size(158, 26);
            this.iD_LineTextBox.TabIndex = 4;
            // 
            // service_IDTextBox
            // 
            this.service_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.passenger_dataBindingSource, "Service_ID", true));
            this.service_IDTextBox.Location = new System.Drawing.Point(142, 163);
            this.service_IDTextBox.Name = "service_IDTextBox";
            this.service_IDTextBox.Size = new System.Drawing.Size(158, 26);
            this.service_IDTextBox.TabIndex = 6;
            // 
            // totalTextBox
            // 
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.passenger_dataBindingSource, "Total", true));
            this.totalTextBox.Location = new System.Drawing.Point(142, 215);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(202, 26);
            this.totalTextBox.TabIndex = 8;
            // 
            // Passenger_data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1075, 721);
            this.Controls.Add(totalLabel);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(service_IDLabel);
            this.Controls.Add(this.service_IDTextBox);
            this.Controls.Add(iD_LineLabel);
            this.Controls.Add(this.iD_LineTextBox);
            this.Controls.Add(this.passenger_dataDataGridView);
            this.Controls.Add(this.passenger_dataBindingNavigator);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Passenger_data";
            this.Text = "Passenger_data";
            this.Load += new System.EventHandler(this.Passenger_data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aviasalesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passenger_dataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passenger_dataBindingNavigator)).EndInit();
            this.passenger_dataBindingNavigator.ResumeLayout(false);
            this.passenger_dataBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passenger_dataDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private AviasalesDataSet aviasalesDataSet;
        private System.Windows.Forms.BindingSource passenger_dataBindingSource;
        private AviasalesDataSetTableAdapters.Passenger_dataTableAdapter passenger_dataTableAdapter;
        private AviasalesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator passenger_dataBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton passenger_dataBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView passenger_dataDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox iD_LineTextBox;
        private System.Windows.Forms.TextBox service_IDTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
    }
}