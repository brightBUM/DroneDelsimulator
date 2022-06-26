using UnityEngine;

namespace Alpha
{
    public class House : MonoBehaviour
    {
        #region Variables
        public Transform Point;
      
        #endregion

        #region UnityMethods
        void Start()
        {
            Point = GetComponentInChildren<Transform>();
        }

        void Update()
        {

        }
        #endregion

       

        #region PublicMethods

        #endregion

        #region PrivateMethods

        #endregion

        #region GameEventListeners

        #endregion
    }
}