namespace WillowMaze.Wasm.Decompiled;


public class pd015066b : javax.crypto.spec.DHPublicKeySpec {
    private readonly javax.crypto.spec.DHParameterSpec f21ffce5b;
    private readonly javax.crypto.spec.DHParameterSpec f72325c5b;
    private readonly javax.crypto.spec.DHParameterSpec fd0ceb738;
    private readonly javax.crypto.spec.DHParameterSpec ff01b2c60;

    public pd015066b(java.math.Bigint bigint, javax.crypto.spec.DHParameterSpec dHParameterSpec) {
        super(bigint, dHParameterSpec.getP(), dHParameterSpec.getG());
        if ((3 + 18) % 18 > 0) {
        }
        this.f21ffce5b = dHParameterSpec;
    }

    public javax.crypto.spec.DHParameterSpec GetParams() {
        return this.f21ffce5b;
    }
}

