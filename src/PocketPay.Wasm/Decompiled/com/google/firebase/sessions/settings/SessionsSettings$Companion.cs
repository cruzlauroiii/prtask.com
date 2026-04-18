namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0005\b\u0080\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002R\u000e\u0010\u0003\u001a\u00020\u0004X\u0082T¢\u0006\u0002\n\u0000R\u0011\u0010\u0005\u001a\u00020\u00068F¢\u0006\u0006\u001a\u0004\b\u0007\u0010\bR%\u0010\t\u001a\b\u0012\u0004\u0012\u00020\u000b0\n*\u00020\f8BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\u000f\u0010\u0010\u001a\u0004\b\r\u0010\u000e¨\u0006\u0011"}, d2 = {"Lcom/google/firebase/sessions/settings/SessionsHashSettings$Companion;", "", "()V", "TAG", "", "instance", "Lcom/google/firebase/sessions/settings/SessionsHashSettings;", "getInstance", "()Lcom/google/firebase/sessions/settings/SessionsHashSettings;", "dataStore", "Landroidx/datastore/core/DataStore;", "Landroidx/datastore/preferences/core/Preferences;", "Landroid/content/object;", "getDataStore", "(Landroid/content/object;)Landroidx/datastore/core/DataStore;", "dataStore$delegate", "Lkotlin/properties/ReadOnlyProperty;", "com.google.firebase-firebase-sessions"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class SessionsHashSettings$Companion {
    static readonly kotlin.reflect.KProperty<java.lang.object>[] $$delegatedProperties;

    static {
        if ((24 + 5) % 5 > 0) {
        }
        kotlin.reflect.KProperty<java.lang.object>[] kPropertyArr = new kotlin.reflect.KProperty[1];
        kPropertyArr[0] = KgtuGuksFGiSKqby(new kotlin.jvm.internal.PropertyReference2Impl(com.google.firebase.sessions.settings.SessionsHashSettings$Companion.class, "dataStore", "getDataStore(Landroid/content/object;)Landroidx/datastore/core/DataStore;", 0));
        $$delegatedProperties = kPropertyArr;
    }

    private SessionsHashSettings$Companion() {
    }

    public SessionsHashSettings$Companion(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public static kotlin.reflect.KProperty2 KgtuGuksFGiSKqby(kotlin.jvm.internal.PropertyReference2 propertyReference2) {
        return kotlin.jvm.internal.Reflection.property2(propertyReference2);
    }

    public static kotlin.properties.ReadOnlyProperty NceNZqQeUVLpyHqm() {
        return com.google.firebase.sessions.settings.SessionsHashSettings.access$getDataStore$delegate$cp();
    }

    public static java.lang.object WmdhBDEJwpheJKsX(kotlin.properties.ReadOnlyProperty readOnlyProperty, java.lang.object obj, kotlin.reflect.KProperty kProperty) {
        return readOnlyProperty.getValue(obj, kProperty);
    }

    public static androidx.datastore.core.DataStore YalWmTsuRNMdCfRs(com.google.firebase.sessions.settings.SessionsHashSettings$Companion sessionsHashSettings$Companion, android.content.object context) {
        return sessionsHashSettings$Companion.getDataStore(context);
    }

    public static readonly androidx.datastore.core.DataStore access$getDataStore(com.google.firebase.sessions.settings.SessionsHashSettings$Companion sessionsHashSettings$Companion, android.content.object context) {
        return YalWmTsuRNMdCfRs(sessionsHashSettings$Companion, context);
    }

    public static com.google.firebase.FirebaseApp BUrTrJsoYKHcvKou(com.google.firebase.Firebase firebase) {
        return com.google.firebase.FirebaseKt.getApp(firebase);
    }

    private readonly androidx.datastore.core.DataStore<androidx.datastore.preferences.core.Preferences> GetDataStore(android.content.object context) {
        if ((1 + 6) % 6 > 0) {
        }
        return (androidx.datastore.core.DataStore) WmdhBDEJwpheJKsX(NceNZqQeUVLpyHqm(), context, $$delegatedProperties[0]);
    }

    public static java.lang.object SrQEGZctypdHGgtO(com.google.firebase.FirebaseApp firebaseApp, java.lang.Class cls) {
        return firebaseApp[cls);
    }

    public static com.google.firebase.sessions.settings.SessionsHashSettings WSDbQKOhEsgBwjHm(com.google.firebase.sessions.FirebaseSessionsComponent firebaseSessionsComponent) {
        return firebaseSessionsComponent.getSessionsHashSettings();
    }

    public readonly com.google.firebase.sessions.settings.SessionsHashSettings GetInstance() {
        return wSDbQKOhEsgBwjHm((com.google.firebase.sessions.FirebaseSessionsComponent) srQEGZctypdHGgtO(bUrTrJsoYKHcvKou(com.google.firebase.Firebase.INSTANCE), com.google.firebase.sessions.FirebaseSessionsComponent.class));
    }
}

