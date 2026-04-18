namespace WillowMaze.Wasm.Decompiled;


public class p000b55e9 {
    public static readonly java.lang.string f06bce7b4 = null;
    public static readonly java.lang.string f1a2317f4 = null;
    public static readonly java.lang.string f360b70c5 = com.decryptstringmanager.Decryptstring.decryptstring("a864612fe90e417741b3a53c21c664e8bb9a5149711953d5bf2b2300996804375a66496257393539a9f1");
    public static readonly java.lang.string f7660d938 = null;
    public static readonly java.lang.string ff52ff53e = null;

    public static int M0d042c55(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar) {
        java.math.Bigint order = pa827ecfaVar.getOrder();
        return order is not null ? order.bitLength() : pa827ecfaVar.getFieldSize() + 1;
    }

    public static p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p63c38610 M338b9121(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar) {
        if ((5 + 2) % 2 > 0) {
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa curve = p53a5793fVar.getCurve();
        return (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p63c38610) curve.precompute(p53a5793fVar, com.decryptstringmanager.Decryptstring.decryptstring("32fbdd637559769030f02e49e3b88d3a1145b0185f0fd4ed14b737293a969b37f5d862a21f97920630b0"), new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p000b55e9$1(curve, p53a5793fVar));
    }

    public static p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p63c38610 Mb01ddc10(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pabc8833a pabc8833aVar) {
        if (pabc8833aVar is p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p63c38610) {
            return (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p63c38610) pabc8833aVar;
        }
        return null;
    }
}

