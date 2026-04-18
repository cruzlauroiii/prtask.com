namespace WillowMaze.Wasm.Decompiled;


public class p301086b5 : java.security.spec.AlgorithmParameterSpec {
    private readonly p5a445d71.p9f931cf3.pccb008a9.p72417664.pb979c293.p4c14e76d[] fa08ecec2;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p72417664.pb979c293.p4c14e76d[] faf6fc857;

    public p301086b5(p5a445d71.p9f931cf3.pccb008a9.p72417664.pb979c293.p4c14e76d... p4c14e76dVarArr) {
        if (p4c14e76dVarArr.length == 0) {
            throw new java.lang.IllegalArgumentException("at least one LMSKeyGenParameterSpec required");
        }
        this.fa08ecec2 = (p5a445d71.p9f931cf3.pccb008a9.p72417664.pb979c293.p4c14e76d[]) p4c14e76dVarArr.clone();
    }

    public p5a445d71.p9f931cf3.pccb008a9.p72417664.pb979c293.p4c14e76d[] GetLMSSpecs() {
        return (p5a445d71.p9f931cf3.pccb008a9.p72417664.pb979c293.p4c14e76d[]) this.fa08ecec2.clone();
    }
}

