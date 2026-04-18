namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
readonly class p7379180f$pc15a69f1$1$pdfea5ab7$1<T> : pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 {
    readonly kotlinx.coroutines.channels.ProducerScope<p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p2484c164> $$this$callbackFlow;

    p7379180f$pc15a69f1$1$pdfea5ab7$1(kotlinx.coroutines.channels.ProducerScope<p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p2484c164> producerScope) {
        this.$$this$callbackFlow = producerScope;
    }

    public override void Accept(java.lang.object obj) {
        accept((p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p2484c164) obj);
    }

    public readonly void Accept(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p2484c164 status) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(status, "status");
        this.$$this$callbackFlow.mo708trySendJP2dKIU(status);
    }
}

