using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.ID;
using ConsumableBuffStations.Common.Systems;

namespace ConsumableBuffStations.Common.Players
{
    public class PermanentBuffPlayer : ModPlayer
    {
        public bool BewitchingUnlocked;
        public bool AmmoBoxUnlocked;
        public bool SharpeningStationUnlocked;
        public bool CrystalBallUnlocked;
        public bool WarTableUnlocked;
        //Thorium variables
        public bool AltarUnlocked;
        public bool ConductorsStandUnlocked;
        public bool NinjaRackUnlocked;

        public override void SaveData(TagCompound tag)
        {
            tag["BewitchingUnlocked"] = BewitchingUnlocked;
            tag["AmmoBoxUnlocked"] = AmmoBoxUnlocked;
            tag["SharpeningStationUnlocked"] = SharpeningStationUnlocked;
            tag["CrystalBallUnlocked"] = CrystalBallUnlocked;
            tag["WarTableUnlocked"] = WarTableUnlocked;
            //Thorium variables
            tag["AltarUnlocked"] = AltarUnlocked;
            tag["ConductorsStandUnlocked"] = ConductorsStandUnlocked;
            tag["NinjaRackUnlocked"] = NinjaRackUnlocked;
        }

        public override void LoadData(TagCompound tag)
        {
            BewitchingUnlocked = tag.GetBool("BewitchingUnlocked");
            AmmoBoxUnlocked = tag.GetBool("AmmoBoxUnlocked");
            SharpeningStationUnlocked = tag.GetBool("SharpeningStationUnlocked");
            CrystalBallUnlocked = tag.GetBool("CrystalBallUnlocked");
            WarTableUnlocked = tag.GetBool("WarTableUnlocked");
            //Thorium variables
            AltarUnlocked = tag.GetBool("AltarUnlocked");
            ConductorsStandUnlocked = tag.GetBool("ConductorsStandUnlocked");
            NinjaRackUnlocked = tag.GetBool("NinjaRackUnlocked");
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
            // Thorium buffs
            if (ThoriumCompatibilitySystem.Thorium != null)
            {
                if (AltarUnlocked &&
                    ThoriumCompatibilitySystem.Thorium.TryFind<ModBuff>("AltarBuff", out var spiritualBuff))
                {
                    Player.AddBuff(spiritualBuff.Type, 2);
                }

                if (ConductorsStandUnlocked &&
                    ThoriumCompatibilitySystem.Thorium.TryFind<ModBuff>("ConductorsStandBuff", out var conductorBuff))
                {
                    Player.AddBuff(conductorBuff.Type, 2);
                }

                if (NinjaRackUnlocked &&
                    ThoriumCompatibilitySystem.Thorium.TryFind<ModBuff>("NinjaBuff", out var sleightBuff))
                {
                    Player.AddBuff(sleightBuff.Type, 2);
                }
            }

        //delete below this line
        //public override void OnEnterWorld()
        //{
            //BewitchingUnlocked = true;
        //}

        }
    
    }
}


