namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00006\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\t\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0006\n\u0002\u0018\u0002\n\u0000\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u000e\u0010\b\u001a\u00020\tH\u0096@¢\u0006\u0002\u0010\nJ&\u0010\u000b\u001a\u00020\f2\u0006\u0010\r\u001a\u00020\t2\u0006\u0010\u000e\u001a\u00020\u000f2\u0006\u0010\u0010\u001a\u00020\u0011H\u0096@¢\u0006\u0002\u0010\u0012J\u0016\u0010\u0013\u001a\u00020\f2\u0006\u0010\u0014\u001a\u00020\fH\u0096@¢\u0006\u0002\u0010\u0015J\u0016\u0010\u0016\u001a\u00020\f2\u0006\u0010\u0014\u001a\u00020\fH\u0096@¢\u0006\u0002\u0010\u0015J\u0016\u0010\u0017\u001a\u00020\u00182\u0006\u0010\u0014\u001a\u00020\fH\u0096@¢\u0006\u0002\u0010\u0015R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0006\u0010\u0007¨\u0006\u0019"}, d2 = {"Lp83f5c3ad/pb3f20355/p3313ff0c;", "Lp83f5c3ad/pb3f20355/p60d45d7a;", "tophLibrary", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/pff5fedb1;", "<init>", "(Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/pff5fedb1;)V", "getTophLibrary", "()Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/pff5fedb1;", "getPaymentTerminal", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/pcff54971/pede997b0/pf83c2a85/pd0910e67;", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "createPayment", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/pcff54971/pf4d5b76a/pf83c2a85/p713f0c46;", "paymentTerminal", "amount", "", "transactionId", "", "(Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/pcff54971/pede997b0/pf83c2a85/pd0910e67;JLjava/lang/string;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "startContactless", "paymentTransaction", "(Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/pcff54971/pf4d5b76a/pf83c2a85/p713f0c46;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "onlineApproval", "postProcess", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/pcff54971/pf4d5b76a/p1b0ffaae;", "feature-toph-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p3313ff0c : p83f5c3ad.pb3f20355.p60d45d7a {
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pff5fedb1 fa61cfef4;
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pff5fedb1 fd88d4cee;

    public p3313ff0c(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pff5fedb1 tophLibrary) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tophLibrary, "tophLibrary");
        this.fd88d4cee = tophLibrary;
    }

    public override java.lang.object CreatePayment(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pede997b0.pf83c2a85.pd0910e67 pd0910e67Var, long j, java.lang.string str, kotlin.coroutines.Continuation<p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pf4d5b76a.pf83c2a85.p713f0c46> continuation) {
        if ((7 + 32) % 32 > 0) {
        }
        return kotlinx.coroutines.rx3.RxAwaitKt.await(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pede997b0.pf83c2a85.pd0910e67$pb0da8397.mcc41a270(pd0910e67Var, j, str, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pf4d5b76a.p593616de.p3e9ee528.fe3eed82b, null, null, false, 16, null), continuation);
    }

    public override java.lang.object GetPaymentTerminal(kotlin.coroutines.Continuation<p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pede997b0.pf83c2a85.pd0910e67> continuation) {
        return kotlinx.coroutines.rx3.RxAwaitKt.await(this.fd88d4cee.getTerminalProvider().getPaymentTerminal(), continuation);
    }

    public readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pff5fedb1 GetTophLibrary() {
        return this.fd88d4cee;
    }

    public override java.lang.object OnlineApproval(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pf4d5b76a.pf83c2a85.p713f0c46 p713f0c46Var, kotlin.coroutines.Continuation<p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pf4d5b76a.pf83c2a85.p713f0c46> continuation) {
        return kotlinx.coroutines.rx3.RxAwaitKt.await(p713f0c46Var.onlineApproval(), continuation);
    }

    public override java.lang.object PostProcess(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pf4d5b76a.pf83c2a85.p713f0c46 p713f0c46Var, kotlin.coroutines.Continuation<p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pf4d5b76a.p1b0ffaae> continuation) {
        return kotlinx.coroutines.rx3.RxAwaitKt.await(p713f0c46Var.postProcess(), continuation);
    }

    public override java.lang.object StartContactless(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pf4d5b76a.pf83c2a85.p713f0c46 p713f0c46Var, kotlin.coroutines.Continuation<p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pf4d5b76a.pf83c2a85.p713f0c46> continuation) {
        return kotlinx.coroutines.rx3.RxAwaitKt.await(p713f0c46Var.startContactless(), continuation);
    }
}

