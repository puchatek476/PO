using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplikacja_GOT_PTTK.Models;

namespace Aplikacja_GOT_PTTK.Data
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<PathModel>().HasData(
            //    new PathModel()
            //    {

            //    });
            modelBuilder.Entity<GeoPointModel>().HasData(
                new GeoPointModel()
                {
                    GeoPointId = 3,
                    Latitude = "50.91173",
                    Longitude = "15.28898",
                    Name = "Czerniawska Kopa",
                    Height = "776",
                },
                  new GeoPointModel()
                  {
                      GeoPointId = 4,
                      Latitude = "50.82309",
                      Longitude = "15.51584",
                      Name = "Wysoka",
                      Height = "816",
                  },
                    new GeoPointModel()
                    {
                        GeoPointId = 5,
                        Latitude = "50.87182",
                        Longitude = "15.58584",
                        Name = "Bobrowe Skały",
                        Height = "699",
                    },
                      new GeoPointModel()
                      {
                          GeoPointId = 6,
                          Latitude = "50.84025",
                          Longitude = "15.56191",
                          Name = "Orle",
                          Height = "825",
                      },
                        new GeoPointModel()
                        {
                            GeoPointId = 7,
                            Latitude = "50.83227",
                            Longitude = "15.53487",
                            Name = "Sowiniec",
                            Height = "675",
                        },
                           new GeoPointModel()
                           {
                               GeoPointId = 8,
                               Latitude = "51.17568",
                               Longitude = "20.76652",
                               Name = "Altana",
                               Height = "408",
                           },
                              new GeoPointModel()
                              {
                                  GeoPointId = 9,
                                  Latitude = "50.78784",
                                  Longitude = "15.51387",
                                  Name = "Przełęcz Mokra",
                                  Height = "940",
                              },
                                 new GeoPointModel()
                                 {
                                     GeoPointId = 10,
                                     Latitude = "51.06359",
                                     Longitude = "20.68944",
                                     Name = "Świnia Góra",
                                     Height = "390",
                                 },
                                    new GeoPointModel()
                                    {
                                        GeoPointId = 11,
                                        Latitude = "50.79257",
                                        Longitude = "15.51307",
                                        Name = "Szrenica",
                                        Height = "1362",
                                    },
                                       new GeoPointModel()
                                       {
                                           GeoPointId = 12,
                                           Latitude = "50.75985",
                                           Longitude = "15.68335",
                                           Name = "Słonecznik",
                                           Height = "1423",
                                       }


                );

        }
    }
}
