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
    public partial class SkladForm : Form
    {
        public SkladForm()
        {
            InitializeComponent();
        }

        private void складBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.складBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.skladDataSet);

        }

        private void SkladForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "skladDataSet.Склад". При необходимости она может быть перемещена или удалена.
            this.складTableAdapter.Fill(this.skladDataSet.Склад);

        }
    }
}
