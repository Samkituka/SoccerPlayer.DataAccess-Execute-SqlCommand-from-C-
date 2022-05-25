
using System;
using System.Data;
using SoccerPlayer.DataAcess.Controllers;
using SoccerPlayer.DataAcess.Models;

namespace SoccerPlayer.UI.CRUDConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerController playerController = new PlayerController();
            playerController.CreatePlayer("Thiago", "Silva ", "37", "Chelsea FC", "Centre-back");
           
        }
    }
}
