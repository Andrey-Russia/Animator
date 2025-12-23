using UnityEngine;

public class jumpj : MonoBehaviour
{
    public Animator animator;

    void Start()
    {
        if (!animator)
        {
            Debug.LogError("Привяжите аниматор к этому скрипту!");
        }
    }

    public void PlayAnimation()
    {
        animator.SetTrigger("HI");
    }
}
