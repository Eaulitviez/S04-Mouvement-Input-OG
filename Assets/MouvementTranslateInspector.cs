using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvementTranslateInspector : MonoBehaviour
{
    [SerializeReference] private Vector3 _deplacement;
     void Update()
    {
        transform.Translate(_deplacement * Time.deltaTime, Space.World);
    }
        
}
