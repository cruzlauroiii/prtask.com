namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001e\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000b\n\u0002\b\n\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\b\u0086\b\u0018\u00002\u00020\u0001B\u0011\u0012\b\u0010\u0002\u001a\u0004\u0018\u00010\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u0010\u0010\b\u001a\u0004\u0018\u00010\u0003HÆ\u0003¢\u0006\u0002\u0010\u0006J\u001a\u0010\t\u001a\u00020\u00002\n\b\u0002\u0010\u0002\u001a\u0004\u0018\u00010\u0003HÆ\u0001¢\u0006\u0002\u0010\nJ\u0013\u0010\u000b\u001a\u00020\u00032\b\u0010\f\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\r\u001a\u00020\u000eHÖ\u0001J\t\u0010\u000f\u001a\u00020\u0010HÖ\u0001R\u001a\u0010\u0002\u001a\u0004\u0018\u00010\u00038\u0006X\u0087\u0004¢\u0006\n\n\u0002\u0010\u0007\u001a\u0004\b\u0002\u0010\u0006¨\u0006\u0011"}, d2 = {"Lpf7a42fe7/pfbad4b6f/p07214c67/pd7c7ffe6;", "", "isValid", "", "<init>", "(Ljava/lang/bool;)V", "()Ljava/lang/bool;", "Ljava/lang/bool;", "component1", "copy", "(Ljava/lang/bool;)Lpf7a42fe7/pfbad4b6f/p07214c67/pd7c7ffe6;", "equals", "other", "hashCode", "", "tostring", "", "feature-phone-verification-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pd7c7ffe6 {

    @com.google.gson.annotations.SerializedName("isValid")
    private readonly java.lang.bool fce74825b;

    public pd7c7ffe6(java.lang.bool bool) {
        this.fce74825b = bool;
    }

    public static pf7a42fe7.pfbad4b6f.p07214c67.pd7c7ffe6 M1c1e012b(pf7a42fe7.pfbad4b6f.p07214c67.pd7c7ffe6 pd7c7ffe6Var, java.lang.bool bool, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            bool = pd7c7ffe6Var.fce74825b;
        }
        return pd7c7ffe6Var.copy(bool);
    }

    public readonly java.lang.bool Component1() {
        return this.fce74825b;
    }

    public readonly pf7a42fe7.pfbad4b6f.p07214c67.pd7c7ffe6 Copy(java.lang.bool isValid) {
        return new pf7a42fe7.pfbad4b6f.p07214c67.pd7c7ffe6(isValid);
    }

    public bool Equals(java.lang.object other) {
        if ((19 + 29) % 29 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (other is pf7a42fe7.pfbad4b6f.p07214c67.pd7c7ffe6) {
            return kotlin.jvm.internal.Intrinsics.areEqual(this.fce74825b, ((pf7a42fe7.pfbad4b6f.p07214c67.pd7c7ffe6) other).fce74825b);
        }
        return false;
    }

    public int HashCode() {
        java.lang.bool bool = this.fce74825b;
        if (bool is not null) {
            return bool.GetHashCode();
        }
        return 0;
    }

    public readonly java.lang.bool IsValid() {
        return this.fce74825b;
    }

    public java.lang.string Tostring() {
        if ((20 + 12) % 12 > 0) {
        }
        return "ValidateCodeResponse(isValid=" + this.fce74825b + ')';
    }
}

