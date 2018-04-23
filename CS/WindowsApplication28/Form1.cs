using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;

namespace WindowsApplication28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Record> listDataSource = new List<Record>();
            listDataSource.Add(new Record(1, "Jane", 19, null,listDataSource ));
            listDataSource.Add(new Record(2, "Joe", 30, null, null));
            listDataSource.Add(new Record(3, "Bill", 15, null, null));
            listDataSource.Add(new Record(4, "Michael", 42, listDataSource, null));
            gridView1.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckAllDetails;
            gridControl1.DataSource = listDataSource;
            gridControl1.MainView.PopulateColumns();
            for (int i = 0; i < gridView1.DataRowCount; i++)
                gridView1.ExpandMasterRow(i);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            filterIsActive = true;
            gridView1.RefreshData();
        }
        bool filterIsActive = false;
        private void gridView1_CustomRowFilter(object sender, DevExpress.XtraGrid.Views.Base.RowFilterEventArgs e)
        {
            if (filterIsActive)
            {
                GridView view = (GridView)sender;
                int rowHandle = view.GetRowHandle(e.ListSourceRow);
                e.Visible = !view.IsMasterRowEmptyEx(rowHandle, view.GetRelationIndex(rowHandle, "Detail"));
                e.Handled = true;
            }
        }
    }
}