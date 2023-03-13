
namespace SkladForms
{
    partial class SkladForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SkladForm));
            System.Windows.Forms.Label дата_поступленияLabel;
            System.Windows.Forms.Label дата_заказаLabel;
            System.Windows.Forms.Label дата_отправкиLabel;
            System.Windows.Forms.Label код_товараLabel;
            System.Windows.Forms.Label код_поставщикаLabel;
            System.Windows.Forms.Label код_заказчикаLabel;
            System.Windows.Forms.Label объемLabel;
            System.Windows.Forms.Label ценаLabel;
            System.Windows.Forms.Label код_сотрудникаLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.skladDataSet = new SkladForms.SkladDataSet();
            this.складBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.складTableAdapter = new SkladForms.SkladDataSetTableAdapters.СкладTableAdapter();
            this.tableAdapterManager = new SkladForms.SkladDataSetTableAdapters.TableAdapterManager();
            this.складBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.складBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.дата_поступленияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.дата_заказаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.дата_отправкиDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.код_товараTextBox = new System.Windows.Forms.TextBox();
            this.код_поставщикаTextBox = new System.Windows.Forms.TextBox();
            this.код_заказчикаTextBox = new System.Windows.Forms.TextBox();
            this.объемTextBox = new System.Windows.Forms.TextBox();
            this.ценаTextBox = new System.Windows.Forms.TextBox();
            this.код_сотрудникаTextBox = new System.Windows.Forms.TextBox();
            дата_поступленияLabel = new System.Windows.Forms.Label();
            дата_заказаLabel = new System.Windows.Forms.Label();
            дата_отправкиLabel = new System.Windows.Forms.Label();
            код_товараLabel = new System.Windows.Forms.Label();
            код_поставщикаLabel = new System.Windows.Forms.Label();
            код_заказчикаLabel = new System.Windows.Forms.Label();
            объемLabel = new System.Windows.Forms.Label();
            ценаLabel = new System.Windows.Forms.Label();
            код_сотрудникаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.складBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.складBindingNavigator)).BeginInit();
            this.складBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(155, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Таблица Склад";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // skladDataSet
            // 
            this.skladDataSet.DataSetName = "SkladDataSet";
            this.skladDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // складBindingSource
            // 
            this.складBindingSource.DataMember = "Склад";
            this.складBindingSource.DataSource = this.skladDataSet;
            // 
            // складTableAdapter
            // 
            this.складTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = SkladForms.SkladDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.ЗаказчикиTableAdapter = null;
            this.tableAdapterManager.ПоставщикиTableAdapter = null;
            this.tableAdapterManager.СкладTableAdapter = this.складTableAdapter;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.Типы_товараTableAdapter = null;
            this.tableAdapterManager.ТоварыTableAdapter = null;
            // 
            // складBindingNavigator
            // 
            this.складBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.складBindingNavigator.BindingSource = this.складBindingSource;
            this.складBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.складBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.складBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.складBindingNavigatorSaveItem});
            this.складBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.складBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.складBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.складBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.складBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.складBindingNavigator.Name = "складBindingNavigator";
            this.складBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.складBindingNavigator.Size = new System.Drawing.Size(511, 25);
            this.складBindingNavigator.TabIndex = 5;
            this.складBindingNavigator.Text = "bindingNavigator1";
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
            // складBindingNavigatorSaveItem
            // 
            this.складBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.складBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("складBindingNavigatorSaveItem.Image")));
            this.складBindingNavigatorSaveItem.Name = "складBindingNavigatorSaveItem";
            this.складBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.складBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.складBindingNavigatorSaveItem.Click += new System.EventHandler(this.складBindingNavigatorSaveItem_Click);
            // 
            // дата_поступленияLabel
            // 
            дата_поступленияLabel.AutoSize = true;
            дата_поступленияLabel.Location = new System.Drawing.Point(156, 90);
            дата_поступленияLabel.Name = "дата_поступленияLabel";
            дата_поступленияLabel.Size = new System.Drawing.Size(103, 13);
            дата_поступленияLabel.TabIndex = 5;
            дата_поступленияLabel.Text = "Дата поступления:";
            // 
            // дата_поступленияDateTimePicker
            // 
            this.дата_поступленияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.складBindingSource, "Дата поступления", true));
            this.дата_поступленияDateTimePicker.Location = new System.Drawing.Point(265, 86);
            this.дата_поступленияDateTimePicker.Name = "дата_поступленияDateTimePicker";
            this.дата_поступленияDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.дата_поступленияDateTimePicker.TabIndex = 6;
            // 
            // дата_заказаLabel
            // 
            дата_заказаLabel.AutoSize = true;
            дата_заказаLabel.Location = new System.Drawing.Point(183, 129);
            дата_заказаLabel.Name = "дата_заказаLabel";
            дата_заказаLabel.Size = new System.Drawing.Size(75, 13);
            дата_заказаLabel.TabIndex = 6;
            дата_заказаLabel.Text = "Дата заказа:";
            // 
            // дата_заказаDateTimePicker
            // 
            this.дата_заказаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.складBindingSource, "Дата заказа", true));
            this.дата_заказаDateTimePicker.Location = new System.Drawing.Point(264, 125);
            this.дата_заказаDateTimePicker.Name = "дата_заказаDateTimePicker";
            this.дата_заказаDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.дата_заказаDateTimePicker.TabIndex = 7;
            // 
            // дата_отправкиLabel
            // 
            дата_отправкиLabel.AutoSize = true;
            дата_отправкиLabel.Location = new System.Drawing.Point(172, 170);
            дата_отправкиLabel.Name = "дата_отправкиLabel";
            дата_отправкиLabel.Size = new System.Drawing.Size(86, 13);
            дата_отправкиLabel.TabIndex = 7;
            дата_отправкиLabel.Text = "Дата отправки:";
            // 
            // дата_отправкиDateTimePicker
            // 
            this.дата_отправкиDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.складBindingSource, "Дата отправки", true));
            this.дата_отправкиDateTimePicker.Location = new System.Drawing.Point(264, 166);
            this.дата_отправкиDateTimePicker.Name = "дата_отправкиDateTimePicker";
            this.дата_отправкиDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.дата_отправкиDateTimePicker.TabIndex = 8;
            // 
            // код_товараLabel
            // 
            код_товараLabel.AutoSize = true;
            код_товараLabel.Location = new System.Drawing.Point(192, 204);
            код_товараLabel.Name = "код_товараLabel";
            код_товараLabel.Size = new System.Drawing.Size(67, 13);
            код_товараLabel.TabIndex = 8;
            код_товараLabel.Text = "Код товара:";
            // 
            // код_товараTextBox
            // 
            this.код_товараTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.складBindingSource, "Код товара", true));
            this.код_товараTextBox.Location = new System.Drawing.Point(265, 201);
            this.код_товараTextBox.Name = "код_товараTextBox";
            this.код_товараTextBox.Size = new System.Drawing.Size(221, 20);
            this.код_товараTextBox.TabIndex = 9;
            // 
            // код_поставщикаLabel
            // 
            код_поставщикаLabel.AutoSize = true;
            код_поставщикаLabel.Location = new System.Drawing.Point(164, 246);
            код_поставщикаLabel.Name = "код_поставщикаLabel";
            код_поставщикаLabel.Size = new System.Drawing.Size(94, 13);
            код_поставщикаLabel.TabIndex = 10;
            код_поставщикаLabel.Text = "Код поставщика:";
            // 
            // код_поставщикаTextBox
            // 
            this.код_поставщикаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.складBindingSource, "Код поставщика", true));
            this.код_поставщикаTextBox.Location = new System.Drawing.Point(265, 239);
            this.код_поставщикаTextBox.Name = "код_поставщикаTextBox";
            this.код_поставщикаTextBox.Size = new System.Drawing.Size(221, 20);
            this.код_поставщикаTextBox.TabIndex = 11;
            // 
            // код_заказчикаLabel
            // 
            код_заказчикаLabel.AutoSize = true;
            код_заказчикаLabel.Location = new System.Drawing.Point(173, 278);
            код_заказчикаLabel.Name = "код_заказчикаLabel";
            код_заказчикаLabel.Size = new System.Drawing.Size(85, 13);
            код_заказчикаLabel.TabIndex = 12;
            код_заказчикаLabel.Text = "Код заказчика:";
            // 
            // код_заказчикаTextBox
            // 
            this.код_заказчикаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.складBindingSource, "Код заказчика", true));
            this.код_заказчикаTextBox.Location = new System.Drawing.Point(264, 275);
            this.код_заказчикаTextBox.Name = "код_заказчикаTextBox";
            this.код_заказчикаTextBox.Size = new System.Drawing.Size(221, 20);
            this.код_заказчикаTextBox.TabIndex = 13;
            // 
            // объемLabel
            // 
            объемLabel.AutoSize = true;
            объемLabel.Location = new System.Drawing.Point(213, 313);
            объемLabel.Name = "объемLabel";
            объемLabel.Size = new System.Drawing.Size(45, 13);
            объемLabel.TabIndex = 14;
            объемLabel.Text = "Объем:";
            // 
            // объемTextBox
            // 
            this.объемTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.складBindingSource, "Объем", true));
            this.объемTextBox.Location = new System.Drawing.Point(264, 310);
            this.объемTextBox.Name = "объемTextBox";
            this.объемTextBox.Size = new System.Drawing.Size(221, 20);
            this.объемTextBox.TabIndex = 15;
            // 
            // ценаLabel
            // 
            ценаLabel.AutoSize = true;
            ценаLabel.Location = new System.Drawing.Point(222, 339);
            ценаLabel.Name = "ценаLabel";
            ценаLabel.Size = new System.Drawing.Size(36, 13);
            ценаLabel.TabIndex = 16;
            ценаLabel.Text = "Цена:";
            // 
            // ценаTextBox
            // 
            this.ценаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.складBindingSource, "Цена", true));
            this.ценаTextBox.Location = new System.Drawing.Point(264, 336);
            this.ценаTextBox.Name = "ценаTextBox";
            this.ценаTextBox.Size = new System.Drawing.Size(221, 20);
            this.ценаTextBox.TabIndex = 17;
            // 
            // код_сотрудникаLabel
            // 
            код_сотрудникаLabel.AutoSize = true;
            код_сотрудникаLabel.Location = new System.Drawing.Point(168, 377);
            код_сотрудникаLabel.Name = "код_сотрудникаLabel";
            код_сотрудникаLabel.Size = new System.Drawing.Size(90, 13);
            код_сотрудникаLabel.TabIndex = 18;
            код_сотрудникаLabel.Text = "Код сотрудника:";
            // 
            // код_сотрудникаTextBox
            // 
            this.код_сотрудникаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.складBindingSource, "Код сотрудника", true));
            this.код_сотрудникаTextBox.Location = new System.Drawing.Point(264, 374);
            this.код_сотрудникаTextBox.Name = "код_сотрудникаTextBox";
            this.код_сотрудникаTextBox.Size = new System.Drawing.Size(221, 20);
            this.код_сотрудникаTextBox.TabIndex = 19;
            // 
            // SkladForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 424);
            this.Controls.Add(код_сотрудникаLabel);
            this.Controls.Add(this.код_сотрудникаTextBox);
            this.Controls.Add(ценаLabel);
            this.Controls.Add(this.ценаTextBox);
            this.Controls.Add(объемLabel);
            this.Controls.Add(this.объемTextBox);
            this.Controls.Add(код_заказчикаLabel);
            this.Controls.Add(this.код_заказчикаTextBox);
            this.Controls.Add(код_поставщикаLabel);
            this.Controls.Add(this.код_поставщикаTextBox);
            this.Controls.Add(код_товараLabel);
            this.Controls.Add(this.код_товараTextBox);
            this.Controls.Add(дата_отправкиLabel);
            this.Controls.Add(this.дата_отправкиDateTimePicker);
            this.Controls.Add(дата_заказаLabel);
            this.Controls.Add(this.дата_заказаDateTimePicker);
            this.Controls.Add(дата_поступленияLabel);
            this.Controls.Add(this.дата_поступленияDateTimePicker);
            this.Controls.Add(this.складBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "SkladForm";
            this.Text = "SkladForm";
            this.Load += new System.EventHandler(this.SkladForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.складBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.складBindingNavigator)).EndInit();
            this.складBindingNavigator.ResumeLayout(false);
            this.складBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private SkladDataSet skladDataSet;
        private System.Windows.Forms.BindingSource складBindingSource;
        private SkladDataSetTableAdapters.СкладTableAdapter складTableAdapter;
        private SkladDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator складBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton складBindingNavigatorSaveItem;
        private System.Windows.Forms.DateTimePicker дата_поступленияDateTimePicker;
        private System.Windows.Forms.DateTimePicker дата_заказаDateTimePicker;
        private System.Windows.Forms.DateTimePicker дата_отправкиDateTimePicker;
        private System.Windows.Forms.TextBox код_товараTextBox;
        private System.Windows.Forms.TextBox код_поставщикаTextBox;
        private System.Windows.Forms.TextBox код_заказчикаTextBox;
        private System.Windows.Forms.TextBox объемTextBox;
        private System.Windows.Forms.TextBox ценаTextBox;
        private System.Windows.Forms.TextBox код_сотрудникаTextBox;
    }
}