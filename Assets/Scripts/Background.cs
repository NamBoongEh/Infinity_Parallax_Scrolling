using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background: MonoBehaviour
{
    public Transform cloud;
    public float speedCloud;

    public Transform mountain;
    public float speedMountain;

    public Transform midground;
    public float speedMidground;

    public Transform plant;
    public float speedPlant;

    public int prevNum;

    void Update()
    {
        Move();

        if(cloud.localPosition.x <= -8.5f)
            TransCloud();
        if(mountain.localPosition.x <= -65f)
            TransMountain();
        if(midground.localPosition.x <= -50f)
            TransMidground();
        if (plant.localPosition.x <= -30f)
            TransPlant();
    }

    void Move()
    {
        cloud.localPosition -= new Vector3(speedCloud * Time.deltaTime, 0f, 0f);
        mountain.localPosition -= new Vector3(speedMountain * Time.deltaTime, 0f, 0f);
        midground.localPosition -= new Vector3(speedMidground * Time.deltaTime, 0f, 0f);
        plant.localPosition -= new Vector3(speedPlant * Time.deltaTime, 0f, 0f);
    }

    void TransCloud()
    {
        cloud.localPosition = GameObject.Find("Cloud" + prevNum).GetComponent<Transform>().position;
        cloud.localPosition += new Vector3(4, 0, 0);
    }

    void TransMountain()
    {
        mountain.localPosition = GameObject.Find("Mountains" + prevNum).GetComponent<Transform>().position;
        mountain.localPosition += new Vector3(30, 0, 0);
    }

    void TransMidground()
    {
        midground.localPosition = GameObject.Find("Midground" + prevNum).GetComponent<Transform>().position;
        midground.localPosition += new Vector3(20, 0, 0);
    }

    void TransPlant()
    {
        plant.localPosition = GameObject.Find("Plant" + prevNum).GetComponent<Transform>().position;
        plant.localPosition += new Vector3(10, 0, 0);
    }
}
