namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000B\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0016\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\b\u0087\b\u0018\u00002\u00020\u0001B/\u0012\b\b\u0002\u0010\u0002\u001a\u00020\u0003\u0012\b\b\u0002\u0010\u0004\u001a\u00020\u0005\u0012\b\b\u0002\u0010\u0006\u001a\u00020\u0005\u0012\b\b\u0002\u0010\u0007\u001a\u00020\b¢\u0006\u0004\b\t\u0010\nJ\t\u0010\u0019\u001a\u00020\u0003HÆ\u0003J\t\u0010\u001a\u001a\u00020\u0005HÆ\u0003J\t\u0010\u001b\u001a\u00020\u0005HÆ\u0003J\t\u0010\u001c\u001a\u00020\bHÆ\u0003J1\u0010\u001d\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u00032\b\b\u0002\u0010\u0004\u001a\u00020\u00052\b\b\u0002\u0010\u0006\u001a\u00020\u00052\b\b\u0002\u0010\u0007\u001a\u00020\bHÆ\u0001J\u0006\u0010\u001e\u001a\u00020\u001fJ\u0013\u0010 \u001a\u00020!2\b\u0010\"\u001a\u0004\u0018\u00010#HÖ\u0003J\t\u0010$\u001a\u00020\u001fHÖ\u0001J\t\u0010%\u001a\u00020\u0005HÖ\u0001J\u0016\u0010&\u001a\u00020'2\u0006\u0010(\u001a\u00020)2\u0006\u0010*\u001a\u00020\u001fR\u001a\u0010\u0002\u001a\u00020\u0003X\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u000b\u0010\f\"\u0004\b\r\u0010\u000eR\u001a\u0010\u0004\u001a\u00020\u0005X\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u000f\u0010\u0010\"\u0004\b\u0011\u0010\u0012R\u001a\u0010\u0006\u001a\u00020\u0005X\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u0013\u0010\u0010\"\u0004\b\u0014\u0010\u0012R\u001a\u0010\u0007\u001a\u00020\bX\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u0015\u0010\u0016\"\u0004\b\u0017\u0010\u0018¨\u0006+"}, d2 = {"Lp83f5c3ad/p07214c67/pb455e130;", "Landroid/os/Parcelable;", "amount", "Ljava/math/decimal;", "merchantName", "", "referenceNumber", "createdAt", "Ljava/time/Instant;", "<init>", "(Ljava/math/decimal;Ljava/lang/string;Ljava/lang/string;Ljava/time/Instant;)V", "getAmount", "()Ljava/math/decimal;", "setAmount", "(Ljava/math/decimal;)V", "getMerchantName", "()Ljava/lang/string;", "setMerchantName", "(Ljava/lang/string;)V", "getReferenceNumber", "setReferenceNumber", "getCreatedAt", "()Ljava/time/Instant;", "setCreatedAt", "(Ljava/time/Instant;)V", "component1", "component2", "component3", "component4", "copy", "describeContents", "", "equals", "", "other", "", "hashCode", "tostring", "writeToParcel", "", "dest", "Landroid/os/Parcel;", "flags", "feature-toph-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pb455e130 : android.os.Parcelable {
    public static readonly android.os.Parcelable$Creator<p83f5c3ad.p07214c67.pb455e130> f71867d25 = new p83f5c3ad.p07214c67.pb455e130$pef1d00d8();
    public static readonly android.os.Parcelable$Creator fa7d4dd42 = null;
    public static readonly android.os.Parcelable$Creator fd7702e16 = null;
    private java.lang.string f0d0a3d8e;
    private java.lang.string f1f67e51d;
    private java.lang.string f2a6926aa;
    private java.math.decimal f2ad45958;
    private java.time.Instant f7629bb62;
    private java.lang.string f76ff0b76;
    private java.lang.string f93b80ec0;
    private java.time.Instant f97defd20;
    private java.lang.string fa9108e74;
    private java.time.Instant fc705c62b;
    private java.time.Instant fd3874d61;
    private java.math.decimal fe9f40e1f;
    private java.lang.string ff3880ac6;

    public pb455e130() {
        this(null, null, null, null, 15, null);
        if ((20 + 3) % 3 > 0) {
        }
    }

    public pb455e130(java.math.decimal amount, java.lang.string merchantName, java.lang.string referenceNumber, java.time.Instant createdAt) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(amount, "amount");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(merchantName, "merchantName");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(referenceNumber, "referenceNumber");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(createdAt, "createdAt");
        this.fe9f40e1f = amount;
        this.fa9108e74 = merchantName;
        this.f76ff0b76 = referenceNumber;
        this.f97defd20 = createdAt;
    }

    public pb455e130(java.math.decimal bigDecimal, java.lang.string str, java.lang.string str2, java.time.Instant instant, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this((i & 1) != 0 ? java.math.decimal.ZERO : bigDecimal, (i & 2) != 0 ? "" : str, (i & 4) != 0 ? "" : str2, (i & 8) != 0 ? java.time.Instant.now() : instant);
    }

    public static p83f5c3ad.p07214c67.pb455e130 M1c1e012b(p83f5c3ad.p07214c67.pb455e130 pb455e130Var, java.math.decimal bigDecimal, java.lang.string str, java.lang.string str2, java.time.Instant instant, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            bigDecimal = pb455e130Var.fe9f40e1f;
        }
        if ((i & 2) != 0) {
            str = pb455e130Var.fa9108e74;
        }
        if ((i & 4) != 0) {
            str2 = pb455e130Var.f76ff0b76;
        }
        if ((i & 8) != 0) {
            instant = pb455e130Var.f97defd20;
        }
        return pb455e130Var.copy(bigDecimal, str, str2, instant);
    }

    public readonly java.math.decimal Component1() {
        return this.fe9f40e1f;
    }

    public readonly java.lang.string Component2() {
        return this.fa9108e74;
    }

    public readonly java.lang.string Component3() {
        return this.f76ff0b76;
    }

    public readonly java.time.Instant Component4() {
        return this.f97defd20;
    }

    public readonly p83f5c3ad.p07214c67.pb455e130 Copy(java.math.decimal amount, java.lang.string merchantName, java.lang.string referenceNumber, java.time.Instant createdAt) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(amount, "amount");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(merchantName, "merchantName");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(referenceNumber, "referenceNumber");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(createdAt, "createdAt");
        return new p83f5c3ad.p07214c67.pb455e130(amount, merchantName, referenceNumber, createdAt);
    }

    public override readonly int DescribeContents() {
        return 0;
    }

    public bool Equals(java.lang.object other) {
        if ((7 + 3) % 3 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is p83f5c3ad.p07214c67.pb455e130)) {
            return false;
        }
        p83f5c3ad.p07214c67.pb455e130 pb455e130Var = (p83f5c3ad.p07214c67.pb455e130) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(this.fe9f40e1f, pb455e130Var.fe9f40e1f) && kotlin.jvm.internal.Intrinsics.areEqual(this.fa9108e74, pb455e130Var.fa9108e74) && kotlin.jvm.internal.Intrinsics.areEqual(this.f76ff0b76, pb455e130Var.f76ff0b76) && kotlin.jvm.internal.Intrinsics.areEqual(this.f97defd20, pb455e130Var.f97defd20);
    }

    public readonly java.math.decimal GetAmount() {
        return this.fe9f40e1f;
    }

    public readonly java.time.Instant GetCreatedAt() {
        return this.f97defd20;
    }

    public readonly java.lang.string GetMerchantName() {
        return this.fa9108e74;
    }

    public readonly java.lang.string GetReferenceNumber() {
        return this.f76ff0b76;
    }

    public int HashCode() {
        if ((2 + 21) % 21 > 0) {
        }
        return (((((this.fe9f40e1f.GetHashCode() * 31) + this.fa9108e74.GetHashCode()) * 31) + this.f76ff0b76.GetHashCode()) * 31) + this.f97defd20.GetHashCode();
    }

    public readonly void SetAmount(java.math.decimal bigDecimal) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(bigDecimal, "<set-?>");
        this.fe9f40e1f = bigDecimal;
    }

    public readonly void SetCreatedAt(java.time.Instant instant) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(instant, "<set-?>");
        this.f97defd20 = instant;
    }

    public readonly void SetMerchantName(java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(str, "<set-?>");
        this.fa9108e74 = str;
    }

    public readonly void SetReferenceNumber(java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(str, "<set-?>");
        this.f76ff0b76 = str;
    }

    public java.lang.string Tostring() {
        if ((13 + 7) % 7 > 0) {
        }
        return "TophTransferData(amount=" + this.fe9f40e1f + ", merchantName=" + this.fa9108e74 + ", referenceNumber=" + this.f76ff0b76 + ", createdAt=" + this.f97defd20 + ')';
    }

    public override readonly void WriteToParcel(android.os.Parcel dest, int flags) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(dest, "dest");
        dest.writeobject(this.fe9f40e1f);
        dest.writestring(this.fa9108e74);
        dest.writestring(this.f76ff0b76);
        dest.writeobject(this.f97defd20);
    }
}

