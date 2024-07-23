using UnityEngine;

public class Forest : MonoBehaviour
{
    private TreeFactory _treeFactory;
    [SerializeField] private GameObject treeModel;

    private void Awake()
    {
        _treeFactory = new TreeFactory();
    }

    private void Start()
    {
        if (treeModel == null)
        {
            Debug.LogError("Tree model is not assigned.");
            return;
        }

        GenerateForest();
    }

    private void GenerateForest()
    {
        for (int i = 0; i < 100; i++)
        {
            Vector3 position = new Vector3(Random.Range(-50f, 50f), 0, Random.Range(-50f, 50f));
            float size = Random.Range(0.5f, 2.0f);

            ITree tree = _treeFactory.GetTree("DefaultTree", treeModel);
            tree.Render(position, size);
        }
    }
}