﻿using System.Linq;
using NWN;
using SWLOR.Game.Server.GameObject;
using SWLOR.Game.Server.Service;

namespace SWLOR.Game.Server.Event.Conversation.Quest.AdvanceQuest
{
    public static class QuestAdvance
    {
        public static bool Check(params object[] args)
        {
            int index = (int)args[0];
            NWPlayer player = _.GetPCSpeaker();
            NWObject talkTo = Object.OBJECT_SELF;
            int questID = talkTo.GetLocalInt("QUEST_ID_" + index);
            if (questID <= 0) questID = talkTo.GetLocalInt("QST_ID_" + index);

            if (DataService.GetAll<Data.Entity.Quest>().All(x => x.ID != questID))
            {
                _.SpeakString("ERROR: Quest #" + index + " is improperly configured. Please notify an admin");
                return false;
            }
            QuestService.AdvanceQuestState(player, talkTo, questID);

            return true;
        }
    }
}
