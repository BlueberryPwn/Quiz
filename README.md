# QuizBlazor

## Intro

This is a Blazor WebAssembly application where users can...
- Create/login on accounts
- Create new quizzes
- Add questions to existing quizzes
- Answer the quizzes, receive and see scores
- Visit profile page that shows their quizzes and previously answered quizzes

## Tech Stack

- ASP.NET
- C#
- SQL Server

## Approach

- ASP.NET Core Web API
- Authorization with IdentityUser
- Code first with SQL Server
- Entity Framework Core

## Code

- Controllers: Handles the backend logic. Logic is mostly stored in repositories and injected into the controllers to keep them thin.
- Models: This application utilizes both model and viewmodel classes.
- Repositories: This application follows the repository pattern by storing majority of the logic inside repositories. The repositories are then injected into the controllers and their methods called when needed.

## Database

The database consists of several tables which are Accounts, Games, Highscores and Profiles.

- Games: Stores data related to the game. This is used to show what quizzes a user has answered and what score they got answering the quiz.
- Questions: The questions for each quiz are stored here which includes question options, the answer, URLs for images/videos, if a question is timed or not and more.
- Quizzes: The quizzes are stored here on creation. Includes data related to the Id and title of the quiz as well as the Id of creator of the quiz.