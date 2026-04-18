namespace WillowMaze.Wasm.Decompiled;

public class Pcb624497 : P5f014d83
{
    private static System.Numerics.BigInteger F1400a9d8;
    private static System.Numerics.BigInteger F2de6f6ac;
    private static System.Numerics.BigInteger F304e5d8d;
    private static System.Numerics.BigInteger F38aef064;
    private static System.Numerics.BigInteger F529e9e0b;
    private static System.Numerics.BigInteger Fa17c5136;
    private static System.Numerics.BigInteger Fbc21e648;
    private static System.Numerics.BigInteger Fbeda3e18;
    private static System.Numerics.BigInteger Ffc19dbb6;
    private System.Security.Cryptography.RandomNumberGenerator F0e586840;
    private p07d32999 F168e7cba;
    private p753eae39 F1dd9bd32;
    private p753eae39 F3c6e0b8a;
    private p07d32999 F3ed57fcc;
    private p07d32999 F55768cb3;
    private System.Security.Cryptography.RandomNumberGenerator F577c2406;
    private p07d32999 Fce04c9ad;

    public pc9ef6b45 Decrypt(byte[] P0, int P1)
    {
        // call: pcb624497.decrypt
        return default!;
    }

    public pc9ef6b45 Decrypt(byte[] P0, int P1, int P2, int P3)
    {
        // str: "Private key required for decryption"
        // call: System.arraycopy
        // call: p753eae39.getModulus
        // call: IllegalArgumentException.<init>
        // call: System.Numerics.BigInteger.modPow
        // call: System.Numerics.BigInteger.<init>
        // call: p753eae39.getExponent
        // call: p753eae39.isPrivate
        // call: pcb624497.generateKey
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0d2c7316.pcb624497.f3c6e0b8a
        // type: IllegalArgumentException
        // type: System.Numerics.BigInteger
        return default!;
    }

    public pc9ef6b45 Encrypt(byte[] P0, int P1)
    {
        // call: pcb624497.encrypt
        return default!;
    }

    public pc9ef6b45 Encrypt(byte[] P0, int P1, int P2)
    {
        // str: "Public key required for encryption"
        // call: p68e35a3f.mec6269b9
        // call: System.Numerics.BigInteger.modPow
        // call: System.arraycopy
        // call: p753eae39.isPrivate
        // call: System.Numerics.BigInteger.subtract
        // call: p753eae39.getModulus
        // call: p753eae39.getExponent
        // call: System.Numerics.BigInteger.bitLength
        // call: pcb624497.generateKey
        // call: IllegalArgumentException.<init>
        // call: p68e35a3f.m812c2a1c
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0d2c7316.pcb624497.f3c6e0b8a
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0d2c7316.pcb624497.fbc21e648
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0d2c7316.pcb624497.f529e9e0b
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0d2c7316.pcb624497.f577c2406
        // type: IllegalArgumentException
        return default!;
    }

    private p94919be6 GenerateKey(System.Numerics.BigInteger P0, System.Numerics.BigInteger P1, int P2)
    {
        // call: p07d32999.generateBytes
        // call: p07d32999.init
        // call: System.Numerics.BigInteger.bitLength
        // call: pc03b0fe3.<init>
        // call: p68e35a3f.mec6269b9
        // call: p94919be6.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0d2c7316.pcb624497.f168e7cba
        // type: p94919be6
        // type: pc03b0fe3
        return default!;
    }

    public void Init(pc9ef6b45 P0)
    {
        // str: "RSA key required"
        // call: IllegalArgumentException.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0d2c7316.pcb624497.f3c6e0b8a
        // type: IllegalArgumentException
    }

}
