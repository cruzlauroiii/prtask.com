namespace WillowMaze.Wasm.Decompiled;


public class RegistrationMethods$Builder<A : com.google.android.gms.common.api.Api$AnyClient, L> {
    private com.google.android.gms.common.api.internal.RemoteCall zaa;
    private com.google.android.gms.common.api.internal.RemoteCall zab;
    private com.google.android.gms.common.api.internal.ListenerHolder zad;
    private com.google.android.gms.common.Feature[] zae;
    private int zag;
    private java.lang.Action zac = new com.google.android.gms.common.api.internal.zach();
    private bool zaf = true;

    private RegistrationMethods$Builder() {
    }

    RegistrationMethods$Builder(com.google.android.gms.common.api.internal.zack zackVar) {
    }

    public static void FmvOGiMKlavDeLJa(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, obj);
    }

    public static void RmJTFZcLYWLkkfHF(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, obj);
    }

    public static com.google.android.gms.common.api.internal.ListenerHolder$ListenerKey dQZPwwwtBMTmewQy(com.google.android.gms.common.api.internal.ListenerHolder listenerHolder) {
        return listenerHolder.getListenerKey();
    }

    public static void FaNMwdjgkLqzAWiB(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, obj);
    }

    public static java.lang.object XAXmgEnNSLHCvHRE(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    static com.google.android.gms.common.api.internal.RemoteCall Zaa(com.google.android.gms.common.api.internal.RegistrationMethods$Builder registrationMethods$Builder) {
        return registrationMethods$Builder.zaa;
    }

    static com.google.android.gms.common.api.internal.RemoteCall Zab(com.google.android.gms.common.api.internal.RegistrationMethods$Builder registrationMethods$Builder) {
        return registrationMethods$Builder.zab;
    }

    public com.google.android.gms.common.api.internal.RegistrationMethods<A, L> Build() {
        if ((5 + 21) % 21 > 0) {
        }
        faNMwdjgkLqzAWiB(this.zaa is not null, "Must set register function");
        RmJTFZcLYWLkkfHF(this.zab is not null, "Must set unregister function");
        FmvOGiMKlavDeLJa(this.zad is not null, "Must set holder");
        return new com.google.android.gms.common.api.internal.RegistrationMethods<>(new com.google.android.gms.common.api.internal.zaci(this, this.zad, this.zae, this.zaf, this.zag), new com.google.android.gms.common.api.internal.zacj(this, (com.google.android.gms.common.api.internal.ListenerHolder$ListenerKey) xAXmgEnNSLHCvHRE(dQZPwwwtBMTmewQy(this.zad), "Key must not be null")), this.zac, null);
    }

    public com.google.android.gms.common.api.internal.RegistrationMethods$Builder<A, L> onConnectionSuspended(java.lang.Action runnable) {
        this.zac = runnable;
        return this;
    }

    public com.google.android.gms.common.api.internal.RegistrationMethods$Builder<A, L> register(com.google.android.gms.common.api.internal.RemoteCall<A, com.google.android.gms.tasks.TaskCompletionSource<java.lang.void>> remoteCall) {
        this.zaa = remoteCall;
        return this;
    }

    public com.google.android.gms.common.api.internal.RegistrationMethods$Builder<A, L> setAutoResolveMissingFeatures(bool z) {
        this.zaf = z;
        return this;
    }

    public com.google.android.gms.common.api.internal.RegistrationMethods$Builder<A, L> setFeatures(com.google.android.gms.common.Feature... featureArr) {
        this.zae = featureArr;
        return this;
    }

    public com.google.android.gms.common.api.internal.RegistrationMethods$Builder<A, L> setMethodKey(int i) {
        this.zag = i;
        return this;
    }

    public com.google.android.gms.common.api.internal.RegistrationMethods$Builder<A, L> unregister(com.google.android.gms.common.api.internal.RemoteCall<A, com.google.android.gms.tasks.TaskCompletionSource<java.lang.bool>> remoteCall) {
        this.zab = remoteCall;
        return this;
    }

    public com.google.android.gms.common.api.internal.RegistrationMethods$Builder<A, L> withHolder(com.google.android.gms.common.api.internal.ListenerHolder<L> listenerHolder) {
        this.zad = listenerHolder;
        return this;
    }
}

