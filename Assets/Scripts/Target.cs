using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] private Transform[] _points;
    [SerializeField] private float _speed;
    
    private int _currentPoint;

    public void Start()
    {
        _currentPoint = Random.Range(0, _points.Length);
        transform.position = _points[_currentPoint].position;
    }

    private void Update()
    {
        if (transform.position == _points[_currentPoint].position)
            _currentPoint = (_currentPoint + 1) % _points.Length;

        transform.position = Vector3.MoveTowards(transform.position, _points[_currentPoint].position, _speed * Time.deltaTime);
    }
}
