# trashbin-unity

## 実行方法
### PC側
* Assets/main.unityを開いて実行(上の方の実行ボタン)
* Game Viewを最大化するときは、実行する前に最大化しておく

### ラズパイ側
* ~/Documents/highspeed_client.pyを開いて、IPアドレスをPCのIPアドレス(172.???とか)に指定
* highspeed_client.pyを実行(python3 highspeed_client.py)
* カメラに腕をかざして離すとPC側に画像が送信される。

## 注意事項
* PCとラズパイは同じローカルネットワークに接続する必要がある。
* ラズパイのファイル編集はsshで接続するか、直接ラズパイ上で編集するか
** sshがおすすめ
** vscodeのsshクライアント拡張とかいれると簡単
** ラズパイのIPアドレス(172.???とか)を指定する
** パスワードはrasp
