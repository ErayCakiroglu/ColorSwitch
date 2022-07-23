using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class TopHareket : MonoBehaviour
{
    [SerializeField] Rigidbody2D top;
    [SerializeField] float ziplamaGucu;
    [SerializeField] Color turkuazRenk, pembeRenk, sariRenk, morRenk;
    [SerializeField] string mevcutRenk = default;
    [SerializeField] SpriteRenderer ressam;
    [SerializeField] Transform renkDegistirici, kontrolCubugu1, kontrolCubugu2, kontrolCubugu3, cember, doubleCember, kare;
    [SerializeField] TextMeshProUGUI skorYazisi;
    [SerializeField] int skor;
    [SerializeField] AudioSource ziplamaMuzigi;

    void Start()
    {
        RastgeleRenk();
    }

    void Update()
    {

        skorYazisi.text = "Skor : " + skor.ToString();

        if(Input.GetKeyDown(KeyCode.Space))
        {
            top.velocity = Vector2.up * ziplamaGucu;
            ziplamaMuzigi.Play();
        }
        
    }

    void OnTriggerEnter2D(Collider2D temas)
    {
        if(temas.tag != mevcutRenk && temas.tag != "RenkDegistirici" && temas.tag != "KontrolCubugu1" && temas.tag != "KontrolCubugu2" && temas.tag != "KontrolCubugu3")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if(temas.tag == "RenkDegistirici")
        {
            skor += Random.Range(2, 5);
            renkDegistirici.position = new Vector3(renkDegistirici.position.x, renkDegistirici.position.y + 7f, renkDegistirici.position.z);
            RastgeleRenk();
        }

        if(temas.tag == "KontrolCubugu1")
        {
            kontrolCubugu1.position = new Vector3(kontrolCubugu1.position.x, kontrolCubugu1.position.y + 21f, kontrolCubugu1.position.z);

            cember.position = new Vector3(cember.position.x, cember.position.y + 21f, cember.position.z);
        }

        if(temas.tag == "KontrolCubugu2")
        {
            kontrolCubugu2.position = new Vector3(kontrolCubugu2.position.x, kontrolCubugu2.position.y + 21f, kontrolCubugu2.position.z);

            doubleCember.position = new Vector3(doubleCember.position.x, doubleCember.position.y + 21f, doubleCember.position.z);
        }

        if(temas.tag == "KontrolCubugu3")
        {
            kontrolCubugu3.position = new Vector3(kontrolCubugu3.position.x, kontrolCubugu3.position.y + 21f, kontrolCubugu3.position.z);

            kare.position = new Vector3(kare.position.x, kare.position.y + 21f, kare.position.z);
        }
    }

    void RastgeleRenk()
    {
        int rastgele = Random.Range(0, 4);
        switch (rastgele)
        {
            case 0:
                mevcutRenk = "Turkuaz";
                ressam.color = turkuazRenk;
                break;
            case 1:
                mevcutRenk = "Pembe";
                ressam.color = pembeRenk;
                break;
            case 2:
                mevcutRenk = "Sarı";
                ressam.color = sariRenk;
                break;
            case 3:
                mevcutRenk = "Mor";
                ressam.color = morRenk;
                break;
        }
    }
}
