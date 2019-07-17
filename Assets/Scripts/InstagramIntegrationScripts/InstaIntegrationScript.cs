using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstaIntegrationScript : MonoBehaviour
{
    private bool authCompleted;
    private string url;
    private string password;
    private string userName;

    // Start is called before the first frame update
    void Start()
    {
    
       // Application.OpenURL("https://api.instagram.com/oauth/authorize/?client_id=CLIENT-ID&redirect_uri=REDIRECT-URI&response_type=token");
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetAccessToken(string myurl)
    {
        string url = myurl;
        string accessToken = "access_token";
        string error = "";

        if (url.Contains(accessToken))
        {
            var data = url.Substring(url.LastIndexOf('=') + 1);
            authCompleted = true;

            //Todo Saving in playerpref data

        }
    }
}
