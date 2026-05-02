using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;
using ParkingSlotManagement.Models;

namespace ParkingSlotManagement.Pages.Slots
{
    public class Index : PageModel
    {
        public List<SlotInfo> listSlots{get; set;} = new List<SlotInfo>();

        public void OnGet()
        {
            try
            {
                string connectionString = "Server=localhost; Port=3306; Database=ParkingDB; Uid=root; Pwd=manager;";
                using(var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    var command = new MySqlCommand("SELECT * FROM Slots",connection);

                    using(var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            SlotInfo slot = new SlotInfo
                            {
                              id = reader.GetInt32(0),
                              slotNumber = reader.GetString(1),
                              location = reader.GetString(2),
                              status = reader.GetString(3)  
                            };
                            listSlots.Add(slot);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving slots: {ex.Message}");
            }
        }
    }
}