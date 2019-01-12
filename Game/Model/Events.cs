using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Game
{
    public class Events
    {
        private string _EventFeedback;
        public string Feedback
        {
            get { return _EventFeedback; }
            set
            {
                _EventFeedback = value;

            }
        }
        private int _EventCount;
        public int EventCount
        {
            get { return _EventCount; }
            set
            {
                _EventCount = value;
            }
        }
        //Lists holding Event Values
        public List<int> EventID = new List<int>();
        public List<string> EventText = new List<string>();
        public List<string> EventFeedback = new List<string>();
        public List<string> ChoiceOne = new List<string>();
        public List<string> ChoiceTwo = new List<string>();
        public List<int> ChoiceId = new List<int>();

        //Random Varibale for Id Generation 
        private Random rnd = new Random();

        //New
        //Question array variables
        //public bool[] QuestionValid = new bool[20];
        public List<bool> QuestionValid = new List<bool>();
        private bool _QuestionValidity;
        public bool QuestionValidity
        {
            get { return _QuestionValidity; }
            set { _QuestionValidity = value; }
        }
        Choice Choices = new Choice();
        //Methods
        public string RequestAdvice(int Id)
        {
            return EventFeedback[Id]; //Display Feedback when requested
        }

        /*
         * Offlne Events - Remove once a database has been connected
         */
        public void InsertOfflineEvents()
        {
            string[] text = new string[20] { "Which one of the following can protect a computer from the risk of unwanted emails?", "Someone at your school asks for your password", "What username is better?", "Login to bank at school?", "Popup *Download New Flash Player* On a games website someone from your school recommended to you", "Would you use online banking while at home, connected to your local router?", "Email - 'Hey bro, can you click this link, I dont use computers ever and I dont know what to do' ", "What characters should exists in a password", "When you are filling out a form/survey online, how do you answer the questions?", "you get an email from an unknown email address. What do you do?", "You recieve an email with an attachment that you were not expecting from a friend", "Should your online identity/username be able to identify your gender?", "Would you post personal information of yours or anyone else without their consent ", "Would you complete a survey/profile page without your parents guardians permission", "Would you give someone you meet in a chat room your phone number?", "Would you send a digital picture of yourself to someone you met in a chatroom", "You are on a visiting a site from a company or organization that I've heard of. They want my name and phone number so I can enter a contest. Is it OK to enter?", "Hyperlink: BUY CHEAP COOL GAMES NOW!!!!!!!!! - Che4pGames.com", "'I HATE YOU' - Sandra", "Email 'Click this link for free money' - Paypal "};
            string[] feedbck = new string[20] { "Incognito mode does not change how emails are handled", "Passwords exist to ensure only you can enter the program", "Usernames should not reveal any clues", "Open internet connections can be dangerous", "Downloading from unknown websites can be dangerous!", "Is the connection safe?", "Do not click links from people that you do not trust", "Words that are not guessable are harder to remember/guess", "Do you trust the website enough to share your personal information", "Are you aware what is attached to the Email?", "Could the attached document harm your computer?", "Sharing information online can be dangerous ", "Once an item is uploaded it can not be deleted", "Do you feel safe sharing this information?", "Do you know what they can do with this information?", "Have you checked with your parents?", "Have you checked with your parents? The site might be a scam", "Do you believe that this is a trustworth site?", "Take action this is bullying, talk to people to find a solution and stop the mean messages", "If an seems offer is too good to be true then sometimes it is" };
            string[] choice1= new string[20] { "Anti-virus software.", "Dont give them it", "CharlieHarold01", "No", "Yes", "No, use the school's connection", "Delete email", "Lowercase and uppercase characters, a number and a special character", "Answer all questions truthfully", "Respond to the email and start a converstation", "Ask your parents if it is okay to open the attachment", "No", "Yes", "Yes", "No", "No", "No", "Delete", "Show Parent", "Open, and enter bank details" };
            string[] choice2 = new string[20] { "Incognito mode.", "Give them it", "TheOnlineGhost0109", "Yes", "No", "Yes", "Open email", "Capital letter, lowercase, and 5 random numbers", "Check with parent/guardian before sharing information online", "Ignore it, place it in the trash folder", "Open the attachment", "Yes", "No", "No", "Yes", "Yes", "Yes", "Open", "Reply", "Ignore it, place it in the trash folder" };
            int[] choiceid= new int[20] {1,1,4,1,2,2,1,3,4,6,3,1,2,2,1,3,3,1,1,6};

            for (int i = 0; i<20; i++)
            {
                EventID.Add(i);
                EventText.Add(text[i]);
                EventFeedback.Add(feedbck[i]);
                ChoiceOne.Add(choice1[i]);
                ChoiceTwo.Add(choice2[i]);
                ChoiceId.Add(choiceid[i]);
            }
        }
        //Insert Events
        public void InsertEvents()
        {
            Choices.Connection();  
            //SQL command
            SqlCommand sql = new SqlCommand("SELECT * FROM gameEvents ORDER BY eventID ASC", Choices.con); // WHERE eventId=@eventId  ORDER BY eventId ASC                                                                    //sql.Parameters.AddWithValue("eventId", Id);
                                                                                                   //data reader
            SqlDataReader rdr = sql.ExecuteReader();
            while (rdr.Read())
            {
                EventID.Add(Convert.ToInt32(rdr[0].ToString()));
                EventText.Add(rdr[1].ToString());
                EventFeedback.Add(rdr[2].ToString());
                ChoiceOne.Add(rdr[3].ToString());
                ChoiceTwo.Add(rdr[4].ToString());
                ChoiceId.Add(Convert.ToInt32(rdr[5].ToString()));
            }
            rdr.Close();
            //}
            Choices.ConnectionClose();
        }
        public int EventsCount()
        {
            Choices.Connection();
            SqlCommand sql = new SqlCommand("SELECT COUNT(*) FROM gameEvents", Choices.con);
            Int32 count = Convert.ToInt32(sql.ExecuteScalar());
            if (count > 0)
            {
                EventCount = count;
                return count;
            }
            else
            {
                return 0;
            }
        }
        /*
         Delete When Database Connection is set up
         */
         public void OfflineEventsCount()
        {
            EventCount = 20;
        }
       
        //Generate RandomID
        public int RandomId()
        {
            if (QuestionsAllUsed() == true)
            {
                QuestionBoolSet(); //Reset Events - making all unused if all are used
                return 0;
            }
            else
            {
                int result = rnd.Next(EventCount);
                while (QuestionValid[result] == true)
                {
                    result = rnd.Next(EventCount);
                }
                return result;
            }
            
        }
        //Mark IndividualEvent (Question) as used
        public void QuestionSet(int Id)
        {
            QuestionValid[Id] = true;
        }
        //Mark All Events as not used
        public void QuestionBoolSet()
        {
            if (QuestionValid.Count <= EventCount)
            {
                QuestionValid.Clear();
            }
            for (int i = 0; i < EventCount; ++i)
            {
                QuestionValid.Add(false);
            }
        }
        //Check if all Events have been used
        public bool QuestionsAllUsed()
        {
            for (int i = 0; i < EventCount; ++i)
            {
                if (QuestionValid[i] == false)
                {
                    return false;
                }
            }
            return true;
        }
        //Part 2
        public void RefreshLists()
        {
            EventID.Clear();
            EventText.Clear();
            EventFeedback.Clear();
            ChoiceOne.Clear();
            ChoiceTwo.Clear();
            ChoiceId.Clear();
            InsertEvents();
        }
        public int DeleteQuestion(int Id)
        {
            //SQL statement
            Choices.Connection();
            //SQL command
            SqlCommand sql = new SqlCommand("Delete FROM gameEvents WHERE eventId=@eventId", Choices.con);
            sql.Parameters.AddWithValue("eventId", Id);
            return sql.ExecuteNonQuery();
        }
        public int AddQuestion(int Id, string Text, string Advice, string FirstChoice, string SecondChoice, int ChoiceId)
        {
            //SQL statement
            Choices.Connection();
            //SQL command
            SqlCommand sql = new SqlCommand("INSERT INTO gameEvents(eventId, eventText, eventFeedback, choiceOne, choiceTwo, choiceID) Values (@eventId, @eventText," +
                "@eventFeedback, @choiceOne, @choiceTwo, @choiceID)", Choices.con);
            sql.Parameters.AddWithValue("eventId", Id);
            sql.Parameters.AddWithValue("eventText", Text);
            sql.Parameters.AddWithValue("eventFeedback", Advice);
            sql.Parameters.AddWithValue("choiceOne", FirstChoice);
            sql.Parameters.AddWithValue("choiceTwo", SecondChoice);
            sql.Parameters.AddWithValue("choiceID", ChoiceId);
            //ConnectionClose();
            return sql.ExecuteNonQuery();
        }
    }
}

