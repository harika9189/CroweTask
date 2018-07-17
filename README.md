# CroweTask
 1.	The program has 1 current business requirement a write Hello World to the console/screen.
  ===>This is achieved by Main method in Hello World Project 

2.	The program should have an API that is separated from the program logic to eventually support mobile applications, web applications, console applications or windows services.
===>ServiceAPI Project achieves this.

3.	The program should support future enhancements for writing to a database, console application, etc.
===>WriteMode project is used to determine which write mode is selected. By default, it selects Console mode.

    a.	Use common design patterns (inheritance, e.g.) to account for these future concerns.
    ===>Used Abstract Classes, inheritance to achieve that in WriteMode Class    Library project

    b.	Use configuration files or another industry standard mechanism for determining where to write the information to.
    ===>Key is added to determine the write mode in App.config file.

4.	Write unit tests to support the API.
===>ServiceTest Project serves this purpose
