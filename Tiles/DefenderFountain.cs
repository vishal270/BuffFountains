using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Microsoft.Xna.Framework;

namespace BuffFountains.Tiles
{
    public class DefenderFountain : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style2xX);
            TileObjectData.newTile.Height = 3;
            TileObjectData.addTile(Type);
            dustType = DustID.Stone;
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("DefenderFountain");
            CreateMapEntryName();
            AddMapEntry(new Color(100, 150, 200),name);
        }
        public override bool NewRightClick(int i, int j)
        {
            Player player = Main.LocalPlayer;
            Main.PlaySound(SoundID.Item3);
            player.AddBuff(BuffID.Endurance, 216000);
            player.AddBuff(BuffID.Lifeforce, 216000);
            player.AddBuff(BuffID.Ironskin, 216000);
            player.AddBuff(BuffID.Regeneration, 216000);
            player.AddBuff(BuffID.Swiftness, 216000);
            player.AddBuff(BuffID.Heartreach, 216000);
            player.AddBuff(BuffID.Titan, 216000);
            player.AddBuff(BuffID.WellFed, 216000);
            return true;
        }
        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(i * 16, j * 16, 32, 48, ModContent.ItemType<Items.Placable.DefenderFountain>());
        }

        public override void MouseOver(int i, int j)
        {
            Player player = Main.LocalPlayer;
            player.noThrow = 2;
            player.showItemIcon = true;
            player.showItemIcon2 = ModContent.ItemType<Items.Placable.DefenderFountain>();
        }
    }
}