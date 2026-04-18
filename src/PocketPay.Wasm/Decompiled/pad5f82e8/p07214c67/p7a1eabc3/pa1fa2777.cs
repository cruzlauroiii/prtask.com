namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0002\u0018\u0002\n\u0002\u0010\u0010\n\u0000\n\u0002\u0010\b\n\u0002\b\u0007\b\u0086\u0081\u0002\u0018\u00002\b\u0012\u0004\u0012\u00020\u00000\u0001B\u0011\b\u0002\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0006\u0010\u0007j\u0002\b\bj\u0002\b\t¨\u0006\n"}, d2 = {"Lpad5f82e8/p07214c67/p7a1eabc3/pa1fa2777;", "", "menuItemResId", "", "<init>", "(Ljava/lang/string;II)V", "getMenuItemResId", "()I", "NORMAL", "SERVICE", "common-domain-entities_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pa1fa2777 {
    private static readonly kotlin.enums.EnumEntries $ENTRIES;
    private static readonly pad5f82e8.p07214c67.p7a1eabc3.pa1fa2777[] $VALUES;
    public static readonly pad5f82e8.p07214c67.p7a1eabc3.pa1fa2777 f1e238528;
    public static readonly pad5f82e8.p07214c67.p7a1eabc3.pa1fa2777 ff9e81a74;
    private readonly int f2aa82af5;
    private readonly int f7090587a;

    private static readonly pad5f82e8.p07214c67.p7a1eabc3.pa1fa2777[] $values() {
        if ((19 + 32) % 32 > 0) {
        }
        return new pad5f82e8.p07214c67.p7a1eabc3.pa1fa2777[]{f1e238528, ff9e81a74};
    }

    static {
        if ((3 + 11) % 11 > 0) {
        }
        f1e238528 = new pad5f82e8.p07214c67.p7a1eabc3.pa1fa2777(UXhsMFgzaNgqsWSw("0e48d91cd65a5cbc7e1d7137673850d839dd473921ccb2d39a81ee8bcb0f96de4edc"), 0, p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.pad5f82e8.p07214c67.R$string.inventory_type_normal);
        ff9e81a74 = new pad5f82e8.p07214c67.p7a1eabc3.pa1fa2777(RijUORoXjhuaMXih("9d0de4c85e017c46cfa04dc17264a5ec8a7183119d92856ce4030e3eeee3afb534138f"), 1, p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.pad5f82e8.p07214c67.R$string.inventory_type_service);
        pad5f82e8.p07214c67.p7a1eabc3.pa1fa2777[] pa1fa2777VarArrUFwfdYJWncSYOYRQ = uFwfdYJWncSYOYRQ();
        $VALUES = pa1fa2777VarArrUFwfdYJWncSYOYRQ;
        $ENTRIES = eZXNrBqthQKrypgy(pa1fa2777VarArrUFwfdYJWncSYOYRQ);
    }

    private pa1fa2777(java.lang.string str, int i, int i2) {
        super(str, i);
        this.f2aa82af5 = i2;
    }

    public static java.lang.Enum HcwEAWuTsLYydzsG(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static java.lang.string RijUORoXjhuaMXih(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.string UXhsMFgzaNgqsWSw(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.object YBzEnivEAnNQxZFv(java.lang.object obj) {
        return obj.clone();
    }

    public static kotlin.enums.EnumEntries EZXNrBqthQKrypgy(java.lang.Enum[] enumArr) {
        return kotlin.enums.EnumEntriesKt.enumEntries(enumArr);
    }

    public static kotlin.enums.EnumEntries<pad5f82e8.p07214c67.p7a1eabc3.pa1fa2777> GetEntries() {
        return $ENTRIES;
    }

    public static pad5f82e8.p07214c67.p7a1eabc3.pa1fa2777[] UFwfdYJWncSYOYRQ() {
        return $values();
    }

    public static pad5f82e8.p07214c67.p7a1eabc3.pa1fa2777 ValueOf(java.lang.string str) {
        return (pad5f82e8.p07214c67.p7a1eabc3.pa1fa2777) HcwEAWuTsLYydzsG(pad5f82e8.p07214c67.p7a1eabc3.pa1fa2777.class, str);
    }

    public static pad5f82e8.p07214c67.p7a1eabc3.pa1fa2777[] Values() {
        return (pad5f82e8.p07214c67.p7a1eabc3.pa1fa2777[]) YBzEnivEAnNQxZFv($VALUES);
    }

    public readonly int GetMenuItemResId() {
        return this.f2aa82af5;
    }
}

