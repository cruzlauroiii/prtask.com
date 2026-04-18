namespace WillowMaze.Wasm.Decompiled;

public class P51f14de8 : Pd69ee98f
{
    private static System.Numerics.BigInteger F0c3405f1;
    private static System.Numerics.BigInteger F0f82d86a;
    private static System.Numerics.BigInteger F1fab1c66;
    private static System.Numerics.BigInteger F9d4e2ebc;
    private static System.Numerics.BigInteger Fa7ef153b;
    private static System.Numerics.BigInteger Fbc21e648;
    private static System.Numerics.BigInteger Fcf92fc60;
    private p73c5877c F06bb221f;
    private System.Numerics.BigInteger F07e05100;
    private readonly pe2d8c23b F10465d73;
    private readonly p38d4f313 F2bc72b0b;
    private System.Numerics.BigInteger F2d6b9982;
    private readonly pe2d8c23b F39218891;
    private readonly p38d4f313 F3ae6fba0;
    private byte[] F5dc264ba;
    private System.Numerics.BigInteger F72814489;
    private System.Numerics.BigInteger F83878c91;
    private pc2763cb7 F8c6223b0;
    private System.Numerics.BigInteger F93e27ff6;
    private byte[] F9d48ddfc;
    private System.Numerics.BigInteger F9dd4e461;
    private System.Numerics.BigInteger Fa055903f;
    private System.Numerics.BigInteger Fb2f5ff47;
    private byte[] Fb4a88417;
    private p73c5877c Fb728c914;
    private byte[] Fbc42457f;
    private readonly p38d4f313 Fbdabf83a;
    private System.Numerics.BigInteger Fca5fe8d5;
    private readonly pe2d8c23b Fd0b1f5e9;
    private System.Numerics.BigInteger Fd1623c44;
    private System.Numerics.BigInteger Fd31bc1cf;
    private System.Numerics.BigInteger Fda72aa6f;
    private p73c5877c Fde7894ab;
    private readonly pe2d8c23b Feafcc14a;
    private readonly pe2d8c23b Feb1b8f5e;
    private pc2763cb7 Ff6679e3a;
    private p73c5877c Ffda14aec;

    private pc9dc4fec M02ea6360(PrivateKey P0)
    {
        // str: "private key not a DHPrivateKey"
        // call: DHParameterSpec.getG
        // call: DHPrivateKey.getX
        // call: InvalidKeyException.<init>
        // call: DHParameterSpec.getL
        // call: DHPrivateKey.getParams
        // call: DHParameterSpec.getP
        // call: p57bb5d9e.engineGetKeyParameters
        // call: pc9dc4fec.<init>
        // call: p4460e12a.<init>
        // type: p4460e12a
        // type: InvalidKeyException
        // type: pc9dc4fec
        return default!;
    }

    private p1bfd3a52 Mc2499d21(PublicKey P0)
    {
        // str: "public key not a DHPublicKey"
        // call: p4460e12a.<init>
        // call: pcb13bc34.engineGetKeyParameters
        // call: pae8d7c13.getDomainParameters
        // call: DHPublicKey.getY
        // call: DHPublicKey.getParams
        // call: DHParameterSpec.getP
        // call: InvalidKeyException.<init>
        // call: DHParameterSpec.getG
        // call: p1bfd3a52.<init>
        // call: DHParameterSpec.getL
        // type: p1bfd3a52
        // type: p4460e12a
        // type: InvalidKeyException
        return default!;
    }

    private byte[] BigIntToBytes(System.Numerics.BigInteger P0)
    {
        // call: System.Numerics.BigInteger.bitLength
        // call: System.arraycopy
        // call: System.Numerics.BigInteger.toByteArray
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.p51f14de8.f83878c91
        return default!;
    }

    private byte[] CalcSecret()
    {
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.p51f14de8.fb4a88417
        return default!;
    }

