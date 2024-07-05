using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Assets.Scripts
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] PlayerController[] playerController;

        int turns;

        private void Start()
        {
            for (int i = 0; i < playerController.Length - 1; i++)
            {
                playerController[i].ID = i;
                playerController[i].Init();
                if ((playerController.Length) / 2 < i)
                {
                    playerController[i].play = Play.Player;
                }

                playerController[i].play = Play.Enemy;
            }
        }

        public void NextTurn(int turn)
        {
            turns = 1;
            turns = turns == turn ? 1 : 0;
        }

        public bool CurrentTurn()
        {
            return turns.Equals(0);
        }

        public void Action(Play play)
        {
             
        }
    }
}