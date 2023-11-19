using System.Collections;
using UnityEngine;

public class Tank : MonoBehaviour
{
    public Bullet ProjectilePrefab;
    public Transform FirePoint;

    private void Start()
    {
        StartCoroutine(ShootingRoutine());
    }

    private IEnumerator ShootingRoutine()
    {
        while (true)
        {
            Shoot();
            yield return new WaitForSeconds(0.5f);
            Shoot();
            yield return new WaitForSeconds(0.5f);
            Shoot();
            yield return new WaitForSeconds(3f);
        }
    }

    private void Shoot()
    {
        if (ProjectilePrefab && FirePoint)
        {
            Bullet bullet = Instantiate(ProjectilePrefab, FirePoint.position, FirePoint.rotation);
            bullet.StartFlying(FirePoint.transform.forward);
        }
    }
}