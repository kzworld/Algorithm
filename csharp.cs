1. What is C#?

C# is the best language for writing Microsoft .NET applications. C# provides the rapid application development found in Visual Basic with the power of C++. Its syntax is similar to C++ syntax and meets 100% of the requirements of OOPs like the following:

    Abstraction
    Encapsulation
    Polymorphism
    Inheritance

To know more about C# Language read the following article:

    Introduction to C#

The latest version of C# is C# 6.0 with lots of new features, to know them read the following article:

    List of All The New Features in C# 6.0: Part 1

2. What is an Object?

According to MSDN, "a class or struct definition is like a blueprint that specifies what the type can do. An object is basically a block of memory that has been allocated and configured according to the blueprint. A program may create many objects of the same class. Objects are also called instances, and they can be stored in either a named variable or in an array or collection. Client code is the code that uses these variables to call the methods and access the public properties of the object. In an object-oriented language such as C#, a typical program consists of multiple objects interacting dynamically".

Objects helps us to access the member of a class or struct either they can be fields, methods or properties, by using the dot. To know more about object read the following links:

    Introduction to Object-Oriented Programming
    Object Lifetime in .NET Framework
    OOP Overview

3. What is Managed or Unmanaged Code?

Managed Code

“The code, which is developed in .NET framework is known as managed code. This code is directly executed by CLR with the help of managed code execution. Any language that is written in .NET Framework is managed code”.

Unmanaged Code

The code, which is developed outside .NET framework is known as unmanaged code.

“Applications that do not run under the control of the CLR are said to be unmanaged, and certain languages such as C++ can be used to write such applications, which, for example, access low - level functions of the operating system. Background compatibility with the code of VB, ASP and COM are examples of unmanaged code”.

Unmanaged code can be unmanaged source code and unmanaged compile code. Unmanaged code is executed with the help of wrapper classes.

Wrapper classes are of two types:

    CCW (COM Callable Wrapper).
    RCW (Runtime Callable Wrapper).

    Managed code and unmanaged code in .NET

4. What is Boxing and Unboxing?

Answer: Boxing and Unboxing both are used for type conversion but have some difference:

Boxing:

Boxing is the process of converting a value type data type to the object or to any interface data type which is implemented by this value type. When the CLR boxes a value means when CLR is converting a value type to Object Type, it wraps the value inside a System.Object and stores it on the heap area in application domain.

Example:



Unboxing:

Unboxing is also a process which is used to extract the value type from the object or any implemented interface type. Boxing may be done implicitly, but unboxing have to be explicit by code.

Example:



The concept of boxing and unboxing underlines the C# unified view of the type system in which a value of any type can be treated as an object.

For more details read this:

    Boxing and Unboxing
    Type Conversions in C#

5. What is the difference between a struct and a class in C#?

Answer:

Class and struct both are the user defined data type but have some major difference:

Struct

    The struct is value type in C# and it inherits from System.Value Type.
    Struct is usually used for smaller amounts of data.
    Struct can’t be inherited to other type.
    A structure can't be abstract.
    No need to create object by new keyword.
    Do not have permission to create any default constructor.

Class

    The class is reference type in C# and it inherits from the System.Object Type.
    Classes are usually used for large amounts of data.
    Classes can be inherited to other class.
    A class can be abstract type.
    We can’t use an object of a class with using new keyword.
    We can create a default constructor.

For more details just go with the following link:

    Some Real Differences Between Structures and Classes
    Struct and Class Differences in C#

6. What is the difference between Interface and Abstract Class?

Answer:

Theoretically their are some differences between Abstract Class and Interface which are listed below:

    A class can implement any number of interfaces but a subclass can at most use only one abstract class.
    An abstract class can have non-abstract methods (concrete methods) while in case of interface all the methods has to be abstract.
    An abstract class can declare or use any variables while an interface is not allowed to do so.
    In an abstract class all data member or functions are private by default while in interface all are public, we can’t change them manually.
    In an abstract class we need to use abstract keyword to declare abstract methods while in an interface we don’t need to use that.
    An abstract class can’t be used for multiple inheritance while interface can be used as multiple inheritance.
    An abstract class use constructor while in an interface we don’t have any type of constructor.

To know more about the difference between Abstract Class and Interface go to the following link:

    Abstract Class vs Interface
    Explore Interface Vs Abstract Class

7. What is enum in C#?

Answer:

An enum is a value type with a set of related named constants often referred to as an enumerator list. The enum keyword is used to declare an enumeration. It is a primitive data type, which is user defined.

An enum type can be an integer (float, int, byte, double etc.). But if you used beside int it has to be cast.

An enum is used to create numeric constants in .NET framework. All the members of enum are of enum type. Their must be a numeric value for each enum type.

The default underlying type of the enumeration element is int. By default, the first enumerator has the value 0, and the value of each successive enumerator is increased by 1.

    enum Dow {Sat, Sun, Mon, Tue, Wed, Thu, Fri};  

Some points about enum

    Enums are enumerated data type in c#.
    Enums are not for end-user, they are meant for developers.
    Enums are strongly typed constant. They are strongly typed, i.e. an enum of one type may not be implicitly assigned to an enum of another type even though the underlying value of their members are the same.
    Enumerations (enums) make your code much more readable and understandable.
    Enum values are fixed. Enum can be displayed as a string and processed as an integer.
    The default type is int, and the approved types are byte, sbyte, short, ushort, uint, long, and ulong.
    Every enum type automatically derives from System.Enum and thus we can use System.Enum methods on enums.
    Enums are value types and are created on the stack and not on the heap.

For more details follow the link:

    Enums in C#
    Enumeration In C#

8. What is the difference between “continue” and “break” statements in C#?

Answer:

Using break statement, you can 'jump out of a loop' whereas by using continue statement, you can 'jump over one iteration' and then resume your loop execution.

Eg. Break Statement

    using System;  
    using System.Collections;  
    using System.Linq;  
    using System.Text;  
      
    namespace break_example {  
        {  
            Class brk_stmt {  
                public static void main(String[] args) {  
                    for (int i = 0; i <= 5; i++) {  
                        if (i == 4) {  
                            continue;  
                        }  
                        Console.ReadLine(“The number is” + i);  
      
                    }  
                }  
            }  
      
        }  
    }  

Output

The number is 0;
The number is 1;
The number is 2;
The number is 3;

