using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WINDB
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private BindingSource sotrBindingSourse;
        private void Form3_Load(object sender, EventArgs e)
        {
            товарыTableAdapter1.Fill(rbProductDataSet11.Товары);
            sotrBindingSourse = new BindingSource(rbProductDataSet11, "Товары");
            NametextBox.DataBindings.Add("Text", sotrBindingSourse, "Наименование");
            PricetextBox.DataBindings.Add("Text", sotrBindingSourse, "Цена");
        }

        private void Previousbutton_Click(object sender, EventArgs e)
        {
            sotrBindingSourse.MovePrevious();
        }

        private void Nextbutton_Click(object sender, EventArgs e)
        {
            sotrBindingSourse.MoveNext();
        }
    }
}
