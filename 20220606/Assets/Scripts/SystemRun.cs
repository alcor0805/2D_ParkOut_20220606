
using UnityEngine;//�ϥ�unity����API�M��
namespace Alcor
{
    /// <summary>
    /// �]�B�t��
    /// </summary>
    public class SystemRun : MonoBehaviour
    {
        #region ���:�s�񪫥�
        [SerializeField, Header("�]�B�t��"),Tooltip("�վ㨤�⪺�]�B�t��"),Range(0,10)]//�ǦC�����A��ܨp�H�ݩ�
        private float speedRun = 3.5f;
        [SerializeField, Header("���D����"),Tooltip("�վ㨤����D����"),Range(300,1000)]
        private float height = 350; 
        private Animator ani;
        private Rigidbody2D rig;
        #endregion

        #region �\��:�t�Ωһݪ��\��
        #endregion

        #region �ƥ�:�{���J�f
        private void Start()
        {
            print("Y���ס�Y");
        }
        #endregion

    }
}

