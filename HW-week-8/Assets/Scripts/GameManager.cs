using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting; 
using UnityEngine;
using UnityEngine.UI; 

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public TextMeshProUGUI title;
    public TextMeshProUGUI description;
    public ScriptableObjectsScript currentLocation;

    public Button harborButton;
    public Button templeButton;
    public Button lighthouseButton; 
    private void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this; 
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        UpdateLocation();
        
    }

    void UpdateLocation()
    {
        title.text = currentLocation.locationName;
        description.text = currentLocation.locationDescription; 
    }

    public void MoveDirection(int dir)
    {
        switch (dir)
        {
            case 0:
                currentLocation = currentLocation.harborLocation;
                break; 
            case 1:
                currentLocation = currentLocation.templeLocation;
                break; 
            case 2:
                currentLocation = currentLocation.lighthouseLocation;
                break; 
            case 3:
                currentLocation = currentLocation.startLocation;
                break;
        }
        UpdateLocation();
        
    }
}
