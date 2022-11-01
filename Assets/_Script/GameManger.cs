using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    public float Balance = 0;
    public GameObject BalanceToken;
    public GameObject middle;
    public GameObject LeftBalance;
    public GameObject LeftBalance1;
    public GameObject LeftBalance2;
    public GameObject LeftBalance3;
    public GameObject LeftBalance4;
    public GameObject LeftBalance5;
    public GameObject LeftBalance6;
    public GameObject LeftBalance7;
    public GameObject LeftBalance8;
    public GameObject LeftBalance9;
    public GameObject RightBalance;
    public GameObject RightBalance9;
    public GameObject RightBalance8;
    public GameObject RightBalance7;
    public GameObject RightBalance6;
    public GameObject RightBalance5;
    public GameObject RightBalance4;
    public GameObject RightBalance3;
    public GameObject RightBalance2;
    public GameObject RightBalance1;
    float loss;
    float increase;

    // Start is called before the first frame update
    void Start()
    {
        float loss = (BalanceToken.transform.position.x - LeftBalance.transform.position.x) / 10;
        float increase = (BalanceToken.transform.position.x - RightBalance.transform.position.x) / 10;

    }

    // Update is called once per frame
    void Update()
    {



        if (Input.GetKey(KeyCode.E))
        {
            Balance += 3 * Time.deltaTime;

        }

        if (Input.GetKey(KeyCode.Q))
        {
            Balance -= 3 * Time.deltaTime;

        }



        if (Balance > 1 & Balance < 2)
        {

            //BalanceToken.transform.position = RightBalance.transform.position;
            BalanceToken.transform.position = Vector3.MoveTowards(BalanceToken.transform.position, RightBalance1.transform.position, 1);
        }

        if (Balance > 2 & Balance < 3)
        {

            //BalanceToken.transform.position = RightBalance.transform.position;
            BalanceToken.transform.position = Vector3.MoveTowards(BalanceToken.transform.position, RightBalance2.transform.position, 1);
        }

        if (Balance > 3 & Balance < 4)
        {

            //BalanceToken.transform.position = RightBalance.transform.position;
            BalanceToken.transform.position = Vector3.MoveTowards(BalanceToken.transform.position, RightBalance3.transform.position, 1);
        }

        if (Balance > 4 & Balance < 5)
        {

            //BalanceToken.transform.position = RightBalance.transform.position;
            BalanceToken.transform.position = Vector3.MoveTowards(BalanceToken.transform.position, RightBalance4.transform.position, 1);
        }

        if (Balance > 5 & Balance < 6)
        {

            //BalanceToken.transform.position = RightBalance.transform.position;
            BalanceToken.transform.position = Vector3.MoveTowards(BalanceToken.transform.position, RightBalance5.transform.position, 1);
        }

        if (Balance > 6 & Balance < 7)
        {

            //BalanceToken.transform.position = RightBalance.transform.position;
            BalanceToken.transform.position = Vector3.MoveTowards(BalanceToken.transform.position, RightBalance6.transform.position, 1);
        }

        if (Balance > 7 & Balance < 8)
        {

            //BalanceToken.transform.position = RightBalance.transform.position;
            BalanceToken.transform.position = Vector3.MoveTowards(BalanceToken.transform.position, RightBalance7.transform.position, 1);
        }

        if (Balance > 8 & Balance < 9)
        {

            //BalanceToken.transform.position = RightBalance.transform.position;
            BalanceToken.transform.position = Vector3.MoveTowards(BalanceToken.transform.position, RightBalance8.transform.position, 1);
        }

        if (Balance > 9 & Balance < 10)
        {

            //BalanceToken.transform.position = RightBalance.transform.position;
            BalanceToken.transform.position = Vector3.MoveTowards(BalanceToken.transform.position, RightBalance9.transform.position, 1);
        }

        if (Balance >= 10)
        {
            Balance = 10;
            //BalanceToken.transform.position = RightBalance.transform.position;
            BalanceToken.transform.position = Vector3.MoveTowards(BalanceToken.transform.position, RightBalance.transform.position, 1);
        }


        if (Balance < 1 & Balance > -1)
        {

            // BalanceToken.transform.position = LeftBalance.transform.position;
            BalanceToken.transform.position = Vector3.MoveTowards(BalanceToken.transform.position, middle.transform.position, 1);
        }


        if (Balance < -1 & Balance > -2)
        {

            // BalanceToken.transform.position = LeftBalance.transform.position;
            BalanceToken.transform.position = Vector3.MoveTowards(BalanceToken.transform.position, LeftBalance1.transform.position, 1);
        }

        if (Balance < -2 & Balance > -3)
        {

            // BalanceToken.transform.position = LeftBalance.transform.position;
            BalanceToken.transform.position = Vector3.MoveTowards(BalanceToken.transform.position, LeftBalance2.transform.position, 1);
        }

        if (Balance < -3 & Balance > -4)
        {

            // BalanceToken.transform.position = LeftBalance.transform.position;
            BalanceToken.transform.position = Vector3.MoveTowards(BalanceToken.transform.position, LeftBalance3.transform.position, 1);
        }



        if (Balance < -4 & Balance > -5)
        {

            // BalanceToken.transform.position = LeftBalance.transform.position;
            BalanceToken.transform.position = Vector3.MoveTowards(BalanceToken.transform.position, LeftBalance4.transform.position, 1);
        }

        if (Balance < -5 & Balance > -6)
        {

            // BalanceToken.transform.position = LeftBalance.transform.position;
            BalanceToken.transform.position = Vector3.MoveTowards(BalanceToken.transform.position, LeftBalance5.transform.position, 1);
        }

        if (Balance < -6 & Balance > -7)
        {

            // BalanceToken.transform.position = LeftBalance.transform.position;
            BalanceToken.transform.position = Vector3.MoveTowards(BalanceToken.transform.position, LeftBalance6.transform.position, 1);
        }

        if (Balance < -7 & Balance > -8)
        {

            // BalanceToken.transform.position = LeftBalance.transform.position;
            BalanceToken.transform.position = Vector3.MoveTowards(BalanceToken.transform.position, LeftBalance7.transform.position, 1);
        }

        if (Balance < -8 & Balance > -9)
        {

            // BalanceToken.transform.position = LeftBalance.transform.position;
            BalanceToken.transform.position = Vector3.MoveTowards(BalanceToken.transform.position, LeftBalance8.transform.position, 1);
        }

        if (Balance < -9 & Balance > -10)
        {

            // BalanceToken.transform.position = LeftBalance.transform.position;
            BalanceToken.transform.position = Vector3.MoveTowards(BalanceToken.transform.position, LeftBalance9.transform.position, 1);
        }

        if (Balance <= -10)
        {
            Balance = -10;
            // BalanceToken.transform.position = LeftBalance.transform.position;
            BalanceToken.transform.position = Vector3.MoveTowards(BalanceToken.transform.position, LeftBalance.transform.position, 1);
        }




    }



}

