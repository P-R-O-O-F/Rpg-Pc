using UnityEngine;
using System;


public class StartPosition : MonoBehaviour
{
    //[SerializeField] private Vector2 startPosition;
    [SerializeField] private Transform player;
    [SerializeField] private Transform StartElement;
    // Start is called before the first frame update
    private void Awake()
    {
        SetPos();
    }

    private void SetPos()
    {
        Vector3 positionEl = StartElement.position;
        player.position = new Vector3(positionEl.x, positionEl.y, player.position.z);
    }
    // Update is called once per frame
    void Update()
    {

    }
}