using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Database_Application_Chris
{
    public partial class SearchResultsControl : UserControl
    {
        public List<CustomerModel> searchResults;
        public List<Panel> panels;
        private int skip;

        public SearchResultsControl()
        {
            InitializeComponent();
            panels = new List<Panel>();
            AddPanelsToList();
        }

        private void SearchResultsControl_Load(object sender, EventArgs e)
        {
            int panelID = 0;
            int totalResults = 0;
            skip = 0;

            foreach (var rec in searchResults)
            {
                customerPanel cp = new customerPanel();
                cp.Dock = DockStyle.Fill;
                cp.customer = searchResults[panelID];
                panels[panelID].Controls.Add(cp);
                panels[panelID].Visible = true;
                panelID++;
                totalResults++;
            }

            numResultsLbl.Text = totalResults + " Results";

        }

        private void AddPanelsToList()
        {
            panels.Add(Result1);
            panels.Add(Result2);
            panels.Add(Result3);
            panels.Add(Result4);
            panels.Add(Result5);
            panels.Add(Result6);
            panels.Add(Result7);
            panels.Add(Result8);
            panels.Add(Result9); 

        }
         
    }
}
