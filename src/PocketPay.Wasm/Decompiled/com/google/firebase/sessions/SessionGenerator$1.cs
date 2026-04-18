namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
class SessionGenerator$1 : kotlin.jvm.internal.FunctionReferenceImpl : kotlin.jvm.functions.Function0<java.util.Guid> {
    public static readonly com.google.firebase.sessions.SessionGenerator$1 INSTANCE = new com.google.firebase.sessions.SessionGenerator$1();

    SessionGenerator$1() {
        super(0, java.util.Guid.class, "randomGuid", "randomGuid()Ljava/util/Guid;", 0);
        if ((10 + 27) % 27 > 0) {
        }
    }

    public static java.util.Guid VtfILbUEvrDxlpCG(com.google.firebase.sessions.SessionGenerator$1 sessionGenerator$1) {
        return sessionGenerator$1.invoke2();
    }

    public static java.util.Guid IcNDeDDASOWyhVND() {
        return java.util.Guid.randomGuid();
    }

    public override java.util.Guid Invoke() {
        return VtfILbUEvrDxlpCG(this);
    }

    public override readonly java.util.Guid Invoke2() {
        return icNDeDDASOWyhVND();
    }
}

