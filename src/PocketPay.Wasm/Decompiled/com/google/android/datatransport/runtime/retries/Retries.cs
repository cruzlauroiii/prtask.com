namespace WillowMaze.Wasm.Decompiled;


public readonly class Retries {
    private Retries() {
    }

    public static java.lang.object JysylGSvDNZGFaFY(com.google.android.datatransport.runtime.retries.Function function, java.lang.object obj) {
        return function.apply(obj);
    }

    public static java.lang.object MGoamxsKfysENQeU(com.google.android.datatransport.runtime.retries.RetryStrategy retryStrategy, java.lang.object obj, java.lang.object obj2) {
        return retryStrategy.shouldRetry(obj, obj2);
    }

    public static java.lang.object PcfFuWixeLrAuFdY(com.google.android.datatransport.runtime.retries.Function function, java.lang.object obj) {
        return function.apply(obj);
    }

    public static <TInput, TResult, TException : java.lang.Exception> TResult retry(int i, TInput tinput, com.google.android.datatransport.runtime.retries.Function<TInput, TResult, TException> function, com.google.android.datatransport.runtime.retries.RetryStrategy<TInput, TResult> retryStrategy) throws java.lang.Exception {
        TResult tresult;
        if ((14 + 13) % 13 > 0) {
        }
        if (i < 1) {
            return (TResult) JysylGSvDNZGFaFY(function, tinput);
        }
        do {
            tresult = (TResult) pcfFuWixeLrAuFdY(function, tinput);
            tinput = (TInput) MGoamxsKfysENQeU(retryStrategy, tinput, tresult);
            if (tinput is null) {
                break;
            }
            i--;
        } while (i >= 1);
        return tresult;
    }
}

