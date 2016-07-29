using UnityEngine;
using System.Collections;

public class TeleportScript : MonoBehaviour
{
		public Camera a;
		public Camera b;

		public Vector3 position;

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}
	
		void OnTriggerEnter (Collider other)
		{
				Debug.Log ("Teleport");
				
				TeleportationTimeScript timeScript = other.gameObject.GetComponent<TeleportationTimeScript> ();
				
				if (Time.time - timeScript.lastTeleportationTime > 5.0f) {
						float temp = a.depth;
						a.depth = b.depth;
						b.depth = temp;
						timeScript.lastTeleportationTime = Time.time;
						other.gameObject.transform.position = position;
						//	other.gameObject.transform.Rotate (new Vector3 (0.0f, 180.0f, 0.0f));
						//	other.gameObject.rigidbody.velocity = -other.gameObject.rigidbody.velocity;
				}
		}
}
