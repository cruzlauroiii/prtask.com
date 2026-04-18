namespace WillowMaze.Wasm.Decompiled;

public class P623db1b3 : P52c18907
{
    private static long F66b62830;
    private static int F726954d8;
    private static long Fb27c2019;
    private static int Fb890b593;
    private static long Fd453dd75;
    private static long Fdbe3354e;
    private static long Fea8d3206;
    private byte[] F13811f43;
    private p54466d0a F150e6cfc;
    private long F179d76db;
    private byte[] F192aa941;
    private int F19355e2c;
    private long F1f660b0c;
    private int F28c8731e;
    private byte[] F2e5298ce;
    private byte[] F31ed86f0;
    private p54466d0a F41f4a3d6;
    private p1748c064 F46e97eb4;
    private p1748c064 F4c27bd44;
    private p1748c064 F4df622d7;
    private p1748c064 F50a8247b;
    private byte[] F5229d4e4;
    private p1748c064 F558aa02e;
    private long F78bdcb8c;
    private long F7f098204;
    private long F8c009836;
    private int Fa67b5fe2;
    private p54466d0a Fbff580d7;

    private void M298c3452(byte[] P0)
    {
        // call: p623db1b3.mbb82a6de
    }

    private void Mbb82a6de(byte[] P0, byte P1)
    {
        // call: p1748c064.doFinal
        // call: p1748c064.update
        // call: p1748c064.init
        // call: p94919be6.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p9a2dd7d6.p623db1b3.f46e97eb4
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p9a2dd7d6.p623db1b3.f2e5298ce
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p9a2dd7d6.p623db1b3.f31ed86f0
        // type: p94919be6
    }

    private byte[] Me50610cf()
    {
        // str: "Insufficient entropy provided by entropy source"
        // call: p54466d0a.getEntropy
        // call: IllegalStateException.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p9a2dd7d6.p623db1b3.f19355e2c
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p9a2dd7d6.p623db1b3.f41f4a3d6
        // type: IllegalStateException
        return default!;
    }

    public int Generate(byte[] P0, byte[] P1, bool P2)
    {
        // str: "Number of bits per request limited to 262144"
        // call: p1748c064.doFinal
        // call: p1748c064.update
        // call: System.arraycopy
        // call: IllegalArgumentException.<init>
        // call: p1748c064.init
        // call: p94919be6.<init>
        // call: p623db1b3.m298c3452
        // call: p623db1b3.reseed
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p9a2dd7d6.p623db1b3.f46e97eb4
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p9a2dd7d6.p623db1b3.f31ed86f0
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p9a2dd7d6.p623db1b3.f179d76db
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p9a2dd7d6.p623db1b3.f2e5298ce
        // type: IllegalArgumentException
        // type: p94919be6
        return 0;
    }

    public int GetBlockSize()
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p9a2dd7d6.p623db1b3.f31ed86f0
        return 0;
    }

    public void Reseed(byte[] P0)
    {
        // call: pff43b8de.md844b504
        // call: p623db1b3.m298c3452
        // call: p623db1b3.me50610cf
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p9a2dd7d6.p623db1b3.f179d76db
    }

}
