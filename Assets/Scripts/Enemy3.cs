using UnityEngine;

public class Enemy3 : MonoBehaviour, IPresentacion
{
    public EnemyData enemyData;

    public void Accion()
    {
        Debug.Log(enemyData.saludo + "soy " + enemyData.nombre + "tengo " + enemyData.vida);
    }

    private void Start()
    {
        Accion();
    }
}

