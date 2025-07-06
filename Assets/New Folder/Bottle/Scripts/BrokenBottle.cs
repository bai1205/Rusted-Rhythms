using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrokenBottle : MonoBehaviour
{
    [SerializeField] GameObject[] pieces;
    [SerializeField] float velMultiplier = 2f;
    [SerializeField] float timeBeforeDestroying = 3f;
    [SerializeField] GameObject bottle;
    bool die = false;
    private void Awake()
    {
        die = true;
    }

    void Start()
    {

        Destroy(this.gameObject, timeBeforeDestroying);
    }
    private void OnDestroy()
    {
        GameObject brokenBottle = Instantiate(bottle, this.transform.position, Quaternion.identity);
    }
    public void RandomVelocities()
    {
        for (int i = 0; i <= pieces.Length - 1; i++)
        {
            float xVel = UnityEngine.Random.Range(0f, 1f);
            float yVel = UnityEngine.Random.Range(0f, 1f);
            float zVel = UnityEngine.Random.Range(0f, 1f);
            Vector3 vel = new Vector3(velMultiplier * xVel, velMultiplier * yVel, velMultiplier * zVel);
            pieces[i].GetComponent<Rigidbody>().velocity = vel;
        }
    }
}