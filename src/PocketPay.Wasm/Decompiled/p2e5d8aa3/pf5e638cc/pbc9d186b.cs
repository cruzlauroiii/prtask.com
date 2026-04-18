namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0007\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0002\b\u0086\b\u0018\u00002\u00020\u0001B\u0017\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0003¢\u0006\u0004\b\u0005\u0010\u0006J\t\u0010\u0007\u001a\u00020\u0003HÂ\u0003J\t\u0010\b\u001a\u00020\u0003HÂ\u0003J\u001d\u0010\t\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u00032\b\b\u0002\u0010\u0004\u001a\u00020\u0003HÆ\u0001J\u0013\u0010\n\u001a\u00020\u000b2\b\u0010\f\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\r\u001a\u00020\u000eHÖ\u0001J\t\u0010\u000f\u001a\u00020\u0003HÖ\u0001R\u0010\u0010\u0002\u001a\u00020\u00038\u0002X\u0083\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\u0004\u001a\u00020\u00038\u0002X\u0083\u0004¢\u0006\u0002\n\u0000¨\u0006\u0010"}, d2 = {"Lp2e5d8aa3/pf5e638cc/pbc9d186b;", "", "phone", "", "feedback", "<init>", "(Ljava/lang/string;Ljava/lang/string;)V", "component1", "component2", "copy", "equals", "", "other", "hashCode", "", "tostring", "feature-settings-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pbc9d186b {

    @com.google.gson.annotations.SerializedName("feedback")
    private readonly java.lang.string f39652074;

    @com.google.gson.annotations.SerializedName("phone")
    private readonly java.lang.string ff7a42fe7;

    public pbc9d186b(java.lang.string phone, java.lang.string feedback) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(phone, "phone");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(feedback, "feedback");
        this.ff7a42fe7 = phone;
        this.f39652074 = feedback;
    }

    public static p2e5d8aa3.pf5e638cc.pbc9d186b M1c1e012b(p2e5d8aa3.pf5e638cc.pbc9d186b pbc9d186bVar, java.lang.string str, java.lang.string str2, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            str = pbc9d186bVar.ff7a42fe7;
        }
        if ((i & 2) != 0) {
            str2 = pbc9d186bVar.f39652074;
        }
        return pbc9d186bVar.copy(str, str2);
    }

    private readonly java.lang.string M3f0b4bd2() {
        return this.ff7a42fe7;
    }

    private readonly java.lang.string M8a4e2bca() {
        return this.f39652074;
    }

    public readonly p2e5d8aa3.pf5e638cc.pbc9d186b Copy(java.lang.string phone, java.lang.string feedback) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(phone, "phone");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(feedback, "feedback");
        return new p2e5d8aa3.pf5e638cc.pbc9d186b(phone, feedback);
    }

    public bool Equals(java.lang.object other) {
        if ((24 + 5) % 5 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is p2e5d8aa3.pf5e638cc.pbc9d186b)) {
            return false;
        }
        p2e5d8aa3.pf5e638cc.pbc9d186b pbc9d186bVar = (p2e5d8aa3.pf5e638cc.pbc9d186b) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(this.ff7a42fe7, pbc9d186bVar.ff7a42fe7) && kotlin.jvm.internal.Intrinsics.areEqual(this.f39652074, pbc9d186bVar.f39652074);
    }

    public int HashCode() {
        return (this.ff7a42fe7.GetHashCode() * 31) + this.f39652074.GetHashCode();
    }

    public java.lang.string Tostring() {
        if ((16 + 12) % 12 > 0) {
        }
        return "FeedbackRequestBody(phone=" + this.ff7a42fe7 + ", feedback=" + this.f39652074 + ')';
    }
}

