namespace WillowMaze.Wasm.Decompiled;

public class P2d68e184_p28bdc648 : P1b0ecc4e$p0bb4c52b, Func<object>
{
    private readonly p1b0ecc4e F1de9b0a3;
    private readonly p1b0ecc4e Fcef6ee33;
    private readonly p2d68e184 This$0;

    public void AckSettings()
    {
    }

    public void AlternateService(int P0, string P1, p58efa9e8 P2, string P3, int P4, long P5)
    {
        // str: "host"
        // str: "protocol"
        // str: "origin"
        // call: Intrinsics.checkNotNullParameter
    }

    public void ApplyAndAckSettings(bool P0, pf4f70727 P1)
    {
        // str: "settings"
        // str: "null cannot be cast to non-null type kotlin.Array<T of kotlin.collections.ArraysKt__ArraysJVMKt.t..."
        // str: " onSettings"
        // call: Intrinsics.checkNotNullParameter
        // call: p87a6e6e6.addBytesToWriteWindow
        // call: p2d68e184.getWriter
        // call: Ref$ObjectRef.<init>
        // call: p2d68e184.getPeerSettings
        // call: pf4f70727.<init>
        // call: pf4f70727.merge
        // call: pf4f70727.getInitialWindowSize
        // call: p2d68e184.getStreams$okhttp
        // call: Dictionary<string, object>.isEmpty
        // call: Dictionary<string, object>.values
        // call: ICollection<object>.toArray
        // call: NullPointerException.<init>
        // call: p2d68e184.setPeerSettings
        // call: p2d68e184.access$getSettingsListenerQueue$p
        // call: p2d68e184.getConnectionName$okhttp
        // call: Intrinsics.stringPlus
        // call: p2d68e184$p28bdc648$p5a6ca965$p1938d6cb$p0f68d17a$pd41d8cd9$pec404527$pec0cd3cb$pc21f969b$1.<init>
        // call: p6d96efb7.schedule
        // call: pbf98b58a.applyAndAckSettings
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184$p28bdc648.this$0
        // field: kotlin.Unit.INSTANCE
        // field: kotlin.jvm.internal.Ref$ObjectRef.element
        // type: Ref$ObjectRef
        // type: pf4f70727
        // type: NullPointerException
        // type: p2d68e184$p28bdc648$p5a6ca965$p1938d6cb$p0f68d17a$pd41d8cd9$pec404527$pec0cd3cb$pc21f969b$1
    }

    public void Data(bool P0, int P1, pcc81e3f6 P2, int P3)
    {
        // str: "source"
        // call: p2d68e184.getStream
        // call: p87a6e6e6.receiveData
        // call: p2d68e184.pushDataLater$okhttp
        // call: p2d68e184.updateConnectionFlowControl$okhttp
        // call: pcc81e3f6.skip
        // call: p87a6e6e6.receiveHeaders
        // call: Intrinsics.checkNotNullParameter
        // call: p2d68e184.writeSynResetLater$okhttp
        // call: p2d68e184.pushedStream$okhttp
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38.f23f149f0
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184$p28bdc648.this$0
        // field: p7ddcfee1.pd1efad72.p23e8a4b4.f12ea5829
    }

    public p1b0ecc4e GetReader$okhttp()
    {
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184$p28bdc648.f1de9b0a3
        return default!;
    }

    public void GoAway(int P0, p9bc96b38 P1, p58efa9e8 P2)
    {
        // str: "debugData"
        // str: "null cannot be cast to non-null type kotlin.Array<T of kotlin.collections.ArraysKt__ArraysJVMKt.t..."
        // str: "errorCode"
        // call: p87a6e6e6.receiveRstStream
        // call: p87a6e6e6.getId
        // call: Intrinsics.checkNotNullParameter
        // call: NullPointerException.<init>
        // call: p58efa9e8.size
        // call: p2d68e184.removeStream$okhttp
        // call: p87a6e6e6.isLocallyInitiated
        // call: p2d68e184.getStreams$okhttp
        // call: Dictionary<string, object>.values
        // call: ICollection<object>.toArray
        // call: p2d68e184.access$setShutdown$p
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38.f3e2449dc
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184$p28bdc648.this$0
        // field: kotlin.Unit.INSTANCE
        // type: NullPointerException
    }

