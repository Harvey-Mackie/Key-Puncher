using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using Game;
using MaterialSkin;
using MaterialSkin.Controls;

namespace KeyPuncherFormsApp
{
    public partial class frmGame : MaterialForm
    {
        public User GameUser;
        Events Event = new Events();
        Choice Choice = new Choice();
        Score Scores = new Score();

        public void CalculateOutcome(int ChoiceR, int ChoiceV)
        {
            Choice.ReputationStart += ChoiceR;
            Choice.VirusStart += ChoiceV;
            if(ChoiceR < 0)
            {
                MessageBox.Show("Wrong Answer, use the advice to recieve help", "Game Help");
            }
            Choice.TurnCounterIncrement(); //Increment TurnCount due to button click
            DisplayAttributes(); //Displays all Attributes to Form label
            if(Choice.ReputationStart >= 100 || Choice.ReputationStart <= 0 || Choice.VirusStart >= 100 || Choice.VirusStart <= 0)
            {
                int Indicator=1;
                try
                {
                    Indicator = Choice.CheckVariables(Choice.ReputationStart, Choice.VirusStart, Choice.TurnCounter, GameUser.Username, GameUser.Offline);
                }
                catch(SqlException)
                {
                    MessageBox.Show("Can't connect to the database to compare high scores.");
                }
                finally
                {
                    EndGame(Indicator);
                }
            }
            ComputeChoice();
        }

        public frmGame()
        {
            InitializeComponent();
            //Design
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }
        private void frmGame_Load(object sender, EventArgs e)
        {
            try
            {
                if(GameUser.Offline==false)//Remove when Database Connection is set up, as will improve run time
                {
                    Choice.Connection(); //Open Connection if not open
                    Event.EventsCount(); //Number of events in the database
                    Choice.InsertChoices(); //Insert Choices
                    Event.RefreshLists(); //Insert Events
                }
                else
                {
                    Event.OfflineEventsCount();
                    Choice.OfflineInsertChoices();
                    Event.InsertOfflineEvents();
                }
                Choice.ResetTurnCount();//Turncount(Attribute)
                Choice.ResetReputation();//Reputation(Attribute)
                Choice.ResetVirus();//Virus(Attribute)
                DisplayAttributes();//Display all Attributes
                Event.QuestionBoolSet();//Set all Questions to not used (false)
                ComputeChoice(); //Display Question and Recieve Correct Choice
            }
            catch(SqlException)
            {
                MessageBox.Show("Can't connect to the database.");
                btnGameBack.PerformClick();
            }
        }
        private void btnOptionOne_Click(object sender, EventArgs e)
        {
            CalculateOutcome(Choice.ChoiceOneReputation, Choice.ChoiceOneViruses);
        }
        private void btnOptionTwo_Click(object sender, EventArgs e)
        {
            CalculateOutcome(Choice.ChoiceTwoReputation, Choice.ChoiceTwoViruses);
        }
        private void btnFeeback_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Event.Feedback);
        }
        //Navigation
        private void btnGameBack_Click(object sender, EventArgs e)
        {
            //Open Menu
            this.Hide();

            frmMenu frmMenu = new frmMenu();
            frmMenu.MenuUser = GameUser;
            frmMenu.Show();

        } //Back button - To Menu
        public void OpenScores()
        {
            this.Hide();
            frmScores frmScores = new frmScores();
            frmScores.ScoresUser = GameUser;
            frmScores.Show();
        } //Open Scores Form - frmScores
        //New Methods
        //Display Event
        public int DisplayEvent()
        {
            //Random ID
            int Question = Event.RandomId();//Generate RandomId to randomise Events
            Event.QuestionValidity = Event.QuestionsAllUsed(); //Check if all Events have been used

            lblQuestion.Text = Event.EventText[Question];
            btnOptionOne.Text = Event.ChoiceOne[Question];
            btnOptionTwo.Text = Event.ChoiceTwo[Question];

            Event.Feedback = Event.RequestAdvice(Question); //Display Advice when button is clicked

            Event.QuestionSet(Question); //Set Event as Used

            return Event.ChoiceId[Question]; //return ChoiceId to determine correct answer

        } //Post Event Values to Form Labels
        public void ComputeChoice()
        {
            int Id = DisplayEvent();
            if (Id <= 0)
            {
                Id = DisplayEvent();
            }
            else
            {
                //Values inputted to variabes.
                Choice.ChoiceOneReputation = Choice.ChoiceOneRep[Id];
                Choice.ChoiceOneViruses = Choice.ChoiceOneVirus[Id];
                Choice.ChoiceTwoReputation = Choice.ChoiceTwoRep[Id];
                Choice.ChoiceTwoViruses = Choice.ChoiceTwoVirus[Id];
            }
        }
        //Attributes Display
        public void DisplayAttributes()
        {
            lblTurns.Text = Choice.TurnCounter.ToString(); //TurnCount Display
            lblReputation.Text = Choice.ReputationStart.ToString(); // Reputation Display
            lblVirus.Text = Choice.VirusStart.ToString(); // Virus Display
        }
        //Display End Game Result to User
        public void EndGame(int Indicator)
        {
            switch (Indicator)
            {
                case 1:
                    MessageBox.Show("Game Lost!");
                    OpenScores();
                    break;
                case 2:
                    MessageBox.Show("Win - Virus' and Reputaion has Reached 100");
                    MessageBox.Show("Well Done on completeing the game! However, you sadly did not make the high scores table");
                    OpenScores();
                    break;
                case 3:
                    MessageBox.Show("NEW HIGH SCORE - Your Score is now in the top 10 high scores!");
                    OpenScores();
                    break;
            }
        }
    }
}
