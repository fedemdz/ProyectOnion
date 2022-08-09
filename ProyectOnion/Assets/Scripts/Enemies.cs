using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    [SerializeField]
    [Range(1f, 10f)]private float speed = 5f;
    public float x, y;
    private Animator anim;
    [SerializeField]
    [Range(2, 10)]
    private int velocidad = 2;
    [SerializeField]
    [Range(20, 50)]
    private int velocidadRotacion = 20;
    /*  [SerializeField]
      [Range(0,1)]
      private int typeEnemy = 0;
    */
    enum EnemieType  {Jackie, Sophie };
    [SerializeField] EnemieType enemieType;
    [SerializeField] Transform playerTramsform;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    


    // Update is called once per frame
    void Update()
{
    switch (enemieType)
    {
        case EnemieType.Jackie:
                RotateAroundPlayer();
            break;
        case EnemieType.Sophie:
                ChasePlayer();
            break;
    }

        transform.Rotate(0, x * Time.deltaTime * velocidadRotacion, 0);
        transform.Translate(0, 0, y * Time.deltaTime * velocidad);

        anim.SetFloat("VelX", x);
        anim.SetFloat("VelY", y);


    }
    private void RotateAroundPlayer()
    {
    LookPlayer();
    transform.RotateAround(playerTramsform.position, Vector3.up, 5f * Time.deltaTime);
    }
    private void Follow()
    {
        LookPlayer();
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }
    private void ChasePlayer()
    {
        LookPlayer();
        Vector3 direction = (playerTramsform.position - transform.position);
        if (direction.magnitude > 1f)
        {
            transform.position += direction.normalized * Time.deltaTime;
        }
    }
    private void LookPlayer()
    {
        Quaternion newRotation = Quaternion.LookRotation(playerTramsform.position - transform.position);
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, 1.5f * Time.deltaTime);
    }

}
