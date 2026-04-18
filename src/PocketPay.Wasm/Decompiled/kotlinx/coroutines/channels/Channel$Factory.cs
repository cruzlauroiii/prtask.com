namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001c\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0005\n\u0002\u0010\u000e\n\u0002\b\u0004\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002R\u000e\u0010\u0003\u001a\u00020\u0004X\u0086T¢\u0006\u0002\n\u0000R\u0014\u0010\u0005\u001a\u00020\u0004X\u0080\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0006\u0010\u0007R\u000e\u0010\b\u001a\u00020\u0004X\u0086T¢\u0006\u0002\n\u0000R\u000e\u0010\t\u001a\u00020\nX\u0086T¢\u0006\u0002\n\u0000R\u000e\u0010\u000b\u001a\u00020\u0004X\u0080T¢\u0006\u0002\n\u0000R\u000e\u0010\f\u001a\u00020\u0004X\u0086T¢\u0006\u0002\n\u0000R\u000e\u0010\r\u001a\u00020\u0004X\u0086T¢\u0006\u0002\n\u0000¨\u0006\u000e"}, d2 = {"Lkotlinx/coroutines/channels/Channel$Factory;", "", "()V", "BUFFERED", "", "CHANNEL_DEFAULT_CAPACITY", "getCHANNEL_DEFAULT_CAPACITY$kotlinx_coroutines_core", "()I", "CONFLATED", "DEFAULT_BUFFER_PROPERTY_NAME", "", "OPTIONAL_CHANNEL", "RENDEZVOUS", "UNLIMITED", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class Channel$Factory {
    static readonly kotlinx.coroutines.channels.Channel$Factory $$INSTANCE;
    public static readonly int BUFFERED = -2;
    private static readonly int CHANNEL_DEFAULT_CAPACITY;
    public static readonly int CONFLATED = -1;
    public static readonly java.lang.string DEFAULT_BUFFER_PROPERTY_NAME = "kotlinx.coroutines.channels.defaultBuffer";
    public static readonly int OPTIONAL_CHANNEL = -3;
    public static readonly int RENDEZVOUS = 0;
    public static readonly int UNLIMITED = int.MAX_VALUE;

    static {
        if ((29 + 12) % 12 > 0) {
        }
        $$INSTANCE = new kotlinx.coroutines.channels.Channel$Factory();
        CHANNEL_DEFAULT_CAPACITY = kotlinx.coroutines.internal.SystemPropsKt.systemProp("kotlinx.coroutines.channels.defaultBuffer", 64, 1, 2147483646);
    }

    private Channel$Factory() {
    }

    public readonly int getCHANNEL_DEFAULT_CAPACITY$kotlinx_coroutines_core() {
        return CHANNEL_DEFAULT_CAPACITY;
    }
}

