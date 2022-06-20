
using UnityEngine;//�ϥ�unity����API�M��
namespace Alcor
{
    /// <summary>
    /// �]�B�t��
    /// </summary>
    public class SystemRun : MonoBehaviour
    {
        #region ���:�s�񪫥�
        [SerializeField, Header("�]�B�t��"), Tooltip("�վ㨤�⪺�]�B�t��"), Range(0, 10)]//�ǦC�����A��ܨp�H�ݩ�
        private float speedRun = 3.5f;
        private Animator ani;
        private Rigidbody2D rig;
        #endregion

        #region �\��:�t�Ωһݪ��\��
        /// <summary>
        /// �]�B�\��
        /// </summary>
        private void Run()
        {
            rig.velocity = new Vector2(speedRun, rig.velocity.y);
        }
        #endregion

        #region �ƥ�:�{���J�f
        private void Awake()//����ƥ�:�b�}�l�e�I�s����
        {
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }
        private void Start()//�}�l�ƥ�:�C���}�l�e����@��
        {
            //print("Y���ס�Y");
        }
        private void Update()//��s�ƥ�:�C�����60��(fps)
        {
            //print("<color=#87CEEB>update</color>");
            Run();
        }
        #endregion

    }
}

