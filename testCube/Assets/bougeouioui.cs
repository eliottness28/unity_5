using UnityEngine;
using System.Collections;


public class bougeouioui : MonoBehaviour
{


    const float VITESSE_JOUEUR = 0.1f;
    void Start()
    {
        print("test shooter");
    }

    void OnCollisionEnter(Collision col)
    {
        print("coll");
    }

    void Déplacement()
    {

        if (Input.GetKey(KeyCode.D))
            transform.position += new Vector3(0, 0, VITESSE_JOUEUR);

        if (Input.GetKey(KeyCode.Q))
            transform.position += new Vector3(0, 0, -VITESSE_JOUEUR);

        if (Input.GetKey(KeyCode.Z))
            transform.position += new Vector3(-VITESSE_JOUEUR, 0, 0);

        if (Input.GetKey(KeyCode.S))
            transform.position += new Vector3(VITESSE_JOUEUR, 0, 0);

    }

    // Update is called once per frame
    void Update()
    {

        Déplacement();

    }
     
    //TODO insérer le décor du village viking
    //but du jeu attraper des villagois

}
