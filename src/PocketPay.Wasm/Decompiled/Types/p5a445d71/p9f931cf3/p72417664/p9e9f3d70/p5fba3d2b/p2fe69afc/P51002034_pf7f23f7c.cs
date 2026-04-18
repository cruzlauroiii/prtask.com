namespace WillowMaze.Wasm.Decompiled;

public class P51002034_pf7f23f7c : P51002034, P03c3d84c, P756b0dc3
{
    private readonly Dictionary<string, object> F0fea6a13;
    private readonly byte[] F166cae43;
    private readonly Dictionary<string, object> F1770ba0b;
    private readonly Dictionary<string, object> F2f919c71;
    private readonly byte[] F41c224a0;
    private readonly Dictionary<string, object> F66bda8ac;
    private readonly Dictionary<string, object> Fedd23a8c;

    private byte[] M7b28ac1a(string P0, char[] P1)
    {
        // call: p89be9433.m48fbf2cf
        // call: pff43b8de.md844b504
        // call: p6c0d87f6.m15117b28
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p2fe69afc.p51002034$pf7f23f7c.f41c224a0
        return default!;
    }

    public void EngineDeleteEntry(string P0)
    {
        // str: "delete operation not supported in shared mode"
        // call: KeyStoreException.<init>
        // type: KeyStoreException
    }

    public Key EngineGetKey(string P0, char[] P1)
    {
        // str: "unable to recover key ("
        // str: ")"
        // str: "): "
        // call: p51002034.engineGetKey
        // call: Dictionary<string, object>.containsKey
        // call: StringBuilder.append
        // call: p51002034$pf7f23f7c.m7b28ac1a
        // call: StringBuilder.<init>
        // call: Dictionary<string, object>.put
        // call: UnrecoverableKeyException.<init>
        // call: pff43b8de.m66e765de
        // call: StringBuilder.toString
        // call: Dictionary<string, object>.get
        // call: InvalidKeyException.getMessage
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p2fe69afc.p51002034$pf7f23f7c.f0fea6a13
        // type: UnrecoverableKeyException
        // type: StringBuilder
        return default!;
    }

    public void EngineSetCertificateEntry(string P0, Certificate P1)
    {
        // str: "set operation not supported in shared mode"
        // call: KeyStoreException.<init>
        // type: KeyStoreException
    }

    public void EngineSetKeyEntry(string P0, Key P1, char[] P2, Certificate[] P3)
    {
        // str: "set operation not supported in shared mode"
        // call: KeyStoreException.<init>
        // type: KeyStoreException
    }

    public void EngineSetKeyEntry(string P0, byte[] P1, Certificate[] P2)
    {
        // str: "set operation not supported in shared mode"
        // call: KeyStoreException.<init>
        // type: KeyStoreException
    }

}
