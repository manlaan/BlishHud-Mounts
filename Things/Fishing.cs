﻿using Blish_HUD.Settings;

namespace Manlaan.Mounts.Things.Mounts
{
    public class Fishing : Thing
    {
        public Fishing(SettingCollection settingCollection, Helper helper) 
            : base(settingCollection, helper, "Fishing", "Fishing", "fishing", 10)
        {
        }

        public override bool IsInUse()
        {
            return false;
        }

        public override bool IsInstactActionApplicable()
        {
            return false;
        }
    }
}
