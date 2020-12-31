# Singleton.cs
MonoBehaviourを**継承しない**クラスのシングルトン

インスタンス初生成時の処理は**コンストラクタ**に記述

# SingletonMono.cs
MonoBehaviourを**継承する**クラスのシングルトン

インスタンス初生成時の処理は、任意で**OnInstanceMadeメソッド**をOverrideして記述。

# 使用例

```
public class Hoge : SingletonMono<Hoge>{
  public void Piyo(){
    // ~~
  }
}

public class Fuga{
  public void FugaFuga(){
    Hoge.Instance.Piyo();
  }
}
```
