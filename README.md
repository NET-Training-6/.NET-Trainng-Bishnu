# .NET-Trainng-Bishnu

## Git vs Github

## Git - Version (Source) Control System
    1. Who (User Name), When (Timestamp), What (Add, Edit, Delete)
    1. Alternatives: Svn, Tfs etc

## GitHub
    1. Home for repositories (projects) - our source code


## Git basics
### Setting up user name and email
```
> git config user.email rawal.bishnu@gmail.com
> git config user.name "Bishnu Rawal"
```

```
> git add .
> git commit -m "sensible commit message"
> git push
```
(For first time, authorize popup may appear)

# Assignments
1. Add new random image in your cloned repo and publish that to remote github.  
1. Find if user supplied number is multiple of 3 and 5
1. Ask user to enter height and weight in metric unit and calculate BMI index for that user.
1. Define a class representing an animal with at least 6 fields and a method. Create 5 objects/instances from this class in our entrypoint.
1. Create appropriate data strcuture for following:
    1. Hold names of 10 people and print them to standard console.
    1. Store salaries of 6 people in a variable and print only the largest to console.
1. Print following patterns:
    ```
    #
    ##
    ###
    ####
    #####
    ######
    ```
    ```
    1
    12
    123
    1234
    12345
    123456
    ```
    ```
    666666
    55555
    4444
    333
    22
    1
    ```
1. Think of a real world scenario for following:
    1. Class 1 should has some fields and methods
    2. Class 2 inherits Class 1
    1. Class 3 has some fields on it
    3. Interface 1 have some method definitions
    1. Class 2 and Class 3 implements Interface 1

1. We have a paragraph and do following for the same.
    ```
        var story = @"A Boy was given permission to put his hand into a, \\
            pitcher to get some filberts. But he took such a great fistful \\
            that he could not draw his hand out again. There he stood, unwilling \\
            to give up a single filbert and yet unable to get them all out at once. \\
            Vexed and disappointed he began to cry.";
    ```

    1. Count number of sentences
    1. Count number of words and 
    1. Count number of characters
    1. Count frequencies each characters: aplhabets, numbers and special characters, exclude space, tab and new line.

1. Create list of at least 10 numbers and print in console only the numbers multiple of 3 an 5.
1. Create list of date of births of 8 people. Print those dobs in console oldest first.
1. Given the collection
    ```
    List<string> names = new() { "Bishnu", "Ab", "Prem", "Em", "Sajan", "Naresh", "Arjun", "Prabis" };
    ```
    1. Get all person names with less than 4 characters and convert them to uppercase.
    1. Get initial (first letter) of names which contains "is" in it.
1. Create a class called "Country" with fields "Name", "Area", "Continent" and "GDP". Then create list of 10 countries like:
    ```
    List<Country> countries = new() 
    { 
        new Country 
        { 
            Name = "Nepal",
            Continent = "Asia"
            Area = 17823783.23,
            GDP = 79247984728
        },
        new Country 
        { 
            Name = "USA",
            Continent = "North America"
            Area = 9817823783.23,
            GDP = 9999997823798472
        }
    };
    ```
    And answer following in both method and expression syntax:
    1. Find all asian countries.
    1. Find top 5 poorest countries. (Use OrderBy())
