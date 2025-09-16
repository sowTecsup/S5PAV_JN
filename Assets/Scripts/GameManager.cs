using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int variable;

    public Player player1 = new(10);
    public Player player2 = new(10);
    void Start()
    {
        Player player3 = player1 + player2;
        Player player4 = player2 / 2;
    }

    // Update is called once per frame
    void Update()
    {
        MiMetodo();
    }
    public void MiMetodo()
    {

    }
    
    public void MiMetodo(int x = 10)
    {

    }
    public void MiMetodo(int x , int a , int z)
    {

    }


}
