using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Buts : MonoBehaviour
{

    [SerializeField] private GameObject _textePoints;
    [SerializeField] private GameObject _ballon;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
      private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Soccer Ball"){
           _textePoints.SetActive(true);
          
        }
    }
}
