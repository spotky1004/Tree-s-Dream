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
	public class TreeOre : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Tree Ore"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("A Tree Ore");
		}

		public override void SetDefaults() 
		{
			item.Size = new Vector2(22);
			item.rare = ItemRarityID.Blue;
			item.value = 7;

			item.autoReuse = true;
			item.useTurn = true;
			item.useTime = 10;
			item.useAnimation = 12;
			item.useStyle = ItemUseStyleID.SwingThrow;

			item.maxStack = 999;
		}
	}
}