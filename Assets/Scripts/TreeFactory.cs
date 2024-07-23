using System;
using System.Collections.Generic;
using UnityEngine;

public class TreeFactory
{
    private readonly Dictionary<string, ITree> trees = new Dictionary<string, ITree>();

    public ITree GetTree(string key, GameObject model)
    {
        if (string.IsNullOrEmpty(key))
        {
            throw new ArgumentException("Key cannot be null or empty", nameof(key));
        }
        
        if (model == null)
        {
            throw new ArgumentNullException(nameof(model));
        }
        
        //Model sharing
        if (!trees.ContainsKey(key))
        {
            trees[key] = new Tree(model);
        }

        return trees[key];
    }
    
}