﻿using Terraria;
using Terraria.ModLoader;
using Terraria.Localization;


namespace BTLc.Buffs
{
    public class Penetrate : ModBuff
    {
        int i = 0;
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            // DisplayName.SetDefault("入刺");
            /* Description.SetDefault(" Not affected by defense, slowly lose HP \n" +
                                    "ouch!"); */

            Main.buffNoSave[Type] = true;
            Main.debuff[Type] = true;
            Main.pvpBuff[Type] = true;
        }
        public override void Update(NPC npc, ref int buffIndex)
        {
            base.Update(npc, ref buffIndex);
            npc.lifeRegen -= 4;
        }
    }
}