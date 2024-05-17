using UnrealBuildTool;

public class BGS_Skate_GabrielSDClientTarget : TargetRules
{
	public BGS_Skate_GabrielSDClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("BGS_Skate_GabrielSD");
	}
}
