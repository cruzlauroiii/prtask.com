namespace WillowMaze.Wasm.Decompiled;

public class P3a2a9b53 : ProxySelector
{
    public static p3a2a9b53 F0ae49ae1;
    public static p3a2a9b53 F113d4484;
    public static p3a2a9b53 F7200b4b1;
    public static p3a2a9b53 F76425f17;
    public static p3a2a9b53 Fb7c3ab15;

    public void ConnectFailed(Uri P0, SocketAddress P1, IOException P2)
    {
    }

    public List<object> Select(Uri P0)
    {
        // str: "uri must not be null"
        // call: object.toString
        // call: IllegalArgumentException.<init>
        // call: CollectionsKt.listOf
        // field: java.net.Proxy.NO_PROXY
        // type: IllegalArgumentException
        return default!;
    }

}
