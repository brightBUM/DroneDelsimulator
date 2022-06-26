using UnityEngine;
using System.Collections.Generic;
using System.Linq;

namespace Alpha
{
    public class OrderMatcher : MonoBehaviour
    {
        #region Variables
        public List<House> houses = new List<House>();
        public float minDistance;
        public float maxDistance;
        //public Transform pickup;
        //public Transform drop;
        public float currentPickDistance;
        

        #endregion

        private void Start()
        {
            houses =  FindObjectsOfType<House>().ToList<House>();
        }

        #region PublicMethods
        //public OrderMatcher(House[] houses,float minDistance)
        //{
        //    this.houses = houses;
        //    this.minDistance = minDistance;
        //}
        public Order MatcherLogic()
        {
            while (true)
            {
                var house1 = houses[Random.Range(0, houses.Count)];
                var house2 = houses[Random.Range(0, houses.Count)];
                if (house1 == house2)
                {
                    continue;
                    
                }
                currentPickDistance = Vector2.Distance(house1.transform.position, house2.transform.position);
                if (currentPickDistance > minDistance)
                {
                    

                    Transform pickup = house1.transform;
                    Transform drop = house2.transform;
                    var weightDummy = CalculateOrderWeight(currentPickDistance);
                    var priceDummy = CalculateOrderPrice(currentPickDistance);
                    Debug.Log("w "+weightDummy);
                    Debug.Log("p "+priceDummy);
                    Order order = new Order(weightDummy, priceDummy, currentPickDistance, pickup, drop);
                    
                    return order;
                }
            }
        }
        #endregion

        #region PrivateMethods
        float CalculateOrderWeight(float currentdis)
        {
            var dispercentage = (currentdis / (maxDistance - minDistance));

            var calculatedweight = Mathf.Lerp(20, 1500, dispercentage);

            return calculatedweight;
        }
        #endregion
        float CalculateOrderPrice(float currentdis)
        {
           

            float currencymultiplier = 10f;

            var calculatedPrice = currencymultiplier  * currentdis;
            return calculatedPrice;
        }
        #region GameEventListeners

        #endregion
    }
    
    
}