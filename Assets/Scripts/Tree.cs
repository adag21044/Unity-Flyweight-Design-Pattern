using System;
using UnityEngine;

public class Tree : ITree
{
    public GameObject treeModel;

    public Tree(GameObject model)
    {
        treeModel = model ?? throw new ArgumentNullException(nameof(model));
    }

    public void Render(Vector3 position, float size)
    {
        GameObject treeInstance = GameObject.Instantiate(treeModel);
        treeInstance.transform.position = position;
        treeInstance.transform.localScale = new Vector3(size, size, size);
    }
}