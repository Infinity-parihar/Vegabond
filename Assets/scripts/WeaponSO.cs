using UnityEngine;

 

[CreateAssetMenu(fileName = "", menuName = "Scriptable Objects/WeaponSO")]
public class WeaponSO : ScriptableObject 
{
    public int damage;
    public float FireRate;
    public GameObject HitVFXPrefab;
}

