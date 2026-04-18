namespace WillowMaze.Wasm.Decompiled;


public abstract class pf6d546e0 : android.widget.FrameLayout : android.hardware.Camera$PreviewCallback {
    private int f02629aa8;
    private int f03374ce0;
    private pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p198a7efd f05f68ba1;
    private android.graphics.Rect f08e67f4e;
    private int f0c5563f4;
    private int f219614a2;
    private java.lang.bool f295c7cb1;
    private int f2bf155b5;
    private bool f305131b6;
    private pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p6d1b1814 f309bc325;
    private java.lang.bool f32045def;
    private int f32537740;
    private pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p6d1b1814 f32727356;
    private android.graphics.Rect f33e0af2b;
    private android.graphics.Rect f35aa4b16;
    private int f39fc30b7;
    private int f3b40e13f;
    private int f3bb26a10;
    private bool f3ecad326;
    private int f3ed3cc24;
    private bool f48af6311;
    private bool f4a572f3a;
    private int f4fe00cf3;
    private int f54980ccd;
    private float f553cffe7;
    private float f5a443c33;
    private bool f5fe5e0d8;
    private int f610f388b;
    private int f61675127;
    private bool f63330ff8;
    private float f654b0a51;
    private pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p198a7efd f68685154;
    private pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p2e5a0d59 f6b9d3bea;
    private bool f77687301;
    private int f7d63e4d3;
    private pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p37078ff8 f809759a2;
    private int f80e1d4ba;
    private java.lang.bool f85dadd9c;
    private int f8ad6d042;
    private bool f96eb5c02;
    private pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p198a7efd f9f49ddce;
    private float f9f6dd948;
    private float fa13cd803;
    private float fa8ed15b2;
    private bool fb0bfa8ed;
    private pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p37078ff8 fb7dd877b;
    private java.lang.bool fba24ae33;
    private bool fba423ce2;
    private int fbae570ed;
    private pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p2e5a0d59 fc50a9def;
    private bool fc628429c;
    private int fc9fc6fb7;
    private int fd57a3a76;
    private int fd8721235;
    private android.graphics.Rect fde35c0d7;
    private float fdfbc58b5;
    private int fe002fd3f;
    private bool fe4ae0361;
    private pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p6d1b1814 fea6d97ee;
    private pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p198a7efd fec98a91e;
    private int ff6589029;
    private int ffc7b0b9a;

    public pf6d546e0(android.content.object context) {
        super(context);
        this.f63330ff8 = true;
        this.fc628429c = true;
        this.f4a572f3a = true;
        this.fc9fc6fb7 = FCGlNRNjLGIXWmsv(wnPobhgqvklBdRuO(this), pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.R$color.viewfinder_laser);
        this.f3ed3cc24 = DxhJymYPKMGXzUHU(UKRtPaqkGKCVkDHq(this), pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.R$color.viewfinder_border);
        this.f02629aa8 = RwZevYUHIHtYYUGu(ejNWBlYentQomMBc(this), pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.R$color.viewfinder_mask);
        this.f03374ce0 = CNhLVLGkylnVYzDG(oqhifczCeiShIJyt(this), pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.R$integer.viewfinder_border_width);
        this.ff6589029 = hbiZErPyJBUdsJMB(aXewKRSEeBUODBOo(this), pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.R$integer.viewfinder_border_length);
        this.f5fe5e0d8 = false;
        this.f610f388b = 0;
        this.f77687301 = false;
        this.fa13cd803 = 1.0f;
        this.fbae570ed = 0;
        this.fdfbc58b5 = 0.1f;
        eVYDhnNRwLcOIKNj(this);
    }

