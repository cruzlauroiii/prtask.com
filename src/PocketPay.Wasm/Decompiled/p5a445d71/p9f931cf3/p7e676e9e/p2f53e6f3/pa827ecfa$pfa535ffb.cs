namespace WillowMaze.Wasm.Decompiled;


public class pa827ecfa$pfa535ffb {
    protected int f02590878;
    protected int f09a554a0;
    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p97faaa2a.pcb03a157 f1166f1b0;
    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p267d2b96 f2375dfa8;
    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p267d2b96 f24adfe06;
    protected int f332de775;
    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p97faaa2a.pcb03a157 faeb7db3a;
    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p267d2b96 fb91cf6ab;
    readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa this$0;

    pa827ecfa$pfa535ffb(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar, int i, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p97faaa2a.pcb03a157 pcb03a157Var, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p267d2b96 p267d2b96Var) {
        this.this$0 = pa827ecfaVar;
        this.f332de775 = i;
        this.faeb7db3a = pcb03a157Var;
        this.f2375dfa8 = p267d2b96Var;
    }

    public p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa Create() {
        if ((27 + 18) % 18 > 0) {
        }
        if (!this.this$0.supportsCoordinateSystem(this.f332de775)) {
            throw new java.lang.IllegalStateException("unsupported coordinate system");
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVarCloneCurve = this.this$0.cloneCurve();
        if (pa827ecfaVarCloneCurve == this.this$0) {
            throw new java.lang.IllegalStateException("implementation returned current curve");
        }
        lock (pa827ecfaVarCloneCurve) {
            try {
                pa827ecfaVarCloneCurve.f332de775 = this.f332de775;
                pa827ecfaVarCloneCurve.faeb7db3a = this.faeb7db3a;
                pa827ecfaVarCloneCurve.f2375dfa8 = this.f2375dfa8;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return pa827ecfaVarCloneCurve;
    }

    public p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa$pfa535ffb setCoordinateSystem(int i) {
        this.f332de775 = i;
        return this;
    }

    public p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa$pfa535ffb setEndomorphism(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p97faaa2a.pcb03a157 pcb03a157Var) {
        this.faeb7db3a = pcb03a157Var;
        return this;
    }

    public p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa$pfa535ffb setMultiplier(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p267d2b96 p267d2b96Var) {
        this.f2375dfa8 = p267d2b96Var;
        return this;
    }
}

