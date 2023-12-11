# Phase 1 - Requirements Engineering

## Introduction

A library system that needs to be capable of managing the users is required. Users need to be able to check out the books from the available stock and pay the over-due fees if they have them. Staff needs to be able to create and delete the users with a confirmaion prompt when removing a user and edit the list of available books. The IDs representing each user should be formated and stored in a specific way, that is described in "System Requirements and Specifications" section. Using IDs as a reference staff members should be able to access the full information about the user including their fullname, current books they hold, their unpaid over-due and history of their book borrowing.

The over-due fees should be capped at the borrowed books value and setted manually by staff and should increase by 10p every day of the book over-due date.

The major aspect of the system is security. Since users are expected to share their billing deails with the system it should focus on providing the data protection and the data leakage should not be possible. In order to achieve that special security measures, including protected authentification system, firewalls, constant bugfix update development must be in use. Deep description of the security measures can be found in "Risk Management" section.

The development strategy of the project is described by the chosen incremental development model. The reasons for this choice are described in the "Software Proces Model" section. Kanban was used to track the progress and assing people to solving the particular issues, the Kanban screenshot can be found in the "Kanban" section. 

## System Requirements and Specifications

The system requirements listed below are devided into functional and not functional. Functional requirements are the basic ones that allow system to work correctly and describe the functionality. Non-functional requirements despite not adding new features to the system, provides a safe and user friendly experience of using the system with low risks of acciential actions with consequences.

### Functional requirements

- Data Bases

    The system should include two data bases, one that contains the users' information and the other that contains the list of available books. Both data bases should be editable by staff members. When users access the system they should be able to choose the books they need to borrow and pay the fees in case of over-due via adding an online payment method.

    The users data base should be capable of storing at least 23000 users (The amount of students currently studying in University of Greenwich) with their details such as First and Second names, history of borrowed books and payments, account registration date and a user ID stored in a specific way:

    1. First part is composede of the initials of the user
    2. Second part is a randomly generated code of four numbers
    3. Third part is a randomly generated single letter

    The book database should be capable of storing at least 50000 books, where each book should have the information about the author, title, cover image, isbn number and synopsis as well as borrowing history, date of publication and date of adding it into the library, current status of availability. The book data base should also allow the multiple copies of the same book to be stored.

    The staff interaction with the system should allow them to change the status of the book from being available to being on loan with providing the user ID of the student loaning the book. The staff should also be able to add, edit or delete user details from the users data base and add and delete books from the books data base.

- Authentification system

    Authentification system should feature two different account classes: users and staff. These classes have different level of acess and the actions they can do using their accounts. The book can not be borrowed by staff, while non of the data bases (books and users) can be edited by user. In order to achieve that authentification system must be able to recognize staff accounts and separate them from users' accounts.

    The system's main purpose is to acceess the users' database and the passwords list and find the passwords corresponded to the user names and accounts when loging in. The password list should be incrypted in order to provide required level of safety and the system needs to be able to understand this encryption.
    
- Payment system

    Payment system won't be developed from scratch for the project. Like most of the web services this project will rely on the existing payment system (for example: Klarna) yet to be decided. The main requirement for the chosen payment system is security and the additional research of the security quality of different services is required.

### Non-Functional requirements

- Confirmation pop-ups

    In order to reduce the accidential actions with unwanted consequences a couple of actions in the system should be followed by pop-up windows requiring a confirmation. This should be applied on these actions:

    1. Editing or deleting the book from the books data base by a staff member
    1. Editing or deleting the user's details from the users data base by a staff member
    2. Returning a book by user
    3. Making a payment for the over-due by user

    Implementation of thse pop-ups significantly can significantly reduce the amout of accidentially deleted books, users and payments.

- User friendly interface

    User friendly interface should be implemented to encourage students to use the system rather than being unintuitive and pushing them to ignore the provided recources. The basic rules of keeping the interface user friendly that should be followed includes not creating overloaded interface with too much menus and buttons and keeping the sequence of actions to perform a particular task while interacting the system as short as possible.

- Mobile version of the web site

    Mobile version of the web site should be created in order to provide a better experence for users interacting with the system with their mobile phones. This version of the web-site should feature larger buttons that can be easily pressed on the small touch screen and larger font.