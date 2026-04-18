namespace WillowMaze.Wasm.Decompiled;


public class pd1e28b1e : javax.imageio.ImageWriteParam {
    public static readonly int f0f904afd = 0;
    public static readonly int f3afe206f = 2;
    public static readonly int f5699e427 = 0;
    public static readonly int f61c1e3b2 = 3;
    public static readonly int f628462ed = 2;
    public static readonly int f6666e5ad = 3;
    public static readonly int f71733c54 = 2;
    public static readonly int f718bd52c = 0;
    public static readonly int f72a4fe8e = 3;
    public static readonly int f76e1d58d = 2;
    public static readonly int f9476732e = 1;
    public static readonly int fab4c5600 = 0;
    public static readonly int fd885513e = 1;
    public static readonly int fdb8da6f8 = 1;
    private bool f5aa3ae35;
    private bool f83000ab6;
    private bool f9cf62833;
    private bool fc3438b20;
    private bool fcfa387d0;

    public pd1e28b1e() {
        this(null);
    }

    public pd1e28b1e(java.util.Locale locale) {
        super(locale);
        this.f9cf62833 = false;
        this.f714b52e5 = p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.p96a75bdb.p603325ef.f46d1276b;
        this.canWriteCompressed = true;
        this.compressionMode = 3;
        this.f8d8a06f5 = this.f714b52e5[0];
    }

    public static bool RnuHxyIycPkpsBzo(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static void AOBeNvcDmgszFPRR(javax.imageio.ImageWriteParam imageWriteParam, java.lang.string str) {
        super.setCompressionType(str);
    }

    public static bool XjWjJOFhSGibrBVg(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public int GetVersion() {
        return 1;
    }

    public bool IsTopDown() {
        return this.f9cf62833;
    }

    public void SetCompressionType(java.lang.string str) {
        aOBeNvcDmgszFPRR(this, str);
        if (RnuHxyIycPkpsBzo(str, "BI_RGB") || xjWjJOFhSGibrBVg(str, "BI_BITFIELDS") || !this.f9cf62833) {
            return;
        }
        this.f9cf62833 = false;
    }

    public void SetTopDown(bool z) {
        this.f9cf62833 = z;
    }
}

