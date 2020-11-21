using UnityEngine;

public class EndingCheck : MonoBehaviour
{
    public IntData goalValue;

    private void OnTriggerEnter(Collider other)
    {
        EndCheck();
    }

    private void EndCheck()
    {
        switch (goalValue.value)
        {
            case 0:
                print("You lose!");
                Time.timeScale = 0;
                break;
            case 20:
                print("You win!");
                Time.timeScale = 0;
                break;
        }
    }
}