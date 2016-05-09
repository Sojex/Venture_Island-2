using UnityEngine;
using System.Collections;

public class PlayerRotation : MonoBehaviour {



	public float lookSensitivity=5f;
	public float xRot;
	public float yRot;
	public float current_xRot;
	public float current_yRot;
	public float smoothness= .1f;
	private float xRotV;
	private float yRotV;

	// Update is called once per frame
	void Update () {

	

		//Player rotation code took me a while to realize that the mouse y would inflounce the horizontal rotation and vice versa

		xRot-= Input.GetAxis ("Mouse Y") * lookSensitivity;
		yRot+= Input.GetAxis ("Mouse X") * lookSensitivity;



		/*prevents player from doing backflips while looking up got code from youtube channel called penguin design
			limits the value of the xRot which essentially just limits how high up and low the player may look
		*/

		xRot = Mathf.Clamp (xRot, -80, 100);





		//code I found from a panguin design tutorial to make the rotation smoother 

	//	current_xRot = Mathf.SmoothDamp (current_xRot, xRot, xRotV, smoothness);




		//actually does the rotation based off of xRot and yRot variables



		transform.rotation = Quaternion.Euler (0f, yRot, 0f);
		Camera.main.transform.localRotation= Quaternion.Euler (xRot,0f,0f);


		//Awesome code that hides cursor and locks it in the middle of the screen helps a lot with rotation
		Screen.lockCursor = true;

	}
}
