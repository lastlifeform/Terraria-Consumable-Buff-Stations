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
        }
    }
}