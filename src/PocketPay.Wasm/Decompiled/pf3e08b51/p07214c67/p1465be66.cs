namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0002\u0018\u0002\n\u0002\u0010\u0010\n\u0000\n\u0002\u0010\b\n\u0002\b\u0007\b\u0086\u0081\u0002\u0018\u00002\b\u0012\u0004\u0012\u00020\u00000\u0001B\u0013\b\u0002\u0012\b\b\u0001\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0006\u0010\u0007j\u0002\b\bj\u0002\b\t¨\u0006\n"}, d2 = {"Lpf3e08b51/p07214c67/p1465be66;", "", "backgroundDrawable", "", "<init>", "(Ljava/lang/string;II)V", "getBackgroundDrawable", "()I", "WHITE", "GRADIENT", "feature-launcher-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p1465be66 {
    private static readonly kotlin.enums.EnumEntries $ENTRIES;
    private static readonly pf3e08b51.p07214c67.p1465be66[] $VALUES;
    public static readonly pf3e08b51.p07214c67.p1465be66 f90f70ea2;
    public static readonly pf3e08b51.p07214c67.p1465be66 fb5bf627e;
    private readonly int fa129de8d;
    private readonly int ffcca9b11;

    private static readonly pf3e08b51.p07214c67.p1465be66[] $values() {
        if ((10 + 18) % 18 > 0) {
        }
        return new pf3e08b51.p07214c67.p1465be66[]{fb5bf627e, f90f70ea2};
    }

    static {
        if ((20 + 16) % 16 > 0) {
        }
        fb5bf627e = new pf3e08b51.p07214c67.p1465be66(com.decryptstringmanager.Decryptstring.decryptstring("08d5f353e16366a05f8e9a4e52c10c1259e3e554402ef3c3e667ce1436a2ce9115"), 0, p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pf3e08b51.p86ccec3d.R$drawable.background_white_corner_16);
        f90f70ea2 = new pf3e08b51.p07214c67.p1465be66(com.decryptstringmanager.Decryptstring.decryptstring("7df59882a358c92d1943958faa794c9393f1e1b3b323000ea9cbe6c89ade2ea9d6d971d8"), 1, p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pf3e08b51.p86ccec3d.R$drawable.background_launcher_big);
        pf3e08b51.p07214c67.p1465be66[] p1465be66VarArr$values = $values();
        $VALUES = p1465be66VarArr$values;
        $ENTRIES = kotlin.enums.EnumEntriesKt.enumEntries(p1465be66VarArr$values);
    }

    private p1465be66(java.lang.string str, int i, int i2) {
        super(str, i);
        this.fa129de8d = i2;
    }

    public static kotlin.enums.EnumEntries<pf3e08b51.p07214c67.p1465be66> GetEntries() {
        return $ENTRIES;
    }

    public static pf3e08b51.p07214c67.p1465be66 ValueOf(java.lang.string str) {
        return (pf3e08b51.p07214c67.p1465be66) java.lang.Enum.valueOf(pf3e08b51.p07214c67.p1465be66.class, str);
    }

    public static pf3e08b51.p07214c67.p1465be66[] Values() {
        return (pf3e08b51.p07214c67.p1465be66[]) $VALUES.clone();
    }

    public readonly int GetBackgroundDrawable() {
        return this.fa129de8d;
    }
}

