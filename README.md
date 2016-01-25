"# ShoppingCartAppMVC" 
This is my first MVC5 Entity Framework website. I am currently using a repository pattern to hold my code and structure in place. Following Technologies used:-
+ ASP.NET MVC5 && Enitiy Framework 
+ LINQ
+ SQL Server (Backend)
+ Dependancy Injection (Ninject)
+ Some Twitter bootstrap
+ Moq

To make the application work please change your webconfig to point to your SQL Server. Entity Framework will do the rest :). Once the tables are created please add your products or simply got to the http://localhost:3288/Admin/Index where you can add items.

http://localhost:3288/Account/Login - Need to add a username and password to teh users table to ensure that you can enter the website.

Still need some developing. But this is a back bone of the application for now. You add,edit,delete items. You can checkout an item, You may need to set a email address so that you can get confimation of perchase. This can be done under the EmailSetting.cs/Concrete folder.


