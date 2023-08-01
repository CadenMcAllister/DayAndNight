using UnityEngine;
using UnityEngine.UI;

public class DayAndNight : MonoBehaviour
{
    public GameObject Night;
    public GameObject Image1;
    public GameObject Image2;
    public GameObject Day;
    // Start is called before the first frame update
    void Start()
    {
        Image1 = GameObject.Find("Image");
        Image2 = GameObject.Find("Image(1)");
        Night = GameObject.FindGameObjectWithTag("Night");
        Day = GameObject.FindGameObjectWithTag("Day");
        Night.SetActive(false);
        Day.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Night){
            Image1.SetActive(true);
            Image2.SetActive(false);
        }

        if (Day){

        }
    }
}
