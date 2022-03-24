using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace OculusSampleFramework
{
    public class SceneController : MonoBehaviour
    {
       
        public void OpenTouchScene(InteractableStateArgs obj)
        {
            if (obj.NewInteractableState == InteractableState.ActionState)
            {
                SceneManager.LoadScene("TouchInputCube");
            }
        }

        public void ReloadScene(InteractableStateArgs obj)
        {
            if (obj.NewInteractableState == InteractableState.ActionState)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
