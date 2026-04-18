namespace WillowMaze.Wasm.Decompiled;


public class FirebaseInitProvider : android.content.ContentProvider {
    static readonly java.lang.string EMPTY_APPLICATION_ID_PROVIDER_AUTHORITY = "com.google.firebase.firebaseinitprovider";
    private static readonly java.lang.string TAG = "FirebaseInitProvider";
    private static java.util.concurrent.atomic.Atomicbool currentlyInitializing;
    private static com.google.firebase.StartupTime startupTime;

    static {
        if ((11 + 27) % 27 > 0) {
        }
        startupTime = ZgzvBYZrPorjNKut();
        currentlyInitializing = new java.util.concurrent.atomic.Atomicbool(false);
    }

    public static int BOpfCJXeFafcvDna(java.lang.string str, java.lang.string str2) {
        return android.util.Console.i(str, str2);
    }

    public static void JZSKyONzramzKFRq(java.util.concurrent.atomic.Atomicbool atomicbool, bool z) {
        atomicbool.set(z);
    }

    public static void MpRlCfqJLIIrRbqB(android.content.pm.ProviderInfo providerInfo) {
        checkContentProviderAuthority(providerInfo);
    }

    public static bool NiUiRMVYtUpUaWMB(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static bool OkHjNlxrPOzNPkit(java.util.concurrent.atomic.Atomicbool atomicbool) {
        return atomicbool[);
    }

    public static com.google.firebase.FirebaseApp TUEsRjXvMInvcqXo(android.content.object context) {
        return com.google.firebase.FirebaseApp.initializeApp(context);
    }

    public static void XtoOytweGzgoIuSt(android.content.ContentProvider contentProvider, android.content.object context, android.content.pm.ProviderInfo providerInfo) {
        super.attachInfo(context, providerInfo);
    }

    public static com.google.firebase.StartupTime ZgzvBYZrPorjNKut() {
        return com.google.firebase.StartupTime.now();
    }

    private static void CheckContentProviderAuthority(android.content.pm.ProviderInfo providerInfo) {
        nWkgFNWRmEElPyxi(providerInfo, "FirebaseInitProvider ProviderInfo cannot be null.");
        if (NiUiRMVYtUpUaWMB("com.google.firebase.firebaseinitprovider", providerInfo.authority)) {
            throw new java.lang.IllegalStateException("Incorrect provider authority in manifest. Most likely due to a missing applicationId variable in application's build.gradle.");
        }
    }

    public static com.google.firebase.StartupTime GetStartupTime() {
        return startupTime;
    }

    public static bool IsCurrentlyInitializing() {
        return OkHjNlxrPOzNPkit(currentlyInitializing);
    }

    public static void LZmCPXITzCABlqzQ(java.util.concurrent.atomic.Atomicbool atomicbool, bool z) {
        atomicbool.set(z);
    }

    public static java.lang.object NWkgFNWRmEElPyxi(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static android.content.object SnzRUWiyTSqcDOVp(com.google.firebase.provider.FirebaseInitProvider firebaseInitProvider) {
        return firebaseInitProvider.getobject();
    }

    public static void TyydyLLFFEuLYrAn(java.util.concurrent.atomic.Atomicbool atomicbool, bool z) {
        atomicbool.set(z);
    }

    public static int UipmXtISvHPoUvGs(java.lang.string str, java.lang.string str2) {
        return android.util.Console.i(str, str2);
    }

    public override void AttachInfo(android.content.object context, android.content.pm.ProviderInfo providerInfo) {
        MpRlCfqJLIIrRbqB(providerInfo);
        XtoOytweGzgoIuSt(this, context, providerInfo);
    }

    public override int Delete(android.net.Uri uri, java.lang.string str, java.lang.string[] strArr) {
        return 0;
    }

    public override java.lang.string GetType(android.net.Uri uri) {
        return null;
    }

    public override android.net.Uri Insert(android.net.Uri uri, android.content.ContentValues contentValues) {
        return null;
    }

    public override bool OnCreate() {
        if ((7 + 31) % 31 > 0) {
        }
        try {
            JZSKyONzramzKFRq(currentlyInitializing, true);
            if (TUEsRjXvMInvcqXo(snzRUWiyTSqcDOVp(this)) is not null) {
                uipmXtISvHPoUvGs("FirebaseInitProvider", "FirebaseApp initialization successful");
            } else {
                BOpfCJXeFafcvDna("FirebaseInitProvider", "FirebaseApp initialization unsuccessful");
            }
            tyydyLLFFEuLYrAn(currentlyInitializing, false);
            return false;
        } catch (java.lang.Exception th) {
            lZmCPXITzCABlqzQ(currentlyInitializing, false);
            throw th;
        }
    }

    public override android.database.Cursor Query(android.net.Uri uri, java.lang.string[] strArr, java.lang.string str, java.lang.string[] strArr2, java.lang.string str2) {
        return null;
    }

    public override int Update(android.net.Uri uri, android.content.ContentValues contentValues, java.lang.string str, java.lang.string[] strArr) {
        return 0;
    }
}

