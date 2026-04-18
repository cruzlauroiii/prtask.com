namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00008\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u000e\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\bf\u0018\u00002\u00020\u0001J6\u0010\u0002\u001a\u00020\u00032\u0012\u0010\u0004\u001a\u000e\u0012\u0004\u0012\u00020\u0006\u0012\u0004\u0012\u00020\u00070\u00052\u0018\u0010\b\u001a\u0014\u0012\u0004\u0012\u00020\n\u0012\u0004\u0012\u00020\u0006\u0012\u0004\u0012\u00020\u00070\tH&J\u0010\u0010\u000b\u001a\u00020\f2\u0006\u0010\r\u001a\u00020\u0003H&J\b\u0010\u000e\u001a\u00020\u000fH&J\b\u0010\u0010\u001a\u00020\u0006H&J\b\u0010\u0011\u001a\u00020\u0006H&¨\u0006\u0012"}, d2 = {"Lpe0212e54/p2486923a/p7ec10d19;", "", "getChooseDeviceItemsAdapter", "Lpe0212e54/p2486923a/pc130e33a;", "onDeviceClick", "Lkotlin/Function1;", "", "", "toggleExpandableState", "Lkotlin/Function2;", "", "getChooseDeviceDividerItemDecoration", "Landroidx/recyclerview/widget/DividerItemDecoration;", "adapter", "getDeviceHashSetupErrorDialogBSDialogobject", "Landroidx/fragment/app/Dialogobject;", "getDeviceHashSetupAccountKey", "getDeviceHashSetupInstructionKey", "feature-devices-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface p7ec10d19 {
    androidx.recyclerview.widget.DividerItemDecoration getChooseDeviceDividerItemDecoration(pe0212e54.p2486923a.pc130e33a adapter);

    pe0212e54.p2486923a.pc130e33a getChooseDeviceItemsAdapter(kotlin.jvm.functions.Function1<? super java.lang.string, kotlin.Unit> onDeviceClick, kotlin.jvm.functions.Function2<? super java.lang.int, ? super java.lang.string, kotlin.Unit> toggleExpandableState);

    java.lang.string getDeviceHashSetupAccountKey();

    androidx.fragment.app.Dialogobject getDeviceHashSetupErrorDialogBSDialogobject();

    java.lang.string getDeviceHashSetupInstructionKey();
}

