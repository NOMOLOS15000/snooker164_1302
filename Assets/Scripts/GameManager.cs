using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private int playerScore;
    public int PlayerScore {get { return playerScore;} set {playerScore = value;} }
    public static GameManager instance;

    [SerializeField]
    private GameObject[] ballPositions;

    [SerializeField]
    private GameObject[] ballPrefab;
    void Awake()
    {
        instance = this;
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SetBall(BallColor.Red, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SetBall(BallColor col, int i)
    {
        GameObject obj = Instantiate(ballPrefab[i],
                    ballPositions[i].transform.position,
                    Quaternion.identity);
        Ball b = obj.GetComponent<Ball>();
        b.SetColorAndPoint(col);
    
    }

}
