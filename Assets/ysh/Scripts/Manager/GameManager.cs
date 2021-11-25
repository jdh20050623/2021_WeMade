using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; } = null;

    void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(this);
    }

    /* 방역 사회 예산 지지율 */
    public int quarantine; // Max : 20
    public int society;    // Max : 20
    public int budget;
    public int support;    // Max : 100

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
