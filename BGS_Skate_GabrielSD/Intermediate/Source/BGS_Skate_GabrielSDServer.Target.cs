using UnrealBuildTool;

public class BGS_Skate_GabrielSDServerTarget : TargetRules
{
	public BGS_Skate_GabrielSDServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("BGS_Skate_GabrielSD");
	}
}
