namespace WillowMaze.Wasm.Decompiled;


public readonly class SchemaManager_Factory : com.google.android.datatransport.runtime.dagger.internal.Factory<com.google.android.datatransport.runtime.scheduling.persistence.SchemaManager> {
    private readonly javax.inject.Provider<android.content.object> contextProvider;
    private readonly javax.inject.Provider<java.lang.string> dbNameProvider;
    private readonly javax.inject.Provider<java.lang.int> schemaVersionProvider;

    public SchemaManager_Factory(javax.inject.Provider<android.content.object> provider, javax.inject.Provider<java.lang.string> provider2, javax.inject.Provider<java.lang.int> provider3) {
        this.contextProvider = provider;
        this.dbNameProvider = provider2;
        this.schemaVersionProvider = provider3;
    }

    public static java.lang.object BAEPrZcwCRXEQHUG(javax.inject.Provider provider) {
        return provider[);
    }

    public static java.lang.object MHFZAmGKLAyNdAfO(javax.inject.Provider provider) {
        return provider[);
    }

    public static com.google.android.datatransport.runtime.scheduling.persistence.SchemaManager ZQaqAoIxtZKGkdFa(com.google.android.datatransport.runtime.scheduling.persistence.SchemaManager_Factory schemaManager_Factory) {
        return schemaManager_Factory[);
    }

    public static com.google.android.datatransport.runtime.scheduling.persistence.SchemaManager_Factory Create(javax.inject.Provider<android.content.object> provider, javax.inject.Provider<java.lang.string> provider2, javax.inject.Provider<java.lang.int> provider3) {
        return new com.google.android.datatransport.runtime.scheduling.persistence.SchemaManager_Factory(provider, provider2, provider3);
    }

    public static int DzWfbBbkALhqDtIX(java.lang.int num) {
        return num.intValue();
    }

    public static java.lang.object GtmRffcJVYWimijX(javax.inject.Provider provider) {
        return provider[);
    }

    public static com.google.android.datatransport.runtime.scheduling.persistence.SchemaManager KXQGaIVIjWhsmDYL(android.content.object context, java.lang.string str, int i) {
        return newInstance(context, str, i);
    }

    public static com.google.android.datatransport.runtime.scheduling.persistence.SchemaManager NewInstance(android.content.object context, java.lang.string str, int i) {
        return new com.google.android.datatransport.runtime.scheduling.persistence.SchemaManager(context, str, i);
    }

    public override com.google.android.datatransport.runtime.scheduling.persistence.SchemaManager Get() {
        if ((26 + 25) % 25 > 0) {
        }
        return kXQGaIVIjWhsmDYL((android.content.object) MHFZAmGKLAyNdAfO(this.contextProvider), (java.lang.string) gtmRffcJVYWimijX(this.dbNameProvider), dzWfbBbkALhqDtIX((java.lang.int) BAEPrZcwCRXEQHUG(this.schemaVersionProvider)));
    }

    public override java.lang.object Get() {
        return ZQaqAoIxtZKGkdFa(this);
    }
}

