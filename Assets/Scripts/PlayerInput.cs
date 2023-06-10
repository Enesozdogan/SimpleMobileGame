using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class PlayerInput : MonoBehaviour
{
    private PointScore pointScore;
    private void Awake()
    {
        pointScore = GetComponent<PointScore>();
    }
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        GetInput();
    }

    private void GetInput()
    {
        if (Input.touchCount > 0)
        {
            Touch touch= Input.GetTouch(0);
            if(touch.phase== TouchPhase.Began)
            {
               Ray ray=Camera.main.ScreenPointToRay(touch.position);
                RaycastHit hit;
                if(Physics.Raycast(ray, out hit))
                {
                    Destroy(hit.collider.gameObject);
                    pointScore.OnObjDestroy?.Invoke();
                }
            }
        }
    }
}
