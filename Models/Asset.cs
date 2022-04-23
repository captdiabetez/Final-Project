using System;

namespace AssetASP.Models
{
    public class Asset 
    {
        public int AssetTagId {get; set;}
        public string DeviceName {get; set;}
        public string DeviceType {get; set;}
        public string Description {get; set;}
        public User User {get; set;}
        public int UserId {get; set;} // Foreign Key
    }
}