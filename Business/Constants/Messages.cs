using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Car added";
        public static string CarUpdated = "Car updated";
        public static string CarDeleted = "Car deleted";
        public static string CarValidate = "The daily price of car must be greater than zero";

        public static string BrandAdded = "Brand added";
        public static string BrandUpdated = "Brand updated";
        public static string BrandDeleted = "Brand deleted";
        public static string BrandValidate = "The name of car must be at least 2 characters";

        public static string ColorAdded = "Color added";
        public static string ColorUpdated = "Color updated";
        public static string ColorDeleted = "Color deleted";
        //public static string ColorValidate = "The daily price of car must be greater than zero";

        public static string RentalAdded = "Rental added";
        public static string RentalUpdated = "Rental updated";
        public static string RentalDeleted = "Rental deleted";
        public static string RentalValidate = "The car is in use";

        public static string CustomerAdded = "Customer added";
        public static string CustomerUpdated = "Customer updated";
        public static string CustomerDeleted = "Customer deleted";

        public static string UserAdded = "User added";
        public static string UserUpdated = "User updated";
        public static string UserDeleted = "User deleted";

        public static string CarImageAdded = "Car image added";
        public static string CarImageUpdated = "Car image updated";
        public static string CarImageDeleted = "Car image deleted";
        public static string CarDailyPriceIncorrect = "Car daily price incorrect";
        public static string CarImageCountExceeded = "Car image count exceeded";
        public static string IncorrectFileExtension = "Incorrect file extension";
        public static string CarIdDoesNotExist = "CarId does not exist";
        public static string CarImageNotFound = "Car image not found";

        public static string UserNotFound = "User not found";
        public static string PasswordError = "Password error";
        public static string SuccessfulLogin = "Successful login";
        public static string UserAlreadyExists = "User already exists";
        public static string Registered = "User registered";
        public static string AccessTokenCreated = "Access token created";
        public static string AuthorizationDenied = "Authorization denied";
    }
}
