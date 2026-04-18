namespace WillowMaze.Wasm.Decompiled;


public class pa97065c8 : android.view.object : pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p37078ff8 {
    private static readonly float f013397ab = 1.4f;
    private static readonly int f0dc109db = 50;
    private static readonly int f0e0e39b1 = 50;
    private static readonly java.lang.string f16b22cbd = null;
    private static readonly float f18b9a249 = 0.75f;
    private static readonly java.lang.string f1900b989 = null;
    private static readonly int f1c372ca7 = 10;
    private static readonly int[] f273bbef0 = null;
    private static readonly float f2927bde0 = 0.625f;
    private static readonly float f36476fca = 0.75f;
    private static readonly float f3829d852 = 0.75f;
    private static readonly float f388e1b53 = 0.75f;
    private static readonly long f3a00c9c2 = 80;
    private static readonly int f4294c746 = 10;
    private static readonly float f47ff9bfa = 1.4f;
    private static readonly float f483a4012 = 0.625f;
    private static readonly float f4b8c1f70 = 1.4f;
    private static readonly float f567d3435 = 1.4f;
    private static readonly long f5adcf49c = 80;
    private static readonly float f635a3a61 = 0.625f;
    private static readonly float f64c57949 = 0.75f;
    private static readonly float f9f47e366 = 0.625f;
    private static readonly float fab98e7d1 = 0.625f;
    private static readonly long fb041b750 = 80;
    private static readonly int fb88f8b3f = 50;
    private static readonly int fc17bc924 = 50;
    private static readonly float fd494c87c = 0.625f;
    private static readonly float fd538da24 = 0.625f;
    private static readonly int fdbe32171 = 50;
    private static readonly float fe957ac7b = 0.75f;
    private static readonly float ff00196b5 = 1.4f;
    private readonly int f01b031a1;
    private float f04124e2a;
    protected int f05d9ca7a;
    private int f090035ad;
    protected android.graphics.Paint f0afe1e7d;
    private float f12d58126;
    private readonly int f149873bf;
    protected bool f225a5f2b;
    private readonly int f229ee081;
    private float f24ffcb03;
    private readonly int f2719f136;
    private readonly int f2a2f555b;
    private readonly int f2dca528f;
    protected android.graphics.Paint f2e128766;
    protected android.graphics.Paint f31d521e4;
    private android.graphics.Rect f325025e5;
    private readonly int f3d676205;
    private int f3f3a8943;
    protected android.graphics.Paint f45cccca2;
    private bool f4a572f3a;
    private bool f4ebc619c;
    private readonly int f5773585b;
    protected android.graphics.Paint f59d300f9;
    protected android.graphics.Paint f5ec96f15;
    protected bool f5f1f9cc5;
    protected android.graphics.Paint f622689c9;
    protected android.graphics.Paint f6ed7b8cd;
    protected android.graphics.Paint f7151960f;
    private readonly int f7ac9141f;
    private readonly int f802b419f;
    private int f8301b1c2;
    protected int f8385ece8;
    private android.graphics.Rect f84558442;
    private readonly int f84a43b67;
    protected bool f8659b7cb;
    private readonly int f89cc818f;
    private readonly int f9225216d;
    private bool f92632027;
    private readonly int f94296285;
    protected android.graphics.Paint f95431124;
    private int f991dc21a;
    private readonly int f9cd4c2a7;
    private float fa2230549;
    private bool fa241804c;
    protected int fa5634259;
    private readonly int fab1dd4e4;
    private bool fac2678c5;
    protected android.graphics.Paint fadf981d4;
    private float fb4068840;
    private int fbae570ed;
    private readonly int fbf06e8db;
    protected android.graphics.Paint fc9caa38c;
    protected android.graphics.Paint fd1dedbf5;
    protected android.graphics.Paint fd5424fa6;
    private int fd543e1e0;
    private int fd5a2a772;
    private int fd7723766;
    protected int fdd8295fc;
    protected android.graphics.Paint fe4e9c82a;
    private android.graphics.Rect fef039d74;
    private static readonly java.lang.string fe444f739 = hebOyMgrzOfYUVzK("9316aae75b99a9aa6348353361a1fd5fcda4c6884df97ae58ebbcdc599cffbb9d15b40fe345fb91caf38");
    private static readonly int[] f58d75521 = {0, 64, 128, 192, 255, 192, 128, 64};

