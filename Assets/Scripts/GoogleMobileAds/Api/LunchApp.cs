using System;
using System.Collections.Generic;
using GoogleMobileAds.Api;
using UnityEngine;
public class LunchApp : MonoBehaviour 
{

    private BannerView bannerView;
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
            string adUnitId = "ca-app-pub-8914296679724331/9069622651";
        #elif UNITY_IPHONE
            string adUnitId = "ca-app-pub-8914296679724331/9069622651";
        #else
            string adUnitId = "unexpected_platform";
        #endif

        bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Top);

        AdRequest request = new AdRequest.Builder().Build();

        bannerView.LoadAd(request);
    }
}
