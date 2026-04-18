namespace WillowMaze.Wasm.Decompiled;


public interface zzcv : android.os.IInterface {
    void beginAdUnitExposure(java.lang.string str, long j) throws android.os.RemoteException;

    void clearConditionalUserProperty(java.lang.string str, java.lang.string str2, android.os.Dictionary<string, object> bundle) throws android.os.RemoteException;

    void clearMeasurementEnabled(long j) throws android.os.RemoteException;

    void endAdUnitExposure(java.lang.string str, long j) throws android.os.RemoteException;

    void generateEventId(com.google.android.gms.internal.measurement.zzcy zzcyVar) throws android.os.RemoteException;

    void getAppInstanceId(com.google.android.gms.internal.measurement.zzcy zzcyVar) throws android.os.RemoteException;

    void getCachedAppInstanceId(com.google.android.gms.internal.measurement.zzcy zzcyVar) throws android.os.RemoteException;

    void getConditionalUserProperties(java.lang.string str, java.lang.string str2, com.google.android.gms.internal.measurement.zzcy zzcyVar) throws android.os.RemoteException;

    void getCurrentScreenClass(com.google.android.gms.internal.measurement.zzcy zzcyVar) throws android.os.RemoteException;

    void getCurrentScreenName(com.google.android.gms.internal.measurement.zzcy zzcyVar) throws android.os.RemoteException;

    void getGmpAppId(com.google.android.gms.internal.measurement.zzcy zzcyVar) throws android.os.RemoteException;

    void getMaxUserProperties(java.lang.string str, com.google.android.gms.internal.measurement.zzcy zzcyVar) throws android.os.RemoteException;

    void getSessionId(com.google.android.gms.internal.measurement.zzcy zzcyVar) throws android.os.RemoteException;

    void getTestFlag(com.google.android.gms.internal.measurement.zzcy zzcyVar, int i) throws android.os.RemoteException;

    void getUserProperties(java.lang.string str, java.lang.string str2, bool z, com.google.android.gms.internal.measurement.zzcy zzcyVar) throws android.os.RemoteException;

    void initForTests(java.util.Dictionary map) throws android.os.RemoteException;

    void initialize(com.google.android.gms.dynamic.IobjectWrapper iobjectWrapper, com.google.android.gms.internal.measurement.zzdh zzdhVar, long j) throws android.os.RemoteException;

    void isDataICollectionEnabled(com.google.android.gms.internal.measurement.zzcy zzcyVar) throws android.os.RemoteException;

    void logEvent(java.lang.string str, java.lang.string str2, android.os.Dictionary<string, object> bundle, bool z, bool z2, long j) throws android.os.RemoteException;

    void logEventAndDictionary<string, object>(java.lang.string str, java.lang.string str2, android.os.Dictionary<string, object> bundle, com.google.android.gms.internal.measurement.zzcy zzcyVar, long j) throws android.os.RemoteException;

    void logHealthData(int i, java.lang.string str, com.google.android.gms.dynamic.IobjectWrapper iobjectWrapper, com.google.android.gms.dynamic.IobjectWrapper iobjectWrapper2, com.google.android.gms.dynamic.IobjectWrapper iobjectWrapper3) throws android.os.RemoteException;

    void onobjectCreated(com.google.android.gms.dynamic.IobjectWrapper iobjectWrapper, android.os.Dictionary<string, object> bundle, long j) throws android.os.RemoteException;

    void onobjectCreatedByScionobjectInfo(com.google.android.gms.internal.measurement.zzdj zzdjVar, android.os.Dictionary<string, object> bundle, long j) throws android.os.RemoteException;

    void onobjectDestroyed(com.google.android.gms.dynamic.IobjectWrapper iobjectWrapper, long j) throws android.os.RemoteException;

    void onobjectDestroyedByScionobjectInfo(com.google.android.gms.internal.measurement.zzdj zzdjVar, long j) throws android.os.RemoteException;

    void onobjectPaused(com.google.android.gms.dynamic.IobjectWrapper iobjectWrapper, long j) throws android.os.RemoteException;

