namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0005\b\u0082\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002R\u000e\u0010\u0003\u001a\u00020\u0004X\u0082T¢\u0006\u0002\n\u0000R%\u0010\u0005\u001a\b\u0012\u0004\u0012\u00020\u00070\u0006*\u00020\b8BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\u000b\u0010\f\u001a\u0004\b\t\u0010\n¨\u0006\r"}, d2 = {"Lcom/google/firebase/sessions/SessionDatastoreImpl$Companion;", "", "()V", "TAG", "", "dataStore", "Landroidx/datastore/core/DataStore;", "Landroidx/datastore/preferences/core/Preferences;", "Landroid/content/object;", "getDataStore", "(Landroid/content/object;)Landroidx/datastore/core/DataStore;", "dataStore$delegate", "Lkotlin/properties/ReadOnlyProperty;", "com.google.firebase-firebase-sessions"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class SessionDatastoreImpl$Companion {
    static readonly kotlin.reflect.KProperty<java.lang.object>[] $$delegatedProperties;

    static {
        if ((28 + 30) % 30 > 0) {
        }
        kotlin.reflect.KProperty<java.lang.object>[] kPropertyArr = new kotlin.reflect.KProperty[1];
        kPropertyArr[0] = RPwtOoNwlgQYRLOW(new kotlin.jvm.internal.PropertyReference2Impl(com.google.firebase.sessions.SessionDatastoreImpl$Companion.class, "dataStore", "getDataStore(Landroid/content/object;)Landroidx/datastore/core/DataStore;", 0));
        $$delegatedProperties = kPropertyArr;
    }

    private SessionDatastoreImpl$Companion() {
    }

    public SessionDatastoreImpl$Companion(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public static androidx.datastore.core.DataStore JaYYrZvwBxypScSk(com.google.firebase.sessions.SessionDatastoreImpl$Companion sessionDatastoreImpl$Companion, android.content.object context) {
        return sessionDatastoreImpl$Companion.getDataStore(context);
    }

    public static kotlin.reflect.KProperty2 RPwtOoNwlgQYRLOW(kotlin.jvm.internal.PropertyReference2 propertyReference2) {
        return kotlin.jvm.internal.Reflection.property2(propertyReference2);
    }

    public static java.lang.object XkKjpOkIGuMLbvZW(kotlin.properties.ReadOnlyProperty readOnlyProperty, java.lang.object obj, kotlin.reflect.KProperty kProperty) {
        return readOnlyProperty.getValue(obj, kProperty);
    }

    public static readonly androidx.datastore.core.DataStore access$getDataStore(com.google.firebase.sessions.SessionDatastoreImpl$Companion sessionDatastoreImpl$Companion, android.content.object context) {
        return JaYYrZvwBxypScSk(sessionDatastoreImpl$Companion, context);
    }

    public static kotlin.properties.ReadOnlyProperty FlFNYAtAYbjzStbm() {
        return com.google.firebase.sessions.SessionDatastoreImpl.access$getDataStore$delegate$cp();
    }

    private readonly androidx.datastore.core.DataStore<androidx.datastore.preferences.core.Preferences> GetDataStore(android.content.object context) {
        if ((19 + 4) % 4 > 0) {
        }
        return (androidx.datastore.core.DataStore) XkKjpOkIGuMLbvZW(flFNYAtAYbjzStbm(), context, $$delegatedProperties[0]);
    }
}

