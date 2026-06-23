using Terraria.ModLoader;

namespace ConsumableBuffStations.Common.Systems
{
    public class ThoriumCompatibilitySystem : ModSystem
    {
        public static Mod Thorium;

        public override void PostSetupContent()
        {
            if (!ModLoader.TryGetMod("ThoriumMod", out Thorium))
                return;

            //foreach (var buff in Thorium.GetContent<ModBuff>())
            //{
            //    Mod.Logger.Info($"THORIUM BUFF: {buff.Name}");
            //}
        }
    }
}