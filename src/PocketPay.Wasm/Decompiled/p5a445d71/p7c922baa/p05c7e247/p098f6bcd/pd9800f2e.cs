namespace WillowMaze.Wasm.Decompiled;


public class pd9800f2e : p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p75fb81d2 {
    private readonly java.security.SecureRandom f0605226d;
    private readonly bool f18524cdc;
    private readonly java.security.SecureRandom f18c8c175;
    private readonly bool f5eb66bf7;
    private readonly java.security.SecureRandom f820cfd0f;
    private readonly bool f8cddf5dd;
    private readonly java.security.SecureRandom fab152b74 = new java.security.SecureRandom();
    private readonly bool ffee34006;

    public pd9800f2e(bool z) {
        this.f18524cdc = z;
    }

    static bool Mf23e8626(p5a445d71.p7c922baa.p05c7e247.p098f6bcd.pd9800f2e pd9800f2eVar) {
        return pd9800f2eVar.f18524cdc;
    }

    static java.security.SecureRandom Mf8f67da7(p5a445d71.p7c922baa.p05c7e247.p098f6bcd.pd9800f2e pd9800f2eVar) {
        return pd9800f2eVar.fab152b74;
    }

    public override p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p54466d0a Get(int i) {
        return new p5a445d71.p7c922baa.p05c7e247.p098f6bcd.pd9800f2e$1(this, i);
    }
}

