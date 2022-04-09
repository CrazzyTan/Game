using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundElement : MonoBehaviour
{
    [SerializeField]
	private float speed;

    public void Move()
    {
        transform.Translate(Vector2.left * speed * Time.smoothDeltaTime); 
    }
}
