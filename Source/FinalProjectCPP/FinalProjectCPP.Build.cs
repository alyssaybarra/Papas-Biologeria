// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class FinalProjectCPP : ModuleRules
{
	public FinalProjectCPP(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput", "AIModule", "GameplayTasks", "NavigationSystem" });
	}
}
