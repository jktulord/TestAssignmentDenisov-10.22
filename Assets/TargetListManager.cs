

using System;
using System.ComponentModel;
using System.Security.AccessControl;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class TargetListManager : MonoBehaviour
{
    private AIDestinationSetter setter;

    public List<Transform> ListTargets;
    public GameObject TargetPrefab;
    //public GameObject LinePrefab;
    // Start is called before the first frame update
    void Start()
    {
        setter = GetComponent<AIDestinationSetter>();
        ListTargets = new List<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, 0);
        if (Input.touchCount > 0){
            Touch touch = Input.GetTouch(0);
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            touchPosition.z = 0;
            GameObject newTarget = Instantiate(TargetPrefab, touchPosition, Quaternion.identity);
            UnityEngine.Debug.Log(touchPosition);
            
            
            LineRenderer lineRenderer = newTarget.AddComponent<LineRenderer>();
            new Material(Shader.Find("Sprites/Default"));
            lineRenderer.widthMultiplier = 0.1f;
            lineRenderer.sortingOrder = 0;
            var points = new Vector3[2];
            if (ListTargets.Count > 0)
                points[0] = ListTargets[ListTargets.Count-1].position;
            else
                points[0] = transform.position;
            points[1] = newTarget.transform.position;
            lineRenderer.SetPositions(points);

            ListTargets.Add(newTarget.transform);
            //transform.position = touchPosition;

        }
        if (ListTargets.Count > 0){
            if (setter.target == null)
                setter.target = ListTargets[0];
            
            if ((transform.position - ListTargets[0].position).magnitude < 0.3f){
                Transform curTarg = ListTargets[0];
                ListTargets.RemoveAt(0);
                Destroy(curTarg.gameObject); 
            }
        }
        else
            setter.target = null;
    }
    void OnDestroy()
    {
        WinManager.PlayerDeath();
    }
}
