using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    // These methods can be linked to UI buttons in the Unity Inspector

    public void LoadRandomBattle()
    {
        SceneManager.LoadScene("BattleArena_Random");
    }

    public void LoadScoreBattle()
    {
        SceneManager.LoadScene("BattleArena_Score");
    }

    public void LoadEquipmentRoom()
    {
        SceneManager.LoadScene("EquipmentRoom");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

