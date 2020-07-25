using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    public Transform do_teleport;
    public GameObject gracz;

    void OnTriggerEnter(Collider other)
    {
        gracz.transform.position = do_teleport.transform.position;
        gracz.transform.rotation = do_teleport.transform.rotation;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
