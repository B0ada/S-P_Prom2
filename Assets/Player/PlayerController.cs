using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefabRifle; // Prefab de la bala para el rifle
    [SerializeField] private GameObject bulletPrefabShotgun; // Prefab de la bala para la escopeta
    [SerializeField] private Transform firePointRifle; // Punto de origen del disparo para el rifle
    [SerializeField] private Transform firePointShotgun; // Punto de origen del disparo para la escopeta
    [SerializeField] private int pellets = 5; // Cantidad de proyectiles disparados por vez con la escopeta
    [SerializeField] private float spreadAngle = 20f; // Ángulo de dispersión de los proyectiles de la escopeta
    [SerializeField] private float bulletForce = 20f; // Fuerza con la que se disparan las balas

    private bool isRifleSelected = true;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            isRifleSelected = !isRifleSelected;
        }

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        if (isRifleSelected)
        {
            // Instancia la bala del rifle en el punto de origen del disparo del rifle
            GameObject bullet = Instantiate(bulletPrefabRifle, firePointRifle.position, firePointRifle.rotation);
            // Obtiene el componente Rigidbody2D de la bala y le aplica una fuerza hacia adelante
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.velocity = firePointRifle.right * bulletForce;
            // Destruye la bala después de un cierto tiempo (ajusta esto según tus necesidades)
            Destroy(bullet, 2f);
        }
        else
        {
            for (int i = 0; i < pellets; i++)
            {
                // Calcula una dirección aleatoria dentro del ángulo de dispersión
                Vector2 direction = Quaternion.Euler(0, 0, Random.Range(-spreadAngle, spreadAngle)) * firePointShotgun.right;
                // Instancia la bala de la escopeta en el punto de origen del disparo de la escopeta
                GameObject bullet = Instantiate(bulletPrefabShotgun, firePointShotgun.position, Quaternion.identity);
                // Obtiene el componente Rigidbody2D de la bala y le aplica una fuerza en la dirección calculada
                Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
                rb.velocity = direction.normalized * bulletForce;
                // Destruye la bala después de un cierto tiempo (ajusta esto según tus necesidades)
                Destroy(bullet, 2f);
            }
        }
    }
}