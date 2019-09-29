using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    [SerializeField] private GameObject background, background2, startPosition, endPosition;
    [SerializeField] private Vector3 backgroundMovement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        background.transform.position += backgroundMovement;
        background2.transform.position += backgroundMovement;
        if(background.transform.position.x < endPosition.transform.position.x)
        {
            background.transform.position = startPosition.transform.position;
        }

        if (background2.transform.position.x < endPosition.transform.position.x)
        {
            background2.transform.position = startPosition.transform.position;
        }
    }
}
