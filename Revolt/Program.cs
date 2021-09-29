using System;
using LightController;

namespace Revolt
{
    class Program
    {
        static void Main(string[] args)
        {
            var controller = new Controller(1000, 1000);
            controller.TurnOnRange(887, 9, 959, 629);
            controller.TurnOnRange(454, 398, 844, 448);
            controller.TurnOffRange(539,243 , 559,965);
            controller.TurnOffRange(370,819 , 676,868);
            controller.TurnOffRange(145,40 , 370,997);
            controller.TurnOffRange(301,3 , 808,453);
            controller.TurnOnRange(351,678 , 951,908);
            controller.ToggleRange(720,196 , 897,994);
            controller.ToggleRange(831,394 , 904,860);
            Console.WriteLine(controller.GetTurnedOnAmount());
        }
    }
}