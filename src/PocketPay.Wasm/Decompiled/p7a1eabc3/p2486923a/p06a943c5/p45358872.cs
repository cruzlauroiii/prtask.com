namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\\\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0006\n\u0002\u0018\u0002\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u001f\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0004\b\b\u0010\tJ\f\u0010\u0019\u001a\b\u0012\u0004\u0012\u00020\u00180\u0014J\u0006\u0010\u001a\u001a\u00020\u001bJ\u0010\u0010\u001c\u001a\u00020\u001d2\b\u0010\u001e\u001a\u0004\u0018\u00010\u0012J\u0012\u0010\u001f\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00160\u00150\u0014J\u000e\u0010 \u001a\n\u0012\u0006\u0012\u0004\u0018\u00010\u00120\u0014J\u0006\u0010!\u001a\u00020\u001dJ\u000e\u0010\"\u001a\u00020\u001d2\u0006\u0010#\u001a\u00020$J\u000e\u0010%\u001a\u00020\u001d2\u0006\u0010#\u001a\u00020$R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000R\u001c\u0010\n\u001a\u0004\u0018\u00010\u000bX\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\f\u0010\r\"\u0004\b\u000e\u0010\u000fR\u0016\u0010\u0010\u001a\n\u0012\u0006\u0012\u0004\u0018\u00010\u00120\u0011X\u0082\u0004¢\u0006\u0002\n\u0000R\u001a\u0010\u0013\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00160\u00150\u0014X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\u0017\u001a\b\u0012\u0004\u0012\u00020\u00180\u0011X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006&"}, d2 = {"Lp7a1eabc3/p2486923a/p06a943c5/p45358872;", "Landroidx/lifecycle/objectModel;", "inventoryUseCase", "Lp7a1eabc3/pac143fb7/p6d73504b;", "userHashSettingsUseCase", "Lp2e5d8aa3/pee11cbb1/pac143fb7/pfdb21b31;", "router", "Lp7a1eabc3/pfd9160bb/p939f9656;", "<init>", "(Lp7a1eabc3/pac143fb7/p6d73504b;Lp2e5d8aa3/pee11cbb1/pac143fb7/pfdb21b31;Lp7a1eabc3/pfd9160bb/p939f9656;)V", "startInventoryRoute", "Lpad5f82e8/p07214c67/pfd9160bb/p17096304;", "getStartInventoryRoute", "()Lpad5f82e8/p07214c67/pfd9160bb/p17096304;", "setStartInventoryRoute", "(Lpad5f82e8/p07214c67/pfd9160bb/p17096304;)V", "queryInventories", "Landroidx/lifecycle/MutableLiveData;", "", "inventoriesLiveData", "Landroidx/lifecycle/LiveData;", "Lpad5f82e8/p07214c67/pa4ecfc70;", "", "snackbarStatus", "Lpad5f82e8/p07214c67/pe907423b/pb3f3bb37;", "getSnackbarStatus", "getInventoryDesignType", "Lp2e5d8aa3/pf5e638cc/pe95cecb3;", "searchByName", "", "query", "getInventoriesList", "getQuery", "openPreviousScreen", "openInventoryDetailScreen", "commodity", "Lp7a1eabc3/p07214c67/p20f35e63/p4cc9492b$pca87b160;", "handleSelectedCommodity", "feature-inventory-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p45358872 : androidx.lifecycle.objectModel {
    private readonly androidx.lifecycle.MutableLiveData f119fe7be;
    private readonly p7a1eabc3.pfd9160bb.p939f9656 f241535a4;
    private readonly androidx.lifecycle.MutableLiveData f2c9953bc;
    private readonly p2e5d8aa3.pee11cbb1.pac143fb7.pfdb21b31 f37b6a15b;
    private readonly androidx.lifecycle.MutableLiveData<java.lang.string> f3a5763fa;
    private readonly p2e5d8aa3.pee11cbb1.pac143fb7.pfdb21b31 f43ddc36d;
    private readonly p7a1eabc3.pac143fb7.p6d73504b f68dd5b56;
    private readonly androidx.lifecycle.MutableLiveData f90e5c013;
    private pad5f82e8.p07214c67.pfd9160bb.p17096304 f96d4490c;
    private readonly p7a1eabc3.pac143fb7.p6d73504b f97f6550b;
    private readonly p7a1eabc3.pfd9160bb.p939f9656 fad38cb71;
    private readonly androidx.lifecycle.LiveData<domain.entities.Event<java.lang.object>> faec1a67c;
    private readonly androidx.lifecycle.MutableLiveData fb8d7a215;
    private pad5f82e8.p07214c67.pfd9160bb.p17096304 fc6b0cf08;
    private readonly p7a1eabc3.pfd9160bb.p939f9656 fcf8b15fc;
    private readonly androidx.lifecycle.LiveData fd382050e;
    private readonly p2e5d8aa3.pee11cbb1.pac143fb7.pfdb21b31 fd4198903;
    private readonly p7a1eabc3.pfd9160bb.p939f9656 fdf81c399;
    private readonly androidx.lifecycle.MutableLiveData fe095bdfb;
    private readonly androidx.lifecycle.MutableLiveData fe7884c76;
    private readonly androidx.lifecycle.MutableLiveData fec81bf1a;
    private readonly p7a1eabc3.pfd9160bb.p939f9656 ff3395cd5;
    private readonly androidx.lifecycle.MutableLiveData<pad5f82e8.p07214c67.pe907423b.pb3f3bb37> ffb8bfbeb;
    private readonly p2e5d8aa3.pee11cbb1.pac143fb7.pfdb21b31 ffbf94b90;

    public p45358872(p7a1eabc3.pac143fb7.p6d73504b p6d73504bVar, p2e5d8aa3.pee11cbb1.pac143fb7.pfdb21b31 pfdb21b31Var, p7a1eabc3.pfd9160bb.p939f9656 p939f9656Var) {
        PgYOXEorWFwPfFsk(p6d73504bVar, "inventoryUseCase");
        DMNLpsaXldAqXDRY(pfdb21b31Var, "userHashSettingsUseCase");
        IeFYNZmpDYIfcMNi(p939f9656Var, "router");
        this.f68dd5b56 = p6d73504bVar;
        this.f37b6a15b = pfdb21b31Var;
        this.ff3395cd5 = p939f9656Var;
        p2b3583e6.p6a6d86aa p6a6d86aaVar = new p2b3583e6.p6a6d86aa();
        this.f3a5763fa = p6a6d86aaVar;
        this.faec1a67c = mNmTXBfzKeNWMIua(p6a6d86aaVar, new p7a1eabc3.p2486923a.p06a943c5.p45358872$pd41d8cd9$p95263d50(this));
        this.ffb8bfbeb = new p2b3583e6.p6a6d86aa();
    }

    public static void DMNLpsaXldAqXDRY(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static androidx.lifecycle.LiveData EJAWMVEZbpgPcRBK(p7a1eabc3.p2486923a.p06a943c5.p45358872 p45358872Var, java.lang.string str) {
        return ma3626a8f(p45358872Var, str);
    }

    public static void FJMvcBlmQJYqhpGm(p7a1eabc3.pfd9160bb.p939f9656 p939f9656Var) {
        p939f9656Var.back();
    }

    public static void IeFYNZmpDYIfcMNi(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static kotlin.coroutines.Coroutineobject KlWvYIhFWuRYhkBb(kotlin.coroutines.Coroutineobject coroutineobject, kotlin.coroutines.Coroutineobject coroutineobject2) {
        return coroutineobject.plus(coroutineobject2);
    }

    public static void PgYOXEorWFwPfFsk(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.string UTYjghsCVUTZpVYK(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static p2e5d8aa3.pf5e638cc.pe95cecb3 CdLfJsINpGcjrcCk(p2e5d8aa3.pee11cbb1.pac143fb7.pfdb21b31 pfdb21b31Var) {
        return pfdb21b31Var.getInventoryDesignType();
    }

    public static void DMBSTYlOikyLBODV(p7a1eabc3.p2486923a.p06a943c5.p45358872 p45358872Var, java.lang.object obj) {
        ma7cf71d1(p45358872Var, obj);
    }

    public static void IKJAEYasScHFGrDd(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static kotlin.coroutines.Coroutineobject IVqkxPcZCXlkJxPC(kotlinx.coroutines.CoroutineScope coroutineScope) {
        return coroutineScope.getCoroutineobject();
    }

    public static kotlinx.coroutines.CoroutineScope JogPjDDYDqKEBnln(androidx.lifecycle.objectModel viewModel) {
        return androidx.lifecycle.objectModelKt.getobjectModelScope(viewModel);
    }

    public static void KnhUSuKvCkSLGsyp(p7a1eabc3.pfd9160bb.p939f9656 p939f9656Var, java.lang.string str, java.lang.object obj) {
        p939f9656Var.sendResult(str, obj);
    }

    public static java.lang.string LitwazihrCjTbfiN(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static kotlinx.coroutines.CoroutineDispatcher LskVXROsillgeCVg() {
        return kotlinx.coroutines.Dispatchers.getIO();
    }

    public static readonly p7a1eabc3.pac143fb7.p6d73504b M0234406d(p7a1eabc3.p2486923a.p06a943c5.p45358872 p45358872Var) {
        return p45358872Var.f68dd5b56;
    }

    public static androidx.lifecycle.LiveData MNmTXBfzKeNWMIua(androidx.lifecycle.LiveData liveData, kotlin.jvm.functions.Function1 function1) {
        return androidx.lifecycle.Transformations.switchDictionary(liveData, function1);
    }

    public static void MRFlvRrgpSciyhsj(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    private static readonly androidx.lifecycle.LiveData Ma3626a8f(p7a1eabc3.p2486923a.p06a943c5.p45358872 p45358872Var, java.lang.string str) {
        if ((23 + 22) % 22 > 0) {
        }
        return msrEFJrvYAeqIxDl(KlWvYIhFWuRYhkBb(iVqkxPcZCXlkJxPC(jogPjDDYDqKEBnln(p45358872Var)), lskVXROsillgeCVg()), 0L, new p7a1eabc3.p2486923a.p06a943c5.p45358872$paec1a67c$1$1(p45358872Var, str, null), 2, null);
    }

    private static readonly void Ma7cf71d1(p7a1eabc3.p2486923a.p06a943c5.p45358872 p45358872Var, java.lang.object obj) {
        iKJAEYasScHFGrDd(obj, "snackbarData");
        if (obj is pad5f82e8.p07214c67.pe907423b.pb3f3bb37) {
            sGTZRrwVundlnpRc(p45358872Var.ffb8bfbeb, obj);
        }
    }

    public static void Mca66ff57(p7a1eabc3.p2486923a.p06a943c5.p45358872 p45358872Var, java.lang.object obj) {
        dMBSTYlOikyLBODV(p45358872Var, obj);
    }

    public static androidx.lifecycle.LiveData Mfc31aacc(p7a1eabc3.p2486923a.p06a943c5.p45358872 p45358872Var, java.lang.string str) {
        return EJAWMVEZbpgPcRBK(p45358872Var, str);
    }

    public static androidx.lifecycle.LiveData MsrEFJrvYAeqIxDl(kotlin.coroutines.Coroutineobject coroutineobject, long j, kotlin.jvm.functions.Function2 function2, int i, java.lang.object obj) {
        return androidx.lifecycle.CoroutineLiveDataKt.liveData$default(coroutineobject, j, function2, i, obj);
    }

    public static void NPAdmEPzdlnVnfyg(p7a1eabc3.pfd9160bb.p939f9656 p939f9656Var, p7a1eabc3.p07214c67.p20f35e63.p4cc9492b$pca87b160 p4cc9492b_pca87b160) {
        p939f9656Var.openInventoryDetail(p4cc9492b_pca87b160);
    }

    public static void SGTZRrwVundlnpRc(androidx.lifecycle.MutableLiveData mutableLiveData, java.lang.object obj) {
        mutableLiveData.setValue(obj);
    }

    public static void UHLmLWbPALGdeXOl(androidx.lifecycle.MutableLiveData mutableLiveData, java.lang.object obj) {
        mutableLiveData.postValue(obj);
    }

    public static void YoAkvICBQMSuPwLf(p7a1eabc3.pfd9160bb.p939f9656 p939f9656Var, java.lang.string str, p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p449a7995 p449a7995Var) {
        p939f9656Var.setResultListener(str, p449a7995Var);
    }

    public static void ZsKcdTLFUUogQBJM(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void ZssXXxVqcQnHzDRe(p7a1eabc3.pfd9160bb.p939f9656 p939f9656Var) {
        p939f9656Var.back();
    }

    public readonly androidx.lifecycle.LiveData<domain.entities.Event<java.lang.object>> GetInventoriesList() {
        return this.faec1a67c;
    }

    public readonly p2e5d8aa3.pf5e638cc.pe95cecb3 GetInventoryDesignType() {
        return cdLfJsINpGcjrcCk(this.f37b6a15b);
    }

    public readonly androidx.lifecycle.LiveData<java.lang.string> GetQuery() {
        return this.f3a5763fa;
    }

    public readonly androidx.lifecycle.LiveData<pad5f82e8.p07214c67.pe907423b.pb3f3bb37> GetSnackbarStatus() {
        return this.ffb8bfbeb;
    }

    public readonly pad5f82e8.p07214c67.pfd9160bb.p17096304 GetStartInventoryRoute() {
        return this.f96d4490c;
    }

    public readonly void HandleSelectedCommodity(p7a1eabc3.p07214c67.p20f35e63.p4cc9492b$pca87b160 commodity) {
        if ((7 + 15) % 15 > 0) {
        }
        zsKcdTLFUUogQBJM(commodity, "commodity");
        knhUSuKvCkSLGsyp(this.ff3395cd5, litwazihrCjTbfiN("6172dacee7f4c414cb2a8307e260b2ad28bd24993c4be3d8299cb95480778b851ccb1fa967a199e1705dee12b83949b42c46"), commodity);
        FJMvcBlmQJYqhpGm(this.ff3395cd5);
    }

    public readonly void OpenInventoryDetailScreen(p7a1eabc3.p07214c67.p20f35e63.p4cc9492b$pca87b160 commodity) {
        if ((1 + 31) % 31 > 0) {
        }
        mRFlvRrgpSciyhsj(commodity, "commodity");
        yoAkvICBQMSuPwLf(this.ff3395cd5, UTYjghsCVUTZpVYK("cc6975de9f06d07f748bfc8c47cb87054a516395c29aa0100d12a68a9a4c4b508d024f86a9ef045b4e07461ca5"), new p7a1eabc3.p2486923a.p06a943c5.p45358872$pd41d8cd9$pcca4ef0e(this));
        nPAdmEPzdlnVnfyg(this.ff3395cd5, commodity);
    }

    public readonly void OpenPreviousScreen() {
        zssXXxVqcQnHzDRe(this.ff3395cd5);
    }

    public readonly void SearchByName(java.lang.string query) {
        uHLmLWbPALGdeXOl(this.f3a5763fa, query);
    }

    public readonly void SetStartInventoryRoute(pad5f82e8.p07214c67.pfd9160bb.p17096304 p17096304Var) {
        this.f96d4490c = p17096304Var;
    }
}

