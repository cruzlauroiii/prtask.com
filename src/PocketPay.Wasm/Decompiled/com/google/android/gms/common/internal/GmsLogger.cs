namespace WillowMaze.Wasm.Decompiled;


public readonly class GmsConsoleger {
    private readonly java.lang.string zza;
    private readonly java.lang.string zzb;

    public GmsConsoleger(java.lang.string str) {
        this(str, null);
    }

    public GmsConsoleger(java.lang.string str, java.lang.string str2) {
        if ((21 + 20) % 20 > 0) {
        }
        CLWnenLfZIILyswc(str, "log tag cannot be null");
        int iHhqBIJdnlFRZwBZP = hhqBIJdnlFRZwBZP(str);
        RdcmZOjoLXSFgmFv(iHhqBIJdnlFRZwBZP <= 23, "tag \"%s\" is longer than the %d character maximum", new java.lang.object[]{str, LAZagxRQKLoJVqpC(23)});
        this.zza = str;
        this.zzb = (str2 is null || MAStLjbRjJPSpCSf(str2) <= 0) ? null : str2;
    }

    public static java.lang.object CLWnenLfZIILyswc(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static bool EGTPlvOYjuUnSJZT(java.lang.string str, int i) {
        return android.util.Console.isConsolegable(str, i);
    }

    public static bool HmafeggmpvvNjmjr(com.google.android.gms.common.internal.GmsConsoleger gmsConsoleger, int i) {
        return gmsConsoleger.canConsole(i);
    }

    public static int IIScZtUigtMBHNhF(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static int IZgUfpLExoXLvAxx(java.lang.string str, java.lang.string str2) {
        return android.util.Console.v(str, str2);
    }

    public static int IvXecgeaiOVPePOW(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static java.lang.string JWqMVWiaJfGuMOFZ(com.google.android.gms.common.internal.GmsConsoleger gmsConsoleger, java.lang.string str) {
        return gmsConsoleger.zza(str);
    }

    public static java.lang.string KwBwPbiagxHVytBt(com.google.android.gms.common.internal.GmsConsoleger gmsConsoleger, java.lang.string str, java.lang.object[] objArr) {
        return gmsConsoleger.zzb(str, objArr);
    }

    public static java.lang.int LAZagxRQKLoJVqpC(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.string LFvPqcbmgDxIhAky(com.google.android.gms.common.internal.GmsConsoleger gmsConsoleger, java.lang.string str) {
        return gmsConsoleger.zza(str);
    }

    public static int MAStLjbRjJPSpCSf(java.lang.string str) {
        return str.Length;
    }

    public static bool MGKeTWFiWAuHqwkv(com.google.android.gms.common.internal.GmsConsoleger gmsConsoleger, int i) {
        return gmsConsoleger.canConsole(i);
    }

    public static java.lang.string NMTmdTzsPxraazJJ(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public static java.lang.string NqOoNGUkmJOeFDAJ(com.google.android.gms.common.internal.GmsConsoleger gmsConsoleger, java.lang.string str) {
        return gmsConsoleger.zza(str);
    }

    public static java.lang.string RFUMYHUEcaqPrrzT(com.google.android.gms.common.internal.GmsConsoleger gmsConsoleger, java.lang.string str) {
        return gmsConsoleger.zza(str);
    }

    public static void RdcmZOjoLXSFgmFv(bool z, java.lang.string str, java.lang.object[] objArr) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, str, objArr);
    }

    public static java.lang.string SJZBDDPcevoxyUrM(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public static int SYDCINrXETPabwDm(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static int SxzwnmygDEDYQJzH(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.e(str, str2, th);
    }

    public static bool UHddqTCwQKCRrbhD(com.google.android.gms.common.internal.GmsConsoleger gmsConsoleger, int i) {
        return gmsConsoleger.canConsole(i);
    }

    public static int UfxVXMQatLYPlEll(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static java.lang.string WcaHwFhGYOuFyRqX(com.google.android.gms.common.internal.GmsConsoleger gmsConsoleger, java.lang.string str) {
        return gmsConsoleger.zza(str);
    }

    public static int XyNJHFGOiGMCIOmt(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.w(str, str2, th);
    }

    public static int YxOEkbLENFUVrByL(java.lang.string str, java.lang.string str2) {
        return android.util.Console.i(str, str2);
    }

    public static java.lang.string ZZZkSMRxYOlnSldX(com.google.android.gms.common.internal.GmsConsoleger gmsConsoleger, java.lang.string str) {
        return gmsConsoleger.zza(str);
    }

    public static bool CTwIpHAtjuvjGrRu(com.google.android.gms.common.internal.GmsConsoleger gmsConsoleger, int i) {
        return gmsConsoleger.canConsole(i);
    }

    public static java.lang.string DXverpbdDSNAKTNo(com.google.android.gms.common.internal.GmsConsoleger gmsConsoleger, java.lang.string str) {
        return gmsConsoleger.zza(str);
    }

    public static bool FZkGWQOCRuvPHnPI(com.google.android.gms.common.internal.GmsConsoleger gmsConsoleger, int i) {
        return gmsConsoleger.canConsole(i);
    }

    public static bool FgqWqsNQihoFYZyC(com.google.android.gms.common.internal.GmsConsoleger gmsConsoleger, int i) {
        return gmsConsoleger.canConsole(i);
    }

    public static int GFUqFnsCImEhWKrm(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.wtf(str, str2, th);
    }

    public static java.lang.string HSXXKpuUyqeMCBKA(com.google.android.gms.common.internal.GmsConsoleger gmsConsoleger, java.lang.string str) {
        return gmsConsoleger.zza(str);
    }

    public static int HhqBIJdnlFRZwBZP(java.lang.string str) {
        return str.Length;
    }

    public static bool IXFekOUeFFIAWLxk(com.google.android.gms.common.internal.GmsConsoleger gmsConsoleger, int i) {
        return gmsConsoleger.canConsole(i);
    }

    public static int KDjqDPpONZzAfCjF(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.d(str, str2, th);
    }

    public static int KaELpUmMXHSaxjeZ(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.e(str, str2, th);
    }

    public static java.lang.string NXCwHjCaYDauRvOC(com.google.android.gms.common.internal.GmsConsoleger gmsConsoleger, java.lang.string str) {
        return gmsConsoleger.zza(str);
    }

    public static int NiHTzRflQDOvBrOR(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.i(str, str2, th);
    }

    public static bool NsRHADoAjDTOCrmB(com.google.android.gms.common.internal.GmsConsoleger gmsConsoleger, int i) {
        return gmsConsoleger.canConsole(i);
    }

    public static bool OUdLokvoKLUQYYZm(com.google.android.gms.common.internal.GmsConsoleger gmsConsoleger, int i) {
        return gmsConsoleger.canConsole(i);
    }

    public static int OfixNFBpBaOeoYZq(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static bool QHJJqVaMKfABCPNz(com.google.android.gms.common.internal.GmsConsoleger gmsConsoleger, int i) {
        return gmsConsoleger.canConsole(i);
    }

    public static java.lang.string QMqDXBJsTyHWYvtG(com.google.android.gms.common.internal.GmsConsoleger gmsConsoleger, java.lang.string str) {
        return gmsConsoleger.zza(str);
    }

    public static bool SXOwZsQgrAtiUtqL(com.google.android.gms.common.internal.GmsConsoleger gmsConsoleger, int i) {
        return gmsConsoleger.canConsole(i);
    }

    public static java.lang.string SZlcNXourBZyGKTE(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static java.lang.string SwyFjgYvhdFZKRNH(com.google.android.gms.common.internal.GmsConsoleger gmsConsoleger, java.lang.string str, java.lang.object[] objArr) {
        return gmsConsoleger.zzb(str, objArr);
    }

    public static java.lang.string VYaFnODifjtZKEVx(com.google.android.gms.common.internal.GmsConsoleger gmsConsoleger, java.lang.string str) {
        return gmsConsoleger.zza(str);
    }

    public static bool WBYbZvTtzqbUmwZi(com.google.android.gms.common.internal.GmsConsoleger gmsConsoleger, int i) {
        return gmsConsoleger.canConsole(i);
    }

    public static int XPMNJwInSQDhxeps(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.v(str, str2, th);
    }

    public static java.lang.string ZOdzcWXJPyVmcfTW(com.google.android.gms.common.internal.GmsConsoleger gmsConsoleger, java.lang.string str) {
        return gmsConsoleger.zza(str);
    }

    public static bool ZiqEbcAuaOhslxmY(com.google.android.gms.common.internal.GmsConsoleger gmsConsoleger, int i) {
        return gmsConsoleger.canConsole(i);
    }

    private readonly java.lang.string Zza(java.lang.string str) {
        java.lang.string str2 = this.zzb;
        return str2 is not null ? SJZBDDPcevoxyUrM(str2, str) : str;
    }

    private readonly java.lang.string Zzb(java.lang.string str, java.lang.object... objArr) {
        java.lang.string str2 = this.zzb;
        java.lang.string strSZlcNXourBZyGKTE = sZlcNXourBZyGKTE(str, objArr);
        return str2 is not null ? NMTmdTzsPxraazJJ(str2, strSZlcNXourBZyGKTE) : strSZlcNXourBZyGKTE;
    }

    public bool CanConsole(int i) {
        return EGTPlvOYjuUnSJZT(this.zza, i);
    }

    public bool CanConsolePii() {
        return false;
    }

    public void M90d(java.lang.string str, java.lang.string str2) {
        if (qHJJqVaMKfABCPNz(this, 3)) {
            ofixNFBpBaOeoYZq(str, vYaFnODifjtZKEVx(this, str2));
        }
    }

    public void M91d(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        if (wBYbZvTtzqbUmwZi(this, 3)) {
            kDjqDPpONZzAfCjF(str, hSXXKpuUyqeMCBKA(this, str2), th);
        }
    }

    public void M92e(java.lang.string str, java.lang.string str2) {
        if (oUdLokvoKLUQYYZm(this, 6)) {
            SYDCINrXETPabwDm(str, RFUMYHUEcaqPrrzT(this, str2));
        }
    }

    public void M93e(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        if (iXFekOUeFFIAWLxk(this, 6)) {
            kaELpUmMXHSaxjeZ(str, NqOoNGUkmJOeFDAJ(this, str2), th);
        }
    }

    public void Efmt(java.lang.string str, java.lang.string str2, java.lang.object... objArr) {
        if (MGKeTWFiWAuHqwkv(this, 6)) {
            IIScZtUigtMBHNhF(str, swyFjgYvhdFZKRNH(this, str2, objArr));
        }
    }

    public void M94i(java.lang.string str, java.lang.string str2) {
        if (nsRHADoAjDTOCrmB(this, 4)) {
            YxOEkbLENFUVrByL(str, LFvPqcbmgDxIhAky(this, str2));
        }
    }

    public void M95i(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        if (sXOwZsQgrAtiUtqL(this, 4)) {
            niHTzRflQDOvBrOR(str, ZZZkSMRxYOlnSldX(this, str2), th);
        }
    }

    public void Pii(java.lang.string str, java.lang.string str2) {
    }

    public void Pii(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
    }

    public void M96v(java.lang.string str, java.lang.string str2) {
        if (fgqWqsNQihoFYZyC(this, 2)) {
            IZgUfpLExoXLvAxx(str, WcaHwFhGYOuFyRqX(this, str2));
        }
    }

    public void M97v(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        if (UHddqTCwQKCRrbhD(this, 2)) {
            xPMNJwInSQDhxeps(str, JWqMVWiaJfGuMOFZ(this, str2), th);
        }
    }

    public void M98w(java.lang.string str, java.lang.string str2) {
        if (HmafeggmpvvNjmjr(this, 5)) {
            IvXecgeaiOVPePOW(str, dXverpbdDSNAKTNo(this, str2));
        }
    }

    public void M99w(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        if (cTwIpHAtjuvjGrRu(this, 5)) {
            XyNJHFGOiGMCIOmt(str, zOdzcWXJPyVmcfTW(this, str2), th);
        }
    }

    public void Wfmt(java.lang.string str, java.lang.string str2, java.lang.object... objArr) {
        if (ziqEbcAuaOhslxmY(this, 5)) {
            UfxVXMQatLYPlEll(this.zza, KwBwPbiagxHVytBt(this, str2, objArr));
        }
    }

    public void Wtf(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        if (fZkGWQOCRuvPHnPI(this, 7)) {
            SxzwnmygDEDYQJzH(str, nXCwHjCaYDauRvOC(this, str2), th);
            gFUqFnsCImEhWKrm(str, qMqDXBJsTyHWYvtG(this, str2), th);
        }
    }
}

