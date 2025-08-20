using JetBrains.Annotations;
using UnityEngine;

public class ObstaclesGenarate : MonoBehaviour
{
    [SerializeField] GameObject Obstacles;
    [SerializeField]DamageController damageController;
    int[] obstaclesPos = { 4, 17, 26, 36,40,48,56,70,100,122,143,168};
  
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
