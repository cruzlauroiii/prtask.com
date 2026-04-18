namespace WillowMaze.Wasm.Decompiled;


public interface ProxyClient : com.google.android.gms.common.api.HasApiKey<com.google.android.gms.auth.api.AuthProxyOptions> {
    com.google.android.gms.tasks.Task<java.lang.string> getSpatulaHeader();

    com.google.android.gms.tasks.Task<com.google.android.gms.auth.api.proxy.ProxyResponse> performProxyRequest(com.google.android.gms.auth.api.proxy.ProxyRequest proxyRequest);
}

