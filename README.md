# A variable is a labeled box in memory. The type tells C# how big the box is and what kind of data it can hold.

int age = 20;              // whole numbers
double price = 99.99;      // decimal numbers
char grade = 'A';          // single character
string name = "Ankit";     // text
bool isPassed = true;      // true/false

------------------------------------------------------------------------------------------------------------------------------------------------
# Operators

  Operators are symbols that perform operations on variables and values. 
  C# provides a wide range of operators, including arithmetic, comparison, logical, assignment, and more.
  Arithmetic Operators: +, -, *, /, %
  Comparison Operators: ==, !=, >, <, >=, <=
  Logical Operators: &&, ||, !
  Assignment Operators: =, +=, -=, *=, /=

------------------------------------------------------------------------------------------------------------------------------------------------
  # Type Conversion:
  Type conversion is the process of converting a value from one data type to another.
  Implicit Conversion: C# automatically converts a smaller data type to a larger data type (
  Explicit Conversion: C# allows you to manually convert a value from one data type to another using casting or conversion methods.
  int x = 10;
  double y = x;              // implicit — safe, no data loss (int fits in double)

 double d = 9.7;
 int i = (int)d;             // explicit cast — you must ask for it, data may be lost (9.7 -> 9)

 Cast is a way to convert a value from one data type to another. It is done by placing the target data type in parentheses before the value to be converted.
 
 ------------------------------------------------------------------------------------------------------------------------------------------------
# Conditions:
C# provides conditional statements that allow you to control the flow of your program based on certain conditions. 
  The most common conditional statements are if, else if, and else.
  if (condition)
  {
	  // code to execute if condition is true
  }
  else if (anotherCondition)
  {
	  // code to execute if anotherCondition is true
  }
  else
  {
	  // code to execute if all conditions are false
  }

-- Switch:
   Switch statement is a control statement that allows you to execute different blocks of code based on the value of a variable or expression.
   switch (variable)
   {
	   case value1:
		   // code to execute if variable equals value1
		   break;
	   case value2:
		   // code to execute if variable equals value2
		   break;
	   default:
		   // code to execute if variable does not match any case
		   break;
   }


------------------------------------------------------------------------------------------------------------------------------------------------
# Method is a block of code that performs a specific task. It can take input parameters, perform operations, and return a value. 
  Methods help in organizing code, making it reusable and easier to read.
  sytax for method is:
	returnType MethodName(parameters)
	{
		// method body
	}

# static method is a method that belongs to the class itself rather than an instance of the class.
  It can be called without creating an object of the class. 
  Static methods are often used for utility functions or operations that do not require access to instance-specific data. 

# Non-static method is a method that belongs to an instance of a class. 
  It can only be called on an object of the class and can access instance-specific data. 
  Non-static methods are used when the behavior of the method depends on the state of the object.

------------------------------------------------------------------------------------------------------------------------------------------------
# class & object
  They are the fundamental building blocks of object-oriented programming in C#.
  A class is a blueprint or template that defines the structure and behavior of objects, while an object is an instance of a class.

------------------------------------------------------------------------------------------------------------------------------------------------
# Method Overloading: 
 Method overloading is a feature in C# that allows a class to have multiple methods with the same name but different parameter lists (different number or types of parameters). 
  It enables developers to create methods that perform similar tasks but with different input requirements, improving code readability and usability.
  
  ------------------------------------------------------------------------------------------------------------------------------------------------
# Principles in C#:
 Encapsulation: Encapsulation is the principle of bundling data (attributes) and methods (functions) that operate on that data into a single unit called a class. It restricts direct access to the internal state of an object and provides controlled access through public methods, ensuring data integrity and security.
 Abstraction: Abstraction is the principle of simplifying complex systems by breaking them down into smaller, more manageable parts. 
 In C#, abstraction is achieved through abstract classes and interfaces, allowing developers to define common behaviors and properties without exposing unnecessary implementation details.
 Inheritance: Inheritance is the principle that allows a class (derived class) to inherit
 Polymorphism: Polymorphism is the principle that allows objects of different classes to be treated as objects of a common base class. 
 It enables a single interface to represent different underlying forms (data types). In C#, polymorphism is achieved through method overriding and interfaces, allowing for dynamic method invocation and flexibility in code design.

------------------------------------------------------------------------------------------------------------------------------------------------
