namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000V\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0002\n\u0002\b\n\u0018\u00002\u00020\u0001B'\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007\u0012\u0006\u0010\b\u001a\u00020\t¢\u0006\u0004\b\n\u0010\u000bJ\u000e\u0010\u0019\u001a\u00020\u001a2\u0006\u0010\u001b\u001a\u00020\u0012J\u0006\u0010\u001c\u001a\u00020\u001aJ\u000e\u0010\u001d\u001a\u00020\u001a2\u0006\u0010\u001b\u001a\u00020\u0012J\u000e\u0010\u001e\u001a\u00020\u001a2\u0006\u0010\u001f\u001a\u00020\u000eJ\u0012\u0010\u000f\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00120\u00110\u0010J\u0012\u0010 \u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00140\u00110\u0010J\f\u0010!\u001a\b\u0012\u0004\u0012\u00020\u00160\u0010J\f\u0010\"\u001a\b\u0012\u0004\u0012\u00020\u00180\u0010J\u0006\u0010#\u001a\u00020\u001aR\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\b\u001a\u00020\tX\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\f\u001a\b\u0012\u0004\u0012\u00020\u000e0\rX\u0082\u0004¢\u0006\u0002\n\u0000R\u001a\u0010\u000f\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00120\u00110\u0010X\u0082\u0004¢\u0006\u0002\n\u0000R\u001a\u0010\u0013\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00140\u00110\rX\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\u0015\u001a\b\u0012\u0004\u0012\u00020\u00160\rX\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\u0017\u001a\b\u0012\u0004\u0012\u00020\u00180\rX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006$"}, d2 = {"Lp7a1eabc3/p2486923a/p951da6b7/pc7a824b4;", "Landroidx/lifecycle/objectModel;", "inventoryUseCase", "Lp7a1eabc3/pac143fb7/p6d73504b;", "userInfoUseCase", "Lpad5f82e8/pac143fb7/p49f290d6/p2f3c4196;", "router", "Lp7a1eabc3/pfd9160bb/p939f9656;", "resourceProvider", "Lp2b3583e6/p4a931512/p2e423cc6;", "<init>", "(Lp7a1eabc3/pac143fb7/p6d73504b;Lpad5f82e8/pac143fb7/p49f290d6/p2f3c4196;Lp7a1eabc3/pfd9160bb/p939f9656;Lp2b3583e6/p4a931512/p2e423cc6;)V", "inventoryId", "Landroidx/lifecycle/MutableLiveData;", "", "currentInventoryItem", "Landroidx/lifecycle/LiveData;", "Lpad5f82e8/p07214c67/pa4ecfc70;", "Lp7a1eabc3/p07214c67/p20f35e63/p4cc9492b$pca87b160;", "removeInventoryStatus", "", "snackBarStatus", "Lpad5f82e8/p07214c67/pe907423b/pb3f3bb37;", "toolbarMenuVisibleStatus", "", "removeCommodity", "", "inventoryItem", "showToolbarMenu", "openInventoryEditScreen", "setInventoryId", "id", "removeInventoryItem", "getSnackBarStatus", "observeToolbarMenuVisibleStatus", "openPreviousScreen", "feature-inventory-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pc7a824b4 : androidx.lifecycle.objectModel {
    private readonly androidx.lifecycle.MutableLiveData<java.lang.bool> f0f320b64;
    private readonly androidx.lifecycle.MutableLiveData f2eb33675;
    private readonly androidx.lifecycle.MutableLiveData f443322ca;
    private readonly p2b3583e6.p4a931512.p2e423cc6 f4734ade7;
    private readonly androidx.lifecycle.MutableLiveData f4ed20684;
    private readonly p7a1eabc3.pac143fb7.p6d73504b f50863146;
    private readonly androidx.lifecycle.MutableLiveData f52d4f2c0;
    private readonly p2b3583e6.p4a931512.p2e423cc6 f62ce8ab4;
    private readonly p7a1eabc3.pac143fb7.p6d73504b f68dd5b56;
    private readonly p2b3583e6.p4a931512.p2e423cc6 f70110e83;
    private readonly androidx.lifecycle.MutableLiveData f7f1b645a;
    private readonly androidx.lifecycle.MutableLiveData<java.lang.string> f84aa9876;
    private readonly androidx.lifecycle.MutableLiveData f858c5085;
    private readonly pad5f82e8.pac143fb7.p49f290d6.p2f3c4196 f8b3f644b;
    private readonly androidx.lifecycle.LiveData<domain.entities.Event<p7a1eabc3.p07214c67.p20f35e63.p4cc9492b$pca87b160>> f9e175697;
    private readonly androidx.lifecycle.MutableLiveData fa176eafc;
    private readonly androidx.lifecycle.MutableLiveData fa2e2c9ed;
    private readonly androidx.lifecycle.LiveData fa3d0bd4d;
    private readonly androidx.lifecycle.MutableLiveData fabfffab0;
    private readonly p7a1eabc3.pfd9160bb.p939f9656 fb0087805;
    private readonly androidx.lifecycle.LiveData fb3ed66af;
    private readonly androidx.lifecycle.LiveData fb8e3413a;
    private readonly androidx.lifecycle.MutableLiveData fbaf3a7dc;
    private readonly androidx.lifecycle.MutableLiveData fbfc8049a;
    private readonly p7a1eabc3.pfd9160bb.p939f9656 fc52c1541;
    private readonly androidx.lifecycle.LiveData fcb277fc3;
    private readonly androidx.lifecycle.MutableLiveData<pad5f82e8.p07214c67.pe907423b.pb3f3bb37> fceffa6b4;
    private readonly androidx.lifecycle.MutableLiveData fd4574372;
    private readonly p7a1eabc3.pfd9160bb.p939f9656 fd71dd3bc;
    private readonly pad5f82e8.pac143fb7.p49f290d6.p2f3c4196 fe639d08f;
    private readonly androidx.lifecycle.MutableLiveData<domain.entities.Event<java.lang.object>> fe91546f3;
    private readonly p7a1eabc3.pfd9160bb.p939f9656 ff3395cd5;
    private readonly p7a1eabc3.pfd9160bb.p939f9656 ff9ab2765;

    public pc7a824b4(p7a1eabc3.pac143fb7.p6d73504b p6d73504bVar, pad5f82e8.pac143fb7.p49f290d6.p2f3c4196 p2f3c4196Var, p7a1eabc3.pfd9160bb.p939f9656 p939f9656Var, p2b3583e6.p4a931512.p2e423cc6 p2e423cc6Var) {
        DkFaUbyhlZtfXLux(p6d73504bVar, "inventoryUseCase");
        jWyrfQIHLbCJAiIX(p2f3c4196Var, "userInfoUseCase");
        DRZsZpLBHhbALNch(p939f9656Var, "router");
        OitUDesGbWSBQkJC(p2e423cc6Var, "resourceProvider");
        this.f68dd5b56 = p6d73504bVar;
        this.fe639d08f = p2f3c4196Var;
        this.ff3395cd5 = p939f9656Var;
        this.f4734ade7 = p2e423cc6Var;
        androidx.lifecycle.MutableLiveData<java.lang.string> mutableLiveData = new androidx.lifecycle.MutableLiveData<>();
        this.f84aa9876 = mutableLiveData;
        this.f9e175697 = JbUiAsZHTFhEiXCG(mutableLiveData, new p7a1eabc3.p2486923a.p951da6b7.pc7a824b4$pd41d8cd9$p95263d50(this));
        this.fe91546f3 = new p2b3583e6.p6a6d86aa();
        this.fceffa6b4 = new p2b3583e6.p6a6d86aa();
        this.f0f320b64 = new p2b3583e6.p6a6d86aa();
    }

    public static void DRZsZpLBHhbALNch(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void DkFaUbyhlZtfXLux(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static bool EAKkKxkKEnqLZzMN(pad5f82e8.pac143fb7.p49f290d6.p2f3c4196 p2f3c4196Var, pad5f82e8.p07214c67.p49f290d6.p1533e8ac[] p1533e8acVarArr) {
        return p2f3c4196Var.hasAtLeastOneGrantOf(p1533e8acVarArr);
    }

    public static androidx.lifecycle.LiveData JbUiAsZHTFhEiXCG(androidx.lifecycle.LiveData liveData, kotlin.jvm.functions.Function1 function1) {
        return androidx.lifecycle.Transformations.switchDictionary(liveData, function1);
    }

    public static void KiXpoXyyFofNiBeG(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static kotlinx.coroutines.Job OiBGJlZDfMnripgk(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Coroutineobject coroutineobject, kotlinx.coroutines.CoroutineStart coroutineStart, kotlin.jvm.functions.Function2 function2, int i, java.lang.object obj) {
        return kotlinx.coroutines.BuildersKt.launch$default(coroutineScope, coroutineobject, coroutineStart, function2, i, obj);
    }

    public static void OitUDesGbWSBQkJC(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void SqHAbKtDUqIBDCWv(p7a1eabc3.pfd9160bb.p939f9656 p939f9656Var, pad5f82e8.p07214c67.pfd9160bb.p17096304 p17096304Var, p7a1eabc3.p07214c67.p20f35e63.p4cc9492b$pca87b160 p4cc9492b_pca87b160) {
        p939f9656Var.openInventoryEdit(p17096304Var, p4cc9492b_pca87b160);
    }

    public static void TYVCXSCoMYJmHWLy(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static kotlinx.coroutines.CoroutineScope WsJuSUDfYWMleaIO(androidx.lifecycle.objectModel viewModel) {
        return androidx.lifecycle.objectModelKt.getobjectModelScope(viewModel);
    }

    public static void YnGgGQsTwWbGjyWD(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void BYHcVVloNwbrJESB(p7a1eabc3.pfd9160bb.p939f9656 p939f9656Var) {
        p939f9656Var.back();
    }

    public static androidx.lifecycle.LiveData DjqBYrtrlRQxtbgq(kotlin.coroutines.Coroutineobject coroutineobject, long j, kotlin.jvm.functions.Function2 function2, int i, java.lang.object obj) {
        return androidx.lifecycle.CoroutineLiveDataKt.liveData$default(coroutineobject, j, function2, i, obj);
    }

    public static kotlinx.coroutines.CoroutineScope DsosvTKnljSVJDEb(androidx.lifecycle.objectModel viewModel) {
        return androidx.lifecycle.objectModelKt.getobjectModelScope(viewModel);
    }

    public static void FHxHUtWdMKTIwIpo(androidx.lifecycle.MutableLiveData mutableLiveData, java.lang.object obj) {
        mutableLiveData.postValue(obj);
    }

    public static androidx.lifecycle.LiveData HlkMbCLNjwgDbaBS(p7a1eabc3.p2486923a.p951da6b7.pc7a824b4 pc7a824b4Var, java.lang.string str) {
        return mf0c8ab66(pc7a824b4Var, str);
    }

    public static java.lang.bool JTFvfHDsEcuaoZja(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void JWyrfQIHLbCJAiIX(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static kotlin.coroutines.Coroutineobject LuCGjkpCicDotauz(kotlinx.coroutines.CoroutineScope coroutineScope) {
        return coroutineScope.getCoroutineobject();
    }

    public static readonly p7a1eabc3.pac143fb7.p6d73504b M0234406d(p7a1eabc3.p2486923a.p951da6b7.pc7a824b4 pc7a824b4Var) {
        return pc7a824b4Var.f68dd5b56;
    }

    public static readonly androidx.lifecycle.MutableLiveData M31264769(p7a1eabc3.p2486923a.p951da6b7.pc7a824b4 pc7a824b4Var) {
        return pc7a824b4Var.fe91546f3;
    }

    public static readonly p2b3583e6.p4a931512.p2e423cc6 M5fb81a65(p7a1eabc3.p2486923a.p951da6b7.pc7a824b4 pc7a824b4Var) {
        return pc7a824b4Var.f4734ade7;
    }

    public static readonly p7a1eabc3.pfd9160bb.p939f9656 M74e3994c(p7a1eabc3.p2486923a.p951da6b7.pc7a824b4 pc7a824b4Var) {
        return pc7a824b4Var.ff3395cd5;
    }

    public static readonly androidx.lifecycle.MutableLiveData M79e7eef2(p7a1eabc3.p2486923a.p951da6b7.pc7a824b4 pc7a824b4Var) {
        return pc7a824b4Var.fceffa6b4;
    }

    public static androidx.lifecycle.LiveData M8d09aab9(p7a1eabc3.p2486923a.p951da6b7.pc7a824b4 pc7a824b4Var, java.lang.string str) {
        return hlkMbCLNjwgDbaBS(pc7a824b4Var, str);
    }

    public static void MZydFwcEOhGryhkI(androidx.lifecycle.MutableLiveData mutableLiveData, java.lang.object obj) {
        mutableLiveData.setValue(obj);
    }

    private static readonly androidx.lifecycle.LiveData Mf0c8ab66(p7a1eabc3.p2486923a.p951da6b7.pc7a824b4 pc7a824b4Var, java.lang.string str) {
        if ((19 + 2) % 2 > 0) {
        }
        return djqBYrtrlRQxtbgq(xvYMTllaQGDXgDYn(luCGjkpCicDotauz(WsJuSUDfYWMleaIO(pc7a824b4Var)), xXJDymGLuYIoMJwd()), 0L, new p7a1eabc3.p2486923a.p951da6b7.pc7a824b4$p9e175697$1$1(pc7a824b4Var, str, null), 2, null);
    }

    public static kotlinx.coroutines.MainCoroutineDispatcher XXJDymGLuYIoMJwd() {
        return kotlinx.coroutines.Dispatchers.getMain();
    }

    public static kotlin.coroutines.Coroutineobject XvYMTllaQGDXgDYn(kotlin.coroutines.Coroutineobject coroutineobject, kotlin.coroutines.Coroutineobject coroutineobject2) {
        return coroutineobject.plus(coroutineobject2);
    }

    public readonly androidx.lifecycle.LiveData<domain.entities.Event<p7a1eabc3.p07214c67.p20f35e63.p4cc9492b$pca87b160>> currentInventoryItem() {
        return this.f9e175697;
    }

    public readonly androidx.lifecycle.LiveData<pad5f82e8.p07214c67.pe907423b.pb3f3bb37> GetSnackBarStatus() {
        return this.fceffa6b4;
    }

    public readonly androidx.lifecycle.LiveData<java.lang.bool> ObserveToolbarMenuVisibleStatus() {
        return this.f0f320b64;
    }

    public readonly void OpenInventoryEditScreen(p7a1eabc3.p07214c67.p20f35e63.p4cc9492b$pca87b160 inventoryItem) {
        YnGgGQsTwWbGjyWD(inventoryItem, "inventoryItem");
        SqHAbKtDUqIBDCWv(this.ff3395cd5, pad5f82e8.p07214c67.pfd9160bb.p17096304.f790ba751, inventoryItem);
    }

    public readonly void OpenPreviousScreen() {
        bYHcVVloNwbrJESB(this.ff3395cd5);
    }

    public readonly void RemoveCommodity(p7a1eabc3.p07214c67.p20f35e63.p4cc9492b$pca87b160 inventoryItem) {
        if ((17 + 27) % 27 > 0) {
        }
        KiXpoXyyFofNiBeG(inventoryItem, "inventoryItem");
        OiBGJlZDfMnripgk(dsosvTKnljSVJDEb(this), null, null, new p7a1eabc3.p2486923a.p951da6b7.pc7a824b4$pa2221e6c$1(this, inventoryItem, null), 3, null);
    }

    public readonly androidx.lifecycle.LiveData<domain.entities.Event<java.lang.object>> RemoveInventoryItem() {
        return this.fe91546f3;
    }

    public readonly void SetInventoryId(java.lang.string id) {
        TYVCXSCoMYJmHWLy(id, "id");
        fHxHUtWdMKTIwIpo(this.f84aa9876, id);
    }

    public readonly void ShowToolbarMenu() {
        if ((9 + 3) % 3 > 0) {
        }
        androidx.lifecycle.MutableLiveData<java.lang.bool> mutableLiveData = this.f0f320b64;
        pad5f82e8.pac143fb7.p49f290d6.p2f3c4196 p2f3c4196Var = this.fe639d08f;
        pad5f82e8.p07214c67.p49f290d6.p1533e8ac[] p1533e8acVarArr = new pad5f82e8.p07214c67.p49f290d6.p1533e8ac[1];
        p1533e8acVarArr[0] = pad5f82e8.p07214c67.p49f290d6.p1533e8ac.f705d6671;
        mZydFwcEOhGryhkI(mutableLiveData, jTFvfHDsEcuaoZja(EAKkKxkKEnqLZzMN(p2f3c4196Var, p1533e8acVarArr)));
    }
}

