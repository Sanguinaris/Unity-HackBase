﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPForestTrn.Hack.Managers;
using UnityEngine;

namespace PPForestTrn.Hack.Mods.PlayerMods
{
    class InfiniteSanity : Module
    {
        public InfiniteSanity() : base("Infinite Sanity", KeyCode.None, Categories.mPlayer, GuiNames.Toggle)
        {
        }

        public override void onEnable()
        {
            EventMgr.Instance.registerEventListener(EventNames.onUpdate, this);
        }

        public override void onDisable()
        {
            EventMgr.Instance.deleteEventListener(EventNames.onUpdate, this);
        }

        public override void onUpdate()
        {
            if (!this.getState()) return;
            TheForest.Utils.LocalPlayer.Stats.Sanity.CurrentSanity = 1337;
        }

    }
}
