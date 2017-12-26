using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace upvoteNotification
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string rowStr = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (rowStr.Contains("https://steemit.com")) // if entered info is eligible
                {
                    var received = Posts.getContent(rowStr); //
                    dataGridView1.Rows[e.RowIndex].Cells[1].Value = received.upvoteCount;
                }
            }
            catch { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notify n = new notify(); n.Show();
        }

        private void startB_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value!=null)
                {
                    string url = row.Cells[0].Value.ToString();
                    var received = Posts.getContent(url);
                    if (received.upvoteCount != (int)row.Cells[1].Value) // If there is a change, show notify to us
                    {
                        notify.url = url;
                        notify.upCount = received.upvoteCount;
                        notify.sbd = received.totalSbd;
                        notify n = new notify(); n.Show();
                        row.Cells[1].Value = received.upvoteCount;
                    }
                }
            }
        }
    }
}
