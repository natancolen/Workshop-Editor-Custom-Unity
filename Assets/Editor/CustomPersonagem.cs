using System.Collections;
using System.Collections.Generic;
using UnityEditor;

[CanEditMultipleObjects, CustomEditor(typeof(Personagem))]
public class CustomPersonagem : Editor {
    public override void OnInspectorGUI() {
        base.OnInspectorGUI();

        Personagem personagem = (Personagem)this.target;

        personagem.nivel = (int)EditorGUILayout.Slider("Level", personagem.nivel, 0, 100);
        personagem.hpMultiplayer = (int)(personagem.hpMultiplayer * personagem.nivel);

        EditorGUILayout.LabelField("HP: " + personagem.hp);

    }
}