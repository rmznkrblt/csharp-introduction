# Methods

A method is a block of code which only runs when it is called. Methods are generally the block of codes or statements in a program that gives the user the ability to reuse the same code which ultimately saves the excessive use of memory, acts as a time saver and more importantly, it provides a better readability of code. So basically, a method is a collection of statements that perform some specific task and return the result to the caller. A method can also perform some specific task without returning anything.

## Defining Methods in C#

![image](https://media.geeksforgeeks.org/wp-content/uploads/methods-in-java.png "Defining Methods")

 ```Modifier``` − This determines the visibility of a variable or a method from another class.

 `Return type` − A method may return a value. The return type is the data type of the value the method returns. If the method is not returning any values, then the return type is void.

 `Method name` − Method name is a unique identifier and it is case sensitive. It cannot be same as any other identifier declared in the class.

 `Parameter list` − Enclosed between parentheses, the parameters are used to pass and receive data from a method. The parameter list refers to the type, order, and number of the parameters of a method. Parameters are optional; that is, a method may contain no parameters.

`Method body` − This contains the set of instructions needed to complete the required activity.

## Call a Method
To call (execute) a method, write the method's name followed by two parentheses () and a semicolon;
>methodName();

### If it is a parameterized method;

> methodName(parameters);

## Types of methods

1. ` Function with no argument and no return value:` When a function has no arguments, it does not receive any data from the calling function. Similarly when it does not return a value, the calling function does not receive any data from the called function.
   > static `void` function();
1. `Function with arguments but no return value:` When a function has arguments, it receive any data from the calling function but it returns no values.
   > static `void` function (`parameters-types`);
1. `Function with no arguments but returns a value:` There could be occasions where we may need to design functions that may not take any arguments but returns a value to the calling function. A example for this is getchar function it has no parameters but it returns an integer an integer type data that represents a character.
   > static `return-type` function();

1. `Function with arguments and return value `
   > static `return-type` function (`parameters-types);`
## Recursive Functions
In programming terms a recursive function can be defined as a routine that calls itself directly or indirectly.
Using recursive algorithm, certain problems can be solved quite easily.

<br>

![recursive functions](https://media.geeksforgeeks.org/wp-content/cdn-uploads/Recursive-Functions-in-c.png "Recursive Functions")

## Method Overloading

Method Overloading is the common way of implementing polymorphism. It is the ability to redefine a function in more than one form. A user can implement function overloading by defining two or more functions in a class sharing the same name. C# can distinguish the methods with different method signatures. i.e. the methods can have the same name but with different parameters list (i.e. the number of the parameters, order of the parameters, and data types of the parameters) within the same class.

![Method Overloading](https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTAA-4lIpoGCpLKcb9woJYOo23zo1fNUsskpA&usqp=CAU "Method Overloading")

## Why do we need Method Overloading ??

If we need to do the same kind of the operation in different ways i.e. for different inputs. In the example described below, we are doing the addition operation for different inputs. It is hard to find many different meaningful names for single action.
