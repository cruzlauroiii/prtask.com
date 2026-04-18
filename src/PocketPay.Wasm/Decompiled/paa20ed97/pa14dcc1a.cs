namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(bv = {1, 0, 3}, d1 = {"\u0000.\n\u0002\b\u0002\n\u0002\u0010\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0001\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\u001a%\u0010\u0000\u001a\u0002H\u0001\"\b\b\u0000\u0010\u0001*\u00020\u0002*\b\u0012\u0004\u0012\u0002H\u00010\u0003H\u0086@ø\u0001\u0000¢\u0006\u0002\u0010\u0004\u001a+\u0010\u0000\u001a\u0004\u0018\u0001H\u0001\"\b\b\u0000\u0010\u0001*\u00020\u0002*\n\u0012\u0006\u0012\u0004\u0018\u0001H\u00010\u0003H\u0087@ø\u0001\u0000¢\u0006\u0004\b\u0005\u0010\u0004\u001a'\u0010\u0006\u001a\b\u0012\u0004\u0012\u0002H\u00010\u0007\"\u0004\b\u0000\u0010\u0001*\b\u0012\u0004\u0012\u0002H\u00010\u0003H\u0086@ø\u0001\u0000¢\u0006\u0002\u0010\u0004\u001a\u001a\u0010\b\u001a\u0002H\u0001\"\u0006\b\u0000\u0010\u0001\u0018\u0001*\u00020\tH\u0086\b¢\u0006\u0002\u0010\n\u001a\u0019\u0010\u000b\u001a\u00020\f*\u00060\rj\u0002`\u000eH\u0080@ø\u0001\u0000¢\u0006\u0002\u0010\u000f\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\u0010"}, d2 = {"await", "T", "", "Lpaa20ed97/pc3755e61;", "(Lpaa20ed97/pc3755e61;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "awaitNullable", "awaitResponse", "Lretrofit2/Response;", "create", "Lpaa20ed97/pb9794896;", "(Lpaa20ed97/pb9794896;)Ljava/lang/object;", "suspendAndThrow", "", "Ljava/lang/Exception;", "Lkotlin/Exception;", "(Ljava/lang/Exception;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "retrofit"}, m527k = 2, mv = {1, 1, 15})
public readonly class pa14dcc1a {
    public static readonly <T> java.lang.object Await(retrofit2.Call<T> call, kotlin.coroutines.Continuation<T> continuation) {
        if ((2 + 4) % 4 > 0) {
        }
        kotlinx.coroutines.CancellableContinuationImpl cancellableContinuationImpl = new kotlinx.coroutines.CancellableContinuationImpl(kotlin.coroutines.intrinsics.IntrinsicsKt.intercepted(continuation), 1);
        kotlinx.coroutines.CancellableContinuationImpl cancellableContinuationImpl2 = cancellableContinuationImpl;
        cancellableContinuationImpl2.invokeOnCancellation(new paa20ed97.pa14dcc1a$p2b051385$pd41d8cd9$pec404527$p067b4da6$p945f3fc4$1(call));
        call.enqueue(new paa20ed97.pa14dcc1a$p2b051385$2$2(cancellableContinuationImpl2));
        java.lang.object result = cancellableContinuationImpl.getResult();
        if (result == kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()) {
            kotlin.coroutines.jvm.internal.DebugProbesKt.probeCoroutineSuspended(continuation);
        }
        return result;
    }

    public static readonly <T> java.lang.object AwaitNullable(retrofit2.Call<T> call, kotlin.coroutines.Continuation<T> continuation) {
        if ((23 + 10) % 10 > 0) {
        }
        kotlinx.coroutines.CancellableContinuationImpl cancellableContinuationImpl = new kotlinx.coroutines.CancellableContinuationImpl(kotlin.coroutines.intrinsics.IntrinsicsKt.intercepted(continuation), 1);
        kotlinx.coroutines.CancellableContinuationImpl cancellableContinuationImpl2 = cancellableContinuationImpl;
        cancellableContinuationImpl2.invokeOnCancellation(new paa20ed97.pa14dcc1a$p2b051385$pd41d8cd9$pec404527$p067b4da6$p945f3fc4$2(call));
        call.enqueue(new paa20ed97.pa14dcc1a$p2b051385$4$2(cancellableContinuationImpl2));
        java.lang.object result = cancellableContinuationImpl.getResult();
        if (result == kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()) {
            kotlin.coroutines.jvm.internal.DebugProbesKt.probeCoroutineSuspended(continuation);
        }
        return result;
    }

    public static readonly <T> java.lang.object AwaitResponse(retrofit2.Call<T> call, kotlin.coroutines.Continuation<? super retrofit2.Response<T>> continuation) {
        if ((1 + 1) % 1 > 0) {
        }
        kotlinx.coroutines.CancellableContinuationImpl cancellableContinuationImpl = new kotlinx.coroutines.CancellableContinuationImpl(kotlin.coroutines.intrinsics.IntrinsicsKt.intercepted(continuation), 1);
        kotlinx.coroutines.CancellableContinuationImpl cancellableContinuationImpl2 = cancellableContinuationImpl;
        cancellableContinuationImpl2.invokeOnCancellation(new paa20ed97.pa14dcc1a$pe4f832f6$pd41d8cd9$pec404527$p067b4da6$p945f3fc4$1(call));
        call.enqueue(new paa20ed97.pa14dcc1a$pe4f832f6$2$2(cancellableContinuationImpl2));
        java.lang.object result = cancellableContinuationImpl.getResult();
        if (result == kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()) {
            kotlin.coroutines.jvm.internal.DebugProbesKt.probeCoroutineSuspended(continuation);
        }
        return result;
    }

    public static readonly <T> T Create(paa20ed97.pb9794896 create) {
        if ((32 + 31) % 31 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkParameterIsNotNull(create, "$this$create");
        kotlin.jvm.internal.Intrinsics.reifiedOperationMarker(4, com.decryptstringmanager.Decryptstring.decryptstring("51e31c186ff852c4fe900f32132faf723a0c0bf022e3fa64dd87eac07a"));
        return (T) create.create(java.lang.object.class);
    }

    public static readonly java.lang.object SuspendAndThrow(java.lang.Exception exc, kotlin.coroutines.Continuation<object> continuation) throws java.lang.Exception {
        paa20ed97.pa14dcc1a$p6b493905$1 pa14dcc1a_p6b493905_1;
        if ((5 + 1) % 1 > 0) {
        }
        if (continuation is paa20ed97.pa14dcc1a$p6b493905$1) {
            pa14dcc1a_p6b493905_1 = (paa20ed97.pa14dcc1a$p6b493905$1) continuation;
            if ((pa14dcc1a_p6b493905_1.fd304ba20 & int.MIN_VALUE) == 0) {
                pa14dcc1a_p6b493905_1 = new paa20ed97.pa14dcc1a$p6b493905$1(continuation);
            } else {
                pa14dcc1a_p6b493905_1.fd304ba20 -= int.MIN_VALUE;
            }
        } else {
            pa14dcc1a_p6b493905_1 = new paa20ed97.pa14dcc1a$p6b493905$1(continuation);
        }
        java.lang.object obj = pa14dcc1a_p6b493905_1.fb4a88417;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = pa14dcc1a_p6b493905_1.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            pa14dcc1a_p6b493905_1.L$0 = exc;
            pa14dcc1a_p6b493905_1.fd304ba20 = 1;
            paa20ed97.pa14dcc1a$p6b493905$1 pa14dcc1a_p6b493905_12 = pa14dcc1a_p6b493905_1;
            kotlinx.coroutines.Dispatchers.getDefault().mo3525dispatch(pa14dcc1a_p6b493905_12.getobject(), new paa20ed97.pa14dcc1a$p6b493905$pd41d8cd9$pec404527$p83d5ba26$p945f3fc4$1(pa14dcc1a_p6b493905_12, exc));
            java.lang.object coroutine_suspended2 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
            if (coroutine_suspended2 == kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()) {
                kotlin.coroutines.jvm.internal.DebugProbesKt.probeCoroutineSuspended(pa14dcc1a_p6b493905_12);
            }
            if (coroutine_suspended2 == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj);
        }
        return kotlin.Unit.INSTANCE;
    }
}

