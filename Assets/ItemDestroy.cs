using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroy : MonoBehaviour
{

    //Unityちゃんのオブジェクト
    private GameObject unitychan;

    //Unityちゃんとアイテムとの距離
    private float ItemDifference;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        //Unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");

        //Unityちゃんとアイテムのz軸方向の距離
        this.ItemDifference = unitychan.transform.position.z - this.transform.position.z;

        //Unityちゃんが通過してから5mでアイテムを破棄
        if (ItemDifference >= 5)
        {

            Destroy(this.gameObject);

        }

    }

}
