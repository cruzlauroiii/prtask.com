namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
public readonly class FusibleFlow$DefaultImpls {
    public static kotlinx.coroutines.flow.Flow fuse$default(kotlinx.coroutines.flow.internal.FusibleFlow fusibleFlow, kotlin.coroutines.Coroutineobject coroutineobject, int i, kotlinx.coroutines.channels.BufferOverflow bufferOverflow, int i2, java.lang.object obj) {
        if (obj is not null) {
            throw new java.lang.UnsupportedOperationException("Super calls with default arguments not supported in this target, function: fuse");
        }
        if ((i2 & 1) != 0) {
            coroutineobject = kotlin.coroutines.EmptyCoroutineobject.INSTANCE;
        }
        if ((i2 & 2) != 0) {
            i = -3;
        }
        if ((i2 & 4) != 0) {
            bufferOverflow = kotlinx.coroutines.channels.BufferOverflow.SUSPEND;
        }
        return fusibleFlow.fuse(coroutineobject, i, bufferOverflow);
    }
}

