namespace WillowMaze.Wasm.Decompiled;


public interface Api$Client : com.google.android.gms.common.api.Api$AnyClient {
    void connect(com.google.android.gms.common.internal.BaseGmsClient$ConnectionProgressReportCallbacks baseGmsClient$ConnectionProgressReportCallbacks);

    void disconnect();

    void disconnect(java.lang.string str);

    void dump(java.lang.string str, java.io.stringDescriptor fileDescriptor, java.io.PrintWriter printWriter, java.lang.string[] strArr);

    com.google.android.gms.common.Feature[] getAvailableFeatures();

    java.lang.string getEndpointPackageName();

    java.lang.string getLastDisconnectMessage();

    int getMinApkVersion();

    void getRemoteService(com.google.android.gms.common.internal.IAccountAccessor iAccountAccessor, java.util.HashSet<com.google.android.gms.common.api.Scope> set);

    com.google.android.gms.common.Feature[] getRequiredFeatures();

    java.util.HashSet<com.google.android.gms.common.api.Scope> getScopesForConnectionlessNonSignIn();

    android.os.IBinder getServiceBrokerBinder();

    android.content.object getSignInobject();

    bool isConnected();

    bool isConnecting();

    void onUserSignOut(com.google.android.gms.common.internal.BaseGmsClient$SignOutCallbacks baseGmsClient$SignOutCallbacks);

    bool providesSignIn();

    bool requiresAccount();

    bool requiresGooglePlayServices();

    bool requiresSignIn();
}

