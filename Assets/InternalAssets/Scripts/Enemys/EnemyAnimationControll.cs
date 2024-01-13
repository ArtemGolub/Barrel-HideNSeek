using UnityEngine;

[RequireComponent(typeof(Animator))]
public class EnemyAnimationControll : MonoBehaviour
{
    private EnemyComponents _components;

    private void Start()
    {
        _components = GetComponent<EnemyComponents>();
    }

    public void IsMove(bool isMove)
    {
        //get from components
        transform.GetComponent<Animator>().SetBool("isMove", isMove);
    }

    public void IsCatch(bool isCatch)
    {
        _components.Animator.SetBool("isCatch", isCatch);
    }
}
