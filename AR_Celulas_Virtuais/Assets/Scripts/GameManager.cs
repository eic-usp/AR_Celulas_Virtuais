using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject defaultCell;
    public static GameObject ActiveCell { get; set; }

    private void Start()
    {
        ActiveCell = defaultCell;
    }

    public void ShowActiveCell()
    {
        ActiveCell.SetActive(true);
    }
}
