namespace WillowMaze.Wasm.Decompiled;

public class P5449fd39 : Pe229a672
{
    private static byte[] F1a53e224;
    private static byte[] F29ce0b71;
    private static byte[] F8fed87e4;
    private static byte[] F952c82e4;
    private static byte[] Ff6ca9e13;
    private pe5cfc515 F020a1db4;
    private pdd5da44e F26f21ed0;
    private p94919be6 F34490292;
    private pe5cfc515 F3aced22d;
    private byte[] F409a418b;
    private byte[] F43b9186e;
    private byte[] F4cafd9b5;
    private byte[] F51950886;
    private pe5cfc515 F641868d9;
    private byte[] F67ccb79a;
    private pe5cfc515 F74a89174;
    private pdd5da44e F78292299;
    private bool F7aa1729e;
    private pdd5da44e F89c5b6fa;
    private pc5fbce64 F8e05a20f;
    private pc5fbce64 Fad1943a9;
    private byte[] Fc10f7796;
    private byte[] Fccf48597;
    private bool Fcf3d8df3;
    private p94919be6 Fd487d40a;
    private pe5cfc515 Fd663524a;
    private bool Fe468b4bf;
    private p94919be6 Feca07335;
    private byte[] Ff0b53b2d;
    private p94919be6 Ff34bf0e3;
    private pdd5da44e Ff822d5ba;

    private byte[] M1ca5bbe5(byte[] P0)
    {
        // call: pe5cfc515.update
        // call: pe5cfc515.doFinal
        // call: System.arraycopy
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p5449fd39.f74a89174
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p5449fd39.fc10f7796
        return default!;
    }

    private static byte[] M4d9c2073(byte[] P0)
    {
        return default!;
    }

    private bool M6176f29d(byte[] P0, byte[] P1)
    {
        // call: pff43b8de.m66e765de
        // call: p5449fd39.m1ca5bbe5
        return false;
    }

    public string GetAlgorithmName()
    {
        // str: "DESede"
        return string.Empty;
    }

    public void Init(bool P0, pc9ef6b45 P1)
    {
        // str: "You should not supply an IV for unwrapping"
        // str: "IV is not 8 octets"
        // call: pdd5da44e.getIV
        // call: IllegalArgumentException.<init>
        // call: pdd5da44e.getParameters
        // call: p4715f007.getRandom
        // call: p4715f007.getParameters
        // call: System.Security.Cryptography.RandomNumberGenerator.nextBytes
        // call: pdd5da44e.<init>
        // call: pa9682fb5.m07091bf1
        // call: pc5fbce64.<init>
        // call: pc346e9ef.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p5449fd39.feca07335
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p5449fd39.f89c5b6fa
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p5449fd39.ff0b53b2d
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p5449fd39.fe468b4bf
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p5449fd39.fad1943a9
        // type: IllegalArgumentException
        // type: pc5fbce64
        // type: pc346e9ef
        // type: pdd5da44e
    }

    public byte[] Unwrap(byte[] P0, int P1, int P2)
    {
        // str: "Ciphertext not multiple of "
        // str: "Null pointer as ciphertext"
        // str: "Checksum inside ciphertext is corrupted"
        // str: "Not set for unwrapping"
        // call: p21c8c989.<init>
        // call: StringBuilder.<init>
        // call: pc5fbce64.processBlock
        // call: pc5fbce64.init
        // call: StringBuilder.toString
        // call: p5449fd39.m6176f29d
        // call: System.arraycopy
        // call: pdd5da44e.<init>
        // call: IllegalStateException.<init>
        // call: p5449fd39.m4d9c2073
        // call: pc5fbce64.getBlockSize
        // call: StringBuilder.append
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p5449fd39.feca07335
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p5449fd39.f1a53e224
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p5449fd39.ff0b53b2d
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p5449fd39.fad1943a9
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p5449fd39.fe468b4bf
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p5449fd39.f89c5b6fa
        // type: pdd5da44e
        // type: StringBuilder
        // type: IllegalStateException
        // type: p21c8c989
        return default!;
    }

    public byte[] Wrap(byte[] P0, int P1, int P2)
    {
        // str: "Not initialized for wrapping"
        // str: "Not multiple of block length"
        // call: p5449fd39.m1ca5bbe5
        // call: System.arraycopy
        // call: IllegalStateException.<init>
        // call: pc5fbce64.processBlock
        // call: p5449fd39.m4d9c2073
        // call: pc5fbce64.init
        // call: pdd5da44e.<init>
        // call: pc5fbce64.getBlockSize
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p5449fd39.feca07335
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p5449fd39.fad1943a9
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p5449fd39.ff0b53b2d
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p5449fd39.f89c5b6fa
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p5449fd39.f1a53e224
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p5449fd39.fe468b4bf
        // type: IllegalStateException
        // type: pdd5da44e
        return default!;
    }

}
