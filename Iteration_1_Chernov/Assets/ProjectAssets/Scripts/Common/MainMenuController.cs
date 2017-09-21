using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Iteration1.Common
{
    public class MainMenuController : MonoBehaviour
    {
        [SerializeField] private GameObject _mainUi;

        public void Start()
        {
            _mainUi.SetActive(true);
        }

        public void OnDisable()
        {
           _mainUi.SetActive(false); 
        }

        public void LodButtonHandler()
        {
            SceneManager.LoadScene(Constants.SceneNames.LodSceneName, LoadSceneMode.Additive);
        }

        public void BatchingButtonHandler()
        {
            SceneManager.LoadScene(Constants.SceneNames.BatchingSceneName, LoadSceneMode.Additive);
        }

        public void CullingButtonHandler()
        {
            SceneManager.LoadScene(Constants.SceneNames.CullingSceneName, LoadSceneMode.Additive);
        }

        public void NavigationButtonHandler()
        {
            SceneManager.LoadScene(Constants.SceneNames.NavigationSceneName, LoadSceneMode.Additive);
        }

        public void LightmapsButtonHandler()
        {
            SceneManager.LoadScene(Constants.SceneNames.LightmapsSceneName, LoadSceneMode.Additive);
        }

        public void AnimationsButtonHandler()
        {
            SceneManager.LoadScene(Constants.SceneNames.AnimationsSceneName, LoadSceneMode.Additive);
        }

        public void LightprobeButtonHandler()
        {
            SceneManager.LoadScene(Constants.SceneNames.LightprobeSceneName, LoadSceneMode.Additive);
        }
    }
}