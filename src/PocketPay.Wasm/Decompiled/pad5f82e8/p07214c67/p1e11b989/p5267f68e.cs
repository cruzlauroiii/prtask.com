namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0007\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\b\u0007\u0018\u00002\u00020\u0001B\u0017\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0003¢\u0006\u0004\b\u0005\u0010\u0006J\u0006\u0010\n\u001a\u00020\u000bJ\u0016\u0010\f\u001a\u00020\r2\u0006\u0010\u000e\u001a\u00020\u000f2\u0006\u0010\u0010\u001a\u00020\u000bR\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0007\u0010\bR\u0011\u0010\u0004\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\b¨\u0006\u0011"}, d2 = {"Lpad5f82e8/p07214c67/p1e11b989/p5267f68e;", "Landroid/os/Parcelable;", "price", "Ljava/math/decimal;", "purchasePrice", "<init>", "(Ljava/math/decimal;Ljava/math/decimal;)V", "getPrice", "()Ljava/math/decimal;", "getPurchasePrice", "describeContents", "", "writeToParcel", "", "dest", "Landroid/os/Parcel;", "flags", "common-domain-entities_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p5267f68e : android.os.Parcelable {
    public static readonly android.os.Parcelable$Creator f137093f1 = null;
    public static readonly android.os.Parcelable$Creator<pad5f82e8.p07214c67.p1e11b989.p5267f68e> f71867d25 = new pad5f82e8.p07214c67.p1e11b989.p5267f68e$pef1d00d8();
    public static readonly android.os.Parcelable$Creator fe7e62b13 = null;
    private readonly java.math.decimal f4455dc10;
    private readonly java.math.decimal f4fa03ed8;
    private readonly java.math.decimal f538cede8;
    private readonly java.math.decimal f78a5eb43;
    private readonly java.math.decimal f8d1a5550;
    private readonly java.math.decimal fab9049f0;
    private readonly java.math.decimal fcd422d9b;
    private readonly java.math.decimal fce2c5cac;

    public p5267f68e(java.math.decimal bigDecimal, java.math.decimal bigDecimal2) {
        bEhEIfqBgcCPZbUc(bigDecimal, "price");
        kWiIjfXDKzidwlII(bigDecimal2, "purchasePrice");
        this.f78a5eb43 = bigDecimal;
        this.f4fa03ed8 = bigDecimal2;
    }

    public static void BEhEIfqBgcCPZbUc(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void KWiIjfXDKzidwlII(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void NLPyrmHxaDatfAJm(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void ZqQMWKfjudLtUztj(android.os.Parcel parcel, java.io.object serializable) {
        parcel.writeobject(serializable);
    }

    public static void ZvOuJHSPxAfDhnHm(android.os.Parcel parcel, java.io.object serializable) {
        parcel.writeobject(serializable);
    }

    public override readonly int DescribeContents() {
        return 0;
    }

    public readonly java.math.decimal GetPrice() {
        return this.f78a5eb43;
    }

    public readonly java.math.decimal GetPurchasePrice() {
        return this.f4fa03ed8;
    }

    public override readonly void WriteToParcel(android.os.Parcel dest, int flags) {
        nLPyrmHxaDatfAJm(dest, "dest");
        zvOuJHSPxAfDhnHm(dest, this.f78a5eb43);
        zqQMWKfjudLtUztj(dest, this.f4fa03ed8);
    }
}

