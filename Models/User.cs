using System;
using System.Collections.Generic;

namespace AssetASP.Models
{
    public class User 
    {
        public int UserId {get; set;} //Primary Key
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public List<Asset> Assets {get; set;}
    }
}