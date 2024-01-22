# Phase 2 - System Modelling Design  
  
  ## Contents
- [Phase 2 - System Modelling Design](#phase-2---system-modelling-design)
  - [Contents](#contents)
  - [Introduction](#introduction)
  - [Use Case Diagram](#use-case-diagram)
  - [Table Discriptions](#table-discriptions)
  - [Appendix](#appendix)
- [Use Case diagram](#use-case-diagram-1)
  - [References and Acknowledgements](#references-and-acknowledgements)

## Introduction
The System Modelling and design Phase is an important step in the software development life cycle since it is at this stage that the conceptualised system beings to take shape through comprehensive modelling and design activities.. The goal is to produce a blueprint that will guide the development team in the systems implementation. This report provides a full summary as the modelling and design tasks completed as well as a set of important diagrams that are critical in representing and communicating the systems structure and operation.

**Diagrams and their purpose:**
1.	***Use case Diagrams:***
Use case diagrams represent the relationships between system elements and external actors, emphasising the systems functionality from the user’s point of view. 
    
2.	***Sequence diagram:***
They are used to highlight the dynamic features of a system by illustrating the chronological sequence of interactions between distinct systems components.

3.	***Class diagram:***
This diagram depicts the system’s static structure, emphasising the interaction and dependencies between classes, objects, and their characteristics.

4.	***Activity diagrams:*** 
They are used to show the flow and control of a system by depicting the sequence of activities and decision points. They are especially effective for modelling business processes and workflows.

5.	***State charts diagrams:***
This diagram depicts the various states that an item or system might enter in response to event.

In summary, the accompanying diagrams give a visual depiction of the systems structure, behaviour, and relationships, providing a comprehensive picture that assists both the development team and stakeholders to comprehend and contributing to the systems effective realisation.
## Use Case Diagram
A use case diagram is a visual representation of how multiple actors (users or external systems) interact with a system or software application. It aids in illustrating the many ways in which users or external entities interact with the system to achieve certain objectives or tasks.

**Key components of a use case diagram are:**
1.	***Actors:*** Actors are entities who interact with the system. They may be users, systems of their own, or external entities. In the diagram, performers are show as stick figures or other forms.
2.	***Use cases:*** use cases describe particularly features or actions that the system does to suit the actor’s demand. They are often depicted as ovals and linked to the actors by lines.
3.	***Relationships:*** Lines link actors and use cases. These lines represent the interactions and interdependence of the actors and the system.
4.	***System boundaries:*** The system boundary is a box that contains all the use case ad actors, indicating the scoop of the system being modelled.

Use case diagrams are useful for collecting and visualising a system needs from the perspective of its users. They are frequently used in the early phases of software development to interact with stakeholders’ and offer a high-level overview of the systems capabilities. Use case are frequently used as the foundation for more extensive models and data throughout the software creation procedure.
 ## Table Discriptions 
 <div align=center>
 
 **Table: Register Usecase**
 
| Unit | Depiction |
|------|------| 
|Actors| Students (new Library member)
|Description| Allow new library member to register with the library system.
|Data| Personal information (Title, Full name, Phone number, Email address, Password, Street address, Date of birth, Gender, Notifications, 2-step-varification (authentication))
|Stimulus| User command issued by a new library member.
|Response| Failed to create an account or successfully account created.
|Comments| The System must have appropriate security permissions to access the users data.

**Table: Login Usecase**
 
| Unit | Depiction |
|------|------| 
|Actors| Students (Library member), Librarian (Staff)
|Description| Allows students and staff to securely log into the system. The system authenticates users using their login information (username and password). Users must hae valid and approved profiles to access the sysem. After logging in, users may search for books.
|Data| Users ability (username and password).
|Stimulus| User command issued by a librarian or staff.
|Response| Authentication failed or Successful login.
|Comments| Users have to have legitimate login information and the necessary permissions. To secure user credentials, the system should utilise security techniques like encoding.

**Table: My Account Usecase**
 
| Unit | Depiction |
|------|------| 
|Actors| Student (User)
|Description| Members may check their accounts status, whih includes personal information. checkouts, book holdings, and any penalties incurred. Members can examine their account information to ensure openness. Members may also view payemnt history, accrued penalties, and current fines/blocks in the fine area
|Data| Personal information, Holds and Fines.
|Stimulus| User command issued by a Student (library member)
|Response| Showing Account Details.
|Comments| The System must have appropriate security permissions to access the users data.

**Table: Manage Inventry**
| Unit | Depiction |
|------|------| 
|Actors|  Librarian (Staff)
|Description| Allows the staff member to handle the library's books. This entails introducing new books to the brochure, removing old ones, and updating the catalog's information. The librarian can keep accurate and up-to-date records of all library resources.
|Data| Management of membership, Book information and catalog details.
|Stimulus| User command issued by a librarian or staff.
|Response| Confirmation of book management.
|Comments| Requires permissions that are required along with access for reservation data. The system may iclude funtionality for batch processing, classification, and monitoring of book accessibility.

**Table: Manage Members**
| Unit | Depiction |
|------|------| 
|Actors|  Librarian (Staff)
|Description| Enables the librarian information. This involves adding new members to the system, updating member data, and deleting members as needed. The librarian keeps member records current and up to date.
|Data| Membe details, User information.
|Stimulus| User command issued by a librarian or staff.
|Response| Confirmation of member management actions.
|Comments| Requires correct authorisation and access to user data. The systems may include tools for recording member borrowing history, controlling user roles, and providing notifications to members.

**Table: Return Books**
| Unit | Depiction |
|------|------| 
|Actors|  Librarian (Staff)
|Description| The librarian receives books that library patrons have returned. Each returned book is either scanned or manually entered into the system by the librarian. The system refreshes the catalougue to show that the returned products are now accessible. If a book is returned late, the System generates an overdue punishment based on predetermined guidlines.
|Data| Membe details, book information.
|Stimulus| User command issued by a librarian or staff.
|Response| Confirmation of successful book.
|Comments| Late returns may results in fines, which must be computed according to the return status. The systems should manage fine computations, alerts, and modify the book's current status .

</div>

## Appendix
# Use Case diagram
![Student Usecase diagram](https://www.plantuml.com/plantuml/png/XP8nxzem4CLtVuhhVme3gJfqgH02XgeCbL3fo7ArZyJ2kKFdSodVlWbD9KjGDKkaztu_woNo9XkgbI6vH6S34z3OzGOXAdcBmkwTzJGG3AZPvKlaAoeEWDv4ZtPF17YZB0CvzyZWxMWb4DiRO8QIITtuJ6zOBfVGVACkPYDTL5cIBd8TVBq3UY-5RU7SNCEgRQ7P5kk9BNgSnftuCyP4uSJVTLGwdBXFi5e1_VAf18BrsltVcS_UyqzCCJn6Cmxq_e0vtqJ3YpFdJMsxXkP8gBxVYLncCF9hS2UgSeD_a7LRup_60CwYKAucyE4Z1BpdFtwbr_zij9i3QHR617iUtU7nwOidolVaBr8iFrTV98KNyJaoFSVr-B6TgQdmHPNOCinYLMszrnAv-rkv3N6Ohk9l)
![Librarian Usecase diagram](https://www.plantuml.com/plantuml/png/bP91Qnj138Nl-XLgJkk3tNin9cbA8T10ITgRBygETdV8ZCPeD4dzxxjhZw7k9WJlPK5wtqDwe-jif5PYWC2TeILKtm-6pYktvfF09niuCaRI3FdPouwK8b9hIHzj7nZfbNEA30278bxzy4zAwacka39cewu3EFnmkLnY4rBlPO7_bkv9gEUjtCaBY-b-yLRpdkCJQpxhFR0L5VoQqlFOW9FtUhLgReeDBEPRclROodVoWTrMVkaUgQTHzWNNQ-G_RIYESRE1Zv3gZCqu9WNli6HMeSYVVrBEhqdT0cUUTQBLQeFD8vEsmpHi5Nev2H5WbaAbRfp38_C_z2xom36zyANKxvqZUvU2sKECK7ENSs6CnyhWTzZI6CFRskfVIrlvnaO-7DxjjEFv9BTaDEPNU1ONr1KlWwhaCcZw4CukhPx1xK3QCuR9G8_jpWlFZm2kMLo9uIy0)

## References and Acknowledgements
1. PlantUML.com. (n.d.). Use case Diagram syntax and features. [online] Available at: https://plantuml.com/use-case-diagram.
2. creately.com. (n.d.). Library Management System | Creately. [online] Available at: https://creately.com/diagram/example/hszw2rmn7/library-management-system.
