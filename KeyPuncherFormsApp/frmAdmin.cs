using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data;
using Game;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KeyPuncherFormsApp
{
    public partial class frmAdmin : MaterialForm
    {
        public User AdminUser;
        Events Event = new Events();
        Choice Choice = new Choice();
        public frmAdmin()
        {
            InitializeComponent();
            //Design
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
        public void LoadQuestions()
        {

            Event.EventsCount();
            Event.RefreshLists();
            DataTable Events = new DataTable();

            Events.Columns.Add("Question ID", typeof(int));
            Events.Columns.Add("Text", typeof(string));
            Events.Columns.Add("Advice", typeof(string));
            Events.Columns.Add("Choice One", typeof(string));
            Events.Columns.Add("Choice Two", typeof(string));
            Events.Columns.Add("Choice Id (Determines Answer)", typeof(int));

            //Add Values
            for (int Increment = 0; Increment < Event.EventsCount(); Increment++)
            {
                Events.Rows.Add(Event.EventID[Increment], Event.EventText[Increment], Event.EventFeedback[Increment], Event.ChoiceOne[Increment], Event.ChoiceTwo[Increment], Event.ChoiceId[Increment]);
            }

            dgEvents.DataSource = Events;
        }
        public void LoadChoices()
        {
            Choice.InsertChoices();
            DataTable Choices = new DataTable();

            Choices.Columns.Add("Choice ID", typeof(int));
            Choices.Columns.Add("Difficulty", typeof(int));
            Choices.Columns.Add("Choice One Reputation", typeof(int));
            Choices.Columns.Add("Choice One Virus", typeof(int));
            Choices.Columns.Add("Choice Two Reputation", typeof(int));
            Choices.Columns.Add("Choice Two Virus", typeof(int));

            //Add Values
            for(int Increment = 0; Increment < Choice.ChoicesCount(); Increment++)
            {
                Choices.Rows.Add(Choice.ChoiceId[Increment], Choice.EventDifficulty[Increment], Choice.ChoiceOneRep[Increment], Choice.ChoiceOneVirus[Increment], Choice.ChoiceTwoRep[Increment], Choice.ChoiceTwoVirus[Increment]);
            }
            dgChoices.DataSource = Choices;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string line = txtEventId.Text;
            int Id;
            try
            {
                if (txtEventId.Text != "")
                {
                    DialogResult DialogResult = MessageBox.Show("Are you sure you want to delete the Event: " + line + ", the question can not be recovered", "Delete Question", MessageBoxButtons.YesNo);
                    if (DialogResult == DialogResult.Yes)
                    {
                        try
                        {
                            Id = Int32.Parse(line);
                            if (Event.DeleteQuestion(Id) > 0)
                            {
                                MessageBox.Show("Question " + Id + " has been deleted.");
                            }
                            else
                            {
                                MessageBox.Show("Question " + Id + " could not been deleted");
                            }
                            LoadQuestions();
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show(line + " is not a numerical value - an ID needs to be numerical.");
                        }
                    }
                    else if (DialogResult == DialogResult.No)
                    {
                        MessageBox.Show("No changes made to the datbase");
                    }
                }
                else
                {
                    MessageBox.Show("Event ID must have a value");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Can't connect to the database - Question could not be deleted");
            }
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            try
            {
                LoadQuestions();
                LoadChoices();
            }
            catch (SqlException)
            {
                MessageBox.Show("Can't connect to the database");
                btnBack.PerformClick();
            }

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Container Left - The Form allows admins to add and remove questions. To remove a question, enter a question ID and press delete.To add a question, choose a Question ID that has not" +
                "already been used, and fill the form out accordingly. Choice ID determines the correct choice and the difficulty of the question even numbers mean that the correct answer  is Choice Two. " +
                " Container Right - The Data grid view displays the database that contains all the questions and choices. Use the buttons -Questions and Choices- to navigate between tables.");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu Menu = new frmMenu();
            Menu.MenuUser = AdminUser;
            Menu.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    Convert.ToInt32(txtEventId.Text);
                    Convert.ToInt32(txtChoiceId.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("ID inputs must be numeric");
                }
                if (txtEventId.Text != "" || txtText.Text != "" || txtAdvice.Text != "" || txtChoiceOne.Text != "" || txtChoiceTwo.Text != "" || txtChoiceId.Text != "")
                {
                    if (txtText.Text.Length > 500 || txtAdvice.Text.Length > 300 || txtChoiceOne.Text.Length > 100 || txtChoiceTwo.Text.Length > 100)
                    {
                        MessageBox.Show("Question credentials are too big. 1. Text is limited to 500 characters. 2. Advice is limited to 300 characters. 3. Choice One is limited to 100 characters. 4. Choice Two is limited to 100 characters");
                    }
                    else
                    {
                        if (Event.EventID.IndexOf(Convert.ToInt32(txtEventId.Text)) > 0)
                        {
                            MessageBox.Show("EventID has already been taken - ID must be unique");
                        }
                        else
                        {
                            if (Event.AddQuestion(Convert.ToInt32(txtEventId.Text), txtText.Text, txtAdvice.Text, txtChoiceOne.Text, txtChoiceTwo.Text, Convert.ToInt32(txtChoiceId.Text)) > 0)
                            {
                                MessageBox.Show("Question Added");
                                LoadQuestions();
                            }
                            else
                            {
                                MessageBox.Show("Question was not added");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Form must be completed before a question can be added");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Can't connect to the database - Question could not be added");
            }

        }

        private void dgEvents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = e.RowIndex;
            try
            {
                if (dgEvents.SelectedCells.Count > 0)
                {
                    int SelectRow = dgEvents.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRows = dgEvents.Rows[SelectRow];

                    txtEventId.Text = selectedRows.Cells[0].Value.ToString();
                    txtText.Text = selectedRows.Cells[1].Value.ToString();
                    txtAdvice.Text = selectedRows.Cells[2].Value.ToString();
                    txtChoiceOne.Text = selectedRows.Cells[3].Value.ToString();
                    txtChoiceTwo.Text = selectedRows.Cells[4].Value.ToString();
                    txtChoiceId.Text = selectedRows.Cells[5].Value.ToString();
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                LoadQuestions();
            }


        }
    }
}
