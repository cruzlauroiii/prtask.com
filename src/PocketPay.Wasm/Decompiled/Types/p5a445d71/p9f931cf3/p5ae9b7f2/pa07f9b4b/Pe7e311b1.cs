namespace WillowMaze.Wasm.Decompiled;

public class Pe7e311b1 : Pe229a672
{
    private static byte[] F030f7c07;
    private static byte[] F1a53e224;
    private static byte[] F8bdfe9c3;
    private static byte[] Ff7c15d48;
    private pc9ef6b45 F018eb9d3;
    private bool F04a9fe9f;
    private byte[] F1e17fbad;
    private pdd5da44e F23de76ff;
    private byte[] F2a97a874;
    private pc5fbce64 F2f42ea04;
    private System.Security.Cryptography.RandomNumberGenerator F3876accb;
    private System.Security.Cryptography.RandomNumberGenerator F3aa851b8;
    private byte[] F3d252b0c;
    private byte[] F479a5a2d;
    private System.Security.Cryptography.RandomNumberGenerator F5c57d27e;
    private pe5cfc515 F74a89174;
    private pdd5da44e F87f98737;
    private pdd5da44e F89c5b6fa;
    private pdd5da44e Fa595955f;
    private pc5fbce64 Fad1943a9;
    private System.Security.Cryptography.RandomNumberGenerator Fae48b02d;
    private byte[] Fb88e2955;
    private pdd5da44e Fbd39beaa;
    private byte[] Fc10f7796;
    private System.Security.Cryptography.RandomNumberGenerator Fe22428cc;
    private bool Fe468b4bf;
    private pc9ef6b45 Feca07335;
    private byte[] Ff0b53b2d;
    private pe5cfc515 Ff70833fb;
    private pe5cfc515 Ffe5ee75f;

    private byte[] M1ca5bbe5(byte[] P0)
    {
        // call: pe5cfc515.update
        // call: System.arraycopy
        // call: pe5cfc515.doFinal
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pe7e311b1.f74a89174
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pe7e311b1.fc10f7796
        return default!;
    }

    private bool M6176f29d(byte[] P0, byte[] P1)
    {
        // call: pe7e311b1.m1ca5bbe5
        // call: pff43b8de.m66e765de
        return false;
    }

    public string GetAlgorithmName()
    {
        // str: "RC2"
        return string.Empty;
    }

    public void Init(bool P0, pc9ef6b45 P1)
    {
        // str: "IV is not 8 octets"
        // str: "You should not supply an IV for unwrapping"
        // call: p4715f007.getRandom
        // call: p766d1ff5.<init>
        // call: pdd5da44e.<init>
        // call: p4715f007.getParameters
        // call: pdd5da44e.getIV
        // call: System.Security.Cryptography.RandomNumberGenerator.nextBytes
        // call: pdd5da44e.getParameters
        // call: pa9682fb5.m07091bf1
        // call: IllegalArgumentException.<init>
        // call: pc5fbce64.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pe7e311b1.fe22428cc
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pe7e311b1.f89c5b6fa
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pe7e311b1.fad1943a9
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pe7e311b1.ff0b53b2d
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pe7e311b1.feca07335
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pe7e311b1.fe468b4bf
        // type: p766d1ff5
        // type: pdd5da44e
        // type: pc5fbce64
        // type: IllegalArgumentException
    }

    public byte[] Unwrap(byte[] P0, int P1, int P2)
    {
        // str: "Ciphertext not multiple of "
        // str: "Checksum inside ciphertext is corrupted"
        // str: "too many pad bytes ("
        // str: "Null pointer as ciphertext"
        // str: ")"
        // str: "Not set for unwrapping"
        // call: StringBuilder.append
        // call: System.arraycopy
        // call: pc5fbce64.processBlock
        // call: pc5fbce64.getBlockSize
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // call: pdd5da44e.<init>
        // call: pe7e311b1.m6176f29d
        // call: p21c8c989.<init>
        // call: IllegalStateException.<init>
        // call: pc5fbce64.init
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pe7e311b1.ff0b53b2d
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pe7e311b1.fad1943a9
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pe7e311b1.feca07335
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pe7e311b1.f89c5b6fa
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pe7e311b1.fe468b4bf
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pe7e311b1.f1a53e224
        // type: p21c8c989
        // type: StringBuilder
        // type: pdd5da44e
        // type: IllegalStateException
        return default!;
    }

    public byte[] Wrap(byte[] P0, int P1, int P2)
    {
        // str: "Not initialized for wrapping"
        // str: "Not multiple of block length"
        // call: pc5fbce64.getBlockSize
        // call: IllegalStateException.<init>
        // call: System.arraycopy
        // call: pe7e311b1.m1ca5bbe5
        // call: pdd5da44e.<init>
        // call: pc5fbce64.init
        // call: System.Security.Cryptography.RandomNumberGenerator.nextBytes
        // call: pc5fbce64.processBlock
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pe7e311b1.f1a53e224
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pe7e311b1.fad1943a9
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pe7e311b1.f89c5b6fa
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pe7e311b1.feca07335
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pe7e311b1.fe22428cc
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pe7e311b1.fe468b4bf
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pe7e311b1.ff0b53b2d
        // type: pdd5da44e
        // type: IllegalStateException
        return default!;
    }

}
