<table align="center" border="0">
    <tr>
        <td><p align="center"><img src="ApplicationLayer/Resources/FastPass-logos.jpeg" width="80" height="80"/></p>
        </td>
        <td>
            <span style="font-size:40px">FastPass</span>
        </td>
    </tr>
</table>
A free and open source password management application made with winforms and C# for windows to better store and handle passwords.This application will allows user to store their passwords locally on their machine so they can use unique passwords for different websites.
<br>
<br>


## Installation instruction
Currently there is no way to install this application yet.


## RoadMap


<details>
 <summary>Pre-mvp development</summary>

 - ✔️ Implement a 3 tier architecture
 - ✔️ Design the UI of each forms
     - ✔️ Form design
     - ✔️ Form navigation
- ✔️ Form Validation
     - ✔️ StorePassForm validation
     - ✔️ UpdatePassForm validation
     - ✔️ SignInForm validation
     - ✔️ SignUpForm validation
     - ✔️ UpdateMasterAccFrom validation
- ✔️ Create database
- ✔️ Create table for storing password
- ✔️ Create table for storing master account info
- ✔️ Allow user to create a master account
- ✔️ Allow user to sign in to their master account
- ✔️ Allow user to store password
- ✔️ Allow user to view password
- ✔️ Allow user to update password
- ✔️ Allow user to delete password
- Release MVP

⚡ Extra features added :
- Forgot password request with email verification
- Update user account (only thier first name and last name)
- View user account info

</details>


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
- Helper class to connect to database and some encryption logic on BusinessLogicLayer
- Datamodel and some rest classes and inteface to commucating with database on the DataAcessLayer

## Dependencies & Libraries
- .NET framework v4.8
- [Dapper](https://www.nuget.org/packages/Dapper/)
- [Easy Crypto](https://www.nuget.org/packages/EasyCrypto/)
- [System.Data.SQLite.Core](https://www.nuget.org/packages/System.Data.SQLite.Core/)
- [FluentEmail](https://www.nuget.org/packages/FluentEmail.Smtp/)

## Extra Info
This project was my contribution for the C# challege by IAmTimCorey 
