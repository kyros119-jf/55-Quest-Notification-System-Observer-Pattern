using System;
using System.Collections.Generic;
using System.Text;

namespace _55_Quest_Notification_System_Observer_Pattern
{
    public class UIManager
    {
        public void UpdateUI(string questName)
        {
            Console.WriteLine($"UI Update: Quest {questName} completed!\n");
        }
    }
}