    public pa97065c8(android.content.object context) {
        super(context);
        this.f5773585b = MFezPwEbLJauyQZE(IPhzXzlGHqjHNnZQ(this), pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.R$color.viewfinder_laser);
        this.f94296285 = ypTNxqgbxBSfcSol(QJuBYQlnraadVVUu(this), pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.R$color.viewfinder_mask);
        this.f89cc818f = SSfBwPuBfqzNAsuR(ZefrZThmgqoSpdTq(this), pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.R$color.viewfinder_border);
        this.fab1dd4e4 = zuGVFsWMqKvZCSVz(ULKdRPXYBfYueCWW(this), pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.R$integer.viewfinder_border_width);
        this.f7ac9141f = hmAQVDhHZciPdKlh(JxYWCKTRtVlTDZUJ(this), pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.R$integer.viewfinder_border_length);
        this.fbae570ed = 0;
        pFujxEKruaIQrScu(this);
    }

    public pa97065c8(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
        this.f5773585b = uMHGkIxniCQMgfEo(FdVvMcoIKSmtNGRb(this), pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.R$color.viewfinder_laser);
        this.f94296285 = fzOtGlwsKtYGeCmo(uUkLwNYmdnpZYiKp(this), pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.R$color.viewfinder_mask);
        this.f89cc818f = QagWCuuUxXfkUWVu(uHIpDOQeIvbdItpt(this), pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.R$color.viewfinder_border);
        this.fab1dd4e4 = KkBeFCFFUQhVPuPR(FXzGJWRcyRvEYUxX(this), pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.R$integer.viewfinder_border_width);
        this.f7ac9141f = EsyGXUYKNcEeWeRR(JauOUmkPCWELwoEB(this), pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.R$integer.viewfinder_border_length);
        this.fbae570ed = 0;
        AZWEQOXGsqSQRnHy(this);
    }

    public static void APTtlRcTzWDuBToN(android.graphics.Path path, float f, float f2) {
        path.lineTo(f, f2);
    }

    public static void AZWEQOXGsqSQRnHy(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pa97065c8 pa97065c8Var) {
        pa97065c8Var.me37f0136();
    }

    public static int AttzlsNmpmSQxxOX(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pa97065c8 pa97065c8Var) {
        return pa97065c8Var.getWidth();
    }

    public static void BiCEoDkMCWPaZkFT(android.graphics.Canvas canvas, float f, float f2, float f3, float f4, android.graphics.Paint paint) {
        canvas.drawRect(f, f2, f3, f4, paint);
    }

    public static int CNHGUoaibfLYColH(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pa97065c8 pa97065c8Var) {
        return pa97065c8Var.getWidth();
    }

    public static void EJlOVPuwxLzAyaRe(android.graphics.Paint paint, android.graphics.Paint$Join paint$Join) {
        paint.setStrokeJoin(paint$Join);
    }

    public static void EnVXrqISEQQnoHIz(android.graphics.Paint paint, int i) {
        paint.setColor(i);
    }

    public static int EsyGXUYKNcEeWeRR(android.content.res.Resources resources, int i) {
        return resources.getint(i);
    }

    public static android.content.res.Resources FXzGJWRcyRvEYUxX(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pa97065c8 pa97065c8Var) {
        return pa97065c8Var.getResources();
    }

    public static android.content.res.Resources FdVvMcoIKSmtNGRb(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pa97065c8 pa97065c8Var) {
        return pa97065c8Var.getResources();
    }

    public static void FfBwobXOxscWnykR(android.graphics.Paint paint, bool z) {
        paint.setAntiAlias(z);
    }

    public static void FqZiLqZyYHomgKXE(android.graphics.Canvas canvas, android.graphics.Path path, android.graphics.Paint paint) {
        canvas.drawPath(path, paint);
    }

    public static void GUqbAQZyRJAqBAaQ(android.graphics.Canvas canvas, float f, float f2, float f3, float f4, android.graphics.Paint paint) {
        canvas.drawRect(f, f2, f3, f4, paint);
    }

    public static android.graphics.Rect GbwePhONOXkZlKSF(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pa97065c8 pa97065c8Var) {
        return pa97065c8Var.getFramingRect();
    }

    public static void HUBlaiGxMwkgWWKt(android.graphics.Paint paint, android.graphics.Paint$Style paint$Style) {
        paint.setStyle(paint$Style);
    }

