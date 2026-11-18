using System;
using System.Collections.Generic;
using System.Text;

namespace _55_Quest_Notification_System_Observer_Pattern
{
   public class QuestManager
    {
        public event Action<string>? QuestCompleted;

        public void CompleteQuest(string questName)
        {
            Console.WriteLine($"Quest {questName} completed!\n");
            QuestCompleted?.Invoke(questName);
        }


    }
}
