using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelAdmin
{
    public partial class Regard : Form
    {
        public Regard()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblSJ.Text = "现在的时间是："+ DateTime.Now.ToString();
        }
    }
}