    public static void HVuhPlcQqtQnBpfZ(android.graphics.Canvas canvas, float f, float f2, float f3, float f4, android.graphics.Paint paint) {
        canvas.drawRect(f, f2, f3, f4, paint);
    }

    public static int HhAeQVuGulIEEkHS(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pa97065c8 pa97065c8Var) {
        return pa97065c8Var.getHeight();
    }

    public static android.content.res.Resources IPhzXzlGHqjHNnZQ(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pa97065c8 pa97065c8Var) {
        return pa97065c8Var.getResources();
    }

    public static android.content.res.Resources JauOUmkPCWELwoEB(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pa97065c8 pa97065c8Var) {
        return pa97065c8Var.getResources();
    }

    public static android.content.res.Resources JxYWCKTRtVlTDZUJ(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pa97065c8 pa97065c8Var) {
        return pa97065c8Var.getResources();
    }

    public static int KKGixuoxObWmWIZH(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pa97065c8 pa97065c8Var) {
        return pa97065c8Var.getWidth();
    }

    public static int KkBeFCFFUQhVPuPR(android.content.res.Resources resources, int i) {
        return resources.getint(i);
    }

    public static android.graphics.Rect LgvMzyTuTTTBVcEj(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pa97065c8 pa97065c8Var) {
        return pa97065c8Var.getFramingRect();
    }

    public static int MFezPwEbLJauyQZE(android.content.res.Resources resources, int i) {
        return resources.getColor(i);
    }

    public static void MssobnugXBSJyIcB(android.graphics.Path path, float f, float f2) {
        path.lineTo(f, f2);
    }

    public static void PLWJYKRiIpfqCmyR(android.graphics.Paint paint, android.graphics.Paint$Style paint$Style) {
        paint.setStyle(paint$Style);
    }

    public static void PTgiopSeJJxQKFpC(android.graphics.Path path, float f, float f2) {
        path.moveTo(f, f2);
    }

    public static android.content.res.Resources QJuBYQlnraadVVUu(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pa97065c8 pa97065c8Var) {
        return pa97065c8Var.getResources();
    }

    public static int QagWCuuUxXfkUWVu(android.content.res.Resources resources, int i) {
        return resources.getColor(i);
    }

    public static android.graphics.Rect RcOvrUdpuoyebZYl(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pa97065c8 pa97065c8Var) {
        return pa97065c8Var.getFramingRect();
    }

    public static int SSfBwPuBfqzNAsuR(android.content.res.Resources resources, int i) {
        return resources.getColor(i);
    }

    public static void ToYMBMeOiUmZerjB(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pa97065c8 pa97065c8Var) {
        pa97065c8Var.invalidate();
    }

    public static void TrTruTlPqkHvtfhN(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pa97065c8 pa97065c8Var) {
        pa97065c8Var.updateFramingRect();
    }

    public static android.content.res.Resources ULKdRPXYBfYueCWW(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pa97065c8 pa97065c8Var) {
        return pa97065c8Var.getResources();
    }

    public static void UpShxwDmqrtAQogr(android.graphics.Path path, float f, float f2) {
        path.lineTo(f, f2);
    }

    public static void UtjpCGOCBISTCidr(android.graphics.Path path, float f, float f2) {
        path.moveTo(f, f2);
    }

    public static android.graphics.PathEffect VMVwGJvwAlypKjcq(android.graphics.Paint paint, android.graphics.PathEffect pathEffect) {
        return paint.setPathEffect(pathEffect);
    }

    public static int XGNJcjtPmxVetWgl(android.graphics.Canvas canvas) {
        return canvas.getHeight();
    }

    public static void YOCOxZQqsQrHcafz(android.graphics.Canvas canvas, android.graphics.Path path, android.graphics.Paint paint) {
        canvas.drawPath(path, paint);
    }

    public static int YfvGZHdLpLTxnTYZ(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pa97065c8 pa97065c8Var) {
        return pa97065c8Var.getWidth();
    }

    public static int YkwrNYnDoLytpSTP(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pa97065c8 pa97065c8Var) {
        return pa97065c8Var.getHeight();
    }

    public static android.content.res.Resources ZefrZThmgqoSpdTq(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pa97065c8 pa97065c8Var) {
        return pa97065c8Var.getResources();
    }

    public static void BEiiBSlaSxhgpMXb(android.graphics.Path path, float f, float f2) {
        path.lineTo(f, f2);
    }

