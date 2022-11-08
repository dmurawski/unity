using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = System.Random;

public class RandomCubesGenerator : MonoBehaviour
{
    List<Vector3> positions = new List<Vector3>();
    public float delay = 3.0f;
    int objectCounter = 0;
    // obiekt do generowania
    public GameObject block;
    public int count = 1;
    public List<Material> materials;

    void Start()
    {
        int max_x = (int)Math.Pow(GetComponent<Renderer>().bounds.min.x, 2);
        int max_z = (int)Math.Pow(GetComponent<Renderer>().bounds.min.z, 2);
        // w momecie uruchomienia generuje 10 kostek w losowych miejscach
        List<int> pozycje_x = new List<int>(Enumerable.Range((int)GetComponent<Renderer>().bounds.min.x, max_x).Where(x => x < (int)GetComponent<Renderer>().bounds.max.x).OrderBy(x => Guid.NewGuid()).Take(count));
        List<int> pozycje_z = new List<int>(Enumerable.Range((int)GetComponent<Renderer>().bounds.min.z, max_z).Where(x => x < (int)GetComponent<Renderer>().bounds.max.z).OrderBy(x => Guid.NewGuid()).Take(count));

        for (int i = 0; i < count; i++)
        {
            this.positions.Add(new Vector3(pozycje_x[i], 5, pozycje_z[i]));
        }
        foreach (Vector3 elem in positions)
        {
            Debug.Log(elem);
        }
        // uruchamiamy coroutine
        StartCoroutine(GenerujObiekt());
    }

    void Update()
    {

    }

    IEnumerator GenerujObiekt()
    {
        Debug.Log("wywo�ano coroutine");
        foreach (Vector3 pos in positions)
        {
            Random random = new Random();
            this.block.GetComponent<Renderer>().material = materials[random.Next(materials.Count)];
            Instantiate(this.block, this.positions.ElementAt(this.objectCounter++), Quaternion.identity);
            yield return new WaitForSeconds(this.delay);
        }
        // zatrzymujemy coroutine
        StopCoroutine(GenerujObiekt());
    }
}
