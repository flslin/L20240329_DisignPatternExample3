using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPosition3D : MonoBehaviour
{
    public float speed_rotate = 1.0f;
    public float speed_scroll = 200.0f;

    public Transform pivot;

    // 좌표 변환 클래스
    [System.Serializable]
    public class PosCoordinates
    {
        // azimuth(구면 좌표계에서 잰 각도) : 방위각
        // elevation : 앙각
        public float _radius, _azimuth, _elevation;

        float _minrad, _maxrad, _minazi, _maxazi, _minelev, _maxelev;
        public PosCoordinates(Vector3 cartesian)
        {
            _minrad = Mathf.Deg2Rad * minAzi;
            _maxrad = Mathf.Deg2Rad * maxAzi;
            _minelev = Mathf.Deg2Rad * minelev;
            _maxelev = Mathf.Deg2Rad * maxelev;

            radius = cartesian.magnitude;
            azimuth = Mathf.Atan2(cartesian.x, cartesian.y);
            elevation = Mathf.Asin(cartesian.y / radius);
        }

        public float radius
        {
            get { return _radius; }
            private set { _radius = Mathf.Clamp(value, _minrad, _maxrad); }
        }

        public float azimuth
        {
            get { return _azimuth; }
            //private set { Mathf.Repeat(value, _maxazi, _minazi); }
        }

        public float elevation
        {
            get { return _elevation; }
        }

    }
}
