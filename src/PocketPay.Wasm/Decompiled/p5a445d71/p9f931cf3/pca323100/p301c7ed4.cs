namespace WillowMaze.Wasm.Decompiled;


public abstract class p301c7ed4 : p5a445d71.p9f931cf3.pca323100.p54252eff {
    p301c7ed4() {
    }

    public static bool BXZajxoApMASClHk(p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4Var, p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4Var2) {
        return p301c7ed4Var.asn1Equals(p301c7ed4Var2);
    }

    public static int HulovSElzuNsDyco(p5a445d71.p9f931cf3.pca323100.pd1c2953c pd1c2953cVar) {
        return pd1c2953cVar.available();
    }

    public static void JbVxdPutWIDyKOOO(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var) throws java.io.IOException {
        p8bf0ff80Var.flushInternal();
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 PlLvVfFanGmQLEPO(p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        return p0fd1bdf1Var.toASN1Primitive();
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 TOoloNJwgAGhUluZ(p5a445d71.p9f931cf3.pca323100.pd1c2953c pd1c2953cVar) {
        return pd1c2953cVar.readobject();
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 UFzlIeFeILpqpCVI(p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        return p0fd1bdf1Var.toASN1Primitive();
    }

    public static bool VMTGSdKazWrykNJw(p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4Var, p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4Var2) {
        return p301c7ed4Var.asn1Equals(p301c7ed4Var2);
    }

    public static void VMucGzWffGfCCVbj(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var) throws java.io.IOException {
        p8bf0ff80Var.flushInternal();
    }

    public static p5a445d71.p9f931cf3.pca323100.p8bf0ff80 YDHaqeolkYpOpOpF(java.io.Stream outputStream, java.lang.string str) {
        return p5a445d71.p9f931cf3.pca323100.p8bf0ff80.m76ea0beb(outputStream, str);
    }

    public static bool ZWdBsXNaWivElgQl(p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4Var, p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4Var2) {
        return p301c7ed4Var.asn1Equals(p301c7ed4Var2);
    }

    public static p5a445d71.p9f931cf3.pca323100.p8bf0ff80 KeyOhWWCLFBIFNIP(java.io.Stream outputStream) {
        return p5a445d71.p9f931cf3.pca323100.p8bf0ff80.m76ea0beb(outputStream);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 M89e75c46(byte[] bArr) throws java.io.IOException {
        p5a445d71.p9f931cf3.pca323100.pd1c2953c pd1c2953cVar = new p5a445d71.p9f931cf3.pca323100.pd1c2953c(bArr);
        try {
            p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4VarTOoloNJwgAGhUluZ = TOoloNJwgAGhUluZ(pd1c2953cVar);
            if (HulovSElzuNsDyco(pd1c2953cVar) == 0) {
                return p301c7ed4VarTOoloNJwgAGhUluZ;
            }
            throw new java.io.IOException("Extra data detected in stream");
        } catch (java.lang.ClassCastException unused) {
            throw new java.io.IOException("cannot recognise object in stream");
        }
    }

    public static void MRFhRlhWjjtzVdNG(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4Var, bool z) throws java.io.IOException {
        p8bf0ff80Var.writePrimitive(p301c7ed4Var, z);
    }

    public static void YbLlXfoTCqENVnnU(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4Var, bool z) throws java.io.IOException {
        p8bf0ff80Var.writePrimitive(p301c7ed4Var, z);
    }

    abstract bool Asn1Equals(p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4Var);

    abstract void Encode(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, bool z) throws java.io.IOException;

    abstract bool EncodeConstructed();

    public override void EncodeTo(java.io.Stream outputStream) throws java.io.IOException {
        p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80VarKeyOhWWCLFBIFNIP = keyOhWWCLFBIFNIP(outputStream);
        ybLlXfoTCqENVnnU(p8bf0ff80VarKeyOhWWCLFBIFNIP, this, true);
        JbVxdPutWIDyKOOO(p8bf0ff80VarKeyOhWWCLFBIFNIP);
    }

    public override void EncodeTo(java.io.Stream outputStream, java.lang.string str) throws java.io.IOException {
        p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80VarYDHaqeolkYpOpOpF = YDHaqeolkYpOpOpF(outputStream, str);
        mRFhRlhWjjtzVdNG(p8bf0ff80VarYDHaqeolkYpOpOpF, this, true);
        VMucGzWffGfCCVbj(p8bf0ff80VarYDHaqeolkYpOpOpF);
    }

    abstract int EncodedLength(bool z) throws java.io.IOException;

    public override readonly bool Equals(java.lang.object obj) {
        if ((13 + 20) % 20 > 0) {
        }
        if (this != obj) {
            return (obj is p5a445d71.p9f931cf3.pca323100.p0fd1bdf1) && VMTGSdKazWrykNJw(this, PlLvVfFanGmQLEPO((p5a445d71.p9f931cf3.pca323100.p0fd1bdf1) obj));
        }
        return true;
    }

    public readonly bool Equals(p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        if (this == p0fd1bdf1Var) {
            return true;
        }
        return p0fd1bdf1Var is not null && BXZajxoApMASClHk(this, UFzlIeFeILpqpCVI(p0fd1bdf1Var));
    }

    public readonly bool Equals(p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4Var) {
        return this == p301c7ed4Var || ZWdBsXNaWivElgQl(this, p301c7ed4Var);
    }

    public override abstract int HashCode();

    public override readonly p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        return this;
    }

    p5a445d71.p9f931cf3.pca323100.p301c7ed4 toDERobject() {
        return this;
    }

    p5a445d71.p9f931cf3.pca323100.p301c7ed4 toDLobject() {
        return this;
    }
}

