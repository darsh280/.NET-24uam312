using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;
using ParkingSlotManagement.Models;

namespace ParkingSlotManagement.Pages.Reservations
{
    public class Index : PageModel
    {
         public List<ReservationInfo> listReservations{get; set;} = new List<ReservationInfo>();
        public void OnGet()
        {
            try
            {
                string connectionString = "Server=localhost; Port=3306; Database=ParkingDB; Uid=root; Pwd=manager;";
                using(var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    var command = new MySqlCommand("SELECT * FROM Reservations", connection);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ReservationInfo res = new ReservationInfo
                            {
                                Id = reader.GetInt32(0),
                                SlotId = reader.GetInt32(1),
                                VehicleNo = reader.GetString(2),
                                TimeIn = reader.GetDateTime(3),
                                TimeOut = reader.IsDBNull(4) ? null : reader.GetDateTime(4)
                            };
                            listReservations.Add(res);
                        }
                    }
                }                
            }catch(Exception ex)
            {
                Console.WriteLine("Error loading reservations: " + ex.Message);
            }
        }
    }
}