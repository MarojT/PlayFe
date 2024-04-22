using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float cooldown = 2;
    private float time = 0;

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        Debug.Log(time);
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && time >= cooldown)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            time = 0;
        }
    }
}
