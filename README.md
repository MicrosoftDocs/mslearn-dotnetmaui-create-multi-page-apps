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

### Exercise n°2
The instruction can be found [here](https://learn.microsoft.com/en-us/training/modules/create-multi-page-apps/5-exercise-implement-tab-navigation).

Open the solution at `exercise2/start/Astronomy/Astronomy.sln` and run the application. The application should look like this:
![Exercise 2](img/ex2/author.jpg)

When clicking on the moon button at the top-left corner, the application should display the following:
![Exercise 2](img/ex2/flyout.jpg)

We can now see that the application is using an *Astronomy* page. Opening it should look like this:
![Exercise 2](img/ex2/moon.jpg)

We can see the two tab at the bottom of the screen. Clicking on the "Sunrise" tab should display the following:
![Exercise 2](img/ex2/sunrise.jpg)

Clicking on the "About" page should still display the following:
![Exercise 2](img/ex2/about.jpg)

### Exercise n°3
The instruction can be found [here](https://learn.microsoft.com/en-us/training/modules/create-multi-page-apps/7-exercise-use-tabbed-pages-with-navigation-pages).

Open the solution at `exercise3/start/Astronomy/Astronomy.sln` and run the application. The application should look like this:
![Exercise 3](img/ex3/author.jpg)

When clicking on the moon button at the top-left corner, the application should display the following:
![Exercise 3](img/ex3/flyout.jpg)

We can now see that the application is using an *Astronomy* page. Opening it should look like this:
![Exercise 3](img/ex3/moonphase.jpg)

We can see the three tab at the bottom of the screen. Clicking on the "Sunrise" tab should display the following:
![Exercise 3](img/ex3/sunrise.jpg)

Finally, clicking on the "Bodies" tab should display the following:
![Exercise 3](img/ex3/bodies.jpg)

We can now see 4 buttons with each a celestial body. Clicking on one of them will display information about the body. For example, clicking on the "Earth" button should display the following:
![Exercise 3](img/ex3/earth.jpg)

Hitting the return button of your phone will get you back to the bodies page.

Here are the other pages:
![Exercise 3](img/ex3/moon.jpg)
![Exercise 3](img/ex3/sun.jpg)
![Exercise 3](img/ex3/comet.jpg)

As per the other exercise, the "About" page should still display the following:
![Exercise 3](img/ex3/about.jpg)

## Conclusion
This assignment was a good introduction to the MAUI framework. It was a good way to learn how to use the framework and how to create a multi-page application. The assignment was also a good way to learn how to create a basic interface using the MAUI framework.

I have now learn how to :
- Create an application using the MAUI framework
- Use the flyout menu
- Use the tabbed page
- Root our application in a navigation page