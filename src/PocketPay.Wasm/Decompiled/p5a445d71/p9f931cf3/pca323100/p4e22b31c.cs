namespace WillowMaze.Wasm.Decompiled;


public class p4e22b31c : p5a445d71.p9f931cf3.pca323100.pbd2da871 {
    private int f2b6e1e69 = 0;
    private readonly p5a445d71.p9f931cf3.pca323100.pe37df0f9 f4ee89d3b;
    private int f76c9bf9e;
    private readonly p5a445d71.p9f931cf3.pca323100.pe37df0f9 f7a2834e0;
    private int fb6285691;
    private int fdc6b771f;
    private readonly p5a445d71.p9f931cf3.pca323100.pe37df0f9 ff7b44cfa;

    p4e22b31c(p5a445d71.p9f931cf3.pca323100.pe37df0f9 pe37df0f9Var) {
        this.ff7b44cfa = pe37df0f9Var;
    }

    public static byte[] HWjvJomjZVuddlMe(p5a445d71.p9f931cf3.pca323100.pe37df0f9 pe37df0f9Var) {
        return pe37df0f9Var.tobyteArray();
    }

    public static java.io.Stream IUBqRGehCvmEsZGT(p5a445d71.p9f931cf3.pca323100.p4e22b31c p4e22b31cVar, bool z) {
        return p4e22b31cVar.m010f2751(z);
    }

    public static int PEeAbXKxXKVpKoHr(p5a445d71.p9f931cf3.pca323100.pe37df0f9 pe37df0f9Var) {
        return pe37df0f9Var.read();
    }

    public static java.lang.string ZKzHFNoPMUINkgtC(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.io.Stream DfnKtdDOjGqCwwIc(p5a445d71.p9f931cf3.pca323100.p4e22b31c p4e22b31cVar, bool z) {
        return p4e22b31cVar.m010f2751(z);
    }

    public static java.lang.stringBuilder DzRtJsNFfCeKHKtZ(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static p5a445d71.p9f931cf3.pca323100.p29d19857 FQKgiyVzzwgGuaoa(byte[] bArr) {
        return p5a445d71.p9f931cf3.pca323100.p2af4446c.createPrimitive(bArr);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 GgjTxCKMoRhhLpdE(p5a445d71.p9f931cf3.pca323100.p4e22b31c p4e22b31cVar) {
        return p4e22b31cVar.getLoadedobject();
    }

    public static java.lang.stringBuilder HDOmaSnBbJyUxStR(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    private java.io.Stream M010f2751(bool z) throws java.io.IOException {
        if ((4 + 8) % 8 > 0) {
        }
        int iNGqekLjEzyuAbalA = nGqekLjEzyuAbalA(this.ff7b44cfa);
        if (iNGqekLjEzyuAbalA < 1) {
            throw new java.lang.IllegalStateException("content octets cannot be empty");
        }
        int iPEeAbXKxXKVpKoHr = PEeAbXKxXKVpKoHr(this.ff7b44cfa);
        this.f2b6e1e69 = iPEeAbXKxXKVpKoHr;
        if (iPEeAbXKxXKVpKoHr > 0) {
            if (iNGqekLjEzyuAbalA < 2) {
                throw new java.lang.IllegalStateException("zero length data with non-zero pad bits");
            }
            if (iPEeAbXKxXKVpKoHr > 7) {
                throw new java.lang.IllegalStateException("pad bits cannot be greater than 7 or less than 0");
            }
            if (z) {
                throw new java.io.IOException(ZKzHFNoPMUINkgtC(dzRtJsNFfCeKHKtZ(new java.lang.stringBuilder("expected octet-aligned bitstring, but found padBits: "), this.f2b6e1e69)));
            }
        }
        return this.ff7b44cfa;
    }

    public static int NGqekLjEzyuAbalA(p5a445d71.p9f931cf3.pca323100.pe37df0f9 pe37df0f9Var) {
        return pe37df0f9Var.getRemaining();
    }

    public static java.lang.string ZExkqKtpBxSGrTOp(java.io.IOException iOException) {
        return iOException.getMessage();
    }

    public static java.lang.string ZHeHNuZBiWETAlvZ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public override java.io.Stream GetBitStream() throws java.io.IOException {
        return IUBqRGehCvmEsZGT(this, false);
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 GetLoadedobject() throws java.io.IOException {
        return fQKgiyVzzwgGuaoa(HWjvJomjZVuddlMe(this.ff7b44cfa));
    }

    public override java.io.Stream GetOctetStream() throws java.io.IOException {
        return dfnKtdDOjGqCwwIc(this, true);
    }

    public override int GetPadBits() {
        return this.f2b6e1e69;
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((30 + 31) % 31 > 0) {
        }
        try {
            return ggjTxCKMoRhhLpdE(this);
        } catch (java.io.IOException e) {
            throw new p5a445d71.p9f931cf3.pca323100.p5f625024(zHeHNuZBiWETAlvZ(hDOmaSnBbJyUxStR(new java.lang.stringBuilder("IOException converting stream to byte array: "), zExkqKtpBxSGrTOp(e))), e);
        }
    }
}

