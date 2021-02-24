# CarRental - Car Rental Project

## :pushpin:Getting Started
An exemplary project for Car Rental workplaces, which is prepared with N-Layered architecture. The project developed using SOLID design principles in the CSharp programming language. CRUD operations are performed using Entity Framework Core.
## :books:Layers  
<!--![entities](https://user-images.githubusercontent.com/77868230/107870096-c5609600-6ea6-11eb-82e6-8e797c8a3617.png)-->
### Entities Layer
The entities layer is a layer where we store our database data. We have three folders **Abstract**, **Concrete** and **DTOs** in the Entities layer.
The abstract folder is used to store abstract objects (e.g Interfaces) while the concrete folder is used to store concrete objects (e.g Classes).The DTOs folder is used to store *Data Transmission Objects* (CarDetailDto)
<br><br>:file_folder:`Abstract`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: ~~IEntity.cs~~
<br> <br> :file_folder:`Concrete`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: *[Brand.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Entities/Concrete/Brand.cs)*    
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: *[Car.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Entities/Concrete/Car.cs)*    
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: *[Color.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Entities/Concrete/Color.cs)*    
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: *[Customer.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Entities/Concrete/Customer.cs)*  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: *[Rental.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Entities/Concrete/Rental.cs)*  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: *[User.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Entities/Concrete/User.cs)*  
<br>:file_folder:`DTOs`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: *[CarDetailDto.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Entities/DTOs/RentalDetailDto.cs)*  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: *[RentalDetailDto.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Entities/DTOs/RentalDetailDto.cs)*  
<br> 
###  Business Layer
This layer coordinates the application, processes commands, makes logical decisions and evaluations, and performs calculations. It also moves and processes data between the two surrounding layers -DataAccess and Presentation. We have 5 folders **Abstract**, **Concrete**, **Constants**, **Dependency Resolvers** and **ValidationRules** in the Business Layer.
<br><br>:file_folder:`Abstract`    
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: *[IBrandService.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Business/Abstract/IBrandService.cs)*   
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: *[ICarService.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Business/Abstract/ICarService.cs)*   
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: *[IColorService.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Business/Abstract/IColorService.cs)*   
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: *[ICustomerService.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Business/Abstract/ICustomerService.cs)*   
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: *[IUserService.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Business/Abstract/IUserService.cs)* 
<br><br>:file_folder:`Concrete`    
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: *[BrandManager.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Business/Concrete/BrandManager.cs)*   
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: *[CarManager.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Business/Concrete/CarManager.cs)*   
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: *[ColorManager.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Business/Concrete/ColorManager.cs)*   
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: *[CustomerManager.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Business/Concrete/CustomerManager.cs)*   
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: *[UserManager.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Business/Concrete/UserManager.cs)*
<br><br>:file_folder:`Constants`    
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: *[Messages.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Business/Constants/Messages.cs)*
<br><br>:file_folder:`DependencyResolvers`    
&nbsp;&nbsp;&nbsp;:file_folder:`Autofac`
