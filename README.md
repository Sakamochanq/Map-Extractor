<div align="center">
    <a href="#">
        <img src="./assets/XXX.png" width="500px" alt="Logo">
    </a>
    <hr>
</div>

<br>

### How to use

地図データ（*.shp）を`PNG`,`JPEG`等の画像として抽出することが出来ます。起動に時間のかかるQGISを使用する必要なくストレスフリーを目指すため、自己用で作成します。

> [!note]
> 現在（2025年5月13日時点）は開発中です。
> 完成時期は未定です。

<br>

<div align="center">
    <a href="#">
        <img src="./assets/XXX.png" width="400px" alt="Demo">
    </a>
</div>

<br>
<hr>
<br>

### Build

<br>

```bash
git clone https://github.com/Sakamochanq/Map-Extractor.git
cd Map-Extractor
```

<br>

Buildを行う場合は、以下のパッケージをインストールしてください。  
インストールの際パッケージ同士の互換性・依存関係に注意してください。

<br>

```bash
dotnet add Package GeoAPI -Version 1.7.5
dotnet add Package NetTopologySuite -Version 1.15.3
dotnet add Package NetTopologySuite.IO.ShapeFile -Version 1.15.3
dotnet add Package SharpMap -Version 1.2.0
```

<br>

Visual Studioから `*.sln` を開き Build を行ってください。

<br>
<hr>
<br>

### License

Release under the [MIT](./LICENSE) LICENSE

<br>

### Author

[Sakamochanq](https://github.com/Sakamochanq)
