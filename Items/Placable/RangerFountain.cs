using Terraria.ID;
using Terraria.ModLoader;

namespace BuffFountains.Items.Placable
{
	public class RangerFountain : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Adds most vanilla ranged buffs");
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
			item.createTile = ModContent.TileType<Tiles.RangerFountain>();

		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddRecipeGroup("BuffFountains:WrathAndRage", 100);
			recipe.AddIngredient(ItemID.ArcheryPotion, 100);
			recipe.AddIngredient(ItemID.AmmoReservationPotion, 100);
			recipe.AddIngredient(ItemID.AmmoBox, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ModContent.ItemType<Items.Placable.RangerFountain>());
			recipe.AddRecipe();
		}
	}
}