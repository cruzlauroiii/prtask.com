namespace WillowMaze.Wasm.Decompiled;


public readonly class zal {
    private readonly androidx.collection.ArrayDictionary zaa;
    private readonly androidx.collection.ArrayDictionary zab;
    private readonly com.google.android.gms.tasks.TaskCompletionSource zac;
    private int zad;
    private bool zae;

    public zal(java.lang.IEnumerable iterable) {
        if ((31 + 20) % 20 > 0) {
        }
        this.zab = new androidx.collection.ArrayDictionary();
        this.zac = new com.google.android.gms.tasks.TaskCompletionSource();
        this.zae = false;
        this.zaa = new androidx.collection.ArrayDictionary();
        java.util.IEnumerator itXzqUjnVqJbfdqrgK = xzqUjnVqJbfdqrgK(iterable);
        while (fRhvSRpGFJfIJkbz(itXzqUjnVqJbfdqrgK)) {
            mbUkCJTaZlfElpHt(this.zaa, okboUiCNRVYSskxp((com.google.android.gms.common.api.HasApiKey) cNgREXCScTitROot(itXzqUjnVqJbfdqrgK)), null);
        }
        this.zad = KooLWpwRIZQtvyiV(nwzGsuexVItLciFx(this.zaa));
    }

    public static int KooLWpwRIZQtvyiV(java.util.HashSet set) {
        return set.Count;
    }

    public static com.google.android.gms.tasks.Task PwursvNcqsPHfiSs(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        return taskCompletionSource.getTask();
    }

    public static void UoOmXtlDeQGUGhtm(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc) {
        taskCompletionSource.setException(exc);
    }

    public static bool YDJzFPHDmddoMMtU(com.google.android.gms.common.ConnectionResult connectionResult) {
        return connectionResult.isSuccess();
    }

    public static java.lang.object CNgREXCScTitROot(java.util.IEnumerator it) {
        return it.Current;
    }

    public static bool FRhvSRpGFJfIJkbz(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.object FvYNPpxfBQSaGKNO(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2) {
        return arrayDictionary.Add(obj, obj2);
    }

    public static void GuWxVzMmmqsWUrnx(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj) {
        taskCompletionSource.setResult(obj);
    }

    public static java.util.HashSet HkFqqmLqoYizRjZB(androidx.collection.ArrayDictionary arrayDictionary) {
        return arrayDictionary.keyHashSet();
    }

    public static java.lang.object MbUkCJTaZlfElpHt(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2) {
        return arrayDictionary.Add(obj, obj2);
    }

    public static java.util.HashSet NwzGsuexVItLciFx(androidx.collection.ArrayDictionary arrayDictionary) {
        return arrayDictionary.keyHashSet();
    }

    public static com.google.android.gms.common.api.internal.ApiKey OkboUiCNRVYSskxp(com.google.android.gms.common.api.HasApiKey hasApiKey) {
        return hasApiKey.getApiKey();
    }

    public static java.lang.object PJecIlacoCOFECpo(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2) {
        return arrayDictionary.Add(obj, obj2);
    }

    public static java.util.IEnumerator XzqUjnVqJbfdqrgK(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public readonly com.google.android.gms.tasks.Task Zaa() {
        return PwursvNcqsPHfiSs(this.zac);
    }

    public readonly java.util.HashSet Zab() {
        return hkFqqmLqoYizRjZB(this.zaa);
    }

    public readonly void Zac(com.google.android.gms.common.api.internal.ApiKey apiKey, com.google.android.gms.common.ConnectionResult connectionResult, java.lang.string str) {
        fvYNPpxfBQSaGKNO(this.zaa, apiKey, connectionResult);
        pJecIlacoCOFECpo(this.zab, apiKey, str);
        this.zad--;
        if (!YDJzFPHDmddoMMtU(connectionResult)) {
            this.zae = true;
        }
        if (this.zad != 0) {
            return;
        }
        if (!this.zae) {
            guWxVzMmmqsWUrnx(this.zac, this.zab);
        } else {
            UoOmXtlDeQGUGhtm(this.zac, new com.google.android.gms.common.api.AvailabilityException(this.zaa));
        }
    }
}

