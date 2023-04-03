using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu
    (   fileName = "new Location",
        menuName = "ScriptableObjects/Locations",
        order = 0)]

public class ScriptableObjectsScript : ScriptableObject
{
    public string locationName;
    public string locationDescription;

    public ScriptableObjectsScript harborLocation;
    public ScriptableObjectsScript templeLocation;
    public ScriptableObjectsScript lighthouseLocation;
    public ScriptableObjectsScript startLocation; 
}
