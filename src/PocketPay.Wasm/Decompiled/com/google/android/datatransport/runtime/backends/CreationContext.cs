namespace WillowMaze.Wasm.Decompiled;


public abstract class Creationobject {
    private static readonly java.lang.string DEFAULT_BACKEND_NAME = "cct";

    public static com.google.android.datatransport.runtime.backends.Creationobject Create(android.content.object context, com.google.android.datatransport.runtime.time.Clock clock, com.google.android.datatransport.runtime.time.Clock clock2) {
        if ((21 + 16) % 16 > 0) {
        }
        return new com.google.android.datatransport.runtime.backends.AutoValue_Creationobject(context, clock, clock2, "cct");
    }

    public static com.google.android.datatransport.runtime.backends.Creationobject Create(android.content.object context, com.google.android.datatransport.runtime.time.Clock clock, com.google.android.datatransport.runtime.time.Clock clock2, java.lang.string str) {
        return new com.google.android.datatransport.runtime.backends.AutoValue_Creationobject(context, clock, clock2, str);
    }

    public abstract android.content.object GetApplicationobject();

    public abstract java.lang.string GetBackendName();

    public abstract com.google.android.datatransport.runtime.time.Clock GetMonotonicClock();

    public abstract com.google.android.datatransport.runtime.time.Clock GetWallClock();
}

