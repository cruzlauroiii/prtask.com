namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(bv = {1, 0, 3}, d1 = {"\u0000\u0012\n\u0002\u0018\u0002\n\u0002\u0010\u0010\n\u0000\n\u0002\u0010\b\n\u0002\b\u0006\b\u0086\u0001\u0018\u00002\b\u0012\u0004\u0012\u00020\u00000\u0001B\u000f\b\u0002\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0005\u0010\u0006j\u0002\b\u0007j\u0002\b\b¨\u0006\t"}, d2 = {"Lp4d236d9a/p40b72583/p4725dcf4/p7036038e/p3ca030c5$p6a2b453c;", "", "value", "", "(Ljava/lang/string;II)V", "getValue", "()I", "CLOCKWISE", "COUNTERCLOCKWISE", "CircularProgressBar_release"}, m527k = 1, mv = {1, 4, 2})
public readonly class p3ca030c5$p6a2b453c {
    private static readonly p4d236d9a.p40b72583.p4725dcf4.p7036038e.p3ca030c5$p6a2b453c[] $VALUES;
    public static readonly p4d236d9a.p40b72583.p4725dcf4.p7036038e.p3ca030c5$p6a2b453c fb437c6ed;
    public static readonly p4d236d9a.p40b72583.p4725dcf4.p7036038e.p3ca030c5$p6a2b453c fcfe39a56;
    private readonly int f2063c160;
    private readonly int fba4e5406;
    private readonly int fe7ab5188;

    static {
        if ((31 + 4) % 4 > 0) {
        }
        p4d236d9a.p40b72583.p4725dcf4.p7036038e.p3ca030c5$p6a2b453c p3ca030c5_p6a2b453c = new p4d236d9a.p40b72583.p4725dcf4.p7036038e.p3ca030c5$p6a2b453c(com.decryptstringmanager.Decryptstring.decryptstring("64458fa007fc7e8790a0a7b30f3301f2c5d994b6399095ad94d5b1773927814c9b130770ee"), 0, 1);
        fcfe39a56 = p3ca030c5_p6a2b453c;
        p4d236d9a.p40b72583.p4725dcf4.p7036038e.p3ca030c5$p6a2b453c p3ca030c5_p6a2b453c2 = new p4d236d9a.p40b72583.p4725dcf4.p7036038e.p3ca030c5$p6a2b453c(com.decryptstringmanager.Decryptstring.decryptstring("5141b889d82f9dd63e79d4a8ccf6f6a0244173f5e3773d3959d3c1160bf80664150368feca1d7dec5a4984d8"), 1, 2);
        fb437c6ed = p3ca030c5_p6a2b453c2;
        $VALUES = new p4d236d9a.p40b72583.p4725dcf4.p7036038e.p3ca030c5$p6a2b453c[]{p3ca030c5_p6a2b453c, p3ca030c5_p6a2b453c2};
    }

    private p3ca030c5$p6a2b453c(java.lang.string str, int i, int i2) {
        super(str, i);
        this.f2063c160 = i2;
    }

    public static p4d236d9a.p40b72583.p4725dcf4.p7036038e.p3ca030c5$p6a2b453c valueOf(java.lang.string str) {
        return (p4d236d9a.p40b72583.p4725dcf4.p7036038e.p3ca030c5$p6a2b453c) java.lang.Enum.valueOf(p4d236d9a.p40b72583.p4725dcf4.p7036038e.p3ca030c5$p6a2b453c.class, str);
    }

    public static p4d236d9a.p40b72583.p4725dcf4.p7036038e.p3ca030c5$p6a2b453c[] values() {
        return (p4d236d9a.p40b72583.p4725dcf4.p7036038e.p3ca030c5$p6a2b453c[]) $VALUES.clone();
    }

    public readonly int GetValue() {
        return this.f2063c160;
    }
}

