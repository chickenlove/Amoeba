# The Amoeba Project

## 概要

Amoebaは、純粋P2Pのメッセージとファイルの共有ソフトです。

## 目的

インターネットにおける権力による抑圧を排除することが最終的な目標です。
そのためにAmoebaでは、高い匿名性と高い障害耐性を持ったメッセージとファイルの共有の機能をユーザーに提供します。

## 特徴

Amoeba = Freenet + Abstract Network + DHT + (Search = WoT or PoW)

 * 接続は抽象化されているので、I2P, Tor, TCP, Proxy, その他を利用可能です。
 * DHTにはKademlia + コネクションプールを使用します。
 * UPnPによってポートを解放することができますが、Port0でも利用可能です(接続数は少なくなります)。
 * 検索リクエスト、アップロード、ダウンロードなどのすべての通信はDHT的に最適なネットワーク上の相手に常に中継＆拡散されます。
