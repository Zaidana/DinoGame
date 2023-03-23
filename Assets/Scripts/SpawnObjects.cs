using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public static SpawnObjects instance;
    [SerializeField] private GameObject[] obstacles;
    [SerializeField] private GameObject flyingObstacle;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        InvokeRepeating("SpawnObstacles", 0.5f, 5);
        
    }

    public void SpawnObstacles()
    {
        
            int randomIndex = Random.Range(0, obstacles.Length);    
            GameObject objetoInstanciado = Instantiate(obstacles[randomIndex], transform.position, Quaternion.identity);   
            Destroy(objetoInstanciado, 8);
        
    }

    
}
