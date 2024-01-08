/**
 * VRpgWorldOptions.cs by Toast https://github.com/dorktoast - 11/6/2023
 * VRpg Project Repo: https://github.com/GIBGames/VRpg
 * Join the GIB Games discord at https://discord.gg/gibgames
 * Licensed under MIT: https://opensource.org/license/mit/
 */

using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

namespace GIB.VRpg
{
	/// <summary>
	/// Options for use in various VRpg derivatives
	/// </summary>
	[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
	public class VRpgOptions : UdonSharpBehaviour
	{
		public Color VipLabelColor;

		[Header("Voice")]
		public float InVoiceZone = 25f;
		public float OutVoiceZone = 0f;
	}
}