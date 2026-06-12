using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.ID;

namespace ConsumableBuffStations.Common.Players
{
    public class PermanentBuffPlayer : ModPlayer
    {
        public bool BewitchingUnlocked;

        public override void SaveData(TagCompound tag)
        {
            tag["BewitchingUnlocked"] = BewitchingUnlocked;
        }

        public override void LoadData(TagCompound tag)
        {
            BewitchingUnlocked = tag.GetBool("BewitchingUnlocked");
        }

        public override void PostUpdateBuffs()
        {
            if (BewitchingUnlocked)
            {
                Player.AddBuff(BuffID.Bewitched, 2);
            }

            

        }

        //delete below this line
        //public override void OnEnterWorld()
        //{
            //BewitchingUnlocked = true;
        //}

        }
    
}


