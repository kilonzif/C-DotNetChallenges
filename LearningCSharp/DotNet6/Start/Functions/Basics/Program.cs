using System;

// Functions are used to group re-usable code together in a single
// unit that can be customized with parameters.

// TODO: Functions have a return type, name, and optional parameters
string getName(string firstname, string lastname){
    return $"{firstname}{lastname}";
}

// TODO: A function with no return value has a 'void' type
void printName(){
    Console.WriteLine("Hello World!");
}

// TODO: Call first function
getName("John","Doe");

// TODO: Call second function

printName();