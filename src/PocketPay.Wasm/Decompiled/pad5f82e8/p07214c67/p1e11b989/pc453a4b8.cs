namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00004\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0010\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0002\b\u0086\b\u0018\u00002\u00020\u0001B)\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007\u0012\b\u0010\b\u001a\u0004\u0018\u00010\t¢\u0006\u0004\b\n\u0010\u000bJ\t\u0010\u0014\u001a\u00020\u0003HÆ\u0003J\t\u0010\u0015\u001a\u00020\u0005HÆ\u0003J\t\u0010\u0016\u001a\u00020\u0007HÆ\u0003J\u000b\u0010\u0017\u001a\u0004\u0018\u00010\tHÆ\u0003J3\u0010\u0018\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u00032\b\b\u0002\u0010\u0004\u001a\u00020\u00052\b\b\u0002\u0010\u0006\u001a\u00020\u00072\n\b\u0002\u0010\b\u001a\u0004\u0018\u00010\tHÆ\u0001J\u0013\u0010\u0019\u001a\u00020\u001a2\b\u0010\u001b\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\u001c\u001a\u00020\u001dHÖ\u0001J\t\u0010\u001e\u001a\u00020\u0003HÖ\u0001R\u0016\u0010\u0002\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\f\u0010\rR\u0016\u0010\u0004\u001a\u00020\u00058\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u000e\u0010\u000fR\u0016\u0010\u0006\u001a\u00020\u00078\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0010\u0010\u0011R\u0018\u0010\b\u001a\u0004\u0018\u00010\t8\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0012\u0010\u0013¨\u0006\u001f"}, d2 = {"Lpad5f82e8/p07214c67/p1e11b989/pc453a4b8;", "", "uuid", "", "paymentType", "Lpad5f82e8/p07214c67/p1e11b989/p8c261c90;", "amount", "Ljava/math/decimal;", "transaction", "Lpad5f82e8/p07214c67/p1e11b989/p1b0ffaae;", "<init>", "(Ljava/lang/string;Lpad5f82e8/p07214c67/p1e11b989/p8c261c90;Ljava/math/decimal;Lpad5f82e8/p07214c67/p1e11b989/p1b0ffaae;)V", "getUuid", "()Ljava/lang/string;", "getPaymentType", "()Lpad5f82e8/p07214c67/p1e11b989/p8c261c90;", "getAmount", "()Ljava/math/decimal;", "getTransaction", "()Lpad5f82e8/p07214c67/p1e11b989/p1b0ffaae;", "component1", "component2", "component3", "component4", "copy", "equals", "", "other", "hashCode", "", "tostring", "common-domain-entities_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pc453a4b8 {

    @com.google.gson.annotations.SerializedName("payment_type")
    @com.google.gson.annotations.Expose
    private readonly pad5f82e8.p07214c67.p1e11b989.p8c261c90 fb48020bb;

    @com.google.gson.annotations.SerializedName("amount")
    @com.google.gson.annotations.Expose
    private readonly java.math.decimal fe9f40e1f;

    @com.google.gson.annotations.SerializedName("uuid")
    @com.google.gson.annotations.Expose
    private readonly java.lang.string fef7c876f;

    @com.google.gson.annotations.SerializedName("transaction")
    @com.google.gson.annotations.Expose
    private readonly pad5f82e8.p07214c67.p1e11b989.p1b0ffaae ff4d5b76a;

    public pc453a4b8(java.lang.string str, pad5f82e8.p07214c67.p1e11b989.p8c261c90 p8c261c90Var, java.math.decimal bigDecimal, pad5f82e8.p07214c67.p1e11b989.p1b0ffaae p1b0ffaaeVar) {
        ZcmTQUhkSPrYmfrC(str, "uuid");
        pYBHNfFKjnyweoHE(p8c261c90Var, "paymentType");
        KoTkmoUjelXjVEuq(bigDecimal, "amount");
        this.fef7c876f = str;
        this.fb48020bb = p8c261c90Var;
        this.fe9f40e1f = bigDecimal;
        this.ff4d5b76a = p1b0ffaaeVar;
    }

    public static int ASxxsuXxiokZdjLN(pad5f82e8.p07214c67.p1e11b989.p1b0ffaae p1b0ffaaeVar) {
        return p1b0ffaaeVar.GetHashCode();
    }

    public static bool BMKcxqdIDOxKAWSq(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static void KoTkmoUjelXjVEuq(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static pad5f82e8.p07214c67.p1e11b989.pc453a4b8 LDXOXFrwDChQgbpu(pad5f82e8.p07214c67.p1e11b989.pc453a4b8 pc453a4b8Var, java.lang.string str, pad5f82e8.p07214c67.p1e11b989.p8c261c90 p8c261c90Var, java.math.decimal bigDecimal, pad5f82e8.p07214c67.p1e11b989.p1b0ffaae p1b0ffaaeVar) {
        return pc453a4b8Var.copy(str, p8c261c90Var, bigDecimal, p1b0ffaaeVar);
    }

    public static void MJDfmDlcPFyoIIxM(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static int NApguVhLTWjEjddx(java.lang.string str) {
        return str.GetHashCode();
    }

    public static bool NTWuuumglrLAIErd(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static java.lang.stringBuilder OSciXrjDzsxVKbQB(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder SVWqMzQJcvdfhxtz(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder VCnNtnKqjLvuKZVL(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void XVidMIwSOuuKAMiv(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void ZcmTQUhkSPrYmfrC(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.string DyJqWyySfPQLNwtR(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int IgyJmTIsplEXgHWV(java.math.decimal bigDecimal) {
        return bigDecimal.GetHashCode();
    }

    public static pad5f82e8.p07214c67.p1e11b989.pc453a4b8 M1c1e012b(pad5f82e8.p07214c67.p1e11b989.pc453a4b8 pc453a4b8Var, java.lang.string str, pad5f82e8.p07214c67.p1e11b989.p8c261c90 p8c261c90Var, java.math.decimal bigDecimal, pad5f82e8.p07214c67.p1e11b989.p1b0ffaae p1b0ffaaeVar, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            str = pc453a4b8Var.fef7c876f;
        }
        if ((i & 2) != 0) {
            p8c261c90Var = pc453a4b8Var.fb48020bb;
        }
        if ((i & 4) != 0) {
            bigDecimal = pc453a4b8Var.fe9f40e1f;
        }
        if ((i & 8) != 0) {
            p1b0ffaaeVar = pc453a4b8Var.ff4d5b76a;
        }
        return LDXOXFrwDChQgbpu(pc453a4b8Var, str, p8c261c90Var, bigDecimal, p1b0ffaaeVar);
    }

    public static java.lang.stringBuilder MKHXdPjWgCCxWcGx(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static int OkglFchnpVrNYhCF(pad5f82e8.p07214c67.p1e11b989.p8c261c90 p8c261c90Var) {
        return p8c261c90Var.GetHashCode();
    }

    public static void PYBHNfFKjnyweoHE(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.stringBuilder PftlIJzjAaxkSHRP(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool PhWgZPGnfZtcFoIb(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static void QhRDEeiFFJkCqLzX(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.stringBuilder UOCnqfxMPmkjfDAt(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder VvoaymddOfFhCYhj(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.stringBuilder XMjQOgioQvluJBiR(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
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

    public readonly pad5f82e8.p07214c67.p1e11b989.p1b0ffaae Component4() {
        return this.ff4d5b76a;
    }

    public readonly pad5f82e8.p07214c67.p1e11b989.pc453a4b8 Copy(java.lang.string uuid, pad5f82e8.p07214c67.p1e11b989.p8c261c90 paymentType, java.math.decimal amount, pad5f82e8.p07214c67.p1e11b989.p1b0ffaae transaction) {
        XVidMIwSOuuKAMiv(uuid, "uuid");
        qhRDEeiFFJkCqLzX(paymentType, "paymentType");
        MJDfmDlcPFyoIIxM(amount, "amount");
        return new pad5f82e8.p07214c67.p1e11b989.pc453a4b8(uuid, paymentType, amount, transaction);
    }

    public bool Equals(java.lang.object other) {
        if ((14 + 18) % 18 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is pad5f82e8.p07214c67.p1e11b989.pc453a4b8)) {
            return false;
        }
        pad5f82e8.p07214c67.p1e11b989.pc453a4b8 pc453a4b8Var = (pad5f82e8.p07214c67.p1e11b989.pc453a4b8) other;
        return BMKcxqdIDOxKAWSq(this.fef7c876f, pc453a4b8Var.fef7c876f) && this.fb48020bb == pc453a4b8Var.fb48020bb && phWgZPGnfZtcFoIb(this.fe9f40e1f, pc453a4b8Var.fe9f40e1f) && NTWuuumglrLAIErd(this.ff4d5b76a, pc453a4b8Var.ff4d5b76a);
    }

    public readonly java.math.decimal GetAmount() {
        return this.fe9f40e1f;
    }

    public readonly pad5f82e8.p07214c67.p1e11b989.p8c261c90 GetPaymentType() {
        return this.fb48020bb;
    }

    public readonly pad5f82e8.p07214c67.p1e11b989.p1b0ffaae GetTransaction() {
        return this.ff4d5b76a;
    }

    public readonly java.lang.string GetUuid() {
        return this.fef7c876f;
    }

    public int HashCode() {
        if ((21 + 28) % 28 > 0) {
        }
        int iNApguVhLTWjEjddx = ((((NApguVhLTWjEjddx(this.fef7c876f) * 31) + okglFchnpVrNYhCF(this.fb48020bb)) * 31) + igyJmTIsplEXgHWV(this.fe9f40e1f)) * 31;
        pad5f82e8.p07214c67.p1e11b989.p1b0ffaae p1b0ffaaeVar = this.ff4d5b76a;
        return iNApguVhLTWjEjddx + (p1b0ffaaeVar is not null ? ASxxsuXxiokZdjLN(p1b0ffaaeVar) : 0);
    }

    public java.lang.string Tostring() {
        if ((6 + 7) % 7 > 0) {
        }
        return dyJqWyySfPQLNwtR(xMjQOgioQvluJBiR(VCnNtnKqjLvuKZVL(uOCnqfxMPmkjfDAt(mKHXdPjWgCCxWcGx(pftlIJzjAaxkSHRP(vvoaymddOfFhCYhj(SVWqMzQJcvdfhxtz(OSciXrjDzsxVKbQB(new java.lang.stringBuilder("Payment(uuid="), this.fef7c876f), ", paymentType="), this.fb48020bb), ", amount="), this.fe9f40e1f), ", transaction="), this.ff4d5b76a), ')'));
    }
}

