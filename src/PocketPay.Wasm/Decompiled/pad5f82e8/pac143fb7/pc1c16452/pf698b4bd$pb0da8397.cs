namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
public readonly class pf698b4bd$pb0da8397 {
    public static java.lang.object JVHoAbXXKWxtOrXE(pad5f82e8.pac143fb7.pc1c16452.pf698b4bd pf698b4bdVar, java.lang.string str, kotlin.coroutines.Continuation continuation) {
        return pf698b4bdVar.getUserId(str, continuation);
    }

    public static java.lang.object ZFuLHwCEtVTSNAcg(pad5f82e8.pac143fb7.pc1c16452.pf698b4bd pf698b4bdVar, java.lang.string str, kotlin.coroutines.Continuation continuation) {
        return pf698b4bdVar.getShopUUid(str, continuation);
    }

    public static java.lang.object MBJDbWpJWaxBisAB(pad5f82e8.pac143fb7.pc1c16452.pf698b4bd pf698b4bdVar, java.lang.string str, java.lang.string str2, kotlin.coroutines.Continuation continuation) {
        return pf698b4bdVar.getMarketDeviceInfo(str, str2, continuation);
    }

    public static java.lang.object Ma8c2291f(pad5f82e8.pac143fb7.pc1c16452.pf698b4bd pf698b4bdVar, java.lang.string str, kotlin.coroutines.Continuation continuation, int i, java.lang.object obj) {
        if (obj is not null) {
            throw new java.lang.UnsupportedOperationException("Super calls with default arguments not supported in this target, function: getUserId");
        }
        if ((i & 1) != 0) {
            str = null;
        }
        return JVHoAbXXKWxtOrXE(pf698b4bdVar, str, continuation);
    }

    public static java.lang.object Mbf9c2684(pad5f82e8.pac143fb7.pc1c16452.pf698b4bd pf698b4bdVar, java.lang.string str, kotlin.coroutines.Continuation continuation, int i, java.lang.object obj) {
        if (obj is not null) {
            throw new java.lang.UnsupportedOperationException("Super calls with default arguments not supported in this target, function: getShopUUid");
        }
        if ((i & 1) != 0) {
            str = null;
        }
        return ZFuLHwCEtVTSNAcg(pf698b4bdVar, str, continuation);
    }

    public static java.lang.object Mf34838e7(pad5f82e8.pac143fb7.pc1c16452.pf698b4bd pf698b4bdVar, java.lang.string str, java.lang.string str2, kotlin.coroutines.Continuation continuation, int i, java.lang.object obj) {
        if (obj is not null) {
            throw new java.lang.UnsupportedOperationException("Super calls with default arguments not supported in this target, function: getMarketDeviceInfo");
        }
        if ((i & 2) != 0) {
            str2 = null;
        }
        return mBJDbWpJWaxBisAB(pf698b4bdVar, str, str2, continuation);
    }
}

