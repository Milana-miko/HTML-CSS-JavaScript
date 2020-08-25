using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class StartScript : MonoBehaviour
{
    public Button Puzzle1;
    public Button Puzzle2;
    public Button Puzzle3;
  
    public void LoadTo(int level)
    {
        SceneManager.LoadScene(level);
    }
}
