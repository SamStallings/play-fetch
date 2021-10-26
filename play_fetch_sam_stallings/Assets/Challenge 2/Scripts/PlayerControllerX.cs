using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float coolDown;
    private float timeToRespawn = 1.5f;

    // Update is called once per frame
    void Update()
    {
        coolDown += Time.deltaTime;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && coolDown > timeToRespawn)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            coolDown = 0;
        }
    }
}