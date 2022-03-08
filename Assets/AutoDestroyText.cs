using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class AutoDestroyText : MonoBehaviour
{
    public float AutoDestroyTime = 5f;

    private TextMeshProUGUI Text;
    private float SpawnTime;

    private void Awake()
    {
        Debug.Log("Awake");
        Text = GetComponent<TextMeshProUGUI>();
    }

    private void OnEnable()
    {
        Debug.Log("Enable");
        SpawnTime = Time.time;
    }

    private void Start()
    {
        Debug.Log("Start");
        AutoDestroyTime = 5f;
    }

    private void Update()
    {
        float remainingTime = (SpawnTime + AutoDestroyTime) - Time.time;

        Text.SetText($"{remainingTime:N2}");

        if (remainingTime <= 0)
        {
            Destroy(gameObject);
        }
    }
}
