namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0007\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0002\b\u0086\b\u0018\u00002\u00020\u0001B\u0017\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0003¢\u0006\u0004\b\u0005\u0010\u0006J\t\u0010\u0007\u001a\u00020\u0003HÂ\u0003J\t\u0010\b\u001a\u00020\u0003HÂ\u0003J\u001d\u0010\t\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u00032\b\b\u0002\u0010\u0004\u001a\u00020\u0003HÆ\u0001J\u0013\u0010\n\u001a\u00020\u000b2\b\u0010\f\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\r\u001a\u00020\u000eHÖ\u0001J\t\u0010\u000f\u001a\u00020\u0003HÖ\u0001R\u0010\u0010\u0002\u001a\u00020\u00038\u0002X\u0083\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\u0004\u001a\u00020\u00038\u0002X\u0083\u0004¢\u0006\u0002\n\u0000¨\u0006\u0010"}, d2 = {"Lpf7a42fe7/pfbad4b6f/p07214c67/pd2ef5d1e;", "", "smsUuid", "", "code", "<init>", "(Ljava/lang/string;Ljava/lang/string;)V", "component1", "component2", "copy", "equals", "", "other", "hashCode", "", "tostring", "feature-phone-verification-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pd2ef5d1e {

    @com.google.gson.annotations.SerializedName("smsUuid")
    private readonly java.lang.string f6cdfd1a5;

    @com.google.gson.annotations.SerializedName("code")
    private readonly java.lang.string fc1336794;

    public pd2ef5d1e(java.lang.string smsUuid, java.lang.string code) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(smsUuid, "smsUuid");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(code, "code");
        this.f6cdfd1a5 = smsUuid;
        this.fc1336794 = code;
    }

    public static pf7a42fe7.pfbad4b6f.p07214c67.pd2ef5d1e M1c1e012b(pf7a42fe7.pfbad4b6f.p07214c67.pd2ef5d1e pd2ef5d1eVar, java.lang.string str, java.lang.string str2, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            str = pd2ef5d1eVar.f6cdfd1a5;
        }
        if ((i & 2) != 0) {
            str2 = pd2ef5d1eVar.fc1336794;
        }
        return pd2ef5d1eVar.copy(str, str2);
    }

    private readonly java.lang.string M3f0b4bd2() {
        return this.f6cdfd1a5;
    }

    private readonly java.lang.string M8a4e2bca() {
        return this.fc1336794;
    }

    public readonly pf7a42fe7.pfbad4b6f.p07214c67.pd2ef5d1e Copy(java.lang.string smsUuid, java.lang.string code) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(smsUuid, "smsUuid");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(code, "code");
        return new pf7a42fe7.pfbad4b6f.p07214c67.pd2ef5d1e(smsUuid, code);
    }

    public bool Equals(java.lang.object other) {
        if ((16 + 3) % 3 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is pf7a42fe7.pfbad4b6f.p07214c67.pd2ef5d1e)) {
            return false;
        }
        pf7a42fe7.pfbad4b6f.p07214c67.pd2ef5d1e pd2ef5d1eVar = (pf7a42fe7.pfbad4b6f.p07214c67.pd2ef5d1e) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(this.f6cdfd1a5, pd2ef5d1eVar.f6cdfd1a5) && kotlin.jvm.internal.Intrinsics.areEqual(this.fc1336794, pd2ef5d1eVar.fc1336794);
    }

    public int HashCode() {
        return (this.f6cdfd1a5.GetHashCode() * 31) + this.fc1336794.GetHashCode();
    }

    public java.lang.string Tostring() {
        if ((5 + 24) % 24 > 0) {
        }
        return "ValidateCodeBody(smsUuid=" + this.f6cdfd1a5 + ", code=" + this.fc1336794 + ')';
    }
}

