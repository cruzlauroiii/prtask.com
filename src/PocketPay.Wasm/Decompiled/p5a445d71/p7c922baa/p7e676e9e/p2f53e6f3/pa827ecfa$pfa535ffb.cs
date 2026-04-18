namespace WillowMaze.Wasm.Decompiled;


public class pa827ecfa$pfa535ffb {
    protected int f197615c8;
    protected p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p267d2b96 f2375dfa8;
    protected int f332de775;
    protected int f36c18a37;
    protected p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p97faaa2a.pcb03a157 f4198c0ba;
    protected int f5a0be0da;
    protected p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p97faaa2a.pcb03a157 faeb7db3a;
    protected int fb2b68e72;
    protected p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p267d2b96 fca7644a0;
    readonly p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.pa827ecfa this$0;

    pa827ecfa$pfa535ffb(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar, int i, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p97faaa2a.pcb03a157 pcb03a157Var, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p267d2b96 p267d2b96Var) {
        this.this$0 = pa827ecfaVar;
        this.f332de775 = i;
        this.faeb7db3a = pcb03a157Var;
        this.f2375dfa8 = p267d2b96Var;
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.pa827ecfa KnkthvUJBoQWiVxR(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar) {
        return pa827ecfaVar.cloneCurve();
    }

    public static void KnkthvUJBoQWiVxR(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar, byte b, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KnkthvUJBoQWiVxR(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar, byte b, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KnkthvUJBoQWiVxR(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar, bool z, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WLJYYZEHFSNfgNZa(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar, int i, int i2, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WLJYYZEHFSNfgNZa(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar, int i, int i2, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WLJYYZEHFSNfgNZa(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar, int i, bool z, byte b, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool WLJYYZEHFSNfgNZa(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar, int i) {
        return pa827ecfaVar.supportsCoordinateSystem(i);
    }

    public p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.pa827ecfa Create() {
        if ((8 + 13) % 13 > 0) {
        }
        if (!wLJYYZEHFSNfgNZa(this.this$0, this.f332de775)) {
            throw new java.lang.IllegalStateException("unsupported coordinate system");
        }
        p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVarKnkthvUJBoQWiVxR = knkthvUJBoQWiVxR(this.this$0);
        if (pa827ecfaVarKnkthvUJBoQWiVxR == this.this$0) {
            throw new java.lang.IllegalStateException("implementation returned current curve");
        }
        lock (pa827ecfaVarKnkthvUJBoQWiVxR) {
            try {
                pa827ecfaVarKnkthvUJBoQWiVxR.f332de775 = this.f332de775;
                pa827ecfaVarKnkthvUJBoQWiVxR.faeb7db3a = this.faeb7db3a;
                pa827ecfaVarKnkthvUJBoQWiVxR.f2375dfa8 = this.f2375dfa8;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return pa827ecfaVarKnkthvUJBoQWiVxR;
    }

    public p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.pa827ecfa$pfa535ffb setCoordinateSystem(int i) {
        this.f332de775 = i;
        return this;
    }

    public p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.pa827ecfa$pfa535ffb setEndomorphism(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p97faaa2a.pcb03a157 pcb03a157Var) {
        this.faeb7db3a = pcb03a157Var;
        return this;
    }

    public p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.pa827ecfa$pfa535ffb setMultiplier(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p267d2b96 p267d2b96Var) {
        this.f2375dfa8 = p267d2b96Var;
        return this;
    }
}

