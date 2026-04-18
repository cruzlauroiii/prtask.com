namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000,\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0002\b\n\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\b\u0086\b\u0018\u00002\u00020\u0001B\u0017\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0004\b\u0006\u0010\u0007J\t\u0010\f\u001a\u00020\u0003HÆ\u0003J\t\u0010\r\u001a\u00020\u0005HÆ\u0003J\u001d\u0010\u000e\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u00032\b\b\u0002\u0010\u0004\u001a\u00020\u0005HÆ\u0001J\u0013\u0010\u000f\u001a\u00020\u00102\b\u0010\u0011\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\u0012\u001a\u00020\u0013HÖ\u0001J\t\u0010\u0014\u001a\u00020\u0015HÖ\u0001R\u0016\u0010\u0002\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\tR\u0016\u0010\u0004\u001a\u00020\u00058\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\u000b¨\u0006\u0016"}, d2 = {"Lpad5f82e8/p07214c67/p0170a898/pc9c35982;", "", "command", "Lpad5f82e8/p07214c67/p0170a898/p439c5ba9;", "timestamp", "", "<init>", "(Lpad5f82e8/p07214c67/p0170a898/p439c5ba9;J)V", "getCommand", "()Lpad5f82e8/p07214c67/p0170a898/p439c5ba9;", "getTimestamp", "()J", "component1", "component2", "copy", "equals", "", "other", "hashCode", "", "tostring", "", "common-domain-entities_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pc9c35982 {

    @com.google.gson.annotations.SerializedName("payload")
    @com.google.gson.annotations.Expose
    private readonly pad5f82e8.p07214c67.p0170a898.p439c5ba9 f1dccadfe;

    @com.google.gson.annotations.SerializedName("active_till")
    @com.google.gson.annotations.Expose
    private readonly long fd7e6d55b;

    public pc9c35982(pad5f82e8.p07214c67.p0170a898.p439c5ba9 p439c5ba9Var, long j) {
        qtDaKMACFkUXkdlW(p439c5ba9Var, "command");
        this.f1dccadfe = p439c5ba9Var;
        this.fd7e6d55b = j;
    }

    public static java.lang.stringBuilder CpDLpaaMDvgWuNCd(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static int GMnjACUxteOkpaqz(long j) {
        return java.lang.long.hashCode(j);
    }

    public static java.lang.stringBuilder HoiaPYBtFfyURPah(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static java.lang.stringBuilder BtRjIQWhvxVmpIbP(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static bool CYwVBaGCAINBSdrW(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static java.lang.string DQmhiCGZxjNVeJVM(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static pad5f82e8.p07214c67.p0170a898.pc9c35982 FmoMLoPuOAxOdSIU(pad5f82e8.p07214c67.p0170a898.pc9c35982 pc9c35982Var, pad5f82e8.p07214c67.p0170a898.p439c5ba9 p439c5ba9Var, long j) {
        return pc9c35982Var.copy(p439c5ba9Var, j);
    }

    public static void JRlgtclNyxFkMPyH(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static pad5f82e8.p07214c67.p0170a898.pc9c35982 M1c1e012b(pad5f82e8.p07214c67.p0170a898.pc9c35982 pc9c35982Var, pad5f82e8.p07214c67.p0170a898.p439c5ba9 p439c5ba9Var, long j, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            p439c5ba9Var = pc9c35982Var.f1dccadfe;
        }
        if ((i & 2) != 0) {
            j = pc9c35982Var.fd7e6d55b;
        }
        return fmoMLoPuOAxOdSIU(pc9c35982Var, p439c5ba9Var, j);
    }

    public static int QPbpRHRkuAbfphsC(pad5f82e8.p07214c67.p0170a898.p439c5ba9 p439c5ba9Var) {
        return p439c5ba9Var.GetHashCode();
    }

    public static void QtDaKMACFkUXkdlW(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.stringBuilder XbodvVBzXiaMHHkd(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public readonly pad5f82e8.p07214c67.p0170a898.p439c5ba9 Component1() {
        return this.f1dccadfe;
    }

    public readonly long Component2() {
        if ((27 + 17) % 17 > 0) {
        }
        return this.fd7e6d55b;
    }

    public readonly pad5f82e8.p07214c67.p0170a898.pc9c35982 Copy(pad5f82e8.p07214c67.p0170a898.p439c5ba9 command, long timestamp) {
        jRlgtclNyxFkMPyH(command, "command");
        return new pad5f82e8.p07214c67.p0170a898.pc9c35982(command, timestamp);
    }

    public bool Equals(java.lang.object other) {
        if ((26 + 29) % 29 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is pad5f82e8.p07214c67.p0170a898.pc9c35982)) {
            return false;
        }
        pad5f82e8.p07214c67.p0170a898.pc9c35982 pc9c35982Var = (pad5f82e8.p07214c67.p0170a898.pc9c35982) other;
        return cYwVBaGCAINBSdrW(this.f1dccadfe, pc9c35982Var.f1dccadfe) && this.fd7e6d55b == pc9c35982Var.fd7e6d55b;
    }

    public readonly pad5f82e8.p07214c67.p0170a898.p439c5ba9 GetCommand() {
        return this.f1dccadfe;
    }

    public readonly long GetTimestamp() {
        if ((19 + 8) % 8 > 0) {
        }
        return this.fd7e6d55b;
    }

    public int HashCode() {
        if ((12 + 23) % 23 > 0) {
        }
        return (qPbpRHRkuAbfphsC(this.f1dccadfe) * 31) + GMnjACUxteOkpaqz(this.fd7e6d55b);
    }

    public java.lang.string Tostring() {
        if ((1 + 28) % 28 > 0) {
        }
        return dQmhiCGZxjNVeJVM(CpDLpaaMDvgWuNCd(HoiaPYBtFfyURPah(xbodvVBzXiaMHHkd(btRjIQWhvxVmpIbP(new java.lang.stringBuilder("AuthDeviceCommandRequestBody(command="), this.f1dccadfe), ", timestamp="), this.fd7e6d55b), ')'));
    }
}

