using UnityEngine;
using System.Collections;

/*------------------------------------------------------------------------
 * Autor: Jordi Aguilera
 * Data: 28/09/16
 * Descripció: es fa servir juntament amb ScrCub per mostrar aspectes 
 *             relacionatas amb la visivilitat de les variables. 
 * Interacció:
 *      - Cada cop que pitgem la tecla C generarà un cub amb posició i color
 *        aleatori, i mostrarà informació particular del cub i general de la 
 *        classe (nombre de cubs a escena)
 *      - Cada cop que pitgem I, mostra el nombre de cubs que hi ha a l'escena, 
 *        llegint la variable de classe públic cubsAEscena
 *        
 * Inicialització: 
 *   Cal establir la variable pública cub a l'Inspector
 *   
 * Notes:
 *   Podem esborrar cubs des del inspector, per veure com el nombre de cubs 
 *   s'actualitza automàticament  
 * -----------------------------------------------------------------------*/

public class ScrTest : MonoBehaviour {

    public GameObject cub;

	// Update is called once per frame
	void Update () {
        GameObject nuevoCubo;
        if (Input.GetKeyDown(KeyCode.C))  // Generem cubs
        {
            nuevoCubo = Instantiate(cub);                   // creem un nou cub
            nuevoCubo.name = "Cub " + ScrCub.cubsAEscena;   // li donem un nom
            // I el posicionem en una ubicació aleatoria entre -3 i 3 per x, y i z
            nuevoCubo.transform.position = new Vector3(Random.Range(-3f, 3f), Random.Range(-3f, 3f), Random.Range(-3f, 3f));
            nuevoCubo.GetComponent<Renderer>().material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        }
        
        if (Input.GetKeyDown(KeyCode.I))
        {
            print("El nombre total de cubs és: "+ScrCub.cubsAEscena );
        }

        if (Input.GetMouseButtonDown(0)) Test(); // Si pitgem el ratolí, mirem si hem picat sobre algun cub
    }

    void Test()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);   
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
             print("El " + hit.transform.name + " té una força de: "+hit.transform.GetComponent<ScrCub>().forsa);
        }
    }
}
