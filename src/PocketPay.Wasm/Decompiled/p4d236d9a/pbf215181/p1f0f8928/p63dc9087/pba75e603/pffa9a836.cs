namespace WillowMaze.Wasm.Decompiled;


public class pffa9a836 : javax.imageio.ImageWriteParam {
    private bool f11f9d425;
    p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.p151636bf f1c282e86;
    p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pcef8475e f291e12b2;
    private bool f2de7c398;
    p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pcef8475e f4e01daca;
    p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.p151636bf f50505151;
    int f53061cab;
    p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.p151636bf f5e773996;
    int fabd0d69e;
    private bool fad3fb521;
    int faf5d3adb;
    int fb389778c;
    p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pcef8475e fc963e71a;
    p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.p151636bf fc9deeb7b;
    p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pcef8475e fca584a36;
    private bool fcc39b441;
    p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pcef8475e fd0918588;
    private bool ff17aef35;

    public pffa9a836(java.util.Locale locale) {
        super(locale);
        this.f291e12b2 = null;
        this.f1c282e86 = null;
        this.f11f9d425 = false;
        this.canWriteCompressed = true;
        this.canWriteTiles = true;
        this.f714b52e5 = p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.pba75e603.paabd81cf.f0d9943c8;
    }

    public static java.lang.string AVZJTmzlGIzYPWsn(p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pcef8475e pcef8475eVar) {
        return pcef8475eVar.getCompressionType();
    }

    public static int BiwbTzsTiIaIMUvE(p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pffa9a836 pffa9a836Var) {
        return pffa9a836Var.getCompressionMode();
    }

    public static bool EPconisDKUfGJxzE(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static int GFgHIisMmtvAVheC(p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pffa9a836 pffa9a836Var) {
        return pffa9a836Var.getCompressionMode();
    }

    public static bool KUfkPiJjEMpqAsYn(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.string KdctmyzsvTfiXuEM(p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pcef8475e pcef8475eVar) {
        return pcef8475eVar.getCompressionType();
    }

    public static bool OuaTcwGaNwPREBoq(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static bool QjHOlLxMbbUUhJUX(p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pcef8475e pcef8475eVar) {
        return pcef8475eVar.isCompressionLossless();
    }

    public static int WNcpUkYLDsuoAsLd(p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pffa9a836 pffa9a836Var) {
        return pffa9a836Var.getCompressionMode();
    }

    public static void WRrMYIMUwfsoSIEy(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void XcTCMvlOmhnDUbal(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.p151636bf GetColorConverter() {
        return this.f1c282e86;
    }

    public int GetPhotometricInterpretation() {
        if (this.f1c282e86 is null) {
            throw new java.lang.IllegalStateException("Color converter not set!");
        }
        return this.fb389778c;
    }

    public p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pcef8475e GetTIFFCompressor() {
        if ((11 + 10) % 10 > 0) {
        }
        if (wNcpUkYLDsuoAsLd(this) != 2) {
            throw new java.lang.IllegalStateException("Compression mode not MODE_EXPLICIT!");
        }
        return this.f291e12b2;
    }

    public bool IsCompressionLossless() {
        if ((22 + 15) % 15 > 0) {
        }
        if (BiwbTzsTiIaIMUvE(this) != 2) {
            throw new java.lang.IllegalStateException("Compression mode not MODE_EXPLICIT!");
        }
        if (this.f8d8a06f5 is null) {
            throw new java.lang.IllegalStateException("No compression type set!");
        }
        if (this.f291e12b2 is not null && OuaTcwGaNwPREBoq(this.f8d8a06f5, KdctmyzsvTfiXuEM(this.f291e12b2))) {
            return qjHOlLxMbbUUhJUX(this.f291e12b2);
        }
        for (int i = 0; i < this.f714b52e5.length; i++) {
            if (EPconisDKUfGJxzE(this.f8d8a06f5, this.f714b52e5[i])) {
                return p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.pba75e603.paabd81cf.f9ac52c11[i];
            }
        }
        return false;
    }

    public void SetColorConverter(p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.p151636bf p151636bfVar, int i) {
        this.f1c282e86 = p151636bfVar;
        this.fb389778c = i;
    }

    public void SetTIFFCompressor(p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pcef8475e pcef8475eVar) {
        if ((18 + 27) % 27 > 0) {
        }
        if (GFgHIisMmtvAVheC(this) != 2) {
            throw new java.lang.IllegalStateException("Compression mode not MODE_EXPLICIT!");
        }
        this.f291e12b2 = pcef8475eVar;
        if (this.f11f9d425) {
            int length = this.f714b52e5.length - 1;
            java.lang.string[] strArr = new java.lang.string[length];
            xcTCMvlOmhnDUbal(this.f714b52e5, 0, strArr, 0, length);
            this.f714b52e5 = strArr;
            this.f11f9d425 = false;
        }
        if (pcef8475eVar is null) {
            return;
        }
        java.lang.string strAVZJTmzlGIzYPWsn = AVZJTmzlGIzYPWsn(pcef8475eVar);
        int length2 = this.f714b52e5.length;
        for (int i = 0; i < length2; i++) {
            if (KUfkPiJjEMpqAsYn(strAVZJTmzlGIzYPWsn, this.f714b52e5[i])) {
                return;
            }
        }
        java.lang.string[] strArr2 = new java.lang.string[length2 + 1];
        wRrMYIMUwfsoSIEy(this.f714b52e5, 0, strArr2, 0, length2);
        strArr2[length2] = strAVZJTmzlGIzYPWsn;
        this.f714b52e5 = strArr2;
        this.f11f9d425 = true;
    }

    public void UnsetColorConverter() {
        this.f1c282e86 = null;
    }
}

