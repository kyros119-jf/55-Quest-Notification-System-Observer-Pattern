using _55_Quest_Notification_System_Observer_Pattern;

QuestManager questmanager = new QuestManager();
XPSystem xpsystem = new XPSystem();
UIManager uimanager = new UIManager();

questmanager.QuestCompleted += xpsystem.AddXP;
questmanager.QuestCompleted += uimanager.UpdateUI;



    questmanager.CompleteQuest("Goblin Hunt");