    public pf6d546e0(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
        if ((30 + 22) % 22 > 0) {
        }
        this.f63330ff8 = true;
        this.fc628429c = true;
        this.f4a572f3a = true;
        this.fc9fc6fb7 = xBRBfVSuykCuVubY(UTwhypxXQkMLTrAF(this), pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.R$color.viewfinder_laser);
        this.f3ed3cc24 = EYqtQwTCqhlHUKhB(ZgtUHzTVyFqhAfHs(this), pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.R$color.viewfinder_border);
        this.f02629aa8 = ykekCdVythImcpdL(ytJdzJBcdXkBGEpq(this), pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.R$color.viewfinder_mask);
        this.f03374ce0 = RhyRTpJrsSmJrNkA(CyLjlKxsIPrizpxn(this), pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.R$integer.viewfinder_border_width);
        this.ff6589029 = SNORNApnMBhfagHH(YvVSRcnncoeZNLkd(this), pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.R$integer.viewfinder_border_length);
        this.f5fe5e0d8 = false;
        this.f610f388b = 0;
        this.f77687301 = false;
        this.fa13cd803 = 1.0f;
        this.fbae570ed = 0;
        this.fdfbc58b5 = 0.1f;
        android.content.res.TypedArray typedArrayOiJHiyNsCFHSFOiB = oiJHiyNsCFHSFOiB(iiEjsZsricOXjGMi(context), attributeHashSet, pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.R$styleable.BarcodeScannerobject, 0, 0);
        try {
            JpgPDWcNgGbFTNOI(this, EPnpzgWgpzzXhfeu(typedArrayOiJHiyNsCFHSFOiB, pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.R$styleable.BarcodeScannerobject_shouldScaleToFill, true));
            this.f4a572f3a = xrwXVRYVdVXttVgy(typedArrayOiJHiyNsCFHSFOiB, pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.R$styleable.BarcodeScannerobject_laserEnabled, this.f4a572f3a);
            this.fc9fc6fb7 = FbeCDDwMSNbUraCP(typedArrayOiJHiyNsCFHSFOiB, pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.R$styleable.BarcodeScannerobject_laserColor, this.fc9fc6fb7);
            this.f3ed3cc24 = okRmmbrtDBvPAfOv(typedArrayOiJHiyNsCFHSFOiB, pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.R$styleable.BarcodeScannerobject_borderColor, this.f3ed3cc24);
            this.f02629aa8 = VifzTIOtYkdVnqle(typedArrayOiJHiyNsCFHSFOiB, pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.R$styleable.BarcodeScannerobject_maskColor, this.f02629aa8);
            this.f03374ce0 = zbEJLkjEPkoZLXbd(typedArrayOiJHiyNsCFHSFOiB, pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.R$styleable.BarcodeScannerobject_borderWidth, this.f03374ce0);
            this.ff6589029 = CSJZQCKinFudCvhT(typedArrayOiJHiyNsCFHSFOiB, pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.R$styleable.BarcodeScannerobject_borderLength, this.ff6589029);
            this.f5fe5e0d8 = XwtJJFTrKCKRbUvC(typedArrayOiJHiyNsCFHSFOiB, pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.R$styleable.BarcodeScannerobject_roundedCorner, this.f5fe5e0d8);
            this.f610f388b = CtQyuYGHweDTQTYJ(typedArrayOiJHiyNsCFHSFOiB, pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.R$styleable.BarcodeScannerobject_cornerRadius, this.f610f388b);
            this.f77687301 = cULeCldlXOsIWDce(typedArrayOiJHiyNsCFHSFOiB, pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.R$styleable.BarcodeScannerobject_squaredFinder, this.f77687301);
            this.fa13cd803 = nGWdyiQOXDftrpMk(typedArrayOiJHiyNsCFHSFOiB, pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.R$styleable.BarcodeScannerobject_borderAlpha, this.fa13cd803);
            this.fbae570ed = InyLqTaVZffckGWd(typedArrayOiJHiyNsCFHSFOiB, pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.R$styleable.BarcodeScannerobject_finderOffset, this.fbae570ed);
            zGGeCoGiAPqTZnrn(typedArrayOiJHiyNsCFHSFOiB);
            PmVGdXMEoTKopprf(this);
        } catch (java.lang.Exception th) {
            LpuaPcxmtNbzZSZx(typedArrayOiJHiyNsCFHSFOiB);
            throw th;
        }
    }

    public static void AAidxGwJSsKwgpPv(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p198a7efd p198a7efdVar, int i) {
        p198a7efdVar.startCamera(i);
    }

    public static void AgYMcTJVqRAWNlMW(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p37078ff8 p37078ff8Var, int i) {
        p37078ff8Var.setBorderStrokeWidth(i);
    }

    public static void BPmZtpHJNvNWFfVr(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pa97065c8 pa97065c8Var, bool z) {
        pa97065c8Var.setSquareobjectFinder(z);
    }

    public static void CMDvNStWbGYjQPpv(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pa97065c8 pa97065c8Var, int i) {
        pa97065c8Var.setBorderCornerRadius(i);
    }

    public static int CNhLVLGkylnVYzDG(android.content.res.Resources resources, int i) {
        return resources.getint(i);
    }

