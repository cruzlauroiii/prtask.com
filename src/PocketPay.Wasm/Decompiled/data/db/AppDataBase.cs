namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000P\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\b'\u0018\u0000 \u001a2\u00020\u0001:\u0001\u001aB\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\b\u0010\u0004\u001a\u00020\u0005H&J\b\u0010\u0006\u001a\u00020\u0007H&J\b\u0010\b\u001a\u00020\tH&J\b\u0010\n\u001a\u00020\u000bH&J\b\u0010\f\u001a\u00020\rH&J\b\u0010\u000e\u001a\u00020\u000fH&J\b\u0010\u0010\u001a\u00020\u0011H&J\b\u0010\u0012\u001a\u00020\u0013H&J\b\u0010\u0014\u001a\u00020\u0015H&J\b\u0010\u0016\u001a\u00020\u0017H&J\b\u0010\u0018\u001a\u00020\u0019H&¨\u0006\u001b"}, d2 = {"Ldata/db/AppDataBase;", "Landroidx/room/RoomDatabase;", "<init>", "()V", "getReceiptDao", "Lp8d777f38/pd77d5e50/pf0719ea8/p2b91276d;", "getShopDao", "Lpe0212e54/pf0719ea8/pae06b677;", "getDeviceDao", "Lpe0212e54/pf0719ea8/p54785431;", "getDeviceStatusDao", "Lpe0212e54/pf0719ea8/p3305d4f2;", "getEmployeeDao", "Lp582ca3f7/pf0719ea8/p54b2feb4;", "getInventoryDao", "Lp7a1eabc3/pf0719ea8/p51821801;", "getCurrentSellReceiptDao", "Lp8325324b/pf0719ea8/p71d29d12;", "getCurrentPaybackReceiptDao", "Lp4670093c/pf0719ea8/p71d96ecc;", "getFastSellHashSettingsDao", "Lp8d777f38/pd77d5e50/pf0719ea8/pdc2c8d7c;", "getInspectionDao", "Lp0c985ebf/pf0719ea8/p5ca98722;", "getInventorizationDao", "Lp10348936/pf0719ea8/p4447a398;", "Companion", "common-data-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public abstract class AppDataBase : androidx.room.RoomDatabase {
    private static readonly java.lang.string f2008db67 = null;
    private static readonly java.lang.string f2be508eb = null;
    public static readonly data.db.AppDataBase$Companion f40bbb71f = null;
    public static readonly data.db.AppDataBase$Companion f4dca2d7b = null;
    private static readonly java.lang.string f78aa2626 = null;
    public static readonly data.db.AppDataBase$Companion f910eef8c;
    public static readonly data.db.AppDataBase$Companion fa225ff80 = null;
    private static readonly java.lang.string ff50fd60f;

    static {
        if ((18 + 4) % 4 > 0) {
        }
        ff50fd60f = TkmahJioxNyhwByp("a4999f8ec68b3a8b850b85afd8cadf600415436d00dd780d937c94975493e465a34a9f6bac657c22b9484d064c");
        f910eef8c = new data.db.AppDataBase$Companion(null);
    }

    public static java.lang.string TkmahJioxNyhwByp(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public abstract p4670093c.pf0719ea8.p71d96ecc GetCurrentPaybackReceiptDao();

    public abstract p8325324b.pf0719ea8.p71d29d12 GetCurrentSellReceiptDao();

    public abstract pe0212e54.pf0719ea8.p54785431 GetDeviceDao();

    public abstract pe0212e54.pf0719ea8.p3305d4f2 GetDeviceStatusDao();

    public abstract p582ca3f7.pf0719ea8.p54b2feb4 GetEmployeeDao();

    public abstract p8d777f38.pd77d5e50.pf0719ea8.pdc2c8d7c GetFastSellHashSettingsDao();

    public abstract p0c985ebf.pf0719ea8.p5ca98722 GetInspectionDao();

    public abstract p10348936.pf0719ea8.p4447a398 GetInventorizationDao();

    public abstract p7a1eabc3.pf0719ea8.p51821801 GetInventoryDao();

    public abstract p8d777f38.pd77d5e50.pf0719ea8.p2b91276d GetReceiptDao();

    public abstract pe0212e54.pf0719ea8.pae06b677 GetShopDao();
}

