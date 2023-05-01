namespace Aviasales
{
    partial class Line_Avia
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
            System.Windows.Forms.Label air_CarrierLabel;
            System.Windows.Forms.Label max_Count_of_peopleLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Line_Avia));
            this.button1 = new System.Windows.Forms.Button();
            this.aviasalesDataSet = new Aviasales.AviasalesDataSet();
            this.line_AviaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.line_AviaTableAdapter = new Aviasales.AviasalesDataSetTableAdapters.Line_AviaTableAdapter();
            this.tableAdapterManager = new Aviasales.AviasalesDataSetTableAdapters.TableAdapterManager();
            this.line_AviaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.line_AviaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.line_AviaDataGridView = new System.Windows.Forms.DataGridView();
            this.сity_FromTextBox = new System.Windows.Forms.TextBox();
            this.city_ToTextBox = new System.Windows.Forms.TextBox();
            this.air_CarrierTextBox = new System.Windows.Forms.TextBox();
            this.max_Count_of_peopleTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            сity_FromLabel = new System.Windows.Forms.Label();
            city_ToLabel = new System.Windows.Forms.Label();
            air_CarrierLabel = new System.Windows.Forms.Label();
            max_Count_of_peopleLabel = new System.Windows.Forms.Label();
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
            сity_FromLabel.Location = new System.Drawing.Point(683, 62);
            сity_FromLabel.Name = "сity_FromLabel";
            сity_FromLabel.Size = new System.Drawing.Size(303, 37);
            сity_FromLabel.TabIndex = 13;
            сity_FromLabel.Text = "Пункт отправления\r\n";
            // 
            // city_ToLabel
            // 
            city_ToLabel.AutoSize = true;
            city_ToLabel.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            city_ToLabel.Location = new System.Drawing.Point(683, 167);
            city_ToLabel.Name = "city_ToLabel";
            city_ToLabel.Size = new System.Drawing.Size(261, 37);
            city_ToLabel.TabIndex = 14;
            city_ToLabel.Text = "Пункт прибытия";
            // 
            // air_CarrierLabel
            // 
            air_CarrierLabel.AutoSize = true;
            air_CarrierLabel.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            air_CarrierLabel.Location = new System.Drawing.Point(33, 68);
            air_CarrierLabel.Name = "air_CarrierLabel";
            air_CarrierLabel.Size = new System.Drawing.Size(262, 37);
            air_CarrierLabel.TabIndex = 15;
            air_CarrierLabel.Text = "Авиаперевозчик";
            // 
            // max_Count_of_peopleLabel
            // 
            max_Count_of_peopleLabel.AutoSize = true;
            max_Count_of_peopleLabel.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            max_Count_of_peopleLabel.Location = new System.Drawing.Point(33, 217);
            max_Count_of_peopleLabel.Name = "max_Count_of_peopleLabel";
            max_Count_of_peopleLabel.Size = new System.Drawing.Size(419, 74);
            max_Count_of_peopleLabel.TabIndex = 16;
            max_Count_of_peopleLabel.Text = "Вместительность самолета \r\n(кол-во пассажиров)";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(28, 617);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 60);
            this.button1.TabIndex = 11;
            this.button1.Text = "Main Menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.line_AviaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.line_AviaBindingNavigator.BindingSource = this.line_AviaBindingSource;
            this.line_AviaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.line_AviaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
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
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.line_AviaBindingNavigatorSaveItem});
            this.line_AviaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.line_AviaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.line_AviaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.line_AviaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.line_AviaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.line_AviaBindingNavigator.Name = "line_AviaBindingNavigator";
            this.line_AviaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.line_AviaBindingNavigator.Size = new System.Drawing.Size(1145, 33);
            this.line_AviaBindingNavigator.TabIndex = 12;
            this.line_AviaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(65, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // line_AviaBindingNavigatorSaveItem
            // 
            this.line_AviaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.line_AviaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("line_AviaBindingNavigatorSaveItem.Image")));
            this.line_AviaBindingNavigatorSaveItem.Name = "line_AviaBindingNavigatorSaveItem";
            this.line_AviaBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.line_AviaBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.line_AviaBindingNavigatorSaveItem.Click += new System.EventHandler(this.line_AviaBindingNavigatorSaveItem_Click);
            // 
            // line_AviaDataGridView
            // 
            this.line_AviaDataGridView.AutoGenerateColumns = false;
            this.line_AviaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.line_AviaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.line_AviaDataGridView.DataSource = this.line_AviaBindingSource;
            this.line_AviaDataGridView.Location = new System.Drawing.Point(271, 339);
            this.line_AviaDataGridView.Name = "line_AviaDataGridView";
            this.line_AviaDataGridView.RowHeadersWidth = 62;
            this.line_AviaDataGridView.RowTemplate.Height = 28;
            this.line_AviaDataGridView.Size = new System.Drawing.Size(862, 308);
            this.line_AviaDataGridView.TabIndex = 12;
            // 
            // сity_FromTextBox
            // 
            this.сity_FromTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.line_AviaBindingSource, "Сity_From", true));
            this.сity_FromTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.сity_FromTextBox.Location = new System.Drawing.Point(808, 115);
            this.сity_FromTextBox.Multiline = true;
            this.сity_FromTextBox.Name = "сity_FromTextBox";
            this.сity_FromTextBox.Size = new System.Drawing.Size(290, 49);
            this.сity_FromTextBox.TabIndex = 14;
            // 
            // city_ToTextBox
            // 
            this.city_ToTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.line_AviaBindingSource, "City_To", true));
            this.city_ToTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.city_ToTextBox.Location = new System.Drawing.Point(808, 217);
            this.city_ToTextBox.Multiline = true;
            this.city_ToTextBox.Name = "city_ToTextBox";
            this.city_ToTextBox.Size = new System.Drawing.Size(290, 49);
            this.city_ToTextBox.TabIndex = 15;
            // 
            // air_CarrierTextBox
            // 
            this.air_CarrierTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.line_AviaBindingSource, "Air_Carrier", true));
            this.air_CarrierTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.air_CarrierTextBox.Location = new System.Drawing.Point(301, 62);
            this.air_CarrierTextBox.Multiline = true;
            this.air_CarrierTextBox.Name = "air_CarrierTextBox";
            this.air_CarrierTextBox.Size = new System.Drawing.Size(290, 49);
            this.air_CarrierTextBox.TabIndex = 16;
            // 
            // max_Count_of_peopleTextBox
            // 
            this.max_Count_of_peopleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.line_AviaBindingSource, "Max_Count_of_people", true));
            this.max_Count_of_peopleTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.max_Count_of_peopleTextBox.Location = new System.Drawing.Point(458, 242);
            this.max_Count_of_peopleTextBox.Multiline = true;
            this.max_Count_of_peopleTextBox.Name = "max_Count_of_peopleTextBox";
            this.max_Count_of_peopleTextBox.Size = new System.Drawing.Size(138, 49);
            this.max_Count_of_peopleTextBox.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Сity_From";
            this.dataGridViewTextBoxColumn2.HeaderText = "Пункт отправления";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "City_To";
            this.dataGridViewTextBoxColumn3.HeaderText = "Пункт назначения";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Air_Carrier";
            this.dataGridViewTextBoxColumn4.HeaderText = "Авиаперевозчик";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Max_Count_of_people";
            this.dataGridViewTextBoxColumn5.HeaderText = "Вместительность салона";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // Line_Avia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1145, 719);
            this.Controls.Add(max_Count_of_peopleLabel);
            this.Controls.Add(this.max_Count_of_peopleTextBox);
            this.Controls.Add(air_CarrierLabel);
            this.Controls.Add(this.air_CarrierTextBox);
            this.Controls.Add(city_ToLabel);
            this.Controls.Add(this.city_ToTextBox);
            this.Controls.Add(сity_FromLabel);
            this.Controls.Add(this.сity_FromTextBox);
            this.Controls.Add(this.line_AviaDataGridView);
            this.Controls.Add(this.line_AviaBindingNavigator);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Line_Avia";
            this.Text = "Line_Avia";
            this.Load += new System.EventHandler(this.Line_Avia_Load);
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
        private System.Windows.Forms.Button button1;
        private AviasalesDataSet aviasalesDataSet;
        private System.Windows.Forms.BindingSource line_AviaBindingSource;
        private AviasalesDataSetTableAdapters.Line_AviaTableAdapter line_AviaTableAdapter;
        private AviasalesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator line_AviaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton line_AviaBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView line_AviaDataGridView;
        private System.Windows.Forms.TextBox сity_FromTextBox;
        private System.Windows.Forms.TextBox city_ToTextBox;
        private System.Windows.Forms.TextBox air_CarrierTextBox;
        private System.Windows.Forms.TextBox max_Count_of_peopleTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}