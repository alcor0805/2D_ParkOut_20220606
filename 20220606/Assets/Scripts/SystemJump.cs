using UnityEngine;

namespace Alcor
{
    public class SystemJump : MonoBehaviour
    {
        #region 資料
        [SerializeField, Header("跳躍高度"), Tooltip("調整跳躍高度"), Range(0, 1000)]
        private float height = 350;

        private Animator ani;
        private Rigidbody2D rig;
        private bool jumpclick;
        #endregion

        #region 功能
        private void JumpKey()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                jumpclick = true;
            }
        }
        private void jumpforce()
        {
            if (jumpclick)
            {
                rig.AddForce(new Vector2(0,height));
                jumpclick = false;
            }
        }
        #endregion

        #region 事件
        private void Awake()
        {
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }
        private void Update()
        {
                JumpKey();
        }
        private void FixedUpdate()
        {
            jumpforce();
        }
        #endregion




    }
}

