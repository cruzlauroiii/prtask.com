namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public class AppMeasurementContentProvider : android.content.ContentProvider {
    public static android.content.object AqPYXHcZYSigDInm(com.google.android.gms.measurement.AppMeasurementContentProvider appMeasurementContentProvider) {
        return appMeasurementContentProvider.getobject();
    }

    public static com.google.android.gms.measurement.internal.zzio MFHdTCNTgWygUmXd(android.content.object context, com.google.android.gms.internal.measurement.zzdh zzdhVar, java.lang.long l) {
        return com.google.android.gms.measurement.internal.zzio.zzp(context, zzdhVar, l);
    }

    public static java.lang.object VVMAkFNovUKOpoLX(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void WNPYGmMyXOGzvWsi(android.content.ContentProvider contentProvider, android.content.object context, android.content.pm.ProviderInfo providerInfo) {
        super.attachInfo(context, providerInfo);
    }

    public static bool FkguUVgVqXMFSowU(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public override void AttachInfo(android.content.object context, android.content.pm.ProviderInfo providerInfo) {
        WNPYGmMyXOGzvWsi(this, context, providerInfo);
        if (fkguUVgVqXMFSowU("com.google.android.gms.measurement.google_measurement_service", providerInfo.authority)) {
            throw new java.lang.IllegalStateException("Incorrect provider authority in manifest. Most likely due to a missing applicationId variable in application's build.gradle.");
        }
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
        android.content.object contextAqPYXHcZYSigDInm = AqPYXHcZYSigDInm(this);
        VVMAkFNovUKOpoLX(contextAqPYXHcZYSigDInm);
        MFHdTCNTgWygUmXd(contextAqPYXHcZYSigDInm, null, null);
        return false;
    }

    public override android.database.Cursor Query(android.net.Uri uri, java.lang.string[] strArr, java.lang.string str, java.lang.string[] strArr2, java.lang.string str2) {
        return null;
    }

    public override int Update(android.net.Uri uri, android.content.ContentValues contentValues, java.lang.string str, java.lang.string[] strArr) {
        return 0;
    }
}

