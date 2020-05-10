using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class MoveArrows : MonoBehaviour
{
    [SerializeField] private GameObject _secondsPivot;
    [SerializeField] private GameObject _minutePivot;
    [SerializeField] private GameObject _hourPivot;
    [SerializeField] private GameObject _rotateCenter;
    private Vector3 _clockCenter;
    private void Start()
    {
        _clockCenter = _rotateCenter.GetComponent<Transform>().localPosition;
    }
    

   void MovingArrows(GameObject arrow, float angle)
    {
        arrow.transform.RotateAround(_clockCenter, Vector3.back, angle* Time.deltaTime);
    }

    private void Update()
    {
       MovingArrows(_secondsPivot,20f);   //3.6f   
       MovingArrows(_minutePivot,10f);   //0.06f
       MovingArrows(_hourPivot, 5f);    // 0.005f
    }
}
