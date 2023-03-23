using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBirdy : MonoBehaviour
{
    public static SpawnBirdy instance;
    [SerializeField] private GameObject flyingObstacle;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        InvokeRepeating("SpawnFlying", 2f, 8);
    }

    public void SpawnFlying()
    {
        GameObject birdy = Instantiate(flyingObstacle, transform.position, Quaternion.identity);
        Destroy(birdy, 8);
    }
}
