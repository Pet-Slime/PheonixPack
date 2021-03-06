using System.Collections;
using APIPlugin;
using DiskCardGame;

namespace PheonixPack
{
	public partial class Plugin
	{
		private static void AddSigilsToBook()
		{
			//This is to make bone digger show up in act 1
			var ability = ScriptableObjectLoader<AbilityInfo>.AllData;

			for (int index = 0; index < ability.Count; index++)
			{
				AbilityInfo info = ability[index];
				if (info.ability == Ability.GainGemBlue)
				{
					info.metaCategories.Add(AbilityMetaCategory.Part1Rulebook);
				}
				if (info.ability == Ability.GainGemOrange)
				{
					info.metaCategories.Add(AbilityMetaCategory.Part1Rulebook);
				}
				if (info.ability == Ability.GainGemGreen)
				{
					info.metaCategories.Add(AbilityMetaCategory.Part1Rulebook);
				}
				if (info.ability == Ability.SwapStats)
				{
					info.metaCategories.Add(AbilityMetaCategory.Part1Rulebook);
				}
				if (info.ability == Ability.GainGemTriple)
				{
					info.metaCategories.Add(AbilityMetaCategory.Part1Rulebook);
				}
				if (info.ability == Ability.ExplodeGems)
				{
					info.metaCategories.Add(AbilityMetaCategory.Part1Rulebook);
				}
			}
		}
	}


}