# Over-Analysis-App

A MVC application which uses Entity framework code-first approach to connect a database and keeps a record of delivery of ball by bowlers in a cricket match in an sql server database.

An application which provides an analysis of bowling for various bowlers in the team so that decision can be made on team selections for future cricket matches. Application will keep a record of each ball delivered in every over of the match and based on that it will provide an overall analysis of the bowler's performance in the match.

Creating an asp.net mvc application to store and retrieve data from sql server database using entity framework code first approach. 

Tech Stack:
C#: For developing .NET application 
SQL Server: relational database for storing data 
Asp.NET MVC: Light weight framework for developing server-side application which provides separation of concerns for developing applications using asp.net 
Entity framework: Provides an ORM to map a relational model with the object oriented model.

Steps:
User launches the application 
Add over details page will be displayed to the user
User will fill in the over details and click the save button
Application will validate the information and save the details in the database 
If there is any validation error, page will list out all the validation errors
If over details are saved in the database an acknowledgement is displayed to the user on the page 
If there is any exception during the save operation then an appropriate error page will be displayed to the user. 
After launching the application user will click on “View Report” link which will redirect to view 
report page which will be used for display the over details for a particular bowler 
User will fill up the form and click search button which will search the database for the over 
details for the given bowler for specified delivery and display the bowler details.
If there are no details present for the given search criteria page should also display an 
appropriate message
