using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CloseButton : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   public void ClickButton()
{
    SceneManager.LoadScene("SampleScene");

}
}