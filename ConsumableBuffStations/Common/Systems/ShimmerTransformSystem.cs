using Terraria.ID;
using Terraria.ModLoader;
using ConsumableBuffStations.Content.Items.PermanentBoosters;

namespace ConsumableBuffStations.Common.Systems
{
    public class ShimmerTransformSystem : ModSystem
    {
        public override void PostSetupContent()
        {
            ItemID.Sets.ShimmerTransformToItem[ItemID.BewitchingTable] =
                ModContent.ItemType<WitchKebab>();

            ItemID.Sets.ShimmerTransformToItem[ItemID.AmmoBox] =
                ModContent.ItemType<BallisticPopcornBucket>();

            ItemID.Sets.ShimmerTransformToItem[ItemID.SharpeningStation] =
                ModContent.ItemType<PeppermintGrindstone>();
            
            ItemID.Sets.ShimmerTransformToItem[ItemID.CrystalBall] =
                ModContent.ItemType<ClairvoyantGumball>();

            ItemID.Sets.ShimmerTransformToItem[ItemID.WarTable] =
                ModContent.ItemType<StrategicSmorgasbord>();

            //Thorium transforms
            if (ModLoader.TryGetMod("ThoriumMod", out Mod thoriumMod))
            {
                ModItem altarItem = thoriumMod.Find<ModItem>("Altar");
                if (altarItem != null)
                {
                    ItemID.Sets.ShimmerTransformToItem[altarItem.Type] =
                        ModContent.ItemType<GoldenWafer>();
                }

                ModItem conductorsStandItem = thoriumMod.Find<ModItem>("ConductorsStand");
                if (conductorsStandItem != null)
                {
                    ItemID.Sets.ShimmerTransformToItem[conductorsStandItem.Type] =
                        ModContent.ItemType<ComposersCandy>();
                }

                ModItem ninjaRackItem = thoriumMod.Find<ModItem>("NinjaRack");
                if (ninjaRackItem != null)
                {
                    ItemID.Sets.ShimmerTransformToItem[ninjaRackItem.Type] =
                        ModContent.ItemType<NinjaRibs>();
                }
            }
        }
    }
}