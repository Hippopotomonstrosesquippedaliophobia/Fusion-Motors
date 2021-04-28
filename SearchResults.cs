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
        private int skip, limit, panelID, recID, lastRecID, totalResults, pageAt, numPages, numOnPage;
        private Size small = new Size(248, 134);
        private Size large = new Size(280, 166);

        private void panel2_SizeChanged(object sender, EventArgs e)
        {
            if (main.Instance.maximized)
            {
                ScaleUp();
            }
            else
            {
                ScaleDown();
            }
        }

        private void ScaleUp()
        {
            Result1.Size = large;
            Result2.Size = large;
            Result3.Size = large;
            Result4.Size = large;
            Result5.Size = large;
            Result6.Size = large;
            Result7.Size = large;
            Result8.Size = large;
            Result9.Size = large;
        }

        private void ScaleDown()
        {
            Result1.Size = small;
            Result2.Size = small;
            Result3.Size = small;
            Result4.Size = small;
            Result5.Size = small;
            Result6.Size = small;
            Result7.Size = small;
            Result8.Size = small;
            Result9.Size = small;
        }

        public SearchResultsControl()
        {
            InitializeComponent();
            panels = new List<Panel>();

            panelID = 0;
            recID = 0;
            lastRecID = 0;
            skip = 0;
            numOnPage = 0;

            // Affects how many are shown on a page at a time
            limit = 9;

            // Starts at 1
            pageAt = 1;

            numPages = 0;
            AddPanelsToList();
        }

        private void SearchResultsControl_Load(object sender, EventArgs e)
        {
            RefreshInformation();
        }

        private void RefreshInformation()
        {
            panelID = 0;
            totalResults = searchResults.Count;
            recID = lastRecID;

            // If theres a slight remainder, add extra page 
            numPages = (totalResults / limit);

            if (numPages % limit > 0)
            {
                numPages += 1;
            }

            if (numPages > 1)
            {
                backBtn.Enabled = false;
                fwdBtn.Enabled = true;
            }else
            {
                backBtn.Enabled = false;
                fwdBtn.Enabled = false;
            }

            // Enable and disable button
            if (pageAt == 1)
            {
                backBtn.Enabled = false;
            }
            if (pageAt > 1)
            {
                backBtn.Enabled = true;
            }
            if (pageAt == numPages)
            {
                fwdBtn.Enabled = false;
            }
            if (pageAt < numPages)
            {
                fwdBtn.Enabled = true;
            }

            numOnPage = 0;

            foreach (var rec in searchResults)
            { 
                skip = (pageAt - 1) * limit;

                if (recID > skip - 1 && recID < (limit + skip) && recID < searchResults.Count)
                {
                    customerPanel cp = new customerPanel();
                    cp.Dock = DockStyle.Fill;
                    cp.customer = searchResults[recID];
                    panels[panelID].Controls.Add(cp);
                    panels[panelID].Visible = true;
                    panelID++;
                    lastRecID++;
                    numOnPage++;
                }
                recID++; 
            }

            if (totalResults == 0)
            {
                numPages = 1;

            }    
            numResultsLbl.Text = " " +totalResults + " Results | Page " + pageAt + " of " +numPages;
        }

        private void ClearPanels()
        {
            for (int i = 0; i < panels.Count; i++)
            {
                panels[i].Controls.Clear();
            }
        }

        private void fwdBtn_Click(object sender, EventArgs e)
        {
            pageAt++;
            ClearPanels();
            RefreshInformation();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            pageAt--;
            lastRecID = lastRecID - (limit + numOnPage);
            ClearPanels();
            RefreshInformation();
            int i = 0;
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
