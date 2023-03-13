
namespace SkladForms
{
    partial class ZakashForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZakashForm));
            System.Windows.Forms.Label код_заказчикаLabel;
            System.Windows.Forms.Label наименованияLabel;
            System.Windows.Forms.Label адресLabel;
            System.Windows.Forms.Label телефонLabel;
            System.Windows.Forms.Label код_потребляемого_товара_1Label;
            System.Windows.Forms.Label код_потребляемого_товара_2Label;
            System.Windows.Forms.Label код_потребляемого_товара_3Label;
            this.label1 = new System.Windows.Forms.Label();
            this.skladDataSet = new SkladForms.SkladDataSet();
            this.заказчикиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказчикиTableAdapter = new SkladForms.SkladDataSetTableAdapters.ЗаказчикиTableAdapter();
            this.tableAdapterManager = new SkladForms.SkladDataSetTableAdapters.TableAdapterManager();
            this.заказчикиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.заказчикиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.код_заказчикаTextBox = new System.Windows.Forms.TextBox();
            this.наименованияTextBox = new System.Windows.Forms.TextBox();
            this.адресTextBox = new System.Windows.Forms.TextBox();
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            this.код_потребляемого_товара_1TextBox = new System.Windows.Forms.TextBox();
            this.код_потребляемого_товара_2TextBox = new System.Windows.Forms.TextBox();
            this.код_потребляемого_товара_3TextBox = new System.Windows.Forms.TextBox();
            код_заказчикаLabel = new System.Windows.Forms.Label();
            наименованияLabel = new System.Windows.Forms.Label();
            адресLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            код_потребляемого_товара_1Label = new System.Windows.Forms.Label();
            код_потребляемого_товара_2Label = new System.Windows.Forms.Label();
            код_потребляемого_товара_3Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказчикиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказчикиBindingNavigator)).BeginInit();
            this.заказчикиBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(176, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Таблица Заказчики";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // skladDataSet
            // 
            this.skladDataSet.DataSetName = "SkladDataSet";
            this.skladDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // заказчикиBindingSource
            // 
            this.заказчикиBindingSource.DataMember = "Заказчики";
            this.заказчикиBindingSource.DataSource = this.skladDataSet;
            // 
            // заказчикиTableAdapter
            // 
            this.заказчикиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = SkladForms.SkladDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.ЗаказчикиTableAdapter = this.заказчикиTableAdapter;
            this.tableAdapterManager.ПоставщикиTableAdapter = null;
            this.tableAdapterManager.СкладTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.Типы_товараTableAdapter = null;
            this.tableAdapterManager.ТоварыTableAdapter = null;
            // 
            // заказчикиBindingNavigator
            // 
            this.заказчикиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.заказчикиBindingNavigator.BindingSource = this.заказчикиBindingSource;
            this.заказчикиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.заказчикиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.заказчикиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.заказчикиBindingNavigatorSaveItem});
            this.заказчикиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.заказчикиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.заказчикиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.заказчикиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.заказчикиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.заказчикиBindingNavigator.Name = "заказчикиBindingNavigator";
            this.заказчикиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.заказчикиBindingNavigator.Size = new System.Drawing.Size(666, 25);
            this.заказчикиBindingNavigator.TabIndex = 4;
            this.заказчикиBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // заказчикиBindingNavigatorSaveItem
            // 
            this.заказчикиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.заказчикиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("заказчикиBindingNavigatorSaveItem.Image")));
            this.заказчикиBindingNavigatorSaveItem.Name = "заказчикиBindingNavigatorSaveItem";
            this.заказчикиBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.заказчикиBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.заказчикиBindingNavigatorSaveItem.Click += new System.EventHandler(this.заказчикиBindingNavigatorSaveItem_Click);
            // 
            // код_заказчикаLabel
            // 
            код_заказчикаLabel.AutoSize = true;
            код_заказчикаLabel.Location = new System.Drawing.Point(223, 84);
            код_заказчикаLabel.Name = "код_заказчикаLabel";
            код_заказчикаLabel.Size = new System.Drawing.Size(85, 13);
            код_заказчикаLabel.TabIndex = 4;
            код_заказчикаLabel.Text = "Код заказчика:";
            // 
            // код_заказчикаTextBox
            // 
            this.код_заказчикаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказчикиBindingSource, "Код заказчика", true));
            this.код_заказчикаTextBox.Location = new System.Drawing.Point(314, 81);
            this.код_заказчикаTextBox.Name = "код_заказчикаTextBox";
            this.код_заказчикаTextBox.Size = new System.Drawing.Size(239, 20);
            this.код_заказчикаTextBox.TabIndex = 5;
            // 
            // наименованияLabel
            // 
            наименованияLabel.AutoSize = true;
            наименованияLabel.Location = new System.Drawing.Point(222, 110);
            наименованияLabel.Name = "наименованияLabel";
            наименованияLabel.Size = new System.Drawing.Size(86, 13);
            наименованияLabel.TabIndex = 5;
            наименованияLabel.Text = "Наименования:";
            // 
            // наименованияTextBox
            // 
            this.наименованияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказчикиBindingSource, "Наименования", true));
            this.наименованияTextBox.Location = new System.Drawing.Point(314, 107);
            this.наименованияTextBox.Name = "наименованияTextBox";
            this.наименованияTextBox.Size = new System.Drawing.Size(239, 20);
            this.наименованияTextBox.TabIndex = 6;
            // 
            // адресLabel
            // 
            адресLabel.AutoSize = true;
            адресLabel.Location = new System.Drawing.Point(267, 136);
            адресLabel.Name = "адресLabel";
            адресLabel.Size = new System.Drawing.Size(41, 13);
            адресLabel.TabIndex = 6;
            адресLabel.Text = "Адрес:";
            // 
            // адресTextBox
            // 
            this.адресTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказчикиBindingSource, "Адрес", true));
            this.адресTextBox.Location = new System.Drawing.Point(314, 133);
            this.адресTextBox.Name = "адресTextBox";
            this.адресTextBox.Size = new System.Drawing.Size(239, 20);
            this.адресTextBox.TabIndex = 7;
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Location = new System.Drawing.Point(253, 162);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(55, 13);
            телефонLabel.TabIndex = 8;
            телефонLabel.Text = "Телефон:";
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказчикиBindingSource, "Телефон", true));
            this.телефонTextBox.Location = new System.Drawing.Point(314, 159);
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(239, 20);
            this.телефонTextBox.TabIndex = 9;
            // 
            // код_потребляемого_товара_1Label
            // 
            код_потребляемого_товара_1Label.AutoSize = true;
            код_потребляемого_товара_1Label.Location = new System.Drawing.Point(151, 197);
            код_потребляемого_товара_1Label.Name = "код_потребляемого_товара_1Label";
            код_потребляемого_товара_1Label.Size = new System.Drawing.Size(157, 13);
            код_потребляемого_товара_1Label.TabIndex = 10;
            код_потребляемого_товара_1Label.Text = "Код потребляемого товара 1:";
            // 
            // код_потребляемого_товара_1TextBox
            // 
            this.код_потребляемого_товара_1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказчикиBindingSource, "Код потребляемого товара 1", true));
            this.код_потребляемого_товара_1TextBox.Location = new System.Drawing.Point(314, 194);
            this.код_потребляемого_товара_1TextBox.Name = "код_потребляемого_товара_1TextBox";
            this.код_потребляемого_товара_1TextBox.Size = new System.Drawing.Size(239, 20);
            this.код_потребляемого_товара_1TextBox.TabIndex = 11;
            // 
            // код_потребляемого_товара_2Label
            // 
            код_потребляемого_товара_2Label.AutoSize = true;
            код_потребляемого_товара_2Label.Location = new System.Drawing.Point(151, 223);
            код_потребляемого_товара_2Label.Name = "код_потребляемого_товара_2Label";
            код_потребляемого_товара_2Label.Size = new System.Drawing.Size(157, 13);
            код_потребляемого_товара_2Label.TabIndex = 12;
            код_потребляемого_товара_2Label.Text = "Код потребляемого товара 2:";
            // 
            // код_потребляемого_товара_2TextBox
            // 
            this.код_потребляемого_товара_2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказчикиBindingSource, "Код потребляемого товара 2", true));
            this.код_потребляемого_товара_2TextBox.Location = new System.Drawing.Point(314, 220);
            this.код_потребляемого_товара_2TextBox.Name = "код_потребляемого_товара_2TextBox";
            this.код_потребляемого_товара_2TextBox.Size = new System.Drawing.Size(239, 20);
            this.код_потребляемого_товара_2TextBox.TabIndex = 13;
            // 
            // код_потребляемого_товара_3Label
            // 
            код_потребляемого_товара_3Label.AutoSize = true;
            код_потребляемого_товара_3Label.Location = new System.Drawing.Point(151, 249);
            код_потребляемого_товара_3Label.Name = "код_потребляемого_товара_3Label";
            код_потребляемого_товара_3Label.Size = new System.Drawing.Size(157, 13);
            код_потребляемого_товара_3Label.TabIndex = 14;
            код_потребляемого_товара_3Label.Text = "Код потребляемого товара 3:";
            // 
            // код_потребляемого_товара_3TextBox
            // 
            this.код_потребляемого_товара_3TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказчикиBindingSource, "Код потребляемого товара 3", true));
            this.код_потребляемого_товара_3TextBox.Location = new System.Drawing.Point(314, 246);
            this.код_потребляемого_товара_3TextBox.Name = "код_потребляемого_товара_3TextBox";
            this.код_потребляемого_товара_3TextBox.Size = new System.Drawing.Size(239, 20);
            this.код_потребляемого_товара_3TextBox.TabIndex = 15;
            // 
            // ZakashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 376);
            this.Controls.Add(код_потребляемого_товара_3Label);
            this.Controls.Add(this.код_потребляемого_товара_3TextBox);
            this.Controls.Add(код_потребляемого_товара_2Label);
            this.Controls.Add(this.код_потребляемого_товара_2TextBox);
            this.Controls.Add(код_потребляемого_товара_1Label);
            this.Controls.Add(this.код_потребляемого_товара_1TextBox);
            this.Controls.Add(телефонLabel);
            this.Controls.Add(this.телефонTextBox);
            this.Controls.Add(адресLabel);
            this.Controls.Add(this.адресTextBox);
            this.Controls.Add(наименованияLabel);
            this.Controls.Add(this.наименованияTextBox);
            this.Controls.Add(код_заказчикаLabel);
            this.Controls.Add(this.код_заказчикаTextBox);
            this.Controls.Add(this.заказчикиBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "ZakashForm";
            this.Text = "ZakashForm";
            this.Load += new System.EventHandler(this.ZakashForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказчикиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказчикиBindingNavigator)).EndInit();
            this.заказчикиBindingNavigator.ResumeLayout(false);
            this.заказчикиBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private SkladDataSet skladDataSet;
        private System.Windows.Forms.BindingSource заказчикиBindingSource;
        private SkladDataSetTableAdapters.ЗаказчикиTableAdapter заказчикиTableAdapter;
        private SkladDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator заказчикиBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton заказчикиBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox код_заказчикаTextBox;
        private System.Windows.Forms.TextBox наименованияTextBox;
        private System.Windows.Forms.TextBox адресTextBox;
        private System.Windows.Forms.TextBox телефонTextBox;
        private System.Windows.Forms.TextBox код_потребляемого_товара_1TextBox;
        private System.Windows.Forms.TextBox код_потребляемого_товара_2TextBox;
        private System.Windows.Forms.TextBox код_потребляемого_товара_3TextBox;
    }
}