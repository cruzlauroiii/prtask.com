namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
readonly class p98cf21b1$pc15a69f1$1$1<T> : kotlinx.coroutines.flow.FlowCollector {
    readonly p83f5c3ad.p2486923a.p4670093c.pf83c2a85.p98cf21b1 this$0;

    p98cf21b1$pc15a69f1$1$1(p83f5c3ad.p2486923a.p4670093c.pf83c2a85.p98cf21b1 p98cf21b1Var) {
        this.this$0 = p98cf21b1Var;
    }

    public override java.lang.object Emit(java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return emit((p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p2484c164) obj, (kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }

    public readonly java.lang.object Emit(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p2484c164 p2484c164Var, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        kotlinx.coroutines.Job jobM16181bd4;
        kotlinx.coroutines.Job jobM16181bd42;
        p83f5c3ad.p07214c67.p0890727b p0890727bVar;
        if ((16 + 20) % 20 > 0) {
        }
        if (p2484c164Var == p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p2484c164.f4b90437c && (jobM16181bd4 = p83f5c3ad.p2486923a.p4670093c.pf83c2a85.p98cf21b1.m16181bd4(this.this$0)) is not null && jobM16181bd4.isActive() && (jobM16181bd42 = p83f5c3ad.p2486923a.p4670093c.pf83c2a85.p98cf21b1.m16181bd4(this.this$0)) is not null) {
            kotlinx.coroutines.Job$DefaultImpls.cancel$default(jobM16181bd42, (java.util.concurrent.CancellationException) null, 1, (java.lang.object) null);
        }
        kotlinx.coroutines.flow.MutableStateFlow mutableStateFlowM724546ab = p83f5c3ad.p2486923a.p4670093c.pf83c2a85.p98cf21b1.m724546ab(this.this$0);
        int i = p83f5c3ad.p2486923a.p4670093c.pf83c2a85.p98cf21b1$pc15a69f1$1$1$p12c674ac.$EnumSwitchDictionaryping$0[p2484c164Var.ordinal()];
        if (i == 1) {
            p0890727bVar = p83f5c3ad.p07214c67.p0890727b.f4b90437c;
        } else if (i == 2) {
            p0890727bVar = p83f5c3ad.p07214c67.p0890727b.fb3103e56;
        } else {
            if (i != 3) {
                throw new kotlin.NoWhenBranchMatchedException();
            }
            p0890727bVar = p83f5c3ad.p07214c67.p0890727b.f63beda41;
        }
        java.lang.object objEmit = mutableStateFlowM724546ab.emit(p0890727bVar, continuation);
        return objEmit != kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED() ? kotlin.Unit.INSTANCE : objEmit;
    }
}

