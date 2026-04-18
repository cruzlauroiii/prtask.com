namespace WillowMaze.Wasm.Decompiled;


public abstract class Eventobject {
    public static com.google.android.datatransport.Eventobject$Builder builder() {
        return new com.google.android.datatransport.AutoValue_Eventobject$Builder();
    }

    public abstract byte[] GetExperimentIdsClear();

    public abstract byte[] GetExperimentIdsEncrypted();

    public abstract java.lang.string GetPseudonymousId();
}

