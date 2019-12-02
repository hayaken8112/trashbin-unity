# trashbin-unity
http://www.iiiexhibition.com/#modal_work15

<img src="http://www.iiiexhibition.com/images/works/work15/thumbnail.png"
 alt="Last Contact Image" title="Last Contact" width="200" height="200" />

## 実行方法
### セットアップ
* PCとラズパイをLANケーブルでつなぐ
  * もしくは同一の無線LAN
* PCとディスプレイをHDMIケーブルでつなぐ
*  macの環境設定でディスプレイの向きを正しくする。解像度を調整
*  ターミナルからラズパイにsshできることを確認
   *  やり方は以下の注意事項を参照
### PC側
* Unityで~/Documents/trashbin-unityを開く
* Assets/main.unityを開いて実行(上の方の実行ボタン)
* Game Viewを最大化するときは、実行する前に最大化しておく

### ラズパイ側
* ~/Documents/main.pyを実行(python3 main.py)
* カメラに腕をかざして離すとPC側に画像が送信される。

## デバッグ・カメラ調整
* ラズパイ上のターミナルでスクリプトを実行
* カメラ&背景差分表示 : ~/Documents/backsub_highspeed.py
* 表示しながらunityに送信 : ~/Documents/highspeed_client.py

## 注意事項
* PCとラズパイは有線でつなぐ。
* あるいは無線でPCとラズパイを同じローカルネットワークに接続する必要がある。
  * この場合main.py内のipアドレスを変更する必要がある。
* ラズパイのファイル編集はsshで接続するか、直接ラズパイ上で編集する
  * sshがおすすめ
  * vscodeのsshクライアント拡張とかいれると簡単
  * 有線の場合は```ssh pi@raspberrypi.local```
  * 無線の場合は```sssh pi@172.???.???.???```
  * パスワードはrasp
  * 繋がらない場合はpingで確認
  * 繋がらない場合はラズパイを再起動
* ラズパイでpython実行は```python3 hoge.py```
* PC上でUnityのウィンドウをアクティブにしておかないと、画像を受け付けない
