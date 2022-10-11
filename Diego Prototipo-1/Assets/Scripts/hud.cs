using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class hud : MonoBehaviour
{
private float vidas;
private TextMeshProUGUI textMesh;
public combate script;


private void Start(){
    textMesh = GetComponent<TextMeshProUGUI>();
}

private void Update(){
    vidas = script.vida;
    textMesh.text = vidas.ToString();
}


}

