namespace WillowMaze.Wasm.Decompiled;

public class Pde667cd0_p3fd6b696 : Pde667cd0
{
    private static Hashtable F07b46124;
    private static Hashtable F1e2e3705;
    private static Hashtable F7a022186;
    private static Hashtable F9127309d;
    private static Hashtable F93d22a9e;
    private System.Security.Cryptography.RandomNumberGenerator F0af0cfd4;
    private pfe41e66b F3f695167;
    private p4760c269 F426954c3;
    private int F5177790a;
    private object F7039d30f;
    private System.Security.Cryptography.RandomNumberGenerator F7ddf32e1;
    private System.Security.Cryptography.RandomNumberGenerator F87135bcf;
    private object F918b1e00;
    private object Fa4cd1c63;
    private p2c69f81a Fad1943a9;
    private p2c69f81a Fc274140c;
    private int Fc8bea13b;
    private pfe41e66b Fccd10663;
    private p4760c269 Fcf09ff5b;
    private string Fd4fc7909;
    private bool Fdb1687e1;
    private bool Fdb42cb97;
    private p4760c269 Feca07335;
    private System.Security.Cryptography.RandomNumberGenerator Feca0e524;
    private string Fed469618;

    private p4760c269 CreateKeyGenParamsBC(p835df581 P0, System.Security.Cryptography.RandomNumberGenerator P1)
    {
        // call: p21c2eb74.<init>
        // call: p835df581.getCurve
        // call: p4760c269.<init>
        // call: p835df581.getN
        // call: p835df581.getH
        // call: p835df581.getG
        // type: p4760c269
        // type: p21c2eb74
        return default!;
    }

    private p4760c269 CreateKeyGenParamsJCE(ECParameterSpec P0, System.Security.Cryptography.RandomNumberGenerator P1)
    {
        // call: p4760c269.<init>
        // call: pde667cd0$p3fd6b696.createKeyGenParamsJCE
        // call: p698f972d.getName
        // call: ECParameterSpec.getOrder
        // call: ECParameterSpec.getCurve
        // call: pf1040019.m2ace2977
        // call: p21c2eb74.<init>
        // call: System.Numerics.BigInteger.valueOf
        // call: pf1040019.maa4c417b
        // call: p1fb7a8a1.m0daa78aa
        // call: ECParameterSpec.getGenerator
        // call: ECParameterSpec.getCofactor
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pde667cd0$p3fd6b696.fccd10663
        // type: p21c2eb74
        // type: p4760c269
        return default!;
    }

    private p4760c269 CreateKeyGenParamsJCE(p35e46fcb P0, System.Security.Cryptography.RandomNumberGenerator P1)
    {
        // call: p35e46fcb.getN
        // call: p35e46fcb.getCurve
        // call: p4760c269.<init>
        // call: p21c2eb74.<init>
        // call: p35e46fcb.getG
        // call: p35e46fcb.getH
        // type: p21c2eb74
        // type: p4760c269
        return default!;
    }

    public KeyPair GenerateKeyPair()
    {
        // call: p3ecd70d1.<init>
        // call: KeyPair.<init>
        // call: pd255ec94.getPrivate
        // call: paa3726ec.<init>
        // call: pde667cd0$p3fd6b696.initialize
        // call: p2c69f81a.generateKeyPair
        // call: System.Security.Cryptography.RandomNumberGenerator.<init>
        // call: pd255ec94.getPublic
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pde667cd0$p3fd6b696.fccd10663
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pde667cd0$p3fd6b696.fed469618
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pde667cd0$p3fd6b696.f918b1e00
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pde667cd0$p3fd6b696.fdb1687e1
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pde667cd0$p3fd6b696.f5177790a
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pde667cd0$p3fd6b696.fad1943a9
        // type: p3ecd70d1
        // type: paa3726ec
        // type: KeyPair
        // type: System.Security.Cryptography.RandomNumberGenerator
        return default!;
    }

    public void Initialize(int P0, System.Security.Cryptography.RandomNumberGenerator P1)
    {
        // str: "key size not configurable."
        // str: "unknown key size."
        // call: pde667cd0$p3fd6b696.initialize
        // call: InvalidParameterException.<init>
        // call: Hashtable.get
        // call: pf74464bf.m1adac6f4
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pde667cd0$p3fd6b696.f07b46124
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pde667cd0$p3fd6b696.f7ddf32e1
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pde667cd0$p3fd6b696.f5177790a
        // type: InvalidParameterException
    }

    public void Initialize(AlgorithmParameterSpec P0, System.Security.Cryptography.RandomNumberGenerator P1)
    {
        // str: "null parameter passed but no implicitCA set"
        // str: "invalid parameterSpec: "
        // call: p37c4833e.m18495958
        // call: InvalidAlgorithmParameterException.<init>
        // call: StringBuilder.<init>
        // call: pde667cd0$p3fd6b696.initializeNamedCurve
        // call: p2c69f81a.init
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: pde667cd0$p3fd6b696.createKeyGenParamsBC
        // call: pfe41e66b.getEcImplicitlyCa
        // call: p1164d587.getName
        // call: pde667cd0$p3fd6b696.createKeyGenParamsJCE
        // call: ECGenParameterSpec.getName
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pde667cd0$p3fd6b696.fdb1687e1
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pde667cd0$p3fd6b696.f918b1e00
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pde667cd0$p3fd6b696.feca07335
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pde667cd0$p3fd6b696.fad1943a9
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pde667cd0$p3fd6b696.fccd10663
        // type: InvalidAlgorithmParameterException
        // type: StringBuilder
    }

    private void InitializeNamedCurve(string P0, System.Security.Cryptography.RandomNumberGenerator P1)
    {
        // str: "unknown curve name: "
        // call: pde667cd0$p3fd6b696.createKeyGenParamsJCE
        // call: StringBuilder.<init>
        // call: p1fb7a8a1.m0daa78aa
        // call: StringBuilder.toString
        // call: p35e46fcb.getH
        // call: p35e46fcb.getN
        // call: p35e46fcb.getCurve
        // call: p35e46fcb.getG
        // call: StringBuilder.append
        // call: InvalidAlgorithmParameterException.<init>
        // call: p698f972d.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pde667cd0$p3fd6b696.fccd10663
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pde667cd0$p3fd6b696.f918b1e00
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pde667cd0$p3fd6b696.feca07335
        // type: p698f972d
        // type: InvalidAlgorithmParameterException
        // type: StringBuilder
    }

}
