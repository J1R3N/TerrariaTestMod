using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TestMod.Items
{
	public class Jibbit : ModItem
	{
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.TestMod.hjson file.

		public override void SetDefaults()
		{
			Item.
			Item.damage = 72;
			Item.DamageType = DamageClass.Throwing;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = 1;
			Item.knockBack = 20;
			Item.value = 10000;
			Item.rare = 3;
			Item.UseSound = CustomSounds.Jibbit;
			Item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.GrassSeeds, 30);
			recipe.AddIngredient(ItemID.PurificationPowder, 5);
			recipe.AddIngredient(ItemID.BambooBlockWall, 3);
			recipe.AddIngredient(ItemID.Ichor, 1);
			recipe.AddTile(TileID.26);
			recipe.Register();
		}
	}
}