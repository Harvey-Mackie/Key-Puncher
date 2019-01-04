# Key Puncher Game

A minimalist educational game that aims to teach kids/young adults about the impacts of their choices online with a retro twist.

Game developed using C# Windows Forms 
<br/>
<br/>

## Requirements
- Download Tables (Can be found in the Tables.sql file)
- Change the connection variable called 'connstring' in the Choice class (Located within the 'Game' project inside the solution) to link to the database where the tables are stored.



---
# User Guide

The ‘<-' button that appears at the top left of certain forms closes the current form and opens the previous form.

---

## Login Form

The form requires the text boxes to contain valid credentials to authorise the account and allow access to the Menu form. Enter the credentials in with the appropriate case sensitivity. 

The credentials must be inserted into the correct text box(s) – distinguishable due to the allocated label on the left-hand side of the form.

Once the Username and Password credentials are entered correctly, click the ‘Submit’ button.  

If the account exists then the account will be validated, resulting in the form closing and the Menu form opening. If the Menu form is not opened, then the credentials you entered are not registered.

---

## Menu Form
 The form allows navigation between all pages that the logged in account is authorised to access.  

 The ‘Admin Page’ button is only visible and clickable by authorised users. The button navigates to the Admin form and closes the Menu form. 

 The ‘Play’ button closes the Menu form and opens the Game form. 
 The ‘Scores’ button closes the Menu form and opens the Scores form. 
 The ‘Log-out’ button closes the Menu form and opens the Login form.

---
## Scores Form
 The form displays the top ten scores that are registered on the system. There are three categories – Position, Username and Score. 

  Position displays the score ranking in ascending order. (1 is the top score and 10 is the lowest score).  

 Username is the name allocated to the user who holds the position.  

 Score determines the position – the lowest score is the best score. 

---
## Game Form
 The form contains three attributes - Reputation, Turn and Virus, they are set to 50, 0, and 50 at the start of every game - each choice selected modifies the attributes values. 

 The Black rectangle located in the centre of the form and displays questions/events.

 The ‘Advice’ button provides the user with appropriate feedback to help answer the question.

 There are two choices for each event, both are located within the buttons at the bottom of the form. Selecting a choice will affect the Reputation and Virus values depending on the choice outcome (correct or incorrect) and increment the turn attribute. 

 Selecting an incorrect choice will increase the Virus count and decrease the Reputation count. 

 Selecting a correct choice will increase the Reputation count and decrease the Virus count.

- Win – To win the game Reputation count must reach 100 or Virus count must reach 0.  
- Lose – To lose the game the Virus count must each 0 or the Reputation count must reach 100. 

Each question has an allocated difficulty and the Reputation/Virus effect values change depending on the difficulty setting: 

| Difficulty  | Correct | Incorrect |
| ------------- | ------------- | ------------- |
| 1  | Reputation increase by 5, Virus decrease by 5. | Reputation decrease by 5, Virus increase by 5.  |
| 2  | Reputation increase by 10, Virus decrease by 10. | Reputation decrease by 10, Virus increase by 10. |
| 3  | Reputation increase by 15, Virus decrease by 15. | Reputation decrease by 15, Virus increase by 15. |
---
## Admin Form

 The form allows authorised users to add and remove questions. 

 On the right-hand side of the form there are two tables visible via the tab control. The buttons ‘Question’ and ‘Choices’ change the table view appropriately. 

 The Question table holds all the questions/events that will be displayed on the Game form. The choice table holds the outcome of each choice. 

 Each Question has a Choice Id attached to determine the correct choice and the difficulty of the question – odd numbers ensure that choice one is the correct answer and even numbers ensure that choice two is correct. 

 To add a question, populate the form on the left-hand side and click the ‘Add’ button once the form is complete. The Question ID must be unique and cannot match an existing question Id in the table on the right.  

 To **delete** a question, insert an existing Question ID and click the ‘Delete’ button. 

 ---

 ## Credits

 - System Design and Code - Harvey Mackie (https://mayar.abertay.ac.uk/~1702389/Portfolio/view/index.php)
