using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SueloChecker : MonoBehaviour
{
    public LayerMask mascaraSuelo;
    public float rayDistance = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool IsGrounded()
    {
        RaycastHit2D resultado = Physics2D.Raycast(transform.position,
            Vector2.down, rayDistance, mascaraSuelo.value);

        if (resultado)
        {
            Debug.Log(resultado.collider.gameObject.name);
           // if (resultado.collider.gameObject.CompareTag("suelo"))
            {
                return true;
            }
        }

        return false;
    }

}
