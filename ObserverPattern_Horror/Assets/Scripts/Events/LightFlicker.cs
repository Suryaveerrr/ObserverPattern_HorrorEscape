using UnityEngine;
using System.Collections;

public class LightFlicker : MonoBehaviour
{
    public Light lamp;
    public float flickerDuration = 2f;   
    public float flickerCooldown = 5f;   
    public float minFlickerTime = 0.03f; 
    public float maxFlickerTime = 0.2f;  
    public bool flickerOnStart = true;

    private void Start()
    {
        if (lamp == null)
        {
            lamp = GetComponentInChildren<Light>();
        }

        if (flickerOnStart)
            StartCoroutine(FlickerLoop());
    }

    IEnumerator FlickerLoop()
    {
        while (true)
        {
            yield return new WaitForSeconds(flickerCooldown);

            float flickerEndTime = Time.time + flickerDuration;

            while (Time.time < flickerEndTime)
            {
                lamp.enabled = false;
                yield return new WaitForSeconds(Random.Range(minFlickerTime, maxFlickerTime));

                lamp.enabled = true;
                yield return new WaitForSeconds(Random.Range(minFlickerTime, maxFlickerTime));
            }

            lamp.enabled = true; // Ensure it's ON after flicker
        }
    }
}
