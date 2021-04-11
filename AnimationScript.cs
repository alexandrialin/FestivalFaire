using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AdvancedCustomizableSystem;
using UnityEngine.SceneManagement;

public class AnimationScript : MonoBehaviour
{
    public CharacterCustomization CharacterCustomization;
    float speed = 3f;
    float rotSpeed = 80;
    float gravity = 8;
    Animator anim;
    // Start is called before the first frame update
    Vector3 moveDir = Vector3.zero;
    CharacterController controller;

    public GameObject shootingUI;
    public GameObject ducksUI;
    public GameObject lightsUI;
    public GameObject musicUI;
    public GameObject basketballUI;


    void Start()
    {
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (controller.isGrounded)
        {
  
            if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
            {
                foreach (Animator a in CharacterCustomization.GetAnimators())
                    a.SetInteger("condition", 1);
                moveDir = new Vector3(0, 0, 1);
                moveDir *= speed;
                transform.eulerAngles = new Vector3(0, 0, 0);

            }
            else if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.W))
            {
                foreach (Animator a in CharacterCustomization.GetAnimators())
                    a.SetInteger("condition", 0);
                moveDir = new Vector3(0, 0, 0);

            }
            else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
            {
                foreach (Animator a in CharacterCustomization.GetAnimators())
                    a.SetInteger("condition", 1);
                moveDir = new Vector3(0, 0, -1);
                moveDir *= speed;
                transform.eulerAngles = new Vector3(0, 180, 0);

            }
            else if (Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.S))
            {
                foreach (Animator a in CharacterCustomization.GetAnimators())
                    a.SetInteger("condition", 0);
                moveDir = new Vector3(0, 0, 0);

            }
            else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
            {
                foreach (Animator a in CharacterCustomization.GetAnimators())
                    a.SetInteger("condition", 1);
                moveDir = new Vector3(1, 0, 0);
                moveDir *= speed;
                transform.eulerAngles = new Vector3(0, 90, 0);

            }
            else if (Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.D))
            {
                foreach (Animator a in CharacterCustomization.GetAnimators())
                    a.SetInteger("condition", 0);
                moveDir = new Vector3(0, 0, 0);

            }
            else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
            {
                foreach (Animator a in CharacterCustomization.GetAnimators())
                    a.SetInteger("condition", 1);
                moveDir = new Vector3(-1, 0, 0);
                moveDir *= speed;
                transform.eulerAngles = new Vector3(0, 270, 0);

            }
            else if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.A))
            {
                foreach (Animator a in CharacterCustomization.GetAnimators())
                    a.SetInteger("condition", 0);

                moveDir = new Vector3(0, 0, 0);
            }


        }
        moveDir.y -= gravity * Time.deltaTime;
        controller.Move(moveDir * Time.deltaTime);

    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Shooting")
        {
            shootingUI.SetActive(true);
        }

        if (other.gameObject.tag == "Ducks")
        {
            ducksUI.SetActive(true);
        }

        if (other.gameObject.tag == "Lights")
        {
            lightsUI.SetActive(true);
        }

        if (other.gameObject.tag == "Music")
        {
            musicUI.SetActive(true);
        }

        if (other.gameObject.tag == "Basketball")
        {
            basketballUI.SetActive(true);
        }

        other.isTrigger = false;
    }

    public void ShootingGameOK()
    {
        shootingUI.SetActive(false);
        SceneManager.LoadScene("ShootingGame");
    }

    public void DuckGameOK()
    {
        ducksUI.SetActive(false);
        SceneManager.LoadScene("DuckClicker");
    }

    public void BasketballGameOK()
    {
        basketballUI.SetActive(false);
        SceneManager.LoadScene("Basketball");
    }

    public void LightGameOK()
    {
        lightsUI.SetActive(false);
        SceneManager.LoadScene("LightSwitch");
    }

    public void MusicGameOK()
    {
        musicUI.SetActive(false);
        SceneManager.LoadScene("Piano");
    }
}