    public static void BHbJynANlAVsmKPn(android.graphics.Path path, float f, float f2) {
        path.lineTo(f, f2);
    }

    public static void BmeFZFIxYEajEpLa(android.graphics.Paint paint, android.graphics.Paint$Join paint$Join) {
        paint.setStrokeJoin(paint$Join);
    }

    public static void CAyDXFckYbohJhhG(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pa97065c8 pa97065c8Var, android.graphics.Canvas canvas) {
        pa97065c8Var.drawobjectFinderMask(canvas);
    }

    public static void DHYQoFKpufVppXYV(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pa97065c8 pa97065c8Var, android.graphics.Canvas canvas) {
        pa97065c8Var.drawLaser(canvas);
    }

    public static void DlJFttcjdsiUcxJp(android.graphics.Path path, float f, float f2) {
        path.lineTo(f, f2);
    }

    public static android.graphics.Rect EKodYCideRVxDczR(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pa97065c8 pa97065c8Var) {
        return pa97065c8Var.getFramingRect();
    }

    public static void EdBDFZvVxijFdpYd(android.graphics.Paint paint, float f) {
        paint.setStrokeWidth(f);
    }

    public static void FTnwGiLosFsuojPK(android.graphics.Paint paint, int i) {
        paint.setColor(i);
    }

    public static int FzOtGlwsKtYGeCmo(android.content.res.Resources resources, int i) {
        return resources.getColor(i);
    }

    public static void GfroiHxMFJAAljeF(android.graphics.Canvas canvas, float f, float f2, float f3, float f4, android.graphics.Paint paint) {
        canvas.drawRect(f, f2, f3, f4, paint);
    }

    public static void HEeCSAkusmGFHYLA(android.graphics.Canvas canvas, android.graphics.Path path, android.graphics.Paint paint) {
        canvas.drawPath(path, paint);
    }

