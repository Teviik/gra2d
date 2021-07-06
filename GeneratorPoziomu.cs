using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GeneratorPoziomu : MonoBehaviour
{

    public GameObject InitialBlock;
    public GameObject[] TerenBlocks;


    private List<GameObject> CurrentBlocks = new List<GameObject>();
    private int BlockIndex = 0;
    void Start()
    {
        
        for(int i=0; i<5; i++ )
        {
            GeneratorBlock();
        }
    }

    
    void GeneratorBlock()
    {

        var index = Random.Range(0, TerenBlocks.Length);
        var prefab = TerenBlocks[index];

        if (BlockIndex < 1)
            prefab = InitialBlock;


        var block = Instantiate(prefab);
        CurrentBlocks.Add(block);

        block.transform.position = Vector2.right * BlockIndex * 172.1f;
        GetComponent<BoxCollider2D>().transform.position = Vector2.right * (BlockIndex - 2) * 172.1f;
        BlockIndex++;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GeneratorBlock();

        var block = CurrentBlocks.First();
        Destroy(block);
        CurrentBlocks.RemoveAt(0);
    }
}
