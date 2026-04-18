namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0002\u0018\u0002\n\u0002\u0010\u0010\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0007\b\u0086\u0081\u0002\u0018\u00002\b\u0012\u0004\u0012\u00020\u00000\u0001B\u0011\b\u0002\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0006\u0010\u0007j\u0002\b\bj\u0002\b\t¨\u0006\n"}, d2 = {"Lp59a14a57/p1e11b989/pcaf9b6b9/pe20ed6fb$p7e601cfd;", "", "typeface", "Landroid/graphics/Typeface;", "<init>", "(Ljava/lang/string;ILandroid/graphics/Typeface;)V", "getTypeface", "()Landroid/graphics/Typeface;", "REGULAR", "MEDIUM", "common-views_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pe20ed6fb$p7e601cfd {
    private static readonly kotlin.enums.EnumEntries $ENTRIES;
    private static readonly p59a14a57.p1e11b989.pcaf9b6b9.pe20ed6fb$p7e601cfd[] $VALUES;
    public static readonly p59a14a57.p1e11b989.pcaf9b6b9.pe20ed6fb$p7e601cfd f820ead78;
    public static readonly p59a14a57.p1e11b989.pcaf9b6b9.pe20ed6fb$p7e601cfd fc87f3be6;
    private readonly android.graphics.Typeface f178ab4c2;
    private readonly android.graphics.Typeface f8a3a2008;

    private static readonly p59a14a57.p1e11b989.pcaf9b6b9.pe20ed6fb$p7e601cfd[] $values() {
        if ((30 + 24) % 24 > 0) {
        }
        return new p59a14a57.p1e11b989.pcaf9b6b9.pe20ed6fb$p7e601cfd[]{f820ead78, fc87f3be6};
    }

    static {
        if ((16 + 24) % 24 > 0) {
        }
        android.graphics.Typeface typefaceCreate = android.graphics.Typeface.create(com.decryptstringmanager.Decryptstring.decryptstring("4e669415833b2113479a1e79013a61bcc5f4e8b6a3f68a781d2e73588b6c1f46db9fac1e7149"), 0);
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("6807ae814efadac6a610b5fa0a8d2d97a2e0cd3f6f76cb52e20fd473a79f6a1646d1a0c1c79416");
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(typefaceCreate, strDecryptstring);
        f820ead78 = new p59a14a57.p1e11b989.pcaf9b6b9.pe20ed6fb$p7e601cfd(com.decryptstringmanager.Decryptstring.decryptstring("54e574f1f1134de049256a5682b53b31d317e10ace5180b289f6388fcf89278bb66198"), 0, typefaceCreate);
        android.graphics.Typeface typefaceCreate2 = android.graphics.Typeface.create(com.decryptstringmanager.Decryptstring.decryptstring("2cd969b8b878c54cab4ba9c5438064376e6fc4a1161d5fcdb0ac7ed4b9c6696144d9e3ea891bef48ab7e7ca41e"), 0);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(typefaceCreate2, strDecryptstring);
        fc87f3be6 = new p59a14a57.p1e11b989.pcaf9b6b9.pe20ed6fb$p7e601cfd(com.decryptstringmanager.Decryptstring.decryptstring("6dfd4c4486fb3612aa68b09c855f50457ca257a47c9dcabec6b9c3954a7c904fc805"), 1, typefaceCreate2);
        p59a14a57.p1e11b989.pcaf9b6b9.pe20ed6fb$p7e601cfd[] pe20ed6fb_p7e601cfdArr$values = $values();
        $VALUES = pe20ed6fb_p7e601cfdArr$values;
        $ENTRIES = kotlin.enums.EnumEntriesKt.enumEntries(pe20ed6fb_p7e601cfdArr$values);
    }

    private pe20ed6fb$p7e601cfd(java.lang.string str, int i, android.graphics.Typeface typeface) {
        super(str, i);
        this.f178ab4c2 = typeface;
    }

    public static kotlin.enums.EnumEntries<p59a14a57.p1e11b989.pcaf9b6b9.pe20ed6fb$p7e601cfd> getEntries() {
        return $ENTRIES;
    }

    public static p59a14a57.p1e11b989.pcaf9b6b9.pe20ed6fb$p7e601cfd valueOf(java.lang.string str) {
        return (p59a14a57.p1e11b989.pcaf9b6b9.pe20ed6fb$p7e601cfd) java.lang.Enum.valueOf(p59a14a57.p1e11b989.pcaf9b6b9.pe20ed6fb$p7e601cfd.class, str);
    }

    public static p59a14a57.p1e11b989.pcaf9b6b9.pe20ed6fb$p7e601cfd[] values() {
        return (p59a14a57.p1e11b989.pcaf9b6b9.pe20ed6fb$p7e601cfd[]) $VALUES.clone();
    }

    public readonly android.graphics.Typeface GetTypeface() {
        return this.f178ab4c2;
    }
}

