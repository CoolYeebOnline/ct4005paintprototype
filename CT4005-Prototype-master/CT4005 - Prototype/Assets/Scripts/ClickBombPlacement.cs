using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickBombPlacement : MonoBehaviour
{
    public GameObject bombPrefab;

    private float timerBomb;
    // Update is called once per frame
    void Update()
    {
        timerBomb -= Time.deltaTime;
        if (Input.GetKey(KeyCode.Space) && timerBomb < 0)
        {
            GameObject bombInstance = Instantiate(bombPrefab);

            bombInstance.transform.position = transform.position;

            bombInstance.transform.localRotation = Quaternion.identity;

            //bombInstance.transform.localScale = Vector3.one;

            //Vector3 trueScale = bombInstance.transform.lossyScale;

            //bombInstance.transform.localScale = new Vector3(1 / trueScale.x, 1 / trueScale.y, 1 / trueScale.z);

            bombInstance.GetComponent<bomb>().LightFuse();
            timerBomb = 3f;
        }
    }
    private void Start()
    {
        timerBomb = 0f;
    }
}