﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetGen : MonoBehaviour
{

    private GameObject obj;
    private Transform t;
    private PlanetGravity planetGrav;
    private OrbitPlanet orbitPlanet;

    private Material[] materials;
    public Material dirt;
    public Material grass;
    public Material stone;
    public Material sand;
    public Material snow;

    private int min = 0;
    private int max = 4;

    // Start is called before the first frame update
    void Start()
    {
        materials = new Material[5];
        materials[0] = dirt;
        materials[1] = grass;
        materials[2] = stone;
        materials[3] = sand;
        materials[4] = snow;

        obj = new GameObject("obj1");
        t = obj.transform;
        t.position = new Vector3(0f, 0f, 0f);
        transform.parent = t;
        transform.position = new Vector3(Random.Range(90f, 500f), 0f, 0f);
        transform.localScale = Vector3.one * Random.Range(1.5f, 3.5f);
        t.localRotation = Quaternion.Euler(Vector3.up * Random.Range(0f, 360f));
        transform.parent = null;
        Destroy(obj);
        transform.localRotation = Quaternion.Euler(Vector3.up * Random.Range(0f, 360f));
        transform.localRotation = Quaternion.Euler(Random.Range(0f, 360f), Random.Range(0f, 360f), Random.Range(0f, 360f));
        planetGrav = gameObject.GetComponent<PlanetGravity>();
        planetGrav.maxDist = transform.localScale.magnitude * 4f;
        planetGrav.strength = 3f;
        orbitPlanet = gameObject.GetComponent<OrbitPlanet>();
        orbitPlanet.rotationSpeed = Random.Range(0.5f, 1.5f);
        gameObject.GetComponentInChildren<Renderer>().material = materials[Random.Range(min, max)];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
