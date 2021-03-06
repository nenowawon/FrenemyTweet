﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class EnemySpawnPoint : MonoBehaviour {

    [Inject]
    private StageSceneManager stageManager;

    [Header("出現する敵の番号")]
    [SerializeField]
    private int spawnRegionNum;

    private void OnTriggerEnter(Collider other)
    {
        // プレイヤーに衝突した場合
        if(other.gameObject.layer != (int)LayerManager.Layer.Player) { return; }
        // 敵を有効化する
        stageManager.EnemyManager.ActivateEnemy(spawnRegionNum);

        // 自分を消す
        Destroy(gameObject);
    }
}
