using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdManager : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
		// If pressing the E key, the user will see a video advertisement
		if(Input.GetKeyDown(KeyCode.E))
		{
			if(Advertisement.IsReady("video"))
			{
				Advertisement.Show("video");
			}
		}
    }

	public void playAdd()
	{
		Advertisement.Show("video");
	}
}
