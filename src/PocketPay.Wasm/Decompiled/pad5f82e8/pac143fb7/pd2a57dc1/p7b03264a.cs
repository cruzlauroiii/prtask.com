namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u0010\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\tH\u0016J\b\u0010\n\u001a\u00020\tH\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u000b"}, d2 = {"Lpad5f82e8/pac143fb7/pd2a57dc1/p7b03264a;", "Lpad5f82e8/pac143fb7/pd2a57dc1/p1d4a7bbf;", "applicationModeRepository", "Lp8d777f38/pb3f20355/pd2a57dc1/p707b8067;", "<init>", "(Lp8d777f38/pb3f20355/pd2a57dc1/p707b8067;)V", "setMode", "", "applicationModeType", "Lpad5f82e8/p07214c67/pd2a57dc1/p5eb17667;", "getMode", "common-domain-usecase_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p7b03264a : pad5f82e8.pac143fb7.pd2a57dc1.p1d4a7bbf {
    private readonly p8d777f38.pb3f20355.pd2a57dc1.p707b8067 fa6c49f1f;
    private readonly p8d777f38.pb3f20355.pd2a57dc1.p707b8067 fb78a79ca;
    private readonly p8d777f38.pb3f20355.pd2a57dc1.p707b8067 fc76f72a4;

    public p7b03264a(p8d777f38.pb3f20355.pd2a57dc1.p707b8067 p707b8067Var) {
        rzvmzNndRAmzvdsM(p707b8067Var, "applicationModeRepository");
        this.fc76f72a4 = p707b8067Var;
    }

    public static void MlZUPpbvgZoHWPEa(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static pad5f82e8.p07214c67.pd2a57dc1.p5eb17667 NTJMAdYikcdTiilB(p8d777f38.pb3f20355.pd2a57dc1.p707b8067 p707b8067Var) {
        return p707b8067Var.getModeType();
    }

    public static void PvlzsjHABiTevBSM(p8d777f38.pb3f20355.pd2a57dc1.p707b8067 p707b8067Var, pad5f82e8.p07214c67.pd2a57dc1.p5eb17667 p5eb17667Var) {
        p707b8067Var.setMode(p5eb17667Var);
    }

    public static void RzvmzNndRAmzvdsM(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public override pad5f82e8.p07214c67.pd2a57dc1.p5eb17667 GetMode() {
        return NTJMAdYikcdTiilB(this.fc76f72a4);
    }

    public override void SetMode(pad5f82e8.p07214c67.pd2a57dc1.p5eb17667 applicationModeType) {
        MlZUPpbvgZoHWPEa(applicationModeType, "applicationModeType");
        PvlzsjHABiTevBSM(this.fc76f72a4, applicationModeType);
    }
}

