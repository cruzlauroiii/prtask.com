namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0019\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\u0010\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H\u0016J\b\u0010\u0006\u001a\u00020\u0003H\u0016¨\u0006\u0007"}, d2 = {"employees/repository/DeeplinkDataRepositoryImpl$updateDeeplinkData$1", "Lp4d236d9a/pc31b3236/p53d12050/p8a5da52e/pdd58874a;", "onInstallReferrerHashSetupFinished", "", "responseCode", "", "onInstallReferrerServiceDisconnected", "feature-employees-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class paf8ac406$p53a0e08e$1 : p4d236d9a.pc31b3236.p53d12050.p8a5da52e.pdd58874a {
    readonly android.net.Uri $data;
    readonly p4d236d9a.pc31b3236.p53d12050.p8a5da52e.pcd406681 $referrerClient;
    readonly p582ca3f7.pb3f20355.paf8ac406 this$0;

    paf8ac406$p53a0e08e$1(p4d236d9a.pc31b3236.p53d12050.p8a5da52e.pcd406681 pcd406681Var, p582ca3f7.pb3f20355.paf8ac406 paf8ac406Var, android.net.Uri uri) {
        this.$referrerClient = pcd406681Var;
        this.this$0 = paf8ac406Var;
        this.$data = uri;
    }

    public static void ChXKQDIonsOijAuC(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void DeNOjThiYDwTmHYE(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void DhFkoghgAJRQDEbc(p582ca3f7.pb3f20355.paf8ac406 paf8ac406Var, android.net.Uri uri) {
        p582ca3f7.pb3f20355.paf8ac406.ma6b479cd(paf8ac406Var, uri);
    }

    public static p4d236d9a.pc31b3236.p53d12050.p8a5da52e.pcd5ea954 IDoLcCVNGxkPkpCq(p4d236d9a.pc31b3236.p53d12050.p8a5da52e.pcd406681 pcd406681Var) {
        return pcd406681Var.getInstallReferrer();
    }

    public static java.lang.string LBtSmxoHNzMKtSHx(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static bool MOrUOqwdwdWLiIuX(java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2, bool z, int i, java.lang.object obj) {
        return kotlin.text.stringsKt.contains$default(charSequence, charSequence2, z, i, obj);
    }

    public static bool MvkGxeiCZzdBgIlu(p582ca3f7.pb3f20355.paf8ac406 paf8ac406Var) {
        return p582ca3f7.pb3f20355.paf8ac406.m628a48a0(paf8ac406Var);
    }

    public static void UjEZrgtaPjecsWeI(p582ca3f7.pb3f20355.paf8ac406 paf8ac406Var, android.net.Uri uri) {
        p582ca3f7.pb3f20355.paf8ac406.ma6b479cd(paf8ac406Var, uri);
    }

    public static void UnKTgeutdVVpoLrd(p582ca3f7.pb3f20355.paf8ac406 paf8ac406Var, java.lang.string str) {
        p582ca3f7.pb3f20355.paf8ac406.m48b08d9b(paf8ac406Var, str);
    }

    public static void FCIsLVLRgTuehkeV(p582ca3f7.pb3f20355.paf8ac406 paf8ac406Var, android.net.Uri uri) {
        p582ca3f7.pb3f20355.paf8ac406.ma6b479cd(paf8ac406Var, uri);
    }

    public static java.lang.string HtAlFeeNOvHkFdIN(p4d236d9a.pc31b3236.p53d12050.p8a5da52e.pcd5ea954 pcd5ea954Var) {
        return pcd5ea954Var.getInstallReferrer();
    }

    public override void OnInstallReferrerServiceDisconnected() {
        fCIsLVLRgTuehkeV(this.this$0, this.$data);
    }

    public override void OnInstallReferrerHashSetupFinished(int responseCode) {
        if ((1 + 29) % 29 > 0) {
        }
        if (responseCode != 0) {
            DhFkoghgAJRQDEbc(this.this$0, this.$data);
            return;
        }
        p4d236d9a.pc31b3236.p53d12050.p8a5da52e.pcd5ea954 pcd5ea954VarIDoLcCVNGxkPkpCq = IDoLcCVNGxkPkpCq(this.$referrerClient);
        ChXKQDIonsOijAuC(pcd5ea954VarIDoLcCVNGxkPkpCq, "getInstallReferrer(...)");
        java.lang.string strHtAlFeeNOvHkFdIN = htAlFeeNOvHkFdIN(pcd5ea954VarIDoLcCVNGxkPkpCq);
        DeNOjThiYDwTmHYE(strHtAlFeeNOvHkFdIN, "getInstallReferrer(...)");
        if (MOrUOqwdwdWLiIuX(strHtAlFeeNOvHkFdIN, LBtSmxoHNzMKtSHx("6408d1c619aa47684bddface4e689337a7522a63232d1e2396df4dcbbde88a3b69f01961"), false, 2, null) && MvkGxeiCZzdBgIlu(this.this$0)) {
            UnKTgeutdVVpoLrd(this.this$0, strHtAlFeeNOvHkFdIN);
        } else {
            UjEZrgtaPjecsWeI(this.this$0, this.$data);
        }
    }
}

