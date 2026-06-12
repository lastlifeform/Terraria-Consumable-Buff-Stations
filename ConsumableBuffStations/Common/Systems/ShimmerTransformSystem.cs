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
        }
    }
}