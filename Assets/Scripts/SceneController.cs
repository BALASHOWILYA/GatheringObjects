using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField] private GameObject circlePrefab;
    [SerializeField] private Transform positionSquare;

    private List<GameObject> _circlePrefab = new List<GameObject>();
    private int _circleNum = 5;
    private Vector3 _pos;
    

    private void Start()
    {
        CreateCircles();
    }

    private void CreateCircles()
    {
        for(int i = 0; i < _circleNum; i++)
        {
           
            _pos = new Vector3(Random.Range(-6, 6), Random.Range(-4, 4));

            if (Mathf.Abs(positionSquare.position.x - _pos.x) > 2 || Mathf.Abs(positionSquare.position.y - _pos.y) > 2)
            {
                _circlePrefab.Add(Instantiate(circlePrefab, _pos, Quaternion.identity));
            }
            else i--;
            
        }
        
    }
}
