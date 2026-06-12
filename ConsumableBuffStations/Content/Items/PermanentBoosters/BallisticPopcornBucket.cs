using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ConsumableBuffStations.Common.Players;
using System.Collections.Generic;

namespace ConsumableBuffStations.Content.Items.PermanentBoosters
{
    public class BallisticPopcornBucket : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;

            Item.useStyle = ItemUseStyleID.EatFood;
            Item.useTime = 20;
            Item.useAnimation = 20;

            Item.UseSound = SoundID.Item2;

            Item.maxStack = 1;
            Item.consumable = true;

            Item.rare = ItemRarityID.LightPurple;
            Item.value = Item.buyPrice(silver: 50);
        }
        public override bool CanUseItem(Player player)
        {
            return !player.GetModPlayer<PermanentBuffPlayer>().AmmoBoxUnlocked;
        }
        public override bool? UseItem(Player player)
        {
            player.GetModPlayer<PermanentBuffPlayer>().AmmoBoxUnlocked = true;

            return true;
        }
        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            tooltips.Add(new TooltipLine(Mod,
                "PermanentUnlock",
                "Permanently grants the effects of an Ammo Box"));
        }
    }
}


//player.GetModPlayer<PermanentBuffPlayer>().BewitchingUnlocked = True;

