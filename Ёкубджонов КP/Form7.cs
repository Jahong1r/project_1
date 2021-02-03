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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void тюнинг_ательеBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.тюнинг_ательеBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ёкубджонов_КРDataSet3);

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ёкубджонов_КРDataSet3.Тюнинг_ателье". При необходимости она может быть перемещена или удалена.
            this.тюнинг_ательеTableAdapter.Fill(this.ёкубджонов_КРDataSet3.Тюнинг_ателье);

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
                    Col = dataGridViewTextBoxColumn3;
                    break;
                case 3:
                    Col = dataGridViewTextBoxColumn4;
                    break;
                case 4:
                    Col = dataGridViewTextBoxColumn5;
                    break;
                case 5:
                    Col = dataGridViewTextBoxColumn6;
                    break;
            }
            if (radioButton1.Checked)
                тюнинг_ательеDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending);
            else
                тюнинг_ательеDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < тюнинг_ательеDataGridView.ColumnCount; i++)
                for (int j = 0; j < тюнинг_ательеDataGridView.RowCount; j++)
                {
                    тюнинг_ательеDataGridView[i, j].Style.BackColor = Color.White;
                    тюнинг_ательеDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            for (int i = 0; i < тюнинг_ательеDataGridView.ColumnCount; i++)
                for (int j = 0; j < тюнинг_ательеDataGridView.RowCount - 1; j++)
                    if (тюнинг_ательеDataGridView[i, j].Value.ToString().Contains(textBox1.Text))
                    {
                        тюнинг_ательеDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        тюнинг_ательеDataGridView[i, j].Style.ForeColor = Color.Blue;
                    }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
