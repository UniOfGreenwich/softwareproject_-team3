# Phase 1 - Requirements Engineering

## Introduction

A library system that needs to be capable of managing the users is required. Users need to be able to check out the books from the available stock and pay the over-due fees if they have them. Staff needs to be able to create and delete the users with a confirmaion prompt when removing a user and edit the list of available books. The IDs representing each user should be formated and stored in a specific way, that is described in "System Requirements and Specifications" section. Using IDs as a reference staff members should be able to access the full information about the user including their fullname, current books they hold, their unpaid over-due and history of their book borrowing.

The over-due fees should be capped at the borrowed books value and setted manually by staff and should increase by 10p of the book over-due date.

## System Requirements and Specifications

The system should include two data bases, one that contains the users' information and the other that contains the list of available books. Both data bases should be editable by staff members. When users access the system they should be able to choose the books they need to borrow and pay the fees in case of over-due via adding an online payment method.

The users data base should be capable of storing at least 23000 users (The amount of students currently studyin in University of Greenwich) with their details such as First and Second names, history of borrowed books and payments, account registration date and a user ID stored in a specific way:

    1. First part is composede of the initials of the user
    2. Second part is a randomly generated code of four numbers
    3. Third part is a randomly generated single letter

The book database should be capable of storing at least 50000 books, where each book should have the information about the author, title, cover image, isbn number and synopsis as well as borrowing history, date of publication and date of adding it into the library, current status of availability. The book data base should also allow the multiple copies of the same book to be stored.

The staff interaction with the system should allow them to change the status of the book from being available to being on loan with providing the user ID of the student loaning the book. The staff should also be able to add, edit or delete user details from the users data base and add and delete books from the books data base.