    public void Headers(bool P0, int P1, int P2, List<object> P3)
    {
        // str: "] onStream"
        // str: "headerBlock"
        // call: p2d68e184.getLastGoodStreamId$okhttp
        // call: Intrinsics.checkNotNullParameter
        // call: p2d68e184.getStream
        // call: p2d68e184.access$isShutdown$p
        // call: p23e8a4b4.toHeaders
        // call: p87a6e6e6.<init>
        // call: p2d68e184.setLastGoodStreamId$okhttp
        // call: p2d68e184.getStreams$okhttp
        // call: int.valueOf
        // call: Dictionary<string, object>.put
        // call: p2d68e184.access$getTaskRunner$p
        // call: pf9f34f60.newQueue
        // call: StringBuilder.<init>
        // call: p2d68e184.getConnectionName$okhttp
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: p2d68e184$p28bdc648$p4340fd73$p67f7b4e7$pd41d8cd9$pec404527$pec0cd3cb$pc21f969b$1.<init>
        // call: p6d96efb7.schedule
        // call: p2d68e184.pushedStream$okhttp
        // call: p2d68e184.getNextStreamId$okhttp
        // field: kotlin.Unit.INSTANCE
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184$p28bdc648.this$0
        // type: p87a6e6e6
        // type: StringBuilder
        // type: p2d68e184$p28bdc648$p4340fd73$p67f7b4e7$pd41d8cd9$pec404527$pec0cd3cb$pc21f969b$1
    }

    public object Invoke()
    {
        // call: p2d68e184$p28bdc648.invoke
        // field: kotlin.Unit.INSTANCE
        return default!;
    }

    public void Invoke()
    {
        // call: p23e8a4b4.closeQuietly
        // call: p2d68e184.close$okhttp
        // call: p1b0ecc4e.readConnectionPreface
        // call: p1b0ecc4e.nextFrame
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38.f23f149f0
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184$p28bdc648.this$0
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184$p28bdc648.f1de9b0a3
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38.fe8c0c708
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38.fd306b6fd
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38.f2027c027
    }

    public void Ping(bool P0, int P1, int P2)
    {
        // str: " ping"
        // call: Intrinsics.stringPlus
        // call: p2d68e184.access$getWriterQueue$p
        // call: p2d68e184.access$getAwaitPongsReceived$p
        // call: p2d68e184.access$setAwaitPongsReceived$p
        // call: object.notifyAll
        // call: p2d68e184.access$getDegradedPongsReceived$p
        // call: p2d68e184.access$setDegradedPongsReceived$p
        // call: long.valueOf
        // call: p2d68e184.access$getIntervalPongsReceived$p
        // call: p2d68e184.access$setIntervalPongsReceived$p
        // call: p2d68e184.getConnectionName$okhttp
        // call: p2d68e184$p28bdc648$pdf911f01$pd41d8cd9$pec404527$pec0cd3cb$pc21f969b$1.<init>
        // call: p6d96efb7.schedule
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184$p28bdc648.this$0
        // field: kotlin.Unit.INSTANCE
        // type: p2d68e184$p28bdc648$pdf911f01$pd41d8cd9$pec404527$pec0cd3cb$pc21f969b$1
    }

    public void Priority(int P0, int P1, int P2, bool P3)
    {
    }

    public void PushPromise(int P0, int P1, List<object> P2)
    {
        // str: "requestHeaders"
        // call: p2d68e184.pushRequestLater$okhttp
        // call: Intrinsics.checkNotNullParameter
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184$p28bdc648.this$0
    }

    public void RstStream(int P0, p9bc96b38 P1)
    {
        // str: "errorCode"
        // call: Intrinsics.checkNotNullParameter
        // call: p2d68e184.pushedStream$okhttp
        // call: p87a6e6e6.receiveRstStream
        // call: p2d68e184.removeStream$okhttp
        // call: p2d68e184.pushResetLater$okhttp
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184$p28bdc648.this$0
    }

    public void Settings(bool P0, pf4f70727 P1)
    {
        // str: "settings"
        // str: " applyAndAckSettings"
        // call: Intrinsics.stringPlus
        // call: p2d68e184$p28bdc648$p2e5d8aa3$pd41d8cd9$pec404527$pec0cd3cb$pc21f969b$1.<init>
        // call: p2d68e184.access$getWriterQueue$p
        // call: Intrinsics.checkNotNullParameter
        // call: p6d96efb7.schedule
        // call: p2d68e184.getConnectionName$okhttp
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184$p28bdc648.this$0
        // type: p2d68e184$p28bdc648$p2e5d8aa3$pd41d8cd9$pec404527$pec0cd3cb$pc21f969b$1
    }

    public void WindowUpdate(int P0, long P1)
    {
        // call: p2d68e184.getWriteBytesMaximum
        // call: p2d68e184.access$setWriteBytesMaximum$p
        // call: object.notifyAll
        // call: p87a6e6e6.addBytesToWriteWindow
        // call: p2d68e184.getStream
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184$p28bdc648.this$0
        // field: kotlin.Unit.INSTANCE
    }

}
