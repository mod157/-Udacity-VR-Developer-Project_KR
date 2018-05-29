using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Key : MonoBehaviour
{
	public GameObject keyPoof;
	public Door door;

	public void OnKeyClicked()
	{
		Instantiate(keyPoof, gameObject.transform);
		
		door.Unlock();
		Destroy(gameObject, 2f);
    }

}
