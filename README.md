# A variable is a labeled box in memory. The type tells C# how big the box is and what kind of data it can hold.

int age = 20;              // whole numbers
double price = 99.99;      // decimal numbers
char grade = 'A';          // single character
string name = "Ankit";     // text
bool isPassed = true;      // true/false

------------------------------------------------------------------------------------------------------------------------------------------------
# Constants:
constants are variables whose values cannot be changed after they are initialized. They are declared using the const keyword and must be assigned a value at the time of declaration.
const double Pi = 3.14159;

------------------------------------------------------------------------------------------------------------------------------------------------
# Exceptional Handling:
It is a mechanism in C# that allows you to handle runtime errors and exceptions gracefully, preventing the program from crashing.
try
{
    // risky code
}
catch (Exception ex)
{
    // runs only if something in the try block went wrong
}

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
# field:
Fields are variables that are declared within a class or struct and are used to store data associated with an object. 
They represent the state or attributes of an object and can have different access modifiers (public, private, protected, etc.) to control their visibility and accessibility.

------------------------------------------------------------------------------------------------------------------------------------------------
# loop:
Loops are control structures that allow you to repeatedly execute a block of code as long as a specified condition is true.
Types of loops in C#:

For Loop: Executes a block of code a specific number of times.
for (initialization; condition; increment/decrement)
{
	// code to execute
}
While Loop: Executes a block of code as long as a specified condition is true.
int i = 0;
while (i < 5)
{
	// code to execute
	i++;
}
do-While Loop: Similar to the while loop, but it guarantees that the block of code will be executed at least once, as the condition is checked after the execution.
int i = 0;
do {
	// code to execute
	i++;
} while (i < 5);

------------------------------------------------------------------------------------------------------------------------------------------------
# Array:
Arrays are used to store multiple values of the same data type in a single variable.
syntax for declaring an array:
int[] numbers = new int[5]; // declares an array of integers with a size of 5
console.writeline(numbers[0]); // access the first element of the array
numbers[1] = 10; // assign a value to the second element of the array

------------------------------------------------------------------------------------------------------------------------------------------------
String:
Strings are used to store sequences of characters. In C#, strings are immutable, meaning that once a string is created, it cannot be changed. However, you can create new strings based on existing ones.

string name = "Ankit";
console.writeline(name); // output: Ankit
console.writeline(name.length); // output: 5
console.writeline(name.toUpper()); // output: ANKIT
console.writeline(name.toLower()); // output: ankit
console.writeline(name.substring(0, 3)); // output: Ank
console.writeline(name.replace("A", "a")); // output: ankit
console.writeline(name.contains("n")); // output: true
console.writeline(name.indexOf("k")); // output: 2

------------------------------------------------------------------------------------------------------------------------------------------------
# constructor:
constructors are special methods in C# that are used to initialize objects of a class. They have the same name as the class and do not have a return type. Constructors are called automatically when an object is created, allowing you to set initial values for the object's fields or perform any necessary setup.
class Person
{
	private string name;
	private int age;
	// Constructor
	public Person(string name, int age)
	{
		this.name = name;
		this.age = age;
	}
	public void DisplayInfo()
	{
		Console.WriteLine($"Name: {name}, Age: {age}");
	}
}

------------------------------------------------------------------------------------------------------------------------------------------------
# Members:
It refers to the components of a class or struct in C#. Members can include fields, properties, methods, events, and nested types. They define the behavior and state of an object and can have different access modifiers to control their visibility and accessibility.

class Bank
{
    public int AccountNumber;        // ← this is a member (a field)
    public string AccountType;       // ← this is a member (a field)
    private double balance;          // ← this is a member (a field)

    public double Balance { ... }    // ← this is a member (a property)

    public Bank(...) { ... }         // ← this is a member (a constructor)

    public void Deposit(...) { ... } // ← this is a member (a method)
}
There are two types of members in C#:
Static Members: Static members belong to the class itself rather than an instance of the class. They can be accessed without creating an object of the class and are shared among all instances of the class.
Instance Members: Instance members belong to a specific instance of a class. They can only be accessed through an object of the class and can have different values for each instance.


