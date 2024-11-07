using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class CollectibleManager : MonoBehaviour
{
    public GameObject originalPrefab;

    public void Awake()
    {
        Instantiate(originalPrefab,
            new Vector3(UnityEngine.Random.Range(0,10),0, UnityEngine.Random.Range(0, 10)),
            Quaternion.identity,
            transform
            );
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
