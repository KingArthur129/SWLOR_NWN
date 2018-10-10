﻿
using NWN;
using SWLOR.Game.Server.Service.Contracts;

namespace SWLOR.Game.Server.Event.Module
{
    internal class OnModuleUseFeat : IRegisteredEvent
    {
        private readonly INWScript _;
        private readonly IAbilityService _ability;
        private readonly IPlayerService _player;
        private readonly IBaseService _base;
        private readonly ICraftService _craft;

        public OnModuleUseFeat(
            INWScript script,
            IAbilityService ability,
            IPlayerService player,
            IBaseService @base,
            ICraftService craft)
        {
            _ = script;
            _ability = ability;
            _player = player;
            _base = @base;
            _craft = craft;
        }

        public bool Run(params object[] args)
        {
            _ability.OnModuleUseFeat();
            _player.OnModuleUseFeat();
            _base.OnModuleUseFeat();
            _craft.OnModuleUseFeat();
            return true;

        }
    }
}
