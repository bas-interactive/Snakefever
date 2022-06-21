using UnityEngine;
using System;

namespace snakefever
{
    public class MainMenu : GameState
    {
        public MainMenu(GameStateMachine stateMachine) : base(stateMachine)
        {
        }

        public override void Enter()
        {
            base.Enter();
            GameManager.Instance.TransitionManager.FadeIn();
        }

        public override void Exit()
        {
            base.Exit();
        }
        public override void CreateLobby()
        {
            
        }

        public override void JoinLobby()
        {
            _stateMachine.SetState(new Transition(_stateMachine, new JoinLobbyMenu(_stateMachine)));
        }

        public override void Quit()
        {
            Application.Quit();
        }
    }
}
