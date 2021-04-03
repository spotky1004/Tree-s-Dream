using Terraria;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace SpotkysFirstMod.Items
{
	public class TreeBar : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Tree Bar"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("A Tree Bar!");
		}

		public override void SetDefaults() 
		{
			item.Size = new Vector2(22);
			item.rare = ItemRarityID.Blue;
			item.value = 2;

			item.autoReuse = true;
			item.useTurn = true;
			item.useTime = 10;
			item.useAnimation = 12;
			item.useStyle = ItemUseStyleID.SwingThrow;

			item.consumable = true;
			item.maxStack = 999;

			item.createTile = TileType<Tile.TreeOreTile>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemType<Items.TreeOre>(), 12);
			recipe.AddIngredient(ItemID.Wood, 25);
			recipe.AddIngredient(ItemID.RichMahogany, 25);
			recipe.AddIngredient(ItemID.BorealWood, 25);
			recipe.AddIngredient(ItemID.Cactus, 25);
			recipe.AddTile(TileID.Furnaces);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}