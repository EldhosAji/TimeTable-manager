using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBManager
{
    public partial class code : Form
    {
        public code()
        {
            InitializeComponent();
        }

        private void code_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbDataSet.cource' table. You can move, or remove it, as needed.
            this.courceTableAdapter.Fill(this.dbDataSet.cource);

        }
    }
}
