using UnityEngine;

public class Bullet : MonoBehaviour, IBullet
{
    private Transform target;
    public float speed;
    public float offSet;
    public GameObject prHitFX;
    
    public void Seek(Transform Target)
    {
        target = Target;
    }

    private void FixedUpdate()
    {
        MoveBullet();
    }

    private void MoveBullet()
    {
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }
        Vector3 dir = new Vector3(target.position.x, target.position.y, target.position.z) - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;
        
        transform.LookAt(target);

        if (dir.magnitude <= distanceThisFrame + offSet)
        {
            HitTarget();
            return;
        }
        transform.Translate(dir.normalized * distanceThisFrame, Space.World);
    }
    
    
    private void HitTarget()
    {
        target.GetComponent<Player_SM>().TriggerDeath();
        Instantiate(prHitFX, target.transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
