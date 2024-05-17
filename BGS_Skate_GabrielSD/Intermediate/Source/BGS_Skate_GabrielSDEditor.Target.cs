using UnrealBuildTool;

public class BGS_Skate_GabrielSDEditorTarget : TargetRules
{
	public BGS_Skate_GabrielSDEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("BGS_Skate_GabrielSD");
	}
}
