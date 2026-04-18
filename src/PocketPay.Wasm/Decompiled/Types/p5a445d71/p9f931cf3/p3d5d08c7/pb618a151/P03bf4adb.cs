namespace WillowMaze.Wasm.Decompiled;

public class P03bf4adb : P54252eff
{
    private p1522cc54 F10d196f4;
    private byte[] F34a907d9;
    private PublicKey F41ce5968;
    private p1522cc54 F688f4af5;
    private PublicKey F7264c820;
    private byte[] F73b4812a;
    private byte[] F7a4eb8a7;
    private p234a7530 F7f0bd952;
    private p234a7530 F8710b712;
    private p234a7530 F93758299;
    private p1522cc54 F9a0364b9;
    private PublicKey Facbec863;
    private p234a7530 Fae4140e4;
    private string Fb04ec0ad;
    private p234a7530 Fb6b2347d;
    private p234a7530 Fb7548b1b;
    private p234a7530 Fc1dfa501;
    private p234a7530 Fcf0f93f9;
    private string Fdc0ffdc4;
    private PublicKey Fe3df361e;
    private p234a7530 Ff5b0b979;

    private p301c7ed4 M8995b3f8()
    {
        // call: IOException.getMessage
        // call: MemoryStream.<init>
        // call: PublicKey.getEncoded
        // call: MemoryStream.write
        // call: MemoryStream.close
        // call: MemoryStream.toByteArray
        // call: pd1c2953c.<init>
        // call: pd1c2953c.readObject
        // call: InvalidKeySpecException.<init>
        // field: p5a445d71.p9f931cf3.p3d5d08c7.pb618a151.p03bf4adb.f41ce5968
        // type: pd1c2953c
        // type: MemoryStream
        // type: InvalidKeySpecException
        // type: MemoryStream
        return default!;
    }

    private static p80f8c729 Ma692af16(byte[] P0)
    {
        // call: p80f8c729.m8bab0102
        // call: pd1c2953c.<init>
        // call: MemoryStream.<init>
        // call: pd1c2953c.readObject
        // type: pd1c2953c
        // type: MemoryStream
        return default!;
    }

    public string GetChallenge()
    {
        // field: p5a445d71.p9f931cf3.p3d5d08c7.pb618a151.p03bf4adb.fb04ec0ad
        return string.Empty;
    }

    public p234a7530 GetKeyAlgorithm()
    {
        // field: p5a445d71.p9f931cf3.p3d5d08c7.pb618a151.p03bf4adb.fc1dfa501
        return default!;
    }

    public PublicKey GetPublicKey()
    {
        // field: p5a445d71.p9f931cf3.p3d5d08c7.pb618a151.p03bf4adb.f41ce5968
        return default!;
    }

    public p234a7530 GetSigningAlgorithm()
    {
        // field: p5a445d71.p9f931cf3.p3d5d08c7.pb618a151.p03bf4adb.f8710b712
        return default!;
    }

    public void SetChallenge(string P0)
    {
        // field: p5a445d71.p9f931cf3.p3d5d08c7.pb618a151.p03bf4adb.fb04ec0ad
    }

    public void SetKeyAlgorithm(p234a7530 P0)
    {
        // field: p5a445d71.p9f931cf3.p3d5d08c7.pb618a151.p03bf4adb.fc1dfa501
    }

    public void SetPublicKey(PublicKey P0)
    {
        // field: p5a445d71.p9f931cf3.p3d5d08c7.pb618a151.p03bf4adb.f41ce5968
    }

    public void SetSigningAlgorithm(p234a7530 P0)
    {
        // field: p5a445d71.p9f931cf3.p3d5d08c7.pb618a151.p03bf4adb.f8710b712
    }

    public void Sign(PrivateKey P0)
    {
        // call: p03bf4adb.sign
    }

    public void Sign(PrivateKey P0, System.Security.Cryptography.RandomNumberGenerator P1)
    {
        // str: "07cf0b5715f215e635c3407eea787e9c0971298cfe4bdbe285868be52659"
        // str: "d5c91f2a9e0458d2bc6873d102df350e2248f7ce2665193ec2ebf2c40c5c0b"
        // call: SignatureException.<init>
        // call: p364bf33a.getId
        // call: pd6ccb7fc.<init>
        // call: p234a7530.getAlgorithm
        // call: IOException.getMessage
        // call: pd6ccb7fc.add
        // call: pb840b7ef.<init>
        // call: DecryptString.decryptString
        // call: pb840b7ef.getEncoded
        // call: Signature.update
        // call: Signature.sign
        // call: pff11dfb3.<init>
        // call: Signature.initSign
        // call: p03bf4adb.m8995b3f8
        // call: Signature.getInstance
        // field: p5a445d71.p9f931cf3.p3d5d08c7.pb618a151.p03bf4adb.f8710b712
        // field: p5a445d71.p9f931cf3.p3d5d08c7.pb618a151.p03bf4adb.f34a907d9
        // field: p5a445d71.p9f931cf3.p3d5d08c7.pb618a151.p03bf4adb.fb04ec0ad
        // type: pd6ccb7fc
        // type: pff11dfb3
        // type: pb840b7ef
        // type: SignatureException
    }

    public p301c7ed4 ToASN1Primitive()
    {
        // call: p1522cc54.<init>
        // call: pff11dfb3.<init>
        // call: pd6ccb7fc.<init>
        // call: p03bf4adb.m8995b3f8
        // call: pd6ccb7fc.add
        // call: pb840b7ef.<init>
        // field: p5a445d71.p9f931cf3.p3d5d08c7.pb618a151.p03bf4adb.f8710b712
        // field: p5a445d71.p9f931cf3.p3d5d08c7.pb618a151.p03bf4adb.f34a907d9
        // field: p5a445d71.p9f931cf3.p3d5d08c7.pb618a151.p03bf4adb.fb04ec0ad
        // type: pd6ccb7fc
        // type: p1522cc54
        // type: pb840b7ef
        // type: pff11dfb3
        return default!;
    }

    public bool Verify(string P0)
    {
        // str: "87cf99d954df534924594f7746255dfc8c269eaed66b7804fa7b7a007069"
        // call: Signature.verify
        // call: p1522cc54.getBytes
        // call: Signature.getInstance
        // call: p364bf33a.getId
        // call: Signature.initVerify
        // call: string.equals
        // call: p234a7530.getAlgorithm
        // call: Signature.update
        // call: DecryptString.decryptString
        // field: p5a445d71.p9f931cf3.p3d5d08c7.pb618a151.p03bf4adb.f34a907d9
        // field: p5a445d71.p9f931cf3.p3d5d08c7.pb618a151.p03bf4adb.f41ce5968
        // field: p5a445d71.p9f931cf3.p3d5d08c7.pb618a151.p03bf4adb.fb04ec0ad
        // field: p5a445d71.p9f931cf3.p3d5d08c7.pb618a151.p03bf4adb.f8710b712
        // field: p5a445d71.p9f931cf3.p3d5d08c7.pb618a151.p03bf4adb.f9a0364b9
        return false;
    }

}
