using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SS_SOFTWARE_BARCODE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CRY_BARCODE_PRINTING barcode = new CRY_BARCODE_PRINTING();
            Form2 barcode_view = new Form2();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.Columns.Add("Size No");
            dt.Columns.Add("Barcode");
            dt.Columns.Add("Printing Name");
            foreach (DataGridViewRow dgwDetails in dataGridView1.Rows)
            {
                int quantity = Convert.ToInt32(dgwDetails.Cells[3].Value);
                for (int i = 0; i < quantity; i++)
                {
                    dt.Rows.Add(dgwDetails.Cells[0].Value, dgwDetails.Cells[1].Value, dgwDetails.Cells[2].Value);
                }
            }
            ds.Tables.Add(dt);
            ds.WriteXmlSchema("Barcode.xml");
            barcode.SetDataSource(ds);
            barcode.PrintToPrinter(1, false, 0, 0);
            barcode_view.cryBarcode.ReportSource = barcode;
            barcode_view.Show();
        }
    }
}