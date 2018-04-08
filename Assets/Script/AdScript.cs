using UnityEngine;
using System.Collections;
using GoogleMobileAds.Api;

public class AdScript : MonoBehaviour
{

    bool hasShownAdOneTime;

    // Use this for initialization
    void Start()
    {
        //Request Ad
        RequestInterstitialAds();
    }

    void Update()
    {
        if (GameScript.isGameOver)
        {
            if (!hasShownAdOneTime)
            {
                hasShownAdOneTime = true;
                Invoke("showInterstitialAd", 2.0f);
            }
        }
    }

    public void showInterstitialAd()
    {
        //Show Ad
        if (interstitial.IsLoaded())
        {
            interstitial.Show();

            //Stop Sound
            //

            Debug.Log("SHOW AD XXX");
        }

    }

    InterstitialAd interstitial;
    private void RequestInterstitialAds()
    {
        // Initialize an InterstitialAd.
        interstitial = new InterstitialAd("ca-app-pub-6483352859443241/1381369593");

        AdRequest request = new AdRequest.Builder().Build();

        // Load the interstitial with the request.
        interstitial.LoadAd(request);

        Debug.Log("AD LOADED XXX");

    }
}