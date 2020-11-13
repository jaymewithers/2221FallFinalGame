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
        if (goalValue.value == 0)
        {
            print("You lose!");
            Time.timeScale = 0;
        }

        if (goalValue.value == 20)
        {
            print("You win!");
            Time.timeScale = 0;
        }
    }
}