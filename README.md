# CarRental - Car Rental Project

## :pushpin:Getting Started
An exemplary project for Car Rental workplaces, which is prepared with N-Layered architecture. The project developed using SOLID design principles in the CSharp programming language. CRUD operations are performed using Entity Framework Core.
## :books:Layers  
<!--![entities](https://user-images.githubusercontent.com/77868230/107870096-c5609600-6ea6-11eb-82e6-8e797c8a3617.png)-->
### Entities Layer
The entities layer is a layer where we store our database data. We have three folders **Abstract**, **Concrete** and **DTOs** in the Entities layer.
The abstract folder is used to store abstract objects (e.g Interfaces) while the concrete folder is used to store concrete objects (e.g Classes).The DTOs folder is used to store *Data Transmission Objects* (CarDetailDto)
<br><br>📂`Abstract`  
&nbsp;&nbsp;&nbsp;📃 ~~IEntity.cs~~
<br> <br>📂`Concrete`  
&nbsp;&nbsp;&nbsp;📃 *[Brand.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Entities/Concrete/Brand.cs)*    
&nbsp;&nbsp;&nbsp;📃 *[Car.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Entities/Concrete/Car.cs)*    
&nbsp;&nbsp;&nbsp;📃 *[Color.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Entities/Concrete/Color.cs)*    
&nbsp;&nbsp;&nbsp;📃 *[Customer.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Entities/Concrete/Customer.cs)*  
&nbsp;&nbsp;&nbsp;📃 *[Rental.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Entities/Concrete/Rental.cs)*  
&nbsp;&nbsp;&nbsp;📃 *[User.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Entities/Concrete/User.cs)*  
<br>📂`DTOs`  
&nbsp;&nbsp;&nbsp;📃 *[CarDetailDto.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Entities/DTOs/RentalDetailDto.cs)*  
&nbsp;&nbsp;&nbsp;📃 *[RentalDetailDto.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Entities/DTOs/RentalDetailDto.cs)*  
<br> 
###  Business Layer
This layer coordinates the application, processes commands, makes logical decisions and evaluations, and performs calculations. It also moves and processes data between the two surrounding layers -DataAccess and Presentation. We have 5 folders **Abstract**, **Concrete**, **Constants**, **Dependency Resolvers** and **ValidationRules** in the Business Layer.
<br><br>📂`Abstract`    
&nbsp;&nbsp;&nbsp;📃 *[IBrandService.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Business/Abstract/IBrandService.cs)*   
&nbsp;&nbsp;&nbsp;📃 *[ICarService.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Business/Abstract/ICarService.cs)*   
&nbsp;&nbsp;&nbsp;📃 *[IColorService.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Business/Abstract/IColorService.cs)*   
&nbsp;&nbsp;&nbsp;📃 *[ICustomerService.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Business/Abstract/ICustomerService.cs)*   
&nbsp;&nbsp;&nbsp;📃 *[IUserService.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Business/Abstract/IUserService.cs)* 
<br><br>📂`Concrete`    
&nbsp;&nbsp;&nbsp;📃 *[BrandManager.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Business/Concrete/BrandManager.cs)*   
&nbsp;&nbsp;&nbsp;📃 *[CarManager.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Business/Concrete/CarManager.cs)*   
&nbsp;&nbsp;&nbsp;📃 *[ColorManager.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Business/Concrete/ColorManager.cs)*   
&nbsp;&nbsp;&nbsp;📃 *[CustomerManager.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Business/Concrete/CustomerManager.cs)*   
&nbsp;&nbsp;&nbsp;📃 *[UserManager.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Business/Concrete/UserManager.cs)*
<br><br>📂`Constants`    
&nbsp;&nbsp;&nbsp;📃 *[Messages.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Business/Constants/Messages.cs)*
<br><br>📂`DependencyResolvers`    
&nbsp;&nbsp;&nbsp;&nbsp;📂`Autofac`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; *📃 [AutofacBusinessModule.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Business/DependencyResolvers/Autofac/AutofacBusinessModule.cs)*
<br><br>📂`ValidationRules`<br>
&nbsp;&nbsp;&nbsp;&nbsp;📂`FluentValidation`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; *📃 [BrandValidator.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Business/ValidationRules/FluentValidation/BrandValidator.cs)*<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; *📃 [CarValidator.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Business/ValidationRules/FluentValidation/CarValidator.cs)*<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; *📃 [ColorValidator.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Business/ValidationRules/FluentValidation/ColorValidator.cs)*<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; *📃 [CustomerValidator.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Business/ValidationRules/FluentValidation/CustomerValidator.cs)*<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; *📃 [RentalValidator.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Business/ValidationRules/FluentValidation/RentalValidator.cs)*<br>

###  Core Layer
<br>📂`Aspects`<br>
&nbsp;&nbsp;&nbsp;📂`Autofac`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂`Validation`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; *📃 [ValidationAspect.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Core/Aspects/Autofac/Validation/ValidationAspect.cs)*
<br><br>📂`Business`<br>
&nbsp;&nbsp;&nbsp; *📃 [IService.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Core/Business/IService.cs)*
<br><br>📂`CrossCuttingConcerns`<br>
&nbsp;&nbsp;&nbsp;📂`Validation`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; *📃 [ValidationTool.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Core/CrossCuttingConcerns/Validation/ValidationTool.cs)*
<br><br>📂`DataAccess`<br>
&nbsp;&nbsp;&nbsp;📂`EntityFramework`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; *📃 [EfEntityRepositoryBase.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Core/DataAccess/EntityFramework/EfEntityRepositoryBase.cs)*<br>
&nbsp;&nbsp;&nbsp; *📃 [IEntityRepository.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Core/DataAccess/IEntityRepository.cs)*
<br><br>📂`Entities`<br>
&nbsp;&nbsp;&nbsp; *📃 [IDto.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Core/Entities/IDto.cs)*<br>
&nbsp;&nbsp;&nbsp; *📃 [IEntity.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Core/Entities/IEntity.cs)*
<br><br>📂`Utilities`<br>
&nbsp;&nbsp;&nbsp;📂`Interceptors`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; *📃 [AspectInterceptorSelector.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Core/Utilities/Interceptors/AspectInterceptorSelector.cs)*<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; *📃 [MethodInterception.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Core/Utilities/Interceptors/MethodInterception.cs)*<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; *📃 [MethodInterceptionBaseAttribute.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Core/Utilities/Interceptors/MethodInterceptionBaseAttribute.cs)*<br>
&nbsp;&nbsp;&nbsp;📂`Results`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; *📃 [DataResult.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Core/Utilities/Results/DataResult.cs)*<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; *📃 [ErrorResult.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Core/Utilities/Results/ErrorResult.cs)*<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; *📃 [ErrorDataResult.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Core/Utilities/Results/ErrorDataResult.cs)*<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; *📃 [IDataResult.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Core/Utilities/Results/IDataResult.cs)*<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; *📃 [IResult.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Core/Utilities/Results/IResult.cs)*<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; *📃 [Result.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Core/Utilities/Results/Result.cs)*<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; *📃 [SuccessDataResult.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Core/Utilities/Results/SuccessDataResult.cs)*<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; *📃 [SuccessResult.cs](https://github.com/tofigamraslanov/CarRental/blob/master/Core/Utilities/Results/SuccessResult.cs)*<br>

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
