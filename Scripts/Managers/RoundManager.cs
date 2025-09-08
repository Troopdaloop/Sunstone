using UnityEngine;

public class RoundManager : MonoBehaviour
{
    public GameObject[] backgrounds; // Assign background GameObjects in Inspector
    public int currentRound = 0;
    public int wavesPerRound = 3;
    private int currentWave = 0;

    public void StartNextWave()
    {
        if (currentWave < wavesPerRound)
        {
            currentWave++;
            SpawnWave(currentWave);
        }
        else
        {
            EndRound();
        }
    }

    void SpawnWave(int waveNumber)
    {
        // Call your WaveManager here with difficulty scaling
        Debug.Log("Spawning wave " + waveNumber + " of round " + currentRound);
        // Example: WaveManager.SpawnWave(waveNumber, currentRound);
    }

    void EndRound()
    {
        currentRound++;
        currentWave = 0;
        SwitchBackground(currentRound);
        GiveReward();
        RefillHealth();
    }

    void SwitchBackground(int round)
    {
        for (int i = 0; i < backgrounds.Length; i++)
        {
            backgrounds[i].SetActive(i == round % backgrounds.Length);
        }
    }

    void GiveReward()
    {
        Debug.Log("Reward granted!");
        // Trigger reward UI or logic here
    }

    void RefillHealth()
    {
        Debug.Log("Health refilled!");
        // Access player health and reset it here
    }
}

