using System;
using System.Collections.Generic;
using System.Text;

namespace _55_Quest_Notification_System_Observer_Pattern
{
    public class XPSystem
    {
        public int PlayerXP { get; private set; } = 0;



        public void AddXP(string questName)
        {
            PlayerXP += 100;
            Console.WriteLine($"Player gained 100 XP from quest {questName}! Total XP: {PlayerXP}\n");
        }
    }
}
