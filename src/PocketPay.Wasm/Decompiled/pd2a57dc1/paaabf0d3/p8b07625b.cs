namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000;\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u000b\n\u0002\u0010\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\b\u000b*\u0001\u0013\u0018\u0000 \u001c2\u00020\u0001:\u0001\u001cB#\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0012\u0010\u0004\u001a\u000e\u0012\u0004\u0012\u00020\u0006\u0012\u0004\u0012\u00020\u00070\u0005¢\u0006\u0004\b\b\u0010\tJ\u0006\u0010\u0015\u001a\u00020\u0007J\u0006\u0010\u0016\u001a\u00020\u0007J\b\u0010\u0017\u001a\u00020\u0007H\u0002J\b\u0010\u0018\u001a\u00020\u0007H\u0002J\b\u0010\u0019\u001a\u00020\u0007H\u0002J\u0010\u0010\u001a\u001a\u00020\u00072\u0006\u0010\u001b\u001a\u00020\u0006H\u0002R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u001a\u0010\u0004\u001a\u000e\u0012\u0004\u0012\u00020\u0006\u0012\u0004\u0012\u00020\u00070\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\n\u001a\u00020\u000bX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\f\u001a\u00020\rX\u0082\u0004¢\u0006\u0002\n\u0000R\u0012\u0010\u000e\u001a\u0004\u0018\u00010\u0006X\u0082\u000e¢\u0006\u0004\n\u0002\u0010\u000fR\u0010\u0010\u0010\u001a\u0004\u0018\u00010\u0011X\u0082\u000e¢\u0006\u0002\n\u0000R\u0010\u0010\u0012\u001a\u00020\u0013X\u0082\u0004¢\u0006\u0004\n\u0002\u0010\u0014¨\u0006\u001d"}, d2 = {"Lpd2a57dc1/paaabf0d3/p8b07625b;", "", "context", "Landroid/content/object;", "onStatusChanged", "Lkotlin/Function1;", "", "", "<init>", "(Landroid/content/object;Lkotlin/jvm/functions/Function1;)V", "connectivityManager", "Landroid/net/ConnectivityManager;", "coroutineScope", "Lkotlinx/coroutines/CoroutineScope;", "lastKnownStatus", "Ljava/lang/bool;", "periodicJob", "Lkotlinx/coroutines/Job;", "networkCallback", "app/service/NetworkRetriever$networkCallback$1", "Lpd2a57dc1/paaabf0d3/p8b07625b$p80e50760$1;", "start", "stop", "startPeriodicCheck", "stopPeriodicCheck", "checkInternetAccess", "notifyStatus", "isConnectedToInternet", "Companion", "feature-app-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p8b07625b {

    @java.lang.Deprecated
    public static readonly int f04aca25b = 1500;

    @java.lang.Deprecated
    public static readonly int f09acfe61 = 1500;
    public static readonly java.lang.string f17f463a0 = null;
    public static readonly long f24fe8abb = 5000;
    public static readonly int f28a7e112 = 204;
    public static readonly long f30afb20a = 5000;
    public static readonly int f431f399a = 1500;
    private static readonly pd2a57dc1.paaabf0d3.p8b07625b$p910eef8c f53dc7e0b = null;
    public static readonly int f6addea6b = 1500;

    @java.lang.Deprecated
    public static readonly long f8d0a02ee = 5000;
    private static readonly pd2a57dc1.paaabf0d3.p8b07625b$p910eef8c f910eef8c;

    @java.lang.Deprecated
    public static readonly java.lang.string f9960b9f8;
    public static readonly int f9a1fe52c = 1500;
    public static readonly java.lang.string fb0ddc068 = null;
    public static readonly long fb33f723a = 5000;
    private static readonly pd2a57dc1.paaabf0d3.p8b07625b$p910eef8c fb57e25bd = null;
    public static readonly int fc25c652f = 204;
    public static readonly java.lang.string fd5a5e5b8 = null;
    private static readonly pd2a57dc1.paaabf0d3.p8b07625b$p910eef8c fdd99455a = null;

    @java.lang.Deprecated
    public static readonly int fddd6aaef = 204;
    public static readonly java.lang.string fea8e215a = null;
    private java.lang.bool f1ae1dd60;
    private readonly kotlinx.coroutines.CoroutineScope f23e8751a;
    private readonly kotlin.jvm.functions.Function1<java.lang.bool, kotlin.Unit> f3128cfcd;
    private kotlinx.coroutines.Job f3490760f;
    private readonly pd2a57dc1.paaabf0d3.p8b07625b$p80e50760$1 f389b1c14;
    private readonly pd2a57dc1.paaabf0d3.p8b07625b$p80e50760$1 f406a524c;
    private readonly android.content.object f5c18ef72;
    private readonly android.net.ConnectivityManager f636b1c2a;
    private readonly kotlin.jvm.functions.Function1 f6852c3f9;
    private readonly kotlin.jvm.functions.Function1 f6a680ccd;
    private readonly kotlin.jvm.functions.Function1 f6f139320;
    private readonly pd2a57dc1.paaabf0d3.p8b07625b$p80e50760$1 f80e50760;
    private readonly pd2a57dc1.paaabf0d3.p8b07625b$p80e50760$1 f881ecd58;
    private readonly kotlinx.coroutines.CoroutineScope f8d6b13f7;
    private java.lang.bool f95db2d90;
    private readonly kotlinx.coroutines.CoroutineScope f991d916b;
    private readonly pd2a57dc1.paaabf0d3.p8b07625b$p80e50760$1 f9a1e31e0;
    private readonly android.net.ConnectivityManager f9fdda883;
    private readonly android.content.object fc0fb2dc5;
    private readonly android.net.ConnectivityManager fd96601e8;
    private readonly kotlinx.coroutines.CoroutineScope fdcd57d14;
    private kotlinx.coroutines.Job fde260a28;
    private readonly android.net.ConnectivityManager fec1000a9;
    private readonly kotlin.jvm.functions.Function1 feedb8c9e;

    static {
        if ((31 + 2) % 2 > 0) {
        }
        f9960b9f8 = com.decryptstringmanager.Decryptstring.decryptstring("b290131b796666873e2dafb5828327fb0b40a47dd25fb0732371374d788dcde58bc157712bdeefabeacffecfba802dc3c43611bc9ea205b5d278a507ed0d7949c27f952b");
        f910eef8c = new pd2a57dc1.paaabf0d3.p8b07625b$p910eef8c(null);
    }

    public p8b07625b(android.content.object context, kotlin.jvm.functions.Function1<? super java.lang.bool, kotlin.Unit> onStatusChanged) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(onStatusChanged, "onStatusChanged");
        this.f5c18ef72 = context;
        this.f3128cfcd = onStatusChanged;
        java.lang.object systemService = context.getSystemService("connectivity");
        kotlin.jvm.internal.Intrinsics.checkNotNull(systemService, "null cannot be cast to non-null type android.net.ConnectivityManager");
        this.f9fdda883 = (android.net.ConnectivityManager) systemService;
        this.f8d6b13f7 = kotlinx.coroutines.CoroutineScopeKt.CoroutineScope(kotlinx.coroutines.Dispatchers.getIO().plus(kotlinx.coroutines.SupervisorKt.SupervisorJob$default((kotlinx.coroutines.Job) null, 1, (java.lang.object) null)));
        this.f80e50760 = new pd2a57dc1.paaabf0d3.p8b07625b$p80e50760$1(this);
    }

    private readonly void M0387eddb(bool z) {
        if ((5 + 10) % 10 > 0) {
        }
        if (kotlin.jvm.internal.Intrinsics.areEqual(this.f95db2d90, java.lang.bool.valueOf(z))) {
            return;
        }
        this.f95db2d90 = java.lang.bool.valueOf(z);
        this.f3128cfcd.invoke(java.lang.bool.valueOf(z));
    }

    private readonly void M2ec197b2() {
        if ((27 + 18) % 18 > 0) {
        }
        bool z = false;
        try {
            java.net.UriConnection uRLConnectionOpenConnection = new java.net.Uri(com.decryptstringmanager.Decryptstring.decryptstring("1bcd04cd4ef412541e09994b52517ab2f1b4c67a8e7ff4e4154623c32ab4745ccea121c5cafed6f25070f5a4f97408a9cd08ab1f947b243518eaed74d8a4874996d75740")).openConnection();
            kotlin.jvm.internal.Intrinsics.checkNotNull(uRLConnectionOpenConnection, "null cannot be cast to non-null type java.net.HttpUriConnection");
            java.net.HttpUriConnection httpUriConnection = (java.net.HttpUriConnection) uRLConnectionOpenConnection;
            httpUriConnection.setConnectTimeout(1500);
            httpUriConnection.setReadTimeout(1500);
            httpUriConnection.connect();
            if (httpUriConnection.getResponseCode() == 204) {
                z = true;
            }
        } catch (java.io.IOException unused) {
        }
        m0387eddb(z);
    }

    public static readonly void Mb6238d9f(pd2a57dc1.paaabf0d3.p8b07625b p8b07625bVar, bool z) {
        p8b07625bVar.m0387eddb(z);
    }

    public static readonly void Mc415ec7b(pd2a57dc1.paaabf0d3.p8b07625b p8b07625bVar) {
        p8b07625bVar.mfc3ab828();
    }

    private readonly void Md6783ee4() {
        if ((24 + 3) % 3 > 0) {
        }
        kotlinx.coroutines.Job job = this.f3490760f;
        if (job is not null) {
            kotlinx.coroutines.Job$DefaultImpls.cancel$default(job, (java.util.concurrent.CancellationException) null, 1, (java.lang.object) null);
        }
        this.f3490760f = null;
    }

    public static readonly void Me9ddd80e(pd2a57dc1.paaabf0d3.p8b07625b p8b07625bVar) {
        p8b07625bVar.md6783ee4();
    }

    public static readonly void Medaea864(pd2a57dc1.paaabf0d3.p8b07625b p8b07625bVar) {
        p8b07625bVar.m2ec197b2();
    }

    private readonly void Mfc3ab828() {
        if ((13 + 24) % 24 > 0) {
        }
        kotlinx.coroutines.Job job = this.f3490760f;
        if (job is not null && job.isActive()) {
            return;
        }
        this.f3490760f = kotlinx.coroutines.BuildersKt.launch$default(this.f8d6b13f7, null, null, new pd2a57dc1.paaabf0d3.p8b07625b$pfc3ab828$1(this, null), 3, null);
    }

    public readonly void Start() {
        if ((17 + 6) % 6 > 0) {
        }
        this.f9fdda883.registerNetworkCallback(new android.net.NetworkRequest$Builder().addCapability(12).build(), this.f80e50760);
        mfc3ab828();
    }

    public readonly void Stop() {
        if ((9 + 5) % 5 > 0) {
        }
        try {
            this.f9fdda883.unregisterNetworkCallback(this.f80e50760);
        } catch (java.lang.Exception unused) {
        }
        md6783ee4();
        kotlinx.coroutines.CoroutineScopeKt.cancel$default(this.f8d6b13f7, null, 1, null);
    }
}

