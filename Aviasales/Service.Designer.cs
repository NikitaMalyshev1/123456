namespace Aviasales
{
    partial class Service
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
            System.Windows.Forms.Label service_IDLabel;
            System.Windows.Forms.Label service_NameLabel;
            System.Windows.Forms.Label hTTPLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Service));
            this.button1 = new System.Windows.Forms.Button();
            this.aviasalesDataSet = new Aviasales.AviasalesDataSet();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceTableAdapter = new Aviasales.AviasalesDataSetTableAdapters.ServiceTableAdapter();
            this.tableAdapterManager = new Aviasales.AviasalesDataSetTableAdapters.TableAdapterManager();
            this.serviceBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.serviceBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.serviceDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.service_IDTextBox = new System.Windows.Forms.TextBox();
            this.service_NameTextBox = new System.Windows.Forms.TextBox();
            this.hTTPTextBox = new System.Windows.Forms.TextBox();
            service_IDLabel = new System.Windows.Forms.Label();
            service_NameLabel = new System.Windows.Forms.Label();
            hTTPLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aviasalesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingNavigator)).BeginInit();
            this.serviceBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // service_IDLabel
            // 
            service_IDLabel.AutoSize = true;
            service_IDLabel.Location = new System.Drawing.Point(51, 79);
            service_IDLabel.Name = "service_IDLabel";
            service_IDLabel.Size = new System.Drawing.Size(86, 20);
            service_IDLabel.TabIndex = 8;
            service_IDLabel.Text = "Service ID:";
            // 
            // service_NameLabel
            // 
            service_NameLabel.AutoSize = true;
            service_NameLabel.Location = new System.Drawing.Point(51, 123);
            service_NameLabel.Name = "service_NameLabel";
            service_NameLabel.Size = new System.Drawing.Size(111, 20);
            service_NameLabel.TabIndex = 9;
            service_NameLabel.Text = "Service Name:";
            // 
            // hTTPLabel
            // 
            hTTPLabel.AutoSize = true;
            hTTPLabel.Location = new System.Drawing.Point(51, 166);
            hTTPLabel.Name = "hTTPLabel";
            hTTPLabel.Size = new System.Drawing.Size(53, 20);
            hTTPLabel.TabIndex = 10;
            hTTPLabel.Text = "HTTP:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 571);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 62);
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
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataMember = "Service";
            this.serviceBindingSource.DataSource = this.aviasalesDataSet;
            // 
            // serviceTableAdapter
            // 
            this.serviceTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Line_AviaTableAdapter = null;
            this.tableAdapterManager.Passenger_dataTableAdapter = null;
            this.tableAdapterManager.ServiceTableAdapter = this.serviceTableAdapter;
            this.tableAdapterManager.TicketTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Aviasales.AviasalesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // serviceBindingNavigator
            // 
            this.serviceBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.serviceBindingNavigator.BindingSource = this.serviceBindingSource;
            this.serviceBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.serviceBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.serviceBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.serviceBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.serviceBindingNavigatorSaveItem});
            this.serviceBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.serviceBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.serviceBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.serviceBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.serviceBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.serviceBindingNavigator.Name = "serviceBindingNavigator";
            this.serviceBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.serviceBindingNavigator.Size = new System.Drawing.Size(1081, 38);
            this.serviceBindingNavigator.TabIndex = 8;
            this.serviceBindingNavigator.Text = "bindingNavigator1";
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
            // serviceBindingNavigatorSaveItem
            // 
            this.serviceBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.serviceBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("serviceBindingNavigatorSaveItem.Image")));
            this.serviceBindingNavigatorSaveItem.Name = "serviceBindingNavigatorSaveItem";
            this.serviceBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 33);
            this.serviceBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.serviceBindingNavigatorSaveItem.Click += new System.EventHandler(this.serviceBindingNavigatorSaveItem_Click);
            // 
            // serviceDataGridView
            // 
            this.serviceDataGridView.AutoGenerateColumns = false;
            this.serviceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serviceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.serviceDataGridView.DataSource = this.serviceBindingSource;
            this.serviceDataGridView.Location = new System.Drawing.Point(525, 423);
            this.serviceDataGridView.Name = "serviceDataGridView";
            this.serviceDataGridView.RowHeadersWidth = 62;
            this.serviceDataGridView.RowTemplate.Height = 28;
            this.serviceDataGridView.Size = new System.Drawing.Size(515, 220);
            this.serviceDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Service_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Service_ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Service_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Service_Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "HTTP";
            this.dataGridViewTextBoxColumn3.HeaderText = "HTTP";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // service_IDTextBox
            // 
            this.service_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceBindingSource, "Service_ID", true));
            this.service_IDTextBox.Location = new System.Drawing.Point(168, 76);
            this.service_IDTextBox.Name = "service_IDTextBox";
            this.service_IDTextBox.Size = new System.Drawing.Size(186, 26);
            this.service_IDTextBox.TabIndex = 9;
            // 
            // service_NameTextBox
            // 
            this.service_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceBindingSource, "Service_Name", true));
            this.service_NameTextBox.Location = new System.Drawing.Point(168, 120);
            this.service_NameTextBox.Name = "service_NameTextBox";
            this.service_NameTextBox.Size = new System.Drawing.Size(325, 26);
            this.service_NameTextBox.TabIndex = 10;
            // 
            // hTTPTextBox
            // 
            this.hTTPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceBindingSource, "HTTP", true));
            this.hTTPTextBox.Location = new System.Drawing.Point(168, 160);
            this.hTTPTextBox.Name = "hTTPTextBox";
            this.hTTPTextBox.Size = new System.Drawing.Size(523, 26);
            this.hTTPTextBox.TabIndex = 11;
            // 
            // Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1081, 683);
            this.Controls.Add(hTTPLabel);
            this.Controls.Add(this.hTTPTextBox);
            this.Controls.Add(service_NameLabel);
            this.Controls.Add(this.service_NameTextBox);
            this.Controls.Add(service_IDLabel);
            this.Controls.Add(this.service_IDTextBox);
            this.Controls.Add(this.serviceDataGridView);
            this.Controls.Add(this.serviceBindingNavigator);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Service";
            this.Text = "Service";
            this.Load += new System.EventHandler(this.Service_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aviasalesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingNavigator)).EndInit();
            this.serviceBindingNavigator.ResumeLayout(false);
            this.serviceBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private AviasalesDataSet aviasalesDataSet;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private AviasalesDataSetTableAdapters.ServiceTableAdapter serviceTableAdapter;
        private AviasalesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator serviceBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton serviceBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView serviceDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox service_IDTextBox;
        private System.Windows.Forms.TextBox service_NameTextBox;
        private System.Windows.Forms.TextBox hTTPTextBox;
    }
}