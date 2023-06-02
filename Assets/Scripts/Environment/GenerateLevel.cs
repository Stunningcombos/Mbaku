using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    public GameObject[] Sections;
    public int zpos = 50;
    public bool CreatingSection = false;
    public int Numsec;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (CreatingSection == false)
        {
            CreatingSection = true;
            StartCoroutine(GenerateSection());
        }
    }
    IEnumerator GenerateSection()
    {
        Numsec = Random.Range(0, 3);
        Instantiate(Sections[Numsec], new Vector3(0, 0, zpos), Quaternion.identity);
        zpos += 335;
        yield return new WaitForSeconds(2);
        CreatingSection = false;
    }

}
