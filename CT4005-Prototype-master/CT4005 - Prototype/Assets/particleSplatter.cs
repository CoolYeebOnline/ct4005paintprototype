using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleSplatter : MonoBehaviour
{
    public ParticleSystem particleLauncher;
    public GameObject bomb;
    public decalPool splatDecalPool;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        particleLauncher.Emit(1);
    }
}
