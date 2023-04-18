using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public List<GameObject> targets;

    private int score;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;

    private float spawnRate = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnTarget());
        score = 0;
        UpdateScore(0);
    }
    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnTarget()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);
        }
    }

    public void UpdateScore(int sscoreToAdd)
    {
        score += sscoreToAdd;
        scoreText.text = "Score: " + score;
    }
}
