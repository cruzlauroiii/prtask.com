namespace WillowMaze.Wasm.Decompiled;


public abstract class pcffc482e : java.security.AlgorithmParameterGeneratorSpi {
    protected java.security.SecureRandom f22e961c9;
    protected int f387de923;
    protected java.security.SecureRandom f7ddf32e1;
    private readonly p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 fc78189be;
    protected int fd035b601;
    private readonly p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 ffde5d67b = new p5a445d71.p9f931cf3.p72417664.p05c7e247.p7ef765a5();
    protected int f5177790a = 1024;

    protected readonly java.security.AlgorithmParameters CreateParametersInstance(java.lang.string str) throws java.security.NoSuchAlgorithmException, java.security.NoSuchProviderException {
        return this.ffde5d67b.createAlgorithmParameters(str);
    }

    protected override void EngineInit(int i, java.security.SecureRandom secureRandom) {
        this.f5177790a = i;
        this.f7ddf32e1 = secureRandom;
    }
}

