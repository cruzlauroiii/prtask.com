namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0000\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\b\u0010\u0006\u001a\u00020\u0007H\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\b"}, d2 = {"Lpad5f82e8/pac143fb7/p4717d53e/p13c07d6f;", "Lpad5f82e8/pac143fb7/p4717d53e/p76c4f3d2;", "connectionRepository", "Lp8d777f38/pb3f20355/pcf1e8c14/p69ce353b;", "<init>", "(Lp8d777f38/pb3f20355/pcf1e8c14/p69ce353b;)V", "hasInternetConnection", "", "common-domain-usecase_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p13c07d6f : pad5f82e8.pac143fb7.p4717d53e.p76c4f3d2 {
    private readonly p8d777f38.pb3f20355.pcf1e8c14.p69ce353b f22711eba;
    private readonly p8d777f38.pb3f20355.pcf1e8c14.p69ce353b f2998e55e;
    private readonly p8d777f38.pb3f20355.pcf1e8c14.p69ce353b f3b1560d5;
    private readonly p8d777f38.pb3f20355.pcf1e8c14.p69ce353b f50f84630;
    private readonly p8d777f38.pb3f20355.pcf1e8c14.p69ce353b f76f6a801;

    public p13c07d6f(p8d777f38.pb3f20355.pcf1e8c14.p69ce353b p69ce353bVar) {
        QuPbzIqamwrHLGvA(p69ce353bVar, "connectionRepository");
        this.f2998e55e = p69ce353bVar;
    }

    public static bool OhUnlaFAmPdcmumK(p8d777f38.pb3f20355.pcf1e8c14.p69ce353b p69ce353bVar) {
        return p69ce353bVar.hasInternetConnection();
    }

    public static void QuPbzIqamwrHLGvA(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public override bool HasInternetConnection() {
        return OhUnlaFAmPdcmumK(this.f2998e55e);
    }
}

