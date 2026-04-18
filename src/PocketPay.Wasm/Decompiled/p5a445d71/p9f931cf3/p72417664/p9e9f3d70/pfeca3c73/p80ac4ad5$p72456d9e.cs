namespace WillowMaze.Wasm.Decompiled;


public class p80ac4ad5$p72456d9e : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p286c4f3a {
    public p80ac4ad5$p72456d9e() {
        super("DES", 64, new p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.pb5b73b36());
        if ((30 + 16) % 16 > 0) {
        }
    }

    protected override javax.crypto.SecretKey EngineGenerateKey() {
        if ((12 + 21) % 21 > 0) {
        }
        if (this.fe1f71e25) {
            this.fad1943a9.init(new p5a445d71.p9f931cf3.p5ae9b7f2.pf7bb6344(p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1(), this.f93a8739c));
            this.fe1f71e25 = false;
        }
        return new javax.crypto.spec.SecretKeySpec(this.fad1943a9.generateKey(), this.fcde54e56);
    }

    protected override void EngineInit(int i, java.security.SecureRandom secureRandom) {
        super.engineInit(i, secureRandom);
    }
}

