namespace Aviasales
{
    partial class Ticket
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
            System.Windows.Forms.Label ticket_IDLabel;
            System.Windows.Forms.Label iD_LineLabel;
            System.Windows.Forms.Label service_IDLabel;
            System.Windows.Forms.Label user_IDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ticket));
            this.button1 = new System.Windows.Forms.Button();
            this.aviasalesDataSet = new Aviasales.AviasalesDataSet();
            this.ticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketTableAdapter = new Aviasales.AviasalesDataSetTableAdapters.TicketTableAdapter();
            this.tableAdapterManager = new Aviasales.AviasalesDataSetTableAdapters.TableAdapterManager();
            this.ticketBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.ticketBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.ticket_IDTextBox = new System.Windows.Forms.TextBox();
            this.iD_LineTextBox = new System.Windows.Forms.TextBox();
            this.service_IDTextBox = new System.Windows.Forms.TextBox();
            this.user_IDTextBox = new System.Windows.Forms.TextBox();
            this.ticketDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            ticket_IDLabel = new System.Windows.Forms.Label();
            iD_LineLabel = new System.Windows.Forms.Label();
            service_IDLabel = new System.Windows.Forms.Label();
            user_IDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aviasalesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingNavigator)).BeginInit();
            this.ticketBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ticket_IDLabel
            // 
            ticket_IDLabel.AutoSize = true;
            ticket_IDLabel.Location = new System.Drawing.Point(55, 95);
            ticket_IDLabel.Name = "ticket_IDLabel";
            ticket_IDLabel.Size = new System.Drawing.Size(76, 20);
            ticket_IDLabel.TabIndex = 2;
            ticket_IDLabel.Text = "Ticket ID:";
            // 
            // iD_LineLabel
            // 
            iD_LineLabel.AutoSize = true;
            iD_LineLabel.Location = new System.Drawing.Point(67, 137);
            iD_LineLabel.Name = "iD_LineLabel";
            iD_LineLabel.Size = new System.Drawing.Size(64, 20);
            iD_LineLabel.TabIndex = 4;
            iD_LineLabel.Text = "ID Line:";
            // 
            // service_IDLabel
            // 
            service_IDLabel.AutoSize = true;
            service_IDLabel.Location = new System.Drawing.Point(45, 180);
            service_IDLabel.Name = "service_IDLabel";
            service_IDLabel.Size = new System.Drawing.Size(86, 20);
            service_IDLabel.TabIndex = 6;
            service_IDLabel.Text = "Service ID:";
            // 
            // user_IDLabel
            // 
            user_IDLabel.AutoSize = true;
            user_IDLabel.Location = new System.Drawing.Point(63, 229);
            user_IDLabel.Name = "user_IDLabel";
            user_IDLabel.Size = new System.Drawing.Size(68, 20);
            user_IDLabel.TabIndex = 8;
            user_IDLabel.Text = "User ID:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 598);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 57);
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
            // ticketBindingSource
            // 
            this.ticketBindingSource.DataMember = "Ticket";
            this.ticketBindingSource.DataSource = this.aviasalesDataSet;
            // 
            // ticketTableAdapter
            // 
            this.ticketTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Line_AviaTableAdapter = null;
            this.tableAdapterManager.Passenger_dataTableAdapter = null;
            this.tableAdapterManager.ServiceTableAdapter = null;
            this.tableAdapterManager.TicketTableAdapter = this.ticketTableAdapter;
            this.tableAdapterManager.UpdateOrder = Aviasales.AviasalesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // ticketBindingNavigator
            // 
            this.ticketBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ticketBindingNavigator.BindingSource = this.ticketBindingSource;
            this.ticketBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ticketBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ticketBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ticketBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.ticketBindingNavigatorSaveItem});
            this.ticketBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ticketBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ticketBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ticketBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ticketBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ticketBindingNavigator.Name = "ticketBindingNavigator";
            this.ticketBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ticketBindingNavigator.Size = new System.Drawing.Size(1074, 33);
            this.ticketBindingNavigator.TabIndex = 1;
            this.ticketBindingNavigator.Text = "bindingNavigator1";
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
            // ticketBindingNavigatorSaveItem
            // 
            this.ticketBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ticketBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ticketBindingNavigatorSaveItem.Image")));
            this.ticketBindingNavigatorSaveItem.Name = "ticketBindingNavigatorSaveItem";
            this.ticketBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.ticketBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.ticketBindingNavigatorSaveItem.Click += new System.EventHandler(this.ticketBindingNavigatorSaveItem_Click);
            // 
            // ticket_IDTextBox
            // 
            this.ticket_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketBindingSource, "Ticket_ID", true));
            this.ticket_IDTextBox.Location = new System.Drawing.Point(137, 92);
            this.ticket_IDTextBox.Name = "ticket_IDTextBox";
            this.ticket_IDTextBox.Size = new System.Drawing.Size(183, 26);
            this.ticket_IDTextBox.TabIndex = 3;
            // 
            // iD_LineTextBox
            // 
            this.iD_LineTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketBindingSource, "ID_Line", true));
            this.iD_LineTextBox.Location = new System.Drawing.Point(137, 134);
            this.iD_LineTextBox.Name = "iD_LineTextBox";
            this.iD_LineTextBox.Size = new System.Drawing.Size(183, 26);
            this.iD_LineTextBox.TabIndex = 5;
            // 
            // service_IDTextBox
            // 
            this.service_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketBindingSource, "Service_ID", true));
            this.service_IDTextBox.Location = new System.Drawing.Point(137, 177);
            this.service_IDTextBox.Name = "service_IDTextBox";
            this.service_IDTextBox.Size = new System.Drawing.Size(183, 26);
            this.service_IDTextBox.TabIndex = 7;
            // 
            // user_IDTextBox
            // 
            this.user_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketBindingSource, "User_ID", true));
            this.user_IDTextBox.Location = new System.Drawing.Point(137, 226);
            this.user_IDTextBox.Name = "user_IDTextBox";
            this.user_IDTextBox.Size = new System.Drawing.Size(183, 26);
            this.user_IDTextBox.TabIndex = 9;
            // 
            // ticketDataGridView
            // 
            this.ticketDataGridView.AutoGenerateColumns = false;
            this.ticketDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.ticketDataGridView.DataSource = this.ticketBindingSource;
            this.ticketDataGridView.Location = new System.Drawing.Point(354, 435);
            this.ticketDataGridView.Name = "ticketDataGridView";
            this.ticketDataGridView.RowHeadersWidth = 62;
            this.ticketDataGridView.RowTemplate.Height = 28;
            this.ticketDataGridView.Size = new System.Drawing.Size(665, 220);
            this.ticketDataGridView.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Ticket_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Ticket_ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_Line";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID_Line";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Service_ID";
            this.dataGridViewTextBoxColumn3.HeaderText = "Service_ID";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "User_ID";
            this.dataGridViewTextBoxColumn4.HeaderText = "User_ID";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button2.Location = new System.Drawing.Point(398, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(255, 134);
            this.button2.TabIndex = 11;
            this.button2.Text = "Пользователи";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1074, 713);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ticketDataGridView);
            this.Controls.Add(user_IDLabel);
            this.Controls.Add(this.user_IDTextBox);
            this.Controls.Add(service_IDLabel);
            this.Controls.Add(this.service_IDTextBox);
            this.Controls.Add(iD_LineLabel);
            this.Controls.Add(this.iD_LineTextBox);
            this.Controls.Add(ticket_IDLabel);
            this.Controls.Add(this.ticket_IDTextBox);
            this.Controls.Add(this.ticketBindingNavigator);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ticket";
            this.Text = "Ticket";
            this.Load += new System.EventHandler(this.Ticket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aviasalesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingNavigator)).EndInit();
            this.ticketBindingNavigator.ResumeLayout(false);
            this.ticketBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private AviasalesDataSet aviasalesDataSet;
        private System.Windows.Forms.BindingSource ticketBindingSource;
        private AviasalesDataSetTableAdapters.TicketTableAdapter ticketTableAdapter;
        private AviasalesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ticketBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton ticketBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox ticket_IDTextBox;
        private System.Windows.Forms.TextBox iD_LineTextBox;
        private System.Windows.Forms.TextBox service_IDTextBox;
        private System.Windows.Forms.TextBox user_IDTextBox;
        private System.Windows.Forms.DataGridView ticketDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button button2;
    }
}