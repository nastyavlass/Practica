using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinDB
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        DataView ПоставщикиView;
        private void button1_Click(object sender, EventArgs e)
        {
            поставщикиTableAdapter1.Fill(rbProductDataSet1.Поставщики);
            ПоставщикиView = new DataView(rbProductDataSet1.Поставщики);
            dataGridView1.DataSource = ПоставщикиView;
            ПоставщикиView.Sort = "Поставщик";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            oleDbDataAdapter1.Update(rbProductDataSet1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ПоставщикиView.Sort = SortTextBox.Text;
            ПоставщикиView.RowFilter = FilterTextBox.Text;
        }
    }
}
