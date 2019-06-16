# PlayingCards

This is an application create for fun and in the intention to learn VSCode for MacOSX.
Main features:
```
- Create deck of cards
- Shuffle
- Reset
- Print
```

## Folder structure
```
PlayingCards/PlayingCards.sln
           |
           |
           +----- PlayingCards.App/PlayingCards.App.csproj
           |
           +----- PlayingCards.Business/PlayingCards.Business.csproj
           |
           +----- PlayingCards.Business.Tests/PlayingCards.Business.Tests.csproj

```
The commands shown in the next section should be executed in the solution folder, once relative path matters.

## Basic commands

**To build the solution:**
```
$ dotnet build
```

**To run the project:**
```
$ dotnet run -p PlayingCards.App/PlayingCards.App.csproj
```

**To run the unit tests:**
```
$ dotnet test
```


## Solution/Project commands

**To create a new solution:**
```
$ dotnet new sln
```

**To create a new project(s):**
```
$ dotnet new console [-n PROJECT_NAME]
$ dotnet new classlib [-n PROJECT_NAME]
$ dotnet new mstest [-n PROJECT_NAME]
```
If you omit PROJECT_NAME it will be given the folder name.

**To add a project to the solution:**
```
$ dotnet sln add PlayingCards.App/PlayingCards.App.csproj
$ dotnet sln add PlayingCards.Business/PlayingCards.Business.csproj
$ dotnet sln add PlayingCards.Business.Tests/PlayingCards.Business.Tests.csproj
```

**To add reference to another project:**
```
$ dotnet add PlayingCards.Business.Tests/PlayingCards.Business.Tests.csproj reference PlayingCards.Business/PlayingCards.Business.csproj
```



