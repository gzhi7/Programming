using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

namespace GoneHome
{
    public class GameManager : MonoBehaviour
    {
        //Switch to next level when this function runs


        public void NextLevel()
        {
            //Get active scene
            Scene currentScene = SceneManager.GetActiveScene();
            // Load the next scene using buildIndex
            SceneManager.LoadScene(currentScene.buildIndex + 1);
        }
            public void ResetLevel()
        {
            //Grab all enemies
            Enemy[] enemies = FindObjectsOfType<Enemy>();
            //Loop through all enemies and rest them
            for (int i = 0; i < enemies.Length; i++)
            {
                // Reset
                enemies[i].Reset();
            }
            // Grab the player and reset it
            Player player = FindObjectOfType<Player>();
            player.Reset();
        }
    }
}