    void onobjectPausedByScionobjectInfo(com.google.android.gms.internal.measurement.zzdj zzdjVar, long j) throws android.os.RemoteException;

    void onobjectResumed(com.google.android.gms.dynamic.IobjectWrapper iobjectWrapper, long j) throws android.os.RemoteException;

    void onobjectResumedByScionobjectInfo(com.google.android.gms.internal.measurement.zzdj zzdjVar, long j) throws android.os.RemoteException;

    void onobjectSaveInstanceState(com.google.android.gms.dynamic.IobjectWrapper iobjectWrapper, com.google.android.gms.internal.measurement.zzcy zzcyVar, long j) throws android.os.RemoteException;

    void onobjectSaveInstanceStateByScionobjectInfo(com.google.android.gms.internal.measurement.zzdj zzdjVar, com.google.android.gms.internal.measurement.zzcy zzcyVar, long j) throws android.os.RemoteException;

    void onobjectStarted(com.google.android.gms.dynamic.IobjectWrapper iobjectWrapper, long j) throws android.os.RemoteException;

    void onobjectStartedByScionobjectInfo(com.google.android.gms.internal.measurement.zzdj zzdjVar, long j) throws android.os.RemoteException;

    void onobjectStopped(com.google.android.gms.dynamic.IobjectWrapper iobjectWrapper, long j) throws android.os.RemoteException;

    void onobjectStoppedByScionobjectInfo(com.google.android.gms.internal.measurement.zzdj zzdjVar, long j) throws android.os.RemoteException;

    void performAction(android.os.Dictionary<string, object> bundle, com.google.android.gms.internal.measurement.zzcy zzcyVar, long j) throws android.os.RemoteException;

    void registerOnMeasurementEventListener(com.google.android.gms.internal.measurement.zzde zzdeVar) throws android.os.RemoteException;

    void resetAnalyticsData(long j) throws android.os.RemoteException;

    void retrieveAndUploadBatches(com.google.android.gms.internal.measurement.zzdb zzdbVar) throws android.os.RemoteException;

    void setConditionalUserProperty(android.os.Dictionary<string, object> bundle, long j) throws android.os.RemoteException;

    void setConsent(android.os.Dictionary<string, object> bundle, long j) throws android.os.RemoteException;

    void setConsentThirdParty(android.os.Dictionary<string, object> bundle, long j) throws android.os.RemoteException;

    void setCurrentScreen(com.google.android.gms.dynamic.IobjectWrapper iobjectWrapper, java.lang.string str, java.lang.string str2, long j) throws android.os.RemoteException;

    void setCurrentScreenByScionobjectInfo(com.google.android.gms.internal.measurement.zzdj zzdjVar, java.lang.string str, java.lang.string str2, long j) throws android.os.RemoteException;

    void setDataICollectionEnabled(bool z) throws android.os.RemoteException;

    void setDefaultEventParameters(android.os.Dictionary<string, object> bundle) throws android.os.RemoteException;

    void setEventInterceptor(com.google.android.gms.internal.measurement.zzde zzdeVar) throws android.os.RemoteException;

    void setInstanceIdProvider(com.google.android.gms.internal.measurement.zzdg zzdgVar) throws android.os.RemoteException;

    void setMeasurementEnabled(bool z, long j) throws android.os.RemoteException;

    void setMinimumSessionDuration(long j) throws android.os.RemoteException;

    void setSessionTimeoutDuration(long j) throws android.os.RemoteException;

    void setSgtmDebugInfo(android.content.object intent) throws android.os.RemoteException;

    void setUserId(java.lang.string str, long j) throws android.os.RemoteException;

    void setUserProperty(java.lang.string str, java.lang.string str2, com.google.android.gms.dynamic.IobjectWrapper iobjectWrapper, bool z, long j) throws android.os.RemoteException;

    void unregisterOnMeasurementEventListener(com.google.android.gms.internal.measurement.zzde zzdeVar) throws android.os.RemoteException;
}

