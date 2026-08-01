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
        SetBall(BallColor.White, 0);
        SetBall(BallColor.Red, 1);
        SetBall(BallColor.Yellow, 2);
        SetBall(BallColor.Green, 3);
        SetBall(BallColor.Brown, 4);
        SetBall(BallColor.Blue, 5);
        SetBall(BallColor.Pink, 6);
        SetBall(BallColor.Black, 7);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SetBall(BallColor col, int i)
    {
        // เช็กป้องกันถ้า index เกินขนาด Array
        if (i >= ballPrefab.Length || i >= ballPositions.Length)
        {
            Debug.LogError($"Index {i} เกินขนาด Array! Check Inspector (ballPrefab size: {ballPrefab.Length}, ballPositions size: {ballPositions.Length})");
            return;
        }

        GameObject obj = Instantiate(ballPrefab[i],
                    ballPositions[i].transform.position,
                    Quaternion.identity);
        Ball b = obj.GetComponent<Ball>();
        b.SetColorAndPoint(col);
    
    }

}
