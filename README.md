# Key Puncher Game

A minimalist educational game that aims to teach kids/young adults about the impacts of their choices online with a retro twist.

This game can be used in a School environment due to there being different user types with different permissions. Thus creating a Teacher and Student system.

The purpose of having users with different permissions is to ensure that the game can be deployed and maintained without the developer needing to modify the database, as the admins/teachers/authorised users have access to the 'Admin Form' where questions can be added and removed directly from the database.

There are different user permissions are required to prevent unauthorised users (students) from modifying the database.

The system is not at risk of modification threats and the user's permissions are checked on every form.

Game developed using C# Windows Forms 
<br/>
<br/>

## Branches

- Download the game from the *master* branch to have the full version, to play the offline version (limited features) download the *offline* branch

- This ReadMe file is created for the **master** branch
- However, also applys for the **'Offline'** branch. I created the 'Offline' branch to allow for some of the game to be played without having to set up the database, to allow users to test the game. The 'Admin Form' cannot be accessed while in offline mode due to the page requiring a database connection. 

- **Offline Version**
![offline](https://user-images.githubusercontent.com/38426388/50686684-3e2d6c80-1016-11e9-85c6-d03e592bdc9f.PNG)

## Requirements
- Download Tables (Can be found in the Tables.sql file)
- Change the connection variable called 'connstring' in the Choice class (Located within the 'Game' project inside the solution) to link to the database where the tables are stored.



---
# User Guide

The **‘<-' button** that appears at the top left of certain forms closes the current form and opens the previous form.



## Login Form

The form requires the text boxes to contain valid credentials to authorise the account and allow access to the Menu form. Enter the credentials in with the appropriate case sensitivity. 

The credentials must be inserted into the correct text box(s) – distinguishable due to the allocated label on the left-hand side of the form.

Once the Username and Password credentials are entered correctly, click the ‘Submit’ button.  

If the account exists then the account will be validated, resulting in the form closing and the Menu form opening. If the Menu form is not opened, then the credentials you entered are not registered.

 ![login](https://user-images.githubusercontent.com/38426388/50686721-65843980-1016-11e9-9c4d-1875a8f9e5d0.PNG)

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

[![Image from Gyazo](https://i.gyazo.com/dcbda4151561691d849cfee7823f7fb9.png)](https://gyazo.com/dcbda4151561691d849cfee7823f7fb9)
---
## Game Form
 The form contains three attributes - Reputation, Turn and Virus, they are set to 50, 0, and 50 at the start of every game - each choice selected modifies the attributes values. 

 The Black rectangle located in the centre of the form and displays questions/events.

 The ‘Advice’ button provides the user with appropriate feedback to help answer the question.
 ![game](https://user-images.githubusercontent.com/38426388/50686757-8c427000-1016-11e9-87ef-0244553c7b79.PNG)
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

 To **add** a question, populate the form on the left-hand side and click the ‘Add’ button once the form is complete. The Question ID must be unique and cannot match an existing question Id in the table on the right.  

 To **delete** a question, insert an existing Question ID and click the ‘Delete’ button. 
 
 [![Image from Gyazo](https://i.gyazo.com/d48fc3f0c129e1f4ba9c8d2d2989138d.gif)](https://gyazo.com/d48fc3f0c129e1f4ba9c8d2d2989138d)

 ---

 ## Credits

 - System Design and Code - Harvey Mackie (https://mayar.abertay.ac.uk/~1702389/Portfolio/view/index.php)
