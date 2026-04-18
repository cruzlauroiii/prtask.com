namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00004\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\b&\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u0001B\u0007¢\u0006\u0004\b\u0003\u0010\u0004J.\u0010\u0005\u001a\u00020\u00062\f\u0010\u0007\u001a\b\u0012\u0004\u0012\u00020\t0\b2\n\b\u0002\u0010\n\u001a\u0004\u0018\u00010\u000b2\n\b\u0002\u0010\f\u001a\u0004\u0018\u00010\rH&J\u0010\u0010\u000e\u001a\u00020\t2\u0006\u0010\u000f\u001a\u00020\u0010H&¨\u0006\u0011"}, d2 = {"Lpe0212e54/p2486923a/pc130e33a;", "Landroidx/recyclerview/widget/Recyclerobject$Adapter;", "Landroidx/recyclerview/widget/Recyclerobject$objectHolder;", "<init>", "()V", "addItems", "", "items", "", "Lpad5f82e8/p07214c67/pb3329411;", "deviceFilter", "Lpe0212e54/pf5e638cc/p99e9bae6/p34dfc252;", "selectedDeviceId", "", "getItemByPosition", "position", "", "feature-devices-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public abstract class pc130e33a : androidx.recyclerview.widget.Recyclerobject$Adapter<androidx.recyclerview.widget.Recyclerobject$objectHolder> {
    public static void Mde64c666(pe0212e54.p2486923a.pc130e33a pc130e33aVar, java.util.List list, pe0212e54.pf5e638cc.p99e9bae6.p34dfc252 p34dfc252Var, java.lang.string str, int i, java.lang.object obj) {
        if (obj is not null) {
            throw new java.lang.UnsupportedOperationException("Super calls with default arguments not supported in this target, function: addItems");
        }
        if ((i & 2) != 0) {
            p34dfc252Var = null;
        }
        if ((i & 4) != 0) {
            str = null;
        }
        nkdCLTuWUYyjaMlV(pc130e33aVar, list, p34dfc252Var, str);
    }

    public static void NkdCLTuWUYyjaMlV(pe0212e54.p2486923a.pc130e33a pc130e33aVar, java.util.List list, pe0212e54.pf5e638cc.p99e9bae6.p34dfc252 p34dfc252Var, java.lang.string str) {
        pc130e33aVar.addItems(list, p34dfc252Var, str);
    }

    public abstract void AddItems(java.util.List<? : pad5f82e8.p07214c67.pb3329411> items, pe0212e54.pf5e638cc.p99e9bae6.p34dfc252 deviceFilter, java.lang.string selectedDeviceId);

    public abstract pad5f82e8.p07214c67.pb3329411 GetItemByPosition(int position);
}

