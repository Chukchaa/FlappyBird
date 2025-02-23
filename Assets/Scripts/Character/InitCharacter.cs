using FlappyBird.Core;
using UnityEngine;
using VContainer;

namespace FlappyBird.Character
{
    public class InitCharacter : MonoBehaviour
    {
        [SerializeField] private Player _player;

        private Player _characterObject;
        private GameState _gameState;

        [Inject]
        public void Construct(GameState gameState, CharacterConfigBase characterConfigBase)
        {
            _gameState = gameState;
            ChatacterCreation(characterConfigBase);
        }

        public void ChatacterCreation(CharacterConfigBase characterConfigBase)
        {
            _characterObject = Instantiate(_player);
            _characterObject.ChangeSprite(characterConfigBase.GetConfig(_gameState.Character.SkinIdentifier).Sprite);
        }
    }
}

