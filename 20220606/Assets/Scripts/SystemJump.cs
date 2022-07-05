using UnityEngine;

namespace Alcor
{
    public class SystemJump : MonoBehaviour
    {
        #region ���
        [SerializeField, Header("���D����"), Tooltip("�վ���D����"), Range(0, 1000)]
        private float height = 350;
        [SerializeField, Header("�վ�a�O�j�p")]
        private Vector3 groundsize = new Vector3(1, 1, 1);
        [SerializeField, Header("�վ�a�O�첾")]
        private Vector3 groundset;
        [SerializeField,Header("�վ�a�O�C��")]
        private Color groundcolor = new (1, 0, 0.2f, 0.5f);
        [SerializeField, Header("�վ�a�O�ϼh")]
        private LayerMask layerGround;
        [SerializeField, Header("���Ĩӷ�")]
        private AudioClip jumpmusic;
        private string jumpname="���D�}��";
        private Animator ani;
        private Rigidbody2D rig;
        private bool jumpclick;
        private bool isGround;
        private AudioSource aud;
        #endregion

        #region �\��
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

        #region �ƥ�
        private void OnDrawGizmos()
        {
            Gizmos.color = groundcolor;
            Gizmos.DrawCube(transform.position + groundset, groundsize);//draw(ø�e��m,ø�e�j�p)
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
            //2D�I����=2D���z.�I�����l(���l��m�A���l�j�p�A����)
            Collider2D hit = Physics2D.OverlapBox(transform.position + groundset, groundsize, 0,layerGround);
            //print("�I���쪺����: " + hit.name);
            isGround = hit;
        }



    }
}

