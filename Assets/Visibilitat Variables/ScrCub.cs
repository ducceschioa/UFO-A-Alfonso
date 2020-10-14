using UnityEngine;
using System.Collections;


/*------------------------------------------------------------------------
 * Autor: Jordi Aguilera
 * Data: 28/09/16
 * Descripció: script creat per mostrar diferents tipus de visibilitat de
 *             les variables
 * -----------------------------------------------------------------------*/
  
    public class ScrCub : MonoBehaviour {
    public float forsa = 10;            // -------------------  variabla pública   --------------------------
    int salts=5;                        // -------------------  variable privada   --------------------------
    public static int cubsAEscena = 0;  // -------------------  variable de classe --------------------------

    void Start()
    {
        cubsAEscena++;                   // cada vegada que es crea un enemic, incrementem aquesta variable
        forsa = Random.Range(50, 100);    // establim la força de l'enemic amb un valor entre 50 i 100
        print("Hi ha " + cubsAEscena + " cubs. Aquest té una força = " + forsa);  // mostrem el nombre de cubs i la força d'aquest
    }

    // Quan el cub es destrueixi, que decrementi el nombre de cubs
    // OnDestroy és un event: quelcom que passa que és detectble pel sistema
    void OnDestroy()
    {
        cubsAEscena--;
    }
}
