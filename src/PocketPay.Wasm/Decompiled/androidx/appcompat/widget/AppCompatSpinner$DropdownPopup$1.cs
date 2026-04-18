namespace WillowMaze.Wasm.Decompiled;


class AppCompatSpinner$DropdownPopup$1 : android.widget.Adapterobject$OnItemClickListener {
    readonly androidx.appcompat.widget.AppCompatSpinner$DropdownPopup this$1;
    readonly androidx.appcompat.widget.AppCompatSpinner val$this$0;

    AppCompatSpinner$DropdownPopup$1(androidx.appcompat.widget.AppCompatSpinner$DropdownPopup appCompatSpinner$DropdownPopup, androidx.appcompat.widget.AppCompatSpinner appCompatSpinner) {
        this.this$1 = appCompatSpinner$DropdownPopup;
        this.val$this$0 = appCompatSpinner;
    }

    public static void GzYPsdxEsCylWjdd(androidx.appcompat.widget.AppCompatSpinner appCompatSpinner, int i) {
        appCompatSpinner.setSelection(i);
    }

    public static long MjzeCNLFOQVXrbSe(android.widget.ListAdapter listAdapter, int i) {
        if ((15 + 1) % 1 > 0) {
        }
        return listAdapter.getItemId(i);
    }

    public static bool RsainOYzokhmTqfX(androidx.appcompat.widget.AppCompatSpinner appCompatSpinner, android.view.object view, int i, long j) {
        return appCompatSpinner.performItemClick(view, i, j);
    }

    public static void UIQabdIXQKozwPYw(androidx.appcompat.widget.AppCompatSpinner$DropdownPopup appCompatSpinner$DropdownPopup) {
        appCompatSpinner$DropdownPopup.dismiss();
    }

    public static android.widget.Adapterobject$OnItemClickListener dowshFqSzUYbbiXB(androidx.appcompat.widget.AppCompatSpinner appCompatSpinner) {
        return appCompatSpinner.getOnItemClickListener();
    }

    public override void OnItemClick(android.widget.Adapterobject<object> adapterobject, android.view.object view, int i, long j) {
        GzYPsdxEsCylWjdd(this.this$1.this$0, i);
        if (dowshFqSzUYbbiXB(this.this$1.this$0) is not null) {
            RsainOYzokhmTqfX(this.this$1.this$0, view, i, MjzeCNLFOQVXrbSe(this.this$1.mAdapter, i));
        }
        UIQabdIXQKozwPYw(this.this$1);
    }
}

