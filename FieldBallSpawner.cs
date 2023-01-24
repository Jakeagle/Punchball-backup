using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldBallSpawner : MonoBehaviour
{
	public float spawnInterval;

	public GameObject FieldBall;

	public float BallSpeed;

	public static FieldBallSpawner instance;

	//if this is true the script will spawn balls
	public bool SpawningBalls = true;


	private bool SpawnedBalls = false;

	private void Awake()
	{
		if (instance == null)
			instance = this;
	}

	private void Update()
	{
		if (SpawningBalls)
			if (!SpawnedBalls)
				StartCoroutine(SpawnFieldBallsR());
	}

	public IEnumerator SpawnFieldBallsR()
	{
		SpawnedBalls = true;
		yield return new WaitForSeconds(spawnInterval);

		GameObject BallSpawner = Instantiate(FieldBall, transform.position, transform.rotation);

		SpawnedBalls = false;
	}
}