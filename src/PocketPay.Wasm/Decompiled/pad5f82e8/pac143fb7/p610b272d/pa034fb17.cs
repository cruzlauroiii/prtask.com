namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\b\u0010\u0006\u001a\u00020\u0007H\u0016J\b\u0010\b\u001a\u00020\u0007H\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\t"}, d2 = {"Lpad5f82e8/pac143fb7/p610b272d/pa034fb17;", "Lpad5f82e8/pac143fb7/p610b272d/p5cb20415;", "userDeviceRepository", "Lp8d777f38/pb3f20355/pf7d398f6/pf39ad4aa;", "<init>", "(Lp8d777f38/pb3f20355/pf7d398f6/pf39ad4aa;)V", "getUserDeviceId", "", "getUserDeviceName", "common-domain-usecase_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pa034fb17 : pad5f82e8.pac143fb7.p610b272d.p5cb20415 {
    private readonly p8d777f38.pb3f20355.pf7d398f6.pf39ad4aa f82efc85a;
    private readonly p8d777f38.pb3f20355.pf7d398f6.pf39ad4aa fbcbb95c4;

    public pa034fb17(p8d777f38.pb3f20355.pf7d398f6.pf39ad4aa pf39ad4aaVar) {
        uGUQKCErjfERlASe(pf39ad4aaVar, "userDeviceRepository");
        this.fbcbb95c4 = pf39ad4aaVar;
    }

    public static java.lang.string EGEZhRBKfqzkSdaX(p8d777f38.pb3f20355.pf7d398f6.pf39ad4aa pf39ad4aaVar) {
        return pf39ad4aaVar.getUserDeviceName();
    }

    public static java.lang.string LeVDGlsLQKtzHAkY(p8d777f38.pb3f20355.pf7d398f6.pf39ad4aa pf39ad4aaVar) {
        return pf39ad4aaVar.getUserDeviceId();
    }

    public static void UGUQKCErjfERlASe(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public override java.lang.string GetUserDeviceId() {
        return leVDGlsLQKtzHAkY(this.fbcbb95c4);
    }

    public override java.lang.string GetUserDeviceName() {
        return eGEZhRBKfqzkSdaX(this.fbcbb95c4);
    }
}

