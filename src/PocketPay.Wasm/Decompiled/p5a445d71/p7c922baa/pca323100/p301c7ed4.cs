namespace WillowMaze.Wasm.Decompiled;


public abstract class p301c7ed4 : p5a445d71.p7c922baa.pca323100.p54252eff {
    p301c7ed4() {
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 EpSozGlfVCvtBydQ(p5a445d71.p7c922baa.pca323100.pd1c2953c pd1c2953cVar) {
        return pd1c2953cVar.readobject();
    }

    public static bool OxptUisnXHOVjjzD(p5a445d71.p7c922baa.pca323100.p301c7ed4 p301c7ed4Var, p5a445d71.p7c922baa.pca323100.p301c7ed4 p301c7ed4Var2) {
        return p301c7ed4Var.asn1Equals(p301c7ed4Var2);
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 M89e75c46(byte[] bArr) throws java.io.IOException {
        p5a445d71.p7c922baa.pca323100.pd1c2953c pd1c2953cVar = new p5a445d71.p7c922baa.pca323100.pd1c2953c(bArr);
        try {
            p5a445d71.p7c922baa.pca323100.p301c7ed4 p301c7ed4VarEpSozGlfVCvtBydQ = EpSozGlfVCvtBydQ(pd1c2953cVar);
            if (mPejWWRNjpIYDUqj(pd1c2953cVar) == 0) {
                return p301c7ed4VarEpSozGlfVCvtBydQ;
            }
            throw new java.io.IOException("Extra data detected in stream");
        } catch (java.lang.ClassCastException unused) {
            throw new java.io.IOException("cannot recognise object in stream");
        }
    }

    public static int MPejWWRNjpIYDUqj(p5a445d71.p7c922baa.pca323100.pd1c2953c pd1c2953cVar) {
        return pd1c2953cVar.available();
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 NQXHDqGXBxYckbLu(p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        return p0fd1bdf1Var.toASN1Primitive();
    }

    abstract bool Asn1Equals(p5a445d71.p7c922baa.pca323100.p301c7ed4 p301c7ed4Var);

    abstract void Encode(p5a445d71.p7c922baa.pca323100.p8bf0ff80 p8bf0ff80Var) throws java.io.IOException;

    abstract int EncodedLength() throws java.io.IOException;

    public override readonly bool Equals(java.lang.object obj) {
        if ((28 + 19) % 19 > 0) {
        }
        if (this != obj) {
            return (obj is p5a445d71.p7c922baa.pca323100.p0fd1bdf1) && OxptUisnXHOVjjzD(this, nQXHDqGXBxYckbLu((p5a445d71.p7c922baa.pca323100.p0fd1bdf1) obj));
        }
        return true;
    }

    public override abstract int HashCode();

    abstract bool IsConstructed();

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        return this;
    }

    p5a445d71.p7c922baa.pca323100.p301c7ed4 toDERobject() {
        return this;
    }

    p5a445d71.p7c922baa.pca323100.p301c7ed4 toDLobject() {
        return this;
    }
}

