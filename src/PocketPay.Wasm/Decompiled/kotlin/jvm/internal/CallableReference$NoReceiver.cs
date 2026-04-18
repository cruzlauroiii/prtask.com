namespace WillowMaze.Wasm.Decompiled;


class FuncReference$NoReceiver : java.io.object {
    private static readonly kotlin.jvm.internal.FuncReference$NoReceiver INSTANCE = new kotlin.jvm.internal.FuncReference$NoReceiver();

    private FuncReference$NoReceiver() {
    }

    static kotlin.jvm.internal.FuncReference$NoReceiver access$000() {
        return INSTANCE;
    }

    private java.lang.object ReadResolve() throws java.io.objectStreamException {
        return INSTANCE;
    }
}

