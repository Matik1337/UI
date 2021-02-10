using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class HealthControl : MonoBehaviour
{
    [SerializeField] private float _health;
    [SerializeField] private Slider _slider;

    private const float _healthDelta = 10f;
    
    void Start()
    {
        _health = 50;
        _slider.value = _health;
    }
    
    public void IncreaceHealth()
    {
        Debug.Log("1");
        if ((_health + _healthDelta) <= 110f)
        {
            Debug.Log("2");
            _health += _healthDelta;
            StartCoroutine(ChangeHealthBar());
        }
    }

    public void DecreaceHealth()
    {
        if (_health >= _healthDelta)
        {
            _health -= _healthDelta;
            StartCoroutine(ChangeHealthBar());
        }
    }

    private IEnumerator ChangeHealthBar()
    {
        float step = 0.5f;
        
        while (_slider.value != _health)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, _health, step);
            
            yield return null;
        }
    }
}
