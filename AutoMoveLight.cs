using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class AutoMoveLight : MonoBehaviour
{
    const float NOON_ANGLE_X = 50f;
    const float NOON_ANGLE_Y = -30f;
    const float NOON_ANGLE_Z = 0f;

    const float NIGHT_ANGLE_X = -130f;
    const float NIGHT_ANGLE_Y = -30f;
    const float NIGHT_ANGLE_Z = 0f;
    
    // 昼に光源をセット
    [MenuItem("GameObject/AutoMoveLight/SetNoon", priority = 21)]
    public static void SetNoon()
    {       
        // GameObjectを選択してなかったらreturn 
        if(Selection.activeGameObject == null){ return;}

        // Lightコンポーネントを持ってなかったらreturn
        if( !Selection.activeGameObject.GetComponent<Light>()){ return;}

        GameObject LightObj = Selection.activeGameObject.gameObject;
        Transform myTransform = LightObj.transform;
        Vector3 noonAngle = myTransform.eulerAngles;
        noonAngle.x = NOON_ANGLE_X;
        noonAngle.y = NOON_ANGLE_Y;
        noonAngle.z = NOON_ANGLE_Z;
        myTransform.eulerAngles = noonAngle;
    }

    // 夜に光源をセット
    [MenuItem("GameObject/AutoMoveLight/SetNight", priority = 21)]
    public static void SetNight()
    {
        // GameObjectを選択してなかったらreturn 
        if(Selection.activeGameObject == null){ return;}

        // Lightコンポーネントを持ってなかったらreturn
        if( !Selection.activeGameObject.GetComponent<Light>()){ return;}

        GameObject LightObj = Selection.activeGameObject.gameObject;
        Transform myTransform = LightObj.transform;
        Vector3 nightAngle = myTransform.eulerAngles;
        nightAngle.x = NIGHT_ANGLE_X;
        nightAngle.y = NIGHT_ANGLE_Y;
        nightAngle.z = NIGHT_ANGLE_Z;
        myTransform.eulerAngles = nightAngle;
    }
}
