using UnityEngine;

public class CoffeeBean : MonoBehaviour
{
    [SerializeField]
    GameObject smallCube;
    [SerializeField]
    int piecesAfterGrind = 4;
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Blade")
        {
            Grind();
        }
    }

    void Grind()
    {
        for (int i = 0; i < piecesAfterGrind; i++)
        {
            Instantiate(smallCube, gameObject.transform.position, Quaternion.identity);
        }
        Destroy(gameObject);
    }
}

/*GrindBlade game obj. modeli küpleri aşağı dökülmesini engelliyor. 
Üzerine ucu yukarıya bakan bir koni ekleyerek birikmeyi önleyebilirsiniz.*/
