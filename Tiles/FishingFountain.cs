using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Microsoft.Xna.Framework;

namespace BuffFountains.Tiles
{
    public class FishingFountain : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style2xX);
            TileObjectData.newTile.Height = 3;
            TileObjectData.addTile(Type);
            dustType = DustID.Stone;
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("FishingFountain");
            CreateMapEntryName();
            AddMapEntry(new Color(100, 150, 200),name);
        }
        public override bool NewRightClick(int i, int j)
        {
            Player player = Main.LocalPlayer;
            Main.PlaySound(SoundID.Item3);
            player.AddBuff(BuffID.Sonar, 216000);
            player.AddBuff(BuffID.Fishing, 216000);
            player.AddBuff(BuffID.Crate, 216000);
            player.AddBuff(BuffID.Calm, 216000);


            return true;
        }
        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(i * 16, j * 16, 32, 48, ModContent.ItemType<Items.Placable.FishingFountain>());
        }

        public override void MouseOver(int i, int j)
        {
            Player player = Main.LocalPlayer;
            player.noThrow = 2;
            player.showItemIcon = true;
            player.showItemIcon2 = ModContent.ItemType<Items.Placable.MagicianFountain>();
        }
    }
}