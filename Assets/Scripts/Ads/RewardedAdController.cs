using UnityEngine.Advertisements;
using UnityEngine;

namespace Ads
{
    public class RewardedAdController : MonoBehaviour, IUnityAdsListener
    {
        private string _gameID = "1234567";
        private AdsPlacementType _placement = AdsPlacementType.rewardedVideo;

        void Start()
        {
            Advertisement.AddListener(this);
            Advertisement.Initialize(_gameID, true);
        }

        public void Update()
        {
            if (Input.GetKeyUp(KeyCode.L))
            {
                ShowRewardedVideo();
            }
        }

        public void ShowRewardedVideo()
        {
            if (Advertisement.IsReady(_placement.ToString()))
            {
                Advertisement.Show(_placement.ToString());
            }
            else
            {
                Debug.LogWarning("ödüllü reklam havuzda yok");
            }
        }


        public void OnUnityAdsDidError(string message)
        {
            throw new System.NotImplementedException();
        }

        public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
        {
            switch (showResult)
            {
                case ShowResult.Failed:
                    //ödül yok
                    break;
                case ShowResult.Skipped:
                    //ödül yok
                    break;
                case ShowResult.Finished:
                    //ödül verilir
                    Debug.Log("REWARD!!");
                    break;
            }
        }

        public void OnUnityAdsDidStart(string placementId)
        {
            
        }

        public void OnUnityAdsReady(string placementId)
        {
            
        }

        public void OnDisable()
        {
            Advertisement.RemoveListener(this);
        }


    }
}