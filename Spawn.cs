using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Spawn : MonoBehaviour
{
    // Start is called before the first frame update
    private static int score;
    void Start()
    {
        StartCoroutine(Spawnn());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }
    }

    public static int Score
    {
        get
        {
            return score;
        }

        set
        {
            Debug.Log(score);
            score = value;
        }
    }

    public GameObject lemmingPrefab;
    public Transform startPos;

    public int amount;

    public IEnumerator Spawnn()
    {
        for (int i = 0; i < amount; i++)
        {
            Instantiate(lemmingPrefab, startPos.position, Quaternion.identity);

            yield return new WaitForSeconds(2);
        }
    }

}
