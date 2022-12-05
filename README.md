
** Works only with unity version >18**



# IconUnitySDK

This SDK is built around C# ICON sdk that can be found here: https://github.com/EclecticaNetwork/IconSDK.net

To import it to your project double click IconUnitySDK.unitypackage in Artifacts folder. 

There is a scene in SDK with UI that serves as an example of how this SDK can be used. 


#  Installation 


- Start a new unity project, import the package provided here : [/Artifacts/IconUnitySDK.unitypackage](/Artifacts/IconUnitySDK.unitypackage) 
- Now if you have newtonsoft unity package pre-installed delete it from the package manager and install the version 1.0.1 to do this go to your project-folder/Packages and open manifest.json and replace/add the line : 


 ` "com.unity.nuget.newtonsoft-json": "1.0.1",`

- Now install unitask , read from this link https://github.com/Cysharp/UniTask#install-via-git-url



# Usage 

Please refer to the [IconSDKManager.cs](/IconUnitySDK/Assets/UnityIntegration/IconSDKManager.cs) to view the usage, you can create and broadcast transaction 


# Support for Hana and ICONEX

As the base ICONSDK supports all the view calls there is no need to bridge the tx for view calls on the unity side, we have also provided the sample folders WebGLTemplates and Plugins that you can easily paste in your unity project to get it working with Hana and ICONEX. 

Detailed Explanations

index.html : Please replace the index.html in the WebGLTemplates inside your WebGLTemplates folder, this is the edited version of the index.html, to support bridging calls 

IconConnector.jslib : This is the jslib file connecting the unity with the js, it is used to transfer raw unisigned tx from the unity to get them signed via js. 

This type of architecture opportuinity to submit the tx in two ways, according to the dev requirement 

1) Create TX (unity) -> Sign Tx (browserjs) -> Submit (browserjs)
2) Create TX (unity) -> Sign Tx (browserjs) -> Submit (unity)

According to the details of error handling etc, we have provided the example for the first type off transaction




# Known Limitations 

- The Nbitcoin and Nethereum versions are old 
- It wants the newtonsoft-unity-json parser version to be 12.0.1 so you may need to downgrade the version 

