using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pup : MonoBehaviour
{
    [SerializeField]

    private float _velocidade = 3.5f ;

    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * _velocidade * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("O objeto "+name+" colidiu com o objeto "+other.name);
        if (other.tag == "Player"){

            Player player = other.GetComponent<Player>();

            if (player != null){
             player.possoDarDisparoTriplo = true ;
            }
            Destroy(this.gameObject);

        }

    }
}
