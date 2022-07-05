using UnityEngine;

namespace Alcor
{
    public class SystemJump : MonoBehaviour
    {
        #region 資料
        [SerializeField, Header("跳躍高度"), Tooltip("調整跳躍高度"), Range(0, 1000)]
        private float height = 350;
        [SerializeField, Header("調整地板大小")]
        private Vector3 groundsize = new Vector3(1, 1, 1);
        [SerializeField, Header("調整地板位移")]
        private Vector3 groundset;
        [SerializeField,Header("調整地板顏色")]
        private Color groundcolor = new (1, 0, 0.2f, 0.5f);
        [SerializeField, Header("調整地板圖層")]
        private LayerMask layerGround;
        [SerializeField, Header("音效來源")]
        private AudioClip jumpmusic;
        private string jumpname="跳躍開關";
        private Animator ani;
        private Rigidbody2D rig;
        private bool jumpclick;
        private bool isGround;
        private AudioSource aud;
        #endregion

        #region 功能
        private void JumpKey()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                jumpclick = true;
            }
            else if (Input.GetKeyUp(KeyCode.Space))
            {
                jumpclick = false;
            }
        }
        private void jumpforce()
        {
            if (jumpclick && isGround)
            {
                rig.AddForce(new Vector2(0,height));
                aud.PlayOneShot(jumpmusic, Random.Range(0.7f,1.5f));
                jumpclick = false;

            }
        }
        private void UpdateAnimator() 
        {
            ani.SetBool(jumpname, !isGround);
        }
        #endregion

        #region 事件
        private void OnDrawGizmos()
        {
            Gizmos.color = groundcolor;
            Gizmos.DrawCube(transform.position + groundset, groundsize);//draw(繪畫位置,繪畫大小)
        }
        private void Awake()
        {
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
            aud = GetComponent<AudioSource>();
        }
        private void Update()
        {
                JumpKey();
            Groundcheck();
            UpdateAnimator();
        }
        private void FixedUpdate()
        {
            jumpforce();
        }
        #endregion
        private void Groundcheck() 
        {
            //2D碰撞器=2D物理.碰撞盒子(盒子位置，盒子大小，角度)
            Collider2D hit = Physics2D.OverlapBox(transform.position + groundset, groundsize, 0,layerGround);
            //print("碰撞到的物件: " + hit.name);
            isGround = hit;
        }



    }
}

