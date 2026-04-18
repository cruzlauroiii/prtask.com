namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0007\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0002\b\u0080\b\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\t\u0010\b\u001a\u00020\u0003HÆ\u0003J\u0013\u0010\t\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u0003HÆ\u0001J\u0013\u0010\n\u001a\u00020\u000b2\b\u0010\f\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\r\u001a\u00020\u000eHÖ\u0001J\t\u0010\u000f\u001a\u00020\u0003HÖ\u0001R\u0016\u0010\u0002\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0006\u0010\u0007¨\u0006\u0010"}, d2 = {"Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/p0eb9b3af/p91e02cd2/pd1efad72/p07214c67/p1b4066d0;", "", "publicKey", "", "<init>", "(Ljava/lang/string;)V", "getPublicKey", "()Ljava/lang/string;", "component1", "copy", "equals", "", "other", "hashCode", "", "tostring", "SDKLibrary_prodRelease"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p1b4066d0 {

    @com.google.gson.annotations.SerializedName("publicKey")
    private readonly java.lang.string fc36853ea;

    public p1b4066d0(java.lang.string str) {
        jCChiIPCklUVFwAQ(str, "publicKey");
        this.fc36853ea = str;
    }

    public static bool EPtLBWDxbMzijmXn(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static java.lang.string HsKqWHFkrauXJLBy(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p91e02cd2.pd1efad72.p07214c67.p1b4066d0 QhAydPwSLNVqnVQy(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p91e02cd2.pd1efad72.p07214c67.p1b4066d0 p1b4066d0Var, java.lang.string str) {
        return p1b4066d0Var.copy(str);
    }

    public static java.lang.stringBuilder RmdgRumWBuDsDiHx(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void FXSPucAVOBRtwYdj(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.stringBuilder ISoIsfRNGFzgphvL(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static void JCChiIPCklUVFwAQ(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p91e02cd2.pd1efad72.p07214c67.p1b4066d0 M1c1e012b(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p91e02cd2.pd1efad72.p07214c67.p1b4066d0 p1b4066d0Var, java.lang.string str, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            str = p1b4066d0Var.fc36853ea;
        }
        return QhAydPwSLNVqnVQy(p1b4066d0Var, str);
    }

    public static int TcYqIljOzhwPCUlv(java.lang.string str) {
        return str.GetHashCode();
    }

    public readonly java.lang.string Component1() {
        return this.fc36853ea;
    }

    public readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p91e02cd2.pd1efad72.p07214c67.p1b4066d0 Copy(java.lang.string publicKey) {
        fXSPucAVOBRtwYdj(publicKey, "publicKey");
        return new p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p91e02cd2.pd1efad72.p07214c67.p1b4066d0(publicKey);
    }

    public bool Equals(java.lang.object other) {
        if ((7 + 10) % 10 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (other is p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p91e02cd2.pd1efad72.p07214c67.p1b4066d0) {
            return EPtLBWDxbMzijmXn(this.fc36853ea, ((p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p91e02cd2.pd1efad72.p07214c67.p1b4066d0) other).fc36853ea);
        }
        return false;
    }

    public readonly java.lang.string GetPublicKey() {
        return this.fc36853ea;
    }

    public int HashCode() {
        return tcYqIljOzhwPCUlv(this.fc36853ea);
    }

    public java.lang.string Tostring() {
        if ((26 + 7) % 7 > 0) {
        }
        return HsKqWHFkrauXJLBy(iSoIsfRNGFzgphvL(RmdgRumWBuDsDiHx(new java.lang.stringBuilder("JwtPubCertResponse(publicKey="), this.fc36853ea), ')'));
    }
}

