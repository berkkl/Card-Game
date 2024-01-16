using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Utility : MonoBehaviour
{
    public static float CalculateInflationImpact(float amount, float inflationRate)
    {
        return amount * inflationRate / 100;
    }
    // Add more utility methods
    
    #region Distance Between Points
    public static float GetDistance(Vector3 pointA, Vector3 pointB)
    {
        return Vector3.Distance(pointA, pointB);
    }
    #endregion Distance Between Points

    #region Layer Check
    public static bool IsLayerInMask(int layer, LayerMask mask)
    {
        return mask == (mask | (1 << layer));
    }
    #endregion Layer Check

    #region Clamp and Normalize Angle
    public static float ClampAngle(float angle, float min, float max)
    {
        angle = NormalizeAngle(angle);
        min = NormalizeAngle(min);
        max = NormalizeAngle(max);
        return Mathf.Clamp(angle, min, max);
    }

    public static float NormalizeAngle(float angle)
    {
        while (angle > 360) angle -= 360;
        while (angle < 0) angle += 360;
        return angle;
    }
    #endregion Clamp and Normalize Angle

    #region Random Point in Bounds
    public static Vector3 RandomPointInBounds(Bounds bounds)
    {
        return new Vector3(
            Random.Range(bounds.min.x, bounds.max.x),
            Random.Range(bounds.min.y, bounds.max.y),
            Random.Range(bounds.min.z, bounds.max.z)
        );
    }
    #endregion Random Point in Bounds
    
    #region Camera Reference
    private static Camera _camera;

    public static Camera Camera
    {
        get
        {
            if (_camera == null) _camera = Camera.main;
            return _camera;
        }
    }
    #endregion Camera Reference
    #region Non-Allocating WaitForSeconds
    // To reduce garbage collection in coroutines
    private static readonly Dictionary<float, WaitForSeconds> WaitDictionary = new Dictionary<float, WaitForSeconds>();

    public static WaitForSeconds GetWait(float time)
    {
        if (WaitDictionary.TryGetValue(time, out WaitForSeconds wait)) return wait;

        WaitDictionary[time] = new WaitForSeconds(time);
        return WaitDictionary[time];
    }
    #endregion Non-Allocating WaitForSeconds
    #region Is Over UI
    // In order to check if you're clicking a UI or not
    private static PointerEventData _eventDataCurrentPosition;
    private static List<RaycastResult> _results;
    public static bool IsOverUi()
    {
        _eventDataCurrentPosition = new PointerEventData(EventSystem.current) { position = Input.mousePosition };
        _results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(_eventDataCurrentPosition, _results);
        return _results.Count > 0;
    }
    #endregion Is Over UI
    #region Get World Point Of Canvas Element
    // To get the world point of canvas element
    public static Vector2 GetWorldPositionOfCanvasElement(RectTransform element)
    {
        RectTransformUtility.ScreenPointToWorldPointInRectangle(element, element.position, Camera, out var result);
        return result;
    }
    #endregion Get World Point
}
