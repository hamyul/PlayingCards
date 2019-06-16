# PlayingCards

## Folder structure
PlayingCards/PlayingCards.sln
           |
           |
           +----- PlayingCards/PlayingCards.csproj
           |
           +----- PlayingCards.Tests/PlayingCards.Tests.csproj

The commands shown in the next section should be executed in the solution folder, once relative path matters.

## Basic commands

To build the solution:
```
$ dotnet build
```

To run the project:
```
$ dotnet run PlayingCards/PlayingCards.csproj
```

To run the unit tests:
```
$ dotnet test
```

## Solution/Project commands
To create a new solution:
```
$ dotnet new sln
```

To create a new project(s):
```
$ dotnet new console [-n PROJECT_NAME]
$ dotnet new classlib [-n PROJECT_NAME]
$ dotnet new mstest [-n PROJECT_NAME]
```
If you omit PROJECT_NAME it will be given the folder name.

To add reference to another project:
```
$ dotnet add PlayingCards.Tests/PlayingCards.Tests.csproj reference PlayingCards/PlayingCards.csproj
```



