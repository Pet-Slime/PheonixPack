using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using PheonixPack.cards;


namespace PheonixPack
{
    [BepInPlugin(PluginGuid, PluginName, PluginVersion)]
	[BepInDependency(APIGUID, BepInDependency.DependencyFlags.HardDependency)]
	[BepInDependency(SigilGUID, BepInDependency.DependencyFlags.SoftDependency)]
	public partial class Plugin : BaseUnityPlugin
	{
		public const string APIGUID = "cyantist.inscryption.api";
		public const string SigilGUID = "extraVoid.inscryption.voidSigils";
		public const string PluginGuid = "extraVoid.inscryption.void_pheonix_pack";
		private const string PluginName = "Pheonix Inscryption";
		private const string PluginVersion = "1.0.0";

		public static string Directory;
		internal static ManualLogSource Log;

		private void Awake()
		{
			Log = base.Logger;

			AddSigilsToBook();
			Aavri.AddCard();
			Alpha.AddCard();
			Ankaa.AddCard();
			Asta.AddCard();
			Beta.AddCard();
			Charlie.AddCard();
			Credi.AddCard();
			Credi_Big.AddCard();
			Damiya.AddCard();
			Elda.AddCard();
			Flancie.AddCard();
			Koeno.AddCard();
			Maeja.AddCard();
			Migiri.AddCard();
			Minerva.AddCard();
			Motuz.AddCard();
			Naomi.AddCard();
			Pollyanna.AddCard();
			Rathian.AddCard();
			Richard.AddCard();
			Riowa.AddCard();
			Sabrina.AddCard();
			Serbirb.AddCard();
			Smolstar.AddCard();
			Snufaroth.AddCard();
			Uno.AddCard();


		}
	}
}