# EpamTraining
Doing homework online course in C #, from the company Epam

Task

Weak 1:


Weak 2:
1. Implement the Figure base class with the abstract Draw () method. Create Square and Rectangle classes (inherited from Figure) which overload the implementation of the Draw () method, which outputs to the console the name of the class in which this method is implemented.
2. Using the previous assignment, add X and Y. readonly properties to the Figure class. Also, to the Figure class, add a parameterized constructor that sets values in these items. Correct the inherited classes to work correctly by calling the base constructor.
3. Using the previous task, change the abstract Draw () method to virtual and implement it the same way as in the Square and Rectangle classes. Make sure that an object of the Figure class can now be initialized and calls to the Draw () method on objects of created classes will cause three different implementations to be called.
4. Using the previous task, render the Draw () method to the IDrawable interface. Create a DrawAll method (params IDrawable [] array) in which to pass objects of created classes and in a loop call the Draw () method for each of them. Make sure that the correct implementations of the Draw () method were called for each class.
