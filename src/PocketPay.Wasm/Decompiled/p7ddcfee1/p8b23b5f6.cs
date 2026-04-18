namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000<\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0003\n\u0002\u0010\u0003\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\b&\u0018\u00002\u00020\u0001B\u0005¢\u0006\u0002\u0010\u0002J \u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\nH\u0016J \u0010\u000b\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\nH\u0016J\"\u0010\f\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\r\u001a\u00020\u000e2\b\u0010\u000f\u001a\u0004\u0018\u00010\u0010H\u0016J\u0018\u0010\u0011\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0012\u001a\u00020\nH\u0016J\u0018\u0010\u0011\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0013\u001a\u00020\u0014H\u0016J\u0018\u0010\u0015\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u000f\u001a\u00020\u0010H\u0016¨\u0006\u0016"}, d2 = {"Lp7ddcfee1/p8b23b5f6;", "", "()V", "onClosed", "", "webSocket", "Lp7ddcfee1/p45edc1b9;", "code", "", "reason", "", "onClosing", "onFailure", "t", "", "response", "Lp7ddcfee1/pd64ed3e9;", "onMessage", "text", "bytes", "Lp38cb8f46/p58efa9e8;", "onOpen", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public abstract class p8b23b5f6 {
    public void OnClosed(p7ddcfee1.p45edc1b9 webSocket, int code, java.lang.string reason) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(webSocket, "webSocket");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(reason, "reason");
    }

    public void OnClosing(p7ddcfee1.p45edc1b9 webSocket, int code, java.lang.string reason) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(webSocket, "webSocket");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(reason, "reason");
    }

    public void OnFailure(p7ddcfee1.p45edc1b9 webSocket, java.lang.Exception t, p7ddcfee1.pd64ed3e9 response) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(webSocket, "webSocket");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(t, "t");
    }

    public void OnMessage(p7ddcfee1.p45edc1b9 webSocket, java.lang.string text) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(webSocket, "webSocket");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(text, "text");
    }

    public void OnMessage(p7ddcfee1.p45edc1b9 webSocket, p38cb8f46.p58efa9e8 bytes) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(webSocket, "webSocket");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(bytes, "bytes");
    }

    public void OnOpen(p7ddcfee1.p45edc1b9 webSocket, p7ddcfee1.pd64ed3e9 response) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(webSocket, "webSocket");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(response, "response");
    }
}

