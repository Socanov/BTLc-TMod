using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace BTLc
{
	public class BTLc : Mod
	{
        internal static BTLc Instance;
        public override void Load()
        {
            Instance = this;
            base.Load();
        }
        public override void Unload()
        {
            base.Unload();
        }
    }
}