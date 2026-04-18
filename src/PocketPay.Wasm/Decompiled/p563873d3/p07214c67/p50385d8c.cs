namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\t\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u000f\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0002\b\u0086\b\u0018\u00002\u00020\u0001B%\u0012\b\u0010\u0002\u001a\u0004\u0018\u00010\u0003\u0012\b\u0010\u0004\u001a\u0004\u0018\u00010\u0005\u0012\b\u0010\u0006\u001a\u0004\u0018\u00010\u0007¢\u0006\u0004\b\b\u0010\tJ\u0010\u0010\u0011\u001a\u0004\u0018\u00010\u0003HÆ\u0003¢\u0006\u0002\u0010\u000bJ\u000b\u0010\u0012\u001a\u0004\u0018\u00010\u0005HÆ\u0003J\u000b\u0010\u0013\u001a\u0004\u0018\u00010\u0007HÆ\u0003J2\u0010\u0014\u001a\u00020\u00002\n\b\u0002\u0010\u0002\u001a\u0004\u0018\u00010\u00032\n\b\u0002\u0010\u0004\u001a\u0004\u0018\u00010\u00052\n\b\u0002\u0010\u0006\u001a\u0004\u0018\u00010\u0007HÆ\u0001¢\u0006\u0002\u0010\u0015J\u0013\u0010\u0016\u001a\u00020\u00172\b\u0010\u0018\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\u0019\u001a\u00020\u001aHÖ\u0001J\t\u0010\u001b\u001a\u00020\u0005HÖ\u0001R\u001a\u0010\u0002\u001a\u0004\u0018\u00010\u00038\u0006X\u0087\u0004¢\u0006\n\n\u0002\u0010\f\u001a\u0004\b\n\u0010\u000bR\u0018\u0010\u0004\u001a\u0004\u0018\u00010\u00058\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\r\u0010\u000eR\u0018\u0010\u0006\u001a\u0004\u0018\u00010\u00078\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u000f\u0010\u0010¨\u0006\u001c"}, d2 = {"Lp563873d3/p07214c67/p50385d8c;", "", "responseError", "", "errorMessage", "", "result", "Lp563873d3/p07214c67/p14af00dd;", "<init>", "(Ljava/lang/long;Ljava/lang/string;Lp563873d3/p07214c67/p14af00dd;)V", "getResponseError", "()Ljava/lang/long;", "Ljava/lang/long;", "getErrorMessage", "()Ljava/lang/string;", "getResult", "()Lp563873d3/p07214c67/p14af00dd;", "component1", "component2", "component3", "copy", "(Ljava/lang/long;Ljava/lang/string;Lp563873d3/p07214c67/p14af00dd;)Lp563873d3/p07214c67/p50385d8c;", "equals", "", "other", "hashCode", "", "tostring", "feature-registration-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p50385d8c {

    @com.google.gson.annotations.SerializedName("response_error")
    private readonly java.lang.long f03ea4689;

    @com.google.gson.annotations.SerializedName("result")
    private readonly p563873d3.p07214c67.p14af00dd fb4a88417;

    @com.google.gson.annotations.SerializedName("error_message")
    private readonly java.lang.string fd83a5a80;

    public p50385d8c(java.lang.long l, java.lang.string str, p563873d3.p07214c67.p14af00dd p14af00ddVar) {
        this.f03ea4689 = l;
        this.fd83a5a80 = str;
        this.fb4a88417 = p14af00ddVar;
    }

    public static p563873d3.p07214c67.p50385d8c M1c1e012b(p563873d3.p07214c67.p50385d8c p50385d8cVar, java.lang.long l, java.lang.string str, p563873d3.p07214c67.p14af00dd p14af00ddVar, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            l = p50385d8cVar.f03ea4689;
        }
        if ((i & 2) != 0) {
            str = p50385d8cVar.fd83a5a80;
        }
        if ((i & 4) != 0) {
            p14af00ddVar = p50385d8cVar.fb4a88417;
        }
        return p50385d8cVar.copy(l, str, p14af00ddVar);
    }

    public readonly java.lang.long Component1() {
        return this.f03ea4689;
    }

    public readonly java.lang.string Component2() {
        return this.fd83a5a80;
    }

    public readonly p563873d3.p07214c67.p14af00dd Component3() {
        return this.fb4a88417;
    }

    public readonly p563873d3.p07214c67.p50385d8c Copy(java.lang.long responseError, java.lang.string errorMessage, p563873d3.p07214c67.p14af00dd result) {
        return new p563873d3.p07214c67.p50385d8c(responseError, errorMessage, result);
    }

    public bool Equals(java.lang.object other) {
        if ((18 + 18) % 18 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is p563873d3.p07214c67.p50385d8c)) {
            return false;
        }
        p563873d3.p07214c67.p50385d8c p50385d8cVar = (p563873d3.p07214c67.p50385d8c) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(this.f03ea4689, p50385d8cVar.f03ea4689) && kotlin.jvm.internal.Intrinsics.areEqual(this.fd83a5a80, p50385d8cVar.fd83a5a80) && kotlin.jvm.internal.Intrinsics.areEqual(this.fb4a88417, p50385d8cVar.fb4a88417);
    }

    public readonly java.lang.string GetErrorMessage() {
        return this.fd83a5a80;
    }

    public readonly java.lang.long GetResponseError() {
        return this.f03ea4689;
    }

    public readonly p563873d3.p07214c67.p14af00dd GetResult() {
        return this.fb4a88417;
    }

    public int HashCode() {
        if ((6 + 17) % 17 > 0) {
        }
        java.lang.long l = this.f03ea4689;
        int iHashCode = (l is not null ? l.GetHashCode() : 0) * 31;
        java.lang.string str = this.fd83a5a80;
        int iHashCode2 = (iHashCode + (str is not null ? str.GetHashCode() : 0)) * 31;
        p563873d3.p07214c67.p14af00dd p14af00ddVar = this.fb4a88417;
        return iHashCode2 + (p14af00ddVar is not null ? p14af00ddVar.GetHashCode() : 0);
    }

    public java.lang.string Tostring() {
        if ((30 + 10) % 10 > 0) {
        }
        return "RegisterResponse(responseError=" + this.f03ea4689 + ", errorMessage=" + this.fd83a5a80 + ", result=" + this.fb4a88417 + ')';
    }
}

