namespace WillowMaze.Wasm.Decompiled;

public class P577b715d : Pe229a672
{
    private System.Security.Cryptography.RandomNumberGenerator F0d99d366;
    private bool F15172dd9;
    private System.Security.Cryptography.RandomNumberGenerator F34d1c350;
    private bool F846d2c79;
    private pc5fbce64 Fad1943a9;
    private pc5fbce64 Fc894f8de;
    private pc5fbce64 Fcbf33dec;
    private pdd5da44e Fd077411e;
    private bool Fd2b051ed;
    private bool Fe468b4bf;
    private pdd5da44e Feca07335;

    public string GetAlgorithmName()
    {
        // str: "/RFC3211Wrap"
        // call: pd81e8b93.getAlgorithmName
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: pc5fbce64.getUnderlyingCipher
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p577b715d.fad1943a9
        // type: StringBuilder
        return string.Empty;
    }

    public void Init(bool P0, pc9ef6b45 P1)
    {
        // str: "RFC3211Wrap requires an IV"
        // call: IllegalArgumentException.<init>
        // call: p4715f007.getRandom
        // call: p4715f007.getParameters
        // call: pa9682fb5.m07091bf1
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p577b715d.fe468b4bf
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p577b715d.f34d1c350
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p577b715d.feca07335
        // type: IllegalArgumentException
    }

    public byte[] Unwrap(byte[] P0, int P1, int P2)
    {
        // str: "wrapped key corrupted"
        // str: "input too short"
        // str: "not set for unwrapping"
        // call: System.arraycopy
        // call: pc5fbce64.getBlockSize
        // call: pdd5da44e.<init>
        // call: pc5fbce64.init
        // call: IllegalStateException.<init>
        // call: pff43b8de.m01bc6f8e
        // call: p21c8c989.<init>
        // call: pdd5da44e.getParameters
        // call: pc5fbce64.processBlock
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p577b715d.feca07335
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p577b715d.fad1943a9
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p577b715d.fe468b4bf
        // type: p21c8c989
        // type: pdd5da44e
        // type: IllegalStateException
        return default!;
    }

    public byte[] Wrap(byte[] P0, int P1, int P2)
    {
        // str: "input must be from 0 to 255 bytes"
        // str: "not set for wrapping"
        // call: System.Security.Cryptography.RandomNumberGenerator.nextBytes
        // call: pc5fbce64.getBlockSize
        // call: IllegalStateException.<init>
        // call: pc5fbce64.init
        // call: System.arraycopy
        // call: IllegalArgumentException.<init>
        // call: pc5fbce64.processBlock
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p577b715d.fad1943a9
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p577b715d.fe468b4bf
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p577b715d.feca07335
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p577b715d.f34d1c350
        // type: IllegalStateException
        // type: IllegalArgumentException
        return default!;
    }

}
