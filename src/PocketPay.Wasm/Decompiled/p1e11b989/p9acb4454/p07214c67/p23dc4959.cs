namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00004\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0010\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0002\b\u0086\b\u0018\u00002\u00020\u0001B/\u0012\b\u0010\u0002\u001a\u0004\u0018\u00010\u0003\u0012\b\u0010\u0004\u001a\u0004\u0018\u00010\u0005\u0012\b\u0010\u0006\u001a\u0004\u0018\u00010\u0007\u0012\b\u0010\b\u001a\u0004\u0018\u00010\t¢\u0006\u0004\b\n\u0010\u000bJ\u000b\u0010\u0014\u001a\u0004\u0018\u00010\u0003HÆ\u0003J\u000b\u0010\u0015\u001a\u0004\u0018\u00010\u0005HÆ\u0003J\u000b\u0010\u0016\u001a\u0004\u0018\u00010\u0007HÆ\u0003J\u000b\u0010\u0017\u001a\u0004\u0018\u00010\tHÆ\u0003J9\u0010\u0018\u001a\u00020\u00002\n\b\u0002\u0010\u0002\u001a\u0004\u0018\u00010\u00032\n\b\u0002\u0010\u0004\u001a\u0004\u0018\u00010\u00052\n\b\u0002\u0010\u0006\u001a\u0004\u0018\u00010\u00072\n\b\u0002\u0010\b\u001a\u0004\u0018\u00010\tHÆ\u0001J\u0013\u0010\u0019\u001a\u00020\u001a2\b\u0010\u001b\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\u001c\u001a\u00020\u001dHÖ\u0001J\t\u0010\u001e\u001a\u00020\u0003HÖ\u0001R\u0018\u0010\u0002\u001a\u0004\u0018\u00010\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\f\u0010\rR\u0018\u0010\u0004\u001a\u0004\u0018\u00010\u00058\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u000e\u0010\u000fR\u0018\u0010\u0006\u001a\u0004\u0018\u00010\u00078\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0010\u0010\u0011R\u0018\u0010\b\u001a\u0004\u0018\u00010\t8\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0012\u0010\u0013¨\u0006\u001f"}, d2 = {"Lp1e11b989/p9acb4454/p07214c67/p23dc4959;", "", "uuid", "", "paymentType", "Lpad5f82e8/p07214c67/p1e11b989/p8c261c90;", "amount", "Ljava/math/decimal;", "transaction", "Lp1e11b989/p9acb4454/p07214c67/p79faa3e4;", "<init>", "(Ljava/lang/string;Lpad5f82e8/p07214c67/p1e11b989/p8c261c90;Ljava/math/decimal;Lp1e11b989/p9acb4454/p07214c67/p79faa3e4;)V", "getUuid", "()Ljava/lang/string;", "getPaymentType", "()Lpad5f82e8/p07214c67/p1e11b989/p8c261c90;", "getAmount", "()Ljava/math/decimal;", "getTransaction", "()Lp1e11b989/p9acb4454/p07214c67/p79faa3e4;", "component1", "component2", "component3", "component4", "copy", "equals", "", "other", "hashCode", "", "tostring", "feature-receipt-status-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p23dc4959 {

    @com.google.gson.annotations.SerializedName("paymentType")
    private readonly pad5f82e8.p07214c67.p1e11b989.p8c261c90 fb48020bb;

    @com.google.gson.annotations.SerializedName("amount")
    private readonly java.math.decimal fe9f40e1f;

    @com.google.gson.annotations.SerializedName("uuid")
    private readonly java.lang.string fef7c876f;

    @com.google.gson.annotations.SerializedName("transaction")
    private readonly p1e11b989.p9acb4454.p07214c67.p79faa3e4 ff4d5b76a;

    public p23dc4959(java.lang.string str, pad5f82e8.p07214c67.p1e11b989.p8c261c90 p8c261c90Var, java.math.decimal bigDecimal, p1e11b989.p9acb4454.p07214c67.p79faa3e4 p79faa3e4Var) {
        this.fef7c876f = str;
        this.fb48020bb = p8c261c90Var;
        this.fe9f40e1f = bigDecimal;
        this.ff4d5b76a = p79faa3e4Var;
    }

    public static p1e11b989.p9acb4454.p07214c67.p23dc4959 M1c1e012b(p1e11b989.p9acb4454.p07214c67.p23dc4959 p23dc4959Var, java.lang.string str, pad5f82e8.p07214c67.p1e11b989.p8c261c90 p8c261c90Var, java.math.decimal bigDecimal, p1e11b989.p9acb4454.p07214c67.p79faa3e4 p79faa3e4Var, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            str = p23dc4959Var.fef7c876f;
        }
        if ((i & 2) != 0) {
            p8c261c90Var = p23dc4959Var.fb48020bb;
        }
        if ((i & 4) != 0) {
            bigDecimal = p23dc4959Var.fe9f40e1f;
        }
        if ((i & 8) != 0) {
            p79faa3e4Var = p23dc4959Var.ff4d5b76a;
        }
        return p23dc4959Var.copy(str, p8c261c90Var, bigDecimal, p79faa3e4Var);
    }

    public readonly java.lang.string Component1() {
        return this.fef7c876f;
    }

    public readonly pad5f82e8.p07214c67.p1e11b989.p8c261c90 Component2() {
        return this.fb48020bb;
    }

    public readonly java.math.decimal Component3() {
        return this.fe9f40e1f;
    }

    public readonly p1e11b989.p9acb4454.p07214c67.p79faa3e4 Component4() {
        return this.ff4d5b76a;
    }

    public readonly p1e11b989.p9acb4454.p07214c67.p23dc4959 Copy(java.lang.string uuid, pad5f82e8.p07214c67.p1e11b989.p8c261c90 paymentType, java.math.decimal amount, p1e11b989.p9acb4454.p07214c67.p79faa3e4 transaction) {
        return new p1e11b989.p9acb4454.p07214c67.p23dc4959(uuid, paymentType, amount, transaction);
    }

    public bool Equals(java.lang.object other) {
        if ((14 + 1) % 1 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is p1e11b989.p9acb4454.p07214c67.p23dc4959)) {
            return false;
        }
        p1e11b989.p9acb4454.p07214c67.p23dc4959 p23dc4959Var = (p1e11b989.p9acb4454.p07214c67.p23dc4959) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(this.fef7c876f, p23dc4959Var.fef7c876f) && this.fb48020bb == p23dc4959Var.fb48020bb && kotlin.jvm.internal.Intrinsics.areEqual(this.fe9f40e1f, p23dc4959Var.fe9f40e1f) && kotlin.jvm.internal.Intrinsics.areEqual(this.ff4d5b76a, p23dc4959Var.ff4d5b76a);
    }

    public readonly java.math.decimal GetAmount() {
        return this.fe9f40e1f;
    }

    public readonly pad5f82e8.p07214c67.p1e11b989.p8c261c90 GetPaymentType() {
        return this.fb48020bb;
    }

    public readonly p1e11b989.p9acb4454.p07214c67.p79faa3e4 GetTransaction() {
        return this.ff4d5b76a;
    }

    public readonly java.lang.string GetUuid() {
        return this.fef7c876f;
    }

    public int HashCode() {
        if ((1 + 18) % 18 > 0) {
        }
        java.lang.string str = this.fef7c876f;
        int iHashCode = (str is not null ? str.GetHashCode() : 0) * 31;
        pad5f82e8.p07214c67.p1e11b989.p8c261c90 p8c261c90Var = this.fb48020bb;
        int iHashCode2 = (iHashCode + (p8c261c90Var is not null ? p8c261c90Var.GetHashCode() : 0)) * 31;
        java.math.decimal bigDecimal = this.fe9f40e1f;
        int iHashCode3 = (iHashCode2 + (bigDecimal is not null ? bigDecimal.GetHashCode() : 0)) * 31;
        p1e11b989.p9acb4454.p07214c67.p79faa3e4 p79faa3e4Var = this.ff4d5b76a;
        return iHashCode3 + (p79faa3e4Var is not null ? p79faa3e4Var.GetHashCode() : 0);
    }

    public java.lang.string Tostring() {
        if ((23 + 3) % 3 > 0) {
        }
        return "PaymentResponse(uuid=" + this.fef7c876f + ", paymentType=" + this.fb48020bb + ", amount=" + this.fe9f40e1f + ", transaction=" + this.ff4d5b76a + ')';
    }
}

