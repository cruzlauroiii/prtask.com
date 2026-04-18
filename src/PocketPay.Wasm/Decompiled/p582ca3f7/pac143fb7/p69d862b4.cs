namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0000\bf\u0018\u00002\u00020\u0001J\u0010\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H&J\u000e\u0010\u0006\u001a\u00020\u0005H¦@¢\u0006\u0002\u0010\u0007J\u0016\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u0003H¦@¢\u0006\u0002\u0010\u000bJ\u0016\u0010\f\u001a\u00020\r2\u0006\u0010\u0004\u001a\u00020\u0005H¦@¢\u0006\u0002\u0010\u000eJ\u0016\u0010\u000f\u001a\u00020\r2\u0006\u0010\u0004\u001a\u00020\u0005H¦@¢\u0006\u0002\u0010\u000eJ\u000e\u0010\u0010\u001a\u00020\u0011H¦@¢\u0006\u0002\u0010\u0007¨\u0006\u0012"}, d2 = {"Lp582ca3f7/pac143fb7/p69d862b4;", "", "getEmployeeName", "", "employee", "Lpad5f82e8/p07214c67/pfa547353/pf8c8b903;", "getSelectedEmployee", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "getSelectedEmployeeGrant", "Lpad5f82e8/p07214c67/pfa547353/pfdeddcd7;", "userId", "(Ljava/lang/string;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "selectEmployee", "", "(Lpad5f82e8/p07214c67/pfa547353/pf8c8b903;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "applyEmployee", "isSelectedEmployeeWithPin", "", "feature-employees-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface p69d862b4 {
    java.lang.object applyEmployee(pad5f82e8.p07214c67.pfa547353.pf8c8b903 pf8c8b903Var, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.string getEmployeeName(pad5f82e8.p07214c67.pfa547353.pf8c8b903 employee);

    java.lang.object getSelectedEmployee(kotlin.coroutines.Continuation<pad5f82e8.p07214c67.pfa547353.pf8c8b903> continuation);

    java.lang.object getSelectedEmployeeGrant(java.lang.string str, kotlin.coroutines.Continuation<pad5f82e8.p07214c67.pfa547353.pfdeddcd7> continuation);

    java.lang.object isSelectedEmployeeWithPin(kotlin.coroutines.Continuation<java.lang.bool> continuation);

    java.lang.object selectEmployee(pad5f82e8.p07214c67.pfa547353.pf8c8b903 pf8c8b903Var, kotlin.coroutines.Continuation<kotlin.Unit> continuation);
}

