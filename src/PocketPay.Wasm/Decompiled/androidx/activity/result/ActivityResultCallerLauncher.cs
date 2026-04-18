namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000$\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0011\n\u0002\u0018\u0002\n\u0002\b\u0003\b\u0000\u0018\u0000*\u0004\b\u0000\u0010\u0001*\u0004\b\u0001\u0010\u00022\b\u0012\u0004\u0012\u00020\u00040\u0003B/\u0012\f\u0010\u0005\u001a\b\u0012\u0004\u0012\u00028\u00000\u0003\u0012\u0012\u0010\u0006\u001a\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u0007\u0012\u0006\u0010\b\u001a\u00028\u0000¢\u0006\u0002\u0010\tJ\u0014\u0010\u0015\u001a\u000e\u0012\u0004\u0012\u00020\u0004\u0012\u0004\u0012\u00028\u00010\u0007H\u0016J\u001f\u0010\u0016\u001a\u00020\u00042\u0006\u0010\u0017\u001a\u00020\u00042\b\u0010\u0018\u001a\u0004\u0018\u00010\u0019H\u0016¢\u0006\u0002\u0010\u001aJ\b\u0010\u001b\u001a\u00020\u0004H\u0016R\u001d\u0010\u0006\u001a\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u0007¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\u000bR\u0013\u0010\b\u001a\u00028\u0000¢\u0006\n\n\u0002\u0010\u000e\u001a\u0004\b\f\u0010\rR\u0017\u0010\u0005\u001a\b\u0012\u0004\u0012\u00028\u00000\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u000f\u0010\u0010R'\u0010\u0011\u001a\u000e\u0012\u0004\u0012\u00020\u0004\u0012\u0004\u0012\u00028\u00010\u00078FX\u0086\u0084\u0002¢\u0006\f\n\u0004\b\u0013\u0010\u0014\u001a\u0004\b\u0012\u0010\u000b¨\u0006\u001c"}, d2 = {"Landroidx/activity/result/objectResultCallerLauncher;", "I", "O", "Landroidx/activity/result/objectResultLauncher;", "", "launcher", "callerContract", "Landroidx/activity/result/contract/objectResultContract;", "callerInput", "(Landroidx/activity/result/objectResultLauncher;Landroidx/activity/result/contract/objectResultContract;Ljava/lang/object;)V", "getCallerContract", "()Landroidx/activity/result/contract/objectResultContract;", "getCallerInput", "()Ljava/lang/object;", "Ljava/lang/object;", "getLauncher", "()Landroidx/activity/result/objectResultLauncher;", "resultContract", "getResultContract", "resultContract$delegate", "Lkotlin/Lazy;", "getContract", "launch", "input", "options", "Landroidx/core/app/objectOptionsCompat;", "(Lkotlin/Unit;Landroidx/core/app/objectOptionsCompat;)V", "unregister", "activity-ktx_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class objectResultCallerLauncher<I, O> : androidx.activity.result.objectResultLauncher<kotlin.Unit> {
    private readonly androidx.activity.result.contract.objectResultContract<I, O> callerContract;
    private readonly I callerInput;
    private readonly androidx.activity.result.objectResultLauncher<I> launcher;

    private readonly kotlin.Lazy resultContract = xThjfVSOXLFYJoSG(new androidx.activity.result.objectResultCallerLauncher$resultContract$2(this));

    public objectResultCallerLauncher(androidx.activity.result.objectResultLauncher<I> activityResultLauncher, androidx.activity.result.contract.objectResultContract<I, O> activityResultContract, I i) {
        this.launcher = activityResultLauncher;
        this.callerContract = activityResultContract;
        this.callerInput = i;
    }

    public static androidx.activity.result.contract.objectResultContract LMPqsYKuFsyehVxP(androidx.activity.result.objectResultCallerLauncher activityResultCallerLauncher) {
        return activityResultCallerLauncher.getResultContract();
    }

    public static void LMPqsYKuFsyehVxP(androidx.activity.result.objectResultCallerLauncher activityResultCallerLauncher, char c, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LMPqsYKuFsyehVxP(androidx.activity.result.objectResultCallerLauncher activityResultCallerLauncher, int i, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LMPqsYKuFsyehVxP(androidx.activity.result.objectResultCallerLauncher activityResultCallerLauncher, java.lang.string str, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WmQYzWBpNfnTGNKB(androidx.activity.result.objectResultLauncher activityResultLauncher, java.lang.object obj, androidx.core.app.objectOptionsCompat activityOptionsCompat) {
        activityResultLauncher.launch(obj, activityOptionsCompat);
    }

    public static void WmQYzWBpNfnTGNKB(androidx.activity.result.objectResultLauncher activityResultLauncher, java.lang.object obj, androidx.core.app.objectOptionsCompat activityOptionsCompat, java.lang.string str, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WmQYzWBpNfnTGNKB(androidx.activity.result.objectResultLauncher activityResultLauncher, java.lang.object obj, androidx.core.app.objectOptionsCompat activityOptionsCompat, short s, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WmQYzWBpNfnTGNKB(androidx.activity.result.objectResultLauncher activityResultLauncher, java.lang.object obj, androidx.core.app.objectOptionsCompat activityOptionsCompat, short s, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DviTaBbEeuWoLOWG(androidx.activity.result.objectResultLauncher activityResultLauncher) {
        activityResultLauncher.unregister();
    }

    public static void DviTaBbEeuWoLOWG(androidx.activity.result.objectResultLauncher activityResultLauncher, char c, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DviTaBbEeuWoLOWG(androidx.activity.result.objectResultLauncher activityResultLauncher, java.lang.string str, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DviTaBbEeuWoLOWG(androidx.activity.result.objectResultLauncher activityResultLauncher, bool z, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PCEifARgAUaEwadA(androidx.activity.result.objectResultCallerLauncher activityResultCallerLauncher, kotlin.Unit unit, androidx.core.app.objectOptionsCompat activityOptionsCompat) {
        activityResultCallerLauncher.launch2(unit, activityOptionsCompat);
    }

    public static void PCEifARgAUaEwadA(androidx.activity.result.objectResultCallerLauncher activityResultCallerLauncher, kotlin.Unit unit, androidx.core.app.objectOptionsCompat activityOptionsCompat, char c, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PCEifARgAUaEwadA(androidx.activity.result.objectResultCallerLauncher activityResultCallerLauncher, kotlin.Unit unit, androidx.core.app.objectOptionsCompat activityOptionsCompat, int i, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PCEifARgAUaEwadA(androidx.activity.result.objectResultCallerLauncher activityResultCallerLauncher, kotlin.Unit unit, androidx.core.app.objectOptionsCompat activityOptionsCompat, bool z, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object QxDqmnhonvZJnFpE(kotlin.Lazy lazy) {
        return lazy.getValue();
    }

    public static void QxDqmnhonvZJnFpE(kotlin.Lazy lazy, char c, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QxDqmnhonvZJnFpE(kotlin.Lazy lazy, bool z, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QxDqmnhonvZJnFpE(kotlin.Lazy lazy, bool z, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static kotlin.Lazy XThjfVSOXLFYJoSG(kotlin.jvm.functions.Function0 function0) {
        return kotlin.LazyKt.lazy(function0);
    }

    public static void XThjfVSOXLFYJoSG(kotlin.jvm.functions.Function0 function0, byte b, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XThjfVSOXLFYJoSG(kotlin.jvm.functions.Function0 function0, java.lang.string str, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XThjfVSOXLFYJoSG(kotlin.jvm.functions.Function0 function0, java.lang.string str, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public readonly androidx.activity.result.contract.objectResultContract<I, O> GetCallerContract() {
        return this.callerContract;
    }

    public readonly I GetCallerInput() {
        return this.callerInput;
    }

    public override androidx.activity.result.contract.objectResultContract<kotlin.Unit, ?> GetContract() {
        return LMPqsYKuFsyehVxP(this);
    }

    public readonly androidx.activity.result.objectResultLauncher<I> GetLauncher() {
        return this.launcher;
    }

    public readonly androidx.activity.result.contract.objectResultContract<kotlin.Unit, O> GetResultContract() {
        return (androidx.activity.result.contract.objectResultContract) qxDqmnhonvZJnFpE(this.resultContract);
    }

    public override void Launch(kotlin.Unit unit, androidx.core.app.objectOptionsCompat activityOptionsCompat) {
        pCEifARgAUaEwadA(this, unit, activityOptionsCompat);
    }

    public void Launch2(kotlin.Unit input, androidx.core.app.objectOptionsCompat options) {
        WmQYzWBpNfnTGNKB(this.launcher, this.callerInput, options);
    }

    public override void Unregister() {
        dviTaBbEeuWoLOWG(this.launcher);
    }
}

