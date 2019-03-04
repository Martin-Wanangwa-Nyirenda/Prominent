using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prominent.ProjectInfo;

namespace Prominent
{
    public partial class Form1 : Form
    {
        private Project project;
        private ProjectInfo.ProjectInfo Info;
        private ProjectUploadControl ProjectUploadControl;

        public Form1()
        {
            InitializeComponent();
            UIControlInit();
            //PopulateListView(CreateListViewItem());
            
        }

        private void ComboBox1_TextChanged(object sender, EventArgs e)
        {
            string value = "hahaha";
            MessageBox.Show(value);
            //Request new json from server
            //repopulate Listview 
        }

        private void addProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectUploadControl.Show();
        }

        private void PopulateListView(List<ListViewItem> listViewItems)
        {
            foreach (ListViewItem item in listViewItems)
            {
                listView1.Items.Add(item);
            }      
        }

        private void InitListView()
        {
            Info = new ProjectInfo.ProjectInfo("");
            project = new Project();
            listView1.Columns.Add("Code No.");
            listView1.Columns.Add("Name");
            listView1.Columns.Add("Date Uploaded", -2, HorizontalAlignment.Left);
        }

        private List<ListViewItem> CreateListViewItem()
        {
            List<ListViewItem> items = new List<ListViewItem>();

            foreach(Project project in Info.GetProjects())
            {
                items.Add(new ListViewItem(new[] { project.BackUpCode.ToString(), project.Name, project.DateBackedUp }));
            }

            return items;
        }

        private void UIControlInit()
        {
            //ListView Initialization
            listView1.View = View.Details;
            //InitListView();

            //ComboBox Initialization
            comboBox1.TextChanged += ComboBox1_TextChanged;

            //Download Button
            downloadBtn.Enabled = false;
            delBtn.Enabled = false;
          

            listView1.ItemSelectionChanged += delegate
            {
                ListViewItemSelected();
            };

            //User Control
            ProjectUploadControl = new ProjectUploadControl();
            
        }

        private void ListViewItemSelected()
        {
            downloadBtn.Enabled = true;
            delBtn.Enabled = true;
        }

        private void addProjectBtn_Click(object sender, EventArgs e)
        {
            ProjectUploadControl.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.MessageLoop)
            {
                Application.Exit();
            }
            else
            {
                Environment.Exit(1);
            }
        }
    }
}
