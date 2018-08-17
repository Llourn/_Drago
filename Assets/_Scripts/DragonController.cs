using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonController : MonoBehaviour
{
    public bool isRobot = false;
    public float moveSpeed = 1.0f;

    public bool isFlinching = false;

    [HideInInspector]
    public bool executingAction = false;

    Anim anim = new Anim();

    IDragonState state;
    IHandleInput inputSource;
    Animator animator;

    private void Start()
    {
        state = new IdlingState();
        if(isRobot){
            inputSource = GetComponent<DragonRobot>();
        } else {
            inputSource = GetComponent<PlayerInput>();
        }
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if(isFlinching)
        {
            HandleInput();
            return;
        }

        if (inputSource.Move() != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(inputSource.Move());
        }

        this.transform.Translate((inputSource.Move() * moveSpeed) * Time.deltaTime, Space.World);
        IDragonCommand currentCommand = inputSource.Action();

        HandleInput();
    }

    void HandleInput()
    {
        IDragonState _state = state.HandleInput(this, inputSource);
        if(_state != null)
        {
            ClearAnimations();
            state = _state;
            state.Enter(this);
        }
    }

    void ClearAnimations()
    {
        animator.SetBool(anim.run, false);
        animator.SetBool(anim.idle, false);
        animator.SetBool(anim.die, false);
    }

    public void PlayRunningAnimation()
    {
        animator.SetBool(anim.run, true);
    }

    public void PlayIdleAnimation()
    {
        animator.SetBool(anim.idle, true);
    }

    public void PlayDeflectAnimation()
    {
        animator.SetTrigger(anim.deflect);
    }

    public void PlayFireAnimation()
    {
        animator.SetTrigger(anim.fire);
    }

    public void PlayDieAnimation()
    {
        animator.SetBool(anim.die, true);
    }

    public void PlayFlinchAnimation()
    {
        animator.SetTrigger(anim.flinch);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Projectile"))
        {
            isFlinching = true;
        }
    }

    public void StopFlinching()
    {
        isFlinching = false;
    }

    public class Anim
    {
        public string run = "Run";
        public string deflect = "Deflect";
        public string fire = "Fire";
        public string idle = "Idle";
        public string die = "Die";
        public string flinch = "Flinch";
    }

}
