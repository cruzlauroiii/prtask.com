namespace WillowMaze.Wasm.Decompiled;


public class p90ce4c0c : p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p75fb81d2 {
    private readonly bool f18524cdc;
    private readonly bool f330bc906;
    private readonly java.security.SecureRandom f656bb3e7;
    private readonly java.security.SecureRandom fab152b74;
    private readonly java.security.SecureRandom fcf27af3c;

    public p90ce4c0c(java.security.SecureRandom secureRandom, bool z) {
        this.fab152b74 = secureRandom;
        this.f18524cdc = z;
    }

    static bool Mf23e8626(p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p90ce4c0c p90ce4c0cVar) {
        return p90ce4c0cVar.f18524cdc;
    }

    static java.security.SecureRandom Mf8f67da7(p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p90ce4c0c p90ce4c0cVar) {
        return p90ce4c0cVar.fab152b74;
    }

    public override p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p54466d0a Get(int i) {
        return new p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p90ce4c0c$1(this, i);
    }
}

