namespace WillowMaze.Wasm.Decompiled;

public class P3ee6e472_pb640a0ce_1 : P406c70d6
{
    private readonly p15c2d85f $request;
    private readonly p3ee6e472 This$0;

    public void OnFailure(pc3755e61 P0, IOException P1)
    {
        // str: "e"
        // str: "call"
        // call: p3ee6e472.failWebSocket
        // call: Intrinsics.checkNotNullParameter
        // field: p7ddcfee1.pd1efad72.p742523da.p3ee6e472$pb640a0ce$1.this$0
    }

    public void OnResponse(pc3755e61 P0, pd64ed3e9 P1)
    {
        // str: "call"
        // str: "unexpected Sec-WebSocket-Extensions in response header"
        // str: "response"
        // str: " WebSocket "
        // call: p992374d8.webSocketUpgradeFailed
        // call: p3ee6e472.failWebSocket
        // call: Intrinsics.checkNotNullParameter
        // call: pd64ed3e9.headers
        // call: p3ee6e472.access$isValid
        // call: pd64ed3e9.exchange
        // call: p3ee6e472.checkUpgradeSuccess$okhttp
        // call: Intrinsics.checkNotNull
        // call: p992374d8.newWebSocketStreams
        // call: p3ee6e472.access$setExtensions$p
        // call: p23e8a4b4.closeQuietly
        // call: p3ee6e472.access$getMessageAndCloseQueue$p
        // call: Queue<object>.clear
        // call: p3ee6e472.close
        // call: p495b756f$p910eef8c.parse
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // call: p15c2d85f.url
        // call: pdfadebdd.redact
        // call: StringBuilder.toString
        // field: p7ddcfee1.pd1efad72.p742523da.p3ee6e472$pb640a0ce$1.this$0
        // field: p7ddcfee1.pd1efad72.p742523da.p495b756f.f910eef8c
        // field: p7ddcfee1.pd1efad72.p23e8a4b4.ffcd12e30
        // field: p7ddcfee1.pd1efad72.p742523da.p3ee6e472$pb640a0ce$1.$request
        // type: StringBuilder
    }

}
