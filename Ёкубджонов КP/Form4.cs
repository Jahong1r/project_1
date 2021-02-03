using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ёкубджонов_КP
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void товарыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.товарыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ёкубджонов_КРDataSet3);

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ёкубджонов_КРDataSet3.Товары". При необходимости она может быть перемещена или удалена.
            this.товарыTableAdapter.Fill(this.ёкубджонов_КРDataSet3.Товары);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            товарыBindingSource.AddNew();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            товарыBindingSource.RemoveCurrent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Validate();
            товарыBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(ёкубджонов_КРDataSet3);
        }
    }
}
