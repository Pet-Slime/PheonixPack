﻿using BepInEx;
using BepInEx.Logging;
using System.Collections.Generic;
using DiskCardGame;
using HarmonyLib;
using UnityEngine;
using APIPlugin;
using Resources = PheonixPack.Resources.Artwork;

namespace PheonixPack.cards
{
	public static class Koeno
	{
		public static void AddCard()
		{

			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.TraderOffer);
			metaCategories.Add(CardMetaCategory.ChoiceNode);

			List<Tribe> Tribes = new List<Tribe>();

			List<GemType> gemCost = new List<GemType>();

			List<Ability> Abilities = new List<Ability>();
			Abilities.Add(Ability.DeathShield);
			Abilities.Add(Ability.RandomConsumable);

			List<Trait> Traits = new List<Trait>();

			List<AbilityIdentifier> customAbilities = new List<AbilityIdentifier>();

			List<SpecialTriggeredAbility> specialAbilities = new List<SpecialTriggeredAbility>();

			List<CardAppearanceBehaviour.Appearance> appearanceBehaviour = new List<CardAppearanceBehaviour.Appearance>();

			Texture2D DefaultTexture = SigilUtils.LoadTextureFromResource(Resources.Artwork.Koeno);

			Texture2D eTexture = SigilUtils.LoadTextureFromResource(Resources.Artwork.Koeno);

			string description = "...";

			EvolveIdentifier evolveId = null;

			IceCubeIdentifier iceCubeId = new IceCubeIdentifier("Smoke", null);

			TailIdentifier tailId = null;

			NewCard.Add(name: "PI_Koeno",
				displayedName: "Koeno",
				baseAttack: 0,
				baseHealth: 3,
				metaCategories,
				cardComplexity: CardComplexity.Simple,
				temple: CardTemple.Nature,
				description,
				hideAttackAndHealth: false,
				bloodCost: 0,
				bonesCost: 5,
				energyCost: 0,
				gemCost,
				specialStatIcon: SpecialStatIcon.None,
				Tribes,
				Traits,
				specialAbilities,
				Abilities,
				customAbilities,
				specialAbilitiesIdsParam: null,
				evolveParams: null,
				defaultEvolutionName: null,
				tailParams: null,
				iceCubeParams: null,
				flipPortraitForStrafe: false,
				onePerDeck: false,
				appearanceBehaviour,
				DefaultTexture,
				altTex: null,
				titleGraphic: null,
				pixelTex: null,
				eTexture,
				animatedPortrait: null,
				decals: null,
				evolveId,
				iceCubeId,
				tailId
				);
		}
	}
}
