using System;
using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEditor;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviourPunCallbacks
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private FixedJoystick __joystick;
    [SerializeField] private Animator _animator;
    public float _moveSpeed;
    [SerializeField] private GameObject styleObject;
    [SerializeField] private GameObject ConfirmButton;
    public bool IsJumping = false;
    private Vector3 playerpos = new Vector3(-1.2f, 0, 0);

    private void Start()
    {
        playerpos.z = UnityEngine.Random.Range(-0.4f, 0.4f);
        transform.SetParent(MainSceneManger.Instance.transform);
        transform.localPosition = playerpos;
        var view = this.GetComponent<PhotonView>();
        if (!view.IsMine)
        {
            Destroy(__joystick.gameObject);
            Destroy(styleObject.gameObject);
            Destroy(ConfirmButton.gameObject);
        }
    }
    // Start is called before the first frame update
    private void FixedUpdate()
    {
        if (__joystick!=null)
        {
            _rigidbody.velocity = new Vector3(__joystick.Horizontal * _moveSpeed, _rigidbody.velocity.y, __joystick.Vertical * _moveSpeed);
            if (__joystick.Horizontal != 0 || __joystick.Vertical != 0)
            {
                transform.rotation = Quaternion.LookRotation(_rigidbody.velocity);
            }
        }
        else
        {
            return;
        }
        
    }
    public void Jump()
    {
        if (IsJumping == false)
        {
            IsJumping = true;
            _rigidbody.velocity += Vector3.up * 2f;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        IsJumping = false;
    }

    
}
