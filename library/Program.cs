// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// loanable  book = new loanable();
 book  book = new book("maze Runner","77777",2676766);

 dvd dvd = new dvd("whatever",787);


book.Display();
book.checkin();
book.Display();
book.checkout();
book.Display();
book.showbookDetails();

dvd.showdvdDetails();

