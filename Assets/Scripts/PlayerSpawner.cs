using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerSpawner : MonoBehaviour
{
    [SerializeField] GameObject _player;

    [SerializeField] public Vector3 startPosition;

    private void Start()
    {
       _player.transform.position = startPosition;
    }

   
}
