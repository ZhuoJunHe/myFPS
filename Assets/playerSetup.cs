using UnityEngine;
using UnityEngine.Networking;



public class playerSetup : NetworkBehaviour
{
	[SerializeField]
	Behaviour[] compDisable;

	Camera sceneCamera;

	void Start()
	{
		if (!isLocalPlayer)			
		{
			for (int i=0; i < compDisable.Length; i++)
			    {
				compDisable[i].enabled = false;
				
			     }

		}
	}
}
