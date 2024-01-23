using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusterErstellen : MonoBehaviour
{
    int zeilenAnzahl = 3;

    void Start()
    {
        for (int zeile = 1; zeile <= zeilenAnzahl; zeile++)
        {
            string ausgabe = "";

            ausgabe = GeneriereMinuszeichen(ausgabe, zeile);

            for (int sterne = 1; sterne <= 2 * zeile - 1; sterne++)
            {
                ausgabe += "*";
            }

            ausgabe = GeneriereMinuszeichen(ausgabe, zeile);

            Debug.Log(ausgabe);
        }
    }

    private int GeneriereMinuszeichen(string ausgabe, int zeile)
    {
        for(int minuszeichen = 1; minuszeichen <= zeilenAnzahl - zeile; minuszeichen++)
        {
            ausgabe += "-";
        }
        return ausgabe;
    }

}
