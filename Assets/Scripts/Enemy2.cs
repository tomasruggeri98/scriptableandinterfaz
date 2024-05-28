using UnityEngine;

public class Enemy2 : MonoBehaviour, IPresentacion
{
    public EnemyData enemyData;

    public void Accion()
    {
        Debug.Log(enemyData.saludo + "mi nombre es " + enemyData.nombre + enemyData.vida);
    }

    private void Start()
    {
        Accion();
    }
}

