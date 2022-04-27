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
                                new Asset {DeviceName = "JAS-103-STA-01", DeviceType = "Desktop", Description = "Workstation Computer"}
                            }
                        },

                        new User
                        {
                            FirstName ="Silas",
                            LastName = "Hernandez"
                        },
                        new User
                        {
                            FirstName ="Yosi",
                            LastName = "Moralez"
                        },

                        new User
                        {
                            FirstName ="Enrique",
                            LastName = "Flores"
                        },

                        new User
                        {
                            FirstName ="William",
                            LastName = "Wray"
                        }
                    );

                    context.SaveChanges();

                    if (context.Assets.Any())
                    {
                        return; // DB has been seeded
                    }

                    context.Assets.AddRange(
                        new Asset
                        {
                            DeviceName = "JH-STA-01",
                            DeviceType = "Computer",
                            Description = "Computer used as a workstation"
                        }
                    );
                    context.SaveChanges();
                }
        }
    }
}