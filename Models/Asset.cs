using System;

namespace AssetASP.Models
{
    public class Asset 
    {
        public int AssetId {get; set;}  // Primary Key
        public string DeviceName {get; set;}
        public string DeviceType {get; set;}
        public string Description {get; set;}
        public User User {get; set;} // Navigation Property
        public int UserId {get; set;} // Foreign Key
    }
}