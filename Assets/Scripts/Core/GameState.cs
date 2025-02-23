using Unity.VisualScripting;
using UnityEngine;

namespace FlappyBird.Core
{
    public sealed class GameState
    {
        public WalletData Wallet { get; set; }
        public CharacterData Character { get; set; }

        public GameState()
        {
            Wallet = new WalletData();
            Character = new CharacterData();
        }
    }

    public class WalletData
    {
        private int _coins;

        public void AddCoins(int coins)
        {
            if(CheckValue(coins))
            {
                _coins += coins;
            }
        }

        public void RemoveCoins(int coins)
        {
            if (CheckValue(coins))
            {
                _coins -= coins;
            }
        }

        private bool CheckValue(int coins)
        {
            if (coins < 0)
            {
                Debug.LogError($"Значение не может быть {coins}");
                return false;
            }

            return true;
        }
    }

    public class CharacterData
    {
        public int SkinIdentifier { get; set; } = 1;
    }
}

