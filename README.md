
** Works only with unity version >18**



# IconUnitySDK

This SDK is built around C# ICON sdk that can be found here: https://github.com/zsaladin/IconSDK.Net

To import it to your project double click IconUnitySDK.unitypackage in Artifacts folder. 

There is a scene in SDK with UI that serves as an example of how this SDK can be used. 


#  Installation 


- Start a new unity project, import the package provided here : [/Artifacts/IconUnitySDK.unitypackage](/Artifacts/IconUnitySDK.unitypackage) 
- Now if you have newtonsoft unity package pre-installed delete it from the package manager and install the version 1.0.1 to do this go to your project-folder/Packages and open manifest.json and replace/add the line : 


 ` "com.unity.nuget.newtonsoft-json": "1.0.1",`

- Now install unitask , read from this link https://github.com/Cysharp/UniTask#install-via-git-url



# Usage 

Please refer to the [IconSDKManager.cs](/IconUnitySDK/Assets/UnityIntegration/IconSDKManager.cs) to view the usage, you can create and broadcast transaction 


# Known Limitations 

- The Nbitcoin and Nethereum versions are old 
- It wants the newtonsoft-unity-json parser version to be 12.0.1 so you may need to downgrade the version 

