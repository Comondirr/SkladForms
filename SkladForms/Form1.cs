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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void должностиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.должностиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.skladDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "skladDataSet.Должности". При необходимости она может быть перемещена или удалена.
            this.должностиTableAdapter.Fill(this.skladDataSet.Должности);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoljForm pf = new DoljForm();
            pf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ZakashForm pf = new ZakashForm();
            pf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PostavForm pf = new PostavForm();
            pf.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SkladForm pf = new SkladForm();
            pf.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SotrudnikiForm pf = new SotrudnikiForm();
            pf.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TipTovarovForm pf = new TipTovarovForm();
            pf.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TovariForm pf = new TovariForm();
            pf.Show();
        }
    }
}
