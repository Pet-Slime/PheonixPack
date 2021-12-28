using BepInEx;
using BepInEx.Logging;
using System.Collections.Generic;
using DiskCardGame;
using HarmonyLib;
using UnityEngine;
using APIPlugin;
using Resources = PheonixPack.Artwork.Resources;
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
		private const string PluginName = "Void Bone Pack";
		private const string PluginVersion = "1.0.0";

		public static string Directory;
		internal static ManualLogSource Log;

		private void Awake()
		{
			Log = base.Logger;

			Harmony harmony = new(PluginGuid);
			harmony.PatchAll();



			AddSigilsToBook();
			Aavri.AddCard();


		}
	}
}