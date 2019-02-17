using System;
using StardewModdingAPI;

namespace BetterSkullCavernFalling
{
    public class ModEntry : Mod
    {
        public override void Entry(IModHelper helper)
        {
            GameEvents.UpdateTick += this.GameEvents_UpdateTick;
        }

        private void GameEvents_UpdateTick(object sender, EventArgs args)
        {
            // Intercept annoying popup messages when jumping into holes in skull cavern.
            // Shows HUD message instead.
            SkullCavernFallMessageIntercepter.Intercept(this.Helper.Reflection);
        }
    }
}
