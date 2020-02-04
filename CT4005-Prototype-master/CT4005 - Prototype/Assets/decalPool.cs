using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class decalPool : MonoBehaviour
{
    public int maxDecals = 100;

    private ParticleSystem decalParticleSystem;
    private int DecalDataIndex;
    private decalData[] particleData;
    private ParticleSystem.Particle[] particles;

    // Start is called before the first frame update
    void Start()
    {
        decalParticleSystem = GetComponent<ParticleSystem>();
        particles = new ParticleSystem.Particle[maxDecals];
        particleData = new decalData[maxDecals];
        for (int i = 0; i < maxDecals; i++)
        {
            particleData[i] = new decalData();
        }
    }
    
    public void particleHit(ParticleCollisionEvent particleCollisionEvent, Gradient colorGradient)
    {
        SetParticleData(particleCollisionEvent, colorGradient);
        displayParticles();
    }

    void SetParticleData(ParticleCollisionEvent particleCollisionEvent, Gradient colorGradient)
    {
        if (DecalDataIndex >= maxDecals)
        {
            DecalDataIndex = 0;
        }
        DecalDataIndex++;
    }

    void displayParticles()
    {
        for(int i = 0; i < particleData.Length; i++)
        {
            particles[i].position = particleData[i].position;
            particles[i].rotation3D = particleData[i].rotation;
            particles[i].startSize = particleData[i].size;
        }
        decalParticleSystem.SetParticles(particles, particles.Length);
    }

   
}


