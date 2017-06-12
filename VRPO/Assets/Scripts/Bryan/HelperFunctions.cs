using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelperFunctions
{
    public static Vector3 MultiplyVector3(Vector3 vector1, Vector3 vector2)
    {
        Vector3 result = new Vector3(vector1.x * vector2.x, vector1.y * vector2.y, vector1.z * vector2.z);
        return result;
    }

    public static float ClampAngle(float angle, float min, float max)
    {
        if (min < 0 && max > 0 && (angle > max || angle < min))
        {
            angle -= 360;
            if (angle > max || angle < min)
            {
                if (Mathf.Abs(Mathf.DeltaAngle(angle, min)) < Mathf.Abs(Mathf.DeltaAngle(angle, max))) return min;
                else return max;
            }
        }
        else if (min > 0 && (angle > max || angle < min))
        {
            angle += 360;
            if (angle > max || angle < min)
            {
                if (Mathf.Abs(Mathf.DeltaAngle(angle, min)) < Mathf.Abs(Mathf.DeltaAngle(angle, max))) return min;
                else return max;
            }
        }

        if (angle < min) return min;
        else if (angle > max) return max;
        else return angle;
    }

    public static bool CheckWithinRange(float min, float max, float value)
    {
        if (value >= min && value <= max)
            return true;
        else
            return false;
    }
}
