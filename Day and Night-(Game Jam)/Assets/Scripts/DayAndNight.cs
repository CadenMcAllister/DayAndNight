using UnityEngine;
using UnityEngine.UI;

public class DayAndNight : MonoBehaviour
{
    public GameObject Night;
    public Image Image1;
    public Image Image2;
    public GameObject Day;
    // Start is called before the first frame update
    void Start()
    {
        Image1 = gameObject.GetComponent<Image>();
        Night = GameObject.FindGameObjectWithTag("Night");
        Day = GameObject.FindGameObjectWithTag("Day");
        Night.SetActive(false);
        Day.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Night){
            Image1.sprite = Image2.sprite;
        }

        if (Day){
            Image1.sprite = Image1.sprite;
        }
    }
}
