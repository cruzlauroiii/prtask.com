namespace WillowMaze.Wasm.Decompiled;


public class pd9800f2e : p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p75fb81d2 {
    private readonly bool f18524cdc;
    private readonly java.security.SecureRandom f1f80eb0c;
    private readonly java.security.SecureRandom f3fc865b5;
    private readonly java.security.SecureRandom f5c578ebe;
    private readonly java.security.SecureRandom fab152b74 = new java.security.SecureRandom();
    private readonly bool fc24f42ea;
    private readonly java.security.SecureRandom ff26b887f;

    public pd9800f2e(bool z) {
        this.f18524cdc = z;
    }

    static bool Mf23e8626(p5a445d71.p9f931cf3.p05c7e247.p098f6bcd.pd9800f2e pd9800f2eVar) {
        return pd9800f2eVar.f18524cdc;
    }

    static java.security.SecureRandom Mf8f67da7(p5a445d71.p9f931cf3.p05c7e247.p098f6bcd.pd9800f2e pd9800f2eVar) {
        return pd9800f2eVar.fab152b74;
    }

    public override p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p54466d0a Get(int i) {
        return new p5a445d71.p9f931cf3.p05c7e247.p098f6bcd.pd9800f2e$1(this, i);
    }
}

