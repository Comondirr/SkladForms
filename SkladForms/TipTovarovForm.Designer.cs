
namespace SkladForms
{
    partial class TipTovarovForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TipTovarovForm));
            System.Windows.Forms.Label код_типаLabel;
            System.Windows.Forms.Label наименованияLabel;
            System.Windows.Forms.Label описанияLabel;
            System.Windows.Forms.Label особенностьLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.skladDataSet = new SkladForms.SkladDataSet();
            this.типы_товараBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.типы_товараTableAdapter = new SkladForms.SkladDataSetTableAdapters.Типы_товараTableAdapter();
            this.tableAdapterManager = new SkladForms.SkladDataSetTableAdapters.TableAdapterManager();
            this.типы_товараBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.типы_товараBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.код_типаTextBox = new System.Windows.Forms.TextBox();
            this.наименованияTextBox = new System.Windows.Forms.TextBox();
            this.описанияTextBox = new System.Windows.Forms.TextBox();
            this.особенностьTextBox = new System.Windows.Forms.TextBox();
            код_типаLabel = new System.Windows.Forms.Label();
            наименованияLabel = new System.Windows.Forms.Label();
            описанияLabel = new System.Windows.Forms.Label();
            особенностьLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.типы_товараBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.типы_товараBindingNavigator)).BeginInit();
            this.типы_товараBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(183, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 53);
            this.label1.TabIndex = 5;
            this.label1.Text = "Таблица  Типы товаров";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // skladDataSet
            // 
            this.skladDataSet.DataSetName = "SkladDataSet";
            this.skladDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // типы_товараBindingSource
            // 
            this.типы_товараBindingSource.DataMember = "Типы товара";
            this.типы_товараBindingSource.DataSource = this.skladDataSet;
            // 
            // типы_товараTableAdapter
            // 
            this.типы_товараTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = SkladForms.SkladDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.ЗаказчикиTableAdapter = null;
            this.tableAdapterManager.ПоставщикиTableAdapter = null;
            this.tableAdapterManager.СкладTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.Типы_товараTableAdapter = this.типы_товараTableAdapter;
            this.tableAdapterManager.ТоварыTableAdapter = null;
            // 
            // типы_товараBindingNavigator
            // 
            this.типы_товараBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.типы_товараBindingNavigator.BindingSource = this.типы_товараBindingSource;
            this.типы_товараBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.типы_товараBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.типы_товараBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.типы_товараBindingNavigatorSaveItem});
            this.типы_товараBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.типы_товараBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.типы_товараBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.типы_товараBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.типы_товараBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.типы_товараBindingNavigator.Name = "типы_товараBindingNavigator";
            this.типы_товараBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.типы_товараBindingNavigator.Size = new System.Drawing.Size(713, 25);
            this.типы_товараBindingNavigator.TabIndex = 6;
            this.типы_товараBindingNavigator.Text = "bindingNavigator1";
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
            // типы_товараBindingNavigatorSaveItem
            // 
            this.типы_товараBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.типы_товараBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("типы_товараBindingNavigatorSaveItem.Image")));
            this.типы_товараBindingNavigatorSaveItem.Name = "типы_товараBindingNavigatorSaveItem";
            this.типы_товараBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.типы_товараBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.типы_товараBindingNavigatorSaveItem.Click += new System.EventHandler(this.типы_товараBindingNavigatorSaveItem_Click);
            // 
            // код_типаLabel
            // 
            код_типаLabel.AutoSize = true;
            код_типаLabel.Location = new System.Drawing.Point(206, 106);
            код_типаLabel.Name = "код_типаLabel";
            код_типаLabel.Size = new System.Drawing.Size(55, 13);
            код_типаLabel.TabIndex = 6;
            код_типаLabel.Text = "Код типа:";
            // 
            // код_типаTextBox
            // 
            this.код_типаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.типы_товараBindingSource, "Код типа", true));
            this.код_типаTextBox.Location = new System.Drawing.Point(267, 103);
            this.код_типаTextBox.Name = "код_типаTextBox";
            this.код_типаTextBox.Size = new System.Drawing.Size(313, 20);
            this.код_типаTextBox.TabIndex = 7;
            // 
            // наименованияLabel
            // 
            наименованияLabel.AutoSize = true;
            наименованияLabel.Location = new System.Drawing.Point(175, 132);
            наименованияLabel.Name = "наименованияLabel";
            наименованияLabel.Size = new System.Drawing.Size(86, 13);
            наименованияLabel.TabIndex = 7;
            наименованияLabel.Text = "Наименования:";
            // 
            // наименованияTextBox
            // 
            this.наименованияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.типы_товараBindingSource, "Наименования", true));
            this.наименованияTextBox.Location = new System.Drawing.Point(267, 129);
            this.наименованияTextBox.Name = "наименованияTextBox";
            this.наименованияTextBox.Size = new System.Drawing.Size(313, 20);
            this.наименованияTextBox.TabIndex = 8;
            // 
            // описанияLabel
            // 
            описанияLabel.AutoSize = true;
            описанияLabel.Location = new System.Drawing.Point(201, 181);
            описанияLabel.Name = "описанияLabel";
            описанияLabel.Size = new System.Drawing.Size(60, 13);
            описанияLabel.TabIndex = 8;
            описанияLabel.Text = "Описания:";
            // 
            // описанияTextBox
            // 
            this.описанияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.типы_товараBindingSource, "Описания", true));
            this.описанияTextBox.Location = new System.Drawing.Point(267, 178);
            this.описанияTextBox.Name = "описанияTextBox";
            this.описанияTextBox.Size = new System.Drawing.Size(313, 20);
            this.описанияTextBox.TabIndex = 9;
            // 
            // особенностьLabel
            // 
            особенностьLabel.AutoSize = true;
            особенностьLabel.Location = new System.Drawing.Point(184, 231);
            особенностьLabel.Name = "особенностьLabel";
            особенностьLabel.Size = new System.Drawing.Size(77, 13);
            особенностьLabel.TabIndex = 9;
            особенностьLabel.Text = "Особенность:";
            // 
            // особенностьTextBox
            // 
            this.особенностьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.типы_товараBindingSource, "Особенность", true));
            this.особенностьTextBox.Location = new System.Drawing.Point(267, 228);
            this.особенностьTextBox.Name = "особенностьTextBox";
            this.особенностьTextBox.Size = new System.Drawing.Size(313, 20);
            this.особенностьTextBox.TabIndex = 10;
            // 
            // TipTovarovForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 285);
            this.Controls.Add(особенностьLabel);
            this.Controls.Add(this.особенностьTextBox);
            this.Controls.Add(описанияLabel);
            this.Controls.Add(this.описанияTextBox);
            this.Controls.Add(наименованияLabel);
            this.Controls.Add(this.наименованияTextBox);
            this.Controls.Add(код_типаLabel);
            this.Controls.Add(this.код_типаTextBox);
            this.Controls.Add(this.типы_товараBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "TipTovarovForm";
            this.Text = "TipTovarovForm";
            this.Load += new System.EventHandler(this.TipTovarovForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.типы_товараBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.типы_товараBindingNavigator)).EndInit();
            this.типы_товараBindingNavigator.ResumeLayout(false);
            this.типы_товараBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private SkladDataSet skladDataSet;
        private System.Windows.Forms.BindingSource типы_товараBindingSource;
        private SkladDataSetTableAdapters.Типы_товараTableAdapter типы_товараTableAdapter;
        private SkladDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator типы_товараBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton типы_товараBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox код_типаTextBox;
        private System.Windows.Forms.TextBox наименованияTextBox;
        private System.Windows.Forms.TextBox описанияTextBox;
        private System.Windows.Forms.TextBox особенностьTextBox;
    }
}