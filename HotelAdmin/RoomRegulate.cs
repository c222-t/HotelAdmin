using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelBLL;
using HotelModel;

namespace HotelAdmin
{
    public partial class RoomRegulate : Form
    {
        RoomTypeManager rtm = new RoomTypeManager();
        public RoomRegulate()
        {
            InitializeComponent();      
        }

        private void RoomRegulate_Load(object sender, EventArgs e)
        {
            DataTable dt = rtm.TypeTable();

            foreach (DataRow item in dt.Rows)
            {
                TreeNode tn = new TreeNode();
                tn.Text = item["Name"].ToString().Trim();
                tn.Tag = item;

                tvCaiDan.Nodes[0].Nodes.Add(tn);
            }
            
        }
    }
}
