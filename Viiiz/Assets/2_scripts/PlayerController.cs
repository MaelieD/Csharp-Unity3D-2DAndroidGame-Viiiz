using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	[SerializeField]
	private Rigidbody2D rgbd;
	[SerializeField]
	public float playerYSpeed = 80f;
	[SerializeField]
	public float bounce = 1f;
	[SerializeField]
	private float playerXSpeed = 100f;

	// Use this for initialization
	void Start () {
		rgbd.velocity = new Vector3 (playerXSpeed, bounce, 0);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		// vitesse constante pour rebondir d'un mur à l'autre
		// stop bouncing , go up

		if (Input.GetKey (KeyCode.Space)) {
			if(rgbd.velocity.x != 0)
				playerXSpeed = rgbd.velocity.x;
			rgbd.velocity = new Vector3 (0, playerYSpeed, 0);
		} else if(rgbd.velocity.x == 0){ // /*Input.GetKeyUp(KeyCode.Space)*/ BUG si relache trop vite
			rgbd.velocity = new Vector3 (playerXSpeed, bounce, 0);
		}
	}
}
