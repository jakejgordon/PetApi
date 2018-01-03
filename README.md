# Assignment Purpose
To do a quick evaluation of your REST API design skills as well as your LINQ skills. If you want to write some unit tests to test your code that is a big bonus as well.

# Assignment Details
You need to expose a brand new REST API that allows users to do the following:
1) Retrieve a list of all Pets with their Owner's name (list of results with petId, petName, ownerName)
2) Save a Pet -- the Name is the only required field
3) Retrieve a specific pet (as specified by its Id)

### The main considerations in the solution are:
1) Can you provide some very basic API documentation in this readme.md that would be workable for 3rd party developers to use?
2) How does your API design look?
2) Can you write the actual code to make the API work? It's fine if you write all of the logic in the controller(s); it's up to you if you want to split it out for any reason.
3) (_OPTIONAL_) How do you do unit testing?

### You do NOT need to worry about any of the following:
* Security/authentication/authorization
* Wiring up an IoC container/dependency injection framework.
* Error logging

### What's Already Been Provided
This project is a brand new WebAPI 2 project with all of the default stuff automagically created. I created a new folder called "DataAccess" which has [a class called DataAccessGodObject.cs](https://github.com/jakejgordon/PetApi/blob/master/PetApi/DataAccess/DataAccessGodObject.cs). This (fairly silly) class has everything you need to retrieve and save Pets.

## INSERT BASIC API DOCUMENTATION HERE
_Please just add your basic API documentation down here_
