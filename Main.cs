using Il2CppAssets.Scripts.Models;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Abilities;
using UnlimitedAbilities;

[assembly:
    MelonInfo(typeof(UnlimitedAbilities.Main), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace UnlimitedAbilities;

[HarmonyPatch]
public class Main : BloonsTD6Mod
{
    public override void OnNewGameModel(GameModel result)
    {
        foreach (var ability in result.GetDescendants<AbilityModel>().ToList())
        {
            ability.maxActivationsPerRound = -1;
        }
    }
}