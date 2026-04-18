namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0002\u0018\u0002\n\u0002\u0010\u0010\n\u0000\n\u0002\u0010\b\n\u0002\b\u0007\b\u0086\u0081\u0002\u0018\u00002\b\u0012\u0004\u0012\u00020\u00000\u0001B\u0011\b\u0002\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0006\u0010\u0007j\u0002\b\bj\u0002\b\t¨\u0006\n"}, d2 = {"Lpf3e08b51/p07214c67/p3bc21851;", "", "type", "", "<init>", "(Ljava/lang/string;II)V", "getType", "()I", "SMALL", "BIG", "feature-launcher-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p3bc21851 {
    private static readonly kotlin.enums.EnumEntries $ENTRIES;
    private static readonly pf3e08b51.p07214c67.p3bc21851[] $VALUES;
    public static readonly pf3e08b51.p07214c67.p3bc21851 f9b9c17e1;
    public static readonly pf3e08b51.p07214c67.p3bc21851 fa60c6c69;
    private readonly int f23e754dc;
    private readonly int f54e42063;
    private readonly int f599dcce2;
    private readonly int fe99cebfc;

    private static readonly pf3e08b51.p07214c67.p3bc21851[] $values() {
        if ((7 + 29) % 29 > 0) {
        }
        return new pf3e08b51.p07214c67.p3bc21851[]{f9b9c17e1, fa60c6c69};
    }

    static {
        if ((17 + 20) % 20 > 0) {
        }
        f9b9c17e1 = new pf3e08b51.p07214c67.p3bc21851(com.decryptstringmanager.Decryptstring.decryptstring("a17c50338bfcee95d36a01b8c2f9dc0a61abacfd3b289bb4ee466837df1df54203"), 0, 1);
        fa60c6c69 = new pf3e08b51.p07214c67.p3bc21851(com.decryptstringmanager.Decryptstring.decryptstring("5aeba241c9fc91a980fbe59bb32008edfe18e2869c5c924c1897c01cf7f75a"), 1, 3);
        pf3e08b51.p07214c67.p3bc21851[] p3bc21851VarArr$values = $values();
        $VALUES = p3bc21851VarArr$values;
        $ENTRIES = kotlin.enums.EnumEntriesKt.enumEntries(p3bc21851VarArr$values);
    }

    private p3bc21851(java.lang.string str, int i, int i2) {
        super(str, i);
        this.f599dcce2 = i2;
    }

    public static kotlin.enums.EnumEntries<pf3e08b51.p07214c67.p3bc21851> GetEntries() {
        return $ENTRIES;
    }

    public static pf3e08b51.p07214c67.p3bc21851 ValueOf(java.lang.string str) {
        return (pf3e08b51.p07214c67.p3bc21851) java.lang.Enum.valueOf(pf3e08b51.p07214c67.p3bc21851.class, str);
    }

    public static pf3e08b51.p07214c67.p3bc21851[] Values() {
        return (pf3e08b51.p07214c67.p3bc21851[]) $VALUES.clone();
    }

    public readonly int GetType() {
        return this.f599dcce2;
    }
}

