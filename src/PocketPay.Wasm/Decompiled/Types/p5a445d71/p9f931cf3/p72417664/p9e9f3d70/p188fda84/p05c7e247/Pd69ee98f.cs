namespace WillowMaze.Wasm.Decompiled;

public abstract class Pd69ee98f : KeyAgreementSpi
{
    private static Dictionary<string, object> F0077c541;
    private static Hashtable F0ecee728;
    private static Dictionary<string, object> F18843345;
    private static Dictionary<string, object> F21335064;
    private static Hashtable F440f16b2;
    private static Dictionary<string, object> F4bea1ceb;
    private static Dictionary<string, object> F569abfdc;
    private static Dictionary<string, object> F73326a23;
    private static Hashtable F9763d6ad;
    private static Dictionary<string, object> F97af7ea5;
    private static Hashtable F9f055aef;
    private static Dictionary<string, object> Fceaee031;
    private static Dictionary<string, object> Feb63e7c7;
    private readonly string F0d7f1a76;
    private readonly p07d32999 F168e7cba;
    private readonly string F31741e6d;
    private readonly string F46c2fbba;
    private readonly p07d32999 F4b609ae9;
    private byte[] F53f67e05;
    private readonly p07d32999 F5aa39c03;
    private byte[] F63656e04;
    private readonly p07d32999 F85b883c7;
    private readonly p07d32999 Fa104c382;
    private byte[] Fd28c500e;
    private readonly string Fe41b3624;

    private static byte[] M417b0119(byte[] P0)
    {
        // call: System.arraycopy
        return default!;
    }

    private static int M75f5b6e7(string P0)
    {
        // call: string.substring
        // call: int.intValue
        // call: string.indexOf
        // call: p89be9433.mb8a8247c
        // call: Dictionary<string, object>.get
        // call: Dictionary<string, object>.containsKey
        // call: int.parseInt
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pd69ee98f.f18843345
        return 0;
    }

    private byte[] Mb7cc37ef(byte[] P0, string P1, int P2)
    {
        // str: "algorithm OID is null"
        // str: "no OID for algorithm: "
        // str: "unknown algorithm encountered: "
        // call: p07d32999.init
        // call: StringBuilder.toString
        // call: p07d32999.generateBytes
        // call: NoSuchAlgorithmException.<init>
        // call: StringBuilder.<init>
        // call: pff43b8de.m01bc6f8e
        // call: StringBuilder.append
        // call: p364bf33a.<init>
        // call: p97b2f481.<init>
        // call: pc03b0fe3.<init>
        // call: System.arraycopy
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pd69ee98f.f53f67e05
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pd69ee98f.f168e7cba
        // type: StringBuilder
        // type: p364bf33a
        // type: NoSuchAlgorithmException
        // type: pc03b0fe3
        // type: p97b2f481
        return default!;
    }

    private static string Mdbd45717(string P0)
    {
        // str: "92816a46c1ed33b724e8a187465ad86db2c09c1d82ba0543feb4827dca2eea"
        // str: "Serpent"
        // call: string.startsWith
        // call: p364bf33a.getId
        // call: string.indexOf
        // call: DecryptString.decryptString
        // call: p89be9433.mb8a8247c
        // call: string.substring
        // call: Dictionary<string, object>.get
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pd69ee98f.f4bea1ceb
        // field: p5a445d71.p9f931cf3.pca323100.p8ee0f7b6.p1bf4cef9.f7cde8b0c
        // field: p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f6d3c5993
        return string.Empty;
    }

    private byte[] CalcSecret()
    {
        return default!;
    }

    private int EngineGenerateSecret(byte[] P0, int P1)
    {
        // str: " bytes"
        // str: " key agreement: need "
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // call: pd69ee98f.engineGenerateSecret
        // call: System.arraycopy
        // call: ShortBufferException.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pd69ee98f.f0d7f1a76
        // type: ShortBufferException
        // type: StringBuilder
        return 0;
    }

    private SecretKey EngineGenerateSecret(string P0)
    {
        // call: p364bf33a.getId
        // call: pd69ee98f.mdbd45717
        // call: byte[].<init>
        // call: pd69ee98f.mb7cc37ef
        // call: Hashtable.get
        // call: pd69ee98f.m75f5b6e7
        // call: Hashtable.containsKey
        // call: p89be9433.mb8a8247c
        // call: pd69ee98f.calcSecret
        // call: p83bdc664.m50f0e52c
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pd69ee98f.f0ecee728
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pd69ee98f.f9763d6ad
        // type: byte[]
        return default!;
    }

    private byte[] EngineGenerateSecret()
    {
        // call: NoSuchAlgorithmException.getMessage
        // call: pd69ee98f.calcSecret
        // call: pd69ee98f.mb7cc37ef
        // call: IllegalStateException.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pd69ee98f.f168e7cba
        // type: IllegalStateException
        return default!;
    }

}
