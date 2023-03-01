### Hugo FRANGIAMONE
#### 2023-03-01
# Framework-based Programming - Assignment 1
## Introduction
This repo contains the code for the first assignment of the course Framework-based Programming at the Institut Teknologi Sepuluh Nopember (ITS) Surabaya, Indonesia. The assignment is to create a simple MAUI application that displays information about the solar system. The application is to be written in C# using the MAUI framework.

## The Application
### Exercise n°1
The instruction can be found [here](https://learn.microsoft.com/en-us/training/modules/create-multi-page-apps/3-exercise-implement-flyout-navigation).

Open the solution at `exercise1/start/Astronomy/Astronomy.sln` and run the application. The application should look like this:
![Exercise 1](img/ex1/author.jpg)

When clicking on the moon button at the top-left corner, the application should display the following:
![Exercise 1](img/ex1/flyout.jpg)

We can now see that the application is using a flyout menu to display all the pages available. The flyout menu is a component of the MAUI framework that can be used to display information in a side menu. The flyout menu is displayed when the user clicks on the button at the top-left corner of the application. The flyout menu can be closed by clicking on the button again or by clicking outside of the menu.

Upon clicking on the "moon phase" button, the application should display the following:
![Exercise 1](img/ex1/moonphase.jpg)

Clicking instead on the "Sunrise" or "About" button should display one of the following:
![Exercise 1](img/ex1/sunrise.jpg)
![Exercise 1](img/ex1/about.jpg)