Eg.Continue Statement

    using System;  
    using System.Collections;  
    using System.Linq;  
    using System.Text;  
      
    namespace continue_example  
    {  
        Class cntnu_stmt   
        {  
            public static void main(String[]   
            {  
                for (int i = 0; i <= 5; i++)   
                {  
                    if (i == 4)   
                    {  
                        continue;  
                    }  
                    Console.ReadLine(“The number  
                      
                }  
            }  
        }  
          
    }  
      
              

Output

The number is 1;
The number is 2;
The number is 3;
The number is 5;

For more details follow link:

    Difference Between Break Statement and Continue Statement in C#
    Break and Continue Statements in C#

9. What is the difference between constant and read only in c#?

Answer:

Constant (const) and Readonly (readonly) both looks like same as per the uses but they have some differences: 

Constant is known as “const” keyword in C# which is also known immutable values which are known at compile time and do not change their values at run time like in any function or constructor for the life of application till the application is running.

Readonly is known as “readonly” keyword in C# which is also known immutable values and are known at compile and run time and do not change their values at run time like in any function for the life of application till the application is running. You can assay their value by constructor when we call constructor with “new” keyword.

See the example

We have a Test Class in which we have two variables one is readonly and another is constant.

    class Test {  
        readonly int read = 10;  
        const int cons = 10;  
        public Test() {  
            read = 100;  
            cons = 100;  
        }  
        public void Check() {  
            Console.WriteLine("Read only : {0}", read);  
            Console.WriteLine("const : {0}", cons);  
        }  
    }  

Here I was trying to change the value of both the variables in constructor but when I am trying to change the constant it gives an error to change their value in that block which have to call at run time.



So finally remove that line of code from class and call this Check() function like the following code snippet:

    class Program {  
        static void Main(string[] args) {  
            Test obj = new Test();  
            obj.Check();  
            Console.ReadLine();  
        }  
    }  
    class Test {  
        readonly int read = 10;  
        const int cons = 10;  
        public Test() {  
            read = 100;  
        }  
        public void Check() {  
            Console.WriteLine("Read only : {0}", read);  
            Console.WriteLine("const : {0}", cons);  
        }  
    }  

Output:



To know more go to the following link:

    Difference Between Const, ReadOnly and Static ReadOnly in C#
    Constant VS ReadOnly In C#

10. What is the difference between ref and out keywords?

Answer:

In C Sharp (C#) we can have three types of parameters in a function. The parameters can be in parameter (which is not returned back to the caller of the function), out parameter and ref parameter. We have lots of differences in both of them.



For more details go to the following link:

    Ref Vs Out Keywords in C#
    Ref And Out Keywords in C#

11. Can “this” be used within a static method?

Answer:

We can't use this in static method because keyword 'this' returns a reference to the current instance of the class containing it. Static methods (or any static member) do not belong to a particular instance. They exist without creating an instance of the class and call with the name of a class not by instance so we can’t use this keyword in the body of static Methods, but in case of Extension Methods we can use it the functions parameters. Let’s have a look on “this” keyword.

The "this" keyword is a special type of reference variable that is implicitly defined within each constructor and non-static method as a first parameter of the type class in which it is defined. For example, consider the following class written in C#.

For more follow this link:

    "this" Keyword in C#
    this keyword in C#

12. Define Property in C#.net?

Answer:

Properties are members that provide a flexible mechanism to read, write or compute the values of private fields, in other words by the property we can access private fields. In other words we can say that a property is a return type function/method with one parameter or without a parameter. These are always public data members. It uses methods to access and assign values to private fields called accessors.

Now question is what are accessors?

The get and set portions or blocks of a property are called accessors. These are useful to restrict the accessibility of a property, the set accessor specifies that we can assign a value to a private field in a property and without the set accessor property it is like a read-only field. By the get accessor we can access the value of the private field, in other words it returns a single value. A Get accessor specifies that we can access the value of a field publically.

We have the three types of properties

    Read/Write.
    ReadOnly.
    WriteOnly

For more details follow the link:

    Property in C#
    Properties In C#

13. What is extension method in c# and how to use them?

Answer:

Extension methods enable you to add methods to existing types without creating a new derived type, recompiling, or otherwise modifying the original type. An extension method is a special kind of static method, but they are called as if they were instance methods on the extended type.

How to use extension methods?

An extension method is a static method of a static class, where the "this" modifier is applied to the first parameter. The type of the first parameter will be the type that is extended.

Extension methods are only in scope when you explicitly import the namespace into your source code with a using directive.

Like: suppose we have a class like bellow:

    public class Class1 {  
        public string Display() {  
            return ("I m in Display");  
        }  
      
        public string Print() {  
            return ("I m in Print");  
        }  
    }  

Now we need to extend the definition of this class so m going to create a static class to create an extinction method like:

    public static class XX {  
        public static void NewMethod(this Class1 ob) {  
            Console.WriteLine("Hello I m extended method");  
        }  
    }  

Here I just create a method that name is NewMethod with a parameter using this to define which type of data I need to be extend, now let’s see how to use this function.



    class Program {  
        static void Main(string[] args) {  
            Class1 ob = new Class1();  
            ob.Display();  
            ob.Print();  
            ob.NewMethod();  
            Console.ReadKey();  
        }  
    }  

Output will be:



For more details you can read this article:

    Extension Methods in C#
    Extension Method In C#

Or watch my video article link

    Extension Methods in C#

14. What is the difference between dispose and finalize methods in c#?

Answer: finalizer and dispose both are used for same task like to free unmanaged resources but have some differences see.

Finalize:

    Finalize used to free unmanaged resources those are not in use like files, database connections in application domain and more, held by an object before that object is destroyed.
    In the Internal process it is called by Garbage Collector and can’t called manual by user code or any service.
    Finalize belongs to System.Object class.
    Implement it when you have unmanaged resources in your code, and make sure that these resources are freed when the Garbage collection happens.

Dispose:

    Dispose is also used to free unmanaged resources those are not in use like files, database connections in Application domain at any time.
    Dispose explicitly it is called by manual user code.
    If we need to dispose method so must implement that class by IDisposable interface.
    It belongs to IDisposable interface.
    Implement this when you are writing a custom class that will be used by other users.

For more details follow this link:

    Back To Basics - Dispose Vs Finalize

15. What is the difference between string and StringBuilder in c#?

Answer:

StringBuilder and string both use to store string value but both have many differences on the bases of instance creation and also for performance:

String:

String is an immutable object. Immutable like when we create string object in code so we cannot modify or change that object in any operations like insert new value, replace or append any value with existing value in string object, when we have to do some operations to change string simply it will dispose the old value of string object and it will create new instance in memory for hold the new value in string object like:



Note:

    It’s an immutable object that hold string value.

    Performance wise string is slow because its’ create a new instance to override or change the previous value.

    String belongs to System namespace.

StringBuilder:

System.Text.Stringbuilder is mutable object which also hold the string value, mutable means once we create a System.Text.Stringbuilder object we can use this object for any operation like insert value in existing string with insert functions also replace or append without creating new instance of System.Text.Stringbuilder for every time so it’s use the previous object so it’s work fast as compare than System.String. Let’s have an example to understand System.Text.Stringbuilder like:



Note:

    StringBuilder is a mutable object.
    Performance wise StringBuilder is very fast because it will use same instance of StringBuilder object to perform any operation like insert value in existing string.
    StringBuilder belongs to System.Text.Stringbuilder namespace.

For More details read this article by following link:

    Comparison of String and StringBuilder in C#
    String and StringBuilder Classes

16. What is delegates in C# and uses of delegates?

Answer:

C# delegates are same as pointers to functions, in C or C++. A delegate Object is a reference type variable that use to holds the reference to a method. The reference can be changed at runtime which is hold by an object of delegate, a delegate object can hold many functions reference which is also known as Invocation List that refers functions in a sequence FIFO, we can new functions ref in this list at run time by += operator and can remove by -= operator.

Delegates are especially used for implementing events and the call-back methods. All delegates are implicitly derived from the System.Delegate class.

Let’s see how to use Delegate with Example:



For More details read this article:

    C# Delegates
    Delegates in C#

17. What is sealed class in c#?

Answer:

Sealed classes are used to restrict the inheritance feature of object oriented programming. Once a class is defined as a sealed class, the class cannot be inherited.

In C#, the sealed modifier is used to define a class as sealed. In Visual Basic .NET the Not Inheritable keyword serves the purpose of sealed. If a class is derived from a sealed class then the compiler throws an error.

If you have ever noticed, structs are sealed. You cannot derive a class from a struct.

The following class definition defines a sealed class in C#:

    // Sealed class  
    sealed class SealedClass  
    {  
      
    }  

Read continue for more details by the following link:

    Sealed Class in C#
    Sealed Class in C#

18. What are partial classes?

Answer:

A partial class is only use to splits the definition of a class in two or more classes in a same source code file or more than one source files. You can create a class definition in multiple files but it will be compiled as one class at run time and also when you’ll create an instance of this class so you can access all the methods from all source file with a same object.

Partial Classes can be create in the same namespace it’s doesn’t allowed to create a partial class in different namespace. So use “partial” keyword with all the class name which you want to bind together with the same name of class in same namespace, let’s have an example:



For more go with following link:

    Partial Classes in C# With Real Example
    Partial Class in C#

19. What is boxing and unboxing?

Answer:

Boxing and Unboxing both using for type converting but have some difference:

Boxing:

Boxing is the process of converting a value type data type to the object or to any interface data type which is implemented by this value type. When the CLR boxes a value means when CLR converting a value type to Object Type, it wraps the value inside a System.Object and stores it on the heap area in application domain.

Example:



Unboxing:

Unboxing is also a process which is use to extracts the value type from the object or any implemented interface type. Boxing may be done implicit but unboxing have to be explicit by code.

Example:



The concept of boxing and unboxing underlies the C# unified view of the type system in which a value of any type can be treated as an object.

For more details:

    Boxing and Unboxing

20. What is IEnumerable<> in c#?

Answer:

IEnumerable is the parent interface for all non-generic collections in System.Collections namespace like ArrayList, HastTable etc. that can be enumerated. For the generic version of this interface as IEnumerable<T> which a parent interface of all generic collections class in System.Collections.Generic namespace like List<> and more.

In System.Collections.Generic.IEnumerable<T> have only a single method which is GetEnumerator() that returns an IEnumerator. IEnumerator provides the power to iterate through the collection by exposing a Current property and Move Next and Reset methods, if we doesn’t have this interface as a parent so we can’t use iteration by foreach loop or can’t use that class object in our LINQ query.



For more details go with following link:

    Implement IEnumerable Interface in C#
    IEnumerable Interface in C#

21. What is difference between late binding and early binding in c#?

Answer:

Early Binding and Late Binding concepts belongs to polymorphism so let’s see first about polymorphism:

Polymorphism is an ability to take more than one form of a function means with a same name we can write multiple functions code in a same class or any derived class.

Polymorphism we have 2 different types to achieve that:

    Compile Time also known as Early Binding or Overloading.
    Run Time also known as Late Binding or Overriding.

Compile Time Polymorphism or Early Binding:

In Compile time polymorphism or Early Binding we will use multiple methods with same name but different type of parameter or may be the number or parameter because of this we can perform different-different tasks with same method name in the same class which is also known as Method overloading.

See how we can do that by the following example:



Run Time Polymorphism or Late Binding:

Run time polymorphism also known as late binding, in Run Time polymorphism or Late Binding we can do use same method names with same signatures means same type or same number of parameters but not in same class because compiler doesn’t allowed that at compile time so we can use in derived class that bind at run time when a child class or derived class object will instantiated that’s way we says that Late Binding. For that we have to create my parent class functions as partial and in driver or child class as override functions with override keyword.

Like as following example:


    Understanding Polymorphism in C#
    Polymorphism in .NET

22. What are the differences between IEnumerable and IQueryable?

Answer:

Before the differences learn what is IEnumerable and IQueryable.

IEnumerable:

Is the parent interface for all non-generic collections in System.Collections namespace like ArrayList, HastTable etc. that can be enumerated. For the generic version of this interface as IEnumerable<T> which a parent interface of all generic collections class in System.Collections.Generic namespace like List<> and more.

IQueryable:

As per MSDN IQueryable interface is intended for implementation by query providers. It is only supposed to be implemented by providers that also implement IQueryable<T>. If the provider does not also implement IQueryable<T>, the standard query operators cannot be used on the provider's data source.

The IQueryable interface inherits the IEnumerable interface so that if it represents a query, the results of that query can be enumerated. Enumeration causes the expression tree associated with an IQueryable object to be executed. The definition of "executing an expression tree" is specific to a query provider. For example, it may involve translating the expression tree to an appropriate query language for the underlying data source. Queries that do not return enumerable results are executed when the Execute method is called.


    IEnumerable vs IQuerable
    IEnumerable Vs IQueryable

23. What happens if the inherited interfaces have conflicting method names?

Answer:

If we implement multipole interface in the same class with conflict method name so we don’t need to define all or in other words we can say if we have conflict methods in same class so we can’t implement their body independently in the same class coz of same name and same signature so we have to use interface name before method name to remove this method confiscation let’s see an example:

    interface testInterface1 {  
        void Show();  
    }  
    interface testInterface2 {  
        void Show();  
    }  
    class Abc: testInterface1,  
    testInterface2 {  
      
        void testInterface1.Show() {  
            Console.WriteLine("For testInterface1 !!");  
        }  
        void testInterface2.Show() {  
            Console.WriteLine("For testInterface2 !!");  
        }  
    }  

Now see how to use those in a class:

    class Program {  
        static void Main(string[] args) {  
            testInterface1 obj1 = new Abc();  
            testInterface1 obj2 = new Abc();  
            obj1.Show();  
            obj2.Show();  
      
            Console.ReadLine();  
        }  
    }  

Output:



For one more example follow the link:

    Inherit Multiple Interfaces and They have Conflicting Method Name

24. What are the Arrays in C#.Net?

Answer:

Arrays are powerful data structures for solving many programming problems. You saw during the creation of variables of many types that they have one thing in common, they hold information about a single item, for instance an integer, float and string type and so on. So what is the solution if you need to manipulate sets of items? One solution would be to create a variable for each item in the set but again this leads to a different problem. How many variables do you need?

So in this situation Arrays provide mechanisms that solves problem posed by these questions. An array is a collection of related items, either value or reference type. In C# arrays are immutable such that the number of dimensions and size of the array are fixed.

Arrays Overview

An array contains zero or more items called elements. An array is an unordered sequence of elements. All the elements in an array are of the same type (unlike fields in a class that can be of different types). The elements of an array accessed using an integer index that always starts from zero. C# supports single-dimensional (vectors), multidimensional and jagged arrays.

Elements are identified by indexes relative to the beginning of the arrays. An index is also commonly called indices or subscripts and are placed inside the indexing operator ([]). Access to array elements is by their index value that ranges from 0 to (length-1).

Array Properties

    The length cannot be changed once created.
    Elements are initialized to default values.
    Arrays are reference types and are instances of System.Array.
    Their number of dimensions or ranks can be determined by the Rank property.
    An array length can be determined by the GetLength() method or Length property.

For more detail follow the link:

    Overview of Arrays in C#
    Doing Arrays - C#

25. What is the Constructor Chaining in C#?

Answer: constructor chaining is a way to connect two or more classes in a relationship as Inheritance, in Constructor Chaining every child class constructor is mapped to parent class Constructor implicitly by base keyword so when you create an instance of child class to it’ll call parent’s class Constructor without it inheritance is not possible.

For more example follow the link:

    Constructor Chaining In C#
    Constructors In C#

26. What’s the difference between the System.Array.CopyTo() and System.Array.Clone()?

Answer:

Clone:

Method creates a shallow copy of an array. A shallow copy of an Array copies only the elements of the Array, whether they are reference types or value types, but it does not copy the objects that the references refer to. The references in the new Array point to the same objects that the references in the original Array point to.

CopyTo:

The Copy static method of the Array class copies a section of an array to another array. The CopyTo method copies all the elements of an array to another one-dimension array. The code listed in Listing 9 copies contents of an integer array to an array of object types.

To learn about arrays go with following link:

    Working with Arrays in C#

27. Can Multiple Catch Blocks executed in c#?

Answer:

we can use multiple Catches block with every try but when any Exceptions is throw by debugger so every catches match this exception type with their signature and catch the exception by any single catch block so that means we can use multiple catches blocks but only one can executed at once like:

    using System;  
    class MyClient {  
        public static void Main() {  
            int x = 0;  
            int div = 0;  
            try {  
                div = 100 / x;  
                Console.WriteLine("Not executed line");  
            } catch (DivideByZeroException de) {  
                Console.WriteLine("DivideByZeroException");  
            } catch (Exception ee) {  
                Console.WriteLine("Exception");  
            } finally {  
                Console.WriteLine("Finally Block");  
            }  
            Console.WriteLine("Result is {0}", div);  
        }  
    }  

To learn more about Exception Handling following link:

    Exception Handling in C#

28. What is Singleton Design Patterns and How to implement in C#?

Answer:

What is Singleton Design Pattern?

    Ensures a class has only one instance and provides a global point of access to it.
    A singleton is a class that only allows a single instance of itself to be created, and usually gives simple access to that instance.
    Most commonly, singletons don't allow any parameters to be specified when creating the instance, since a second request of an instance with a different parameter could be problematic! (If the same instance should be accessed for all requests with the same parameter then the factory pattern is more appropriate.)
    There are various ways to implement the Singleton Pattern in C#. The following are the common characteristics of a Singleton Pattern.

    • A single constructor, that is private and parameterless.
    • The class is sealed.
    • A static variable that holds a reference to the single created instance, if any.
    • A public static means of getting the reference to the single created instance, creating one if necessary.

This is the example how to write the code with Singleton:

    namespace Singleton {  
        class Program {  
            static void Main(string[] args) {  
                Calculate.Instance.ValueOne = 10.5;  
                Calculate.Instance.ValueTwo = 5.5;  
                Console.WriteLine("Addition : " + Calculate.Instance.Addition());  
                Console.WriteLine("Subtraction : " + Calculate.Instance.Subtraction());  
                Console.WriteLine("Multiplication : " + Calculate.Instance.Multiplication());  
                Console.WriteLine("Division : " + Calculate.Instance.Division());  
      
                Console.WriteLine("\n----------------------\n");  
      
                Calculate.Instance.ValueTwo = 10.5;  
                Console.WriteLine("Addition : " + Calculate.Instance.Addition());  
                Console.WriteLine("Subtraction : " + Calculate.Instance.Subtraction());  
                Console.WriteLine("Multiplication : " + Calculate.Instance.Multiplication());  
                Console.WriteLine("Division : " + Calculate.Instance.Division());  
      
                Console.ReadLine();  
            }  
        }  
      
        public sealed class Calculate {  
            private Calculate() {}  
            private static Calculate instance = null;  
            public static Calculate Instance {  
                get {  
                    if (instance == null) {  
                        instance = new Calculate();  
                    }  
                    return instance;  
                }  
            }  
      
            public double ValueOne {  
                get;  
                set;  
            }  
            public double ValueTwo {  
                get;  
                set;  
            }  
      
            public double Addition() {  
                return ValueOne + ValueTwo;  
            }  
      
            public double Subtraction() {  
                return ValueOne - ValueTwo;  
            }  
      
            public double Multiplication() {  
                return ValueOne * ValueTwo;  
            }  
      
            public double Division() {  
                return ValueOne / ValueTwo;  
            }  
        }  
    }  

To read more about Singleton in depth so follow the link:

    Singleton Design Pattern in C#
    Implementing Singleton Design Patterns

29. Difference between Throw Exception and Throw Clause.

Answer:

The basic difference is that the Throw exception overwrites the stack trace and this makes it hard to find the original code line number that has thrown the exception.

Throw basically retains the stack information and adds to the stack information in the exception that it is thrown.

Let us see what it means rather speaking so many words to better understand the differences. I am using a console application to easily test and see how the usage of the two differ in their functionality.

    using System;  
    using System.Collections.Generic;  
    using System.Linq;  
    using System.Text;  
      
    namespace TestingThrowExceptions {  
        class Program {  
            public void ExceptionMethod() {  
                throw new Exception("Original Exception occurred in ExceptionMethod");  
      
            }  
      
            static void Main(string[] args) {  
                Program p = new Program();  
                try {  
                    p.ExceptionMethod();  
                } catch (Exception ex) {  
      
                    throw ex;  
                }  
            }  
        }  
    }  

Now run the code by pressing the F5 key of the keyboard and see what happens. It returns an exception and look at the stack trace:

For More Details use following link:

    Difference Between Throw Exception and Throw Clause

30. What are Indexer in C# .Net?

Answer:

Indexer allows classes to be used in more intuitive manner. C# introduces a new concept known as Indexers which are used for treating an object as an array. The indexers are usually known as smart arrays in C#. They are not essential part of object-oriented programming.

An indexer, also called an indexed property, is a class property that allows you to access a member variable of a class using the features of an array.

Defining an indexer allows you to create classes that act like virtual arrays. Instances of that class can be accessed using the [] array access operator.

Creating an Indexer

    < modifier > <  
    return type > this[argument list] {  
        get {  
            // your get block code  
        }  
      
        set {  
            // your set block code  
        }  
    }  

In the above code:

<modifier>

can be private, public, protected or internal.

<return type>

can be any valid C# types.

For more details use following link:

    Indexers in C#
    INDEXER in C#

31. What is multicast delegate in c#?

Answer

Delegate can invoke only one method reference has been encapsulated into the delegate.it is possible for certain delegate to hold and invoke multiple methods such delegate called multicast delegates.multicast delegates also know as combinable delegates, must satisfy the following conditions:

    The return type of the delegate must be void. None of the parameters of the delegate type can be delegate type can be declared as output parameters using out keywords.
    Multicast delegate instance that created by combining two delegates, the invocation list is formed by concatenating the invocation list of two operand of the addition operation. Delegates are invoked in the order they are added.

Implement Multicast Delegates Example:

    using System;  
    using System.Collections.Generic;  
    using System.Linq;  
    using System.Text;  
    delegate void MDelegate();  
    class DM {  
        static public void Display() {  
            Console.WriteLine("Meerut");  
        }  
        static public void print() {  
            Console.WriteLine("Roorkee");  
        }  
    }  
    class MTest {  
        public static void Main() {  
            MDelegate m1 = new MDelegate(DM.Display);  
            MDelegate m2 = new MDelegate(DM.print);  
            MDelegate m3 = m1 + m2;  
            MDelegate m4 = m2 + m1;  
            MDelegate m5 = m3 - m2;  
            m3();  
            m4();  
            m5();  
        }  
    }  

Use following link to with more details:

    How to create implement multicast Delegates in C#
    Delegate in C#

32. Difference between Equality Operator (==) and Equals() Method in C#.

Answer:

Both the == Operator and the Equals() method are used to compare two value type data items or reference type data items. The Equality Operator (==) is the comparison operator and the Equals() method compares the contents of a string. The == Operator compares the reference identity while the Equals() method compares only contents. Let’s see with some examples.

In this example we assigned a string variable to another variable. A string is a reference type and in the following example, a string variable is assigned to another string variable so they are referring to the same identity in the heap and both have the same content so you get True output for both the == Operator and the Equals() method.

    using System;  
    namespace ComparisionExample {  
        class Program {  
            static void Main(string[] args) {  
                string name = "sandeep";  
                string myName = name;  
                Console.WriteLine("== operator result is {0}", name == myName);  
                Console.WriteLine("Equals method result is {0}", name.Equals(myName));  
                Console.ReadKey();  
            }  
        }  
    }  

For more details go with this following Links:

    Difference Between Equality Operator ( ==) and Equals() Method in C#

33. Difference between is and as operator in C#.

Answer:

"is" operator

In the C# language, we use the "is" operator to check the object type. If the two objects are of the same type, it returns true and false if not.

Let's understand the preceding from a small program.

We defined the following two classes:

    class Speaker {  
        public string Name {  
            get;  
            set;  
        }  
    }  
    class Author {  
        public string Name {  
            get;  
            set;  
        }  
    }  

Now, let's try to check the preceding types as:

    var speaker = new Speaker { Name="Gaurav Kumar Arora"};  

We declared an object of Speaker as in the following:

    var isTrue = speaker is Speaker;   

In the preceding, we are just checking the matching type. Yes, our speaker is an object of Speaker type.

    Console.WriteLine("speaker is of Speaker type:{0}", isTrue);   

So, the results as true.

But, here we get false:

    var author = new Author { Name = "Gaurav Kumar Arora" };   
    var isTrue = speaker is Author;   
    Console.WriteLine("speaker is of Author type:{0}", isTrue);  

Because our our speaker is not an object of Author type.

"as" operator:

The "as" operator behaves similar to the "is" operator. The only difference is it returns the object if both are compatible to that type else it returns null.
 
Let's understand the preceding with a small snippet as in the following:

    public static string GetAuthorName(dynamic obj)   
    {   
    Author authorObj = obj as Author;   
    return (authorObj != null) ? authorObj.Name : string.Empty;   
    }   

We have a method that accepts dynamic objects and returns the object name property if the object is of the Author type.

Here, we declared two objects:

    var speaker = new Speaker { Name="Gaurav Kumar Arora"};   
    var author = new Author { Name = "Gaurav Kumar Arora" };   

The following returns the "Name" property:

    var authorName = GetAuthorName(author);   
    Console.WriteLine("Author name is:{0}", authorName);   

It returns an empty string:

    authorName = GetAuthorName(speaker);   
    Console.WriteLine("Author name is:{0}", authorName);   

For more follow the link:

    "is" and "as" Operators of C#
    The Is and As Operators in C#

34. How to use Nullable<> Types in .Net?

Answer:

A nullable Type is a data type is that contain the defined data type or the value of null.

You should note here that here variable datatype has been given and then only it can be used.

This nullable type concept is not comaptible with "var".

I will explain this with syntax in next section.

Declaration:

Any DataType can be declared nullable type with the help of operator "?".
Example of the syntax is as Follows :-

    int? i = null;  

As discussed in previous section "var" is not compatible with this Nullable Type.

So we will have Compile Time error if we are declaring something like: -

    var? i = null;  

though following syntax is completely fine :-

    var i = 4;  

For more details about Nullable<> follow the link:

    Getting started with Nullable Types in C#

35. Different Ways of Method can be overloaded.

Answer:

Method overloading is a way to achieve compile time Polymorphism where we can use a method with the same name but different signature, Method overloading is done at compile time and we have multiple way to do that but in all way method name should be same.

    Number of parameter can be different.
    Types of parameter can be different.
    Order of parameters can be different.

Example:

    using System;  
    using System.Collections.Generic;  
    using System.Linq;  
    using System.Text;  
      
    namespace Hello_Word {  
        class overloding {  
            public static void Main() {  
                Console.WriteLine(volume(10));  
                Console.WriteLine(volume(2.5F, 8));  
                Console.WriteLine(volume(100L, 75, 15));  
                Console.ReadLine();  
            }  
      
            static int volume(int x) {  
                return (x * x * x);  
            }  
      
            static double volume(float r, int h) {  
                return (3.14 * r * r * h);  
            }  
      
            static long volume(long l, int b, int h) {  
                return (l * b * h);  
            }  
        }  
    }  

Note:

If we have a method that have two parameter object type and have a same name method with two integer parameter so when we call that method with int value so it’ll call that method have integer parameter instead of object type parameters method.

To learn more about Method Overloading follow link:

    Method Overloading in C#

36. What is an Object Pool in .Net?

Answer:

Object Pooling is something that tries to keep a pool of objects in memory to be re-used later and hence it will reduce the load of object creation to a great extent. This article will try to explain this in detail. The example is for an Employee object, but you can make it general by using Object base class.

What does it mean?

Object Pool is nothing but a container of objects that are ready for use. Whenever there is a request for a new object, the pool manager will take the request and it will be served by allocating an object from the pool.

How it works?

We are going to use Factory pattern for this purpose. We will have a factory method, which will take care about the creation of objects. Whenever there is a request for a new object, the factory method will look into the object pool (we use Queue object). If there is any object available within the allowed limit, it will return the object (value object), otherwise a new object will be created and give you back.

For more Details follow the link:

    Object Pooling in .NET
    Object Pool Design Pattern

37. What are generics in c#.net?

Answer:

Generics allow you to delay the specification of the data type of programming elements in a class or a method, until it is actually used in the program. In other words, generics allow you to write a class or method that can work with any data type.

You write the specifications for the class or the method, with substitute parameters for data types. When the compiler encounters a constructor for the class or a function call for the method, it generates code to handle the specific data type.



Generic classes and methods combine reusability, type safety and efficiency in a way that their non-generic counterparts cannot. Generics are most frequently used with collections and the methods that operate on them. Version 2.0 of the .NET Framework class library provides a new namespace, System.Collections.Generic, that contains several new generic-based collection classes. It is recommended that all applications that target the .NET Framework 2.0 and later use the new generic collection classes instead of the older non-generic counterparts such as ArrayList.

Features of Generics

Generics is a technique that enriches your programs in the following ways:

    It helps you to maximize code reuse, type safety and performance.
    You can create generic collection classes. The .NET Framework class library contains several new generic collection classes in the System.Collections.Generic namespace. You may use these generic collection classes instead of the collection classes in the System.Collections namespace.
    You can create your own generic interfaces, classes, methods, events and delegates.
    You may create generic classes constrained to enable access to methods on specific data types.
    You may get information on the types used in a generic data type at run-time using reflection.

For More details follow the link:

    Introduction to Generics in C#
    Generics in C#

38. Describe the accessibility modifiers in c#.Net.

Answer:

Access modifiers are keywords used to specify the declared accessibility of a member or a type.

Why to use access modifiers?

Access modifiers are an integral part of object-oriented programming. They support the concept of encapsulation, which promotes the idea of hiding functionality. Access modifiers allow you to define who does or doesn't have access to certain features.

In C# there are 5 different types of Access Modifiers.



For details follow the link:

    What are Access Modifiers in C#?
    Access Specifiers (Access Modifiers) in C#

39. What is Virtual Method in C#?

Answer:

A virtual method is a method that can be redefined in derived classes. A virtual method has an implementation in a base class as well as derived the class. It is used when a method's basic functionality is the same but sometimes more functionality is needed in the derived class. A virtual method is created in the base class that can be overridden in the derived class. We create a virtual method in the base class using the virtual keyword and that method is overridden in the derived class using the override keyword.

When a method is declared as a virtual method in a base class then that method can be defined in a base class and it is optional for the derived class to override that method. The overriding method also provides more than one form for a method. Hence it is also an example for polymorphism.

When a method is declared as a virtual method in a base class and that method has the same definition in a derived class then there is no need to override it in the derived class. But when a virtual method has a different definition in the base class and the derived class then there is a need to override it in the derived class.

When a virtual method is invoked, the run-time type of the object is checked for an overriding member. The overriding member in the most derived class is called, which might be the original member, if no derived class has overridden the member.

Virtual Method

    By default, methods are non-virtual. We can't override a non-virtual method.
    We can't use the virtual modifier with the static, abstract, private or override modifiers.

For More Details follow the link:

    Virtual Method in C#

40. What are the Difference between Array and ArrayList in C#.Net?

Answer:

Difference between Array and ArrayList



To know more about Arraylist follow the link:

    Collections in C#: ArrayList and Arrays

41. What you understand by Value types and Reference types in C#.Net?

Answer:

In C# data types can be of two types: Value Types and Reference Types. Value type variables contain their object (or data) directly. If we copy one value type variable to another then we are actually making a copy of the object for the second variable. Both of them will independently operate on their values, Value Type member will located into Stack and reference member will located in Heap always.

Let consider each case briefly.

    Pure Value Type

    Here I used a structure as a value type. It has an integer member. I created two instances of this structure. After wards I assigned second instance to the first one. Then I changed the state of second instance, but it hasn't effect the first one, as whole items are value type and assignments on those types will copy only values not references i.e. in a Value Type assignment, all instances have its own local copy of members.

    Pure Reference Type

    I created a class and added a "DataTable" as a Reference Type member for this class. Then I performed the assignments just like below. But the difference is that on changing the state of second instance, the state of first instance will automatically alter. So in a Reference Type assignment both Value and Reference will be assigned i.e. all instances will point to the single object.

    Value Type With Reference Type

    This case and the last case to come are more interesting. I used a structure in this particular scenario also. But this time it includes a Reference Type(A Custom Class Object) Member besides a Value Type (An Integer) Member. When you performing the assignments, it seems like a swallow copy, as Value Type member of first instance won't effected, but the Reference Type member will alter according to the second instance. So in this particular scenario, assignment of Reference Type member produced a reference to a single object and assignment of Value Type member produced a local copy of that member.

    Reference Type With Value Type

    Contrary to the above case, in this scenario, both Reference & Value Types will be effected. I.e. a Value Type member in a Reference Type will be shared among its instances.

For more details follow this link:

    C# Concepts: Value Type and Reference Type
    Value Types and Reference Types Variables

42. What is Serialization?

Answer:

Serialization means saving the state of your object to secondary memory, such as a file.

Suppose you have a business layer where you have many classes to perform your business data.

Now suppose you want to test whether your business classes give the correct data out without verifying the result from the UI or from a database. Because it will take some time to process.

SO what you will you do my friend?

Here comes Serialization. You will serialize all your necessary business classes and save them into a text or XML file.

on your hard disk. So you can easily test your desired result by comparing your serialized saved data with.

your desired output data. You can say it is a little bit of autonomic unit testing performed by the developer.

There are three types of serialization:

    Binary serialization (Save your object data into binary format).
    Soap Serialization (Save your object data into binary format; mainly used in network related communication).
    XmlSerialization (Save your object data into an XML file).

For more details follow the link:

    Use of Serialization in C#
    Serializing Objects in C#

43. What is the use of Using statement in C#?

Answer:

The .Net Framework provides resource management for managed objects through the garbage collector - You do not have to explicitly allocate and release memory for managed objects. Clean-up operations for any unmanaged resources should performed in the destructor in C#. To allow the programmer to explicitly perform these clean-up activities, objects can provide a Dispose method that can be invoked when the object is no longer needed. The using statement in C# defines a boundary for the object outside of which, the object is automatically destroyed. The using statement is excited when the end of the "using" statement block or the execution exits the "using" statement block indirectly, for example - an exception is thrown. The "using" statement allows you to specify multiple resources in a single statement. The object could also be created outside the "using" statement. The objects specified within the using block must implement the IDisposable interface. The framework invokes the Dispose method of objects specified within the "using" statement when the block is exited.

For more details or examples follow the link:

    The "Using" Statement in C#

44. What is jagged array in C#.Net?

Answer:

A jagged array is an array whose elements are arrays. The elements of a jagged array can be of different dimensions and sizes. A jagged array is sometimes called an "array of arrays."

A special type of array is introduced in C#. A Jagged Array is an array of an array in which the length of each array index can differ.

Example:

    int[][] jagArray = new int[5][];  

In the above declaration the rows are fixed in size. But columns are not specified as they can vary.

Declaring and initializing jagged array.

    int[][] jaggedArray = new int[5][];  
      
    jaggedArray[0] = new int[3];  
    jaggedArray[1] = new int[5];  
    jaggedArray[2] = new int[2];  
    jaggedArray[3] = new int[8];  
    jaggedArray[4] = new int[10];  
    jaggedArray[0] = new int[] { 3, 5, 7, };  
    jaggedArray[1] = new int[] { 1, 0, 2, 4, 6 };  
    jaggedArray[2] = new int[] { 1, 6 };  
    jaggedArray[3] = new int[] { 1, 0, 2, 4, 6, 45, 67, 78 };  
    jaggedArray[4] = new int[] { 1, 0, 2, 4, 6, 34, 54, 67, 87, 78 };  

For more details follow the link:

    Jagged Arrays in C#.NET
    Jagged Array in C#

45. What is Multithreading with .NET?

Answer:

The real usage of a thread is not about a single sequential thread, but rather using multiple threads in a single program. Multiple threads running at the same time and performing various tasks is referred as Multithreading. A thread is considered to be a lightweight process because it runs within the context of a program and takes advantage of resources allocated for that program.


A single-threaded process contains only one thread while a multithreaded process contains more than one thread for execution.


System.Threading Namespace

Like many other features, in .NET, System.Threading is the namespace that provides various types to help in construction of multithreaded applications.



For more Details and example follow the link:

    Multithreading with .NET

46. Explain Anonymous type in C#?

Answer:

Anonymous types allow us to create new type without defining them. This is way to defining read only properties into a single object without having to define type explicitly. Here Type is generating by the compiler and it is accessible only for the current block of code. The type of properties is also inferred by the compiler.

We can create anonymous types by using “new” keyword together with the object initializer.

Example

    var anonymousData = new   
    {  
        ForeName = "Jignesh",  
        SurName = "Trivedi"  
    };  
    Console.WriteLine("First Name : " + anonymousData.ForeName);  

Anonymous Types with LINQ Example

Anonymous types are also used with the "Select" clause of LINQ query expression to return subset of properties.

Example

If Any object collection having properties called FirstName , LastName, DOB etc. and you want only FirstName and LastName after the Querying the data then.

    class MyData {  
        public string FirstName {  
            get;  
            set;  
        }  
        public string LastName {  
            get;  
            set;  
        }  
        public DateTime DOB {  
            get;  
            set;  
        }  
        public string MiddleName {  
            get;  
            set;  
        }  
    }  
    static void Main(string[] args) {  
        // Create Dummy Data to fill Collection.  
        List < MyData > data = new List < MyData > ();  
        data.Add(new MyData {  
            FirstName = "Jignesh", LastName = "Trivedi", MiddleName = "G", DOB = new DateTime(1990, 12, 30)  
        });  
        data.Add(new MyData {  
            FirstName = "Tejas", LastName = "Trivedi", MiddleName = "G", DOB = new DateTime(1995, 11, 6)  
        });  
        data.Add(new MyData {  
            FirstName = "Rakesh", LastName = "Trivedi", MiddleName = "G", DOB = new DateTime(1993, 10, 8)  
        });  
        data.Add(new MyData {  
            FirstName = "Amit", LastName = "Vyas", MiddleName = "P", DOB = newDateTime(1983, 6, 15)  
        });  
        data.Add(new MyData {  
            FirstName = "Yash", LastName = "Pandiya", MiddleName = "K", DOB = newDateTime(1988, 7, 20)  
        });  
    }  
    var anonymousData = from pl in data  
    select new {  
        pl.FirstName, pl.LastName  
    };  
    foreach(var m in anonymousData) {  
        Console.WriteLine("Name : " + m.FirstName + " " + m.LastName);  
    }  
    }  

For More Details follow the link:

    Anonymous Types in C#
    Return Anonymous Type in C#

47. Explain Hashtable in C#?

Answer:

A Hashtable is a collection that stores (Keys, Values) pairs. Here, the Keys are used to find the storage location and is immutable and cannot have duplicate entries in the Hashtable. The .Net Framework has provided a Hash Table class that contains all the functionality required to implement a hash table without any additional development. The hash table is a general-purpose dictionary collection. Each item within the collection is a DictionaryEntry object with two properties: a key object and a value object. These are known as Key/Value. When items are added to a hash table, a hash code is generated automatically. This code is hidden from the developer. All access to the table's values is achieved using the key object for identification. As the items in the collection are sorted according to the hidden hash code, the items should be considered to be randomly ordered.

The Hashtable Collection

The Base Class libraries offers a Hashtable Class that is defined in the System.Collections namespace, so you don't have to code your own hash tables. It processes each key of the hash that you add every time and then uses the hash code to look up the element very quickly. The capacity of a hash table is the number of elements the hash table can hold. As elements are added to a hash table, the capacity is automatically increased as required through reallocation. It is an older .Net Framework type.

Declaring a Hashtable

The Hashtable class is generally found in the namespace called System.Collections. So to execute any of the examples, we have to add using System.Collections; to the source code. The declaration for the Hashtable is:

    Hashtable HT = new Hashtable ();  

For more details follow the link:

    C# .Net : HashTable Class
    Introduction To Hashing and the HashTable Class: Part 3

48. What is LINQ in C#?

Answer:

LINQ stands for Language Integrated Query. LINQ is a data querying methodology which provides querying capabilities to .NET languages with a syntax similar to a SQL query

LINQ has a great power of querying on any source of data. The data source could be collections of objects, database or XML files. We can easily retrieve data from any object that implements the IEnumerable<T> interface.

Advantages of LINQ

    LINQ offers an object-based, language-integrated way to query over data no matter where that data came from. So through LINQ we can query database, XML as well as collections.

    Compile time syntax checking.

    It allows you to query collections like arrays, enumerable classes etc in the native language of your application, like VB or C# in much the same way as you would query a database using SQL.


For more details follow the link:

    Concept of LINQ with C#
    Using LINQ With C# 2012

49. What is File Handling in C#.Net?

Answer:

The System.IO namespace provides four classes that allow you to manipulate individual files, as well as interact with a machine directory structure. The Directory and File directly extends System.Object and supports the creation, copying, moving and deletion of files using various static methods. They only contain static methods and are never instantiated. The FileInfo and DirecotryInfo types are derived from the abstract class FileSystemInfo type and they are typically, employed for obtaining the full details of a file or directory because their members tend to return strongly typed objects. They implement roughly the same public methods as a Directory and a File but they are stateful and the members of these classes are not static.


For more details follow the link:

    File Handling in C# .NET
    File handling in C#

50. What is Reflection in C#.Net?

Answer:

Reflection typically is the process of runtime type discovery to inspect metadata, CIL code, late binding and self-generating code. At run time by using reflection, we can access the same "type" information as displayed by the ildasm utility at design time. The reflection is analogous to reverse engineering in which we can break an existing *.exe or *.dll assembly to explore defined significant contents information, including methods, fields, events and properties.

You can dynamically discover the set of interfaces supported by a given type using the System.Reflection namespace. This namespace contains numerous related types as follows:



Reflection typically is used to dump out the loaded assemblies list, their reference to inspect methods, properties etcetera. Reflection is also used in the external disassembling tools such Reflector, Fxcop and NUnit because .NET tools don't need to parse the source code similar to C++.

Metadata Investigation

The following program depicts the process of reflection by creating a console based application. This program will display the details of the fields, methods, properties and interfaces for any type within the mscorlib.dll assembly. Before proceeeding, it is mandatory to import "System.Reflection".

Here, we are defining a number of static methods in the program class to enumerate fields, methods and interfaces in the specified type. The static method takes a single "System.Type" parameter and returns void.

    static void FieldInvestigation(Type t) {  
        Console.WriteLine("*********Fields*********");  
        FieldInfo[] fld = t.GetFields();  
        foreach(FieldInfo f in fld) {  
            Console.WriteLine("-->{0}", f.Name);  
        }  
    }  
      
    static void MethodInvestigation(Type t) {  
        Console.WriteLine("*********Methods*********");  
        MethodInfo[] mth = t.GetMethods();  
        foreach(MethodInfo m in mth) {  
            Console.WriteLine("-->{0}", m.Name);  
        }  
    }  

1) What is C-Sharp (C#)?
C# is a type-safe, managed and object oriented language, which is compiled by .Net framework for generating intermediate language (IL).
2) Explain the features of C#?
Below are some of the features supported in C# -

    Constructors and Destructors
    Properties
    Passing Parameters
    Arrays
    Main
    XML Documentation and
    Indexers

 
3) List some of the advantages of C#?
Below are the advantages of C# -

    Easy to learn
    Object oriented
    Component oriented
    Part of .NET framework

