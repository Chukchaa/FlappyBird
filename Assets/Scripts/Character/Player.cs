using UnityEngine;

namespace FlappyBird.Character
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer _spriteRenderer;

        public void ChangeSprite(Sprite sprite)
        {
            _spriteRenderer.sprite = sprite;
        }
    }
}
