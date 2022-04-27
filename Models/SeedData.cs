using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Collections.Generic;

namespace AssetASP.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AssetDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<AssetDbContext>>()))
                {
                    if (context.Users.Any())
                    {
                        return; // DB has been seeded
                    }

                    context.Users.AddRange(
                        new User
                        {
                            FirstName ="John",
                            LastName = "Hernandez",
                            Assets = new List<Asset> {
                                new Asset {DeviceName = "JAS-103-STA-01", DeviceType = "Desktop", Description = "Workstation Computer"},
                                new Asset {DeviceName = "Monitor-01", DeviceType = "Monitor", Description = "Workstation Monitor"},
                                new Asset {DeviceName = "JAS-103-PRI-01", DeviceType = "Printer", Description = "Workstation Printer"}
                            }
                        },

                        new User
                        {
                            FirstName ="Silas",
                            LastName = "Hernandez",
                            Assets = new List<Asset> {
                                new Asset {DeviceName = "SIL-104-STA-01", DeviceType = "Desktop", Description = "Workstation Computer"},
                                new Asset {DeviceName = "Monitor-02", DeviceType = "Monitor", Description = "Workstation Monitor"},
                                new Asset {DeviceName = "SIL-104-PRI-01", DeviceType = "Printer", Description = "Workstation Printer"}
                            }
                            
                        },
                        new User
                        {
                            FirstName ="Yosi",
                            LastName = "Moralez",
                            Assets = new List<Asset> {
                                new Asset {DeviceName = "SOS-105-STA-01", DeviceType = "Desktop", Description = "Workstation Computer"},
                                new Asset {DeviceName = "Monitor-03", DeviceType = "Monitor", Description = "Workstation Monitor"},
                                new Asset {DeviceName = "SOS-105-PRI-01", DeviceType = "Printer", Description = "Workstation Printer"}
                            }
                        },

                        new User
                        {
                            FirstName ="Enrique",
                            LastName = "Flores",
                            Assets = new List<Asset> {
                                new Asset {DeviceName = "ENR-105-STA-01", DeviceType = "Desktop", Description = "Workstation Computer"},
                                new Asset {DeviceName = "Monitor-04", DeviceType = "Monitor", Description = "Workstation Monitor"},
                                new Asset {DeviceName = "SIL-105-PRI-01", DeviceType = "Printer", Description = "Workstation Printer"}
                            }
                        },

                        new User
                        {
                            FirstName ="William",
                            LastName = "Wray",
                            Assets = new List<Asset> {
                                new Asset {DeviceName = "WRA-106-STA-01", DeviceType = "Desktop", Description = "Workstation Computer"},
                                new Asset {DeviceName = "Monitor-05", DeviceType = "Monitor", Description = "Workstation Monitor"},
                                new Asset {DeviceName = "WRA-106-PRI-01", DeviceType = "Printer", Description = "Workstation Printer"}
                            }
                        }
                    );

                    context.SaveChanges();

                    if (context.Assets.Any())
                    {
                        return; // DB has been seeded
                    }
                }
        }
    }
}