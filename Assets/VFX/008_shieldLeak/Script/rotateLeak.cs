using UnityEngine;
using UnityEngine.VFX;

public class rotateLeak : MonoBehaviour
{
    [SerializeField] private GameObject shield;
    [SerializeField] private float speed;
    [SerializeField] private VisualEffect Shield;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(shield.transform.position, Vector3.up, speed * Time.deltaTime);

        if(Shield != null && Shield.aliveParticleCount == 0){
            gameObject.SetActive(false);
        }
    }
}
