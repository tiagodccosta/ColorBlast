using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using admob;

public class AdManager : MonoBehaviour {

    public static AdManager Instance { set; get;}

    private void Start()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);

#if UNITY_EDITOR
#elif UNITY_ANDROID
        Admob.Instance().initAdmob("ca-app-pub-9864525431596351/2608323060", "ca-app-pub-9864525431596351/3673992722");
        Admob.Instance().loadInterstitial();
#endif
    }

    public void ShowBanner()
    {
        #if UNITY_EDITOR
        #elif UNITY_ANDROID
        Admob.Instance().showBannerRelative(AdSize.Banner, AdPosition.TOP_CENTER, 5);
        #endif
    }

    public void ShowBannerDown()
    {
        #if UNITY_EDITOR
        #elif UNITY_ANDROID
        Admob.Instance().showBannerRelative(AdSize.Banner, AdPosition.BOTTOM_CENTER, 5);
        #endif
    }

    public void ShowVideo()
    {
        #if UNITY_EDITOR
        #elif UNITY_ANDROID
        if(Admob.Instance().isInterstitialReady())
        {
            Admob.Instance().showInterstitial();
        }
        #endif
    } 

}
