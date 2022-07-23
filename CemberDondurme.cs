using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CemberDondurme : MonoBehaviour
{
    [SerializeField] static float cemberDonusHizi;
    void Update()
    {
        transform.Rotate(0f, 0f, cemberDonusHizi);
    }
}
