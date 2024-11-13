using MauiApp1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WinFormsApp1
{
    public partial class DetailForm : Form
    {
        private Assignment assignment;
        private DBContext dbContext = new DBContext();
        public event EventHandler DataSaved;
        public DetailForm()
        {
            InitializeComponent();
            LoadComboBoxes();
            assignment = new Assignment();

        }

        public DetailForm(Assignment assignment)
        {
            InitializeComponent();
            LoadComboBoxes();
            this.assignment = assignment;
            button2.Text = "Delete";
            if (assignment != null)
            {
                txtTitle.Text = assignment.Title ?? string.Empty;
                txtDescription.Text = assignment.Description ?? string.Empty;
                comboPriority.SelectedIndex = assignment.PriorityID >= 0 ? assignment.PriorityID-1 : -1;
                comboStatus.SelectedIndex = assignment.StatusID >= 0 ? assignment.StatusID-1 : -1;
            }
            else
            {
                txtTitle.Text = string.Empty;
                txtDescription.Text = string.Empty;
                comboPriority.SelectedIndex = -1;
                comboStatus.SelectedIndex = -1;
            }
        }

        private void LoadComboBoxes()
        {
            List<Priority> priorities = dbContext.Priorities.ToList();
            comboPriority.DataSource = priorities;
            comboPriority.DisplayMember = "PriorityName";
            comboPriority.ValueMember = "PriorityID";
            comboPriority.SelectedIndex = 0;

            List<Status> statuses = dbContext.Statuses.ToList();
            comboStatus.DataSource = statuses;
            comboStatus.DisplayMember = "StatusName";
            comboStatus.ValueMember = "StatusID";
            comboStatus.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (assignment == null)
            {
                assignment = new Assignment
                {
                    Title = txtTitle.Text,
                    Description = txtDescription.Text,
                    Priority = (Priority)comboPriority.SelectedItem,
                    Status = (Status)comboStatus.SelectedItem
                };
                AssignmentManager.Add(assignment);
            }
            else
            {
                assignment.Title = txtTitle.Text;
                assignment.Description = txtDescription.Text;
                assignment.Priority = (Priority)comboPriority.SelectedItem;
                assignment.Status = (Status)comboStatus.SelectedItem;
                AssignmentManager.Update(assignment);
            }
            DataSaved?.Invoke(this, EventArgs.Empty);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Delete" && assignment != null)
            {
                AssignmentManager.Delete(assignment);
            }
            DataSaved?.Invoke(this, EventArgs.Empty);
            Close();
        }
    }
}
