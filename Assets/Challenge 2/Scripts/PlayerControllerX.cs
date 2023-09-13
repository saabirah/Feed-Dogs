using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    float spawnCooldown = 0.5f;
    float timeSinceSpawn = 0.0f;



    // Update is called once per frame
    void Update()
    {
        timeSinceSpawn += Time.deltaTime;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && timeSinceSpawn > spawnCooldown)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            timeSinceSpawn = 0.0f;

        }
    }
}
