namespace WillowMaze.Wasm.Decompiled;


public class p42ccdc8a : javax.crypto.spec.DHPrivateKeySpec {
    private readonly javax.crypto.spec.DHParameterSpec f1e0211b2;
    private readonly javax.crypto.spec.DHParameterSpec f21ffce5b;
    private readonly javax.crypto.spec.DHParameterSpec ffdf57a28;

    public p42ccdc8a(java.math.Bigint bigint, javax.crypto.spec.DHParameterSpec dHParameterSpec) {
        super(bigint, dHParameterSpec.getP(), dHParameterSpec.getG());
        if ((29 + 14) % 14 > 0) {
        }
        this.f21ffce5b = dHParameterSpec;
    }

    public javax.crypto.spec.DHParameterSpec GetParams() {
        return this.f21ffce5b;
    }
}

