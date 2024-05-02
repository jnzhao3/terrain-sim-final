using UnityEngine;
//https://docs.unity3d.com/Manual/InstantiatingPrefabs.html
public class CircleFormation : MonoBehaviour
{
   // Instantiates prefabs in a circle formation
   public GameObject prefab;
   public int numberOfObjects = 20;
   public float radius = 5f;
   public float move = 0;
   void Start()
   {
       for (int i = 0; i < numberOfObjects; i++)
       {
           float angle = i * Mathf.PI * 2 / numberOfObjects;
           float x = Mathf.Cos(angle) * radius;
           float z = Mathf.Sin(angle) * radius;
           Vector3 pos = transform.position + new Vector3(x, 0, z);
           float angleDegrees = -angle*Mathf.Rad2Deg;
           Quaternion rot = Quaternion.Euler(0, angleDegrees, 0);
           Instantiate(prefab, pos, rot);
       }
    //    timestep++;
   }

   void Update()
   {
    // for (int i = 0; i < numberOfObjects; i++) 
    // {
    //     // float angle = i * Mathf.PI * 2 / numberOfObjects;
    //     // float x = Mathf.Cos(angle) * radius;
    //     // float z = Mathf.Sin(angle) * radius;
    //     // Vector3 pos = transform.position + new Vector3(x, timestep, z);
    //     // float angleDegrees = -angle*Mathf.Rad2Deg;
    //     // Quaternion rot = Quaternion.Euler(0, angleDegrees, 0);
    //     // Instantiate(prefab, pos, rot);
    //     transform.Translate()
    // }
    // if (move == 3) {
    //     move = 0;
    // } else {
    //     move++;
    // }
    
   }
}