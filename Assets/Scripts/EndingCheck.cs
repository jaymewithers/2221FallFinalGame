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
        }
        
        if (goalValue.value == 20)
        {
            print("You win!");
        }
    }
}