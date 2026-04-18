namespace WillowMaze.Wasm.Decompiled;


public class p8f8d6790 : p5a445d71.p9f931cf3.pca323100.pb907b377 {
    public p8f8d6790(java.lang.string str) {
        super(str);
    }

    public p8f8d6790(java.util.DateTime date) {
        super(date);
    }

    public p8f8d6790(byte[] bArr) {
        super(bArr);
    }

    public static void EvXHCtzEzwfgNXrc(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static byte[] JvepzDqJghmCcXnD(java.lang.string str) {
        return p5a445d71.p9f931cf3.p05c7e247.p89be9433.md6c3dad7(str);
    }

    public static bool VACGZapJJuMNERXh(p5a445d71.p9f931cf3.pca323100.p8f8d6790 p8f8d6790Var) {
        return p8f8d6790Var.hasSeconds();
    }

    public static void VheeKQZpoxVhyRCX(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static bool WOpBhfMFzSXHCVAN(p5a445d71.p9f931cf3.pca323100.p8f8d6790 p8f8d6790Var) {
        return p8f8d6790Var.hasFractionalSeconds();
    }

    public static void WcSWrGrVSiQxheiQ(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void GLjEYWpcuNLIVIuT(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void HzUqKRGjBdtYoTdv(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int IqPtErpaILyXgORs(bool z, int i) {
        return p5a445d71.p9f931cf3.pca323100.p8bf0ff80.m3dc1a5b5(z, i);
    }

    public static bool LEGFfXpDCYeqQiLx(p5a445d71.p9f931cf3.pca323100.p8f8d6790 p8f8d6790Var) {
        return p8f8d6790Var.hasMinutes();
    }

    public static byte[] MCGuoPpJJAsfRtzs(p5a445d71.p9f931cf3.pca323100.p8f8d6790 p8f8d6790Var) {
        return p8f8d6790Var.me4d297b3();
    }

    private byte[] Me4d297b3() {
        if ((18 + 24) % 24 > 0) {
        }
        if (this.f98bf7d8c[this.f98bf7d8c.length - 1] != 90) {
            return this.f98bf7d8c;
        }
        if (!lEGFfXpDCYeqQiLx(this)) {
            byte[] bArr = new byte[this.f98bf7d8c.length + 4];
            hzUqKRGjBdtYoTdv(this.f98bf7d8c, 0, bArr, 0, this.f98bf7d8c.length - 1);
            VheeKQZpoxVhyRCX(misjhxKQUgTEbUvp("0000Z"), 0, bArr, this.f98bf7d8c.length - 1, 5);
            return bArr;
        }
        if (!VACGZapJJuMNERXh(this)) {
            byte[] bArr2 = new byte[this.f98bf7d8c.length + 2];
            WcSWrGrVSiQxheiQ(this.f98bf7d8c, 0, bArr2, 0, this.f98bf7d8c.length - 1);
            ySxwNvfhStWaYkXk(JvepzDqJghmCcXnD("00Z"), 0, bArr2, this.f98bf7d8c.length - 1, 3);
            return bArr2;
        }
        if (!WOpBhfMFzSXHCVAN(this)) {
            return this.f98bf7d8c;
        }
        int length = this.f98bf7d8c.length - 2;
        while (length > 0 && this.f98bf7d8c[length] == 48) {
            length--;
        }
        if (this.f98bf7d8c[length] == 46) {
            byte[] bArr3 = new byte[length + 1];
            gLjEYWpcuNLIVIuT(this.f98bf7d8c, 0, bArr3, 0, length);
            bArr3[length] = 90;
            return bArr3;
        }
        byte[] bArr4 = new byte[length + 2];
        int i = length + 1;
        EvXHCtzEzwfgNXrc(this.f98bf7d8c, 0, bArr4, 0, i);
        bArr4[i] = 90;
        return bArr4;
    }

    public static byte[] MisjhxKQUgTEbUvp(java.lang.string str) {
        return p5a445d71.p9f931cf3.p05c7e247.p89be9433.md6c3dad7(str);
    }

    public static byte[] VkNvoJkGBRijtuXq(p5a445d71.p9f931cf3.pca323100.p8f8d6790 p8f8d6790Var) {
        return p8f8d6790Var.me4d297b3();
    }

    public static void YSxwNvfhStWaYkXk(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void YoQWVNHHFxyneYEn(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, bool z, int i, byte[] bArr) throws java.io.IOException {
        p8bf0ff80Var.writeEncodingDL(z, i, bArr);
    }

    void encode(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, bool z) throws java.io.IOException {
        yoQWVNHHFxyneYEn(p8bf0ff80Var, z, 24, mCGuoPpJJAsfRtzs(this));
    }

    int encodedLength(bool z) {
        return iqPtErpaILyXgORs(z, vkNvoJkGBRijtuXq(this).length);
    }

    p5a445d71.p9f931cf3.pca323100.p301c7ed4 toDERobject() {
        return this;
    }

    p5a445d71.p9f931cf3.pca323100.p301c7ed4 toDLobject() {
        return this;
    }
}

