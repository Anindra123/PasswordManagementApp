# PasswordManagementApp
A password management application made with winforms and C# to better store and handle passwords.This application will allows user to store their passwords locally on their machine so they can use unique passwords for different websites.



## Installation instruction
Currently there is no way to install this application yet.


## RoadMap

Things i want to accomplish by making this project
- ✔️ Implement a 3 tier architecture
- ⚒️ Design the UI of each forms
    - ✔️ Form design
    - ⚙️ Form navigation
- ⚒️ Form Validation
     - ✔️ StorePassForm validation
     - ⚒️ UpdatePassForm validation
     - ✔️ SignInForm validation
     - ✔️ SignUpForm validation
     - UpdateMasterAccFrom validation
- ✔️ Create database
- ✔️ Create table for storing password
- ✔️ Create table for storing master account info
- ✔️ Allow user to create a master account
- ✔️ Allow user to sign in to their master account
- ✔️ Allow user to store password
- ✔️ Allow user to view password
- ⚒️ Allow user to update password
- ✔️ Allow user to delete password
- Release MVP


## Contributing
I highly encourage anyone finding about this project to contribute to it. You can contribute 
by creating a issue or creating a pull request by :

- forking this repo
- cloning the repo
- creating a branch using the command `git checkout -b branchname`
- making your changes and push it on your branch with `git push -u origin branchname`
- creating a pull request on github

## Ways to contribute
There are many things that you can help me out with.

Some of them are : 
- Give feedback or update my 3 tier architecture implementation
- Check for vulnerablities and post it on issue
- Check for code improvements and create a pull request after updating it
- UI update suggestion
- Code comments
- Writing tests

Currently my application is designed like this :
- All forms on ApplicationLayer
- Datamodel and some encryption logic on BusinessLogicLayer
- All sqlite and helper class for connecting to the database on the DataAcessLayer

## Dependencies & Libraries
- .NET framework v4.8
- [Dapper](https://www.nuget.org/packages/Dapper/)
- [Easy Crypto](https://www.nuget.org/packages/EasyCrypto/)
- [System.Data.SQLite.Core](https://www.nuget.org/packages/System.Data.SQLite.Core/)

## Extra Info
This project is my contribution for the C# challege by IAmTimCorey 