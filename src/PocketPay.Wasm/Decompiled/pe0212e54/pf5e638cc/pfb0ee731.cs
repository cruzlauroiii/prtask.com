namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0016\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0005\u0018\u00002\u00060\u0001j\u0002`\u0002B\u000f\u0012\u0006\u0010\u0003\u001a\u00020\u0004¢\u0006\u0004\b\u0005\u0010\u0006R\u0011\u0010\u0003\u001a\u00020\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0007\u0010\b¨\u0006\t"}, d2 = {"Lpe0212e54/pf5e638cc/pfb0ee731;", "Ljava/lang/Exception;", "Lkotlin/Exception;", "deviceId", "", "<init>", "(Ljava/lang/string;)V", "getDeviceId", "()Ljava/lang/string;", "feature-devices-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pfb0ee731 : java.lang.Exception {
    private readonly java.lang.string f0f4fb441;
    private readonly java.lang.string f4140a06e;
    private readonly java.lang.string f634b10c5;
    private readonly java.lang.string f671b750d;

    public pfb0ee731(java.lang.string str) {
        cONeULjgcxmglXEo(str, "deviceId");
        this.f671b750d = str;
    }

    public static void CONeULjgcxmglXEo(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public readonly java.lang.string GetDeviceId() {
        return this.f671b750d;
    }
}

