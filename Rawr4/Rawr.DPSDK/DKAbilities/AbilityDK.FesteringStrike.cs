﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Rawr.DK
{
    /// <summary>
    /// This class is the implmentation of the Festering Strike Ability based on the AbilityDK_Base class.
    /// Increases the duration of your Blood Plague, Frost Fever, and Chains of Ice effects on the target by up to 6 sec.
    /// </summary>
    class AbilityDK_FesteringStrike : AbilityDK_Base
    {
        public AbilityDK_FesteringStrike(CombatState CS)
        {
            this.CState = CS;
            this.wMH = CS.MH;
            this.wOH = CS.OH;
            this.szName = "Festering Strike";
            this.AbilityCost[(int)DKCostTypes.Blood] = 1;
            this.AbilityCost[(int)DKCostTypes.Frost] = 1;
            this.AbilityCost[(int)DKCostTypes.RunicPower] = -15;
            this.DamageAdditiveModifer = 560 * 150 / 100;
            this.fWeaponDamageModifier = 1.5f;
            this.bWeaponRequired = true;
            this.bTriggersGCD = true;
            this.uRange = MELEE_RANGE;
        }
    }
}