using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product is successfully added";
        public static string ProductNameInvalid = "Product name is invalid";
        public static string MaintenanceTime = "Sytem is in maintenance";
        public static string ProductListed = "Products are listed";
        public static string ProductCountOfCategoryError = "There can be 10 products in a category";
        public static string ProductNameAlreadyExists = "There is already a product with this name";
        public static string CategoryLimitExceded="There are more than 15 categories";
        public static string AuthorizationDenied = "User name or password is incorrect";
        public static string UserRegistered="User is registered";
        public static string UserNotFound = "There is no user";
        public static string PasswordError = "Incorrect password";
        public static string SuccessfulLogin = "Login is success";
        public static string UserAlreadyExists = "This username is used";
        public static string AccessTokenCreated = "Token is generated";
    }
}
