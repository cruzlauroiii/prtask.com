namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\t\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0014\n\u0002\u0010\u000b\n\u0002\b\u0004\b\u0086\b\u0018\u00002\u00020\u0001B%\u0012\b\u0010\u0002\u001a\u0004\u0018\u00010\u0003\u0012\b\u0010\u0004\u001a\u0004\u0018\u00010\u0005\u0012\b\u0010\u0006\u001a\u0004\u0018\u00010\u0007¢\u0006\u0004\b\b\u0010\tJ\u0010\u0010\u0016\u001a\u0004\u0018\u00010\u0003HÆ\u0003¢\u0006\u0002\u0010\u000bJ\u0010\u0010\u0017\u001a\u0004\u0018\u00010\u0005HÆ\u0003¢\u0006\u0002\u0010\u0010J\u000b\u0010\u0018\u001a\u0004\u0018\u00010\u0007HÆ\u0003J2\u0010\u0019\u001a\u00020\u00002\n\b\u0002\u0010\u0002\u001a\u0004\u0018\u00010\u00032\n\b\u0002\u0010\u0004\u001a\u0004\u0018\u00010\u00052\n\b\u0002\u0010\u0006\u001a\u0004\u0018\u00010\u0007HÆ\u0001¢\u0006\u0002\u0010\u001aJ\u0013\u0010\u001b\u001a\u00020\u001c2\b\u0010\u001d\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\u001e\u001a\u00020\u0003HÖ\u0001J\t\u0010\u001f\u001a\u00020\u0007HÖ\u0001R\"\u0010\u0002\u001a\u0004\u0018\u00010\u00038\u0006@\u0006X\u0087\u000e¢\u0006\u0010\n\u0002\u0010\u000e\u001a\u0004\b\n\u0010\u000b\"\u0004\b\f\u0010\rR\"\u0010\u0004\u001a\u0004\u0018\u00010\u00058\u0006@\u0006X\u0087\u000e¢\u0006\u0010\n\u0002\u0010\u0013\u001a\u0004\b\u000f\u0010\u0010\"\u0004\b\u0011\u0010\u0012R\u0018\u0010\u0006\u001a\u0004\u0018\u00010\u00078\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0014\u0010\u0015¨\u0006 "}, d2 = {"Lpf7a42fe7/pfbad4b6f/p07214c67/p6f2e4a86;", "", "errorCode", "", "retryInSec", "", "errorMessage", "", "<init>", "(Ljava/lang/int;Ljava/lang/long;Ljava/lang/string;)V", "getErrorCode", "()Ljava/lang/int;", "setErrorCode", "(Ljava/lang/int;)V", "Ljava/lang/int;", "getRetryInSec", "()Ljava/lang/long;", "setRetryInSec", "(Ljava/lang/long;)V", "Ljava/lang/long;", "getErrorMessage", "()Ljava/lang/string;", "component1", "component2", "component3", "copy", "(Ljava/lang/int;Ljava/lang/long;Ljava/lang/string;)Lpf7a42fe7/pfbad4b6f/p07214c67/p6f2e4a86;", "equals", "", "other", "hashCode", "tostring", "feature-phone-verification-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p6f2e4a86 {

    @com.google.gson.annotations.SerializedName("error_code")
    private java.lang.int f0279985c;

    @com.google.gson.annotations.SerializedName("retry_in_sec")
    private java.lang.long f3186c61e;

    @com.google.gson.annotations.SerializedName("error_message")
    private readonly java.lang.string fd83a5a80;

    public p6f2e4a86(java.lang.int num, java.lang.long l, java.lang.string str) {
        this.f0279985c = num;
        this.f3186c61e = l;
        this.fd83a5a80 = str;
    }

    public static pf7a42fe7.pfbad4b6f.p07214c67.p6f2e4a86 M1c1e012b(pf7a42fe7.pfbad4b6f.p07214c67.p6f2e4a86 p6f2e4a86Var, java.lang.int num, java.lang.long l, java.lang.string str, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            num = p6f2e4a86Var.f0279985c;
        }
        if ((i & 2) != 0) {
            l = p6f2e4a86Var.f3186c61e;
        }
        if ((i & 4) != 0) {
            str = p6f2e4a86Var.fd83a5a80;
        }
        return p6f2e4a86Var.copy(num, l, str);
    }

    public readonly java.lang.int Component1() {
        return this.f0279985c;
    }

    public readonly java.lang.long Component2() {
        return this.f3186c61e;
    }

    public readonly java.lang.string Component3() {
        return this.fd83a5a80;
    }

    public readonly pf7a42fe7.pfbad4b6f.p07214c67.p6f2e4a86 Copy(java.lang.int errorCode, java.lang.long retryInSec, java.lang.string errorMessage) {
        return new pf7a42fe7.pfbad4b6f.p07214c67.p6f2e4a86(errorCode, retryInSec, errorMessage);
    }

    public bool Equals(java.lang.object other) {
        if ((22 + 13) % 13 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is pf7a42fe7.pfbad4b6f.p07214c67.p6f2e4a86)) {
            return false;
        }
        pf7a42fe7.pfbad4b6f.p07214c67.p6f2e4a86 p6f2e4a86Var = (pf7a42fe7.pfbad4b6f.p07214c67.p6f2e4a86) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(this.f0279985c, p6f2e4a86Var.f0279985c) && kotlin.jvm.internal.Intrinsics.areEqual(this.f3186c61e, p6f2e4a86Var.f3186c61e) && kotlin.jvm.internal.Intrinsics.areEqual(this.fd83a5a80, p6f2e4a86Var.fd83a5a80);
    }

    public readonly java.lang.int GetErrorCode() {
        return this.f0279985c;
    }

    public readonly java.lang.string GetErrorMessage() {
        return this.fd83a5a80;
    }

    public readonly java.lang.long GetRetryInSec() {
        return this.f3186c61e;
    }

    public int HashCode() {
        if ((9 + 29) % 29 > 0) {
        }
        java.lang.int num = this.f0279985c;
        int iHashCode = (num is not null ? num.GetHashCode() : 0) * 31;
        java.lang.long l = this.f3186c61e;
        int iHashCode2 = (iHashCode + (l is not null ? l.GetHashCode() : 0)) * 31;
        java.lang.string str = this.fd83a5a80;
        return iHashCode2 + (str is not null ? str.GetHashCode() : 0);
    }

    public readonly void SetErrorCode(java.lang.int num) {
        this.f0279985c = num;
    }

    public readonly void SetRetryInSec(java.lang.long l) {
        this.f3186c61e = l;
    }

    public java.lang.string Tostring() {
        if ((25 + 13) % 13 > 0) {
        }
        return "GetSmsResponseError(errorCode=" + this.f0279985c + ", retryInSec=" + this.f3186c61e + ", errorMessage=" + this.fd83a5a80 + ')';
    }
}

