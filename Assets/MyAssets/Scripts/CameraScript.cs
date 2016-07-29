using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour
{
		public Camera pair;
		private Vector3 pairOriginalLocation;

		// Use this for initialization
		void Start ()
		{
				pairOriginalLocation = pair.transform.position;
		}
	
		// Update is called once per frame
		void Update ()
		{
				
/*				
				Quaternion originalQuart = Camera.main.transform.rotation;
				
				Camera.main.transform.LookAt (gameObject.transform.position);
				
				Quaternion quat = Camera.main.transform.rotation;
				quat.x = 0;
				
				pair.transform.rotation = (quat);
				
				Camera.main.transform.rotation = originalQuart;
	*/
		
				//		gameObject.transform.Rotate (0.0f, 180.0f, 0.0f);
				gameObject.transform.localPosition = -(pairOriginalLocation - Camera.main.transform.position);
				Vector3 newPos = gameObject.transform.position;
				newPos.y = Camera.main.transform.position.y;
				gameObject.transform.position = newPos;
				gameObject.transform.rotation = Camera.main.transform.rotation;	 
				
				//	gameObject.transform.Rotate (Camera.main.transform.eulerAngles);
		}
}
