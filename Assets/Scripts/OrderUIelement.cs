using UnityEngine;
using TMPro;
namespace Alpha
{
    public class OrderUIelement : MonoBehaviour
    {
        #region Variables
        [SerializeField] private TextMeshProUGUI weightUI;
        [SerializeField] private TextMeshProUGUI distanceUI;
        [SerializeField] private TextMeshProUGUI priceUI;
        #endregion

        #region UnityMethods
        void Start()
        {

        }

        void Update()
        {

        }
        #endregion

        #region PublicMethods
        public void SetOrderText(float weight,float distance,float price)
        {
            weightUI.text = weight.ToString("0.#");
            distanceUI.text = distance.ToString("0.#");
            priceUI.text = price.ToString();

        }
        #endregion

        #region PrivateMethods

        #endregion

        #region GameEventListeners

        #endregion
    }
}