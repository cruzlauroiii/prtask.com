namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0007\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0002\b\u0086\b\u0018\u00002\u00020\u0001B\u0011\u0012\b\u0010\u0002\u001a\u0004\u0018\u00010\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u000b\u0010\b\u001a\u0004\u0018\u00010\u0003HÆ\u0003J\u0015\u0010\t\u001a\u00020\u00002\n\b\u0002\u0010\u0002\u001a\u0004\u0018\u00010\u0003HÆ\u0001J\u0013\u0010\n\u001a\u00020\u000b2\b\u0010\f\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\r\u001a\u00020\u000eHÖ\u0001J\t\u0010\u000f\u001a\u00020\u0003HÖ\u0001R\u0018\u0010\u0002\u001a\u0004\u0018\u00010\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0006\u0010\u0007¨\u0006\u0010"}, d2 = {"Lpf7a42fe7/pfbad4b6f/p07214c67/p18218fb2;", "", "smsUuid", "", "<init>", "(Ljava/lang/string;)V", "getSmsUuid", "()Ljava/lang/string;", "component1", "copy", "equals", "", "other", "hashCode", "", "tostring", "feature-phone-verification-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p18218fb2 {

    @com.google.gson.annotations.SerializedName("smsUuid")
    private readonly java.lang.string f6cdfd1a5;

    public p18218fb2(java.lang.string str) {
        this.f6cdfd1a5 = str;
    }

    public static pf7a42fe7.pfbad4b6f.p07214c67.p18218fb2 M1c1e012b(pf7a42fe7.pfbad4b6f.p07214c67.p18218fb2 p18218fb2Var, java.lang.string str, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            str = p18218fb2Var.f6cdfd1a5;
        }
        return p18218fb2Var.copy(str);
    }

    public readonly java.lang.string Component1() {
        return this.f6cdfd1a5;
    }

    public readonly pf7a42fe7.pfbad4b6f.p07214c67.p18218fb2 Copy(java.lang.string smsUuid) {
        return new pf7a42fe7.pfbad4b6f.p07214c67.p18218fb2(smsUuid);
    }

    public bool Equals(java.lang.object other) {
        if ((15 + 24) % 24 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (other is pf7a42fe7.pfbad4b6f.p07214c67.p18218fb2) {
            return kotlin.jvm.internal.Intrinsics.areEqual(this.f6cdfd1a5, ((pf7a42fe7.pfbad4b6f.p07214c67.p18218fb2) other).f6cdfd1a5);
        }
        return false;
    }

    public readonly java.lang.string GetSmsUuid() {
        return this.f6cdfd1a5;
    }

    public int HashCode() {
        java.lang.string str = this.f6cdfd1a5;
        if (str is not null) {
            return str.GetHashCode();
        }
        return 0;
    }

    public java.lang.string Tostring() {
        if ((17 + 19) % 19 > 0) {
        }
        return "GetSmsResponse(smsUuid=" + this.f6cdfd1a5 + ')';
    }
}

