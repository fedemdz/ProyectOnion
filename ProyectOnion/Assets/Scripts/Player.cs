using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int hp = 100;
    public int maxhp = 100;
    public float velocidad = 2f;
    public float velocidadRotacion = 130f;
        public float x, y;
    private Animator anim;
    public int attack= 7;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(hp);
        Debug.Log("EJECUTANDO EL START");
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("EJECUTANDO EL UPDATE");
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        if (Input.GetKey(KeyCode.Space)) 
        {
            Damage(10);
        }
        if (Input.GetKey(KeyCode.LeftAlt))
        {
            Heal(10);
            if (hp>= maxhp)
                {
                hp = maxhp;
            }
               
        }
        transform.Rotate(0, x * Time.deltaTime * velocidadRotacion, 0);
        transform.Translate(0, 0, y * Time.deltaTime * velocidad);

        anim.SetFloat("VelX", x);
        anim.SetFloat("VelY", y);
    }
    void Damage(int value)
    {
        hp = hp - value;
    }
    void Heal(int value)
    {
        hp = hp + value;
    }
}
