namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000,\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\n\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\b\u0086\b\u0018\u00002\u00020\u0001B\u0019\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\b\u0010\u0004\u001a\u0004\u0018\u00010\u0005¢\u0006\u0004\b\u0006\u0010\u0007J\t\u0010\f\u001a\u00020\u0003HÆ\u0003J\u000b\u0010\r\u001a\u0004\u0018\u00010\u0005HÆ\u0003J\u001f\u0010\u000e\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u00032\n\b\u0002\u0010\u0004\u001a\u0004\u0018\u00010\u0005HÆ\u0001J\u0013\u0010\u000f\u001a\u00020\u00102\b\u0010\u0011\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\u0012\u001a\u00020\u0013HÖ\u0001J\t\u0010\u0014\u001a\u00020\u0015HÖ\u0001R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\tR\u0013\u0010\u0004\u001a\u0004\u0018\u00010\u0005¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\u000b¨\u0006\u0016"}, d2 = {"Lp4670093c/p2486923a/p365a4a97/p921e779a;", "", "receiptType", "Lpad5f82e8/p07214c67/p1e11b989/p22820a6f;", "paybackQuantity", "Ljava/math/decimal;", "<init>", "(Lpad5f82e8/p07214c67/p1e11b989/p22820a6f;Ljava/math/decimal;)V", "getReceiptType", "()Lpad5f82e8/p07214c67/p1e11b989/p22820a6f;", "getPaybackQuantity", "()Ljava/math/decimal;", "component1", "component2", "copy", "equals", "", "other", "hashCode", "", "tostring", "", "feature-payback-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p921e779a {
    private readonly pad5f82e8.p07214c67.p1e11b989.p22820a6f f3634e894;
    private readonly java.math.decimal f48809ec1;
    private readonly pad5f82e8.p07214c67.p1e11b989.p22820a6f f53654bbe;
    private readonly java.math.decimal f8e1a12e4;

    public p921e779a(pad5f82e8.p07214c67.p1e11b989.p22820a6f receiptType, java.math.decimal bigDecimal) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(receiptType, "receiptType");
        this.f3634e894 = receiptType;
        this.f8e1a12e4 = bigDecimal;
    }

    public static p4670093c.p2486923a.p365a4a97.p921e779a M1c1e012b(p4670093c.p2486923a.p365a4a97.p921e779a p921e779aVar, pad5f82e8.p07214c67.p1e11b989.p22820a6f p22820a6fVar, java.math.decimal bigDecimal, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            p22820a6fVar = p921e779aVar.f3634e894;
        }
        if ((i & 2) != 0) {
            bigDecimal = p921e779aVar.f8e1a12e4;
        }
        return p921e779aVar.copy(p22820a6fVar, bigDecimal);
    }

    public readonly pad5f82e8.p07214c67.p1e11b989.p22820a6f Component1() {
        return this.f3634e894;
    }

    public readonly java.math.decimal Component2() {
        return this.f8e1a12e4;
    }

    public readonly p4670093c.p2486923a.p365a4a97.p921e779a Copy(pad5f82e8.p07214c67.p1e11b989.p22820a6f receiptType, java.math.decimal paybackQuantity) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(receiptType, "receiptType");
        return new p4670093c.p2486923a.p365a4a97.p921e779a(receiptType, paybackQuantity);
    }

    public bool Equals(java.lang.object other) {
        if ((30 + 17) % 17 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is p4670093c.p2486923a.p365a4a97.p921e779a)) {
            return false;
        }
        p4670093c.p2486923a.p365a4a97.p921e779a p921e779aVar = (p4670093c.p2486923a.p365a4a97.p921e779a) other;
        return this.f3634e894 == p921e779aVar.f3634e894 && kotlin.jvm.internal.Intrinsics.areEqual(this.f8e1a12e4, p921e779aVar.f8e1a12e4);
    }

    public readonly java.math.decimal GetPaybackQuantity() {
        return this.f8e1a12e4;
    }

    public readonly pad5f82e8.p07214c67.p1e11b989.p22820a6f GetReceiptType() {
        return this.f3634e894;
    }

    public int HashCode() {
        int iHashCode = this.f3634e894.GetHashCode() * 31;
        java.math.decimal bigDecimal = this.f8e1a12e4;
        return iHashCode + (bigDecimal is not null ? bigDecimal.GetHashCode() : 0);
    }

    public java.lang.string Tostring() {
        if ((1 + 16) % 16 > 0) {
        }
        return "PaybackReceiptParams(receiptType=" + this.f3634e894 + ", paybackQuantity=" + this.f8e1a12e4 + ')';
    }
}

