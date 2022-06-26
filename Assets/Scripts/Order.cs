using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alpha
{
    public class Order
    {
        public float time;
        public float weight;
        public float price;
        public float distance;
        public Transform pickUpPoint;
        public Transform dropPoint;

        // public GameObject highlighter;

        public Order(Transform pickUpPoint, Transform dropPoint)
        {
            this.pickUpPoint = pickUpPoint;
            this.dropPoint = dropPoint;
        }
        public Order(float weight,float price,float distance,Transform pickUpPoint, Transform dropPoint)
        {
            this.weight = weight;
            this.price = price;
            this.distance = distance;
            this.pickUpPoint = pickUpPoint;
            this.dropPoint = dropPoint;
        }
    }
}

