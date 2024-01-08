/**
 * TMPTestScript.cs by Toast https://github.com/dorktoast - 11/12/2023
 * VRpg Project Repo: https://github.com/GIBGames/VRpg
 * Join the GIB Games discord at https://discord.gg/gibgames
 * Licensed under MIT: https://opensource.org/license/mit/
 */

using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using TMPro;

namespace GIB.VRpg
{
	/// <summary>
	/// Summary of Class
	/// </summary>
	[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
	public class TMPTestScript : UdonSharpBehaviour
	{
		[SerializeField] private TextMeshProUGUI text1;
		[SerializeField] private TextMeshPro text2;
		[SerializeField] private TextMeshProUGUI text3;
		[SerializeField] private TextMeshPro text4;

		public void TextTest()
        {
			int someNum = Random.Range(0, 3);

            switch (someNum)
            {
				case 0:
					text1.text = "Test!";
					text2.text = "1111111!";
					break;
				case 1:
					text1.text = "Foo!";
					text2.text = "444444444444";
					break;
				case 2:
					text1.text = "bar!!!!";
					text2.text = "OOOOOOOOOOOOO";
					break;
                default:
                    break;
            }

			text3.text = System.DateTime.Now.ToString();
			text4.text = $"It's {Random.Range(0, 2f)} boom";

		}
	}
}