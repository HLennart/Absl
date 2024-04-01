using UnrealBuildTool;

using System.IO;

public class Absl : ModuleRules
{
    public Absl(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = ModuleRules.PCHUsageMode.NoSharedPCHs;
        PrivatePCHHeaderFile = Path.Combine(ModuleDirectory, "Public", "Absl.h");
        bUseUnity = false;

        bPrecompile = false;
        bUsePrecompiled = false;

        ShadowVariableWarningLevel = WarningLevel.Off;

       
        
        PrivateDefinitions.Add("HAS_STRPTIME=0"); // should be the correct default value?
        PrivateDefinitions.Add("NOMINMAX=1");
        PublicDefinitions.Add("ABSL_BUILD_DLL=1");
        
        
        
        PublicSystemIncludePaths.Add(Path.Combine(ModuleDirectory, "Public"));

        PublicDependencyModuleNames.AddRange(
            new string[]
            {
                "Core",
            }
        );

        PrivateDependencyModuleNames.AddRange(
            new string[]
            {
                "CoreUObject",
                "Engine"
            }
        );
    }
}