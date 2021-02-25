# CarRental - Car Rental Project

## :pushpin:Getting Started
An exemplary project for Car Rental workplaces, which is prepared with N-Layered architecture. The project developed using SOLID design principles in the CSharp programming language. CRUD operations are performed using Entity Framework Core.
## :books:Layers  
<!--![entities](https://user-images.githubusercontent.com/77868230/107870096-c5609600-6ea6-11eb-82e6-8e797c8a3617.png)-->
### Entities Layer
The entities layer is a layer where we store our database data. We have three folders **Abstract**, **Concrete** and **DTOs** in the Entities layer.
The abstract folder is used to store abstract objects (e.g Interfaces) while the concrete folder is used to store concrete objects (e.g Classes).The DTOs folder is used to store *Data Transmission Objects* (CarDetailDto)
<br><br>📂`Abstract`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: ~~IEntity.cs~~
<br> <br>📂`Concrete`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 *[Brand.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Entities/Concrete/Brand.cs)*    
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 *[Car.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Entities/Concrete/Car.cs)*    
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 *[Color.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Entities/Concrete/Color.cs)*    
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 *[Customer.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Entities/Concrete/Customer.cs)*  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 *[Rental.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Entities/Concrete/Rental.cs)*  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 *[User.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Entities/Concrete/User.cs)*  
<br>:file_folder:`DTOs`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 *[CarDetailDto.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Entities/DTOs/RentalDetailDto.cs)*  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 *[RentalDetailDto.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Entities/DTOs/RentalDetailDto.cs)*  
<br> 
###  Business Layer
This layer coordinates the application, processes commands, makes logical decisions and evaluations, and performs calculations. It also moves and processes data between the two surrounding layers -DataAccess and Presentation. We have 5 folders **Abstract**, **Concrete**, **Constants**, **Dependency Resolvers** and **ValidationRules** in the Business Layer.
<br><br>📂`Abstract`    
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 *[IBrandService.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Business/Abstract/IBrandService.cs)*   
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 *[ICarService.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Business/Abstract/ICarService.cs)*   
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 *[IColorService.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Business/Abstract/IColorService.cs)*   
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 *[ICustomerService.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Business/Abstract/ICustomerService.cs)*   
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 *[IUserService.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Business/Abstract/IUserService.cs)* 
<br><br>📂`Concrete`    
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 *[BrandManager.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Business/Concrete/BrandManager.cs)*   
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 *[CarManager.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Business/Concrete/CarManager.cs)*   
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 *[ColorManager.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Business/Concrete/ColorManager.cs)*   
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 *[CustomerManager.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Business/Concrete/CustomerManager.cs)*   
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 *[UserManager.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Business/Concrete/UserManager.cs)*
<br><br>📂`Constants`    
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 *[Messages.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Business/Constants/Messages.cs)*
<br>📂`DependencyResolvers`    
&nbsp;📂`Autofac`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃[AutofacBusinessModule.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Business/DependencyResolvers/Autofac/AutofacBusinessModule.cs)

## Tables in Database

<table>
  <tr>
    <td>Cars</td>
     <td>Rentals</td>
     <td>Users</td>
  </tr>
  <tr>
    <td>

 
| Variable Name | Data Type    |
| ------------- | ------------ |
| Id            | int          |
| BrandId       | int          |
| ColorId       | int          |
| ModelYear     | int          |
| DailyPrice    | decimal      |
| Description   | nvarchar(50) |

   </td>
    <td>

| Variable Name | Data Type |
| ------------- | --------- |
| Id            | int       |
| CarId         | int       |
| CustomerId    | int       |
| RentDate      | datetime  |
| ReturnDate    | datetime  |

   </td>
    <td>

| Variable Name | Data Type    |
| ------------- | ------------ |
| Id            | int          |
| FirstName     | nvarchar(50) |
| LastName      | nvarchar(50) |
| Email         | nvarchar(50) |
| Password      | nvarchar(50) |

   </td>
  </tr>
 </table>

<table>
  <tr>
    <td>Customers</td>
     <td>Brands</td>
     <td>Colors</td>
  </tr>
  <tr>
    <td>

| Variable Name | Data Type    |
| ------------- | ------------ |
| UserId        | int          |
| CustomerName  | nvarchar(50) |

   </td>
    <td>

| Variable Name | Data Type    |
| ------------- | ------------ |
| Id            | int          |
| BrandName     | nvarchar(50) |

   </td>
    <td>

| Variable Name | Data Type    |
| ------------- | ------------ |
| Id            | int          |
| ColorName     | nvarchar(50) |

   </td>
  </tr>
 </table>
