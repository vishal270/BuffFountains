using Terraria.ID;
using Terraria.ModLoader;

namespace BuffFountains.Items.Placable
{
	public class MagicianFountain : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Adds most vanilla magic buffs");
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
			item.createTile = ModContent.TileType<Tiles.MagicianFountain>();

		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddIngredient(ItemID.MagicPowerPotion, 100);
			recipe.AddIngredient(ItemID.ManaRegenerationPotion, 100);
			recipe.AddRecipeGroup("BuffFountains:WrathAndRage", 100);
			recipe.AddIngredient(ItemID.CrystalBall, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ModContent.ItemType<Items.Placable.MagicianFountain>());
			recipe.AddRecipe();
		}
	}
}