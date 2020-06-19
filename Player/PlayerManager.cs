using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    //플레이어 이동
    //마우스이동 및 FPS 구도 만들기
    //플레이어 이동 애니메이션 추가

<<<<<<< HEAD
    private float moveSpeed = 5;
=======
    private float moveSpeed = 3;
>>>>>>> f1c6e1b6ae67b2085758e7c03e47ec5bede0b66f
    private Animator playerAnimator;

    public enum PlayerState
    {
        idle,
        walk
        // 앉기, 뛰기(보류)
    }

    PlayerState state;

    // Start is called before the first frame update
    void Start()
    {
        state = PlayerState.idle;
        playerAnimator = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        checkState();
        checkAnimation();
        playerMove();
    }

    void playerMove() {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(h, 0, v) * moveSpeed * Time.deltaTime);
        transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X"), 0));
    }

    void shootGun() { 
    
    }

    void checkState() {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.W))
        {
            state = PlayerState.walk;
        }
        else {
            state = PlayerState.idle;
        }
    }

    void checkAnimation() {
        if (state == PlayerState.walk)
        {
            playerAnimator.SetBool("isWalk", true);
        }
        else {
            playerAnimator.SetBool("isWalk", false);
        }
    }
}
