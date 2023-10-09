using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocidade = 20.0f;
    public float entradaHorizontal;
    public float entradaVertical;

    public GameObject pfLaser;

    public float tempoDeDisparo = 0.3f;

    public float podeDisparar = 0.0f;

    public bool possoDarDisparoTriplo = false;

    public GameObject DisparoTriplo;

    public int vidas = 3;



    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start de " + this.name);
        velocidade = 30.0f;
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {

        Movimento();

        
        
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {

            Disparo();

        }

    }

    
        private void Movimento()
    { 

        entradaHorizontal = Input.GetAxisRaw("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * velocidade * entradaHorizontal);

        if (transform.position.x < -6.8f)
        {
            transform.position = new Vector3(-6.8f, transform.position.y, 0);
        }
        
        if (transform.position.x > 7)
        {
            transform.position = new Vector3(7f, transform.position.y, 0);
        }

        entradaVertical = Input.GetAxisRaw("Vertical");
        transform.Translate(Vector3.up * Time.deltaTime * velocidade * entradaVertical);
        
        if (transform.position.y < -5.5f)
        {
            transform.position = new Vector3(transform.position.x, -5.5f, 0);
        }

    }

    private void Disparo()
    {

        if (Time.time > podeDisparar)
        {

            if (possoDarDisparoTriplo == true)
            {

                Instantiate(DisparoTriplo, transform.position + new Vector3(0, 1.1f, 0), Quaternion.identity);

            }
            else
            {

                Instantiate(pfLaser, transform.position + new Vector3(0, 1.1f, 0), Quaternion.identity);
            }

            podeDisparar = Time.time + tempoDeDisparo;

        }
    }


    public IEnumerator DisparoTriploRotina()
    {
        yield return new WaitForSeconds(7.0f);

        possoDarDisparoTriplo = false;
    }

    public void LigarPUDisparoTriplo()
    {
        possoDarDisparoTriplo = true;
        StartCoroutine(DisparoTriploRotina());
    }

    public void DanoAoPLayer()
    {
        vidas--;

        if (vidas < 1)
        {
            Destroy(this.gameObject);
        }
    }
}
           
        


                

