using UnityEngine;

namespace KKH.Camera
{
    public class CameraResolution : BaseBehaviour
    {
        [SerializeField] private UnityEngine.Camera _camera;
        [SerializeField] private float _boardUnit;

        protected override void Initialize()
        {
            base.Initialize();
            float targetAspect = 16f / 9f;
            float currentAspect = _camera.aspect;

            if (currentAspect >= targetAspect)
            {
                _camera.orthographicSize = _boardUnit / targetAspect;
            }
            else
            {
                _camera.orthographicSize = _boardUnit / currentAspect;
            }
        }

        protected override void OnBindField()
        {
            base.OnBindField();
            _camera = GetComponent<UnityEngine.Camera>();
        }
    }

}
