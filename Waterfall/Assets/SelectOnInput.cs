using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class SelectOnInput : MonoBehaviour {
    //******************************************************
    // https://www.youtube.com/watch?v=OWtQnZsSdEU&t=27m32s#
    //******************************************************
    public EventSystem eventSystem;
    public GameObject selectedObject;

    private bool buttonSelected;

    void Start() { }

    void Update()
    {
        if (Input.GetAxisRaw("Vertical") != 0 && !buttonSelected)
        {
            eventSystem.SetSelectedGameObject(selectedObject);
            buttonSelected = true;
        }
        else if(Input.GetKey(KeyCode.Escape))
        {
            GameObject.Find("MainMenu").gameObject.SetActive(true);
        }
    }

    private void OnDisable()
    {
        buttonSelected = false;
    }
}
