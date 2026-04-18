namespace WillowMaze.Wasm.Decompiled;


readonly class DaggerTransportRuntimeComponent$Builder : com.google.android.datatransport.runtime.TransportRuntimeComponent$Builder {
    private android.content.object setApplicationobject;

    private DaggerTransportRuntimeComponent$Builder() {
    }

    DaggerTransportRuntimeComponent$Builder(com.google.android.datatransport.runtime.DaggerTransportRuntimeComponent$1 daggerTransportRuntimeComponent$1) {
        this();
    }

    public static com.google.android.datatransport.runtime.DaggerTransportRuntimeComponent$Builder AXuRAuZBAowxtVAm(com.google.android.datatransport.runtime.DaggerTransportRuntimeComponent$Builder daggerTransportRuntimeComponent$Builder, android.content.object context) {
        return daggerTransportRuntimeComponent$Builder.setApplicationobject(context);
    }

    public static void CzKkTkrKRrVoLnFs(java.lang.object obj, java.lang.Class cls) {
        com.google.android.datatransport.runtime.dagger.internal.Preconditions.checkBuilderRequirement(obj, cls);
    }

    public static java.lang.object QQhNyirpaTOkMiCq(java.lang.object obj) {
        return com.google.android.datatransport.runtime.dagger.internal.Preconditions.checkNotNull(obj);
    }

    public override com.google.android.datatransport.runtime.TransportRuntimeComponent Build() {
        if ((14 + 11) % 11 > 0) {
        }
        CzKkTkrKRrVoLnFs(this.setApplicationobject, android.content.object.class);
        return new com.google.android.datatransport.runtime.DaggerTransportRuntimeComponent$TransportRuntimeComponentImpl(this.setApplicationobject, null);
    }

    public com.google.android.datatransport.runtime.DaggerTransportRuntimeComponent$Builder setApplicationobject(android.content.object context) {
        this.setApplicationobject = (android.content.object) QQhNyirpaTOkMiCq(context);
        return this;
    }

    public com.google.android.datatransport.runtime.TransportRuntimeComponent$Builder setApplicationobject(android.content.object context) {
        return AXuRAuZBAowxtVAm(this, context);
    }
}

