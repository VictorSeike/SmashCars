using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAInimigo : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float _velocidade = 25.5f;

    [SerializeField]
    private GameObject _explosaoDoInimigo;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.down * _velocidade * Time.deltaTime);


        if (transform.position.y < -15.8f)
        {
            transform.position = new Vector3(Random.Range(-7.12f, 7.45f), 32.7f, 0);
        }
        
    }


    private void OnTriggerEnter2D(Collider2D other)
    {

        Debug.Log("O objeto " + name + " colidiu com o objeto " + other.name);

        if (other.tag == "Tiro")
        {
            Destroy(other.gameObject);
            Instantiate(_explosaoDoInimigo, transform.position, Quaternion.identity);
            Destroy(this.gameObject);

        }



        if (other.tag == "Player")
        {
            Player player = other.GetComponent<Player>();

            if (player != null)
            {
                player.DanoAoPLayer();
            }


        }

        
    }
        
        
}