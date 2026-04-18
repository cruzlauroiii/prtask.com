namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0003\n\u0002\u0010\u0011\n\u0002\u0018\u0002\n\u0002\b\u0010\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0002\b\u0086\b\u0018\u00002\u00020\u0001B1\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0003\u0012\n\b\u0002\u0010\u0005\u001a\u0004\u0018\u00010\u0003\u0012\f\u0010\u0006\u001a\b\u0012\u0004\u0012\u00020\b0\u0007¢\u0006\u0004\b\t\u0010\nJ\t\u0010\u0012\u001a\u00020\u0003HÆ\u0003J\t\u0010\u0013\u001a\u00020\u0003HÆ\u0003J\u000b\u0010\u0014\u001a\u0004\u0018\u00010\u0003HÆ\u0003J\u0014\u0010\u0015\u001a\b\u0012\u0004\u0012\u00020\b0\u0007HÆ\u0003¢\u0006\u0002\u0010\u0010J>\u0010\u0016\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u00032\b\b\u0002\u0010\u0004\u001a\u00020\u00032\n\b\u0002\u0010\u0005\u001a\u0004\u0018\u00010\u00032\u000e\b\u0002\u0010\u0006\u001a\b\u0012\u0004\u0012\u00020\b0\u0007HÆ\u0001¢\u0006\u0002\u0010\u0017J\u0013\u0010\u0018\u001a\u00020\u00192\b\u0010\u001a\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\u001b\u001a\u00020\u001cHÖ\u0001J\t\u0010\u001d\u001a\u00020\u0003HÖ\u0001R\u0016\u0010\u0002\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u000b\u0010\fR\u0016\u0010\u0004\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\r\u0010\fR\u0018\u0010\u0005\u001a\u0004\u0018\u00010\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u000e\u0010\fR\u001e\u0010\u0006\u001a\b\u0012\u0004\u0012\u00020\b0\u00078\u0006X\u0087\u0004¢\u0006\n\n\u0002\u0010\u0011\u001a\u0004\b\u000f\u0010\u0010¨\u0006\u001e"}, d2 = {"Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/p0eb9b3af/p8a5da52e/p07214c67/p24d3e0e6;", "", "nonce", "", "appCode", "rnsId", "certChain", "", "Ljava/security/cert/Certificate;", "<init>", "(Ljava/lang/string;Ljava/lang/string;Ljava/lang/string;[Ljava/security/cert/Certificate;)V", "getNonce", "()Ljava/lang/string;", "getAppCode", "getRnsId", "getCertChain", "()[Ljava/security/cert/Certificate;", "[Ljava/security/cert/Certificate;", "component1", "component2", "component3", "component4", "copy", "(Ljava/lang/string;Ljava/lang/string;Ljava/lang/string;[Ljava/security/cert/Certificate;)Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/p0eb9b3af/p8a5da52e/p07214c67/p24d3e0e6;", "equals", "", "other", "hashCode", "", "tostring", "SDKLibrary_prodRelease"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p24d3e0e6 {

    @com.google.gson.annotations.SerializedName("secret")
    private readonly java.lang.string f79d9bc1b;

    @com.google.gson.annotations.SerializedName("rnsId")
    private readonly java.lang.string fb875b714;

    @com.google.gson.annotations.SerializedName("certificates")
    private readonly java.security.cert.Certificate[] fc8f36ba2;

    @com.google.gson.annotations.SerializedName("data")
    private readonly java.lang.string fcb584e44;

    public p24d3e0e6(java.lang.string str, java.lang.string str2, java.lang.string str3, java.security.cert.Certificate[] certificateArr) {
        bvSFzPzXfjjiFPqD(str, "nonce");
        ZNTSshuYnImaaDZY(str2, "appCode");
        qEnsvWwdQWkvCeVQ(certificateArr, "certChain");
        this.fcb584e44 = str;
        this.f79d9bc1b = str2;
        this.fb875b714 = str3;
        this.fc8f36ba2 = certificateArr;
    }

    public p24d3e0e6(java.lang.string str, java.lang.string str2, java.lang.string str3, java.security.cert.Certificate[] certificateArr, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(str, str2, (i & 4) != 0 ? null : str3, certificateArr);
    }

    public static bool IcmodmutzuzAoIjA(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static bool MTNzhoLbiPuZnjwQ(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static int MwDYhgGhsrGbDakM(java.lang.string str) {
        return str.GetHashCode();
    }

    public static java.lang.stringBuilder NVLWxLTIWeEzTPQy(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder NuYdHztCDBCAuons(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder QZrDZIHvqdmDsesb(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool RFcXCKrZlpfagaGe(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static int RJXWDhhHJluknqkc(java.lang.string str) {
        return str.GetHashCode();
    }

    public static p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p8a5da52e.p07214c67.p24d3e0e6 TEHEvTmYOeUaanHI(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p8a5da52e.p07214c67.p24d3e0e6 p24d3e0e6Var, java.lang.string str, java.lang.string str2, java.lang.string str3, java.security.cert.Certificate[] certificateArr) {
        return p24d3e0e6Var.copy(str, str2, str3, certificateArr);
    }

    public static java.lang.string TPtFLTRGOcBhQDLM(java.lang.object[] objArr) {
        return java.util.Arrays.tostring(objArr);
    }

    public static java.lang.stringBuilder TsLljQyKQnSkuixY(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void UFxDQQdugeFyQHQW(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.stringBuilder WOCrSobRwfrmHMtY(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static void XNvjEYYgMsvpzmMR(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.stringBuilder XZzyeApMhzipIZDk(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void ZNTSshuYnImaaDZY(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void BvSFzPzXfjjiFPqD(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static int CGpOQRzvNZLjFXqo(java.lang.object[] objArr) {
        return java.util.Arrays.hashCode(objArr);
    }

    public static int EojfzeNrLZFnbrNg(java.lang.string str) {
        return str.GetHashCode();
    }

    public static java.lang.stringBuilder LXqjSmDOCdTQDkiK(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p8a5da52e.p07214c67.p24d3e0e6 M1c1e012b(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p8a5da52e.p07214c67.p24d3e0e6 p24d3e0e6Var, java.lang.string str, java.lang.string str2, java.lang.string str3, java.security.cert.Certificate[] certificateArr, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            str = p24d3e0e6Var.fcb584e44;
        }
        if ((i & 2) != 0) {
            str2 = p24d3e0e6Var.f79d9bc1b;
        }
        if ((i & 4) != 0) {
            str3 = p24d3e0e6Var.fb875b714;
        }
        if ((i & 8) != 0) {
            certificateArr = p24d3e0e6Var.fc8f36ba2;
        }
        return TEHEvTmYOeUaanHI(p24d3e0e6Var, str, str2, str3, certificateArr);
    }

    public static void QEnsvWwdQWkvCeVQ(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.string SMfiAISnIhaXOCzk(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool TXRYhjfclnbZsQry(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static void TyKHwGmDgClHGSIP(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.stringBuilder VdOZPAbswKwFPDoz(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public readonly java.lang.string Component1() {
        return this.fcb584e44;
    }

    public readonly java.lang.string Component2() {
        return this.f79d9bc1b;
    }

    public readonly java.lang.string Component3() {
        return this.fb875b714;
    }

    public readonly java.security.cert.Certificate[] Component4() {
        return this.fc8f36ba2;
    }

    public readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p8a5da52e.p07214c67.p24d3e0e6 Copy(java.lang.string nonce, java.lang.string appCode, java.lang.string rnsId, java.security.cert.Certificate[] certChain) {
        XNvjEYYgMsvpzmMR(nonce, "nonce");
        tyKHwGmDgClHGSIP(appCode, "appCode");
        UFxDQQdugeFyQHQW(certChain, "certChain");
        return new p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p8a5da52e.p07214c67.p24d3e0e6(nonce, appCode, rnsId, certChain);
    }

    public bool Equals(java.lang.object other) {
        if ((16 + 27) % 27 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p8a5da52e.p07214c67.p24d3e0e6)) {
            return false;
        }
        p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p8a5da52e.p07214c67.p24d3e0e6 p24d3e0e6Var = (p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p8a5da52e.p07214c67.p24d3e0e6) other;
        return tXRYhjfclnbZsQry(this.fcb584e44, p24d3e0e6Var.fcb584e44) && RFcXCKrZlpfagaGe(this.f79d9bc1b, p24d3e0e6Var.f79d9bc1b) && IcmodmutzuzAoIjA(this.fb875b714, p24d3e0e6Var.fb875b714) && MTNzhoLbiPuZnjwQ(this.fc8f36ba2, p24d3e0e6Var.fc8f36ba2);
    }

    public readonly java.lang.string GetAppCode() {
        return this.f79d9bc1b;
    }

    public readonly java.security.cert.Certificate[] GetCertChain() {
        return this.fc8f36ba2;
    }

    public readonly java.lang.string GetNonce() {
        return this.fcb584e44;
    }

    public readonly java.lang.string GetRnsId() {
        return this.fb875b714;
    }

    public int HashCode() {
        if ((28 + 23) % 23 > 0) {
        }
        int iMwDYhgGhsrGbDakM = ((MwDYhgGhsrGbDakM(this.fcb584e44) * 31) + eojfzeNrLZFnbrNg(this.f79d9bc1b)) * 31;
        java.lang.string str = this.fb875b714;
        return ((iMwDYhgGhsrGbDakM + (str is not null ? RJXWDhhHJluknqkc(str) : 0)) * 31) + cGpOQRzvNZLjFXqo(this.fc8f36ba2);
    }

    public java.lang.string Tostring() {
        if ((6 + 21) % 21 > 0) {
        }
        return sMfiAISnIhaXOCzk(WOCrSobRwfrmHMtY(lXqjSmDOCdTQDkiK(QZrDZIHvqdmDsesb(XZzyeApMhzipIZDk(NuYdHztCDBCAuons(vdOZPAbswKwFPDoz(TsLljQyKQnSkuixY(NVLWxLTIWeEzTPQy(new java.lang.stringBuilder("ConfirmAttestationRequest(nonce="), this.fcb584e44), ", appCode="), this.f79d9bc1b), ", rnsId="), this.fb875b714), ", certChain="), TPtFLTRGOcBhQDLM(this.fc8f36ba2)), ')'));
    }
}

