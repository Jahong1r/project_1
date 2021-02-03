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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void товарыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.товарыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ёкубджонов_КРDataSet3);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ёкубджонов_КРDataSet3.Товары". При необходимости она может быть перемещена или удалена.
            this.товарыTableAdapter.Fill(this.ёкубджонов_КРDataSet3.Товары);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button3.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DataGridViewColumn Col = dataGridViewTextBoxColumn2;
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    Col = dataGridViewTextBoxColumn1;
                    break;
                case 1:
                    Col = dataGridViewTextBoxColumn2;
                    break;
                case 2:
                    Col = dataGridViewTextBoxColumn4;
                    break;
            }
            if (radioButton1.Checked)
                товарыDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending);
            else
                товарыDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < товарыDataGridView.ColumnCount; i++)
                for (int j = 0; j < товарыDataGridView.RowCount; j++)
                {
                    товарыDataGridView[i, j].Style.BackColor = Color.White;
                    товарыDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            for (int i = 0; i < товарыDataGridView.ColumnCount; i++)
                for (int j = 0; j < товарыDataGridView.RowCount - 1; j++)
                    if (товарыDataGridView[i, j].Value.ToString().Contains(textBox1.Text))
                    {
                        товарыDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        товарыDataGridView[i, j].Style.ForeColor = Color.Blue;
                    }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
