# EpamTraining
Doing homework online course in C #, from the company Epam

All Task:
Weak 1:
1. Without using System.Math to implement the Rectangle class with methods that allow you to calculate the perimeter and rectangle forgiveness. The coordinates of the left upper and right lower corner are passed by parameters to the constructor of the class Rectangle.
2. Implement task 1 using auto-implemented properties instead of methods.
3. Without using System.Math, implement the Circle class with methods that allow you to calculate the length of a circle and the simplest circle. The radius is passed by a parameter to the appropriate method. The counting constants must be in the Circle class.
4. Implement tasks 1 and 3 using static classes. Point coordinates for the Rectangle class with parameters in the appropriate methods.
5. Реалізувати клас ComplexNumber. Перегрузити операції множення та ділення для комплексних чисел. Розділити створений клас на логічні регіони (#region).

The results are presented in the project PartialTask1

Weak 2:
1. Implement the Figure base class with the abstract Draw () method. Create Square and Rectangle classes (inherited from Figure) which overload the implementation of the Draw () method, which outputs to the console the name of the class in which this method is implemented.
2. Using the previous assignment, add X and Y. readonly properties to the Figure class. Also, to the Figure class, add a parameterized constructor that sets values in these items. Correct the inherited classes to work correctly by calling the base constructor.
3. Using the previous task, change the abstract Draw () method to virtual and implement it the same way as in the Square and Rectangle classes. Make sure that an object of the Figure class can now be initialized and calls to the Draw () method on objects of created classes will cause three different implementations to be called.
4. Using the previous task, render the Draw () method to the IDrawable interface. Create a DrawAll method (params IDrawable [] array) in which to pass objects of created classes and in a loop call the Draw () method for each of them. Make sure that the correct implementations of the Draw () method were called for each class.

The results are presented in the project PartialTask2

Weak 3:

1.Create a list that contains several people (> 5). Each person must have several numbers (> 2). Display the name and age of each created person on the console.
2.Using the AddRange method, add two more people to the created list. Output all numbers to the console (without using LINQ).
3.Create a list of randomly generated elements of type string (n> 100, length of tape 4, all characters in uppercase). Remove all duplicate elements starting with 'Z' in descending order (z-a). Display the number of items in the list before and after the transformations. Create DisplayPage method (int pageNumber) when you call the corresponding page of the updated list (the number of elements on the page is constant: 5). Implement the program so that the page number to be output is read from the console. If the entered ribbon is not a number then terminate the program (without using LINQ).

The results are presented in the project PartialTask3
