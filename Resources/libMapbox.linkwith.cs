using System;
using ObjCRuntime;


[assembly: LinkWith ("libMapbox.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator, ForceLoad = true, Frameworks = "CoreFoundation CoreGraphics CoreLocation Foundation QuartzCore UIKit", LinkerFlags = "-lz -lsqlite3", IsCxx = true)]
//[assembly: LinkWith ("libMapbox.a", LinkTarget.Arm64 | LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator64 | LinkTarget.Simulator, SmartLink = true, ForceLoad = true)]
