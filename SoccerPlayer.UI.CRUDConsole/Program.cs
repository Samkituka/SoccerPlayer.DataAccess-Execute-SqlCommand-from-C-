
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
            playerController.CreatePlayer("Harry", "Kane ", "28", "Tottenham Hotspur", "Striker");
           
        }
    }
}
