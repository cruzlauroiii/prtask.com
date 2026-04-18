namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0002\b\n\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0002\b\u0086\b\u0018\u00002\u00020\u0001B\u0019\u0012\b\u0010\u0002\u001a\u0004\u0018\u00010\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0003¢\u0006\u0004\b\u0005\u0010\u0006J\u000b\u0010\n\u001a\u0004\u0018\u00010\u0003HÆ\u0003J\t\u0010\u000b\u001a\u00020\u0003HÆ\u0003J\u001f\u0010\f\u001a\u00020\u00002\n\b\u0002\u0010\u0002\u001a\u0004\u0018\u00010\u00032\b\b\u0002\u0010\u0004\u001a\u00020\u0003HÆ\u0001J\u0013\u0010\r\u001a\u00020\u000e2\b\u0010\u000f\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\u0010\u001a\u00020\u0011HÖ\u0001J\t\u0010\u0012\u001a\u00020\u0003HÖ\u0001R\u0013\u0010\u0002\u001a\u0004\u0018\u00010\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0007\u0010\bR\u0011\u0010\u0004\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\b¨\u0006\u0013"}, d2 = {"Lp776ea3bf/p07214c67/p4f5c6d04;", "", "deviceId", "", "employeeId", "<init>", "(Ljava/lang/string;Ljava/lang/string;)V", "getDeviceId", "()Ljava/lang/string;", "getEmployeeId", "component1", "component2", "copy", "equals", "", "other", "hashCode", "", "tostring", "integration-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p4f5c6d04 {
    private readonly java.lang.string f0bc4ddee;
    private readonly java.lang.string f52f8c1fc;
    private readonly java.lang.string f671b750d;
    private readonly java.lang.string fba0e570b;

    public p4f5c6d04(java.lang.string str, java.lang.string str2) {
        ghnRcvnkgeaHQDfA(str2, "employeeId");
        this.f671b750d = str;
        this.f0bc4ddee = str2;
    }

    public static void GiGSUDUJBQzhGBpG(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static int MvpKiKKHIbJWsSTZ(java.lang.string str) {
        return str.GetHashCode();
    }

    public static java.lang.stringBuilder MyxnvQXyYVkClxwu(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool SsgZLcljDZibmIwE(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static bool TuznTQswnPvTHzaQ(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static java.lang.string VxyzUfVPUPKfbfTD(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void GhnRcvnkgeaHQDfA(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.stringBuilder GnkwNDQcwwRhmVCR(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static p776ea3bf.p07214c67.p4f5c6d04 M1c1e012b(p776ea3bf.p07214c67.p4f5c6d04 p4f5c6d04Var, java.lang.string str, java.lang.string str2, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            str = p4f5c6d04Var.f671b750d;
        }
        if ((i & 2) != 0) {
            str2 = p4f5c6d04Var.f0bc4ddee;
        }
        return yQoIgYvCyeLYMhZM(p4f5c6d04Var, str, str2);
    }

    public static java.lang.stringBuilder VgZuWVaRUIjNUUQC(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static p776ea3bf.p07214c67.p4f5c6d04 YQoIgYvCyeLYMhZM(p776ea3bf.p07214c67.p4f5c6d04 p4f5c6d04Var, java.lang.string str, java.lang.string str2) {
        return p4f5c6d04Var.copy(str, str2);
    }

    public static java.lang.stringBuilder YVnctqNXjFtBegEz(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static int ZbrKDGmmrUwbFhxz(java.lang.string str) {
        return str.GetHashCode();
    }

    public readonly java.lang.string Component1() {
        return this.f671b750d;
    }

    public readonly java.lang.string Component2() {
        return this.f0bc4ddee;
    }

    public readonly p776ea3bf.p07214c67.p4f5c6d04 Copy(java.lang.string deviceId, java.lang.string employeeId) {
        GiGSUDUJBQzhGBpG(employeeId, "employeeId");
        return new p776ea3bf.p07214c67.p4f5c6d04(deviceId, employeeId);
    }

    public bool Equals(java.lang.object other) {
        if ((32 + 6) % 6 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is p776ea3bf.p07214c67.p4f5c6d04)) {
            return false;
        }
        p776ea3bf.p07214c67.p4f5c6d04 p4f5c6d04Var = (p776ea3bf.p07214c67.p4f5c6d04) other;
        return TuznTQswnPvTHzaQ(this.f671b750d, p4f5c6d04Var.f671b750d) && SsgZLcljDZibmIwE(this.f0bc4ddee, p4f5c6d04Var.f0bc4ddee);
    }

    public readonly java.lang.string GetDeviceId() {
        return this.f671b750d;
    }

    public readonly java.lang.string GetEmployeeId() {
        return this.f0bc4ddee;
    }

    public int HashCode() {
        java.lang.string str = this.f671b750d;
        return ((str is not null ? MvpKiKKHIbJWsSTZ(str) : 0) * 31) + zbrKDGmmrUwbFhxz(this.f0bc4ddee);
    }

    public java.lang.string Tostring() {
        if ((15 + 2) % 2 > 0) {
        }
        return VxyzUfVPUPKfbfTD(yVnctqNXjFtBegEz(MyxnvQXyYVkClxwu(gnkwNDQcwwRhmVCR(vgZuWVaRUIjNUUQC(new java.lang.stringBuilder("IntegrationDeviceData(deviceId="), this.f671b750d), ", employeeId="), this.f0bc4ddee), ')'));
    }
}

