using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.ID;

namespace ConsumableBuffStations.Common.Players
{
    public class PermanentBuffPlayer : ModPlayer
    {
        public bool BewitchingUnlocked;
        public bool AmmoBoxUnlocked;
        public bool SharpeningStationUnlocked;
        public bool CrystalBallUnlocked;
        public bool WarTableUnlocked;

        public override void SaveData(TagCompound tag)
        {
            tag["BewitchingUnlocked"] = BewitchingUnlocked;
            tag["AmmoBoxUnlocked"] = AmmoBoxUnlocked;
            tag["SharpeningStationUnlocked"] = SharpeningStationUnlocked;
            tag["CrystalBallUnlocked"] = CrystalBallUnlocked;
            tag["WarTableUnlocked"] = WarTableUnlocked;
        }

        public override void LoadData(TagCompound tag)
        {
            BewitchingUnlocked = tag.GetBool("BewitchingUnlocked");
            AmmoBoxUnlocked = tag.GetBool("AmmoBoxUnlocked");
            SharpeningStationUnlocked = tag.GetBool("SharpeningStationUnlocked");
            CrystalBallUnlocked = tag.GetBool("CrystalBallUnlocked");
            WarTableUnlocked = tag.GetBool("WarTableUnlocked");
        }

        public override void PostUpdateBuffs()
        {
            if (BewitchingUnlocked)
            {
                Player.AddBuff(BuffID.Bewitched, 2);
            }

            if (AmmoBoxUnlocked)
            {
                Player.AddBuff(BuffID.AmmoBox, 2);
            }

            if (SharpeningStationUnlocked)
            {
                Player.AddBuff(BuffID.Sharpened, 2);
            }

            if (CrystalBallUnlocked)
            {
                Player.AddBuff(BuffID.Clairvoyance, 2);
            }

            if (WarTableUnlocked)
            {
                Player.AddBuff(BuffID.WarTable, 2);
            }
        }

        //delete below this line
        //public override void OnEnterWorld()
        //{
            //BewitchingUnlocked = true;
        //}

        }
    
}


