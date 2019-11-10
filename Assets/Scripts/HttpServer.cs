using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;


[System.Serializable]
public class OnRequestEvent : UnityEvent<HttpListenerContext> { }

public class HttpServer : MonoBehaviour
{
    private HttpListener httpListener = new HttpListener();

    public int port = 8080;
    public string path = "/";
    public bool startOnAwake = true;
    public OnRequestEvent OnRequest;

    // Use this for initialization
    void Start()
    {
        httpListener.Prefixes.Add("http://*:" + port + path);
        if (startOnAwake)
        {
            StartServer();
        }
    }
    // リクエストの受け付けを開始する
    public async Task StartServer()
    {
        httpListener.Start();

        while (true)
        {
            // リモートからの接続を待機
            var context = await httpListener.GetContextAsync();

            // 着信ログを表示
            Debug.Log("Request path: " + context.Request.RawUrl);

            OnRequest.Invoke(context);
        }
    }

    // サーバーを停止する
    public void StopServer()
    {
        httpListener.Stop();
    }

    // 破棄時にサーバーを止める
    void OnDestroy()
    {
        StopServer();
    }
}
