/**
 * VRpgLogs.cs by Toast https://github.com/dorktoast - 11/6/2023
 * VRpg Project Repo: https://github.com/GIBGames/VRpg
 * Join the GIB Games discord at https://discord.gg/gibgames
 * Licensed under MIT: https://opensource.org/license/mit/
 */

using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using UdonToolkit;

namespace GIB.VRpg
{
	/// <summary>
	/// Handles different types of logging interactions.
	/// </summary>
	[UdonBehaviourSyncMode(BehaviourSyncMode.Manual)]
	[CustomName("VRPG Log Handler")]
	public class VRpgLogs : UdonSharpBehaviour
	{
        // Log boxes here, later
		[Header("Logger Options")]
		[SerializeField] private string gameName = "VRpg";
		[SerializeField] private Color labelColor = Color.yellow;

		[UdonSynced] public string NewDebugText;

		public void DebugLog(string message, GameObject go)
        {
			Debug.Log(Utils.MakeColor($"[{gameName}]", labelColor) + ": " + message, go);
        }

		public void NetworkDebugLog(string message)
		{
			Networking.SetOwner(Networking.LocalPlayer, gameObject);
			NewDebugText = message;
			RequestSerialization();
			SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "DoNetworkDebug");
		}

		public void DoNetworkDebug()
        {
			Debug.Log(Utils.MakeColor($"[{gameName}]//SYNC", labelColor) + ": " + NewDebugText);
        }

	}
}