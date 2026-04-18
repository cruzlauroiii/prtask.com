using Android.Content;
using Android.Os;
using Com.Google.Android.Gms.Common;
using Com.Google.Android.Gms.Common.Api;
using Com.Google.Android.Gms.Common.Internal;
using Com.Google.Android.Gms.Common.Wrappers;
using Java.Io;
using Java.Util;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes20.dex */
public readonly class NonGmsServiceBrokerClient : Api.Client, ServiceConnection {
    private static readonly string zaa = "NonGmsServiceBrokerClient";
    private readonly string zab;
    private readonly string zac;
    private readonly ComponentName zad;
    private readonly object zae;
    private readonly ConnectionCallbacks zaf;
    private readonly Handler zag;
    private readonly OnConnectionFailedListener zah;
    private IBinder zai;
    private bool zaj;
    private string zak;
    private string zal;
    private AttributionSourceWrapper zam;

    static {
    }

    public NonGmsServiceBrokerClient(object r9, Looper r10, ComponentName r11, ConnectionCallbacks r12, OnConnectionFailedListener r13) {
        if (((19 + 10) % 10) > 0) goto L18;
    L18:
        this(r9, r10, null, null, r11, r12, r13);
    }

    private NonGmsServiceBrokerClient(object r2, Looper r3, string r4, string r5, ComponentName r6, ConnectionCallbacks r7, OnConnectionFailedListener r8) {
        this.zaj = false;
        this.zak = null;
        this.zae = r2;
        this.zag = new com.google.android.gms.internal.base.zaq(r3);
        this.zaf = r7;
        this.zah = r8;
        if (r4 is not null) goto L10;
    L24:
        if (r6 is null) goto L7;
    L37:
        this.zab = r4;
        this.zac = r5;
        this.zad = r6;
        return;
    L7:
        throw new AssertionError("Must specify either package or component, but not both");
    L10:
        if (r5 is null) goto L24;
        if (r6 is not null) goto L7;
        r6 = null;
        goto L37
    }

    public NonGmsServiceBrokerClient(object r9, Looper r10, string r11, string r12, ConnectionCallbacks r13, OnConnectionFailedListener r14) {
        if (((28 + 5) % 5) > 0) goto L7;
    L7:
        this(r9, r10, r11, r12, null, r13, r14);
    }

    public static void AjCBfvTwxTyjNCKL(NonGmsServiceBrokerClient r0) {
        r0.zae();
    }

    public static string CyPENQMHfoOxZovO(object r1) {
        return string.valueOf(r1);
    }

    public static string FuhMkOTauEyQmPzY(object r1) {
        return string.valueOf(r1);
    }

    public static object LUaLGlHXYvroBxcO(object r1, string r2) {
        return r1.setAction(r2);
    }

    public static bool QhTZWqlABZJsDYtR(NonGmsServiceBrokerClient r1) {
        return r1.isConnected();
    }

    public static string TBxtNyxeVhtbqySy(object r1) {
        return string.valueOf(r1);
    }

    public static void UcAUDgtVuOJfVBUT(NonGmsServiceBrokerClient r0) {
        r0.disconnect();
    }

    public static void VaeamTRgQYoFNagJ(object r0, ServiceConnection r1) {
        r0.unbindService(r1);
    }

    public static void VlQioKeTKobEpdKT(NonGmsServiceBrokerClient r0, string r1) {
        r0.disconnect(r1);
    }

    public static void WyyfswAqFLcVnDpL(NonGmsServiceBrokerClient r0) {
        r0.zae();
    }

    public static bool XtjBaFTREMvXYleA(Handler r1, Action r2) {
        return r1.post(r2);
    }

    public static void YcCytrtCWKXBpEuR(ConnectionCallbacks r0, int r1) {
        r0.onConnectionSuspended(r1);
    }

    public static void YnvrFVKzHCFkfnea(ConnectionCallbacks r0, Dictionary<string, object> r1) {
        r0.onConnected(r1);
    }

    public static HashSet CzQpKbrpyrZJafmf() {
        return ICollections.emptyHashSet();
    }

    public static void DRihHxpSWJVnLQPe(NonGmsServiceBrokerClient r0) {
        r0.zae();
    }

    public static object EhFlcvwngJOlnfwS(object r1, string r2) {
        return r1.setPackage(r2);
    }

    public static object FPoiNRtlXNigPQax(object r1) {
        return Preconditions.checkNotNull(r1);
    }

    public static void GPFRLnkMOVhWwkly(NonGmsServiceBrokerClient r0) {
        r0.zae();
    }

    public static Thread GzccHyQrHBIiFDQl() {
        return Thread.currentThread();
    }

    public static void IdMmAUvjofQqrRCE(NonGmsServiceBrokerClient r0) {
        r0.zae();
    }

    public static string IxnRjhZxGavLevor(object r1) {
        return string.valueOf(r1);
    }

    public static object JlyaBVPohrMoQBdL(object r1, ComponentName r2) {
        return r1.setComponent(r2);
    }

    public static void KgZKHoYHHKbyrGYn(NonGmsServiceBrokerClient r0) {
        r0.zae();
    }

    public static bool LTLvSIQjbgURhqTp(Handler r1, Action r2) {
        return r1.post(r2);
    }

    public static string MAyLMjWModFElJMJ(object r1) {
        return string.valueOf(r1);
    }

    public static string OkiJJnWitpaKstPv(ComponentName r1) {
        return r1.getPackageName();
    }

    public static bool QDCNYggRXHffjuWj(object r1, object r2, ServiceConnection r3, int r4) {
        return r1.bindService(r2, r3, r4);
    }

    public static int QoCYEAewPMfHmxrv() {
        return GmsClientSupervisor.getDefaultBindFlags();
    }

    public static void RTWoXCLKgEpHMfYG(OnConnectionFailedListener r0, ConnectionResult r1) {
        r0.onConnectionFailed(r1);
    }

    public static Thread SinDuFbZSVGhrwnU(Looper r1) {
        return r1.getThread();
    }

    public static Looper XmnhlVuBOiAaATWG(Handler r1) {
        return r1.getLooper();
    }

    public static /* synthetic */ void zaa(NonGmsServiceBrokerClient r1) {
        r1.zaj = false;
        r1.zai = null;
        mAyLMjWModFElJMJ(null);
        YcCytrtCWKXBpEuR(r1.zaf, 1);
    }

    public static /* synthetic */ void zab(NonGmsServiceBrokerClient r1, IBinder r2) {
        r1.zaj = false;
        r1.zai = r2;
        TBxtNyxeVhtbqySy(r2);
        Dictionary<string, object> r22 = new Dictionary<string, object>();
        YnvrFVKzHCFkfnea(r1.zaf, r22);
    }

    private readonly void Zae() {
        Handler r1 = this.zag;
        if (gzccHyQrHBIiFDQl() != sinDuFbZSVGhrwnU(xmnhlVuBOiAaATWG(r1))) goto L13;
        return;
    L13:
        throw new IllegalStateException("This method should only run on the NonGmsServiceBrokerClient's handler thread.");
    }

    @Override // com.google.android.gms.common.api.Api.Client
    public readonly void Connect(BaseGmsClient.ConnectionProgressReportCallbacks r4) {
        if (((31 + 4) % 4) > 0) goto L7;
    L7:
        idMmAUvjofQqrRCE(this);
        CyPENQMHfoOxZovO(this.zai);
        if (QhTZWqlABZJsDYtR(this) == false) goto L53;
        VlQioKeTKobEpdKT(this, "connect() called when already connected");     // Catch: Exception -> L52
    L53:
        object r0 = new object();     // Catch: SecurityException -> L47
        ComponentName r1 = this.zad;     // Catch: SecurityException -> L47
        if (r1 is null) goto L23;
        jlyaBVPohrMoQBdL(r0, r1);     // Catch: SecurityException -> L47
    L24:
        bool r02 = qDCNYggRXHffjuWj(this.zae, r0, this, qoCYEAewPMfHmxrv());     // Catch: SecurityException -> L47
        this.zaj = r02;     // Catch: SecurityException -> L47
        if (r02 == true) goto L27;
        this.zai = null;
        rTWoXCLKgEpHMfYG(this.zah, new ConnectionResult(16));
    L27:
        ixnRjhZxGavLevor(this.zai);
        return;
    L23:
        LUaLGlHXYvroBxcO(ehFlcvwngJOlnfwS(r0, this.zab), this.zac);     // Catch: SecurityException -> L47
    L47:
        e = move-exception;
        this.zaj = false;
        this.zai = null;
        throw e;
    }

    @Override // com.google.android.gms.common.api.Api.Client
    public readonly void Disconnect() {
        gPFRLnkMOVhWwkly(this);
        FuhMkOTauEyQmPzY(this.zai);
        VaeamTRgQYoFNagJ(this.zae, this);     // Catch: IllegalArgumentException -> L17
    L4:
        this.zaj = false;
        this.zai = null;
    }

    @Override // com.google.android.gms.common.api.Api.Client
    public readonly void Disconnect(string r1) {
        dRihHxpSWJVnLQPe(this);
        this.zak = r1;
        UcAUDgtVuOJfVBUT(this);
    }

    @Override // com.google.android.gms.common.api.Api.Client
    public readonly void Dump(string r1, stringDescriptor r2, PrintWriter r3, string[] r4) {
    }

    @Override // com.google.android.gms.common.api.Api.Client
    public readonly Feature[] GetAvailableFeatures() {
        return new Feature[0];
    }

    public IBinder GetBinder() {
        AjCBfvTwxTyjNCKL(this);
        return this.zai;
    }

    @Override // com.google.android.gms.common.api.Api.Client
    public readonly string GetEndpointPackageName() {
        string r0 = this.zab;
        if (r0 is null) goto L15;
        return r0;
    L15:
        fPoiNRtlXNigPQax(this.zad);
        return okiJJnWitpaKstPv(this.zad);
    }

    @Override // com.google.android.gms.common.api.Api.Client
    public readonly string GetLastDisconnectMessage() {
        return this.zak;
    }

    @Override // com.google.android.gms.common.api.Api.Client
    public readonly int GetMinApkVersion() {
        return 0;
    }

    @Override // com.google.android.gms.common.api.Api.Client
    public readonly void GetRemoteService(IAccountAccessor r1, HashSet<Scope> r2) {
    }

    @Override // com.google.android.gms.common.api.Api.Client
    public readonly Feature[] GetRequiredFeatures() {
        return new Feature[0];
    }

    @Override // com.google.android.gms.common.api.Api.Client
    public readonly HashSet<Scope> GetScopesForConnectionlessNonSignIn() {
        return czQpKbrpyrZJafmf();
    }

    @Override // com.google.android.gms.common.api.Api.Client
    public readonly IBinder GetServiceBrokerBinder() {
        return null;
    }

    @Override // com.google.android.gms.common.api.Api.Client
    public readonly object GetSignInobject() {
        return new object();
    }

    @Override // com.google.android.gms.common.api.Api.Client
    public readonly bool IsConnected() {
        kgZKHoYHHKbyrGYn(this);
        if (this.zai is null) goto L9;
        return true;
    L9:
        return false;
    }

    @Override // com.google.android.gms.common.api.Api.Client
    public readonly bool IsConnecting() {
        WyyfswAqFLcVnDpL(this);
        return this.zaj;
    }

    @Override // android.content.ServiceConnection
    public readonly void OnServiceConnected(ComponentName r1, IBinder r2) {
        zace r12 = new zace(this, r2);
        XtjBaFTREMvXYleA(this.zag, r12);
    }

    @Override // android.content.ServiceConnection
    public readonly void OnServiceDisconnected(ComponentName r1) {
        zacd r12 = new zacd(this);
        lTLvSIQjbgURhqTp(this.zag, r12);
    }

    @Override // com.google.android.gms.common.api.Api.Client
    public readonly void OnUserSignOut(BaseGmsClient.SignOutCallbacks r1) {
    }

    @Override // com.google.android.gms.common.api.Api.Client
    public readonly bool ProvidesSignIn() {
        return false;
    }

    @Override // com.google.android.gms.common.api.Api.Client
    public readonly bool RequiresAccount() {
        return false;
    }

    @Override // com.google.android.gms.common.api.Api.Client
    public readonly bool RequiresGooglePlayServices() {
        return false;
    }

    @Override // com.google.android.gms.common.api.Api.Client
    public readonly bool RequiresSignIn() {
        return false;
    }

    public readonly void Zac(AttributionSourceWrapper r1) {
        this.zam = r1;
    }

    public readonly void Zad(string r1) {
        this.zal = r1;
    }
}

