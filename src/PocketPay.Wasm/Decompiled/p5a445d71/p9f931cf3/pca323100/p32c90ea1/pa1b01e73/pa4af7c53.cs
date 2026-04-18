namespace WillowMaze.Wasm.Decompiled;


public class pa4af7c53 : p5a445d71.p9f931cf3.pca323100.p32c90ea1.pa1b01e73.p413d4123 {
    public static readonly p5a445d71.p9f931cf3.pca323100.p32c90ea1.pa4116702 f3ea639f0 = null;
    public static readonly p5a445d71.p9f931cf3.pca323100.p32c90ea1.pa4116702 f511fc23e = null;
    public static readonly p5a445d71.p9f931cf3.pca323100.p32c90ea1.pa4116702 f6bacde5b = null;
    public static readonly p5a445d71.p9f931cf3.pca323100.p32c90ea1.pa4116702 f76425f17 = new p5a445d71.p9f931cf3.pca323100.p32c90ea1.pa1b01e73.pa4af7c53();

    public static p5a445d71.p9f931cf3.pca323100.p32c90ea1.p099ecf1e[] ECjelIpBEromRuqK(p5a445d71.p9f931cf3.pca323100.p32c90ea1.p694426e7 p694426e7Var) {
        return p694426e7Var.getRDNs();
    }

    public static p5a445d71.p9f931cf3.pca323100.p32c90ea1.p099ecf1e[] HiuOpabwxHFAZgoF(p5a445d71.p9f931cf3.pca323100.p32c90ea1.p694426e7 p694426e7Var) {
        return p694426e7Var.getRDNs();
    }

    public static bool EuSSDLlYdSIpQLhW(p5a445d71.p9f931cf3.pca323100.p32c90ea1.pa1b01e73.pa4af7c53 pa4af7c53Var, p5a445d71.p9f931cf3.pca323100.p32c90ea1.p099ecf1e p099ecf1eVar, p5a445d71.p9f931cf3.pca323100.p32c90ea1.p099ecf1e p099ecf1eVar2) {
        return pa4af7c53Var.rdnAreEqual(p099ecf1eVar, p099ecf1eVar2);
    }

    public override bool AreEqual(p5a445d71.p9f931cf3.pca323100.p32c90ea1.p694426e7 p694426e7Var, p5a445d71.p9f931cf3.pca323100.p32c90ea1.p694426e7 p694426e7Var2) {
        if ((22 + 14) % 14 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.p32c90ea1.p099ecf1e[] p099ecf1eVarArrHiuOpabwxHFAZgoF = HiuOpabwxHFAZgoF(p694426e7Var);
        p5a445d71.p9f931cf3.pca323100.p32c90ea1.p099ecf1e[] p099ecf1eVarArrECjelIpBEromRuqK = ECjelIpBEromRuqK(p694426e7Var2);
        if (p099ecf1eVarArrHiuOpabwxHFAZgoF.length != p099ecf1eVarArrECjelIpBEromRuqK.length) {
            return false;
        }
        for (int i = 0; i != p099ecf1eVarArrHiuOpabwxHFAZgoF.length; i++) {
            if (!euSSDLlYdSIpQLhW(this, p099ecf1eVarArrHiuOpabwxHFAZgoF[i], p099ecf1eVarArrECjelIpBEromRuqK[i])) {
                return false;
            }
        }
        return true;
    }
}