4) What are IDE’s provided by Microsoft for C# development?
Below are the IDE’s used for C# development –

    Visual Studio Express (VCE)
    Visual Studio (VS)
    Visual Web Developer

 

5) Explain the types of comments in C#?

Below are the types of comments in C# -

    Single Line Comment Eg : //
    Multiline Comments Eg: /* */
    XML Comments Eg : ///

6) Explain sealed class in C#?

Sealed class is used to prevent the class from being inherited from other classes. So “sealed” modifier also can be used with methods to avoid the methods to override in the child classes.

7) Give an example of using sealed class in C#?

Below is the sample code of sealed class in C# -

class X {} 
sealed class Y : X {}

Sealed methods –

class A
{
 protected virtual void First() { }
 protected virtual void Second() { }
}
class B : A
{
 sealed protected override void First() {}
 protected override void Second() { }
}

If any class inherits from class “B” then method – “First” will not be overridable as this method is sealed in class B.


Must Read - .Net Framework Interview Questions and Answers 

8) List out the differences between Array and ArrayList in C#?

    Array stores the values or elements of same data type but arraylist stores values of different datatypes.
    Arrays will use the fixed length but arraylist does not uses fixed length like array.

9) Why to use “using” in C#?

“Using” statement calls – “dispose” method internally, whenever any exception occurred in any method call and in “Using” statement objects are read only and cannot be reassignable or modifiable.

