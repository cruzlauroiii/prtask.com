namespace WillowMaze.Wasm.Decompiled;


class pf83fabfe$p45cf3335$1 : p38cb8f46.pe86e8b35 {
    readonly paa20ed97.pf83fabfe$p45cf3335 this$0;

    pf83fabfe$p45cf3335$1(paa20ed97.pf83fabfe$p45cf3335 pf83fabfe_p45cf3335, p38cb8f46.pf31bbdd1 pf31bbdd1Var) {
        super(pf31bbdd1Var);
        this.this$0 = pf83fabfe_p45cf3335;
    }

    public override long Read(p38cb8f46.p7e62bc34 p7e62bc34Var, long j) throws java.io.IOException {
        try {
            return super.read(p7e62bc34Var, j);
        } catch (java.io.IOException e) {
            this.this$0.f5883c2a0 = e;
            throw e;
        }
    }
}

