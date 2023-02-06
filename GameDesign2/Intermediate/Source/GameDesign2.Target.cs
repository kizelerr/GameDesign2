using UnrealBuildTool;

public class GameDesign2Target : TargetRules
{
	public GameDesign2Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("GameDesign2");
	}
}
