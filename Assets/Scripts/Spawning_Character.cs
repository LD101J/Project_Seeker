using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AuraVision_ProjectSeeker
{
    /// <summary>
    /// this class deals with spawning characters
    /// </summary>
    public class Spawning_Character : MonoBehaviour
    {
        #region Psuedocode for spawning characters
        //i need variables for all prefabs
        //i also need a variable to store these spawned objects
        //on start, i need to call these lists
        #endregion

        #region Variables for spawning
        //spawning gameobjects
        [SerializeField] private GameObject[] civilians;//survivors
        [SerializeField] private GameObject killer;// onyx is the killer(hunter)
        //storage variables for spawning
        private GameObject civilianStore;
        private GameObject onyxStore;
        
        #endregion

        private void Start()
        {
            #region Spawning & Storing
            
            onyxStore = Instantiate(killer);//spawning & storing killer prefab, this will not spawn when the game begins
            #endregion
        }
    }
}