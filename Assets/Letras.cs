using UnityEngine;
using TMPro;

public class Letras : MonoBehaviour
{
    public Transform Jogador;
    public TMP_Text contar;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        double pos=Jogador.position.z+491.2;
        contar.text = pos.ToString("0");
    }
}
