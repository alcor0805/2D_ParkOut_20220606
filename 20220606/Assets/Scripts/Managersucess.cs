using UnityEngine;
namespace Alcor
{
    public class Managersucess : MonoBehaviour
    {
        [SerializeField, Header("����W��")]
        private string objectname = "����H";
        [SerializeField, Header("�]�B����")]
        private SystemRun systemRun;
        [SerializeField, Header("���D����")]
        private SystemJump systemJump;

        #region Trigger
        /// <summary>
        /// �䤤�@�Ӫ��󦳤Ŀ�is trigger
        /// </summary>
        //�⪫��I���ɰ���@��
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.name.Contains(objectname))
            {
                systemJump.enabled = false;
                systemRun.enabled = false;
            }
        }

        //�⪫��I�����}�ɰ���@��
        private void OnTriggerExit2D(Collider2D collision)
        {

        }
        //�⪫��I�����d�������
        private void OnTriggerStay2D(Collider2D collision)
        {

        }
        #endregion

        #region collision
        /// <summary>
        /// ��Ӫ��󳣨S���Ŀ�is trigger
        /// </summary>
        private void OnCollisionEnter2D(Collision2D collision)
        {

        }
        private void OnCollisionExit2D(Collision2D collision)
        {

        }
        private void OnCollisionStay2D(Collision2D collision)
        {

        }
        #endregion
    }
}

