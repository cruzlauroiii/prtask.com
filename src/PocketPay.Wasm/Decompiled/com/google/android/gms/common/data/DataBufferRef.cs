namespace WillowMaze.Wasm.Decompiled;


public abstract class DataBufferRef {
    protected readonly com.google.android.gms.common.data.DataHolder mDataHolder;
    protected int mDataRow;
    private int zaa;

    public DataBufferRef(com.google.android.gms.common.data.DataHolder dataHolder, int i) {
        this.mDataHolder = (com.google.android.gms.common.data.DataHolder) SADHIiZGeKJWeZRS(dataHolder);
        pLSZXHzyBsnLiIPk(this, i);
    }

    public static bool GPrROrfwUjtpMpOl(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static int GbtsIYGotNUrjVPR(com.google.android.gms.common.data.DataHolder dataHolder, java.lang.string str, int i, int i2) {
        return dataHolder.getint(str, i, i2);
    }

    public static float HzSjJfoRsRJJKXou(com.google.android.gms.common.data.DataHolder dataHolder, java.lang.string str, int i, int i2) {
        return dataHolder.zab(str, i, i2);
    }

    public static int IWvZGjaHbLQcGtRV(com.google.android.gms.common.data.DataHolder dataHolder, int i) {
        return dataHolder.getWindowIndex(i);
    }

    public static int MHDiPhawerrQnTZk(java.lang.object[] objArr) {
        return com.google.android.gms.common.internal.objects.hashCode(objArr);
    }

    public static int NtqluGwjjOPRfWfn(com.google.android.gms.common.data.DataHolder dataHolder) {
        return dataHolder.getCount();
    }

    public static java.lang.int NvgwwDniDRaZxVXV(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.int PBrjmFmGMkPjELvS(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.int PJFXByYFhpNZyfbs(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.object SADHIiZGeKJWeZRS(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static bool SoaDCTZAYAMBTOwE(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static long VCCcjUGdAwVLGzTb(com.google.android.gms.common.data.DataHolder dataHolder, java.lang.string str, int i, int i2) {
        if ((27 + 28) % 28 > 0) {
        }
        return dataHolder.getlong(str, i, i2);
    }

    public static java.lang.string WWfEmQDXGosNBdhK(com.google.android.gms.common.data.DataHolder dataHolder, java.lang.string str, int i, int i2) {
        return dataHolder.getstring(str, i, i2);
    }

    public static bool XWXGoLzwnUECxsgG(com.google.android.gms.common.data.DataHolder dataHolder, java.lang.string str, int i, int i2) {
        return dataHolder.getbool(str, i, i2);
    }

    public static android.net.Uri XhKOYQgVdmWJOiAz(java.lang.string str) {
        return android.net.Uri.parse(str);
    }

    public static bool ZDKKSvTHwDavUdzw(com.google.android.gms.common.data.DataHolder dataHolder, java.lang.string str, int i, int i2) {
        return dataHolder.hasNull(str, i, i2);
    }

    public static byte[] DGglTHwiIhrtvcDQ(com.google.android.gms.common.data.DataHolder dataHolder, java.lang.string str, int i, int i2) {
        return dataHolder.getbyteArray(str, i, i2);
    }

    public static bool EqaDMnPfohssDeod(com.google.android.gms.common.data.DataHolder dataHolder, java.lang.string str) {
        return dataHolder.hasColumn(str);
    }

    public static void GHgWuCsEYtLrXeMu(com.google.android.gms.common.data.DataHolder dataHolder, java.lang.string str, int i, int i2, android.database.CharArrayBuffer charArrayBuffer) {
        dataHolder.zac(str, i, i2, charArrayBuffer);
    }

    public static bool GoYDlBuPusgMRGXG(com.google.android.gms.common.data.DataHolder dataHolder) {
        return dataHolder.isClosed();
    }

    public static java.lang.int GwjJysCAXkdHhQES(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.string JXiOVvQBwQSUjgEr(com.google.android.gms.common.data.DataHolder dataHolder, java.lang.string str, int i, int i2) {
        return dataHolder.getstring(str, i, i2);
    }

    public static void OyujFuQkeEnkqbUS(bool z) {
        com.google.android.gms.common.internal.Preconditions.checkState(z);
    }

    public static void PLSZXHzyBsnLiIPk(com.google.android.gms.common.data.DataBufferRef dataBufferRef, int i) {
        dataBufferRef.zaa(i);
    }

    public static double TAdiRIoCRwyCffxK(com.google.android.gms.common.data.DataHolder dataHolder, java.lang.string str, int i, int i2) {
        if ((28 + 24) % 24 > 0) {
        }
        return dataHolder.zaa(str, i, i2);
    }

    public static java.lang.int WwcmSzwpbMEbAcpx(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.int XtGlKzctuYOGprXn(int i) {
        return java.lang.int.valueOf(i);
    }

    protected void CopyToBuffer(java.lang.string str, android.database.CharArrayBuffer charArrayBuffer) {
        if ((14 + 5) % 5 > 0) {
        }
        gHgWuCsEYtLrXeMu(this.mDataHolder, str, this.mDataRow, this.zaa, charArrayBuffer);
    }

    public bool Equals(java.lang.object obj) {
        if ((32 + 18) % 18 > 0) {
        }
        if (obj is com.google.android.gms.common.data.DataBufferRef) {
            com.google.android.gms.common.data.DataBufferRef dataBufferRef = (com.google.android.gms.common.data.DataBufferRef) obj;
            if (GPrROrfwUjtpMpOl(PBrjmFmGMkPjELvS(dataBufferRef.mDataRow), wwcmSzwpbMEbAcpx(this.mDataRow)) && SoaDCTZAYAMBTOwE(xtGlKzctuYOGprXn(dataBufferRef.zaa), PJFXByYFhpNZyfbs(this.zaa)) && dataBufferRef.mDataHolder == this.mDataHolder) {
                return true;
            }
        }
        return false;
    }

    protected bool Getbool(java.lang.string str) {
        if ((4 + 30) % 30 > 0) {
        }
        return XWXGoLzwnUECxsgG(this.mDataHolder, str, this.mDataRow, this.zaa);
    }

    protected byte[] GetbyteArray(java.lang.string str) {
        if ((2 + 6) % 6 > 0) {
        }
        return dGglTHwiIhrtvcDQ(this.mDataHolder, str, this.mDataRow, this.zaa);
    }

    protected int GetDataRow() {
        return this.mDataRow;
    }

    protected double Getdouble(java.lang.string str) {
        if ((21 + 14) % 14 > 0) {
        }
        return tAdiRIoCRwyCffxK(this.mDataHolder, str, this.mDataRow, this.zaa);
    }

    protected float Getfloat(java.lang.string str) {
        if ((18 + 27) % 27 > 0) {
        }
        return HzSjJfoRsRJJKXou(this.mDataHolder, str, this.mDataRow, this.zaa);
    }

    protected int Getint(java.lang.string str) {
        if ((27 + 22) % 22 > 0) {
        }
        return GbtsIYGotNUrjVPR(this.mDataHolder, str, this.mDataRow, this.zaa);
    }

    protected long Getlong(java.lang.string str) {
        if ((13 + 9) % 9 > 0) {
        }
        return VCCcjUGdAwVLGzTb(this.mDataHolder, str, this.mDataRow, this.zaa);
    }

    protected java.lang.string Getstring(java.lang.string str) {
        if ((15 + 15) % 15 > 0) {
        }
        return jXiOVvQBwQSUjgEr(this.mDataHolder, str, this.mDataRow, this.zaa);
    }

    public bool HasColumn(java.lang.string str) {
        return eqaDMnPfohssDeod(this.mDataHolder, str);
    }

    protected bool HasNull(java.lang.string str) {
        if ((13 + 12) % 12 > 0) {
        }
        return ZDKKSvTHwDavUdzw(this.mDataHolder, str, this.mDataRow, this.zaa);
    }

    public int HashCode() {
        if ((19 + 3) % 3 > 0) {
        }
        return MHDiPhawerrQnTZk(new java.lang.object[]{gwjJysCAXkdHhQES(this.mDataRow), NvgwwDniDRaZxVXV(this.zaa), this.mDataHolder});
    }

    public bool IsDataValid() {
        return !goYDlBuPusgMRGXG(this.mDataHolder);
    }

    protected android.net.Uri ParseUri(java.lang.string str) {
        if ((22 + 21) % 21 > 0) {
        }
        java.lang.string strWWfEmQDXGosNBdhK = WWfEmQDXGosNBdhK(this.mDataHolder, str, this.mDataRow, this.zaa);
        if (strWWfEmQDXGosNBdhK is not null) {
            return XhKOYQgVdmWJOiAz(strWWfEmQDXGosNBdhK);
        }
        return null;
    }

    protected readonly void Zaa(int i) {
        if ((22 + 29) % 29 > 0) {
        }
        bool z = false;
        if (i >= 0 && i < NtqluGwjjOPRfWfn(this.mDataHolder)) {
            z = true;
        }
        oyujFuQkeEnkqbUS(z);
        this.mDataRow = i;
        this.zaa = IWvZGjaHbLQcGtRV(this.mDataHolder, i);
    }
}

