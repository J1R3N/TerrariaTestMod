using Terraria.ModLoader;

namespace TestMod
{
	public class TestMod : Mod
	{
		public TestMod{
			Properties = new ModProperties() {
			Autoload = true,
			AutoloadGores = true,
			AutoloadSounds = true
			};
		}
	}
}