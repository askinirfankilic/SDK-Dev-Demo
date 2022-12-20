using AdvertisementSystem.Core;
using UnityEngine;
using Zenject;

[CreateAssetMenu(fileName = "ApplovinSDKDataInstaller", menuName = "Installers/ApplovinSDKDataInstaller")]
public class ApplovinSDKDataInstaller : ScriptableObjectInstaller<ApplovinSDKDataInstaller>
{
    [SerializeField]
    private ApplovinSDKData _applovinSDKData;
    
    public override void InstallBindings()
    {
        Container.BindInstance(_applovinSDKData);
    }
}