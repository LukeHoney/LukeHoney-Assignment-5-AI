using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCubeRandomLocation : MonoBehaviour
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
        target = GameObject.Find("Following Cube(Clone)");
    }
    public void spawnpoint()
    {
        spawnNumberLocation = UnityEngine.Random.Range(0, spawnPoints.Length); 

        Instantiate(cube1, spawnPoints[spawnNumberLocation].transform.position, Quaternion.identity);

        StartCoroutine(Wait());
    }

    IEnumerator Wait()

    {
        yield return new WaitForSeconds(3);
        target.SetActive(false);
        spawnpoint();
        
    }
}
