using System;
class library{
static string [] books={"CPP","Python","Java"};
static string [] users={"Benvin","Yuta","Luffy"};
public void search_book(string b){
try{
for(int i=0;i< books.GetLength(0);i++){
if(b == books[i]){
   Console.WriteLine("Book Found!");
   break;
}
if(i == books.GetLength(0)-1 && b!=books[i]){
   throw new NoBookException();
}
}
}
catch(NoBookException e){
Console.WriteLine("ERROR: " + e);
}
}
public void user_valdation(string u){
try{
for(int i=0;i< users.GetLength(0);i++){
if(u == users[i]){
   Console.WriteLine("User Found!");
   break;
}
if(i == users.GetLength(0)-1 && u!=books[i]){
   throw new NoUserException();
}
}
}
catch(NoUserException e){
   Console.WriteLine("ERROR: " + e);
}
}
}
class NoBookException:ApplicationException{
public override string Message{
get{
   return string.Format("Book not Found");
}
}
}
class NoUserException:ApplicationException{
public override string Message{
get{
   return string.Format("User not Found");
}
}
}
namespace MyApp 
{
internal class Program
{
static void Main(string[] args)
{
   Console.WriteLine("Library Management system");
   int ch;
   library ob1 = new library();
   do{
       Console.WriteLine("Menu\n 1.Search Book\n 2.Search User validity\n 3.Exit");
       ch = int.Parse(Console.ReadLine());
       if(ch==1){
           Console.WriteLine("Enter the book to be searched");
           string b = Console.ReadLine();
           ob1.search_book(b);
       }
       else if(ch==2){
           Console.WriteLine("Enter the User to be searched");
           string u = Console.ReadLine();
           ob1.user_valdation(u);
       }
   }while(ch!=3);
}
}
}