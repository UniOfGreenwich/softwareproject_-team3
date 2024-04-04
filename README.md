# Phase 3  -   IMPLEMENTATION AND TESTING 
---------------------------------------------------------
## Task Allocation 

| Name | Assignment |
|-----|-----| 
|[Denis](https://github.com/wheissmd) | User table in Database // Access comands for user database // Login Screen // Home Screeen After Login // Manage Student Accounts
|[Wojciech](https://github.com/flock-of-jays)| Books table in Database // Access comands for books database // Readme
|[Reshmaa](http://github.com/reshmaa2005)| Borrowing Books // Table // Updated Readme Photos
|[Maisha](https://github.com/maishkhan)| Check History
|[Sanjita](http://github.com/SanjiGre99)| Fees Payment  
 

## Introduction

The final phase for the project involves the implementation and testing of the product. The overall design of the code was done based on the requirements of the previous phases, as well as the final product brief. Individual elements of the project were then split up to be completed by indivudual team members.


## Implementation

The implementation for the project involved splitting it up into smaller elements to make it more managable. The use of the functions has been explained below.

 ### SQLcommands.cs

This file was created as an interface between the other functions and the databases. It included multiple functions inside, with each completing a different function on the database when called.

 ### Login.cs

Used to add functionality into the login screen. Checks the input fields for entered data and checks them against the database of users.

![image](https://github.com/TeachingMaterial/softwareproject_-team3/assets/146332550/55a37a49-b848-4953-ab61-6c6d0064e48c)


### StaffHome.cs and StudentHome.cs

Adding functionality to the pages seen after logging in. StaffHome.cs allows for functionality for the screen if login in as a user that has been marked as a staff member, and the StudentHome.cs adds different functionality if logged into an account marked as a student.

Student page gives the option to view their information, borrow a book, pay any overdue fees, check their borrowing history, and for logging out. Staff page gives the options to view their account information, confirm the borrowing of a book, manage a student's account, manage the books in inventory, and logging out.

![image](https://github.com/TeachingMaterial/softwareproject_-team3/assets/146332550/208e5f78-5e50-49e1-b99d-24946dcb0e8b)

 ### StudentMyInfo.cs

When on the update details page, allows users logged in with a student account to modify their own details.
![image](https://github.com/TeachingMaterial/softwareproject_-team3/assets/146332550/bd5c3ec0-ddb3-47a2-8f59-efc6aeba12a2)

### ManageStudentAccounts.cs

This code gives staff members the capability to look up a student account's details and modify them.

### Borrowing Book 

This system facilitates users in borrowing books by allowing them to input the book's title into the designated field and subsequently clicking the "Search" button. Upon connection to the book database, the system displays the relevant book information, including its title and image. This feature ensures ease of identification for both students and staff. Upon selection, users can click the "Add" button, which prompts automatic display of the borrowing date and pre-set returning date. Alternatively, users have the option to erase the searched book by clicking the “Delete” button, enabling them to search for alternative titles. Regrettably, certain functions within the system are currently non-operational.  
![image](https://github.com/TeachingMaterial/softwareproject_-team3/assets/146332550/5ded0203-febb-4681-bed7-ccaa90e04859)


### Check History.cs

The application likely deals with managing a history of books, providing a user interface to view, update, and delete
![image](https://github.com/TeachingMaterial/softwareproject_-team3/assets/146332550/b0de34d7-5b40-4c37-ad09-9c8877e44854)

1. Namespace and Class Declaration
- namespace dataBASE declares a namespace called dataBASE. Namespaces are used to organize code and prevent naming conflicts.
- partial class Checkhistory is a declaration of a partial class named Checkhistory. The partial keyword indicates that the class definition may be split across multiple files.

2. Components and Layout
- private System.ComponentModel.IContainer components = null; declares a container for components.
- InitializeComponent method is where the setup of the UI components happens. This includes creating buttons, text boxes, 
  labels, panels, and a data grid view, setting their properties (like location, size, fonts), and adding them to the form.
- Panels (panel1 and panel2) are used to group other controls together. panel1 seems to be the main container, while panel2 
  might be used for detailed book information or operations.
- Buttons (button1 to button5) serve various functions such as refreshing the data grid view, updating records, deleting 
  records, etc.
- Text Boxes (textBox1 to textBox6) are likely used for inputting or displaying book information such as name, author, ISBN, 
  and publication details.
- Labels (label1 to label6) provide textual descriptions or titles for UI elements.
- DataGridView (dataGridView1) is used to display a list of books, allowing users to view the history in a tabulated format.
  
3. Event Handlers
- Methods like button1_Click, label1_Click, label2_Click, panel1_Paint, and dataGridView1_CellClick are placeholders for event handlers that respond to user actions like clicks. The actual functionality (e.g., refreshing data, selecting a book from the grid) would be implemented in these methods, but the implementations are not shown in this snippet.
  
4. Functionality Summary
This form allows users to interact with a database of book records. Users can search for books by name, view a list of books, select a book to see more details, and perform actions like update or delete records.
The actual database interactions (queries, updates, deletions) are not shown in this code snippet, indicating they are handled elsewhere in the application, possibly in other parts of the partial class or in separate classes.


## Testing

Testing of individual elements had to be done to make sure that they work as intended.

### Working elements

- The login page worked as intended
- Editing the account information modifies the database as intended
- The logout button closed the account window

### Non functioning elements

- Some of the buttons in the home page did not function properly
- The database for the books as well as some of the functionality to borrow did not function well
