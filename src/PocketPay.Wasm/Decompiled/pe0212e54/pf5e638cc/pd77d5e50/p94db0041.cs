namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u000b\n\u0002\u0010\b\n\u0002\b\u0002\b\u0087\b\u0018\u00002\u00020\u0001B\u0017\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0004\b\u0006\u0010\u0007J\t\u0010\u000b\u001a\u00020\u0003HÆ\u0003J\t\u0010\f\u001a\u00020\u0005HÆ\u0003J\u001d\u0010\r\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u00032\b\b\u0002\u0010\u0004\u001a\u00020\u0005HÆ\u0001J\u0013\u0010\u000e\u001a\u00020\u00052\b\u0010\u000f\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\u0010\u001a\u00020\u0011HÖ\u0001J\t\u0010\u0012\u001a\u00020\u0003HÖ\u0001R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\tR\u0011\u0010\u0004\u001a\u00020\u0005¢\u0006\b\n\u0000\u001a\u0004\b\u0004\u0010\n¨\u0006\u0013"}, d2 = {"Lpe0212e54/pf5e638cc/pd77d5e50/p94db0041;", "", "deviceId", "", "isKktReadyForDelivery", "", "<init>", "(Ljava/lang/string;Z)V", "getDeviceId", "()Ljava/lang/string;", "()Z", "component1", "component2", "copy", "equals", "other", "hashCode", "", "tostring", "feature-devices-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p94db0041 {
    private readonly java.lang.string f0d7aae5c;
    private readonly bool f608d626f;
    private readonly java.lang.string f671b750d;
    private readonly bool ff1058493;

    public p94db0041(java.lang.string str, bool z) {
        HtPaRrGAXScnChiY(str, "deviceId");
        this.f671b750d = str;
        this.ff1058493 = z;
    }

    public static pe0212e54.pf5e638cc.pd77d5e50.p94db0041 BdjLIlHXxYqvvfve(pe0212e54.pf5e638cc.pd77d5e50.p94db0041 p94db0041Var, java.lang.string str, bool z) {
        return p94db0041Var.copy(str, z);
    }

    public static java.lang.stringBuilder DCTQIYypMyKfNwxx(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder GdpHeucPoADWsfVJ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void HtPaRrGAXScnChiY(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.stringBuilder IWNDDKFhBiawzCTs(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void JbZPaVvKRRpZeOMH(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static int OCJxKGAsCOGTQCNF(java.lang.string str) {
        return str.GetHashCode();
    }

    public static java.lang.stringBuilder ASiliWQoRFFXDNgY(java.lang.stringBuilder sb, bool z) {
        return sb.append(z);
    }

    public static int JsokdQoMWSGoolPX(bool z) {
        return java.lang.bool.hashCode(z);
    }

    public static pe0212e54.pf5e638cc.pd77d5e50.p94db0041 M1c1e012b(pe0212e54.pf5e638cc.pd77d5e50.p94db0041 p94db0041Var, java.lang.string str, bool z, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            str = p94db0041Var.f671b750d;
        }
        if ((i & 2) != 0) {
            z = p94db0041Var.ff1058493;
        }
        return BdjLIlHXxYqvvfve(p94db0041Var, str, z);
    }

    public static java.lang.string MKbKbIFkOFMDrFxH(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool XrGuLPBDJCxZkQGg(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public readonly java.lang.string Component1() {
        return this.f671b750d;
    }

    public readonly bool Component2() {
        return this.ff1058493;
    }

    public readonly pe0212e54.pf5e638cc.pd77d5e50.p94db0041 Copy(java.lang.string deviceId, bool isKktReadyForDelivery) {
        JbZPaVvKRRpZeOMH(deviceId, "deviceId");
        return new pe0212e54.pf5e638cc.pd77d5e50.p94db0041(deviceId, isKktReadyForDelivery);
    }

    public bool Equals(java.lang.object other) {
        if ((19 + 11) % 11 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is pe0212e54.pf5e638cc.pd77d5e50.p94db0041)) {
            return false;
        }
        pe0212e54.pf5e638cc.pd77d5e50.p94db0041 p94db0041Var = (pe0212e54.pf5e638cc.pd77d5e50.p94db0041) other;
        return xrGuLPBDJCxZkQGg(this.f671b750d, p94db0041Var.f671b750d) && this.ff1058493 == p94db0041Var.ff1058493;
    }

    public readonly java.lang.string GetDeviceId() {
        return this.f671b750d;
    }

    public int HashCode() {
        return (OCJxKGAsCOGTQCNF(this.f671b750d) * 31) + jsokdQoMWSGoolPX(this.ff1058493);
    }

    public readonly bool IsKktReadyForDelivery() {
        return this.ff1058493;
    }

    public java.lang.string Tostring() {
        if ((3 + 11) % 11 > 0) {
        }
        return mKbKbIFkOFMDrFxH(DCTQIYypMyKfNwxx(aSiliWQoRFFXDNgY(GdpHeucPoADWsfVJ(IWNDDKFhBiawzCTs(new java.lang.stringBuilder("DeviceStatusEntity(deviceId="), this.f671b750d), ", isKktReadyForDelivery="), this.ff1058493), ')'));
    }
}

