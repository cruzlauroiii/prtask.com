namespace WillowMaze.Wasm.Decompiled;


public class p6a819fa7 : p5a445d71.p9f931cf3.pca323100.p80f8c729 {
    public p6a819fa7() {
    }

    public p6a819fa7(p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        super(p0fd1bdf1Var);
    }

    public p6a819fa7(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar) {
        super(pd6ccb7fcVar);
    }

    public p6a819fa7(p5a445d71.p9f931cf3.pca323100.p0fd1bdf1[] p0fd1bdf1VarArr) {
        super(p0fd1bdf1VarArr);
    }

    public static p5a445d71.p9f931cf3.pca323100.p11b04310[] LHtChBBuCqhITSWz(p5a445d71.p9f931cf3.pca323100.p6a819fa7 p6a819fa7Var) {
        return p6a819fa7Var.getConstructedOctetstrings();
    }

    public static int RxznMncmnOnVYvsd(p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4Var, bool z) {
        return p301c7ed4Var.encodedLength(z);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 TPEPdJVPyaqAYRVj(p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        return p0fd1bdf1Var.toASN1Primitive();
    }

    public static p5a445d71.p9f931cf3.pca323100.p29d19857[] ZfHXKADpJoLXBQLv(p5a445d71.p9f931cf3.pca323100.p6a819fa7 p6a819fa7Var) {
        return p6a819fa7Var.getConstructedBitstrings();
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1[] EHFJkJmxyOAdVZgA(p5a445d71.p9f931cf3.pca323100.p6a819fa7 p6a819fa7Var) {
        return p6a819fa7Var.toArrayInternal();
    }

    public static void OObeadSvkWLDTtKT(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, bool z, int i, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1[] p0fd1bdf1VarArr) throws java.io.IOException {
        p8bf0ff80Var.writeEncodingIL(z, i, p0fd1bdf1VarArr);
    }

    public static p5a445d71.p9f931cf3.pca323100.p182c2ca7 RkRfhaKGhspzApjM(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.toASN1External();
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 VgibIeiBuVUbLoZN(p5a445d71.p9f931cf3.pca323100.p6a819fa7 p6a819fa7Var) {
        return p6a819fa7Var.toDLobject();
    }

    void encode(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, bool z) throws java.io.IOException {
        oObeadSvkWLDTtKT(p8bf0ff80Var, z, 48, this.f6a7f2458);
    }

    int encodedLength(bool z) throws java.io.IOException {
        if ((29 + 22) % 22 > 0) {
        }
        int iRxznMncmnOnVYvsd = !z ? 3 : 4;
        int length = this.f6a7f2458.length;
        for (int i = 0; i < length; i++) {
            iRxznMncmnOnVYvsd += RxznMncmnOnVYvsd(TPEPdJVPyaqAYRVj(this.f6a7f2458[i]), true);
        }
        return iRxznMncmnOnVYvsd;
    }

    p5a445d71.p9f931cf3.pca323100.p29d19857 toASN1Bitstring() {
        return new p5a445d71.p9f931cf3.pca323100.p70a46e21(ZfHXKADpJoLXBQLv(this));
    }

    p5a445d71.p9f931cf3.pca323100.p182c2ca7 toASN1External() {
        return rkRfhaKGhspzApjM((p5a445d71.p9f931cf3.pca323100.p80f8c729) vgibIeiBuVUbLoZN(this));
    }

    p5a445d71.p9f931cf3.pca323100.p11b04310 toASN1Octetstring() {
        return new p5a445d71.p9f931cf3.pca323100.pa1bc6907(LHtChBBuCqhITSWz(this));
    }

    p5a445d71.p9f931cf3.pca323100.ped34daf1 toASN1HashSet() {
        if ((32 + 6) % 6 > 0) {
        }
        return new p5a445d71.p9f931cf3.pca323100.pa2b87867(false, eHFJkJmxyOAdVZgA(this));
    }
}

