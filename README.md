# Phase 1 - Requirements Engineering
## Contents
- [Phase 1 - Requirements Engineering](#phase-1---requirements-engineering)
  - [Contents](#contents)
  - [Table](#table)
  - [Software Process Model](#software-process-model)
    - [What is an Incremental Model](#what-is-an-incremental-model)
    - [Phases of Incremental Models](#phases-of-incremental-models)
    - [Using an Incremental Model](#using-an-incremental-model)
    - [Justification For Model Choice](#justification-for-model-choice)
  - [References and Acknowledgements](#references-and-acknowledgements)
     
  
## Table
| Name | Assignment |
|-----|-----| 
|[Denis](https://github.com/wheissmd) | Introduction // System Requirement
|[Wojciech](https://github.com/flock-of-jays)| Kanban // Gantt Chart
|[Maisha](https://github.com/maishkhan)| Content // Table // Software Processes Model // Reference
|[Reshmaa](http://github.com/reshmaa2005)| Glossary // Risk and Risk Planning
|[Sanjita](http://github.com/SanjiGre99)| User Requirement // Create Authors

## Software Process Model

A software process model is a structured representation of the software development process. It describes the sequential and parallel activities that take place throughout the software development life cycle (SDLC). The process model serves as a roadmap for planning, stucturing, and controlling the process of developing an information system.

**1. Waterfall Model**

* Sequential and linear model.
* Progresses through defined phases such as requirement, design, implementation, testing, deployment, and maintenance.
  
**2. Agile Model**

* Emphasixes Fleibility, collaboration, and customer feedback.
* Incorporates risk assessment and adjusts the process as needed based on feedback and evalutio.

**3. Incremental Model**

* Breaks the system into small, maangeable parts or increments. 
* Each increment represents a portion of the system's funtionality and is developed separately.

**4. DevOps Model**

* Integrates development and operations to improve collaboration and productivity.
* Aims to automate the software delivery process and enhance communication between development and operations teams.

The choice of a software process model depends on various factors, including project requirments, organizational goals, and the nature of the software being developed. Different models have theirstrengths and weaknesses, and organizations may choose or tailor a model based on their specific needs and constraints. For this projects we have chosen the incremental model for the Library System.

### What is an Incremental Model 

The incremental model is a software paradigm for growth for big and complicated systems. It is built on the concept of adding new features, or increments, to an existing system rather than starting from scratch. The incremental model divides or breaks down software requirements into multiple stand-alone modules or increments in the SDLC (Softwre development life cycle). Once the moduloes have been partitioned, incremental development is carried out in steps, comprising all analysis, design, implementation, necessary testing or varification, and maintenance. The functionality of each stage is built on the fuctionality of the preceding stage, and this process is repeated until the software is complete.

The incremental model requires the development team to complete each incremental build as rapidly as feasible. The objects is to gradually offer a ductional product. Regular releases are part of the process, with each release reflecting an increase in functionality and quality.

![Figure of Incremental model](https://lh6.googleusercontent.com/ymTiT6ebNQFPbGxIRYioFD1SwBOw7S_NrBfkLloBmhEO5vvx4m_GiskiT5jEYAs7NeMHB2hlVPFz3K00L1xwWtxE3n_ThWS2dT6tU-TEr_WTkk58dC-3HBgceJXjGgEC4NYqpglu-bYAXvME7lt-hpc)

### Phases of Incremental Models 

The phases of incremental models in the (SDLC) typically follow a pattern where the development processe is divided into smaller increments or modules. each increment goes through a set of common phases. While the specific names of the phases may very slightly based on the model and methodology being used, a general representation includes the following phases: 

***1. Planning:***
  
  * Define the overall project scope, objectives, and requirements.
  * identify the increments or modules that will be deveoped.
  * Plan the Schedule and resources for each increment.

***2. Requirements Analysis:***

* Gather and analyze the requirement for the specific increment.
*  Define the features and fuctionality that will be implemented in the current phase.

***3. Design:***

* Create a high-level design for the entire system, focusing on the features to be implemenred in the current increment.
* Break down the design into smaller components or modules.

***4. Implementation:***

* Develop the code for the features identified in the design phase.
* Coding is focused on the specific increment being worked on.

***5. Testing:***

* Conduct testing on the increment to ensure that the implemented features meet the specified requirements.
* Identify and fix any defects or issues found during testing.

***6. Integration:***

* Integration the current increment with previously developed increments.
* Varify that the integrated system functions as expected and that there are no conflicts between increments.

***7. Deployment:***

* Release the current increment to end-users or stakeholders for evalution.
* Gather feedback on the implemented features.

***8. Feedback and Evalution:***

* Collect feedack from users and stakeholders.
* Evalute the success of the implemented features.
* Use feedback to make improvements and adjustments for the next increment.

These phases may vary in terminology or specific activities depending on the chosen incremental model. Additionally, some incremental models may incorperate a feedback loop where each increment informs the planning and development of subsequent increments. The key is that the development process is broken down into manageable parts, allowing for flexibility, early deliveries, and adaptation to changing requirements.

### Using an Incremental Model

The incremental Model in software development offers several benifits that contribute to a more flexible and adaptive approach to building software. Some of the additional of using an incremental model include:

**1. Reduced Risk of Project Failure:**

* The incremental model allows for the detection and correction of errors and issues at an early stage, reducing the risk of major project failure.
* Early identification of problems makes it easier to address and mitigate potential risks.

**2. Higher Visibility and Control**

* Projects progress is more visible and measurable with the completion of each increment.
* This provides betetr control over the development process and allows for early iddentification and resolution of issues.

**3. Easier Integration and testing:**

* Incremental development simplifies integration and testing since eacfh increment is a funtional subset of the complete system.
* Integration and testing efforts are distributed over time rather than being concentrated at the end of the development process.

**4. Better Resource Allocation:**

* Resources can be allocated incrementally based on the current priorities and requirements.
* Teams can be assigned to work on specific increments, optimizing resource utilization.

**5. Enhance Team Collaboration:**

* Communication and coordination are streamlined, promoting a collaborative development environment.
* Teans can collaborate more effectively as they work on smaller, well-defined tasks.

**Pros of Incremental Model:**

1. Frequent User Feedback: Continuous feedback from users allows for the refinement of requirements and ensures that the final product aligns with user expectations.
2. Early Delivery of Partial Functionality: Users get to see and use of the system early in the development process, providing tangible benefits sooner
3. Higher Stakeholder Confidence: Regular delivery of increments builds stakeholder confidence as they see continuous progress and have oppurtunities to provide input.
4. Meeting Goals: Once the requirements are mapped out, all software goalsnand objectives can be sarisfied completely through incremental development.

**Cons of Incremental Model:**

1. **Potential for Overlapping Features:** Without proper planning, there may be a risk of overlapping features between increments, leading to redundancy.
2. **Complexity in tracking:** Tracking and managing the progress of multiple increments can become complex, especially in large projects.
3. **Mangement Overhead:** Managing multiple increments may increase projects management overhead, requiring careful planning and coordination.
4. **Possibility for Incomplete Suystem Integration:** If not managed properly, there is a risk of incomplete system integration, leading to issues when integrating all increments.
  

### Justification For Model Choice

The Incremental Model is a suitable choice for developing a library system due to its ability to involve users early in the development process and gather continuous feedback. Libraries often have diverse user needs, and incremental development allows for the phase implementation of various modules, such as cataloging, circulation, and user management. This approach aligns well with the evolving requirements of libraries, providing flexibility to adapt to changing technologies and services. Additionally, the model aids in risk management by accuracy and reliability of data in a library system. For libraries with critical operational features, the Incremental model allows for a faster time-to-market, enalbling the use of essential funtionalities without waiting for the entire system to be completed. Resource optimization is facilitated by allocating resources based on feature priority, and the model support smoother intregation with existing systems. The incremental approach also allows for phased training and adoption, easing the transition for library staff and users. Effective project management and communication are essential for the successful implementation of the incremental model in the development of a library system.

In conclusion, while the incremental model offers benefits such as early delivery, user feedback, and flexibility, it requires careful planning and management to mitigate itspotential drawbacks. The suitability of this model depends on the specific characteristics and requirements of the software development project.



## References and Acknowledgements
1. Software process model.[Online] Available at:  https://www.educative.io/blog/software-process-model-types


2. User requirements. [Online] Available at: https://cds.cern.ch/record/383258/files/p123.pdf  

3. System requirements. [Online] Available at: https://www.tutorialspoint.com/software_engineering/software_requirements.htm

4. Kanban. [Online] Available at: https://www.atlassian.com/agile/kanban 

5. Defination of Gantt chart. [Online] Available at: https://www.gantt.com/
6. Gantt Chart. [Online] Available at: https://mermaid.js.org/syntax/gantt.html
7. System Malfunction: 
   
   (Reference: Gary Stoneburner, Alice Goguen, and Alexis Feringa, Computer Security Division Information Technology Laboratory National Institute of Standards and Technology Gaithersburg, MD 20899-8930, July 2002, Reference: [Online] Available at: https://www.hhs.gov/sites/default/files/ocr/privacy/hipaa/administrative/securityrule/nist800-30.pdf )  

8. Inadequate User Training: 
   
   Reference:  Ilia Sotnikov ,Published: August 2, 2018. [Online] Available at: https://blog.netwrix.com/2018/08/02/how-to-create-an-effective-information-security-risk-management-program 

9. Security Breaches

    U.S. Department of Commerce Wilbur L. Ross, Jr., Secretary. [Online] Available at: https://nvlpubs.nist.gov/nistpubs/SpecialPublications/NIST.SP.800-37r2.pdf 

10. Incremental Model. [Online] Available at: https://www.plutora.com/blog/incremental-model-what-and-how-to-implement-it#:~:text=The%20incremental%20model%20is%20an,scope%2C%20objectives%2C%20and%20constraints.