﻿using UnityEngine;
using System.Collections;

//static class to control events across the game
//has to be cleared on scene load
public static class EventManager
{
	
		public delegate void GameEvent ();
	
		public static event GameEvent GamePause, GameResume, PlayerDeath, GameRestart;

		public static void TriggerGamePause ()
		{
				if (GamePause != null) {
						GamePause ();
				}
		}

        public static void TriggerPlayerDeath()
        {
            if (PlayerDeath != null)
            {
                PlayerDeath();
            }
        }
	
		public static void TriggerGameResume ()
		{
				if (GameResume != null) {
						GameResume ();
				}
		}

		
		
		public static void TriggerGameRestart ()
		{
            if (GameRestart != null)
            {
                GameRestart();
            }
				GameResume = null;
				GamePause = null;
                PlayerDeath = null;
				
		}
	
}
