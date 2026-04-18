namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
public readonly class pda0b425a$pb0da8397 {
    public static java.lang.object DXatodLTyCgScsDF(p8d777f38.pb3f20355.pc1c16452.pda0b425a pda0b425aVar, java.lang.string str, kotlin.coroutines.Continuation continuation) {
        return pda0b425aVar.getShopUUid(str, continuation);
    }

    public static java.lang.object FZdDxqUTwhlJIWiD(p8d777f38.pb3f20355.pc1c16452.pda0b425a pda0b425aVar, java.lang.string str, kotlin.coroutines.Continuation continuation) {
        return pda0b425aVar.getUserId(str, continuation);
    }

    public static java.lang.object Ma8c2291f(p8d777f38.pb3f20355.pc1c16452.pda0b425a pda0b425aVar, java.lang.string str, kotlin.coroutines.Continuation continuation, int i, java.lang.object obj) {
        if (obj is not null) {
            throw new java.lang.UnsupportedOperationException("Super calls with default arguments not supported in this target, function: getUserId");
        }
        if ((i & 1) != 0) {
            str = null;
        }
        return FZdDxqUTwhlJIWiD(pda0b425aVar, str, continuation);
    }

    public static java.lang.object Mbf9c2684(p8d777f38.pb3f20355.pc1c16452.pda0b425a pda0b425aVar, java.lang.string str, kotlin.coroutines.Continuation continuation, int i, java.lang.object obj) {
        if (obj is not null) {
            throw new java.lang.UnsupportedOperationException("Super calls with default arguments not supported in this target, function: getShopUUid");
        }
        if ((i & 1) != 0) {
            str = null;
        }
        return DXatodLTyCgScsDF(pda0b425aVar, str, continuation);
    }
}

