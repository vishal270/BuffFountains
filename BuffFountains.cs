using Terraria;
using Terraria.ModLoader;
using Terraria.Localization;
using Terraria.ID;


namespace BuffFountains
{
    public class BuffFountains : Mod
	{
        public override void AddRecipeGroups()
        {
            RecipeGroup group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Wrath And Rage potion", new int[]
            {
                ItemID.WrathPotion,
                ItemID.RagePotion
            });
            RecipeGroup.RegisterGroup("BuffFountains:WrathAndRage", group);
        }
    }
}