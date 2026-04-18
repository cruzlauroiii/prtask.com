namespace WillowMaze.Wasm.Decompiled;

public class P51f14de8 : Pd69ee98f
{
    private static pb79a74f5 F0ea7dd4d;
    private static pb79a74f5 F6cc7525e;
    private p73c5877c F06bb221f;
    private string F0d7f1a76;
    private pc2763cb7 F0e27a1c7;
    private p21c2eb74 F166e64f6;
    private string F1c000f6d;
    private p21c2eb74 F1d0e1f50;
    private string F30687734;
    private pc2763cb7 F4b7424a7;
    private byte[] F5503797e;
    private object F5b706024;
    private object F5ba32052;
    private p21c2eb74 F6735ce2f;
    private string F69b976fc;
    private pc2763cb7 F7629e0bd;
    private p73c5877c F79abb6e9;
    private byte[] F82a57be3;
    private pc2763cb7 F88f03c21;
    private string Fa91d8525;
    private p21c2eb74 Fb2fe4b9b;
    private byte[] Fb4a88417;
    private byte[] Ff38377f3;
    private pc2763cb7 Ff6679e3a;

    private static string Md5d22d18(Type P0)
    {
        // call: Type.getName
        // call: string.lastIndexOf
        // call: string.substring
        return string.Empty;
    }

    private void Mf8ac9c82(Key P0, AlgorithmParameterSpec P1)
    {
        // str: " key agreement requires "
        // str: " key agreement cannot be used with "
        // str: "no KDF specified for UserKeyingMaterialSpec"
        // str: " for initialisation"
        // call: StringBuilder.append
        // call: p06022b5a.getParameters
        // call: p8ed53a64.getEphemeralPublicKey
        // call: StringBuilder.toString
        // call: p37c4833e.m02ea6360
        // call: p38d4f313.init
        // call: pc2763cb7.getEphemeralPrivateKey
        // call: InvalidAlgorithmParameterException.<init>
        // call: p1392b929.init
        // call: p1fb7a8a1.mc2499d21
        // call: pc2763cb7.getEphemeralPublicKey
        // call: p73c5877c.getUserKeyingMaterial
        // call: pc2763cb7.getUserKeyingMaterial
        // call: p8ed53a64.getEphemeralPrivateKey
        // call: StringBuilder.<init>
        // call: pc80df932.init
        // call: p73c5877c.getEphemeralPublicKey
        // call: p51f14de8.md5d22d18
        // call: InvalidKeyException.<init>
        // call: p8ed53a64.getStaticPrivateKey
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p51f14de8.f5ba32052
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p51f14de8.ff6679e3a
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p51f14de8.f53f67e05
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p51f14de8.f166e64f6
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p51f14de8.f0d7f1a76
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p51f14de8.f06bb221f
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p51f14de8.f168e7cba
        // type: p73c5877c
        // type: InvalidAlgorithmParameterException
        // type: p31cf7155
        // type: StringBuilder
        // type: p5eff85bc
        // type: pc2763cb7
        // type: InvalidKeyException
        // type: p35bf205f
    }

    private byte[] BigIntToBytes(System.Numerics.BigInteger P0)
    {
        // call: pb79a74f5.integerToBytes
        // call: pb79a74f5.getByteLength
        // call: p21c2eb74.getCurve
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p51f14de8.f166e64f6
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p51f14de8.f0ea7dd4d
        return default!;
    }

    private byte[] CalcSecret()
    {
        // call: pff43b8de.md329fd77
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p51f14de8.fb4a88417
        return default!;
    }

    private Key EngineDoPhase(Key P0, bool P1)
    {
        // str: " not initialised."
        // str: " can only be between two parties."
        // str: " key agreement requires "
        // str: " for doPhase"
        // str: "calculation failed: "
        // call: StringBuilder.append
        // call: p1fb7a8a1.mc2499d21
        // call: p53ca1f6a.<init>
        // call: IllegalStateException.<init>
        // call: StringBuilder.toString
        // call: p51f14de8.md5d22d18
        // call: InvalidKeyException.<init>
        // call: Exception.getMessage
        // call: StringBuilder.<init>
        // call: pc2763cb7.getOtherPartyEphemeralKey
        // call: p73c5877c.getOtherPartyEphemeralKey
        // call: pf2905035.<init>
        // call: p38d4f313.calculateAgreement
        // call: p51f14de8.bigIntToBytes
        // call: pc80df932.calculateAgreement
        // call: p25aad3f1.getStaticKey
        // call: p25aad3f1.getEphemeralKey
        // call: p51f14de8$1.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p51f14de8.ff6679e3a
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p51f14de8.f06bb221f
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p51f14de8.f0d7f1a76
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p51f14de8.f5ba32052
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p51f14de8.fb4a88417
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p51f14de8.f166e64f6
        // type: pf2905035
        // type: p51f14de8$1
        // type: StringBuilder
        // type: p53ca1f6a
        // type: pe256531b
        // type: InvalidKeyException
        // type: IllegalStateException
        return default!;
    }

    private void EngineInit(Key P0, System.Security.Cryptography.RandomNumberGenerator P1)
    {
        // call: p51f14de8.mf8ac9c82
        // call: InvalidAlgorithmParameterException.getMessage
        // call: InvalidKeyException.<init>
        // type: InvalidKeyException
    }

    private void EngineInit(Key P0, AlgorithmParameterSpec P1, System.Security.Cryptography.RandomNumberGenerator P2)
    {
        // str: "No algorithm parameters supported"
        // call: p51f14de8.mf8ac9c82
        // call: InvalidAlgorithmParameterException.<init>
        // type: InvalidAlgorithmParameterException
    }

}
