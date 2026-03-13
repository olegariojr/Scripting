using JetBrains.Annotations;
using UnityEngine;

public class NPC : MonoBehaviour
{
    Vector3 newPosition = Vector3.zero;
    int speed = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //NPC Health
        int health = 5;
        //NPC Level
        int level = 3;
        
        print (level+health);
        
                
        

    }

    // Update is called once per frame
    void Update()
    {
        newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        newPosition.y += speed * Time.deltaTime;
        newPosition.x += speed * Time.deltaTime;
        transform.position = newPosition;
        print (newPosition);

    }
}
