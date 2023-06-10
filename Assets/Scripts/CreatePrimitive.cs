using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePrimitive : MonoBehaviour
{

    public List<PrimitiveType> primitives = new List<PrimitiveType>();
    // Start is called before the first frame update
    void Start()
    {
        
        primitives.Add(PrimitiveType.Cube);
        primitives.Add(PrimitiveType.Capsule);
        primitives.Add(PrimitiveType.Cylinder);
        primitives.Add(PrimitiveType.Sphere);
        InvokeRepeating("CreateObj", 1.5f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void CreateObj()
    {
        GameObject go = GameObject.CreatePrimitive(primitives[Random.Range(0,primitives.Count)]);
        go.transform.position = new Vector2(Random.Range(-2.33f, 2.33f), Random.Range(3.47f, 4.67f));
        go.AddComponent(typeof(Rigidbody));
    }
}
