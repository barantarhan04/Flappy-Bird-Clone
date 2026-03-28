using UnityEngine;

public class LoopGround : MonoBehaviour
{
    [SerializeField] private float _speed = 1f;
    [SerializeField] private float _width = 6f;

    private SpriteRenderer _spriterenderer;

    private Vector2 _startSize;

    private void Start()
    {
        _spriterenderer = GetComponent<SpriteRenderer>();

        _startSize = new Vector2(_spriterenderer.size.x, _spriterenderer.size.y);
    }

    private void Update()
    {
        _spriterenderer.size = new Vector2(_spriterenderer.size.x + _speed * Time.deltaTime, _spriterenderer.size.y);

        if(_spriterenderer.size.x > _width)
        {
            _spriterenderer.size = _startSize;
        }
    }
}
