using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TestMod.Items
{
	public class HelloDeady : ModItem
	{
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.TestMod.hjson file.
        public override void SetDefaults()
		{
			Item.accessory = true;
      		Item.value = Item.sellPrice(1, 7, 50, 0);
      		Item.width = 40;
			Item.height = 40;
			Item.rare = ItemRarityID.LightRed;
        }

        public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.VilePowder, 15);
			recipe.AddIngredient(ItemID.Acorn, 15);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.Register();
		}
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            // Fügen Sie hier den Buff hinzu, den Ihre Ausrüstung verleihen soll
            if (!player.HasBuff(BuffID.Deady)) 	//Deady muss noch erstellt werden
            {
                player.AddBuff(BuffID.Deady, 0); // Endurance-Buff 
            }
            }
            
        }
    }
}
