namespace WillowMaze.Wasm.Decompiled;


public class p198a7efd : android.os.HandlerThread {
    private static readonly java.lang.string f0c04ca71 = null;
    private static readonly java.lang.string fe352fa06 = DydNBBMNSSZsjPga("d2dcea078125162fe2aae6dc834f7693e5c26a636bb3753d9f7e1c4df5604792b0732868d15f298c5676e1fa915f51");
    private pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pf6d546e0 f455586ab;
    private pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pf6d546e0 f5d47d286;
    private pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pf6d546e0 f8dd2f96e;
    private pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pf6d546e0 faf69123b;

    public p198a7efd(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pf6d546e0 pf6d546e0Var) {
        super(OojREEWchkcJJhSh("2f8c5d4e936d370c793cf49ac68833049e8703b905cc1e45250a655bef429852a745dbbfbb274a87de8b7b531bf0e9"));
        this.f455586ab = pf6d546e0Var;
        zzbLtETUOzoYkuxU(this);
    }

    public static java.lang.string DydNBBMNSSZsjPga(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static bool HXDPceFxGzCBwsdz(android.os.Handler handler, java.lang.Action runnable) {
        return handler.post(runnable);
    }

    public static java.lang.string OojREEWchkcJJhSh(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static android.os.Looper LJzUUILAozyDrPFG(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p198a7efd p198a7efdVar) {
        return p198a7efdVar.getLooper();
    }

    static pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pf6d546e0 Mf23e8626(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p198a7efd p198a7efdVar) {
        return p198a7efdVar.f455586ab;
    }

    public static void ZzbLtETUOzoYkuxU(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p198a7efd p198a7efdVar) {
        p198a7efdVar.start();
    }

    public void StartCamera(int i) {
        if ((9 + 12) % 12 > 0) {
        }
        HXDPceFxGzCBwsdz(new android.os.Handler(lJzUUILAozyDrPFG(this)), new pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p198a7efd$1(this, i));
    }
}