10) Explain namespaces in C#?

Namespaces are containers for the classes. We will use namespaces for grouping the related classes in C#. “Using” keyword can be used for using the namespace in other namespace.

11) Why to use keyword “const” in C#? Give an example.

“Const” keyword is used for making an entity constant. We can’t reassign the value to constant.

Eg: const string _name = "Test";

12) What is the difference between “constant” and “readonly” variables in C#?

    “Const” keyword is used for making an entity constant. We cannot modify the value later in the code. Value assigning is mandatory to constant variables.
    “readonly” variable value can be changed during runtime and value to readonly variables can be assigned in the constructor or at the time of declaration.


Must Read - ADO.Net Interview Questions and Answers 

13) Explain “static” keyword in C#?

“Static” keyword can be used for declaring a static member. If the class is made static then all the members of the class are also made static. If the variable is made static then it will have a single instance and the value change is updated in this instance.

14) What is the difference between “dispose” and “finalize” variables in C#?

    Dispose - This method uses interface – “IDisposable” interface and it will free up both managed and unmanaged codes like – database connection, files etc.
    Finalize - This method is called internally unlike Dispose method which is called explicitly. It is called by garbage collector and can’t be called from the code.

15) How the exception handling is done in C#?

In C# there is a “try… catch” block to handle the error.

