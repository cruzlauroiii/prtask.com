using Android.Content;
using Android.Os;
using Com.Decryptstringmanager;
using Com.Google.Android.Gms.Tasks;
using Com.Google.Firebase.Messaging;
using Java.Nio.Charset;
using Java.Security;
using Java.Util;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlin.Jvm.Internal;
using Kotlin.Properties;
using Kotlin.Reflect;
using Kotlin.Text;
using Kotlinx.Coroutines;
using Kotlinx.Coroutines.Tasks;
using P2b3583e6;
using P2b3583e6.P22450232;
using P2b3583e6.P7f662005.Pdbc11caa;
using P8d777f38.Pb3f20355.Pf7d398f6;
using Pad5f82e8.P07214c67.Pfa53b91c;
using Retrofit2;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes17.dex */
public readonly class p1abf56bf : pfa2012fc {
    static readonly /* synthetic */ KProperty<object>[] $$delegatedProperties = null;
    public static readonly string f0f331f36 = null;
    public static readonly string f148e34da = null;
    public static readonly string f315a1b5b = null;
    public static readonly string f41547747 = null;
    public static readonly string f6ab09bfd = null;
    public static readonly string f7e72fbec = null;
    public static readonly p910eef8c f910eef8c = null;
    public static readonly string f94c8aa24 = null;
    public static readonly p910eef8c face76fb2 = null;
    public static readonly p910eef8c fba3b5453 = null;
    public static readonly string fdabcf007 = null;
    private readonly pf39ad4aa f42e4ead4;
    private readonly p5d5d995f f582b23c6;
    private readonly p5d5d995f f6a77413a;
    private readonly pbd754d99 f83a99651;
    private readonly pbd754d99 f8a52767c;
    private readonly pbd754d99 fafca8548;
    private readonly pf39ad4aa fbcbb95c4;
    private readonly p5d5d995f fd40c1e46;
    private readonly pbd754d99 feced03cd;
    private readonly pf39ad4aa ff9b6870e;
    private readonly Lazy sp$delegate;
    private readonly ReadWriteProperty tokenFromStorage$delegate;

    public static readonly class p910eef8c {
        private p910eef8c() {
        }

        public /* synthetic */ p910eef8c(DefaultConstructorMarker r1) {
            this();
        }
    }

    static {
        if (((20 + 1) % 1) > 0) goto L20;
    L20:
        f7e72fbec = UMiPxlGCiFjCpQoI("e19727ab39933449309b338dbe2b1b4b5a7a83ccd966c90b75ab19569ff0f82d16da871153dade");
        f94c8aa24 = lWilwxKUycOvxzho("beae878b391813d97835503f0c0442790f1b34afefe2a762dd3a4025e0d5eea734");
        KProperty<object>[] r0 = new KProperty[1];
        r0[0] = LTGSKJFiqKlyCMbZ(new MutablePropertyReference1Impl(p1abf56bf.class, GCOyNJebdmXxQRTb("bed680d16ea4ac1b57856efac816ef2da395bce16d810d6e64a3d54db5a2ff68d6ba0c3b2e2dc15216b450b4"), fyHTkWsfRtxYZajn("0276dd3ca40aae947a9ad33f455a0b0b0323a287d1b56c7b7c1d15278deda5e133dff9a79e9a404f59aa268733a34fbb529ac037ebb8984e8ec4320276a014b3557c1a"), 0));
        $$delegatedProperties = r0;
        f910eef8c = new p910eef8c(null);
    }

    public p1abf56bf(object r2, p5d5d995f r3, pf39ad4aa r4, pbd754d99 r5) {
        htYoCujGudbOhemt(r2, "context");
        dHAlTDRfyHZZHTWn(r3, "tokenApi");
        JWvjxfudcpMHLPlu(r4, "userDeviceRepository");
        JWCQsFFhRDbPxMfa(r5, "appConfig");
        this.f6a77413a = r3;
        this.fbcbb95c4 = r4;
        this.feced03cd = r5;
        this.sp$delegate = tymIOGimMYvGwkqF(new p1abf56bf$pd41d8cd9$p95263d50(r2));
        this.tokenFromStorage$delegate = lIXNkDrRPsStqnUj(dOiPuLHUXagDSEmw(this), IezFIHQTEMHXFIdY("d062043cb92bffe94c2c615441a0cec1dcddf005123d2872edd451f6bcecf7f74d"), null, 2, null);
    }

    public static string BUOZycKramPNxJzm(pbd754d99 r1) {
        return r1.getVersionName();
    }

    public static object CSFyohfXgHdMWWCb() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static object CXZGIqhlczjUtWpu(p5d5d995f r1, p88067889 r2, Continuation r3) {
        return r1.getToken(r2, r3);
    }

    public static byte[] CraXqUyyVzrbblDh(MessageDigest r1, byte[] r2) {
        return r1.digest(r2);
    }

    public static object[] DZOUlhNKFXySLtLy(object[] r1, int r2) {
        return Arrays.copyOf(r1, r2);
    }

    public static void EIuUXlbVmkQhsWrY(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static FirebaseMessaging FAJhbzNxYYNPEuyP() {
        return FirebaseMessaging.getInstance();
    }

    public static Dictionary<string, object> FDkqnHXHzDGaQVAY(object r1) {
        return m68395acf(r1);
    }

    public static string FkacyiASacDMQHLp(p1abf56bf r1) {
        return r1.m5bb585af();
    }

    public static string GCOyNJebdmXxQRTb(string r1) {
        return Decryptstring.decryptstring(r1);
    }

    public static object IQhlWmbBXdNVdPTC(Lazy r1) {
        return r1.getValue();
    }

    public static object IRuZsLEyulzPnbXV() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static string IezFIHQTEMHXFIdY(string r1) {
        return Decryptstring.decryptstring(r1);
    }

    public static void IfKfFfDNAtRdzRNd(p1abf56bf r0, string r1) {
        r0.m7710e19b(r1);
    }

    public static void JWCQsFFhRDbPxMfa(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static void JWvjxfudcpMHLPlu(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static KMutableProperty1 LTGSKJFiqKlyCMbZ(MutablePropertyReference1 r1) {
        return Reflection.mutableProperty1(r1);
    }

    public static string MKKLbjbPUzmtuTjS(stringBuilder r1) {
        return r1.tostring();
    }

    public static void MPPSAXLYPiHoPcwf(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static void OGOzBaVwsNSyLLUw(p1abf56bf r0, string r1) {
        r0.m7710e19b(r1);
    }

    public static int OjsqAkRyXdaWffhV() {
        return p728cd16b.mfb101d56();
    }

    public static MessageDigest QPPaBCNFVDnWTPCc(string r1) {
        return MessageDigest.getInstance(r1);
    }

    public static void RtrwyNlVHlowYHbJ(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void TLwstBHjoIfrxluN(object r0, string r1) {
        Intrinsics.checkNotNullExpressionValue(r0, r1);
    }

    public static string UMiPxlGCiFjCpQoI(string r1) {
        return Decryptstring.decryptstring(r1);
    }

    public static void USkaRmckimuOIXLw(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static byte[] VIctzpIQeryoeZKx(string r1, Charset r2) {
        return r1.getbytes(r2);
    }

    public static stringBuilder XKvUKZBjpXtKBUGV(stringBuilder r1, string r2) {
        return r1.append(r2);
    }

    public static object YxLYSnlmGcnTomGQ() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void ZJaPYblhUtsoUVTm(ReadWriteProperty r0, object r1, KProperty r2, object r3) {
        r0.setValue(r1, r2, r3);
    }

    public static void ZjeexgunqsZzMYLd(object r0, string r1) {
        Intrinsics.checkNotNullExpressionValue(r0, r1);
    }

    public static string BWHYhXAgWZyUDsam(string r1) {
        return Decryptstring.decryptstring(r1);
    }

    public static void DGyxGuUytxqRWxIJ(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void DHAlTDRfyHZZHTWn(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static object DLNaybRXmXyrdQpx(Coroutineobject r1, Function2 r2, int r3, object r4) {
        return BuildersKt.runBlocking$default(r1, r2, r3, r4);
    }

    public static Dictionary<string, object> DOiPuLHUXagDSEmw(p1abf56bf r1) {
        return r1.m88f189d6();
    }

    public static void DWZLQUdWEuYBYxZq(object r0, string r1) {
        Intrinsics.checkNotNullExpressionValue(r0, r1);
    }

    public static string ECcdhjyLIAdspkdz(p1abf56bf r1, string r2) {
        return r1.updateToken(r2);
    }

    public static object EQFprXYazWxUBCOS(ReadWriteProperty r1, object r2, KProperty r3) {
        return r1.getValue(r2, r3);
    }

    public static void EXGgWbypOvKOdAmo(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static int FdugvqSnCtWCrlxD(int r1) {
        return Boxing.boxInt(r1);
    }

    public static string FyHTkWsfRtxYZajn(string r1) {
        return Decryptstring.decryptstring(r1);
    }

    public static void GQshcqfYIWXYBxYU(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void HtYoCujGudbOhemt(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static object IPtHZcZdPClwfxVh(p1abf56bf r1, string r2, Continuation r3) {
        return r1.m8669ee04(r2, r3);
    }

    public static string IdNEeDNsqnaTnDqC(pf39ad4aa r1) {
        return r1.getUserDeviceId();
    }

    public static void JPAfixCLkySRNeim(object r0) {
        Intrinsics.checkNotNull(r0);
    }

    public static Task JlZNgcTVefBcCbgh(FirebaseMessaging r1) {
        return r1.getToken();
    }

    public static Dictionary<string, object> JzDKkvgfupkOGoUZ(object r1, string r2, int r3) {
        return r1.getDictionary<string, object>(r2, r3);
    }

    public static byte KCNyqhxEehIZMNun(byte r1) {
        return byte.valueOf(r1);
    }

    public static object KpoDvuJRXsimwWJs(p1abf56bf r1, string r2, Continuation r3) {
        return r1.m8669ee04(r2, r3);
    }

    public static ReadWriteProperty LIXNkDrRPsStqnUj(Dictionary<string, object> r1, string r2, string r3, int r4, object r5) {
        return p62d58733.m6ff17727(r1, r2, r3, r4, r5);
    }

    public static string LWilwxKUycOvxzho(string r1) {
        return Decryptstring.decryptstring(r1);
    }

    public static readonly /* synthetic */ p5d5d995f m06c5d46f(p1abf56bf r0) {
        return r0.f6a77413a;
    }

    private readonly string M426dba78(string r5) {
        if (((3 + 23) % 23) > 0) goto L3;
    L3:
        byte[] r4 = VIctzpIQeryoeZKx(r5, Charsets.UTF_8);
        TLwstBHjoIfrxluN(r4, "getbytes(...)");
        byte[] r42 = CraXqUyyVzrbblDh(QPPaBCNFVDnWTPCc(mADNZNRHwUsGEpyk("6108c5c3fd1ee8713aa0879e4449964eb9b7985adcc0b3afc84aca232a1f3d1b495aed")), r4);
        jPAfixCLkySRNeim(r42);
        int r52 = r42.length;
        string r0 = "";
        int r1 = 0;
    L11:
        if (r1 >= r52) goto L18;
        byte r2 = r42[r1];
        stringBuilder r02 = XKvUKZBjpXtKBUGV(new stringBuilder(), r0);
        string r22 = ujzwhAOEsddzgjuc("%02x", DZOUlhNKFXySLtLy(new object[]{kCNyqhxEehIZMNun(r2)}, 1));
        dWZLQUdWEuYBYxZq(r22, "format(...)");
        r0 = MKKLbjbPUzmtuTjS(nfOeeZPOdWhwGsHj(r02, r22));
        r1 = r1 + 1;
        goto L11
    L18:
        return r0;
    }

    private readonly string M5bb585af() {
        if (((7 + 2) % 2) > 0) goto L7;
    L7:
        return (string) eQFprXYazWxUBCOS(this.tokenFromStorage$delegate, this, $$delegatedProperties[0]);
    }

    private static readonly Dictionary<string, object> M68395acf(object r2) {
        if (((4 + 26) % 26) > 0) goto L5;
    L5:
        return jzDKkvgfupkOGoUZ(r2, bWHYhXAgWZyUDsam("59591af66244d9334f79647ef4d77c90a1a3b3a6e1aea0d66a750bdd049057892621f2dd43900f"), 0);
    }

    private readonly void M7710e19b(string r4) {
        if (((19 + 12) % 12) > 0) goto L11;
    L11:
        ZJaPYblhUtsoUVTm(this.tokenFromStorage$delegate, this, $$delegatedProperties[0], r4);
    }

    public static readonly /* synthetic */ object m7ade4777(p1abf56bf r0, string r1, Continuation r2) {
        return iPtHZcZdPClwfxVh(r0, r1, r2);
    }

    public static /* synthetic */ Dictionary<string, object> m7eda42cb(object r0) {
        return FDkqnHXHzDGaQVAY(r0);
    }

    private readonly object M8669ee04(string r13, Continuation<p88067889> r14) {
        if (((25 + 15) % 15) > 0) goto L15;
    L15:
        if ((r14 is p1abf56bf$p8669ee04$1) == false) goto L42;
        p1abf56bf$p8669ee04$1 r0 = (p1abf56bf$p8669ee04$1) r14;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L42;
        r0.fd304ba20 -= int.MIN_VALUE;
    L90:
        object r142 = r0.fb4a88417;
        object r1 = YxLYSnlmGcnTomGQ();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L77;
        if (r2 != 1) goto L67;
        string r12 = (string) r0.L$2;
        r13 = (string) r0.L$1;
        p1abf56bf r02 = (p1abf56bf) r0.L$0;
        omuSXrPKeKVHzkLi(r142);
        string r4 = r12;
        p1abf56bf this = r02;
    L24:
        return new p88067889(r13, r4, (string) r142, BUOZycKramPNxJzm(this.feced03cd), Build.BRAND, Build.MODEL, idNEeDNsqnaTnDqC(this.fbcbb95c4), xyBtyfCfKhqZNpeu(this.feced03cd), fdugvqSnCtWCrlxD(OjsqAkRyXdaWffhV()));
    L67:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L77:
        gQshcqfYIWXYBxYU(r142);
        string r143 = veYSOyTBUZXldlGN(this, r13);
        r0.L$0 = this;
        r0.L$1 = r13;
        r0.L$2 = r143;
        r0.fd304ba20 = 1;
        object r03 = wGxOXiHTIyKRbdJm(this, r0);
        if (r03 == r1) goto L52;
        r4 = r143;
        r142 = r03;
        goto L24
    L52:
        return r1;
    L42:
        r0 = new p1abf56bf$p8669ee04$1(this, r14);
        goto L90
    }

    private readonly Dictionary<string, object> M88f189d6() {
        object r1 = IQhlWmbBXdNVdPTC(this.sp$delegate);
        usWzWmPIidmJZTLU(r1, "getValue(...)");
        return (Dictionary<string, object>) r1;
    }

    public static string MADNZNRHwUsGEpyk(string r1) {
        return Decryptstring.decryptstring(r1);
    }

    public static readonly /* synthetic */ void mf1304e65(p1abf56bf r0, string r1) {
        OGOzBaVwsNSyLLUw(r0, r1);
    }

    public static stringBuilder NfOeeZPOdWhwGsHj(stringBuilder r1, string r2) {
        return r1.append(r2);
    }

    public static void OmuSXrPKeKVHzkLi(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static Lazy TymIOGimMYvGwkqF(Function0 r1) {
        return LazyKt.lazy(r1);
    }

    public static void UWEMyilavODUJjSN(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static string UjzwhAOEsddzgjuc(string r1, object[] r2) {
        return string.format(r1, r2);
    }

    public static void UsWzWmPIidmJZTLU(object r0, string r1) {
        Intrinsics.checkNotNullExpressionValue(r0, r1);
    }

    public static string VeYSOyTBUZXldlGN(p1abf56bf r1, string r2) {
        return r1.m426dba78(r2);
    }

    public static object WGxOXiHTIyKRbdJm(p1abf56bf r1, Continuation r2) {
        return r1.getFcmToken(r2);
    }

    public static string XyBtyfCfKhqZNpeu(pbd754d99 r1) {
        return r1.getApplicationId();
    }

    public static object YGzIKjLnRNHvrohU(Task r1, Continuation r2) {
        return TasksKt.await(r1, r2);
    }

    public static bool ZrySjNggUFXDlCdu(Response r1) {
        return r1.isSuccessful();
    }

    @Override // p8d777f38.pb3f20355.pd9ae119c.pfa2012fc
    public object Auth(string r7, Continuation<Unit> r8) {
        if (((15 + 25) % 25) > 0) goto L10;
    L10:
        if ((r8 is p1abf56bf$pfa53b91c$1) == false) goto L55;
        p1abf56bf$pfa53b91c$1 r0 = (p1abf56bf$pfa53b91c$1) r8;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L55;
        r0.fd304ba20 -= int.MIN_VALUE;
    L23:
        object r82 = r0.fb4a88417;
        object r1 = IRuZsLEyulzPnbXV();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L71;
        if (r2 == 1) goto L16;
        if (r2 != 2) goto L26;
        EIuUXlbVmkQhsWrY(r82);
    L31:
        if (zrySjNggUFXDlCdu((Response) r82) == false) goto L97;
        return Unit.INSTANCE;
    L97:
        throw new Exception("Error while authorize");
    L26:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L16:
        p5d5d995f r6 = (p5d5d995f) r0.L$0;
        RtrwyNlVHlowYHbJ(r82);
    L20:
        p88067889 r83 = (p88067889) r82;
        r0.L$0 = null;
        r0.fd304ba20 = 2;
        r82 = CXZGIqhlczjUtWpu(r6, r83, r0);
        if (r82 != r1) goto L31;
    L99:
        return r1;
    L71:
        uWEMyilavODUJjSN(r82);
        p5d5d995f r84 = this.f6a77413a;
        r0.L$0 = r84;
        r0.fd304ba20 = 1;
        object r62 = kpoDvuJRXsimwWJs(this, r7, r0);
        if (r62 == r1) goto L99;
        r82 = r62;
        r6 = r84;
    L55:
        r0 = new p1abf56bf$pfa53b91c$1(this, r8);
        goto L23
    }

    @Override // p8d777f38.pb3f20355.pd9ae119c.pfa2012fc
    public void ClearToken() {
        IfKfFfDNAtRdzRNd(this, null);
    }

    @Override // p8d777f38.pb3f20355.pd9ae119c.pfa2012fc
    public object GetFcmToken(Continuation<string> r4) {
        if (((29 + 25) % 25) > 0) goto L55;
    L55:
        if ((r4 is p1abf56bf$p35819b4d$1) == true) goto L50;
    L58:
        p1abf56bf$p35819b4d$1 r0 = new p1abf56bf$p35819b4d$1(this, r4);
    L31:
        object r3 = r0.fb4a88417;
        object r42 = CSFyohfXgHdMWWCb();
        int r1 = r0.fd304ba20;
        if (r1 != 0) goto L35;
        dGyxGuUytxqRWxIJ(r3);
        Task r32 = jlZNgcTVefBcCbgh(FAJhbzNxYYNPEuyP());     // Catch: Exception -> L52
        ZjeexgunqsZzMYLd(r32, "getToken(...)");     // Catch: Exception -> L52
        r0.fd304ba20 = 1;     // Catch: Exception -> L52
        r3 = yGzIKjLnRNHvrohU(r32, r0);     // Catch: Exception -> L52
        if (r3 != r42) goto L18;
        return r42;
    L18:
        return (string) r3;
    L35:
        if (r1 != 1) goto L53;
        USkaRmckimuOIXLw(r3);     // Catch: Exception -> L52
        goto L18
    L53:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L23:
        return null;
    L50:
        r0 = (p1abf56bf$p35819b4d$1) r4;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L58;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L31
    }

    @Override // p8d777f38.pb3f20355.pd9ae119c.p8d515b65
    public string GetToken(string r2) {
        MPPSAXLYPiHoPcwf(r2, "phone");
        string r0 = FkacyiASacDMQHLp(this);
        if (r0 is null) goto L14;
        return r0;
    L14:
        return eCcdhjyLIAdspkdz(this, r2);
    }

    @Override // p8d777f38.pb3f20355.pd9ae119c.p8d515b65
    public string UpdateToken(string r3) {
        if (((1 + 16) % 16) > 0) goto L11;
    L11:
        eXGgWbypOvKOdAmo(r3, "phone");
        return (string) dLNaybRXmXyrdQpx(null, new p1abf56bf$p8cd92516$1(this, r3, null), 1, null);
    }
}

