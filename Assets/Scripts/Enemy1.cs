using UnityEngine;

public class Enemy1 : MonoBehaviour, IPresentacion
{
    public EnemyData enemyData;

    public void Accion()
    {
        Debug.Log(enemyData.saludo + "soy "+ enemyData.nombre + "y tengo " + enemyData.vida + " de vida");
    }

    private void Start()
    {
        Accion();
    }
}
