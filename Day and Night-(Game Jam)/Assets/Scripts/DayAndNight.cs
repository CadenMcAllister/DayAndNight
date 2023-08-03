using UnityEngine;
using UnityEngine.UI;

public class DayAndNight : MonoBehaviour
{
    public GameObject Night;
    public GameObject Image1;
    public GameObject Image2;
    public GameObject Day;

    private bool isDay = true; 

    // Start is called before the first frame update
    void Start()
    {
        Image1 = GameObject.Find("Image");
        Image2 = GameObject.Find("Image (1)");
        Night = GameObject.FindGameObjectWithTag("Night");
        Day = GameObject.FindGameObjectWithTag("Day");
        Night.SetActive(false);
        Day.SetActive(true);
        Image2.SetActive(false); 
        Image1.SetActive(true); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1)){
            Night.SetActive(true);
            Day.SetActive(false);
            isDay = false; 
        }

        if (Input.GetMouseButtonUp(1)){
            Day.SetActive(true);
            Night.SetActive(false);
            isDay = true; 
        }

        if (isDay){ 
            Image1.SetActive(true);
            Image2.SetActive(false);
        } else if (!isDay) { 
            Image2.SetActive(true);
            Image1.SetActive(false);
        }
    }
}
