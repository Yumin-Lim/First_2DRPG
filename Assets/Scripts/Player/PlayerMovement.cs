using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Config")]
    [SerializeField] private float speed;
    private PlayerActions actions;
    private void Awake()
    {
        actions = new PlayerActions();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable() 
    {
        
    }

    private void OnDisable() 
    {
        
    }
}
