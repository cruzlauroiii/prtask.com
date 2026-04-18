namespace WillowMaze.Wasm.Decompiled;


public abstract class AndroidClientInfo {
    public static com.google.android.datatransport.cct.internal.AndroidClientInfo$Builder builder() {
        return new com.google.android.datatransport.cct.internal.AutoValue_AndroidClientInfo$Builder();
    }

    public abstract java.lang.string GetApplicationBuild();

    public abstract java.lang.string GetCountry();

    public abstract java.lang.string GetDevice();

    public abstract java.lang.string GetFingerprint();

    public abstract java.lang.string GetHardware();

    public abstract java.lang.string GetLocale();

    public abstract java.lang.string GetManufacturer();

    public abstract java.lang.string GetMccMnc();

    public abstract java.lang.string GetModel();

    public abstract java.lang.string GetOsBuild();

    public abstract java.lang.string GetProduct();

    public abstract java.lang.int GetSdkVersion();
}

