# Phase 3 - Implementation and Testing

## Task Allocation 

| Name | Role |
| ----------- | ----------- |
| Denis | User Database/Access comands for user database/login screen |
| Maisha | check history |
| Reshmaa | Borrowing Books |
| Sanjita | Fees Payment |
| Wojciech | Books Database/access commands for books database/readme |

## Introduction

The final phase for the project involves the implementation and testing of the product. The overall design of the code was done based on the requirements of the previous phases, as well as the final product brief. Individual elements of the project were then split up to be completed by indivudual team members.

## Implementation

The implementation for the project involved splitting it up into smaller elements to make it more managable. The use of the functions has been explained below.

### SQLcommands.cs

This file was created as an interface between the other functions and the databases. It included multiple functions inside, with each completing a different function on the database when called.

### login.cs

Used to add functionality into the login screen. Checks the input fields for entered data and checks them against the database of users.

### StaffHome.cs and StudentHome.cs

Adding functionality to the pages seen after logging in. StaffHome.cs allows for functionality for the screen if login in as a user that has been marked as a staff member, and the StudentHome.cs adds different functionality if logged into an account marked as a student.

### StudentMyInfo.cs

When on the update details page, allows users logged in with a student account to modify their own details.

### ManageStudentAccounts.cs

This code gives staff members the capability to look up a student account's details and modify them.

### Checkhistory.cs



## Testing

Testing of individual elements had to be done to make sure that they work as intended.

### Working elements

- The login page worked as intended
- Editing the account information modifies the database as intended
- The logout button closed the account window

### Non functioning elements

- Some of the buttons in the home page did not function properly
- The database for the books as well as some of the functionality to borrow did not function well
