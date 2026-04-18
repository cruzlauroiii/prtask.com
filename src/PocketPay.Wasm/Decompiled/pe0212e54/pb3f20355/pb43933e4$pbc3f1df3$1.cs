namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "pe0212e54.pb3f20355.pb43933e4", m533f = "DevicesRepositoryImpl.kt", m534i = {0, 0, 0, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2}, m535l = {112, 117, 121, 145}, m536m = "updateRemoteDevices", m537n = {"this", "shops", "devices", "this", "shops", "devices", "selectedDevice", "this", "shops", "selectedDevice", "paymentHashSettingsDictionary", "updatedDevices", "device"}, m538s = {"L$0", "L$1", "L$2", "L$0", "L$1", "L$2", "L$3", "L$0", "L$1", "L$2", "L$3", "L$4", "L$6"})
readonly class pb43933e4$pbc3f1df3$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    java.lang.object L$3;
    java.lang.object L$4;
    java.lang.object L$5;
    java.lang.object L$6;
    int f580bba8e;
    int f685be528;
    java.lang.object f80e13ba1;
    java.lang.object fb4a88417;
    int fd304ba20;
    readonly pe0212e54.pb3f20355.pb43933e4 this$0;

    pb43933e4$pbc3f1df3$1(pe0212e54.pb3f20355.pb43933e4 pb43933e4Var, kotlin.coroutines.Continuation<? super pe0212e54.pb3f20355.pb43933e4$pbc3f1df3$1> continuation) {
        super(continuation);
        this.this$0 = pb43933e4Var;
    }

    public static java.lang.object LNVDupNsrOaxvbgl(pe0212e54.pb3f20355.pb43933e4 pb43933e4Var, java.util.List list, java.util.List list2, kotlin.coroutines.Continuation continuation) {
        return pe0212e54.pb3f20355.pb43933e4.mcc980c15(pb43933e4Var, list, list2, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return LNVDupNsrOaxvbgl(this.this$0, null, null, this);
    }
}

