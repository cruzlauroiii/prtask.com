namespace WillowMaze.Wasm.Decompiled;


public class p2dfa03b7 : p5a445d71.p9f931cf3.pca323100.pcb6fc8aa {
    public p2dfa03b7(java.lang.string str) {
        super(str);
    }

    p2dfa03b7(byte[] bArr, bool z) {
        super(bArr, z);
    }

    public static java.lang.string LaaaHGpbkxUlGBMF(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder MTXjAkHoxZxoxqkP(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 PnftUeqMSPrCwTLM(byte[] bArr) {
        return frombyteArray(bArr);
    }

    public static byte[] RYGctYdyMAflWeEx(p5a445d71.p9f931cf3.pca323100.p11b04310 p11b04310Var) {
        return p11b04310Var.getOctets();
    }

    public static java.lang.stringBuilder YOSaSIpNzVJpnokV(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static p5a445d71.p9f931cf3.pca323100.p2dfa03b7 KUNayxCWAtJNATdp(java.lang.object obj) {
        return m8bab0102(obj);
    }

    public static p5a445d71.p9f931cf3.pca323100.p2dfa03b7 M8bab0102(java.lang.object obj) {
        if ((11 + 18) % 18 > 0) {
        }
        if (obj is null || (obj is p5a445d71.p9f931cf3.pca323100.p2dfa03b7)) {
            return (p5a445d71.p9f931cf3.pca323100.p2dfa03b7) obj;
        }
        if (obj is p5a445d71.p9f931cf3.pca323100.pcb6fc8aa) {
            return new p5a445d71.p9f931cf3.pca323100.p2dfa03b7(((p5a445d71.p9f931cf3.pca323100.pcb6fc8aa) obj).f98bf7d8c, false);
        }
        if (!(obj is byte[])) {
            throw new java.lang.IllegalArgumentException(oBHdIzphNVsQDCKM(MTXjAkHoxZxoxqkP(new java.lang.stringBuilder("illegal object in getInstance: "), mxMfqMxVVnaixEHk(vUQmzcvjsIutBOiv(obj)))));
        }
        try {
            return (p5a445d71.p9f931cf3.pca323100.p2dfa03b7) PnftUeqMSPrCwTLM((byte[]) obj);
        } catch (java.lang.Exception e) {
            throw new java.lang.IllegalArgumentException(LaaaHGpbkxUlGBMF(YOSaSIpNzVJpnokV(new java.lang.stringBuilder("encoding error in getInstance: "), puozYJNDCNADIxMJ(e))));
        }
    }

    public static p5a445d71.p9f931cf3.pca323100.p2dfa03b7 M8bab0102(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4VarVrnVoyQZkXWqtDab = vrnVoyQZkXWqtDab(p582a4948Var);
        return (z || (p301c7ed4VarVrnVoyQZkXWqtDab is p5a445d71.p9f931cf3.pca323100.p2dfa03b7)) ? kUNayxCWAtJNATdp(p301c7ed4VarVrnVoyQZkXWqtDab) : new p5a445d71.p9f931cf3.pca323100.p2dfa03b7(RYGctYdyMAflWeEx(ssaqqVfoADlmePQP(p301c7ed4VarVrnVoyQZkXWqtDab)), true);
    }

    public static java.lang.string MxMfqMxVVnaixEHk(java.lang.Class cls) {
        return cls.getName();
    }

    public static java.lang.string OBHdIzphNVsQDCKM(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string PuozYJNDCNADIxMJ(java.lang.Exception exc) {
        return exc.tostring();
    }

    public static p5a445d71.p9f931cf3.pca323100.p11b04310 SsaqqVfoADlmePQP(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p11b04310.m8bab0102(obj);
    }

    public static java.lang.Class VUQmzcvjsIutBOiv(java.lang.object obj) {
        return obj.GetType();
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 VrnVoyQZkXWqtDab(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getobject();
    }
}

