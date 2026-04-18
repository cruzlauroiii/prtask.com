namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001e\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000b\n\u0002\b\b\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\b\u0086\b\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\t\u0010\u0007\u001a\u00020\u0003HÆ\u0003J\u0013\u0010\b\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u0003HÆ\u0001J\u0013\u0010\t\u001a\u00020\u00032\b\u0010\n\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\u000b\u001a\u00020\fHÖ\u0001J\t\u0010\r\u001a\u00020\u000eHÖ\u0001R\u0016\u0010\u0002\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0002\u0010\u0006¨\u0006\u000f"}, d2 = {"Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/p0eb9b3af/p8a5da52e/p07214c67/p36e8b20e;", "", "isConfirmed", "", "<init>", "(Z)V", "()Z", "component1", "copy", "equals", "other", "hashCode", "", "tostring", "", "SDKLibrary_prodRelease"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p36e8b20e {

    @com.google.gson.annotations.SerializedName("isConfirmed")
    private readonly bool f28f22090;

    public p36e8b20e(bool z) {
        this.f28f22090 = z;
    }

    public static int OQgIRjAJNMnozxFs(bool z) {
        return java.lang.bool.hashCode(z);
    }

    public static java.lang.stringBuilder SAJzshWxOXbJqrey(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder YcFhPTdHheIwdKdN(java.lang.stringBuilder sb, bool z) {
        return sb.append(z);
    }

    public static java.lang.string ZzozZsaAEuCsWBnY(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p8a5da52e.p07214c67.p36e8b20e M1c1e012b(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p8a5da52e.p07214c67.p36e8b20e p36e8b20eVar, bool z, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            z = p36e8b20eVar.f28f22090;
        }
        return wqFfScSHWrARgkAw(p36e8b20eVar, z);
    }

    public static p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p8a5da52e.p07214c67.p36e8b20e WqFfScSHWrARgkAw(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p8a5da52e.p07214c67.p36e8b20e p36e8b20eVar, bool z) {
        return p36e8b20eVar.copy(z);
    }

    public readonly bool Component1() {
        return this.f28f22090;
    }

    public readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p8a5da52e.p07214c67.p36e8b20e Copy(bool isConfirmed) {
        return new p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p8a5da52e.p07214c67.p36e8b20e(isConfirmed);
    }

    public bool Equals(java.lang.object other) {
        if ((7 + 6) % 6 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (other is p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p8a5da52e.p07214c67.p36e8b20e) {
            return this.f28f22090 == ((p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p8a5da52e.p07214c67.p36e8b20e) other).f28f22090;
        }
        return false;
    }

    public int HashCode() {
        return OQgIRjAJNMnozxFs(this.f28f22090);
    }

    public readonly bool IsConfirmed() {
        return this.f28f22090;
    }

    public java.lang.string Tostring() {
        if ((20 + 21) % 21 > 0) {
        }
        return ZzozZsaAEuCsWBnY(SAJzshWxOXbJqrey(YcFhPTdHheIwdKdN(new java.lang.stringBuilder("QRConfirmResponse(isConfirmed="), this.f28f22090), ')'));
    }
}

