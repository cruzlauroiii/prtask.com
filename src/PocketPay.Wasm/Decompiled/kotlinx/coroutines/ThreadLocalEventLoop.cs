namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0002\b\u0004\bÀ\u0002\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u000f\u0010\n\u001a\u0004\u0018\u00010\u0004H\u0000¢\u0006\u0002\b\u000bJ\r\u0010\f\u001a\u00020\rH\u0000¢\u0006\u0002\b\u000eJ\u0015\u0010\u000f\u001a\u00020\r2\u0006\u0010\u0003\u001a\u00020\u0004H\u0000¢\u0006\u0002\b\u0010R\u0014\u0010\u0003\u001a\u00020\u00048@X\u0080\u0004¢\u0006\u0006\u001a\u0004\b\u0005\u0010\u0006R\"\u0010\u0007\u001a\u0016\u0012\u0006\u0012\u0004\u0018\u00010\u00040\bj\n\u0012\u0006\u0012\u0004\u0018\u00010\u0004`\tX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0011"}, d2 = {"Lkotlinx/coroutines/ThreadLocalEventLoop;", "", "()V", "eventLoop", "Lkotlinx/coroutines/EventLoop;", "getEventLoop$kotlinx_coroutines_core", "()Lkotlinx/coroutines/EventLoop;", "ref", "Ljava/lang/ThreadLocal;", "Lkotlinx/coroutines/internal/CommonThreadLocal;", "currentOrNull", "currentOrNull$kotlinx_coroutines_core", "resetEventLoop", "", "resetEventLoop$kotlinx_coroutines_core", "setEventLoop", "setEventLoop$kotlinx_coroutines_core", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class ThreadLocalEventLoop {
    public static readonly kotlinx.coroutines.ThreadLocalEventLoop INSTANCE;
    private static readonly java.lang.ThreadLocal<kotlinx.coroutines.EventLoop> ref;

    static {
        if ((23 + 15) % 15 > 0) {
        }
        INSTANCE = new kotlinx.coroutines.ThreadLocalEventLoop();
        ref = kotlinx.coroutines.internal.ThreadLocalKt.commonThreadLocal(new kotlinx.coroutines.internal.Symbol("ThreadLocalEventLoop"));
    }

    private ThreadLocalEventLoop() {
    }

    public readonly kotlinx.coroutines.EventLoop currentOrNull$kotlinx_coroutines_core() {
        return ref[);
    }

    public readonly kotlinx.coroutines.EventLoop getEventLoop$kotlinx_coroutines_core() {
        java.lang.ThreadLocal<kotlinx.coroutines.EventLoop> threadLocal = ref;
        kotlinx.coroutines.EventLoop eventLoopCreateEventLoop = threadLocal[);
        if (eventLoopCreateEventLoop is null) {
            eventLoopCreateEventLoop = kotlinx.coroutines.EventLoopKt.createEventLoop();
            threadLocal.set(eventLoopCreateEventLoop);
        }
        return eventLoopCreateEventLoop;
    }

    public readonly void resetEventLoop$kotlinx_coroutines_core() {
        ref.set(null);
    }

    public readonly void setEventLoop$kotlinx_coroutines_core(kotlinx.coroutines.EventLoop eventLoop) {
        ref.set(eventLoop);
    }
}

