using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkladForms
{
    public partial class TipTovarovForm : Form
    {
        public TipTovarovForm()
        {
            InitializeComponent();
        }

        private void типы_товараBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.типы_товараBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.skladDataSet);

        }

        private void TipTovarovForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "skladDataSet.Типы_товара". При необходимости она может быть перемещена или удалена.
            this.типы_товараTableAdapter.Fill(this.skladDataSet.Типы_товара);

        }
    }
}
