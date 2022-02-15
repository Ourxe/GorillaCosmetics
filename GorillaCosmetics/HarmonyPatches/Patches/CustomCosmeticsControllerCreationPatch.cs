﻿using System;
using System.Collections.Generic;
using System.Text;
using HarmonyLib;
using UnityEngine;

namespace GorillaCosmetics.HarmonyPatches.Patches
{
	[HarmonyPatch(typeof(VRRig))]
	[HarmonyPatch("Start", MethodType.Normal)]
	internal class CustomCosmeticsControllerCreationPatch
	{
		internal static void Postfix(VRRig __instance)
		{
			Plugin.Log($"GorillaCosmetics: Creating CustomCosmeticsController for {__instance.photonView?.Owner?.NickName ?? "SELF"}");
			__instance.gameObject.AddComponent<CustomCosmeticsController>();
		}
	}
}
