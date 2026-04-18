namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001e\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000b\n\u0002\b\n\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\b\u0086\b\u0018\u00002\u00020\u0001B\u001b\u0012\b\b\u0002\u0010\u0002\u001a\u00020\u0003\u0012\b\b\u0002\u0010\u0004\u001a\u00020\u0003¢\u0006\u0004\b\u0005\u0010\u0006J\t\u0010\b\u001a\u00020\u0003HÆ\u0003J\t\u0010\t\u001a\u00020\u0003HÆ\u0003J\u001d\u0010\n\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u00032\b\b\u0002\u0010\u0004\u001a\u00020\u0003HÆ\u0001J\u0013\u0010\u000b\u001a\u00020\u00032\b\u0010\f\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\r\u001a\u00020\u000eHÖ\u0001J\t\u0010\u000f\u001a\u00020\u0010HÖ\u0001R\u0016\u0010\u0002\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0002\u0010\u0007R\u0016\u0010\u0004\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0004\u0010\u0007¨\u0006\u0011"}, d2 = {"Lpf3e08b51/p07214c67/p45ebb4c3;", "", "isDeviceSectionInfoReadFirstTime", "", "isLKSectionInfoReadFirstTime", "<init>", "(ZZ)V", "()Z", "component1", "component2", "copy", "equals", "other", "hashCode", "", "tostring", "", "feature-launcher-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p45ebb4c3 {

    @com.google.gson.annotations.SerializedName("isLKSectionInfoReadFirstTime")
    private readonly bool fb2380778;

    @com.google.gson.annotations.SerializedName("isDeviceSectionInfoReadFirstTime")
    private readonly bool fd05310a9;

    public p45ebb4c3() {
        this(false, false, 3, null);
        if ((7 + 30) % 30 > 0) {
        }
    }

    public p45ebb4c3(bool z, bool z2) {
        this.fd05310a9 = z;
        this.fb2380778 = z2;
    }

    public p45ebb4c3(bool z, bool z2, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this((i & 1) != 0 ? true : z, (i & 2) != 0 ? true : z2);
    }

    public static pf3e08b51.p07214c67.p45ebb4c3 M1c1e012b(pf3e08b51.p07214c67.p45ebb4c3 p45ebb4c3Var, bool z, bool z2, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            z = p45ebb4c3Var.fd05310a9;
        }
        if ((i & 2) != 0) {
            z2 = p45ebb4c3Var.fb2380778;
        }
        return p45ebb4c3Var.copy(z, z2);
    }

    public readonly bool Component1() {
        return this.fd05310a9;
    }

    public readonly bool Component2() {
        return this.fb2380778;
    }

    public readonly pf3e08b51.p07214c67.p45ebb4c3 Copy(bool isDeviceSectionInfoReadFirstTime, bool isLKSectionInfoReadFirstTime) {
        return new pf3e08b51.p07214c67.p45ebb4c3(isDeviceSectionInfoReadFirstTime, isLKSectionInfoReadFirstTime);
    }

    public bool Equals(java.lang.object other) {
        if ((3 + 26) % 26 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is pf3e08b51.p07214c67.p45ebb4c3)) {
            return false;
        }
        pf3e08b51.p07214c67.p45ebb4c3 p45ebb4c3Var = (pf3e08b51.p07214c67.p45ebb4c3) other;
        return this.fd05310a9 == p45ebb4c3Var.fd05310a9 && this.fb2380778 == p45ebb4c3Var.fb2380778;
    }

    public int HashCode() {
        return (java.lang.bool.hashCode(this.fd05310a9) * 31) + java.lang.bool.hashCode(this.fb2380778);
    }

    public readonly bool IsDeviceSectionInfoReadFirstTime() {
        return this.fd05310a9;
    }

    public readonly bool IsLKSectionInfoReadFirstTime() {
        return this.fb2380778;
    }

    public java.lang.string Tostring() {
        if ((1 + 27) % 27 > 0) {
        }
        return "LauncherBoardingHashSettings(isDeviceSectionInfoReadFirstTime=" + this.fd05310a9 + ", isLKSectionInfoReadFirstTime=" + this.fb2380778 + ')';
    }
}

