using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sparkles : MonoBehaviour
{
    
    private ParticleSystem ps;
    public float spawnTime=1.0f;
    private float elapsedTime = 0.0f;
    private bool isPlaying = false;
    

    void Awake()
    {
        ps = GetComponent<ParticleSystem>();
        if (ps == null)
            ps = gameObject.AddComponent<ParticleSystem>();
        ps.Stop();
        
        
    }
    // Start is called before the first frame update
    void Start()
    {
        //var material = new Material(Shader.Find("Legacy Shaders/Particles/Additive"));
        //ps.GetComponent<ParticleSystemRenderer>().material = material;
        
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && !isPlaying)
        {
            ps.Play();
            isPlaying = true;
            elapsedTime = 0.0f;

        }
        if (isPlaying)
        {
            elapsedTime += Time.deltaTime;
            Debug.Log("elapsedTime " + elapsedTime);

        }
        if(elapsedTime >= spawnTime)
        {
            isPlaying = false;
            ps.Stop();
        }
        
    }
}