16) Can we execute multiple catch blocks in C#?
No. Once any exception is occurred it executes specific exception catch block and the control comes out.
17) Why to use “finally” block in C#?

“Finally” block will be executed irrespective of exception. So while executing the code in try block when exception is occurred, control is returned to catch block and at last “finally” block will be executed. So closing connection to database / releasing the file handlers can be kept in “finally” block.
18) What is the difference between “finalize” and “finally” methods in C#?

    Finalize – This method is used for garbage collection. So before destroying an object this method is called as part of clean up activity.
    Finally – This method is used for executing the code irrespective of exception occurred or not.

 

19) What is the difference between “throw ex” and “throw” methods in C#?

    “throw ex” will replace the stack trace of the exception with stack trace info of re throw point.
    “throw” will preserve the original stack trace info.

20) Can we have only “try” block without “catch” block in C#?

Yes we can have only try block without catch block.

21) List out two different types of errors in C#?

Below are the types of errors in C# -

    Compile Time Error
    Run Time Error

22) Do we get error while executing “finally” block in C#?

Yes. We may get error in finally block.

23) Mention the assembly name where System namespace lies in C#?

Assembly Name – mscorlib.dll

24) What are the differences between static, public and void in C#?

    Static classes/methods/variables are accessible throughout the application without creating instance. Compiler will store the method address as an entry point. 
    Public methods or variables are accessible throughout the application. 
    Void is used for the methods to indicate it will not return any value.


