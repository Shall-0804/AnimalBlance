using JetBrains.Annotations;
using UnityEngine;

public class ObstaclesGenarate : MonoBehaviour
{
    [SerializeField] GameObject Obstacles;
    [SerializeField]DamageController damageController;
    int[] obstaclesPos = { 5, 20, 30, 40,45,53,59,72,103,114,123,143,160};
  
    void Start()
    {
      
        damageController.ReGenarate += GenarateObj;
        //ç≈èâÇÃê∂ê¨
        for (int i = 0; i < obstaclesPos.Length; i++)
        {
            GameObject Obj = Instantiate(Obstacles, new Vector3(0, 10.3f, obstaclesPos[i]), Quaternion.identity);
        }
        
    }

    void Update()
    {
        
    }
    void GenarateObj()
    {
        for (int i = 0; i < obstaclesPos.Length; i++)
        {
            GameObject Obj = Instantiate(Obstacles, new Vector3(0, 10.3f, obstaclesPos[i]), Quaternion.identity);
        }
    }
}
