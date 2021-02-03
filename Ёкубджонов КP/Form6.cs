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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void тюнинг_ательеBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.тюнинг_ательеBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ёкубджонов_КРDataSet3);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ёкубджонов_КРDataSet3.Тюнинг_ателье". При необходимости она может быть перемещена или удалена.
            this.тюнинг_ательеTableAdapter.Fill(this.ёкубджонов_КРDataSet3.Тюнинг_ателье);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            тюнинг_ательеBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Validate();
            тюнинг_ательеBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(ёкубджонов_КРDataSet3);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            тюнинг_ательеBindingSource.RemoveCurrent();
        }
    }
}
