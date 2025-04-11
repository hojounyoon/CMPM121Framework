using System.IO;
using UnityEngine;

public class EnemyDefiner : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        readEnemyJson();
    }

    void readEnemyJson() {
        string FileName = "Assets/Resources/enemies.json";
        string JsonString = File.ReadAllText(FileName);
        print(JsonString);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
