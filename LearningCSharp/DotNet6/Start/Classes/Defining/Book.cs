using System;

namespace Defining
{
    // classes have a name, unique within the namespace
    public class Book
    {
        // TODO: classes have member variables, or "fields" to hold data

        string _name;
        string _author;
        int _pageCount;

        // TODO: classes have one or more constructors
        public Book( string name,string author, int pageCount){
            _name = name;
           _author = author;
            _pageCount = pageCount;

        }


        // TODO: methods are used to operate on the class and data
        public void getBookDesc(){
            Console.WriteLine($"{_name} by {_author} and has {_pageCount} pages")
        }

    }
}
