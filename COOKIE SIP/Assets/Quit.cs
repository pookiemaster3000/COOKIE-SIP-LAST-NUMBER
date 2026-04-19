using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour
{
   public void ClickButton()
{
    SceneManager.LoadScene("Scene 1-Start Page");

}
}