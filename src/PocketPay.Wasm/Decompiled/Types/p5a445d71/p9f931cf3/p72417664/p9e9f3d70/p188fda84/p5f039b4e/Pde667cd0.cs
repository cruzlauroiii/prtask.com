namespace WillowMaze.Wasm.Decompiled;

public class Pde667cd0 : KeyPairGenerator
{
    private static Hashtable F21ffce5b;
    private static object F38878df7;
    private static object F3b236df5;
    private static object Fa1d7a7f3;
    private static Hashtable Fa6117409;
    private static object Fd134470b;
    private static object Fdce7c417;
    private pc97cd309 F12da1a7a;
    private bool F1b17d120;
    private p1e1fa682 F28d53022;
    private bool F402b3012;
    private int F4ccf0264;
    private int F5177790a;
    private p1e1fa682 F5ab977dc;
    private bool F647b6dc5;
    private System.Security.Cryptography.RandomNumberGenerator F7ddf32e1;
    private System.Security.Cryptography.RandomNumberGenerator F86020eba;
    private System.Security.Cryptography.RandomNumberGenerator F89547c29;
    private p1e1fa682 Fad1943a9;
    private p1e1fa682 Fb3915154;
    private int Fc6086e4c;
    private p1e1fa682 Fcbde7de8;
    private bool Fdb1687e1;
    private pc97cd309 Fdb7298e4;
    private int Fdddd6846;
    private System.Security.Cryptography.RandomNumberGenerator Feab574c6;
    private pc97cd309 Feca07335;

    public KeyPair GenerateKeyPair()
    {
        // str: "org.bouncycastle.dsa.FIPS186-2for1024bits"
        // call: Hashtable.get
        // call: Hashtable.containsKey
        // call: pe65dc874.m7702ab0e
        // call: p47a1abc0.<init>
        // call: p9fc2d28c.mf2b2f421
        // call: p47a1abc0.init
        // call: peccdefbd.<init>
        // call: p08716e2c.<init>
        // call: p47a1abc0.generateParameters
        // call: pc97cd309.<init>
        // call: Hashtable.put
        // call: KeyPair.<init>
        // call: pf74464bf.m1adac6f4
        // call: pd255ec94.getPrivate
        // call: p84e9a1d3.<init>
        // call: p8ffa3299.<init>
        // call: p1e1fa682.generateKeyPair
        // call: p1e1fa682.init
        // call: pd255ec94.getPublic
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.pde667cd0.fdb1687e1
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.pde667cd0.f21ffce5b
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.pde667cd0.feca07335
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.pde667cd0.f5177790a
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.pde667cd0.f7ddf32e1
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.pde667cd0.fad1943a9
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.pde667cd0.fdce7c417
        // type: p47a1abc0
        // type: peccdefbd
        // type: p08716e2c
        // type: pc97cd309
        // type: KeyPair
        // type: p8ffa3299
        // type: p84e9a1d3
        return default!;
    }

    public void Initialize(int P0, System.Security.Cryptography.RandomNumberGenerator P1)
    {
        // str: "strength must be from 512 - 4096 and a multiple of 1024 above 1024"
        // call: pc97cd309.<init>
        // call: pe0946edd.<init>
        // call: DSAParameterSpec.getP
        // call: p1e1fa682.init
        // call: InvalidParameterException.<init>
        // call: DSAParameterSpec.getG
        // call: pfe41e66b.getDSADefaultParameters
        // call: DSAParameterSpec.getQ
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.pde667cd0.fad1943a9
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.pde667cd0.feca07335
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.pde667cd0.fdb1687e1
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63d19d11.fd08e68ea
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.pde667cd0.f7ddf32e1
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.pde667cd0.f5177790a
        // type: pe0946edd
        // type: InvalidParameterException
        // type: pc97cd309
    }

    public void Initialize(AlgorithmParameterSpec P0, System.Security.Cryptography.RandomNumberGenerator P1)
    {
        // str: "parameter object not a DSAParameterSpec"
        // call: DSAParameterSpec.getP
        // call: pe0946edd.<init>
        // call: InvalidAlgorithmParameterException.<init>
        // call: pc97cd309.<init>
        // call: DSAParameterSpec.getG
        // call: DSAParameterSpec.getQ
        // call: p1e1fa682.init
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.pde667cd0.fad1943a9
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.pde667cd0.fdb1687e1
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.pde667cd0.feca07335
        // type: InvalidAlgorithmParameterException
        // type: pc97cd309
        // type: pe0946edd
    }

}
