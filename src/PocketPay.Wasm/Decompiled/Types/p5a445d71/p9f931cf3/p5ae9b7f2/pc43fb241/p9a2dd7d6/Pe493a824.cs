namespace WillowMaze.Wasm.Decompiled;

public class Pe493a824 : P52c18907
{
    private static long F1f80f813;
    private static Hashtable F22a73340;
    private static byte[] F26a5b238;
    private static int F27c913e6;
    private static Hashtable F346dc2b6;
    private static long F4c251450;
    private static int F85fb1c9a;
    private static long Fa8717104;
    private static int Fb890b593;
    private static Hashtable Fbbfe300e;
    private static byte[] Fbc21e648;
    private static int Fdaef5bce;
    private static long Fea8d3206;
    private static long Feb9e0fe5;
    private static byte[] Ff30a93a8;
    private static byte[] Fff742d3f;
    private byte[] F03fb54d1;
    private pe5cfc515 F042b4c42;
    private int F0456c880;
    private long F0c70a78a;
    private long F179d76db;
    private byte[] F18a10280;
    private int F19355e2c;
    private pe5cfc515 F19e2a2da;
    private byte[] F31ed86f0;
    private p54466d0a F326e460e;
    private p54466d0a F41f4a3d6;
    private byte[] F463954a4;
    private int F49104dbc;
    private pe5cfc515 F5de832c0;
    private int F614866c6;
    private p54466d0a F6f14231d;
    private p54466d0a F7f180bf0;
    private int Fa47bb652;
    private long Fa772c84b;
    private int Fb63621a0;
    private int Fce2ccbfa;
    private byte[] Fd2c88e86;
    private byte[] Fd7d2f8d7;
    private byte[] Fdbffb4fb;
    private int Feb2ef5a0;

    private byte[] M0800fc57(byte[] P0)
    {
        // call: pe5cfc515.getDigestSize
        // call: pe493a824.m3c89e51d
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p9a2dd7d6.pe493a824.f5de832c0
        return default!;
    }

    private void M3c89e51d(byte[] P0, byte[] P1)
    {
        // call: pe5cfc515.doFinal
        // call: pe5cfc515.update
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p9a2dd7d6.pe493a824.f5de832c0
    }

    private byte[] M83b9912b(byte[] P0, int P1)
    {
        // call: System.arraycopy
        // call: pe5cfc515.getDigestSize
        // call: pe493a824.mcfef9de9
        // call: pe493a824.m3c89e51d
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p9a2dd7d6.pe493a824.fbc21e648
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p9a2dd7d6.pe493a824.f5de832c0
        return default!;
    }

    private void Mcfef9de9(byte[] P0, byte[] P1)
    {
    }

    private byte[] Me50610cf()
    {
        // str: "Insufficient entropy provided by entropy source"
        // call: p54466d0a.getEntropy
        // call: IllegalStateException.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p9a2dd7d6.pe493a824.f41f4a3d6
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p9a2dd7d6.pe493a824.f19355e2c
        // type: IllegalStateException
        return default!;
    }

    public int Generate(byte[] P0, byte[] P1, bool P2)
    {
        // str: "Number of bits per request limited to 262144"
        // call: pe493a824.reseed
        // call: pe493a824.mcfef9de9
        // call: pe493a824.m83b9912b
        // call: IllegalArgumentException.<init>
        // call: System.arraycopy
        // call: pe493a824.m0800fc57
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p9a2dd7d6.pe493a824.f31ed86f0
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p9a2dd7d6.pe493a824.f179d76db
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p9a2dd7d6.pe493a824.f18a10280
        // type: IllegalArgumentException
        return 0;
    }

    public int GetBlockSize()
    {
        // call: pe5cfc515.getDigestSize
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p9a2dd7d6.pe493a824.f5de832c0
        return 0;
    }

    public void Reseed(byte[] P0)
    {
        // call: pe493a824.me50610cf
        // call: pff43b8de.md844b504
        // call: pa470a233.m87729a3b
        // call: System.arraycopy
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p9a2dd7d6.pe493a824.f5de832c0
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p9a2dd7d6.pe493a824.f31ed86f0
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p9a2dd7d6.pe493a824.fb63621a0
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p9a2dd7d6.pe493a824.f18a10280
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p9a2dd7d6.pe493a824.fbc21e648
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p9a2dd7d6.pe493a824.f179d76db
    }

}
