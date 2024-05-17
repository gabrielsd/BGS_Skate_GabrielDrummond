using UnrealBuildTool;

public class BGS_Skate_GabrielSDTarget : TargetRules
{
	public BGS_Skate_GabrielSDTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("BGS_Skate_GabrielSD");
	}
}
