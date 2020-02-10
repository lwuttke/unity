using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Storm : MonoBehaviour
{
    private List<SpriteRenderer> childs;
    // Start is called before the first frame update
    void Start()
    {
        childs = new List<SpriteRenderer>();
        for(int i = 0; i < transform.childCount; i++)
        {
            Transform child = transform.GetChild(i);
            SpriteRenderer r = child.GetComponent<SpriteRenderer>();
            if (r != null)
                childs.Add(r);
        }
        childs.Sort(ComparePosition);

        for (int i = 0; i < transform.childCount; i++)
        {
            Transform child = transform.GetChild(i);
            SpriteRenderer spriteRenderer = child.GetComponent<SpriteRenderer>();
            if (spriteRenderer != null)
            {
                float reduceFactor = i / (float) transform.childCount;
                spriteRenderer.color = spriteRenderer.color - new Color(reduceFactor, reduceFactor, reduceFactor, 0.0f);
            }
        }
    }

    // Step 3: Method to compare the x position of two sprites.
    // It returns 0 if both x-positions are equal, 1 if the x-position of the first argument (sr1) is larger than the second one (sr2)
    // and -1 if it is smaller.
    public static int ComparePosition(SpriteRenderer sr1, SpriteRenderer sr2)
    {
        if (sr1.transform.position.x < sr2.transform.position.x)
            return -1;
        if (sr1.transform.position.x > sr2.transform.position.x)
            return 1;
        return 0;
    }

}
