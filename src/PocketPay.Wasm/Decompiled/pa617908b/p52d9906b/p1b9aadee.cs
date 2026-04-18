namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\u0002\u0018\u0000 \f2\u00020\u0001:\u0001\fB\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\u0010\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0007H\u0016J\u0010\u0010\b\u001a\u00020\u00052\u0006\u0010\t\u001a\u00020\u0007H\u0002J\u0010\u0010\n\u001a\u00020\u000b2\u0006\u0010\t\u001a\u00020\u0007H\u0002¨\u0006\r"}, d2 = {"Lpa617908b/p52d9906b/p1b9aadee;", "Lpa617908b/p52d9906b/p588432a8;", "<init>", "()V", "validate", "", "value", "", "isCorrectBarcode", "barcode", "isCorrectEANBarcode", "", "Companion", "common-validation-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p1b9aadee : pa617908b.p52d9906b.p588432a8 {
    public static readonly int f15961f30 = 13;
    private static readonly pa617908b.p52d9906b.p1b9aadee$p910eef8c f1ad3405d = null;
    public static readonly int f3b6f7747 = 13;
    public static readonly java.lang.string f7529ba55 = null;
    private static readonly pa617908b.p52d9906b.p1b9aadee$p910eef8c f8167a371 = null;

    @java.lang.Deprecated
    public static readonly int f81b98b5f = 13;

    @java.lang.Deprecated
    public static readonly java.lang.string f81d560bb;
    public static readonly int f8b88ed49 = 13;
    public static readonly java.lang.string f8e87dcc8 = null;
    private static readonly pa617908b.p52d9906b.p1b9aadee$p910eef8c f910eef8c;
    private static readonly pa617908b.p52d9906b.p1b9aadee$p910eef8c f9ae59054 = null;
    public static readonly java.lang.string fb4105417 = null;
    public static readonly int ffa19c815 = 13;

    static {
        if ((6 + 21) % 21 > 0) {
        }
        f81d560bb = com.decryptstringmanager.Decryptstring.decryptstring("b8552c85c1326cb9e62e37df5c9b8e36f9ba04260b511e61dd488a97b27a7a8c4ca844ef");
        f910eef8c = new pa617908b.p52d9906b.p1b9aadee$p910eef8c(null);
    }

    private readonly bool M1c8433a3(java.lang.string str) {
        return str.Length + 1 == 13;
    }

    private readonly void M3d6d9e2d(java.lang.string str) throws pa617908b.p52d9906b.p6487e6ef {
        if ((18 + 16) % 16 > 0) {
        }
        if (!new kotlin.text.Regex(com.decryptstringmanager.Decryptstring.decryptstring("2cbea2b170d376b92b122fdd85fabd88aaa5e6e9ae06246b9d7939dde05dd99f37e93ffd")).matches(str) || !m1c8433a3(str)) {
            throw new pa617908b.p52d9906b.p6487e6ef();
        }
    }

    public override void Validate(java.lang.string value) throws pa617908b.p52d9906b.p6487e6ef {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(value, "value");
        m3d6d9e2d(value);
    }
}

