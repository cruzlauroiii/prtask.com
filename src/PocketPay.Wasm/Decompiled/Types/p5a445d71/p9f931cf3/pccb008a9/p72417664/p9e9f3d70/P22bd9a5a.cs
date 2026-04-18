namespace WillowMaze.Wasm.Decompiled;

public class P22bd9a5a : Provider, Pa80a706f
{
    public static string F024fc5f4;
    private static string F0c8b8468;
    private static string F11c03ec2;
    private static Dictionary<string, object> F13971749;
    private static string[] F33542fe2;
    public static string F39ce6da8;
    public static pfe41e66b F3e947965;
    private static string F449af774;
    private static Dictionary<string, object> F477a8a18;
    private static string[] F52db1505;
    private static string F5635e6d1;
    public static string F6a4353c8;
    public static string F8d4b7180;
    private static string F991415ee;
    private static string F9ef0b6ce;
    public static string Fb271ad37;
    private static string Fcaf9b6b9;
    public static pfe41e66b Fd08e68ea;
    private static Dictionary<string, object> Fd10a9cca;
    private static string[] Fd64387a3;
    private static string[] Fdb402cc7;
    private static string[] Fe6618f04;
    private static Dictionary<string, object> Ff7a46120;
    private static string Ffd0ce160;
    private static Dictionary<string, object> Ffd15a252;

    public static PublicKey M1367c17c(p3cdccfc9 P0)
    {
        // call: p3cdccfc9.getAlgorithm
        // call: pae2f7198.generatePublic
        // call: p234a7530.getAlgorithm
        // call: p22bd9a5a.m4adb1aab
        return default!;
    }

    private static pae2f7198 M4adb1aab(p364bf33a P0)
    {
        // call: Dictionary<string, object>.get
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p22bd9a5a.ff7a46120
        return default!;
    }

    private void Ma0f84894()
    {
        // str: "a81e38538a0444767ec4f1b5e2dd1135e80f427f52c36e7e087acf44781ecda44f6cd911c7ae075bb517b889f06b53ad1..."
        // call: p22bd9a5a.mdfb3e053
        // call: DecryptString.decryptString
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p22bd9a5a.fd64387a3
    }

    private static Type Mdf9e1f96(Type P0, string P1)
    {
        // call: Type.getClassLoader
        // call: ClassLoader.loadClass
        // call: p22bd9a5a$2.<init>
        // call: AccessController.doPrivileged
        // type: p22bd9a5a$2
        return default!;
    }

    private void Mdfb3e053(string P0, string[] P1)
    {
        // str: "$Mappings : "
        // str: "$Mappings"
        // str: "cannot create instance of "
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: Type.newInstance
        // call: pf0f6addc.configure
        // call: InternalError.<init>
        // call: p22bd9a5a.mdf9e1f96
        // type: p22bd9a5a
        // type: StringBuilder
        // type: InternalError
    }

    public static PrivateKey Me72b28f9(p811299f8 P0)
    {
        // call: p22bd9a5a.m4adb1aab
        // call: p234a7530.getAlgorithm
        // call: pae2f7198.generatePrivate
        // call: p811299f8.getPrivateKeyAlgorithm
        return default!;
    }

    private static void Mf23e8626(p22bd9a5a P0)
    {
        // call: p22bd9a5a.ma0f84894
    }

    public void AddAlgorithm(string P0, string P1)
    {
        // str: ") found"
        // str: "duplicate provider key ("
        // call: IllegalStateException.<init>
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // call: p22bd9a5a.containsKey
        // call: p22bd9a5a.put
        // type: StringBuilder
        // type: IllegalStateException
    }

    public void AddAlgorithm(string P0, p364bf33a P1, string P2)
    {
        // str: ".OID."
        // str: "4204a8883ce6f8dad8e128826848161c42a3ce47a584afc5c37577a37c"
        // str: ") not found"
        // str: "primary key ("
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // call: DecryptString.decryptString
        // call: StringBuilder.toString
        // call: p22bd9a5a.addAlgorithm
        // call: IllegalStateException.<init>
        // call: p22bd9a5a.containsKey
        // type: StringBuilder
        // type: IllegalStateException
    }

    public void AddAttributes(string P0, Dictionary<string, object> P1)
    {
        // str: ") found"
        // str: "duplicate provider attribute key ("
        // str: "7b722d558fa04cdf0e67e6d76f2b309340a803681e1c9e871c7bb1582b"
        // call: StringBuilder.append
        // call: p22bd9a5a.put
        // call: StringBuilder.<init>
        // call: Dictionary<string, object>.keySet
        // call: StringBuilder.toString
        // call: IEnumerator<object>.next
        // call: HashSet<object>.iterator
        // call: p22bd9a5a.containsKey
        // call: DecryptString.decryptString
        // call: IllegalStateException.<init>
        // call: Dictionary<string, object>.get
        // call: IEnumerator<object>.hasNext
        // type: StringBuilder
        // type: IllegalStateException
    }

    public void AddKeyInfoConverter(p364bf33a P0, pae2f7198 P1)
    {
        // call: Dictionary<string, object>.put
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p22bd9a5a.ff7a46120
    }

    public pae2f7198 GetKeyInfoConverter(p364bf33a P0)
    {
        // call: Dictionary<string, object>.get
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p22bd9a5a.ff7a46120
        return default!;
    }

    public bool HasAlgorithm(string P0, string P1)
    {
        // str: "b178eaff5575428517542b28b18e0970f1dce7501fd56b665fb921964b"
        // str: "Alg.Alias."
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: p22bd9a5a.containsKey
        // call: DecryptString.decryptString
        // type: StringBuilder
        return false;
    }

    public void SetParameter(string P0, object P1)
    {
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p22bd9a5a.fd08e68ea
    }

}
