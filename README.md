# Singleton.cs
MonoBehaviourを**継承しない**クラスのシングルトン
インスタンス初生成時の処理はコンストラクタに記述

# SingletonMono.cs
MonoBehaviourを**継承する**クラスのシングルトン
インスタンス初生成時の処理は、任意でOnInstanceMadeメソッドをOverrideして記述。

# 使い方

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
