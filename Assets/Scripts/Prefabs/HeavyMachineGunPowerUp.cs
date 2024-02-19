using System;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class HeavyMachineGunPowerUp : MonoBehaviour
{

    [SerializeField] private Transform actualWeapon;
    [SerializeField] private Transform newWeapon;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Contains("Player"))
        {
            Transform weaponAnchor = actualWeapon.parent;
            Instantiate(newWeapon, weaponAnchor);
            Destroy(actualWeapon.gameObject);
        }
    }
}
