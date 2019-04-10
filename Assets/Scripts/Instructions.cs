using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace other
{
    public class Instructions : MonoBehaviour
    {

        public void back()
        {
            SceneManager.LoadScene(0);
        }
    }
}