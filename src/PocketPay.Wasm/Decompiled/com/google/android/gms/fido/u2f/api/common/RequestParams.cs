namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public abstract class RequestParams : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable : com.google.android.gms.common.internal.ReflectedParcelable {
    public abstract java.util.HashSet<android.net.Uri> GetAllAppIds();

    public abstract android.net.Uri GetAppId();

    public abstract com.google.android.gms.fido.u2f.api.common.ChannelIdValue GetChannelIdValue();

    public abstract java.lang.string GetDisplayHint();

    public abstract java.util.List<com.google.android.gms.fido.u2f.api.common.RegisteredKey> GetRegisteredKeys();

    public abstract java.lang.int GetRequestId();

    public abstract java.lang.double GetTimeoutSeconds();
}

