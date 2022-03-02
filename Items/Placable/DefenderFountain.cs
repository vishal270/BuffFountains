using Terraria.ID;
using Terraria.ModLoader;


namespace BuffFountains.Items.Placable
{
	public class DefenderFountain : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Adds most movement and defensive vanilla buffs");
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
			item.createTile = ModContent.TileType<Tiles.DefenderFountain>();

		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
		//	recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddIngredient(ItemID.LifeforcePotion, 100);
			recipe.AddIngredient(ItemID.EndurancePotion, 100);
			recipe.AddIngredient(ItemID.IronskinPotion, 100);
			recipe.AddIngredient(ItemID.RegenerationPotion, 100);
			recipe.AddIngredient(ItemID.SwiftnessPotion, 100);
			recipe.AddIngredient(ItemID.TitanPotion, 100);
			recipe.AddIngredient(ItemID.HeartreachPotion, 100);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ModContent.ItemType<Items.Placable.DefenderFountain>());
			recipe.AddRecipe();
		}
	}
}