using UnityEngine;

public class DeltaTimeChanger : MonoBehaviour
{
    [SerializeField] private float _timeScale = 1.0f;

    private void Start()
    {
        Time.timeScale = _timeScale;
    }
}
