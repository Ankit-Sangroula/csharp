# Learning C# — Quick Reference Guide

## Variables

A variable is a labeled box in memory. The type tells C# how big the box is and what kind of data it can hold.

```csharp
int age = 20;              // whole numbers
double price = 99.99;      // decimal numbers
char grade = 'A';          // single character
string name = "Ankit";     // text
bool isPassed = true;      // true/false
```

---

## Constants

Constants are variables whose values cannot be changed after they are initialized. They are declared using the `const` keyword and must be assigned a value at the time of declaration.

```csharp
const double Pi = 3.14159;
```

---

## Exception Handling

A mechanism in C# that allows you to handle runtime errors and exceptions gracefully, preventing the program from crashing.

```csharp
try
{
    // risky code
}
catch (Exception ex)
{
    // runs only if something in the try block went wrong
}
```

---

## Operators

Operators are symbols that perform operations on variables and values. C# provides a wide range of operators, including arithmetic, comparison, logical, and assignment operators.

| Category | Operators |
|---|---|
| Arithmetic | `+` `-` `*` `/` `%` |
| Comparison | `==` `!=` `>` `<` `>=` `<=` |
| Logical | `&&` `\|\|` `!` |
| Assignment | `=` `+=` `-=` `*=` `/=` |

---

## Type Conversion

Type conversion is the process of converting a value from one data type to another.

- **Implicit Conversion** — C# automatically converts a smaller data type to a larger one (no data loss).
- **Explicit Conversion** — you manually convert a value from one data type to another using casting or conversion methods.

```csharp
int x = 10;
double y = x;              // implicit — safe, no data loss (int fits in double)

double d = 9.7;
int i = (int)d;             // explicit cast — you must ask for it, data may be lost (9.7 -> 9)
```

A **cast** is a way to convert a value from one data type to another, done by placing the target data type in parentheses before the value being converted.

---

## Conditions

C# provides conditional statements that let you control the flow of your program based on certain conditions. The most common are `if`, `else if`, and `else`.

```csharp
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
```

### Switch

A control statement that executes different blocks of code based on the value of a variable or expression.

```csharp
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
```

---

## Methods

A method is a block of code that performs a specific task. It can take input parameters, perform operations, and return a value. Methods help organize code, making it reusable and easier to read.

```csharp
returnType MethodName(parameters)
{
    // method body
}
```

**Static method** — belongs to the class itself rather than an instance of the class. It can be called without creating an object of the class. Static methods are often used for utility functions or operations that don't require access to instance-specific data.

**Non-static (instance) method** — belongs to an instance of a class. It can only be called on an object of the class and can access instance-specific data. Used when the method's behavior depends on the state of the object.

---

## Class & Object

The fundamental building blocks of object-oriented programming in C#.

- A **class** is a blueprint or template that defines the structure and behavior of objects.
- An **object** is an instance of a class.
- A class contains fields, properties, methods, and events that define the characteristics and actions of the objects created from it.

```csharp
class Bank
{
    public int AccountNumber;
    private double balance;

    public void Deposit(double amount)
    {
        balance += amount;
    }
}

Bank myAccount = new Bank();   // myAccount is an OBJECT of class Bank
```

---

## Method Overloading

A feature in C# that allows a class to have multiple methods with the same name but different parameter lists (different number or types of parameters). It enables methods that perform similar tasks with different input requirements, improving code readability and usability.

```csharp
int Add(int a, int b) => a + b;
double Add(double a, double b) => a + b;
```

---

## Principles of OOP in C#

- **Encapsulation** — bundling data (fields) and methods that operate on that data into a single unit (a class). It restricts direct access to an object's internal state and provides controlled access through public methods, ensuring data integrity and security.
- **Abstraction** — simplifying complex systems by breaking them into smaller, manageable parts. In C#, achieved through abstract classes and interfaces, letting you define common behaviors without exposing unnecessary implementation details.
- **Inheritance** — allows a class (derived class) to inherit fields and methods from another class (base class), promoting code reuse.
- **Polymorphism** — allows objects of different classes to be treated as objects of a common base class, enabling a single interface to represent different underlying forms. Achieved through method overriding and interfaces, allowing dynamic method invocation and flexible code design.

---

## Fields

Fields are variables declared within a class or struct, used to store data associated with an object. They represent the state or attributes of an object and can have different access modifiers (`public`, `private`, `protected`, etc.) to control their visibility and accessibility.

---

## Loops

Loops are control structures that let you repeatedly execute a block of code as long as a specified condition is true.

**For Loop** — executes a block of code a specific number of times.
```csharp
for (initialization; condition; increment/decrement)
{
    // code to execute
}
```

**While Loop** — executes a block of code as long as a specified condition is true.
```csharp
int i = 0;
while (i < 5)
{
    // code to execute
    i++;
}
```

