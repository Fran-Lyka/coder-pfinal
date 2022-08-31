using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponsManager : MonoBehaviour
{
    [SerializeField] GameObject[] armas;
    [SerializeField] Transform playerHand;
    [SerializeField] List<GameObject> WeaponList;

    public List<GameObject> WeaponList { get => weaponList; set => weaponList = value;}
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    
    void DisableAllWeapons()
    {
        for (int i = 0; i < weapons.Length; i++)
        {
            weapons[0].SetActive(false);
        }
    }
}

