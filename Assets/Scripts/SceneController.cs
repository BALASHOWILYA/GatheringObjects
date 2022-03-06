using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField] private GameObject circlePrefab;
    [SerializeField] private Transform _positionSquare;

    private List<GameObject> _circlePrefab = new List<GameObject>();
    private int _circleNum = 5;
    private Vector3 _pos;
    

    private void Start()
    {
        CreateCircles();
    }
    public void CreateCircles()
    {
        for(int i = 0; i < _circleNum; i++)
        {
            
            _pos = new Vector3(Random.Range(-6, 6), Random.Range(-4, 4));
            if (_positionSquare.position == _pos)
            {
                i--;
                continue;
            }
            _circlePrefab.Add(Instantiate(circlePrefab, _pos, Quaternion.identity));
        }
        
    }
}
