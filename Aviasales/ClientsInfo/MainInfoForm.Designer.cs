namespace Aviasales.ClientsInfo
{
    partial class MainInfoForm
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
            System.Windows.Forms.Label сity_FromLabel;
            System.Windows.Forms.Label city_ToLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainInfoForm));
            this.aviasalesDataSet = new Aviasales.AviasalesDataSet();
            this.line_AviaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.line_AviaTableAdapter = new Aviasales.AviasalesDataSetTableAdapters.Line_AviaTableAdapter();
            this.tableAdapterManager = new Aviasales.AviasalesDataSetTableAdapters.TableAdapterManager();
            this.line_AviaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.сity_FromTextBox = new System.Windows.Forms.TextBox();
            this.city_ToTextBox = new System.Windows.Forms.TextBox();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.checkBoxMoreInfo = new System.Windows.Forms.CheckBox();
            this.line_AviaDataGridView = new System.Windows.Forms.DataGridView();
            сity_FromLabel = new System.Windows.Forms.Label();
            city_ToLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aviasalesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line_AviaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line_AviaBindingNavigator)).BeginInit();
            this.line_AviaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.line_AviaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // сity_FromLabel
            // 
            сity_FromLabel.AutoSize = true;
            сity_FromLabel.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            сity_FromLabel.Location = new System.Drawing.Point(12, 69);
            сity_FromLabel.Name = "сity_FromLabel";
            сity_FromLabel.Size = new System.Drawing.Size(303, 37);
            сity_FromLabel.TabIndex = 3;
            сity_FromLabel.Text = "Пункт отправления";
            // 
            // city_ToLabel
            // 
            city_ToLabel.AutoSize = true;
            city_ToLabel.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            city_ToLabel.Location = new System.Drawing.Point(12, 132);
            city_ToLabel.Name = "city_ToLabel";
            city_ToLabel.Size = new System.Drawing.Size(283, 37);
            city_ToLabel.TabIndex = 5;
            city_ToLabel.Text = "Пункт назначения";
            // 
            // aviasalesDataSet
            // 
            this.aviasalesDataSet.DataSetName = "AviasalesDataSet";
            this.aviasalesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // line_AviaBindingSource
            // 
            this.line_AviaBindingSource.DataMember = "Line_Avia";
            this.line_AviaBindingSource.DataSource = this.aviasalesDataSet;
            // 
            // line_AviaTableAdapter
            // 
            this.line_AviaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Line_AviaTableAdapter = this.line_AviaTableAdapter;
            this.tableAdapterManager.Passenger_dataTableAdapter = null;
            this.tableAdapterManager.ServiceTableAdapter = null;
            this.tableAdapterManager.TicketTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Aviasales.AviasalesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // line_AviaBindingNavigator
            // 
            this.line_AviaBindingNavigator.AddNewItem = null;
            this.line_AviaBindingNavigator.BindingSource = this.line_AviaBindingSource;
            this.line_AviaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.line_AviaBindingNavigator.DeleteItem = null;
            this.line_AviaBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.line_AviaBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.line_AviaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.line_AviaBindingNavigator.Location = new System.Drawing.Point(9, 9);
            this.line_AviaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.line_AviaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.line_AviaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.line_AviaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.line_AviaBindingNavigator.Name = "line_AviaBindingNavigator";
            this.line_AviaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.line_AviaBindingNavigator.Size = new System.Drawing.Size(291, 38);
            this.line_AviaBindingNavigator.TabIndex = 0;
            this.line_AviaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(65, 33);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            // сity_FromTextBox
            // 
            this.сity_FromTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.line_AviaBindingSource, "Сity_From", true));
            this.сity_FromTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.сity_FromTextBox.Location = new System.Drawing.Point(321, 53);
            this.сity_FromTextBox.Multiline = true;
            this.сity_FromTextBox.Name = "сity_FromTextBox";
            this.сity_FromTextBox.Size = new System.Drawing.Size(316, 53);
            this.сity_FromTextBox.TabIndex = 4;
            // 
            // city_ToTextBox
            // 
            this.city_ToTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.line_AviaBindingSource, "City_To", true));
            this.city_ToTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.city_ToTextBox.Location = new System.Drawing.Point(321, 116);
            this.city_ToTextBox.Multiline = true;
            this.city_ToTextBox.Name = "city_ToTextBox";
            this.city_ToTextBox.Size = new System.Drawing.Size(316, 53);
            this.city_ToTextBox.TabIndex = 6;
            // 
            // buttonSelect
            // 
            this.buttonSelect.BackColor = System.Drawing.SystemColors.Info;
            this.buttonSelect.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSelect.Location = new System.Drawing.Point(685, 69);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(195, 84);
            this.buttonSelect.TabIndex = 11;
            this.buttonSelect.Text = "Поиск рейсов";
            this.buttonSelect.UseVisualStyleBackColor = false;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.Info;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(19, 605);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(172, 63);
            this.buttonBack.TabIndex = 12;
            this.buttonBack.Text = "Назад\r\n";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBoxMoreInfo
            // 
            this.checkBoxMoreInfo.AutoSize = true;
            this.checkBoxMoreInfo.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxMoreInfo.Location = new System.Drawing.Point(123, 251);
            this.checkBoxMoreInfo.Name = "checkBoxMoreInfo";
            this.checkBoxMoreInfo.Size = new System.Drawing.Size(353, 41);
            this.checkBoxMoreInfo.TabIndex = 13;
            this.checkBoxMoreInfo.Text = "Полная информация";
            this.checkBoxMoreInfo.UseVisualStyleBackColor = true;
            // 
            // line_AviaDataGridView
            // 
            this.line_AviaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.line_AviaDataGridView.Location = new System.Drawing.Point(123, 298);
            this.line_AviaDataGridView.Name = "line_AviaDataGridView";
            this.line_AviaDataGridView.RowHeadersWidth = 62;
            this.line_AviaDataGridView.RowTemplate.Height = 28;
            this.line_AviaDataGridView.Size = new System.Drawing.Size(1013, 279);
            this.line_AviaDataGridView.TabIndex = 14;
            // 
            // MainInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1148, 680);
            this.Controls.Add(this.line_AviaDataGridView);
            this.Controls.Add(this.checkBoxMoreInfo);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(сity_FromLabel);
            this.Controls.Add(this.сity_FromTextBox);
            this.Controls.Add(city_ToLabel);
            this.Controls.Add(this.city_ToTextBox);
            this.Controls.Add(this.line_AviaBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainInfoForm";
            this.Text = "Информация о рейсах";
            this.Load += new System.EventHandler(this.MainInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aviasalesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line_AviaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line_AviaBindingNavigator)).EndInit();
            this.line_AviaBindingNavigator.ResumeLayout(false);
            this.line_AviaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.line_AviaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AviasalesDataSet aviasalesDataSet;
        private System.Windows.Forms.BindingSource line_AviaBindingSource;
        private AviasalesDataSetTableAdapters.Line_AviaTableAdapter line_AviaTableAdapter;
        private AviasalesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator line_AviaBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox сity_FromTextBox;
        private System.Windows.Forms.TextBox city_ToTextBox;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.CheckBox checkBoxMoreInfo;
        private System.Windows.Forms.DataGridView line_AviaDataGridView;
    }
}