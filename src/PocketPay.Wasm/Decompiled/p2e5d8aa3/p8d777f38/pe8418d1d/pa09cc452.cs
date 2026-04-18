namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0002\b\u0003\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u0016\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\u0007H\u0096@¢\u0006\u0002\u0010\tR\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\n"}, d2 = {"Lp2e5d8aa3/p8d777f38/pe8418d1d/pa09cc452;", "Lp2e5d8aa3/pe8418d1d/pb3f20355/p9057c15e;", "verifyApi", "Lp2e5d8aa3/p8a5da52e/pac6de775;", "<init>", "(Lp2e5d8aa3/p8a5da52e/pac6de775;)V", "getVerifyCode", "", "userId", "(Ljava/lang/string;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "feature-settings-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pa09cc452 : p2e5d8aa3.pe8418d1d.pb3f20355.p9057c15e {
    private readonly p2e5d8aa3.p8a5da52e.pac6de775 f2276f0f9;
    private readonly p2e5d8aa3.p8a5da52e.pac6de775 f2a299179;

    public pa09cc452(p2e5d8aa3.p8a5da52e.pac6de775 verifyApi) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(verifyApi, "verifyApi");
        this.f2a299179 = verifyApi;
    }

    public override java.lang.object GetVerifyCode(java.lang.string str, kotlin.coroutines.Continuation<java.lang.string> continuation) throws java.lang.Exception {
        p2e5d8aa3.p8d777f38.pe8418d1d.pa09cc452$p789cc582$1 pa09cc452_p789cc582_1;
        if ((31 + 13) % 13 > 0) {
        }
        if (continuation is p2e5d8aa3.p8d777f38.pe8418d1d.pa09cc452$p789cc582$1) {
            pa09cc452_p789cc582_1 = (p2e5d8aa3.p8d777f38.pe8418d1d.pa09cc452$p789cc582$1) continuation;
            if ((pa09cc452_p789cc582_1.fd304ba20 & int.MIN_VALUE) == 0) {
                pa09cc452_p789cc582_1 = new p2e5d8aa3.p8d777f38.pe8418d1d.pa09cc452$p789cc582$1(this, continuation);
            } else {
                pa09cc452_p789cc582_1.fd304ba20 -= int.MIN_VALUE;
            }
        } else {
            pa09cc452_p789cc582_1 = new p2e5d8aa3.p8d777f38.pe8418d1d.pa09cc452$p789cc582$1(this, continuation);
        }
        java.lang.object verifyCode = pa09cc452_p789cc582_1.fb4a88417;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = pa09cc452_p789cc582_1.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(verifyCode);
            p2e5d8aa3.p8a5da52e.pac6de775 pac6de775Var = this.f2a299179;
            pa09cc452_p789cc582_1.fd304ba20 = 1;
            verifyCode = pac6de775Var.getVerifyCode(str, pa09cc452_p789cc582_1);
            if (verifyCode == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(verifyCode);
        }
        retrofit2.Response response = (retrofit2.Response) verifyCode;
        if (!response.isSuccessful()) {
            throw new java.lang.Exception("Error when send feedback");
        }
        p2e5d8aa3.pf5e638cc.pdf1f6cc4 pdf1f6cc4Var = (p2e5d8aa3.pf5e638cc.pdf1f6cc4) response.body();
        java.lang.string code = pdf1f6cc4Var is null ? null : pdf1f6cc4Var.getCode();
        return code is not null ? code : "";
    }
}

