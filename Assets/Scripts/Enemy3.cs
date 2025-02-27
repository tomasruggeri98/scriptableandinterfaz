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

    void OnTriggerEnter2D(Collider2D other)
    {
        // Verificar si el objeto con el que hemos colisionado tiene el tag "Player"
        if (other.CompareTag("Player"))
        {
            // Llamar al m�todo Accion
            Accion();
        }
    }
}

