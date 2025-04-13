using UnityEngine;

public class Weapon : MonoBehaviour
{
  
   [SerializeField] ParticleSystem MuzzleFlash;
  
    
    public void Shoot(WeaponSO W){
  

        MuzzleFlash.Play();
        RaycastHit hit;
        
        
       if( Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward,out hit ,Mathf.Infinity)){
        Instantiate(W.HitVFXPrefab,hit.point,Quaternion.identity);
        EnemyHealth enemyHealth = hit.collider.GetComponent<EnemyHealth>();  
        enemyHealth?.TakeDamage(W.damage);


        }
    }
   
  
}
 