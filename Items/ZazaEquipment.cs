using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TestMod.Items
{
	public class ZazaEquipment : ModItem
	{
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.TestMod.hjson file.
        public override void SetDefaults()
		{
			Item.accessory = true;
			Item.defense = 7;
           	Item.value = Item.sellPrice(0, 3, 50, 0);
            Item.width = 40;
			Item.height = 40;
			Item.rare = ItemRarityID.LightRed;
            //Main.buffNoTimeDisplay[Type] = false; // Der Buff wird eine Dauer haben, aber sie wird endlos sein

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
            if (!player.HasBuff(BuffID.Endurance))
            {
                player.AddBuff(BuffID.Endurance, 0); // Endurance-Buff 
            }
            if (!player.HasBuff(BuffID.NightOwl))
            {
                player.AddBuff(BuffID.NightOwl, 0); // Night-Vision-Buff
            }
            
        }
    }
}