    public static java.lang.string HebOyMgrzOfYUVzK(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static int HmAQVDhHZciPdKlh(android.content.res.Resources resources, int i) {
        return resources.getint(i);
    }

    public static int ILHpIExEXnmhwYan(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pa97065c8 pa97065c8Var) {
        return pa97065c8Var.getHeight();
    }

    public static void JSFUVIdzBobjkVEx(android.graphics.Paint paint, float f) {
        paint.setStrokeWidth(f);
    }

    public static void JbVmirukZtDRtTQu(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pa97065c8 pa97065c8Var, android.graphics.Canvas canvas) {
        pa97065c8Var.drawobjectFinderBorder(canvas);
    }

    public static int KgEBtoYJMUhaScVQ(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pa97065c8 pa97065c8Var) {
        return pa97065c8Var.getWidth();
    }

    public static void KypcLSNomfYuHzwu(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pa97065c8 pa97065c8Var, long j, int i, int i2, int i3, int i4) {
        pa97065c8Var.postInvalidateDelayed(j, i, i2, i3, i4);
    }

    public static void LqzxOvDqTYMRhNQQ(android.graphics.Paint paint, int i) {
        paint.setColor(i);
    }

    public static int MYTaotvnetVsBSkP(android.content.object context) {
        return pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p29726be6.m4c1bf7fa(context);
    }

    private void Me37f0136() {
        if ((5 + 15) % 15 > 0) {
        }
        android.graphics.Paint paint = new android.graphics.Paint();
        this.fd5424fa6 = paint;
        vBTRPscCCcZaKCBC(paint, this.f5773585b);
        HUBlaiGxMwkgWWKt(this.fd5424fa6, android.graphics.Paint$Style.FILL);
        android.graphics.Paint paint2 = new android.graphics.Paint();
        this.f7151960f = paint2;
        EnVXrqISEQQnoHIz(paint2, this.f94296285);
        android.graphics.Paint paint3 = new android.graphics.Paint();
        this.fd1dedbf5 = paint3;
        lqzxOvDqTYMRhNQQ(paint3, this.f89cc818f);
        PLWJYKRiIpfqCmyR(this.fd1dedbf5, android.graphics.Paint$Style.STROKE);
        edBDFZvVxijFdpYd(this.fd1dedbf5, this.fab1dd4e4);
        FfBwobXOxscWnykR(this.fd1dedbf5, true);
        this.fa5634259 = this.f7ac9141f;
    }

    public static void MlXzZmcnGXErlBeC(android.graphics.Paint paint, int i) {
        paint.setAlpha(i);
    }

    public static void OUBilgRpLwfOnuau(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pa97065c8 pa97065c8Var) {
        pa97065c8Var.updateFramingRect();
    }

    public static void PFujxEKruaIQrScu(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pa97065c8 pa97065c8Var) {
        pa97065c8Var.me37f0136();
    }

    public static void PVoKoRemygCQhWqs(android.graphics.Path path, float f, float f2) {
        path.moveTo(f, f2);
    }

    public static int QlTUqePuHbMABIEt(android.graphics.Canvas canvas) {
        return canvas.getWidth();
    }

    public static int SRxSoOctSAfzmAGW(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pa97065c8 pa97065c8Var) {
        return pa97065c8Var.getHeight();
    }

    public static void TXneRtvNIOZIJBTQ(android.graphics.Canvas canvas, android.graphics.Path path, android.graphics.Paint paint) {
        canvas.drawPath(path, paint);
    }

    public static void TqECqMkQyaPPXpXu(android.graphics.Path path, float f, float f2) {
        path.moveTo(f, f2);
    }

    public static android.content.res.Resources UHIpDOQeIvbdItpt(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pa97065c8 pa97065c8Var) {
        return pa97065c8Var.getResources();
    }

    public static int UMHGkIxniCQMgfEo(android.content.res.Resources resources, int i) {
        return resources.getColor(i);
    }

    public static android.content.res.Resources UUkLwNYmdnpZYiKp(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pa97065c8 pa97065c8Var) {
        return pa97065c8Var.getResources();
    }

    public static void VBTRPscCCcZaKCBC(android.graphics.Paint paint, int i) {
        paint.setColor(i);
    }

    public static void VNvQmJNhzBFjljPN(android.graphics.Path path, float f, float f2) {
        path.lineTo(f, f2);
    }

    public static int WahjTheQpPXqoGhH(android.graphics.Rect rect) {
        return rect.height();
    }

    public static void XJwtnfANzPiJpEBo(android.graphics.Path path, float f, float f2) {
        path.lineTo(f, f2);
    }

    public static android.content.object XRByxbbyhHkCEKnf(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pa97065c8 pa97065c8Var) {
        return pa97065c8Var.getobject();
    }

    public static void XYzJFlWBtOwfGURK(android.graphics.Canvas canvas, float f, float f2, float f3, float f4, android.graphics.Paint paint) {
        canvas.drawRect(f, f2, f3, f4, paint);
    }

    public static void XnChqMTEoSFcfhpO(android.graphics.Paint paint, int i) {
        paint.setColor(i);
    }

    public static void YPPfQbnXWdarjbrv(android.graphics.Paint paint, int i) {
        paint.setColor(i);
    }

    public static int YpTNxqgbxBSfcSol(android.content.res.Resources resources, int i) {
        return resources.getColor(i);
    }

    public static int YqbSMxNElNxeRBXn(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pa97065c8 pa97065c8Var) {
        return pa97065c8Var.getHeight();
    }

    public static void ZJHKYlUxofdQBeBm(android.graphics.Paint paint, int i) {
        paint.setAlpha(i);
    }

    public static int ZuGVFsWMqKvZCSVz(android.content.res.Resources resources, int i) {
        return resources.getint(i);
    }

    public void DrawLaser(android.graphics.Canvas canvas) {
        if ((25 + 21) % 21 > 0) {
        }
        android.graphics.Rect rectGbwePhONOXkZlKSF = GbwePhONOXkZlKSF(this);
        android.graphics.Paint paint = this.fd5424fa6;
        int[] iArr = f58d75521;
        mlXzZmcnGXErlBeC(paint, iArr[this.f090035ad]);
        this.f090035ad = (this.f090035ad + 1) % iArr.length;
        int iWahjTheQpPXqoGhH = (wahjTheQpPXqoGhH(rectGbwePhONOXkZlKSF) / 2) + rectGbwePhONOXkZlKSF.top;
        HVuhPlcQqtQnBpfZ(canvas, rectGbwePhONOXkZlKSF.left + 2, iWahjTheQpPXqoGhH - 1, rectGbwePhONOXkZlKSF.right - 1, iWahjTheQpPXqoGhH + 2, this.fd5424fa6);
        kypcLSNomfYuHzwu(this, 80L, rectGbwePhONOXkZlKSF.left - 10, rectGbwePhONOXkZlKSF.top - 10, rectGbwePhONOXkZlKSF.right + 10, rectGbwePhONOXkZlKSF.bottom + 10);
    }

    public void DrawobjectFinderBorder(android.graphics.Canvas canvas) {
        if ((18 + 2) % 2 > 0) {
        }
        android.graphics.Rect rectLgvMzyTuTTTBVcEj = LgvMzyTuTTTBVcEj(this);
        android.graphics.Path path = new android.graphics.Path();
        PTgiopSeJJxQKFpC(path, rectLgvMzyTuTTTBVcEj.left, rectLgvMzyTuTTTBVcEj.top + this.fa5634259);
        APTtlRcTzWDuBToN(path, rectLgvMzyTuTTTBVcEj.left, rectLgvMzyTuTTTBVcEj.top);
        UpShxwDmqrtAQogr(path, rectLgvMzyTuTTTBVcEj.left + this.fa5634259, rectLgvMzyTuTTTBVcEj.top);
        hEeCSAkusmGFHYLA(canvas, path, this.fd1dedbf5);
        tqECqMkQyaPPXpXu(path, rectLgvMzyTuTTTBVcEj.right, rectLgvMzyTuTTTBVcEj.top + this.fa5634259);
        MssobnugXBSJyIcB(path, rectLgvMzyTuTTTBVcEj.right, rectLgvMzyTuTTTBVcEj.top);
        bEiiBSlaSxhgpMXb(path, rectLgvMzyTuTTTBVcEj.right - this.fa5634259, rectLgvMzyTuTTTBVcEj.top);
        YOCOxZQqsQrHcafz(canvas, path, this.fd1dedbf5);
        pVoKoRemygCQhWqs(path, rectLgvMzyTuTTTBVcEj.right, rectLgvMzyTuTTTBVcEj.bottom - this.fa5634259);
        dlJFttcjdsiUcxJp(path, rectLgvMzyTuTTTBVcEj.right, rectLgvMzyTuTTTBVcEj.bottom);
        bHbJynANlAVsmKPn(path, rectLgvMzyTuTTTBVcEj.right - this.fa5634259, rectLgvMzyTuTTTBVcEj.bottom);
        tXneRtvNIOZIJBTQ(canvas, path, this.fd1dedbf5);
        UtjpCGOCBISTCidr(path, rectLgvMzyTuTTTBVcEj.left, rectLgvMzyTuTTTBVcEj.bottom - this.fa5634259);
        xJwtnfANzPiJpEBo(path, rectLgvMzyTuTTTBVcEj.left, rectLgvMzyTuTTTBVcEj.bottom);
        vNvQmJNhzBFjljPN(path, rectLgvMzyTuTTTBVcEj.left + this.fa5634259, rectLgvMzyTuTTTBVcEj.bottom);
        FqZiLqZyYHomgKXE(canvas, path, this.fd1dedbf5);
    }

    public void DrawobjectFinderMask(android.graphics.Canvas canvas) {
        if ((31 + 4) % 4 > 0) {
        }
        int iQlTUqePuHbMABIEt = qlTUqePuHbMABIEt(canvas);
        int iXGNJcjtPmxVetWgl = XGNJcjtPmxVetWgl(canvas);
        android.graphics.Rect rectEKodYCideRVxDczR = eKodYCideRVxDczR(this);
        float f = iQlTUqePuHbMABIEt;
        xYzJFlWBtOwfGURK(canvas, 0.0f, 0.0f, f, rectEKodYCideRVxDczR.top, this.f7151960f);
        GUqbAQZyRJAqBAaQ(canvas, 0.0f, rectEKodYCideRVxDczR.top, rectEKodYCideRVxDczR.left, rectEKodYCideRVxDczR.bottom + 1, this.f7151960f);
        gfroiHxMFJAAljeF(canvas, rectEKodYCideRVxDczR.right + 1, rectEKodYCideRVxDczR.top, f, rectEKodYCideRVxDczR.bottom + 1, this.f7151960f);
        BiCEoDkMCWPaZkFT(canvas, 0.0f, rectEKodYCideRVxDczR.bottom + 1, f, iXGNJcjtPmxVetWgl, this.f7151960f);
    }

    public android.graphics.Rect GetFramingRect() {
        return this.f84558442;
    }

    public override void OnDraw(android.graphics.Canvas canvas) {
        if (RcOvrUdpuoyebZYl(this) is not null) {
            cAyDXFckYbohJhhG(this, canvas);
            jbVmirukZtDRtTQu(this, canvas);
            if (this.f4a572f3a) {
                dHYQoFKpufVppXYV(this, canvas);
            }
        }
    }

    protected override void OnSizeChanged(int i, int i2, int i3, int i4) {
        TrTruTlPqkHvtfhN(this);
    }

    public override void SetBorderAlpha(float f) {
        int i = (int) (255.0f * f);
        this.fb4068840 = f;
        zJHKYlUxofdQBeBm(this.fd1dedbf5, i);
    }

    public override void SetBorderColor(int i) {
        yPPfQbnXWdarjbrv(this.fd1dedbf5, i);
    }

    public override void SetBorderCornerRadius(int i) {
        VMVwGJvwAlypKjcq(this.fd1dedbf5, new android.graphics.CornerPathEffect(i));
    }

    public override void SetBorderCornerRounded(bool z) {
        if (z) {
            EJlOVPuwxLzAyaRe(this.fd1dedbf5, android.graphics.Paint$Join.ROUND);
        } else {
            bmeFZFIxYEajEpLa(this.fd1dedbf5, android.graphics.Paint$Join.BEVEL);
        }
    }

    public override void SetBorderLineLength(int i) {
        this.fa5634259 = i;
    }

    public override void SetBorderStrokeWidth(int i) {
        jSFUVIdzBobjkVEx(this.fd1dedbf5, i);
    }

    public override void SetLaserColor(int i) {
        fTnwGiLosFsuojPK(this.fd5424fa6, i);
    }

    public override void SetLaserEnabled(bool z) {
        this.f4a572f3a = z;
    }

    public override void SetMaskColor(int i) {
        xnChqMTEoSFcfhpO(this.f7151960f, i);
    }

    public override void SetSquareobjectFinder(bool z) {
        this.f8659b7cb = z;
    }

    public override void SetobjectFinderOffset(int i) {
        this.fbae570ed = i;
    }

    public override void SetupobjectFinder() {
        oUBilgRpLwfOnuau(this);
        ToYMBMeOiUmZerjB(this);
    }

    public void UpdateFramingRect() {
        int iKKGixuoxObWmWIZH;
        int iYqbSMxNElNxeRBXn;
        if ((14 + 15) % 15 > 0) {
        }
        lock (this) {
            try {
                android.graphics.Point point = new android.graphics.Point(kgEBtoYJMUhaScVQ(this), iLHpIExEXnmhwYan(this));
                int iMYTaotvnetVsBSkP = mYTaotvnetVsBSkP(xRByxbbyhHkCEKnf(this));
                if (this.f8659b7cb) {
                    iKKGixuoxObWmWIZH = (int) ((iMYTaotvnetVsBSkP != 1 ? sRxSoOctSAfzmAGW(this) : AttzlsNmpmSQxxOX(this)) * 0.625f);
                    iYqbSMxNElNxeRBXn = iKKGixuoxObWmWIZH;
                } else if (iMYTaotvnetVsBSkP != 1) {
                    int iYkwrNYnDoLytpSTP = (int) (YkwrNYnDoLytpSTP(this) * 0.625f);
                    iYqbSMxNElNxeRBXn = iYkwrNYnDoLytpSTP;
                    iKKGixuoxObWmWIZH = (int) (iYkwrNYnDoLytpSTP * 1.4f);
                } else {
                    iKKGixuoxObWmWIZH = (int) (KKGixuoxObWmWIZH(this) * 0.75f);
                    iYqbSMxNElNxeRBXn = (int) (iKKGixuoxObWmWIZH * 0.75f);
                }
                if (iKKGixuoxObWmWIZH > CNHGUoaibfLYColH(this)) {
                    iKKGixuoxObWmWIZH = YfvGZHdLpLTxnTYZ(this) - 50;
                }
                if (iYqbSMxNElNxeRBXn > HhAeQVuGulIEEkHS(this)) {
                    iYqbSMxNElNxeRBXn = yqbSMxNElNxeRBXn(this) - 50;
                }
                int i = (point.x - iKKGixuoxObWmWIZH) / 2;
                int i2 = (point.y - iYqbSMxNElNxeRBXn) / 2;
                int i3 = this.fbae570ed;
                this.f84558442 = new android.graphics.Rect(i + i3, i2 + i3, (i + iKKGixuoxObWmWIZH) - i3, (i2 + iYqbSMxNElNxeRBXn) - i3);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

