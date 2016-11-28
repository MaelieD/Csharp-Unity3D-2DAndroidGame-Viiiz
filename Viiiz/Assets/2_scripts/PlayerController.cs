using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;

	[SerializeField]
	private Rigidbody2D rgbd;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		rgbd.velocity = new Vector3 (0, 50, 0);

		if(Input.GetKey(KeyCode.Space))
			rgbd.velocity = new Vector3 (60, 50, 0);

		/*float moveHorizontal = Input.GetAxis ("Horizontal"); // left and right
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, 0.2f);
		rgbd.AddForce (movement * speed);//*/
	}
}