Don't Miss - Database Interview Questions and Answers

25) What is the difference between “out” and “ref” parameters in C#?

“out” parameter can be passed to a method and it need not be initialized where as “ref” parameter has to be initialized before it is used.

26) Explain Jagged Arrays in C#?

If the elements of an array is an array then it’s called as jagged array. The elements can be of different sizes and dimensions.

27) Can we use “this” inside a static method in C#?

No. We can’t use “this” in static method.

28) What are value types in C#?

Below are the list of value types in C# -

    decimal
    int
    byte
    enum
    double
    long
    float


Must Read - SQL Query Interview Questions and Answers

29) What are reference types in C#?

Below are the list of reference types in C# -

    class
    string
    interface
    object

30) Can we override private virtual method in C#?

No. We can’t override private virtual methods as it is not accessible outside the class.

31) Explain access modifier – “protected internal” in C#?
“protected internal” can be accessed in the same assembly and the child classes can also access these methods.
32) In try block if we add return statement whether finally block is executed in C#?

Yes. Finally block will still be executed in presence of return statement in try block.
33) What you mean by inner exception in C#?
Inner exception is a property of exception class which will give you a brief insight of the exception i.e, parent exception and child exception details.
34) Explain String Builder class in C#?
This will represent the mutable string of characters and this class cannot be inherited. It allows us to Insert, Remove, Append and Replace the characters. “ToString()” method can be used for the final string obtained from StringBuilder. For example,

StringBuilder TestBuilder = new StringBuilder("Hello");
TestBuilder.Remove(2, 3); // result - "He"
TestBuilder.Insert(2, "lp"); // result - "Help"
TestBuilder.Replace('l', 'a'); // result - "Heap"

 

35) What is the difference between “StringBuilder” and “String” in C#?

    StringBuilder is mutable, which means once object for stringbuilder is created, it later be modified either using Append, Remove or Replace.
    String is immutable and it means we cannot modify the string object and will always create new object in memory of string type.

36) What is the difference between methods – “System.Array.Clone()” and “System.Array.CopyTo()” in C#?

    “CopyTo()” method can be used to copy the elements of one array to other. 
    “Clone()” method is used to create a new array to contain all the elements which are in the original array.

37) How we can sort the array elements in descending order in C#?

“Sort()” method is used with “Reverse()” to sort the array in descending order.


Also Read - ASP.Net Interview Questions and Answers

38) Explain circular reference in C#?

