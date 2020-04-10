
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    // Start is called before the first frame update
    
    
    // 定義類別成員
    // c#
    // 1.大小不一樣
    // 2. 括號成對出現 () [] {} '' "" <>

    [Header("怪物一號")]
    public Enemy Enemy1;

    [Header("怪物二號")]
    public Enemy Enemy2;

    // 事件 : 在特定時間會已指定次數執行的方法 (名稱為藍色)
    // 開始事件 : 撥放遊戲時執行一次 - 初始事件
    private void Start()
    {
        // 輸出("文字訊息");
        // c# 結尾為分號 ;

        // 取得 get
        print("輸出怪物一號的魔力 : " + Enemy1.mp);
        print("輸出怪物二號的裝備名稱 : " + Enemy2.bb);

        // 設定 set
        Enemy1.hp = 100;
        Enemy2.hp = 300;
        Enemy1.mtd = 50;
        Enemy1.hh ="木棍";
        Enemy2.hh = "短刀";
        Enemy1.key = true;
        Enemy2.box = true;
    }
}

