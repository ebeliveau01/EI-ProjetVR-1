using System;
using TMPro;
using UnityEngine;

public class Picture : MonoBehaviour {
    public Texture2D newTexture;
    private string startText = "Détail";
    public string text;
    private TextMeshPro textMesh;

    void Start() {
        Transform planeTransform = transform.Find("image");
        textMesh = GetComponentInChildren<TextMeshPro>();

        if (planeTransform != null) {
            Renderer planeRenderer = planeTransform.GetComponent<Renderer>();
            
            if (planeRenderer != null)
                planeRenderer.material.mainTexture = newTexture;
        }

        if (textMesh != null)
            textMesh.text = startText;
    }

    public void ToggleText() {
        if (textMesh.text == startText)
            textMesh.text = text;
        else
            textMesh.text = startText;
    }
}