This is a situation where in, multiple resources are dependent on each other and this causes a lock condition and this makes the resource to be unused.

39) List out some of the exceptions in C#?

Below are some of the exceptions in C# -

    NullReferenceException
    ArgumentNullException
    DivideByZeroException
    IndexOutOfRangeException
    InvalidOperationException
    StackOverflowException etc.

40) Explain Generics in C#?

Generics in c# is used to make the code reusable and which intern decreases the code redundancy and increases the performance and type safety.
Namespace – “System.Collections.Generic” is available in C# and this should be used over “System.Collections” types.

41) Explain object pool in C#?

Object pool is used to track the objects which are being used in the code. So object pool reduces the object creation overhead.


Also Read - ASP.Net MVC Interview Questions and Answers

42) What you mean by delegate in C#?

Delegates are type safe pointers unlike function pointers as in C++. Delegate is used to represent the reference of the methods of some return type and parameters.

43) What are the types of delegates in C#?

Below are the uses of delegates in C# -

    Single Delegate
    Multicast Delegate
    Generic Delegate

44) What are the three types of Generic delegates in C#?

Below are the three types of generic delegates in C# -

    Func
    Action
    Predicate

45) What are the differences between events and delegates in C#?

Main difference between event and delegate is event will provide one more of encapsulation over delegates. So when you are using events destination will listen to it but delegates are naked, which works in subscriber/destination model.

46) Can we use delegates for asynchronous method calls in C#?
Yes. We can use delegates for asynchronous method calls.
47) What are the uses of delegates in C#?
Below are the list of uses of delegates in C# -

    Callback Mechanism
    Asynchronous Processing
    Abstract and Encapsulate method
    Multicasting

 
48) What is Nullable Types in C#?
Variable types does not hold null values so to hold the null values we have to use nullable types. So nullable types can have values either null or other values as well.

Eg: Int? mynullablevar = null;

 

49) Why to use “Nullable Coalescing Operator” (??) in C#?

Nullable Coalescing Operator can be used with reference types and nullable value types. So if the first operand of the expression is null then the value of second operand is assigned to the variable. For example,

double? myFirstno = null;
double mySecno;
mySecno = myFirstno ?? 10.11;

50) What is the difference between “as” and “is” operators in C#?

    “as” operator is used for casting object to type or class.
    “is” operator is used for checking the object with type and this will return a Boolean value.

51) Define Multicast Delegate in C#?

A delegate with multiple handlers are called as multicast delegate. The example to demonstrate the same is given below

public delegate void CalculateMyNumbers(int x, int y);
int x = 6;
int y = 7;
CalculateMyNumbers addMyNumbers = new CalculateMyNumbers(FuncForAddingNumbers);
CalculateMyNumbers multiplyMyNumbers = new CalculateMyNumbers(FuncForMultiplyingNumbers);
CalculateMyNumbers multiCast = (CalculateMyNumbers)Delegate.Combine (addMyNumbers, multiplyMyNumbers);
multiCast.Invoke(a,b);

52) What is the difference between CType and Directcast in C#?

    CType is used for conversion between type and the expression.
    Directcast is used for converting the object type which requires run time type to be the same as specified type.

53) Is C# code is unmanaged or managed code?

C# code is managed code because the compiler – CLR will compile the code to Intermediate Language.

54) Why to use lock statement in C#?

Lock will make sure one thread will not intercept the other thread which is running the part of code. So lock statement will make the thread wait, block till the object is being released.

55) Explain Hashtable in C#?

It is used to store the key/value pairs based on hash code of the key. Key will be used to access the element in the collection. For example,

Hashtable myHashtbl = new Hashtable();
myHashtbl.Add("1", "TestValue1");
myHashtbl.Add("2", "TestValue2");

56) How to check whether hash table contains specific key in C#?

Method – “ContainsKey” can be used to check the key in hash table. Below is the sample code for the same –

Eg: myHashtbl.ContainsKey("1");

57) What is enum in C#?

enum keyword is used for declaring an enumeration, which consists of named constants and it is called as enumerator lists. Enums are value types in C# and these can’t be inherited. Below is the sample code of using Enums

Eg: enum Fruits { Apple, Orange, Banana, WaterMelon};

58) Which are the loop types available in C#?

Below are the loop types in C# -

For
While
Do.. While

59) What is the difference between “continue” and “break” statements in C#?

    “continue” statement is used to pass the control to next iteration. This statement can be used with – “while”, “for”, “foreach” loops.
    “break” statement is used to exit the loop.

60) Write a sample code to write the contents to text file in C#?

Below is the sample code to write the contents to text file –

Using System.IO;
File.WriteAllText(”mytextfilePath”, “MyTestContent”);

61) What you mean by boxing and unboxing in C#?
Boxing – This is the process of converting from value type to reference type. For example,

int myvar = 10;
object myObj = myvar;

UnBoxing – It’s completely opposite to boxing. It’s the process of converting reference type to value type. For example,

int myvar2 = (int)myObj;

62) Explain Partial Class in C#?

Partial classes concept added in .Net Framework 2.0 and it allows us to split the business logic in multiple files with the same class name along with “partial” keyword.
63) Explain Anonymous type in C#?
This is being added in C# 3.0 version. This feature enables us to create an object at compile time. Below is the sample code for the same –

Var myTestCategory = new { CategoryId = 1, CategoryName = “Category1”};

64) Name the compiler of C#?

C# Compiler is – CSC.

65) Explain the types of unit test cases?

Below are the list of unit test case types –

    Positive Test cases
    Negative Test cases
    Exception Test cases

66) Explain Copy constructor in C#?

If the constructor contains the same class in the constructor parameter then it is called as copy constructor.

class MyClass
{
 public string prop1, prop2;
 public MyClass(string a, string b)
 {
 prop1 = a;
 prop2 = b;
 }
 
 public MyClass(MyClass myobj) // Copy Constructor
 {
 prop1 = myobj.prop1;
 prop2 = myobj.prop2;
 }
}

67) Explain Static constructor in C#?

If the constructor is declared as static then it will be invoked only once for all number of instances of a class. Static constructor will initialize the static fields of a class.

class MyClass
{
 public string prop1, prop2;
 public MyClass(string a, string b)
 {
 prop1 = a;
 prop2 = b;
 }

Static MyClass()
 {
 Console.WriteLine(“Static Constr Test”);
 }
 public MyClass(MyClass myobj) // Copy Constructor
 {
 prop1 = myobj.prop1;
 prop2 = myobj.prop2;
 }
}

68) Which string method is used for concatenation of two strings in c#?

“Concat” method of String class is used to concatenate two strings. For example,

string.Concat(firstStr, secStr)

69) Explain Indexers in C#?

Indexers are used for allowing the classes to be indexed like arrays. Indexers will resemble the property structure but only difference is indexer’s accessors will take parameters. For example,

class MyCollection<T>
{
 private T[] myArr = new T[100];
 public T this[int t]
 {
 get
 {
 return myArr[t];
 }
 set
 {
 myArr[t] = value;
 }
 }
}

70) What are the collection types can be used in C#?

Below are the collection types in C# -

    ArrayList
    Stack
    Queue
    SortedList
    HashTable
    Bit Array

71) Explain Attributes in C#?

    Attributes are used to convey the info for runtime about the behavior of elements like – “methods”, “classes”, “enums” etc.
    Attributes can be used to add metadata like – comments, classes, compiler instruction etc.

72) List out the pre defined attributes in C#?

Below are the predefined attributes in C# -

    Conditional
    Obsolete
    Attribute Usage

73) What is Thread in C#?

Thread is an execution path of a program. Thread is used to define the different or unique flow of control. If our application involves some time consuming processes then it’s better to use Multithreading., which involves multiple threads.

74) List out the states of a thread in C#?

Below are the states of thread –

    Unstarted State
    Ready State
    Not Runnable State
    Dead State

75) Explain the methods and properties of Thread class in C#?

Below are the methods and properties of thread class –

    CurrentCulture
    CurrentThread
    CurrentContext
    IsAlive
    IsThreadPoolThread
    IsBackground
    Priority


76) What is a class ?

A class is the generic definition of what an object is. A Class describes all the attributes of the object, as well as the methods that implement the behavior of the member object. In other words, class is a template of an object. For ease of understanding a class, we will look at an example. In the class Employee given below, Name and Salary are the attributes of the class Person. The Setter and Getter methods are used to store and fetch data from the variable.

public class Employee
{
private String name;
private String Salary;
public String getName()
{
  return name;
}
public void setName(String name)
{
  this.name = name; 
}
public String getSalary ()
{
  return Salary;
}
public void setSalary (String Salary)
{
  this. Salary = Salary;
}
} 

 

77) What is an Object?
An object is an instance of a class. It contains real values instead of variables. For example, let us create an instance of the class Employee called “John”.

Employee John= new Employee();
Now we can access all the methods in the class “Employee” via object “John” as shown below.
John.setName(“XYZ”); 

78) What are the Access Modifiers in C# ?
Different Access Modifier are - Public, Private, Protected, Internal, Protected Internal

    Public – When a method or attribute is defined as Public, it can be accessed from any code in the project. For example, in the above Class “Employee” getName() and setName() are public.
    Private - When a method or attribute is defined as Private, It can be accessed by any code within the containing class only. For example, in the above Class “Employee” attributes name and salary can be accessed within the Class Employee Only. If an attribute or class is defined without access modifiers, it's default access modifier will be private.
    Protected - When attribute and methods are defined as protected, it can be accessed by any method in the inherited classes and any method within the same class. The protected access modifier cannot be applied to classes and interfaces. Methods and fields in a interface can't be declared protected.
    Internal – If an attribute or method is defined as Internal, access is restricted to classes within the current project assembly.
    Protected Internal – If an attribute or method is defined as Protected Internal, access is restricted to classes within the current project assembly and types derived from the containing class. 

 

