using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
namespace Packt.Shared;
public class Book
{

    // Needs .Net 7 or later as well as C# 11 or later
    public required string? Isbn { get; set; }
    public required string? Title { get; set; }
    public string? Author { get; set; }
    public int? PageCount { get; set; }
/*
 * All three string properties are nullable.
 * Setting a property or feild to be required does not mean it cannot be null.
 * It just means that it must be explicitly set to null.
 */

    // constructor
    public Book() {
       
    } // for use with initialization syntax

   /* [SetsRequiredMembers]*/ // for setting the values of required members
     public Book(/*string? isbn, string? title,*/ string auth)
    {
        //Isbn = isbn;
        //Title = title;
        Author = auth;
    }
}