using System;
using UnityEngine;

namespace BoundfoxStudios.MiniGolf._Game.Scripts
{
  public class WindmillRotation : MonoBehaviour
  {
    public float Speed = 30f;

    private void Update()
    {
      transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z + Speed * Time.deltaTime);
    }
  }
}
