using UnityEngine;
using System.Collections;

public class WallGenerator : MonoBehaviour {

	// Color Level 1
	Color c1 = new Color(178, 39, 0, 255);//#B22700;
	Color c2 = new Color(255, 76, 25, 255);//#FF4C19;
	Color c3 = new Color(255, 56, 0, 255);//#FF3800;

	public int maxPlatforms = 50;

	[SerializeField]
	public GameObject squareWallRight;
	[SerializeField]
	public GameObject squareWallLeft;

	public int horizontalMin = 1;
	public int horizontalMax = 5;

	private Vector2 originPosition;

	// Use this for initialization
	void Start () {
		SpawnSquares (squareWallRight.transform.position);
		SpawnSquares (squareWallLeft.transform.position);
	}
	
	// Update is called once per frame
	void Update () {

	}

	void SpawnSquares(Vector3 originPosition)
	{
		for (int i = 0; i < maxPlatforms; i++) {
			Vector3 nextPosition = originPosition;
			for (int j = 0; j < Random.Range(horizontalMin, horizontalMax); j++)
			{
				Instantiate (squareWallRight, nextPosition, Quaternion.identity);
				originPosition = nextPosition;
			}
		}
	}
}
