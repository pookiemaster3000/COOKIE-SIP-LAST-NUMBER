using UnityEngine;

public class WorkerVisibility : MonoBehaviour
{
    public int thisWorkerNumber;

    void Start()
    {
        int chosen = PlayerPrefs.GetInt("ChosenWorker", 0);
        if (chosen != thisWorkerNumber)
        {
            gameObject.SetActive(false);
        }
    }
}