    private Key EngineDoPhase(Key P0, bool P1)
    {
        // str: "DHKeyAgreement doPhase requires DHPublicKey"
        // str: "Diffie-Hellman not initialised."
        // str: "MQV Diffie-Hellman can use only two key pairs"
        // str: "Invalid DH PublicKey"
        // str: "Shared key can't be 1"
        // str: "unified Diffie-Hellman can use only two key pairs"
        // str: "DHPublicKey not for this KeyAgreement!"
        // call: System.Numerics.BigInteger.equals
        // call: p51f14de8.bigIntToBytes
        // call: pa666112c.<init>
        // call: p51f14de8.mc2499d21
        // call: p1c11fbf7.<init>
        // call: p73c5877c.getOtherPartyEphemeralKey
        // call: InvalidKeyException.<init>
        // call: IllegalStateException.<init>
        // call: DHPublicKey.getParams
        // call: System.Numerics.BigInteger.compareTo
        // call: System.Numerics.BigInteger.subtract
        // call: System.Numerics.BigInteger.modPow
        // call: pc2763cb7.getOtherPartyEphemeralKey
        // call: pcb13bc34.<init>
        // call: pe2d8c23b.calculateAgreement
        // call: DHParameterSpec.getG
        // call: p38d4f313.calculateAgreement
        // call: DHParameterSpec.getP
        // call: DHPublicKey.getY
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.p51f14de8.fbdabf83a
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.p51f14de8.f83878c91
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.p51f14de8.fb4a88417
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.p51f14de8.f06bb221f
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.p51f14de8.fbc21e648
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.p51f14de8.f9dd4e461
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.p51f14de8.fd0b1f5e9
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.p51f14de8.fb2f5ff47
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.p51f14de8.f0f82d86a
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.p51f14de8.ff6679e3a
        // type: InvalidKeyException
        // type: IllegalStateException
        // type: pcb13bc34
        // type: p1c11fbf7
        // type: pa666112c
        return default!;
    }

    private int EngineGenerateSecret(byte[] P0, int P1)
    {
        // str: "Diffie-Hellman not initialised."
        // call: pd69ee98f.engineGenerateSecret
        // call: IllegalStateException.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.p51f14de8.f9dd4e461
        // type: IllegalStateException
        return 0;
    }

    private SecretKey EngineGenerateSecret(string P0)
    {
        // str: "Diffie-Hellman not initialised."
        // str: "TlsPremasterSecret"
        // call: p51f14de8.trimZeroes
        // call: byte[].<init>
        // call: IllegalStateException.<init>
        // call: string.equals
        // call: pd69ee98f.engineGenerateSecret
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.p51f14de8.fb4a88417
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.p51f14de8.f9dd4e461
        // type: IllegalStateException
        // type: byte[]
        return default!;
    }

    private byte[] EngineGenerateSecret()
    {
        // str: "Diffie-Hellman not initialised."
        // call: pd69ee98f.engineGenerateSecret
        // call: IllegalStateException.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.p51f14de8.f9dd4e461
        // type: IllegalStateException
        return default!;
    }

    private void EngineInit(Key P0, System.Security.Cryptography.RandomNumberGenerator P1)
    {
        // str: "DHKeyAgreement requires DHPrivateKey"
        // call: InvalidKeyException.<init>
        // call: p51f14de8.bigIntToBytes
        // call: DHPrivateKey.getParams
        // call: DHParameterSpec.getG
        // call: DHParameterSpec.getP
        // call: DHPrivateKey.getX
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.p51f14de8.f83878c91
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.p51f14de8.f9dd4e461
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.p51f14de8.fb2f5ff47
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.p51f14de8.fb4a88417
        // type: InvalidKeyException
    }

    private void EngineInit(Key P0, AlgorithmParameterSpec P1, System.Security.Cryptography.RandomNumberGenerator P2)
    {
        // str: "DHKeyAgreement requires DHPrivateKey for initialisation"
        // str: "agreement algorithm not MQV based"
        // str: "agreement algorithm not DHU based"
        // str: "DHKeyAgreement only accepts DHParameterSpec"
        // str: "no KDF specified for UserKeyingMaterialSpec"
        // call: DHParameterSpec.getP
        // call: DHParameterSpec.getG
        // call: InvalidAlgorithmParameterException.<init>
        // call: pe2d8c23b.init
        // call: InvalidKeyException.<init>
        // call: p51f14de8.bigIntToBytes
        // call: DHPrivateKey.getX
        // call: p38d4f313.init
        // call: DHPrivateKey.getParams
        // call: p2b44c653.getUserKeyingMaterial
        // call: pfbd59bca.<init>
        // call: pc2763cb7.getEphemeralPublicKey
        // call: p73c5877c.getEphemeralPublicKey
        // call: p51f14de8.mc2499d21
        // call: p51f14de8.m02ea6360
        // call: p251537e4.<init>
        // call: pc2763cb7.getEphemeralPrivateKey
        // call: p73c5877c.getEphemeralPrivateKey
        // call: p73c5877c.getUserKeyingMaterial
        // call: pc2763cb7.getUserKeyingMaterial
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.p51f14de8.f83878c91
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.p51f14de8.fd0b1f5e9
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.p51f14de8.f06bb221f
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.p51f14de8.f168e7cba
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.p51f14de8.f53f67e05
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.p51f14de8.fb2f5ff47
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.p51f14de8.ff6679e3a
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.p51f14de8.fbdabf83a
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.p51f14de8.f9dd4e461
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.p51f14de8.fb4a88417
        // type: InvalidAlgorithmParameterException
        // type: p251537e4
        // type: pfbd59bca
        // type: InvalidKeyException
    }

}
