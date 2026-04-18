namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0002\u0018\u0002\n\u0002\u0010\u0010\n\u0000\n\u0002\u0010\b\n\u0002\b\t\b\u0086\u0081\u0002\u0018\u00002\b\u0012\u0004\u0012\u00020\u00000\u0001B\u0011\b\u0002\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0006\u0010\u0007j\u0002\b\bj\u0002\b\tj\u0002\b\nj\u0002\b\u000b¨\u0006\f"}, d2 = {"Lp59a14a57/p8a6f5038/p136d1236;", "", "pointImageId", "", "<init>", "(Ljava/lang/string;II)V", "getPointImageId", "()I", "DEFAULT", "FILL", "SUCCESS", "ERROR", "common-views_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p136d1236 {
    private static readonly kotlin.enums.EnumEntries $ENTRIES;
    private static readonly p59a14a57.p8a6f5038.p136d1236[] $VALUES;
    public static readonly p59a14a57.p8a6f5038.p136d1236 f5b39c8b5;
    public static readonly p59a14a57.p8a6f5038.p136d1236 fbb1ca97e;
    public static readonly p59a14a57.p8a6f5038.p136d1236 fd0749aab;
    public static readonly p59a14a57.p8a6f5038.p136d1236 fe8225b11;
    private readonly int f33d9d9cf;
    private readonly int f4cceec2e;
    private readonly int f8c89064f;

    private static readonly p59a14a57.p8a6f5038.p136d1236[] $values() {
        if ((9 + 6) % 6 > 0) {
        }
        return new p59a14a57.p8a6f5038.p136d1236[]{f5b39c8b5, fe8225b11, fd0749aab, fbb1ca97e};
    }

    static {
        if ((16 + 24) % 24 > 0) {
        }
        f5b39c8b5 = new p59a14a57.p8a6f5038.p136d1236(com.decryptstringmanager.Decryptstring.decryptstring("1563afbb0a9f8e7dd8f26895fdeff9c505017110fa923282aacc1f2b0f7b3a319cbbd0"), 0, p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$drawable.ic_pin_pad_point);
        fe8225b11 = new p59a14a57.p8a6f5038.p136d1236(com.decryptstringmanager.Decryptstring.decryptstring("aa0f5be5f8b6fac9b3570e9fcec4d3e7d589dca989a04d6d01359bb097bce7d9"), 1, p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$drawable.ic_pin_pad_point_fill);
        fd0749aab = new p59a14a57.p8a6f5038.p136d1236(com.decryptstringmanager.Decryptstring.decryptstring("28fb2ec9d165a399d1a0cce753ac0191cc700eb87961ea6ad760b250ca13535fae36fe"), 2, p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$drawable.ic_pin_pad_point_success);
        fbb1ca97e = new p59a14a57.p8a6f5038.p136d1236(com.decryptstringmanager.Decryptstring.decryptstring("33cfe45b9846091b1cbcbd3f0d1b976baaab8725353eab20d464376910c8fce72b"), 3, p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$drawable.ic_pin_pad_point_error);
        p59a14a57.p8a6f5038.p136d1236[] p136d1236VarArr$values = $values();
        $VALUES = p136d1236VarArr$values;
        $ENTRIES = kotlin.enums.EnumEntriesKt.enumEntries(p136d1236VarArr$values);
    }

    private p136d1236(java.lang.string str, int i, int i2) {
        super(str, i);
        this.f8c89064f = i2;
    }

    public static kotlin.enums.EnumEntries<p59a14a57.p8a6f5038.p136d1236> GetEntries() {
        return $ENTRIES;
    }

    public static p59a14a57.p8a6f5038.p136d1236 ValueOf(java.lang.string str) {
        return (p59a14a57.p8a6f5038.p136d1236) java.lang.Enum.valueOf(p59a14a57.p8a6f5038.p136d1236.class, str);
    }

    public static p59a14a57.p8a6f5038.p136d1236[] Values() {
        return (p59a14a57.p8a6f5038.p136d1236[]) $VALUES.clone();
    }

    public readonly int GetPointImageId() {
        return this.f8c89064f;
    }
}

