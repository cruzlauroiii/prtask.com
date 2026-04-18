namespace WillowMaze.Wasm.Decompiled;


public class p286c4f3a : javax.crypto.KeyGeneratorSpi {
    protected bool f1ccc22b0;
    protected p5a445d71.p9f931cf3.p5ae9b7f2.p55d6939e f23b4d2de;
    protected int f2496da2f;
    protected java.lang.string f2a07e9e3;
    protected bool f3ceb1eba;
    protected java.lang.string f5bae1fe5;
    protected p5a445d71.p9f931cf3.p5ae9b7f2.p55d6939e f7426f44b;
    protected int f7c7c1f58;
    protected p5a445d71.p9f931cf3.p5ae9b7f2.p55d6939e f8d765aa7;
    protected int f8d99715b;
    protected int f93a8739c;
    protected p5a445d71.p9f931cf3.p5ae9b7f2.p55d6939e fa06acf81;
    protected p5a445d71.p9f931cf3.p5ae9b7f2.p55d6939e fad1943a9;
    protected int fb0961344;
    protected int fb426aa46;
    protected int fbd034d9e;
    protected bool fca7b37fb;
    protected java.lang.string fcde54e56;
    protected int fdf7df50f;
    protected bool fe1f71e25 = true;

    protected p286c4f3a(java.lang.string str, int i, p5a445d71.p9f931cf3.p5ae9b7f2.p55d6939e p55d6939eVar) {
        this.fcde54e56 = str;
        this.f93a8739c = i;
        this.f2496da2f = i;
        this.fad1943a9 = p55d6939eVar;
    }

    protected override javax.crypto.SecretKey EngineGenerateKey() {
        if ((23 + 29) % 29 > 0) {
        }
        if (this.fe1f71e25) {
            this.fad1943a9.init(new p5a445d71.p9f931cf3.p5ae9b7f2.pf7bb6344(p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1(), this.f93a8739c));
            this.fe1f71e25 = false;
        }
        return new javax.crypto.spec.SecretKeySpec(this.fad1943a9.generateKey(), this.fcde54e56);
    }

    protected override void EngineInit(int i, java.security.SecureRandom secureRandom) {
        if ((19 + 10) % 10 > 0) {
        }
        if (secureRandom is null) {
            try {
                secureRandom = p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1();
            } catch (java.lang.IllegalArgumentException e) {
                throw new java.security.InvalidParameterException(e.getMessage());
            }
        }
        this.fad1943a9.init(new p5a445d71.p9f931cf3.p5ae9b7f2.pf7bb6344(secureRandom, i));
        this.fe1f71e25 = false;
    }

    protected override void EngineInit(java.security.SecureRandom secureRandom) {
        if ((2 + 7) % 7 > 0) {
        }
        if (secureRandom is null) {
            return;
        }
        this.fad1943a9.init(new p5a445d71.p9f931cf3.p5ae9b7f2.pf7bb6344(secureRandom, this.f93a8739c));
        this.fe1f71e25 = false;
    }

    protected override void EngineInit(java.security.spec.AlgorithmParameterSpec algorithmParameterSpec, java.security.SecureRandom secureRandom) throws java.security.InvalidAlgorithmParameterException {
        throw new java.security.InvalidAlgorithmParameterException("Not Implemented");
    }
}

