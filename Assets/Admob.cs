using UnityEngine;
using System.Collections;
using GoogleMobileAds.Api;

public class Admob : MonoBehaviour
{
    InterstitialAd interstitial;

    public string InterstitialId;

    // Use this for initialization
    void Start()
    {
#if UNITY_ANDROID
        string appID = "ca-app-pub-3681695695299458~4413828827";
#elif UNITY_IPHONE
			string adUnitId = "INSERT_IOS_INTERSTITIAL_AD_UNIT_ID_HERE";
#else
			string adUnitId = "unexpected_platform";
#endif
        //Request Ads
        //RequestBanner();
        MobileAds.Initialize(appID);

        RequestInterstitial();

        showInterstitialAd();

    }

    public void showInterstitialAd()
    {
        //Show Ad
        if (interstitial.IsLoaded())
        {
            Debug.Log("ahadna rekjkllaaam");
            interstitial.Show();
        }

    }



    private void RequestInterstitial()
    {
#if UNITY_ANDROID
        string adUnitId = InterstitialId;
#elif UNITY_IPHONE
			string adUnitId = "INSERT_IOS_INTERSTITIAL_AD_UNIT_ID_HERE";
#else
			string adUnitId = "unexpected_platform";
#endif

        // Initialize an InterstitialAd.
        interstitial = new InterstitialAd(adUnitId);
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        interstitial.LoadAd(request);
    }

}