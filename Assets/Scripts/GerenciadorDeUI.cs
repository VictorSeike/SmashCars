using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GerenciadorDeUI : MonoBehaviour
{

    public Image painelDeVidas;
   
    public Sprite[] vidas;

    public int placar;
    public Text textoPlacar;
   
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       
    }

        public void AtualizarVidas( int vidasAtuais )
    {
        painelDeVidas.sprite = vidas[vidasAtuais];
    }

    public void AtualizarPlacar()
    {
        placar = placar + 100;
        // placar += 100;
       
        textoPlacar.text = "PLACAR : " + placar;

    }






}