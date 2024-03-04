using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DuckCpeciesApp.Controls;
using DuckCpeciesApp.Ducks;
using DuckCpeciesApp.BL;

namespace WindowsFormsApp1
{
    public partial class frmDucks : Form
    {
        private const string _dvlName = "dlv1";

        public frmDucks()
        {
            InitializeComponent();
            SubInit();
            //ShowDuks();
        }

        /*protected void DuckPrint(Duck duck)
        {
            string duckInfo = "";
            duckInfo += "quack type: '" + duck.performQuack() + "',  ";
            duckInfo += "fly type: '" + duck.performFly() + "'";

            string[] listItemData = new string[1];
            listItemData[0] = duckInfo;
        }*/

        void SubInit()
        {
            DackListView dlv = new DackListView();
            dlv.Name = _dvlName;
            dlv.Left = 25;
            dlv.Top = 80;
            dlv.Width = 650;
            this.Controls.Add(dlv);
        }

        private void ShowDuks()
        {
            DackListView dvl = (DackListView)this.Controls.Find(_dvlName, false)[0];
            dvl.Clear();
            dvl.Enabled = false;
            Test1.Run(dvl);
            dvl.Enabled = true;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            ShowDuks();
        }
    }
}
