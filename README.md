
** Works only with unity version >18**

# Demo : https://vimeo.com/manage/videos/782125956

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

# Browser Integration




Now you will be able to directly integrate and call smartcontract and send transactions via the browser. This was much needed as most of the webgames would require this. 

### C# Methods you can use in unity


**Send ICX To Address:**


IconSDK.BridgeCore.sendTransaction(string to, string value, string stepLimit, string nid, string nonce,string  gameObject, string callBackMethod)


gameObject: "Unity game object name"
callBackMethod: "Callback method name in game"





**Call SCORE View-Only method**

This method can be used to call view-only methods on the icon contracts

IconSDK.BridgeCore.sendCall(string to, string method,string params_,string gameObject,string callBackMethod)

gameObject: "Unity game object name"
callBackMethod: "Callback method name in game"
For other parameters check here<https://github.com/icon-project/icon-sdk-js#iconserviceiconbuildercallbuilder>




**Call SCORE method:**


This method is used to call transaction method on the smart-contract.

IconSDK.BridgeCore.sendCallTransaction(string to, string method, string params_, string value,string stepLimit,string nid,string nonce,string gameObject,string callBackMethod)

gameObject: "Unity game object name"
callBackMethod: "Callback method name in game"
For other parameters check here<https://github.com/icon-project/icon-sdk-js#iconserviceiconbuildercalltransactionbuilder>a

**Callback method**

You can use this function definition for the callback method, you will receive the result of success or failure in the callback method

public void callBackMethod(string resultJsonObject);






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

