using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionBehavior : MonoBehaviour
{
    public bool collided;

    void OnCollisionEnter(Collision collision)
    {
        if (!collided)
        {
            collided = true;
            // 3
            GameObject clown = gameObject.transform.parent.gameObject;
            Animator clownAnimator = clown.GetComponent<Animator>();
            // 4
            clownAnimator.SetTrigger("hit");
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
