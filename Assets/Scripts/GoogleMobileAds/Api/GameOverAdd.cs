using System;
using System.Collections.Generic;
using GoogleMobileAds.Api;
using UnityEngine;

public class GameOverAdd : MonoBehaviour 
{

  private InterstitialAd interstitial;
	public void Start()
    {

        #if UNITY_ANDROID
            string appId = "ca-app-pub-8914296679724331~2979240495";
        #elif UNITY_IPHONE
            string appId = "ca-app-pub-8914296679724331~2979240495";
        #else
            string appId = "unexpected_platform";
        #endif


        MobileAds.Initialize(appId);

        this.RequestBanner();
    }
    private void RequestBanner()
    {
        #if UNITY_ANDROID
            string adUnitId = "ca-app-pub-8914296679724331/5969473133";
        #elif UNITY_IPHONE
            string adUnitId = "ca-app-pub-8914296679724331/5969473133";
        #else
            string adUnitId = "unexpected_platform";
        #endif

        this.interstitial = new InterstitialAd(adUnitId);

        AdRequest request = new AdRequest.Builder().Build();

        this.interstitial.LoadAd(request);
		
		if (this.interstitial.IsLoaded()) 
		{
    		this.interstitial.Show();
  		}
    }
}
