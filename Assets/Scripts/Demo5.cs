using System.Collections.Generic;
using TMPro;
using UIS;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Demo 5
/// </summary>
public class Demo5 : MonoBehaviour {

    /// <summary>
    /// Link to list
    /// </summary>
    [SerializeField]
    Scroller List = null;

    /// <summary>
    /// Items count
    /// </summary>
    [SerializeField]
    int Count = 100;

    /// <summary>
    

    /// <summary>
    /// Widths data container
    /// </summary>
    readonly List<int> _widths = new List<int>();

    /// <summary>
    /// Init
    /// </summary>
    void Start() {
        List.OnFill += OnFillItem;
        List.OnWidth += OnWidthItem;
        List.InitData( Count);
    }

    /// <summary>
    /// Callback on fill item
    /// </summary>
    /// <param name="index">Item index</param>
    /// <param name="item">Item object</param>
    void OnFillItem(int index, GameObject item) {
        item.GetComponentInChildren<TextMeshProUGUI>().text = index.ToString();
    }

    /// <summary>
    /// Callback on request item width
    /// </summary>
    /// <param name="index">Item index</param>
    /// <returns>Current item width</returns>
    int OnWidthItem(int index) {
        return (int)List.Prefab.GetComponent<RectTransform>().sizeDelta.x;
    }
    

    /// <summary>
    /// Load next demo scene
    /// </summary>
    /// <param name="index">Scene index</param>
    public void SceneLoad(int index) {
        SceneManager.LoadScene(index);
    }
}