using UnityEngine;
using Cinemachine;

public class Orbital : MonoBehaviour
{
    public float speed = 10f;

    private CinemachineOrbitalTransposer m_orbital;

    void Start()
    {
        var vcam = GetComponent<CinemachineVirtualCamera>();
        if (vcam != null)
            m_orbital = vcam.GetCinemachineComponent<CinemachineOrbitalTransposer>();
    }

    void Update()
    {
        if (m_orbital != null)
            m_orbital.m_XAxis.Value += Time.deltaTime * speed;
    }
}
