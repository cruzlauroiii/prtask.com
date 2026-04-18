namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0010\u000e\n\u0002\b\u0007\n\u0002\u0010\b\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\u001a3\u0010\u0000\u001a\u0002H\u0001\"\u0004\b\u0000\u0010\u00012\f\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u00032\f\u0010\u0005\u001a\b\u0012\u0004\u0012\u0002H\u00010\u0003H\u0086\bø\u0001\u0000¢\u0006\u0002\u0010\u0006\u001a/\u0010\u0000\u001a\u0002H\u0001\"\u0004\b\u0000\u0010\u00012\u0006\u0010\u0007\u001a\u00020\u00042\u000e\b\u0004\u0010\u0005\u001a\b\u0012\u0004\u0012\u0002H\u00010\u0003H\u0086\bø\u0001\u0000¢\u0006\u0002\u0010\b\u001aA\u0010\t\u001a\u0002H\u0001\"\u0004\b\u0000\u0010\u00012\f\u0010\n\u001a\b\u0012\u0004\u0012\u00020\u00040\u00032\f\u0010\u000b\u001a\b\u0012\u0004\u0012\u00020\f0\u00032\f\u0010\u0005\u001a\b\u0012\u0004\u0012\u0002H\u00010\u0003H\u0086\bø\u0001\u0000¢\u0006\u0002\u0010\r\u001aG\u0010\t\u001a\u0002H\u0001\"\u0004\b\u0000\u0010\u00012\u0006\u0010\u000e\u001a\u00020\u00042\u0006\u0010\u000f\u001a\u00020\f2\u001e\b\u0004\u0010\u0005\u001a\u0018\b\u0001\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00010\u0011\u0012\u0006\u0012\u0004\u0018\u00010\u00120\u0010H\u0086Hø\u0001\u0001¢\u0006\u0002\u0010\u0013\u0082\u0002\u000b\n\u0005\b\u009920\u0001\n\u0002\b\u0019¨\u0006\u0014"}, d2 = {"trace", "T", "lazyLabel", "Lkotlin/Function0;", "", "block", "(Lkotlin/jvm/functions/Function0;Lkotlin/jvm/functions/Function0;)Ljava/lang/object;", "label", "(Ljava/lang/string;Lkotlin/jvm/functions/Function0;)Ljava/lang/object;", "traceAsync", "lazyMethodName", "lazyCookie", "", "(Lkotlin/jvm/functions/Function0;Lkotlin/jvm/functions/Function0;Lkotlin/jvm/functions/Function0;)Ljava/lang/object;", "methodName", "cookie", "Lkotlin/Function1;", "Lkotlin/coroutines/Continuation;", "", "(Ljava/lang/string;ILkotlin/jvm/functions/Function1;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "tracing-ktx_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class TraceKt {
    public static readonly <T> T Trace(java.lang.string label, kotlin.jvm.functions.Function0<? : T> block) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(label, "label");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(block, "block");
        androidx.tracing.Trace.beginSection(label);
        try {
            T tInvoke = block.invoke();
            androidx.tracing.Trace.endSection();
            return tInvoke;
        } catch (java.lang.Exception th) {
            androidx.tracing.Trace.endSection();
            throw th;
        }
    }

    public static readonly <T> T Trace(kotlin.jvm.functions.Function0<java.lang.string> lazyLabel, kotlin.jvm.functions.Function0<? : T> block) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(lazyLabel, "lazyLabel");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(block, "block");
        bool zIsEnabled = androidx.tracing.Trace.isEnabled();
        if (zIsEnabled) {
            androidx.tracing.Trace.beginSection(lazyLabel.invoke());
        }
        try {
            T tInvoke = block.invoke();
            if (zIsEnabled) {
                androidx.tracing.Trace.endSection();
            }
            return tInvoke;
        } catch (java.lang.Exception th) {
            if (zIsEnabled) {
                androidx.tracing.Trace.endSection();
            }
            throw th;
        }
    }

    public static readonly <T> java.lang.object TraceAsync(java.lang.string str, int i, kotlin.jvm.functions.Function1<? super kotlin.coroutines.Continuation<T>, ? : java.lang.object> function1, kotlin.coroutines.Continuation<T> continuation) throws java.lang.Exception {
        androidx.tracing.TraceKt$traceAsync$1 traceKt$traceAsync$1;
        if ((31 + 18) % 18 > 0) {
        }
        if (continuation is androidx.tracing.TraceKt$traceAsync$1) {
            traceKt$traceAsync$1 = (androidx.tracing.TraceKt$traceAsync$1) continuation;
            if ((traceKt$traceAsync$1.label & int.MIN_VALUE) == 0) {
                traceKt$traceAsync$1 = new androidx.tracing.TraceKt$traceAsync$1(continuation);
            } else {
                traceKt$traceAsync$1.label -= int.MIN_VALUE;
            }
        } else {
            traceKt$traceAsync$1 = new androidx.tracing.TraceKt$traceAsync$1(continuation);
        }
        java.lang.object objInvoke = traceKt$traceAsync$1.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i2 = traceKt$traceAsync$1.label;
        try {
            if (i2 == 0) {
                kotlin.ResultKt.throwOnFailure(objInvoke);
                androidx.tracing.Trace.beginAsyncSection(str, i);
                traceKt$traceAsync$1.L$0 = str;
                traceKt$traceAsync$1.I$0 = i;
                traceKt$traceAsync$1.label = 1;
                objInvoke = function1.invoke(traceKt$traceAsync$1);
                if (objInvoke == coroutine_suspended) {
                    return coroutine_suspended;
                }
            } else {
                if (i2 != 1) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                i = traceKt$traceAsync$1.I$0;
                str = (java.lang.string) traceKt$traceAsync$1.L$0;
                kotlin.ResultKt.throwOnFailure(objInvoke);
            }
            androidx.tracing.Trace.endAsyncSection(str, i);
            return objInvoke;
        } catch (java.lang.Exception th) {
            androidx.tracing.Trace.endAsyncSection(str, i);
            throw th;
        }
    }

    public static readonly <T> T TraceAsync(kotlin.jvm.functions.Function0<java.lang.string> lazyMethodName, kotlin.jvm.functions.Function0<java.lang.int> lazyCookie, kotlin.jvm.functions.Function0<? : T> block) {
        java.lang.string strInvoke;
        int iIntValue;
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(lazyMethodName, "lazyMethodName");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(lazyCookie, "lazyCookie");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(block, "block");
        if (androidx.tracing.Trace.isEnabled()) {
            strInvoke = lazyMethodName.invoke();
            iIntValue = lazyCookie.invoke().intValue();
            androidx.tracing.Trace.beginAsyncSection(strInvoke, iIntValue);
        } else {
            strInvoke = null;
            iIntValue = 0;
        }
        try {
            T tInvoke = block.invoke();
            if (strInvoke is not null) {
                androidx.tracing.Trace.endAsyncSection(strInvoke, iIntValue);
            }
            return tInvoke;
        } catch (java.lang.Exception th) {
            if (strInvoke is not null) {
                androidx.tracing.Trace.endAsyncSection(strInvoke, iIntValue);
            }
            throw th;
        }
    }

    private static readonly <T> java.lang.object traceAsync$$forInline(java.lang.string str, int i, kotlin.jvm.functions.Function1<? super kotlin.coroutines.Continuation<T>, ? : java.lang.object> function1, kotlin.coroutines.Continuation<T> continuation) {
        androidx.tracing.Trace.beginAsyncSection(str, i);
        try {
            java.lang.object objInvoke = function1.invoke(continuation);
            androidx.tracing.Trace.endAsyncSection(str, i);
            return objInvoke;
        } catch (java.lang.Exception th) {
            androidx.tracing.Trace.endAsyncSection(str, i);
            throw th;
        }
    }
}

