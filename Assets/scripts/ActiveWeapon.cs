using StarterAssets;
using UnityEngine;

public class ActiveWeapon : MonoBehaviour
{
    
   StarterAssetsInputs starterAssetsInputs;
   Weapon currentWeapon ; 
   [SerializeField] WeaponSO W;
  
    Animator animator;
   const string SHOOT_STRING = "Shoot"; 
   float timeSinceLastShot= 0f;
    void Awake() {

    starterAssetsInputs = GetComponentInParent<StarterAssetsInputs>();
    currentWeapon = GetComponentInChildren<Weapon>() ;
    animator= GetComponent<Animator>();  
   }

    
     void HandleShoot(){
        if(!starterAssetsInputs.shoot) 
        return ;

        if (timeSinceLastShot>W.FireRate){

        currentWeapon.Shoot(W);
        animator.Play(SHOOT_STRING,0,0f);
        timeSinceLastShot=0f;
        }
        starterAssetsInputs.ShootInput(false);
      
    }
    // Update is called once per frame
    void Update()
    {   timeSinceLastShot += Time.deltaTime;
        HandleShoot();
    }
}
