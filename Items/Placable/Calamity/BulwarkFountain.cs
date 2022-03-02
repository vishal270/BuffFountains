using Terraria.ID;
using Terraria.ModLoader;


namespace BuffFountains.Items.Placable.Calamity
{
	public class BulwarkFountain : ModItem
	{
		public override void SetStaticDefaults()
		{

					Tooltip.SetDefault("Adds most movement and defensive calamity & vanilla buffs");
			}
			
		public override void SetDefaults()
		{

			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.consumable = true;
			item.value = 500;
			item.createTile = ModContent.TileType<Tiles.Calamity.BulwarkFountain>();

        }

		public override void AddRecipes()
		{
			Mod calamity = ModLoader.GetMod("CalamityMod");
				ModRecipe recipe = new ModRecipe(mod);
			if (calamity != null)
			{
				recipe.AddIngredient(ModContent.ItemType<Items.Placable.DefenderFountain>(),1);
				recipe.AddIngredient(calamity.ItemType("YharimsStimulants"),100);
				recipe.AddIngredient(calamity.ItemType("TitanScalePotion"), 100);
				recipe.AddIngredient(calamity.ItemType("SoaringPotion"), 100);
				recipe.AddIngredient(calamity.ItemType("PhotosynthesisPotion"), 100);
				recipe.AddIngredient(ItemID.CalmingPotion, 100);
				recipe.AddIngredient(ItemID.LovePotion, 100);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ModContent.ItemType<Items.Placable.Calamity.BulwarkFountain>());
				recipe.AddRecipe();
			}
            else
            {

            }
		}
	}
}