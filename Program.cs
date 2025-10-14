/*
https://www.thecsharpacademy.com/project/53/math-game

Requirements for the Math Game:
- You need to create a Math game containing the 4 basic operations
- The divisions should result on INTEGERS ONLY and dividends should go from 0 to 100. Example: Your app shouldn't present the division 7/2 to the user, since it doesn't result in an integer.
- Users should be presented with a menu to choose an operation
- You should record previous games in a List and there should be an option in the menu for the user to visualize a history of previous games.
- You don't need to record results on a database. Once the program is closed the results will be deleted
*/

using MathGame;

MathGameLogic game = new MathGameLogic();

game.StartGame();

/*
BACKLOG
 - Add levels (easy, medium, hard) with different ranges of numbers
 - Add a timer for each question
 - random game option
 - speedrun 10
 - refactor to DRY principle
*/


/*Intro to Docker
You need to containerize a console app with Docker.
The goal is to demonstrate a working application inside a container. You do NOT need to use external databases, volumes, or advanced Docker features. The Math Game is ideal for this project, since it doesn't contain any dependencies.
You must create a Dockerfile that defines how your application is containerized. Include instructions to restore, build, and run your project.
Your Docker image should be buildable using the 'docker build' command, and the container should be runnable with 'docker run'.
You should include a brief README explaining how to build and run your container. Mention any dependencies or setup steps.
*/