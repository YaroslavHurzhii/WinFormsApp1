using MauiApp1;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        List<Assignment> assignments;
        private DBContext dbContext = new DBContext();
        private bool formLoaded = false;
        public Form1()
        {
            InitializeComponent();
            FillCheckBoxes();
            LoadAssignments();
        }

        public void LoadAssignments()
        {
            assignments = AssignmentManager.Get();
            listBox1.DataSource = assignments;
            listBox1.DisplayMember = "ToString";
        }

        private void FillCheckBoxes()
        {
            var priorities = dbContext.Priorities.ToList();
            var statuses = dbContext.Statuses.ToList();
            checkedListBox1.Items.Clear();
            checkedListBox2.Items.Clear();
            foreach (var priority in priorities)
            {
                checkedListBox1.Items.Add(priority, true);
                checkedListBox1.DisplayMember = "PriorityName";
            }
            foreach (var status in statuses)
            {
                checkedListBox2.Items.Add(status, true);
                checkedListBox2.DisplayMember = "StatusName";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DetailForm detailForm = new();
            detailForm.DataSaved += (sender, e) => LoadAssignments();
            detailForm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }


        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            //LoadAssignments();
            if (listBox1.SelectedItem != null)
            {
                Assignment selectedAssignment = listBox1.SelectedItem as Assignment;

                if (selectedAssignment != null)
                {
                    DetailForm detailForm = new(selectedAssignment);
                    detailForm.DataSaved += (sender, e) => LoadAssignments();
                    detailForm.Show();
                }
            }
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (formLoaded)
            {
                BeginInvoke(new Action(() => ApplyFilters()));
            }
        }

        private void checkedListBox2_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (formLoaded)
            {
                BeginInvoke(new Action(() => ApplyFilters()));
            }
        }

        private void ApplyFilters()
        {
            LoadAssignments();
            var filteredAssignments = assignments;
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                filteredAssignments = filteredAssignments.Where(a => a.Title.Contains(textBox1.Text) || a.Description.Contains(textBox1.Text)).ToList();
            }
            var selectedPriorities = checkedListBox1.CheckedItems
                .Cast<Priority>()
                .Select(p => p.PriorityID)
                .ToList();

            var selectedStatuses = checkedListBox2.CheckedItems
                .Cast<Status>()
                .Select(s => s.StatusID)
                .ToList();

            filteredAssignments = filteredAssignments
                .Where(task =>
                    (selectedPriorities.Count == 0 || selectedPriorities.Contains(task.PriorityID)) &&
                    (selectedStatuses.Count == 0 || selectedStatuses.Contains(task.StatusID)))
                .ToList();

            listBox1.DataSource = filteredAssignments;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formLoaded = true;
        }
    }
}
