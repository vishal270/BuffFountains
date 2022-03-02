using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace BuffFountains.Items.Placable
{
	public class WarriorFountain : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Adds most vanilla melee buffs");
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
			item.createTile = ModContent.TileType<Tiles.WarriorFountain>();

		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddRecipeGroup("BuffFountains:WrathAndRage", 100);
			recipe.AddIngredient(ItemID.Ale, 100);
			recipe.AddIngredient(ItemID.SharpeningStation, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ModContent.ItemType<Items.Placable.WarriorFountain>());
			recipe.AddRecipe();
		}
	}
}