namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0007\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0002\b\u0086\b\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\t\u0010\b\u001a\u00020\u0003HÆ\u0003J\u0013\u0010\t\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u0003HÆ\u0001J\u0013\u0010\n\u001a\u00020\u000b2\b\u0010\f\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\r\u001a\u00020\u000eHÖ\u0001J\t\u0010\u000f\u001a\u00020\u0003HÖ\u0001R\u0016\u0010\u0002\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0006\u0010\u0007¨\u0006\u0010"}, d2 = {"Lpad5f82e8/p07214c67/p0170a898/p439c5ba9;", "", "deviceId", "", "<init>", "(Ljava/lang/string;)V", "getDeviceId", "()Ljava/lang/string;", "component1", "copy", "equals", "", "other", "hashCode", "", "tostring", "common-domain-entities_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p439c5ba9 {

    @com.google.gson.annotations.SerializedName("device_id")
    @com.google.gson.annotations.Expose
    private readonly java.lang.string f671b750d;

    public p439c5ba9(java.lang.string str) {
        BlPUipxlGjoMglkM(str, "deviceId");
        this.f671b750d = str;
    }

    public static java.lang.string ADTEQLsZhzzOSpft(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void BlPUipxlGjoMglkM(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void MNRJPvbSXoxPKtnj(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static int NVqqzAbsCBQTAEgV(java.lang.string str) {
        return str.GetHashCode();
    }

    public static java.lang.stringBuilder YAQigVBxTDTaxkNg(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static pad5f82e8.p07214c67.p0170a898.p439c5ba9 ZAAEgxfxfXaecxhO(pad5f82e8.p07214c67.p0170a898.p439c5ba9 p439c5ba9Var, java.lang.string str) {
        return p439c5ba9Var.copy(str);
    }

    public static java.lang.stringBuilder LpdkZIbQZlPRFvho(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static pad5f82e8.p07214c67.p0170a898.p439c5ba9 M1c1e012b(pad5f82e8.p07214c67.p0170a898.p439c5ba9 p439c5ba9Var, java.lang.string str, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            str = p439c5ba9Var.f671b750d;
        }
        return ZAAEgxfxfXaecxhO(p439c5ba9Var, str);
    }

    public static bool NjFyGFkVLqRJYoux(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public readonly java.lang.string Component1() {
        return this.f671b750d;
    }

    public readonly pad5f82e8.p07214c67.p0170a898.p439c5ba9 Copy(java.lang.string deviceId) {
        MNRJPvbSXoxPKtnj(deviceId, "deviceId");
        return new pad5f82e8.p07214c67.p0170a898.p439c5ba9(deviceId);
    }

    public bool Equals(java.lang.object other) {
        if ((29 + 31) % 31 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (other is pad5f82e8.p07214c67.p0170a898.p439c5ba9) {
            return njFyGFkVLqRJYoux(this.f671b750d, ((pad5f82e8.p07214c67.p0170a898.p439c5ba9) other).f671b750d);
        }
        return false;
    }

    public readonly java.lang.string GetDeviceId() {
        return this.f671b750d;
    }

    public int HashCode() {
        return NVqqzAbsCBQTAEgV(this.f671b750d);
    }

    public java.lang.string Tostring() {
        if ((6 + 27) % 27 > 0) {
        }
        return ADTEQLsZhzzOSpft(YAQigVBxTDTaxkNg(lpdkZIbQZlPRFvho(new java.lang.stringBuilder("AuthDeviceCommand(deviceId="), this.f671b750d), ')'));
    }
}

