# NameSorterDemo

This assessment project demonstrates a name-sorter software written in C# using .Net Core framework.

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes. See deployment for notes on how to deploy the project on a live system.

### Prerequisites

You can download or clone the project using git into your local repository.

```
$ git clone https://github.com/GhazalK/NameSorterDemo.git
```

### Installing

The project can be run using dotnet CLI Tool. 
In order to do so, it is required to change the directory to the project main folder and 
from the project directory build the project using the following command.

```
dotnet build
```

After building the project the following command would run the project through the CLI.

```
dotnet run --project name-sorter ./unsorted-names-list.txt
```

After a successful build and run, the names will appear on the screen, and a text file will be 
created which contains the sorted names.

## Running the tests

As for the assessment requirements, unit testing is conducted. In order to run the test true 
the CLI the following command should be used. 


```
dotnet test
```

### And coding style 

SOLID design principle is used to structure the code. 