**Do-While Loop** — similar to `while`, but guarantees the block runs at least once, since the condition is checked after execution.
```csharp
int i = 0;
do
{
    // code to execute
    i++;
} while (i < 5);
```

---

## Array

Arrays store multiple values of the same data type in a single variable.

```csharp
int[] numbers = new int[5];      // declares an array of integers with a size of 5
Console.WriteLine(numbers[0]);   // access the first element of the array
numbers[1] = 10;                 // assign a value to the second element
```

---

## String

Strings store sequences of characters. In C#, strings are immutable — once created, a string cannot be changed. However, you can create new strings based on existing ones.

```csharp
string name = "Ankit";
Console.WriteLine(name);                  // Ankit
Console.WriteLine(name.Length);           // 5
Console.WriteLine(name.ToUpper());        // ANKIT
Console.WriteLine(name.ToLower());        // ankit
Console.WriteLine(name.Substring(0, 3));  // Ank
Console.WriteLine(name.Replace("A", "a")); // ankit
Console.WriteLine(name.Contains("n"));    // true
Console.WriteLine(name.IndexOf("k"));     // 2
```

---

## Constructor

Constructors are special methods used to initialize objects of a class. They have the same name as the class and no return type. Constructors are called automatically when an object is created, letting you set initial values for the object's fields or perform any necessary setup.

```csharp
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
```

---

## Access Modifiers

Access modifiers are keywords that define the visibility and accessibility of classes, methods, fields, and other members. They control how and where these members can be accessed from other parts of the code.

| Modifier | Accessible from |
|---|---|
| `public` | Any code, in the same assembly or another assembly that references it |
| `protected` | The same class and any derived (child) classes |
| `private` | Only within the same class |

---

## Members

"Member" refers to the components of a class or struct in C#. Members can include fields, properties, methods, events, and nested types. They define the behavior and state of an object and can have different access modifiers to control their visibility and accessibility.

```csharp
class Bank
{
    public int AccountNumber;        // ← this is a member (a field)
    public string AccountType;       // ← this is a member (a field)
    private double balance;          // ← this is a member (a field)

    public double Balance { get { return balance; } }  // ← this is a member (a property)

    public Bank(int accNo, string accType) { ... }      // ← this is a member (a constructor)

    public void Deposit(double amount) { ... }          // ← this is a member (a method)
}
```

There are two types of members in C#:

- **Static Members** — belong to the class itself rather than an instance of the class. Accessible without creating an object, and shared among all instances.
- **Instance Members** — belong to a specific instance of a class. Only accessible through an object, and can hold different values for each instance.

---

## Inheritance

Inheritance is a fundamental OOP concept that allows a class (derived class) to inherit properties and methods from another class (base class).

```csharp
public class A
{
}

public class B : A
{
}
```
---
## Class Properties

Class properties are members that provide a way to access and manipulate an object's data. They're defined using `get` and `set` accessors, letting you control how values are retrieved and modified. Properties can encapsulate fields, providing a level of abstraction and validation.

- **Public properties** can be accessed from outside the class.
- **Private properties** are only accessible within the class itself.

Properties are used to access and modify private fields in a controlled manner, providing encapsulation and data integrity. Without properties, you'd have to use public fields directly, which can lead to unintended modifications and no control over the data. Properties let you implement validation logic, perform calculations, or trigger events when a value is accessed or modified.

```csharp
public type PropertyName
{
    get { return field; }      // retrieves the value of the property
    set { field = value; }     // sets the value of the property
}
```

---
## Method Hiding

A feature in C# that lets a derived class provide a new implementation of a method already defined in its base class. When a method in the derived class is declared with the `new` keyword, it hides the base class version instead of overriding it.

```csharp
class Base
{
    public void Show() { Console.WriteLine("Base"); }
}

class Derived : Base
{
    public new void Show() { Console.WriteLine("Derived"); }
}
```
new keyword is used to indicate that the method in the derived class is intentionally hiding the method in the base class.
When you call the `Show` method on an instance of the derived class, it will invoke the derived version, while calling it on an instance of the base class will invoke the base version.

---
## Struct

Structs are value types in C# used to define lightweight objects. They're similar to classes but have key differences — they're stored on the stack rather than the heap, and don't support inheritance. Structs are typically used for small data structures that don't need the overhead of a class.

```csharp
struct Point
{
    public int x;
    public int y;
}
```

---

## Enum

Enums (short for enumerations) are a special data type that lets you define a set of named constants. They represent a collection of related values in a more readable and maintainable way, often used to represent a fixed set of options.

```csharp
enum Day { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }

Day today = Day.Monday;
```

---

## Sealed Class

A sealed class is a class that cannot be inherited by any other class.

```csharp
sealed class SealedClass
{
    // class members
}
```

---
## Abstract Class:
Abstract classes are classes that cannot be instantiated directly and are meant to be inherited by other classes. 
They can contain abstract methods (without implementation) that must be implemented by derived classes, as well as concrete methods (with implementation).

```csharp