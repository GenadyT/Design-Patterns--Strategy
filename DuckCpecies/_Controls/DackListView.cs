using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DuckCpeciesApp.BL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DuckCpeciesApp.Controls
{
    class DackListView : System.Windows.Forms.ListView
    {
        private const int Columns_Count = 4;
        
        public DackListView()
        {
            this.HeaderStyle = ColumnHeaderStyle.Nonclickable;

            this.View = System.Windows.Forms.View.Details;
            this.GridLines = true;
            this.Width = 350;
            this.Height = 150;

            const int ColumnHeight = 25;

            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, ColumnHeight);
            this.SmallImageList = imgList;

            this.Columns.Clear();
            ColumnHeader column;
            const int ColumnWidth = 150;            

            column = new ColumnHeader();
            column.Text = "- Title --";
            column.Width = ColumnWidth;
            this.Columns.Add(column);

            column = new ColumnHeader();
            column.Text = "- Quack Behavior --";
            column.Width = ColumnWidth;
            this.Columns.Add(column);

            column = new ColumnHeader();
            column.Text = "- Fly Behavior --";
            column.Width = ColumnWidth;
            this.Columns.Add(column);

            column = new ColumnHeader();
            column.Text = "- Can Swim --";
            column.Width = ColumnWidth;
            this.Columns.Add(column);
        }

        public void AddItem(DuckInfo duckInfo)
        {
            /*string format = "Duck Species: {0},  Quack Behavior: {1},  Fly Behavior: {2}";
            string itemData = String.Format(format, duckInfo.Title, duckInfo.QuackBehavior, duckInfo.FlyBehavior);*/

            string[] arr = new string[Columns_Count];
            arr[0] = duckInfo.Title;
            arr[1] = duckInfo.QuackBehavior;
            arr[2] = duckInfo.FlyBehavior;
            arr[3] = duckInfo.canSwim.ToString();
            
            ListViewItem itm = new ListViewItem(arr);
            this.Items.Add(itm);
        }

        public new void Clear()
        {
            this.Items.Clear();
        }
    }
}
