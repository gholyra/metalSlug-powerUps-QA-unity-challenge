using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    public static PlayerWeapon Instance;
    
    [SerializeField] private GameObject pistolBulletPrefab;
    [SerializeField] private GameObject heavyBulletPrefab;
    [SerializeField] private Transform weaponObject;

    private Transform aimTransform;

    public bool isPistolTheWeapon { get; set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        aimTransform = GetComponent<Transform>();
        isPistolTheWeapon = true;
    }

    private void Update()
    {
        AimHandler();
        ShootingHandler();
    }
    
    #region Handler
    private void AimHandler()
    {
        Vector3 mousePosition = GameManager.Instance.GetMousePosition();
        Vector3 aimDirection = (mousePosition - transform.position).normalized;
        float angle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg;
        aimTransform.eulerAngles = new Vector3(0, 0, angle);
    }

    private void ShootingHandler()
    {
        if (isPistolTheWeapon)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Instantiate(pistolBulletPrefab, weaponObject.position, weaponObject.rotation);
            }
        }
        else
        {
            if (Input.GetButton("Fire1"))
            {
                Instantiate(heavyBulletPrefab, weaponObject.position, weaponObject.rotation);
            }
        }
    }
    #endregion
    
}
