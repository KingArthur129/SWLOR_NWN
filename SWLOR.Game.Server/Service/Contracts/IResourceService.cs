﻿using NWN;
using SWLOR.Game.Server.Enumeration;
using SWLOR.Game.Server.GameObject;

namespace SWLOR.Game.Server.Service.Contracts
{
    public interface IResourceService
    {
        ItemProperty GetRandomComponentBonusIP(ResourceQuality quality);
        int CalculateChanceForComponentBonus(NWPlayer player, int tier, ResourceQuality quality);
        int GetDifficultyAdjustment(ResourceQuality quality);
        string GetResourceDescription(NWPlaceable resource);
    }
}