79) Explain Static Members in C# ?

If an attribute's value had to be same across all the instances of the same class, the static keyword is used. For example, if the Minimum salary should be set for all employees in the employee class, use the following code.

private static double MinSalary = 30000;

To access a private or public attribute or method in a class, at first an object of the class should be created. Then by using the object instance of that class, attributes or methods can be accessed. To access a static variable, we don't want to create an instance of the class containing the static variable. We can directly refer that static variable as shown below.

double var = Employee.MinSalary ;

80) What is Reference Type in C# ?

Let us explain this with the help of an example. In the code given below,

Employee emp1;
Employee emp2 = new Employee();
emp1 = emp2;

Here emp2 has an object instance of Employee Class. But emp1 object is set as emp2. What this means is that the object emp2 is referred in emp1, rather than copying emp2 instance into emp1. When a change is made in emp2 object, corresponding changes can be seen in emp1 object. 


81) Define Property in C# ?

Properties are a type of class member, that are exposed to the outside world as a pair of Methods. For example, for the static field Minsalary, we will Create a property as shown below.

private double minimumSalary;
public static double MinSalary
{
 get
 {
   return minimumSalary;
 }
 set
 {
   minimumSalary = value;
 }
}

So when we execute the following lines code

double minSal = Employee.MinSalary;

get Method will get triggered and value in minimumSalary field will be returned. When we execute,

Employee. MinSalary = 3000;

set Method will get triggered and value will be stored in minimumSalary field.

82) Explain Overloading in C# ?

When methods are created with the same name, but with different signature its called overloading. For example, WriteLine method in console class is an example of overloading. In the first instance, it takes one variable. In the second instance, “WriteLine” method takes two variable.

Console.WriteLine(x);
Console.WriteLine("The message is {0}", Message);

Different types of overloading in C# are

    Constructor overloading
    Function overloading
    Operator overloading

83) What is Constructor Overloading in C# .net ?

In Constructor overloading, n number of constructors can be created for the same class. But the signatures of each constructor should vary. For example

public class Employee 
{
 public Employee() 
 { }
 public Employee(String Name) 
 { }
}

84) What is Function Overloading in C# .net ?

In Function overloading, n number of functions can be created for the same class. But the signatures of each function should vary. For example

public class Employee 
{
 public void Employee() 
 { }
 public void Employee(String Name) 
 { }
}

85) What is Operator Overloading in C# .net ?

We had seen function overloading in the previous example. For operator Overloading, we will have a look at the example given below. We had defined a class rectangle with two operator overloading methods.

class Rectangle
{
 private int Height;
 private int Width;

 public Rectangle(int w,int h)
 {
   Width=w;
   Height=h;
 } 
 public static bool operator >(Rectangle a,Rectangle b)
 {
   return a.Height > b.Height ;
 }
 public static bool operator <(Rectangle a,Rectangle b)
 {
   return a.Height < b.Height ;
 } 
}

Let us call the operator overloaded functions from the method given below. When first if condition is triggered, the first overloaded function in the rectangle class will be triggered. When second if condition is triggered, the second overloaded function in the rectangle class will be triggered. 

public static void Main()
{
Rectangle obj1 =new Rectangle();
Rectangle obj2 =new Rectangle();

 if(obj1 > obj2)
 {
  Console.WriteLine("Rectangle1 is greater than Rectangle2");
 } 

 if(obj1 < obj2)
 {
  Console.WriteLine("Rectangle1 is less than Rectangle2");
 }
}

86) What is Data Encapsulation ?

Data Encapsulation is defined as the process of hiding the important fields from the end user. In the above example, we had used getters and setters to set value for MinSalary. The idea behind this is that, private field “minimumSalary” is an important part of our classes. So if we give a third party code to have complete control over the field without any validation, it can adversely affect the functionality. This is inline with the OOPS Concept that an external user should know about the what an object does. How it does it, should be decided by the program. So if a user set a negative value for MinSalary, we can put a validation in the set method to avoid negative values as shown below

set
{
 if(value > 0)
 {
  minSalary = value;
 }
}


87) Explain Inheritance in C# ?
In object-oriented programming (OOP), inheritance is a way to reuse code of existing objects. In inheritance, there will be two classes - base class and derived classes. A class can inherit attributes and methods from existing class called base class or parent class. The class which inherits from a base class is called derived classes or child class. For more clarity on this topic, let us have a look at 2 classes shown below. Here Class Car is Base Class and Class Ford is derived class.

class Car
{
 public Car()
 {
  Console.WriteLine("Base Class Car");
 }

 public void DriveType()
 {
  Console.WriteLine("Right Hand Drive");
 }
}

class Ford : Car
{
 public Ford()
 {
  Console.WriteLine("Derived Class Ford");
 }

 public void Price()
 {
  Console.WriteLine("Ford Price : 100K $");
 }
}

When we execute following lines of code ,

Ford CarFord = new Ford();
CarFord.DriveType();
CarFord.Price();

Output Generated is as given below.

Base Class Car
Derived Class Ford
Right Hand Drive
Ford Price : 100K $

What this means is that, all the methods and attributes of Base Class car are available in Derived Class Ford. When an object of class Ford is created, constructors of the Base and Derived class get invoked. Even though there is no method called DriveType() in Class Ford, we are able to invoke the method because of inheriting Base Class methods to derived class.

88) Can Multiple Inheritance implemented in C# ?

In C#, derived classes can inherit from one base class only. If you want to inherit from multiple base classes, use interface.
 

89) What is Polymorphism in C# ?

The ability of a programming language to process objects in different ways depending on their data type or class is known as Polymorphism. There are two types of polymorphism

    Compile time polymorphism. Best example is Overloading
    Runtime polymorphism. Best example is Overriding

 

90) Explain the use of Virtual Keyword in C# ?

When we want to give permission to a derived class to override a method in base class, Virtual keyword is used. For example. lets us look at the classes Car and Ford as shown below.

class Car
{
 public Car()
 {
  Console.WriteLine("Base Class Car");
 }
 public virtual void DriveType()
 {
  Console.WriteLine("Right Hand Drive");
 }
}

class Ford : Car
{
 public Ford()
 {
  Console.WriteLine("Derived Class Ford");
 }
 public void Price()
 {
  Console.WriteLine("Ford Price : 100K $");
 }
 public override void DriveType()
 {
  Console.WriteLine("Right Hand ");
 }
}

When following lines of code get executed 

Car CarFord = new Car();
CarFord.DriveType();
CarFord = new Ford();
CarFord.DriveType();

Output is as given below.

Base Class Car
Right Hand Drive
Base Class Car
Derived Class Ford
Right Hand

91) What is overriding in c# ?

To override a base class method which is defined as virtual, Override keyword is used. In the above example, method DriveType is overridden in the derived class.

92) What is Method Hiding in C# ?
If the derived class doesn't want to use methods in the base class, derived class can implement it's own version of the same method with same signature. For example, in the classes given below, DriveType() is implemented in the derived class with same signature. This is called Method Hiding.

class Car
{
 public void DriveType()
 {
  Console.WriteLine("Right Hand Drive");
 }
}

class Ford : Car
{
 public void DriveType()
 {
  Console.WriteLine("Right Hand ");
 }
}


93) What is Abstract Class in C#?
If we don't want a class to be instantiated, define the class as abstract. An abstract class can have abstract and non abstract classes. If a method is defined as abstract, it must be implemented in derived class. For example, in the classes given below, method DriveType is defined as abstract. 

abstract class Car
{
 public Car()
 {
  Console.WriteLine("Base Class Car");
 }
 public abstract void DriveType();
}

class Ford : Car
{
 public void DriveType()
 {
  Console.WriteLine("Right Hand ");
 }
}

Method DriveType get implemented in derived class.

94) What is Sealed Classes in c# ?
If a class is defined as Sealed, it cannot be inherited in derived class. Example of a sealed class is given below.

public sealed class Car
{
 public Car()
 {
  Console.WriteLine("Base Class Car");
 }

 public void DriveType()
 {
  Console.WriteLine("Right Hand ");
 }
} 


95) What is an Interface in C# ?

An interface is similar to a class with method signatures. There wont be any implementation of the methods in an Interface. Classes which implement interface should have an implementation of methods defined in the abstract class.

96) What is a Constructor in C# ?

Constructor is a special method that get invoked/called automatically, whenever an object of a given class gets instantiated. In our class car, constructor is defined as shown below

public Car()
{
 Console.WriteLine("Base Class Car");
}

When ever an instance of class car is created from the same class or its derived class(Except Few Scenarios), Constructor get called and sequence of code written in the constructor get executed.

interface Breaks
{
 void BreakType();
}

interface Wheels
{
 void WheelType();
}

class Ford : Breaks, Wheels
{
 public Ford()
 {
  Console.WriteLine("Derived Class Ford");
 }
 public void Price()
 {
  Console.WriteLine("Ford Price : 100K $");
 }
 public void BreakType()
 {
  Console.WriteLine("Power Break");
 }
 public void WheelType()
 {
  Console.WriteLine("Bridgestone");
 }
}


97) What is a Destructor in C# ? 

Destructor is a special method that get invoked/called automatically whenever an object of a given class gets destroyed. Main idea behind using destructor is to free the memory used by the object.