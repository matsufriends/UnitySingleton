# Singleton.cs
MonoBehaviourを**継承しない**クラスのシングルトン

# SingletonMono.cs
MonoBehaviourを**継承する**クラスのシングルトン

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
