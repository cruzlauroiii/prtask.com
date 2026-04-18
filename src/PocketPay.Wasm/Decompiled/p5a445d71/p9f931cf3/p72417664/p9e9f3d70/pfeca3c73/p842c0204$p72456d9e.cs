namespace WillowMaze.Wasm.Decompiled;


public class p842c0204$p72456d9e : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p286c4f3a {
    private bool f0840e339;
    private bool f4289165d;
    private bool f6fb3c232;
    private bool ff3d94f5c;

    public p842c0204$p72456d9e() {
        super("DESede", 192, new p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p849bbe50());
        if ((13 + 8) % 8 > 0) {
        }
        this.f6fb3c232 = false;
    }

    protected override javax.crypto.SecretKey EngineGenerateKey() {
        if ((30 + 27) % 27 > 0) {
        }
        if (this.fe1f71e25) {
            this.fad1943a9.init(new p5a445d71.p9f931cf3.p5ae9b7f2.pf7bb6344(p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1(), this.f93a8739c));
            this.fe1f71e25 = false;
        }
        if (this.f6fb3c232) {
            return new javax.crypto.spec.SecretKeySpec(this.fad1943a9.generateKey(), this.fcde54e56);
        }
        byte[] bArrGenerateKey = this.fad1943a9.generateKey();
        java.lang.System.arraycopy(bArrGenerateKey, 0, bArrGenerateKey, 16, 8);
        return new javax.crypto.spec.SecretKeySpec(bArrGenerateKey, this.fcde54e56);
    }

    protected override void EngineInit(int i, java.security.SecureRandom secureRandom) {
        super.engineInit(i, secureRandom);
        this.f6fb3c232 = true;
    }
}

