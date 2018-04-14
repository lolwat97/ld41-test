using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTextColorAlpha_Timer : MonoBehaviour {

    public float StartTime = 2f;
    private float StartTimeLeft;
    public float FadeInTime = 0.5f;
    private float FadeInTimeLeft;
    public float CurrentAlpha;

    public Color FinalColor = new Color(1,1,1,1);

    private UnityEngine.UI.Text Text;

	// Use this for initialization
	void Start () {
        StartTimeLeft = StartTime;
        FadeInTimeLeft = FadeInTime;
        Text = GetComponent<UnityEngine.UI.Text>();
        Text.color = new Color(FinalColor.r, FinalColor.g, FinalColor.b, 0);
	}
	
	// Update is called once per frame
	void Update () {
        if(StartTimeLeft >= 0)
            StartTimeLeft -= Time.deltaTime;
        else
            if(FadeInTimeLeft >= 0)
            {
            FadeInTimeLeft -= Time.deltaTime;
            CurrentAlpha = 1 - (FadeInTimeLeft/FadeInTime);
            Text.color = new Color(FinalColor.r, FinalColor.g, FinalColor.b, CurrentAlpha);
            }
        
	}
}
