#define TEST
using UnityEngine;
using UnityEngine.Advertisements;

namespace Ads { 
    public class AdsManager : MonoBehaviour
    {

        #if UNITY_IOS
            private string _gameID = "3870136";
        #elif UNITY_ANDROID
            private string _gameID = "3870137";
        #else
            private string _gameID = "1234567";
        #endif

        #if TEST
            private bool _isTest = true;
        #else
            private bool _isTest = false;
        #endif


        //project id: 35b414e6-744b-40fb-966f-52ab8f9f1158

        private void Start()
        {
            Advertisement.Initialize(_gameID, _isTest);
        }

        /* 3 çeşit reklam var 
        1-Interstitial = tam ekran, 5 sn sonra geç videolar
        2-banner = tepede kenarlarda çıkan reklamlar
        3-reward = geçemediğimiz 30snlik, izlenme sonunda bir şey kazanılan reklamlar
        */

        private void Update()
        {
            if (Input.GetKeyUp(KeyCode.N))
            {
                ShowInterstitialAd();
            }
        }

        public void ShowInterstitialAd()
        {
            if (Advertisement.IsReady())  //reklam havuzunda reklam var mı?
            {
                Advertisement.Show();
            }
            else
            {
                Debug.LogWarning("havuz boş");
            }
        }
        
    }
}