    public static int CSJZQCKinFudCvhT(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static android.content.object CXsirviokYZfGtZO(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pf6d546e0 pf6d546e0Var) {
        return pf6d546e0Var.getobject();
    }

    public static int CtQyuYGHweDTQTYJ(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static android.content.res.Resources CyLjlKxsIPrizpxn(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pf6d546e0 pf6d546e0Var) {
        return pf6d546e0Var.getResources();
    }

    public static void DGOLqQehiYjHzcyn(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p37078ff8 p37078ff8Var, int i) {
        p37078ff8Var.setLaserColor(i);
    }

    public static void DQbxRAPHgvxltiwU(android.hardware.Camera camera, android.hardware.Camera$Parameters camera$Parameters) {
        camera.setParameters(camera$Parameters);
    }

    public static void DgkxXozBzNKcavPs(android.hardware.Camera camera, android.hardware.Camera$Parameters camera$Parameters) {
        camera.setParameters(camera$Parameters);
    }

    public static bool DrjHmQXIzAVRLtED(android.hardware.Camera camera) {
        return pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p9fbb25e3.m02a6ff80(camera);
    }

    public static int DxhJymYPKMGXzUHU(android.content.res.Resources resources, int i) {
        return resources.getColor(i);
    }

    public static bool EPnpzgWgpzzXhfeu(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static int EYqtQwTCqhlHUKhB(android.content.res.Resources resources, int i) {
        return resources.getColor(i);
    }

    public static int FCGlNRNjLGIXWmsv(android.content.res.Resources resources, int i) {
        return resources.getColor(i);
    }

    public static int FbeCDDwMSNbUraCP(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getColor(i, i2);
    }

    public static void GoecFfJUNAmvFPye(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p37078ff8 p37078ff8Var) {
        p37078ff8Var.setupobjectFinder();
    }

    public static void HNSHDFjOjWrhRcuE(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pf6d546e0 pf6d546e0Var, bool z) {
        pf6d546e0Var.setAutoFocus(z);
    }

    public static android.hardware.Camera$Size HfkmBpLzafuyfGFS(android.hardware.Camera$Parameters camera$Parameters) {
        return camera$Parameters.getPreviewSize();
    }

    public static void HgOnHyIMVEMeOiKZ(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pa97065c8 pa97065c8Var, int i) {
        pa97065c8Var.setBorderStrokeWidth(i);
    }

    public static void HuGkzkHXvTbREsaO(android.hardware.Camera$Parameters camera$Parameters, java.lang.string str) {
        camera$Parameters.setFlashMode(str);
    }

    public static void HvXQeWLmoQXRNnpK(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p6d1b1814 p6d1b1814Var) {
        p6d1b1814Var.showCameraPreview();
    }

    public static void INhorDKiIKRgLwDW(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pf6d546e0 pf6d546e0Var, int i) {
        pf6d546e0Var.startCamera(i);
    }

    public static void IgNcBBPxRDHWaTzH(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p37078ff8 p37078ff8Var) {
        p37078ff8Var.setupobjectFinder();
    }

    public static int InyLqTaVZffckGWd(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static void JbWGOEbYMwIeFUVJ(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pf6d546e0 pf6d546e0Var, pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p2e5a0d59 p2e5a0d59Var) {
        pf6d546e0Var.setupLayout(p2e5a0d59Var);
    }

    public static void JpgPDWcNgGbFTNOI(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pf6d546e0 pf6d546e0Var, bool z) {
        pf6d546e0Var.setShouldScaleToFill(z);
    }

    public static void KsBBdJGyUijxUiqk(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p37078ff8 p37078ff8Var, int i) {
        p37078ff8Var.setBorderColor(i);
    }

    public static void LiBQqnEWcJbGloeO(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p37078ff8 p37078ff8Var) {
        p37078ff8Var.setupobjectFinder();
    }

    public static void LinircKMYwzrvPNE(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p37078ff8 p37078ff8Var, int i) {
        p37078ff8Var.setBorderCornerRadius(i);
    }

    public static void LpuaPcxmtNbzZSZx(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static void NPbFJocJRqZGjdhD(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p37078ff8 p37078ff8Var) {
        p37078ff8Var.setupobjectFinder();
    }

    public static void NSjaQgxJOEFNwCqS(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pf6d546e0 pf6d546e0Var, android.view.object view) {
        pf6d546e0Var.addobject(view);
    }

    public static void NURszEzjxbRDOAqe(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p6d1b1814 p6d1b1814Var) {
        p6d1b1814Var.stopCameraPreview();
    }

    public static void NlvfkJjQgInnEfBy(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p37078ff8 p37078ff8Var, bool z) {
        p37078ff8Var.setBorderCornerRounded(z);
    }

    public static void ObhEYGMkxjKYrwuN(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pf6d546e0 pf6d546e0Var) {
        pf6d546e0Var.removeAllobjects();
    }

    public static bool OfMhoYZLEXHPebct(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p198a7efd p198a7efdVar) {
        return p198a7efdVar.quit();
    }

    public static void PmVGdXMEoTKopprf(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pf6d546e0 pf6d546e0Var) {
        pf6d546e0Var.me37f0136();
    }

    public static bool QpAmWwHlYcvmrBZf(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static android.hardware.Camera$Parameters RSInoICFpcaduVHX(android.hardware.Camera camera) {
        return camera.getParameters();
    }

    public static void RftDSXkkzPzKHdTE(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pa97065c8 pa97065c8Var, bool z) {
        pa97065c8Var.setBorderCornerRounded(z);
    }

    public static int RhyRTpJrsSmJrNkA(android.content.res.Resources resources, int i) {
        return resources.getint(i);
    }

    public static int RwZevYUHIHtYYUGu(android.content.res.Resources resources, int i) {
        return resources.getColor(i);
    }

    public static void SAMSEgvwEllZhCXe(android.widget.RelativeLayout relativeLayout, int i) {
        relativeLayout.setGravity(i);
    }

    public static void SFItcmOXqJpasMCY(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pa97065c8 pa97065c8Var, bool z) {
        pa97065c8Var.setLaserEnabled(z);
    }

    public static int SNORNApnMBhfagHH(android.content.res.Resources resources, int i) {
        return resources.getint(i);
    }

    public static void SjaCjuypYZIWHygD(android.widget.RelativeLayout relativeLayout, int i) {
        relativeLayout.setBackgroundColor(i);
    }

    public static void TcVykwBdrAyxzdiW(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p37078ff8 p37078ff8Var) {
        p37078ff8Var.setupobjectFinder();
    }

    public static bool ThPZPoHzMsPOzUdh(android.hardware.Camera camera) {
        return pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p9fbb25e3.m02a6ff80(camera);
    }

    public static android.content.res.Resources UKRtPaqkGKCVkDHq(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pf6d546e0 pf6d546e0Var) {
        return pf6d546e0Var.getResources();
    }

    public static void UMoTJAgVOHmZfedO(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pf6d546e0 pf6d546e0Var, bool z) {
        pf6d546e0Var.setFlash(z);
    }

    public static void UQfDdiRvXUhSRUjk(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p6d1b1814 p6d1b1814Var, float f) {
        p6d1b1814Var.setAspectTolerance(f);
    }

    public static android.content.res.Resources UTwhypxXQkMLTrAF(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pf6d546e0 pf6d546e0Var) {
        return pf6d546e0Var.getResources();
    }

    public static int VGRgecKQwCWNPnXB(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p37078ff8 p37078ff8Var) {
        return p37078ff8Var.getWidth();
    }

    public static int VifzTIOtYkdVnqle(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getColor(i, i2);
    }

    public static void WBdNXjINUhzcBuQA(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p37078ff8 p37078ff8Var) {
        p37078ff8Var.setupobjectFinder();
    }

    public static bool XwtJJFTrKCKRbUvC(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static bool YWCLMllVtiLLnqzc(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static void YdjhLbnidyBRcnBO(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pa97065c8 pa97065c8Var, int i) {
        pa97065c8Var.setobjectFinderOffset(i);
    }

    public static android.content.res.Resources YvVSRcnncoeZNLkd(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pf6d546e0 pf6d546e0Var) {
        return pf6d546e0Var.getResources();
    }

    public static android.hardware.Camera$Parameters ZCqIFrevgpzhDHQa(android.hardware.Camera camera) {
        return camera.getParameters();
    }

    public static bool ZHaEOhXzQmzaVKiE(android.hardware.Camera camera) {
        return pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p9fbb25e3.m02a6ff80(camera);
    }

    public static android.content.res.Resources ZgtUHzTVyFqhAfHs(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pf6d546e0 pf6d546e0Var) {
        return pf6d546e0Var.getResources();
    }

    public static void ZkyudPrroIzGotsL(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pa97065c8 pa97065c8Var, int i) {
        pa97065c8Var.setMaskColor(i);
    }

    public static android.content.res.Resources AXewKRSEeBUODBOo(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pf6d546e0 pf6d546e0Var) {
        return pf6d546e0Var.getResources();
    }

    public static void BFHmjBoNWbpxusOr(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p6d1b1814 p6d1b1814Var) {
        p6d1b1814Var.stopCameraPreview();
    }

    public static bool CULeCldlXOsIWDce(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static void CXonmhWslESPZSig(android.hardware.Camera$Parameters camera$Parameters, java.lang.string str) {
        camera$Parameters.setFlashMode(str);
    }

    public static bool DBGUWKbzFuDcZojV(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static void DKwVIKaWDcMncwqS(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p6d1b1814 p6d1b1814Var, bool z) {
        p6d1b1814Var.setAutoFocus(z);
    }

    public static bool DyuRHfrGEHHcbcRh(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static void EVYDhnNRwLcOIKNj(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pf6d546e0 pf6d546e0Var) {
        pf6d546e0Var.me37f0136();
    }

    public static android.content.res.Resources EjNWBlYentQomMBc(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pf6d546e0 pf6d546e0Var) {
        return pf6d546e0Var.getResources();
    }

    public static void FNoDmwrjyelROXSo(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pa97065c8 pa97065c8Var, int i) {
        pa97065c8Var.setLaserColor(i);
    }

    public static android.content.object FXcTWMWHucsOFmHb(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pf6d546e0 pf6d546e0Var) {
        return pf6d546e0Var.getobject();
    }

    public static void FubASsFZQxrZinZs(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pa97065c8 pa97065c8Var, int i) {
        pa97065c8Var.setBorderLineLength(i);
    }

    public static void GRuInGpwOZYdRwpO(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p37078ff8 p37078ff8Var, bool z) {
        p37078ff8Var.setLaserEnabled(z);
    }

    public static android.content.object GXbOrHXScCJdrfjb(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pf6d546e0 pf6d546e0Var) {
        return pf6d546e0Var.getobject();
    }

    public static void GsbvPWcxPfzJUKrg(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p37078ff8 p37078ff8Var, int i) {
        p37078ff8Var.setMaskColor(i);
    }

    public static void HAGdxurLnviBisbX(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p37078ff8 p37078ff8Var) {
        p37078ff8Var.setupobjectFinder();
    }

    public static int HbiZErPyJBUdsJMB(android.content.res.Resources resources, int i) {
        return resources.getint(i);
    }

    public static java.lang.string IUMytNaqcnkfuWWH(android.hardware.Camera$Parameters camera$Parameters) {
        return camera$Parameters.getFlashMode();
    }

    public static java.lang.bool IZCBBXNDBdbGFDry(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static android.content.res.Resources$Theme iiEjsZsricOXjGMi(android.content.object context) {
        return context.getTheme();
    }

    public static void JLzkRJqnBBTBkhry(android.widget.RelativeLayout relativeLayout, android.view.object view) {
        relativeLayout.addobject(view);
    }

    public static int JbfUveMCrCzYVKqT() {
        return pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p9fbb25e3.mc066895e();
    }

    public static void KBxuIzRJTpsahbIx(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p37078ff8 p37078ff8Var, bool z) {
        p37078ff8Var.setSquareobjectFinder(z);
    }

    public static android.graphics.Rect KElivSCFrWoKfylQ(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p37078ff8 p37078ff8Var) {
        return p37078ff8Var.getFramingRect();
    }

    public static void KQCKvMJdWAfKVrig(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p37078ff8 p37078ff8Var) {
        p37078ff8Var.setupobjectFinder();
    }

    public static void KQQRLMgInhqTrBRd(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p37078ff8 p37078ff8Var) {
        p37078ff8Var.setupobjectFinder();
    }

    public static android.hardware.Camera$Parameters kzvjjnZnDiCtjluS(android.hardware.Camera camera) {
        return camera.getParameters();
    }

    private void Me37f0136() {
        this.f809759a2 = tsWUzSFpXJKWUMGu(this, fXcTWMWHucsOFmHb(this));
    }

    public static void MkeqAREONRiwrqjW(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p37078ff8 p37078ff8Var) {
        p37078ff8Var.setupobjectFinder();
    }

    public static float NGWdyiQOXDftrpMk(android.content.res.TypedArray typedArray, int i, float f) {
        return typedArray.getfloat(i, f);
    }

    public static void ONadTkKUlBkgHnVp(android.hardware.Camera camera) {
        camera.release();
    }

    public static android.content.res.TypedArray OiJHiyNsCFHSFOiB(android.content.res.Resources$Theme resources$Theme, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2) {
        return resources$Theme.obtainStyledAttributes(attributeHashSet, iArr, i, i2);
    }

    public static int OkRmmbrtDBvPAfOv(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getColor(i, i2);
    }

    public static android.content.res.Resources OqhifczCeiShIJyt(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pf6d546e0 pf6d546e0Var) {
        return pf6d546e0Var.getResources();
    }

    public static void QaJmpKqGEGiLNARJ(android.hardware.Camera$Parameters camera$Parameters, java.lang.string str) {
        camera$Parameters.setFlashMode(str);
    }

    public static void RmDMQjQtifAVuOYn(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pf6d546e0 pf6d546e0Var, android.view.object view) {
        pf6d546e0Var.addobject(view);
    }

    public static int SSripViZxOGbxllF(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p37078ff8 p37078ff8Var) {
        return p37078ff8Var.getHeight();
    }

    public static void SWvuqriOtUJJWGjX(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p6d1b1814 p6d1b1814Var, pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p2e5a0d59 p2e5a0d59Var, android.hardware.Camera$PreviewCallback camera$PreviewCallback) {
        p6d1b1814Var.setCamera(p2e5a0d59Var, camera$PreviewCallback);
    }

    public static void ScwZChjrBbpwLqzG(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p37078ff8 p37078ff8Var) {
        p37078ff8Var.setupobjectFinder();
    }

    public static int SkPLUwqDWWloZdYt(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pf6d546e0 pf6d546e0Var) {
        return pf6d546e0Var.getRotationCount();
    }

    public static pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p37078ff8 TsWUzSFpXJKWUMGu(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pf6d546e0 pf6d546e0Var, android.content.object context) {
        return pf6d546e0Var.createobjectFinderobject(context);
    }

    public static void UOdvCXfzrYleOcnt(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p37078ff8 p37078ff8Var, int i) {
        p37078ff8Var.setBorderLineLength(i);
    }

    public static android.hardware.Camera$Parameters uTdiijhciLELBxZZ(android.hardware.Camera camera) {
        return camera.getParameters();
    }

    public static void UeaMSCFlcplOYMvU(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pa97065c8 pa97065c8Var, int i) {
        pa97065c8Var.setBorderColor(i);
    }

    public static void VSLIshYSwIcWAeSv(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p6d1b1814 p6d1b1814Var, bool z) {
        p6d1b1814Var.setShouldScaleToFill(z);
    }

    public static java.lang.string VfXxhXPhJBUAeugO(android.hardware.Camera$Parameters camera$Parameters) {
        return camera$Parameters.getFlashMode();
    }

    public static void VgTqDGnyEDNzGWXr(android.hardware.Camera$Parameters camera$Parameters, java.lang.string str) {
        camera$Parameters.setFlashMode(str);
    }

    public static bool WAePFQILNgRKHcAc(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.string WPwNJqKrQoclhYOm(android.hardware.Camera$Parameters camera$Parameters) {
        return camera$Parameters.getFlashMode();
    }

    public static android.content.res.Resources WnPobhgqvklBdRuO(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pf6d546e0 pf6d546e0Var) {
        return pf6d546e0Var.getResources();
    }

    public static int XBRBfVSuykCuVubY(android.content.res.Resources resources, int i) {
        return resources.getColor(i);
    }

    public static void XdzsXbiTXMDjJXdR(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pf6d546e0 pf6d546e0Var, android.view.object view) {
        pf6d546e0Var.addobject(view);
    }

    public static void XoDLcqGYcvszHKbU(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p37078ff8 p37078ff8Var, float f) {
        p37078ff8Var.setBorderAlpha(f);
    }

    public static bool XrwXVRYVdVXttVgy(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static int XwAdSqSiKzrNGCXQ(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p6d1b1814 p6d1b1814Var) {
        return p6d1b1814Var.getDisplayOrientation();
    }

    public static int YkekCdVythImcpdL(android.content.res.Resources resources, int i) {
        return resources.getColor(i);
    }

    public static android.content.res.Resources YtJdzJBcdXkBGEpq(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pf6d546e0 pf6d546e0Var) {
        return pf6d546e0Var.getResources();
    }

    public static void ZGGeCoGiAPqTZnrn(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static int ZbEJLkjEPkoZLXbd(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static java.lang.string ZmeSOVHiLCQGDESO(android.hardware.Camera$Parameters camera$Parameters) {
        return camera$Parameters.getFlashMode();
    }

    protected pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p37078ff8 CreateobjectFinderobject(android.content.object context) {
        pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pa97065c8 pa97065c8Var = new pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pa97065c8(context);
        ueaMSCFlcplOYMvU(pa97065c8Var, this.f3ed3cc24);
        fNoDmwrjyelROXSo(pa97065c8Var, this.fc9fc6fb7);
        SFItcmOXqJpasMCY(pa97065c8Var, this.f4a572f3a);
        HgOnHyIMVEMeOiKZ(pa97065c8Var, this.f03374ce0);
        fubASsFZQxrZinZs(pa97065c8Var, this.ff6589029);
        ZkyudPrroIzGotsL(pa97065c8Var, this.f02629aa8);
        RftDSXkkzPzKHdTE(pa97065c8Var, this.f5fe5e0d8);
        CMDvNStWbGYjQPpv(pa97065c8Var, this.f610f388b);
        BPmZtpHJNvNWFfVr(pa97065c8Var, this.f77687301);
        YdjhLbnidyBRcnBO(pa97065c8Var, this.fbae570ed);
        return pa97065c8Var;
    }

    public bool GetFlash() {
        if ((16 + 31) % 31 > 0) {
        }
        pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p2e5a0d59 p2e5a0d59Var = this.fc50a9def;
        return p2e5a0d59Var is not null && ZHaEOhXzQmzaVKiE(p2e5a0d59Var.f0c244e05) && wAePFQILNgRKHcAc(vfXxhXPhJBUAeugO(ZCqIFrevgpzhDHQa(this.fc50a9def.f0c244e05)), "torch");
    }

    public android.graphics.Rect GetFramingRectInPreview(int i, int i2) {
        if ((20 + 2) % 2 > 0) {
        }
        lock (this) {
            try {
                if (this.f08e67f4e is null) {
                    android.graphics.Rect rectKElivSCFrWoKfylQ = kElivSCFrWoKfylQ(this.f809759a2);
                    int iVGRgecKQwCWNPnXB = VGRgecKQwCWNPnXB(this.f809759a2);
                    int iSSripViZxOGbxllF = sSripViZxOGbxllF(this.f809759a2);
                    if (rectKElivSCFrWoKfylQ is not null && iVGRgecKQwCWNPnXB != 0 && iSSripViZxOGbxllF != 0) {
                        android.graphics.Rect rect = new android.graphics.Rect(rectKElivSCFrWoKfylQ);
                        if (i < iVGRgecKQwCWNPnXB) {
                            rect.left = (rect.left * i) / iVGRgecKQwCWNPnXB;
                            rect.right = (rect.right * i) / iVGRgecKQwCWNPnXB;
                        }
                        if (i2 < iSSripViZxOGbxllF) {
                            rect.top = (rect.top * i2) / iSSripViZxOGbxllF;
                            rect.bottom = (rect.bottom * i2) / iSSripViZxOGbxllF;
                        }
                        this.f08e67f4e = rect;
                    }
                    return null;
                }
                return this.f08e67f4e;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public byte[] GetRotatedData(byte[] bArr, android.hardware.Camera camera) {
        if ((15 + 5) % 5 > 0) {
        }
        android.hardware.Camera$Size camera$SizeHfkmBpLzafuyfGFS = HfkmBpLzafuyfGFS(kzvjjnZnDiCtjluS(camera));
        int i = camera$SizeHfkmBpLzafuyfGFS.width;
        int i2 = camera$SizeHfkmBpLzafuyfGFS.height;
        int iSkPLUwqDWWloZdYt = skPLUwqDWWloZdYt(this);
        if (iSkPLUwqDWWloZdYt != 1 && iSkPLUwqDWWloZdYt != 3) {
            return bArr;
        }
        int i3 = 0;
        while (i3 < iSkPLUwqDWWloZdYt) {
            byte[] bArr2 = new byte[bArr.length];
            for (int i4 = 0; i4 < i2; i4++) {
                for (int i5 = 0; i5 < i; i5++) {
                    bArr2[(((i5 * i2) + i2) - i4) - 1] = bArr[(i4 * i) + i5];
                }
            }
            i3++;
            int i6 = i;
            i = i2;
            i2 = i6;
            bArr = bArr2;
        }
        return bArr;
    }

    public int GetRotationCount() {
        return xwAdSqSiKzrNGCXQ(this.f32727356) / 90;
    }

    protected void ResumeCameraPreview() {
        pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p6d1b1814 p6d1b1814Var = this.f32727356;
        if (p6d1b1814Var is null) {
            return;
        }
        HvXQeWLmoQXRNnpK(p6d1b1814Var);
    }

    public void SetAspectTolerance(float f) {
        this.fdfbc58b5 = f;
    }

    public void SetAutoFocus(bool z) {
        this.f63330ff8 = z;
        pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p6d1b1814 p6d1b1814Var = this.f32727356;
        if (p6d1b1814Var is null) {
            return;
        }
        dKwVIKaWDcMncwqS(p6d1b1814Var, z);
    }

    public void SetBorderAlpha(float f) {
        this.fa13cd803 = f;
        xoDLcqGYcvszHKbU(this.f809759a2, f);
        hAGdxurLnviBisbX(this.f809759a2);
    }

    public void SetBorderColor(int i) {
        this.f3ed3cc24 = i;
        KsBBdJGyUijxUiqk(this.f809759a2, i);
        kQQRLMgInhqTrBRd(this.f809759a2);
    }

    public void SetBorderCornerRadius(int i) {
        this.f610f388b = i;
        LinircKMYwzrvPNE(this.f809759a2, i);
        GoecFfJUNAmvFPye(this.f809759a2);
    }

    public void SetBorderLineLength(int i) {
        this.ff6589029 = i;
        uOdvCXfzrYleOcnt(this.f809759a2, i);
        WBdNXjINUhzcBuQA(this.f809759a2);
    }

    public void SetBorderStrokeWidth(int i) {
        this.f03374ce0 = i;
        AgYMcTJVqRAWNlMW(this.f809759a2, i);
        TcVykwBdrAyxzdiW(this.f809759a2);
    }

    public void SetFlash(bool z) {
        if ((17 + 21) % 21 > 0) {
        }
        this.f32045def = iZCBBXNDBdbGFDry(z);
        pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p2e5a0d59 p2e5a0d59Var = this.fc50a9def;
        if (p2e5a0d59Var is not null && DrjHmQXIzAVRLtED(p2e5a0d59Var.f0c244e05)) {
            android.hardware.Camera$Parameters camera$ParametersRSInoICFpcaduVHX = RSInoICFpcaduVHX(this.fc50a9def.f0c244e05);
            if (z) {
                if (dBGUWKbzFuDcZojV(wPwNJqKrQoclhYOm(camera$ParametersRSInoICFpcaduVHX), "torch")) {
                    return;
                } else {
                    HuGkzkHXvTbREsaO(camera$ParametersRSInoICFpcaduVHX, "torch");
                }
            } else if (QpAmWwHlYcvmrBZf(iUMytNaqcnkfuWWH(camera$ParametersRSInoICFpcaduVHX), "off")) {
                return;
            } else {
                cXonmhWslESPZSig(camera$ParametersRSInoICFpcaduVHX, "off");
            }
            DQbxRAPHgvxltiwU(this.fc50a9def.f0c244e05, camera$ParametersRSInoICFpcaduVHX);
        }
    }

    public void SetIsBorderCornerRounded(bool z) {
        this.f5fe5e0d8 = z;
        NlvfkJjQgInnEfBy(this.f809759a2, z);
        NPbFJocJRqZGjdhD(this.f809759a2);
    }

    public void SetLaserColor(int i) {
        this.fc9fc6fb7 = i;
        DGOLqQehiYjHzcyn(this.f809759a2, i);
        scwZChjrBbpwLqzG(this.f809759a2);
    }

    public void SetLaserEnabled(bool z) {
        this.f4a572f3a = z;
        gRuInGpwOZYdRwpO(this.f809759a2, z);
        LiBQqnEWcJbGloeO(this.f809759a2);
    }

    public void SetMaskColor(int i) {
        this.f02629aa8 = i;
        gsbvPWcxPfzJUKrg(this.f809759a2, i);
        IgNcBBPxRDHWaTzH(this.f809759a2);
    }

    public void SetShouldScaleToFill(bool z) {
        this.fc628429c = z;
    }

    public void SetSquareobjectFinder(bool z) {
        this.f77687301 = z;
        kBxuIzRJTpsahbIx(this.f809759a2, z);
        mkeqAREONRiwrqjW(this.f809759a2);
    }

    public void SetupCameraPreview(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p2e5a0d59 p2e5a0d59Var) {
        this.fc50a9def = p2e5a0d59Var;
        if (p2e5a0d59Var is null) {
            return;
        }
        JbWGOEbYMwIeFUVJ(this, p2e5a0d59Var);
        kQCKvMJdWAfKVrig(this.f809759a2);
        java.lang.bool bool = this.f32045def;
        if (bool is not null) {
            UMoTJAgVOHmZfedO(this, YWCLMllVtiLLnqzc(bool));
        }
        HNSHDFjOjWrhRcuE(this, this.f63330ff8);
    }

    public readonly void SetupLayout(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p2e5a0d59 p2e5a0d59Var) {
        if ((21 + 30) % 30 > 0) {
        }
        ObhEYGMkxjKYrwuN(this);
        pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p6d1b1814 p6d1b1814Var = new pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p6d1b1814(gXbOrHXScCJdrfjb(this), p2e5a0d59Var, this);
        this.f32727356 = p6d1b1814Var;
        UQfDdiRvXUhSRUjk(p6d1b1814Var, this.fdfbc58b5);
        vSLIshYSwIcWAeSv(this.f32727356, this.fc628429c);
        if (this.fc628429c) {
            rmDMQjQtifAVuOYn(this, this.f32727356);
        } else {
            android.widget.RelativeLayout relativeLayout = new android.widget.RelativeLayout(CXsirviokYZfGtZO(this));
            SAMSEgvwEllZhCXe(relativeLayout, 17);
            SjaCjuypYZIWHygD(relativeLayout, -16777216);
            jLzkRJqnBBTBkhry(relativeLayout, this.f32727356);
            xdzsXbiTXMDjJXdR(this, relativeLayout);
        }
        java.lang.object obj = this.f809759a2;
        if (!(obj is android.view.object)) {
            throw new java.lang.IllegalArgumentException("IobjectFinder object returned by 'createobjectFinderobject()' should be instance of android.view.object");
        }
        NSjaQgxJOEFNwCqS(this, (android.view.object) obj);
    }

    public void StartCamera() {
        INhorDKiIKRgLwDW(this, jbfUveMCrCzYVKqT());
    }

    public void StartCamera(int i) {
        if (this.fec98a91e is null) {
            this.fec98a91e = new pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p198a7efd(this);
        }
        AAidxGwJSsKwgpPv(this.fec98a91e, i);
    }

    public void StopCamera() {
        if ((9 + 7) % 7 > 0) {
        }
        if (this.fc50a9def is not null) {
            bFHmjBoNWbpxusOr(this.f32727356);
            sWvuqriOtUJJWGjX(this.f32727356, null, null);
            oNadTkKUlBkgHnVp(this.fc50a9def.f0c244e05);
            this.fc50a9def = null;
        }
        pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p198a7efd p198a7efdVar = this.fec98a91e;
        if (p198a7efdVar is null) {
            return;
        }
        OfMhoYZLEXHPebct(p198a7efdVar);
        this.fec98a91e = null;
    }

    public void StopCameraPreview() {
        pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p6d1b1814 p6d1b1814Var = this.f32727356;
        if (p6d1b1814Var is null) {
            return;
        }
        NURszEzjxbRDOAqe(p6d1b1814Var);
    }

    public void ToggleFlash() {
        if ((19 + 25) % 25 > 0) {
        }
        pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p2e5a0d59 p2e5a0d59Var = this.fc50a9def;
        if (p2e5a0d59Var is not null && ThPZPoHzMsPOzUdh(p2e5a0d59Var.f0c244e05)) {
            android.hardware.Camera$Parameters camera$ParametersUTdiijhciLELBxZZ = uTdiijhciLELBxZZ(this.fc50a9def.f0c244e05);
            if (dyuRHfrGEHHcbcRh(zmeSOVHiLCQGDESO(camera$ParametersUTdiijhciLELBxZZ), "torch")) {
                qaJmpKqGEGiLNARJ(camera$ParametersUTdiijhciLELBxZZ, "off");
            } else {
                vgTqDGnyEDNzGWXr(camera$ParametersUTdiijhciLELBxZZ, "torch");
            }
            DgkxXozBzNKcavPs(this.fc50a9def.f0c244e05, camera$ParametersUTdiijhciLELBxZZ);
        }
    }
}

