using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace SpotkysFirstMod.Items
{
	[AutoloadEquip(EquipType.Legs)]
	public class TreeArmorLegs : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Tree Greaves"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("A Tree Greaves");
		}

		public override void SetDefaults() 
		{
			item.width = 22;
			item.height = 16;
			item.defense = 5;
			item.value = 600;
			item.rare = ItemRarityID.Green;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemType<Items.TreeBar>(), 6);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}