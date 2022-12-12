using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCubeRandomLocation3 : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject cube1;
    public int spawnNumberLocation;
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {

        spawnpoint();

    }
    private void Update()
    {
        target = GameObject.Find("Following Cube (2)(Clone)");
    }
    public void spawnpoint()
    {
        spawnNumberLocation = UnityEngine.Random.Range(0, spawnPoints.Length);

        Instantiate(cube1, spawnPoints[spawnNumberLocation].transform.position, Quaternion.identity);

        StartCoroutine(Wait());
    }

    IEnumerator Wait()

    {
        yield return new WaitForSeconds(2);
        target.SetActive(false);
        spawnpoint();

    }
}
