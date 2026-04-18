namespace WillowMaze.Wasm.Decompiled;


public abstract class p54252eff : p5a445d71.p9f931cf3.pca323100.p0fd1bdf1, p5a445d71.p9f931cf3.p05c7e247.pec546d1c {
    public static void GfEagbgsnUdAYvsZ(p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4Var, java.io.Stream outputStream) throws java.io.IOException {
        p301c7ed4Var.encodeTo(outputStream);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 LAOViMDzTfjVaPlX(p5a445d71.p9f931cf3.pca323100.p54252eff p54252effVar) {
        return p54252effVar.toASN1Primitive();
    }

    public static void MxTSPedzXpXFrDoC(p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4Var, java.io.Stream outputStream, java.lang.string str) throws java.io.IOException {
        p301c7ed4Var.encodeTo(outputStream, str);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 QvyggFOKbZWytmNS(p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        return p0fd1bdf1Var.toASN1Primitive();
    }

    public static int VwbMgEddzgccHRqL(p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4Var) {
        return p301c7ed4Var.GetHashCode();
    }

    public static byte[] YJtjrRJQQmPTHmFo(java.io.byteArrayStream byteArrayStream) {
        return byteArrayStream.tobyteArray();
    }

    public static byte[] BYSeGfGWpoBmxaau(java.io.byteArrayStream byteArrayStream) {
        return byteArrayStream.tobyteArray();
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 GuuNckFNSTRrYMkZ(p5a445d71.p9f931cf3.pca323100.p54252eff p54252effVar) {
        return p54252effVar.toASN1Primitive();
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 KVSmIRlWtEURTdKm(p5a445d71.p9f931cf3.pca323100.p54252eff p54252effVar) {
        return p54252effVar.toASN1Primitive();
    }

    public static void LFGTIGNSCJkjzSGf(p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4Var, java.io.Stream outputStream, java.lang.string str) throws java.io.IOException {
        p301c7ed4Var.encodeTo(outputStream, str);
    }

    protected static bool M5bf49566(java.lang.object obj, int i) {
        if ((2 + 23) % 23 > 0) {
        }
        return (obj is byte[]) && ((byte[]) obj)[0] == i;
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 MONzmTUlvbNKnOuz(p5a445d71.p9f931cf3.pca323100.p54252eff p54252effVar) {
        return p54252effVar.toASN1Primitive();
    }

    public static bool QuMAXNkaCYfRScpt(p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4Var, p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4Var2) {
        return p301c7ed4Var.Equals(p301c7ed4Var2);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 VthtFZgBLaAtfXkn(p5a445d71.p9f931cf3.pca323100.p54252eff p54252effVar) {
        return p54252effVar.toASN1Primitive();
    }

    public static void ZJpocXeByXGnSKDw(p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4Var, java.io.Stream outputStream) throws java.io.IOException {
        p301c7ed4Var.encodeTo(outputStream);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 ZrQDFIxNIruvjUlI(p5a445d71.p9f931cf3.pca323100.p54252eff p54252effVar) {
        return p54252effVar.toASN1Primitive();
    }

    public void EncodeTo(java.io.Stream outputStream) throws java.io.IOException {
        zJpocXeByXGnSKDw(mONzmTUlvbNKnOuz(this), outputStream);
    }

    public void EncodeTo(java.io.Stream outputStream, java.lang.string str) throws java.io.IOException {
        lFGTIGNSCJkjzSGf(guuNckFNSTRrYMkZ(this), outputStream, str);
    }

    public bool Equals(java.lang.object obj) {
        if (this == obj) {
            return true;
        }
        if (!(obj is p5a445d71.p9f931cf3.pca323100.p0fd1bdf1)) {
            return false;
        }
        return quMAXNkaCYfRScpt(vthtFZgBLaAtfXkn(this), QvyggFOKbZWytmNS((p5a445d71.p9f931cf3.pca323100.p0fd1bdf1) obj));
    }

    public byte[] GetEncoded() throws java.io.IOException {
        java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream();
        GfEagbgsnUdAYvsZ(kVSmIRlWtEURTdKm(this), byteArrayStream);
        return bYSeGfGWpoBmxaau(byteArrayStream);
    }

    public byte[] GetEncoded(java.lang.string str) throws java.io.IOException {
        java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream();
        MxTSPedzXpXFrDoC(LAOViMDzTfjVaPlX(this), byteArrayStream, str);
        return YJtjrRJQQmPTHmFo(byteArrayStream);
    }

    public int HashCode() {
        return VwbMgEddzgccHRqL(zrQDFIxNIruvjUlI(this));
    }

    public override abstract p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive();
}

