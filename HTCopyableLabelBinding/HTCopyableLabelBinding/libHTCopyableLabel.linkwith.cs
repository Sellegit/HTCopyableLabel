using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libHTCopyableLabel.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator, ForceLoad = true)]
