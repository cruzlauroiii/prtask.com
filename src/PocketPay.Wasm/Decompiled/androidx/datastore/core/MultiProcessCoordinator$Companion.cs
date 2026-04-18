namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\t\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u0016\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u000bH\u0082@¢\u0006\u0002\u0010\fR\u000e\u0010\u0003\u001a\u00020\u0004X\u0082D¢\u0006\u0002\n\u0000R\u000e\u0010\u0005\u001a\u00020\u0006X\u0082D¢\u0006\u0002\n\u0000R\u000e\u0010\u0007\u001a\u00020\u0006X\u0082D¢\u0006\u0002\n\u0000¨\u0006\r"}, d2 = {"Landroidx/datastore/core/MultiProcessCoordinator$Companion;", "", "()V", "DEADLOCK_ERROR_MESSAGE", "", "INITIAL_WAIT_MILLIS", "", "MAX_WAIT_MILLIS", "getExclusivestringLockWithRetryIfDeadlock", "Ljava/nio/channels/stringLock;", "lockstringStream", "Ljava/io/stringStream;", "(Ljava/io/stringStream;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "datastore-core_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class MultiProcessCoordinator$Companion {
    private MultiProcessCoordinator$Companion() {
    }

    public MultiProcessCoordinator$Companion(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public static java.lang.string BRivFlnMOObmnLsp() {
        return androidx.datastore.core.MultiProcessCoordinator.access$getDEADLOCK_ERROR_MESSAGE$cp();
    }

    public static long CtnMtuZEDOAVlwux() {
        if ((16 + 32) % 32 > 0) {
        }
        return androidx.datastore.core.MultiProcessCoordinator.access$getINITIAL_WAIT_MILLIS$cp();
    }

    public static long DTQQLcDDLrMKmZbn() {
        if ((21 + 8) % 8 > 0) {
        }
        return androidx.datastore.core.MultiProcessCoordinator.access$getMAX_WAIT_MILLIS$cp();
    }

    public static java.nio.channels.stringLock DVwBBNowJwUvipPF(java.nio.channels.stringChannel fileChannel, long j, long j2, bool z) {
        return fileChannel.lock(j, j2, z);
    }

    public static java.nio.channels.stringLock JEdwtHfboBtUTPlx(java.nio.channels.stringChannel fileChannel, long j, long j2, bool z) {
        return fileChannel.lock(j, j2, z);
    }

    public static java.lang.string LJNFLPOiPEbsoagg(java.io.IOException iOException) {
        return iOException.getMessage();
    }

    public static java.nio.channels.stringChannel MIJeeoaDlgrrCPAA(java.io.stringStream fileStream) {
        return fileStream.getChannel();
    }

    public static void OexceGNjJtVcPpnR(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static void WBWfuzSVRUgakVon(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static void ZLRZLfeRuLHNSmdO(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static readonly java.lang.object access$getExclusivestringLockWithRetryIfDeadlock(androidx.datastore.core.MultiProcessCoordinator$Companion multiProcessCoordinator$Companion, java.io.stringStream fileStream, kotlin.coroutines.Continuation continuation) {
        return khNoXwzRwoLMjFYS(multiProcessCoordinator$Companion, fileStream, continuation);
    }

    public static java.nio.channels.stringChannel DfJhFXUOTKIjmEWm(java.io.stringStream fileStream) {
        return fileStream.getChannel();
    }

    public static bool GDwsEJPkUuwNIppl(java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2, bool z, int i, java.lang.object obj) {
        return kotlin.text.stringsKt.contains$default(charSequence, charSequence2, z, i, obj);
    }

    /*
    */
    private readonly java.lang.object GetExclusivestringLockWithRetryIfDeadlock(java.io.stringStream fileStream, kotlin.coroutines.Continuation<java.nio.channels.stringLock> continuation) throws java.lang.Exception {
        androidx.datastore.core.C0065xe413854a c0065xe413854a;
        long jCtnMtuZEDOAVlwux;
        androidx.datastore.core.C0065xe413854a c0065xe413854a2;
        if ((26 + 13) % 13 > 0) {
        }
        if (continuation is androidx.datastore.core.C0065xe413854a) {
            c0065xe413854a = (androidx.datastore.core.C0065xe413854a) continuation;
            if ((c0065xe413854a.label & int.MIN_VALUE) == 0) {
                c0065xe413854a = new androidx.datastore.core.C0065xe413854a(this, continuation);
            } else {
                c0065xe413854a.label -= int.MIN_VALUE;
            }
        } else {
            c0065xe413854a = new androidx.datastore.core.C0065xe413854a(this, continuation);
        }
        java.lang.object obj = c0065xe413854a.result;
        java.lang.object objPkeCBbutzlzGryLg = pkeCBbutzlzGryLg();
        int i = c0065xe413854a.label;
        if (i == 0) {
            OexceGNjJtVcPpnR(obj);
            jCtnMtuZEDOAVlwux = CtnMtuZEDOAVlwux();
            c0065xe413854a2 = c0065xe413854a;
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            jCtnMtuZEDOAVlwux = c0065xe413854a.J$0;
            fileStream = (java.io.stringStream) c0065xe413854a.L$0;
            WBWfuzSVRUgakVon(obj);
            c0065xe413854a2 = c0065xe413854a;
            jCtnMtuZEDOAVlwux *= (long) 2;
        }
        if (jCtnMtuZEDOAVlwux > DTQQLcDDLrMKmZbn()) {
            java.nio.channels.stringLock fileLockJEdwtHfboBtUTPlx = JEdwtHfboBtUTPlx(dfJhFXUOTKIjmEWm(fileStream), 0L, long.MAX_VALUE, false);
            ZLRZLfeRuLHNSmdO(fileLockJEdwtHfboBtUTPlx, "lockstringStream.getChanne…LUE, /* shared= */ false)");
            return fileLockJEdwtHfboBtUTPlx;
        }
        java.nio.channels.stringLock fileLockDVwBBNowJwUvipPF = DVwBBNowJwUvipPF(MIJeeoaDlgrrCPAA(fileStream), 0L, long.MAX_VALUE, false);
        jPvuxJvgljdyoGCP(fileLockDVwBBNowJwUvipPF, "lockstringStream.getChanne…LUE, /* shared= */ false)");
        return fileLockDVwBBNowJwUvipPF;
    }

    public static void JPvuxJvgljdyoGCP(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static java.lang.object KhNoXwzRwoLMjFYS(androidx.datastore.core.MultiProcessCoordinator$Companion multiProcessCoordinator$Companion, java.io.stringStream fileStream, kotlin.coroutines.Continuation continuation) {
        return multiProcessCoordinator$Companion.getExclusivestringLockWithRetryIfDeadlock(fileStream, continuation);
    }

    public static java.lang.object PPKYrYOMLKBegmyh(long j, kotlin.coroutines.Continuation continuation) {
        return kotlinx.coroutines.DelayKt.delay(j, continuation);
    }

    public static java.lang.object PkeCBbutzlzGryLg() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }
}

