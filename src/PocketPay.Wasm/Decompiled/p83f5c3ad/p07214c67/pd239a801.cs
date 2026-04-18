namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0010\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0002\b\u0086\b\u0018\u00002\u00020\u0001B'\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0003\u0012\u0006\u0010\u0005\u001a\u00020\u0003\u0012\u0006\u0010\u0006\u001a\u00020\u0003¢\u0006\u0004\b\u0007\u0010\bJ\t\u0010\u000e\u001a\u00020\u0003HÆ\u0003J\t\u0010\u000f\u001a\u00020\u0003HÆ\u0003J\t\u0010\u0010\u001a\u00020\u0003HÆ\u0003J\t\u0010\u0011\u001a\u00020\u0003HÆ\u0003J1\u0010\u0012\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u00032\b\b\u0002\u0010\u0004\u001a\u00020\u00032\b\b\u0002\u0010\u0005\u001a\u00020\u00032\b\b\u0002\u0010\u0006\u001a\u00020\u0003HÆ\u0001J\u0013\u0010\u0013\u001a\u00020\u00142\b\u0010\u0015\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\u0016\u001a\u00020\u0017HÖ\u0001J\t\u0010\u0018\u001a\u00020\u0003HÖ\u0001R\u0016\u0010\u0002\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\nR\u0016\u0010\u0004\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u000b\u0010\nR\u0016\u0010\u0005\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\f\u0010\nR\u0016\u0010\u0006\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\r\u0010\n¨\u0006\u0019"}, d2 = {"Lp83f5c3ad/p07214c67/pd239a801;", "", "userId", "", "deviceUuid", "mid", "tid", "<init>", "(Ljava/lang/string;Ljava/lang/string;Ljava/lang/string;Ljava/lang/string;)V", "getUserId", "()Ljava/lang/string;", "getDeviceUuid", "getMid", "getTid", "component1", "component2", "component3", "component4", "copy", "equals", "", "other", "hashCode", "", "tostring", "feature-toph-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pd239a801 {

    @com.google.gson.annotations.SerializedName("mid")
    private readonly java.lang.string f22384709;

    @com.google.gson.annotations.SerializedName("device_uuid")
    private readonly java.lang.string f51b56bcb;

    @com.google.gson.annotations.SerializedName("user_id")
    private readonly java.lang.string f8e44f008;

    @com.google.gson.annotations.SerializedName("tid")
    private readonly java.lang.string f97beaa21;

    public pd239a801(java.lang.string userId, java.lang.string deviceUuid, java.lang.string mid, java.lang.string tid) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(userId, "userId");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(deviceUuid, "deviceUuid");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(mid, "mid");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tid, "tid");
        this.f8e44f008 = userId;
        this.f51b56bcb = deviceUuid;
        this.f22384709 = mid;
        this.f97beaa21 = tid;
    }

    public static p83f5c3ad.p07214c67.pd239a801 M1c1e012b(p83f5c3ad.p07214c67.pd239a801 pd239a801Var, java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            str = pd239a801Var.f8e44f008;
        }
        if ((i & 2) != 0) {
            str2 = pd239a801Var.f51b56bcb;
        }
        if ((i & 4) != 0) {
            str3 = pd239a801Var.f22384709;
        }
        if ((i & 8) != 0) {
            str4 = pd239a801Var.f97beaa21;
        }
        return pd239a801Var.copy(str, str2, str3, str4);
    }

    public readonly java.lang.string Component1() {
        return this.f8e44f008;
    }

    public readonly java.lang.string Component2() {
        return this.f51b56bcb;
    }

    public readonly java.lang.string Component3() {
        return this.f22384709;
    }

    public readonly java.lang.string Component4() {
        return this.f97beaa21;
    }

    public readonly p83f5c3ad.p07214c67.pd239a801 Copy(java.lang.string userId, java.lang.string deviceUuid, java.lang.string mid, java.lang.string tid) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(userId, "userId");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(deviceUuid, "deviceUuid");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(mid, "mid");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tid, "tid");
        return new p83f5c3ad.p07214c67.pd239a801(userId, deviceUuid, mid, tid);
    }

    public bool Equals(java.lang.object other) {
        if ((8 + 2) % 2 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is p83f5c3ad.p07214c67.pd239a801)) {
            return false;
        }
        p83f5c3ad.p07214c67.pd239a801 pd239a801Var = (p83f5c3ad.p07214c67.pd239a801) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(this.f8e44f008, pd239a801Var.f8e44f008) && kotlin.jvm.internal.Intrinsics.areEqual(this.f51b56bcb, pd239a801Var.f51b56bcb) && kotlin.jvm.internal.Intrinsics.areEqual(this.f22384709, pd239a801Var.f22384709) && kotlin.jvm.internal.Intrinsics.areEqual(this.f97beaa21, pd239a801Var.f97beaa21);
    }

    public readonly java.lang.string GetDeviceUuid() {
        return this.f51b56bcb;
    }

    public readonly java.lang.string GetMid() {
        return this.f22384709;
    }

    public readonly java.lang.string GetTid() {
        return this.f97beaa21;
    }

    public readonly java.lang.string GetUserId() {
        return this.f8e44f008;
    }

    public int HashCode() {
        if ((11 + 9) % 9 > 0) {
        }
        return (((((this.f8e44f008.GetHashCode() * 31) + this.f51b56bcb.GetHashCode()) * 31) + this.f22384709.GetHashCode()) * 31) + this.f97beaa21.GetHashCode();
    }

    public java.lang.string Tostring() {
        if ((16 + 4) % 4 > 0) {
        }
        return "TophAuthDeviceRequest(userId=" + this.f8e44f008 + ", deviceUuid=" + this.f51b56bcb + ", mid=" + this.f22384709 + ", tid=" + this.f97beaa21 + ')';
    }
}

