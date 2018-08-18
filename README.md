# About the Program

This is an about 12 weeks course, held by Pentalog Brasov, they guided us through 3 modules: starting with best practices of C# and extending it by developing a web application.

## Module01Week01

• Create a “guess the number” game
• You must generate a random number between 0 and 100 (the target number)
• You ask the user to guess the number, by entering a number in the console
• If the user guesses correctly, the game ends
• If the user’s guess was smaller than the target number, tell the user that the number
was too small
• If the user’s guess was larger than the target number, tell the user that the number
was too big
• Allow the user to guess again until he guesses correctly

## Module01Week02

1. Read from the console 3 integers representing the year, month and day of
a person and a letter (M/F) representing the gender of the person
• Convert the 3 integers and create a DateTime for the birthdate
• Compute the age of the person, based on the birthdate
• Create an enum for the genders (Female, Male)
• Using the input for gender, set the value of a nullable variable to one of the enum
values or to null (if the user wrote an invalid character, other than M or F)
• If there’s a valid Gender, then display a message if the person is retired or at what age
he/she will retire (Female at 63, Male at 65)
2. Choose 7 methods from the string build-in functionalities and create some
examples with them

## Module01Week03

Create the classes from the following requirements:
• Create an application that allows users to post messages on a common board.
• A person can create an account using his email and personal information like first
name, last name, birthdate.
• Each post should have an author
• The board should display all the posts, created by all the users, chronologically, in
descending order (latest first)
Notes:
• No implementation for methods, we will continue next week with that
• Create 2 projects in the same solution: a class library and a console app

## Module01Week04

Create an console app from the following requirements:
• Create an application that allows users to post messages on a common board.
• A person can create an account using his email and personal information like first
name, last name, birthdate.
• Each post should have an author
• The board should display all the posts, created by all the users, chronologically, in
descending order (latest first)
Notes:
• Implement the entire functionality for this application, similar to the course app
• Create 2 projects in the same solution: a class library and a console app
• Sort

## Module01Week05

•Extend the homework you did last week
•In the message board, implement an indexer that allows us to get the posts
using an index, like this:
• Post p = board[0];
•In the message board, add an event that fires when a post is added.
• The board should fire the event, and the console app should subscribe to the
event.
• The console app should write a message to the console each time a post is
added to the board.

## Module02Week01

•Load list of names from file with name people.txt.
•Add remove one of the name and add 2 new names to the list.
•Save modified list in the new file.
•In case file not exist throw and catch exception. When exception is catch
create missing file.
•If one of the name is invalid then display message and don’t add name to the
list. Valid names contains only letters.

## Module02Week03

• Display all the persons borne between 1985 and 1995, ordered by the number of vowels from their full name.
• Make a list of User objects from a list of People objects, where username is equals to $"{FirstName}{LastName}{BirthDate.ToString("yy")}".

## Module03Week01

• Create a new ASP.NET MVC 5 application with UserAuthentication
• In the new app, add your entity (Post/Message) in the models folder
The Post class should have: Id (int), UserId(int), TimeOfPosting(DateTime), Message(string), PostType(Enum with 2 values: Text and Photo), IsSticky(bool), Priority (int – optional with values ranging from 1 to 5)
• Create a Controller - PostsController with the following actions:
	-Index Action (Create also a view for it with the List template)
	-Details Action (Create also a view for it with the Details template)		
	-Create Action (With the [HttpGet] attribute, create also a view for it with the 	Create template)
	-Create Action (With the [HttpPost] attribute)
		-The create POST action will receive the Post class as a parameter
		-If the post Message is null or empty return 404
		-If the post Message is not null or empty return the Details view with the 		post object as a parameter

## Module03Week02

• Add the following actions to the Controller:
	-Edit Action (Both the [HttpGet] and [HttpPost] actions – you can add other field 	validations if you want)
	-Delete Action ( can be done directly with [HttpGet])
• Use the ViewBag to send the current DateTime from the controller to the Post Index view
• Create a partial view containing the instructions for creating a post (a text explaining that the post must be no longer than 255 characters, etc) and include it in the Create and in the Edit views.
• Modify the layout page: in the menubar add an URL to the Index action from your controller. Also in the layout add your name in the footer section of the application.

## Module03Week03

• Create a Category model and generate a controller for it.
• Modify the create POST action to set the current user on the Post object when creating one (before adding it to the database, make sure you have in the Post class, the string ApplicationUserId, and the virtual ApplicationUser properties, to let EntityFramework know that you want the post to be linked with the ApplicationUser class). Add also the link with Category. Then generate the controller.
• Add the [Authorize] and [AllowAnonymous] accordingly on the controllers. Add links to your pages on the application menu bar.
• Optional: Be creative :) use Bootstrap to make your pages more attractive.

## Module03Week04

• Create a simple String calculator with a method int Add(string numbers)

    -The method can take 0, 1 or 2 numbers, and will return their sum (for an empty string 	it will return 0) for example “” or “1” or “1,2”
    -Start with the simplest test case of an empty string and move to 1 and two numbers
    -Remember to solve things as simply as possible so that you force yourself to write 	tests you did not think about
    -Remember to refactor after each passing test

• Allow the Add method to handle an unknown amount of numbers
• Allow the Add method to handle new lines between numbers (instead of commas).

    -the following input is ok:  “1\n2,3”  (will equal 6)
    -the following input is NOT ok:  “1,\n” (not need to prove it - just clarifying)

• Support different delimiters
    -to change a delimiter, the beginning of the string will contain a separate line that 	looks like this:   “//[delimiter]\n[numbers…]” for example “//;\n1;2” should 	return three where the default delimiter is ‘;’ .
    -the first line is optional. all existing scenarios should still be supported

• Calling Add with a negative number will throw an exception “negatives not allowed” - and the negative that was passed.if there are multiple negatives, show all of them in the exception message




