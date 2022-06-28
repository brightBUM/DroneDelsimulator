using UnityEngine;
using System.Collections.Generic;

namespace Alpha
{
    public class OrderSystem : MonoBehaviour
    {
        #region Variables
        [SerializeField] private List<Order> orders = new List<Order>();
        [SerializeField] public OrderMatcher orderMatcher;
        [SerializeField] public OrderUIelement[] ordersUI;
        //[SerializeField] GameObject dashBoardCanvas;
        //[SerializeField] GameObject parentItem;
        //[SerializeField] float minDistance;
        //[SerializeField] House[] hoses;
        
        //[Header("Order stats")]

        #endregion

        #region UnityMethods
        void Start()
        {
            
            //hoses = FindObjectsOfType<House>();
            orderMatcher = FindObjectOfType<OrderMatcher>();

        }

        void Update()
        {

        }
        #endregion

        #region PublicMethods
        public void ShowDashboard()
        {
            for(int i=0;i<3;i++)
            {

                Order orderdummy = orderMatcher.MatcherLogic();
                orders.Add(orderdummy);
                ordersUI[i].SetOrderText(orderdummy.weight,orderdummy.distance,orderdummy.price);
            }
            
        }
        #endregion
        
        #region PrivateMethods
       
        #endregion

        #region GameEventListeners

        #endregion
    }
}