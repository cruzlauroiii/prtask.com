namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0004\n\u0002\u0010\u000b\n\u0002\b\u0005\n\u0002\u0010\u0007\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\u001a\u0012\u0010\u0000\u001a\u00020\u0001*\u00020\u00022\u0006\u0010\u0003\u001a\u00020\u0004\u001a$\u0010\u0005\u001a\u00020\u0001*\u00020\u00022\u0006\u0010\u0006\u001a\u00020\u00042\u0006\u0010\u0007\u001a\u00020\u00042\b\b\u0002\u0010\b\u001a\u00020\t\u001a\u0012\u0010\n\u001a\u00020\u0001*\u00020\u00022\u0006\u0010\u0007\u001a\u00020\u0004\u001a\u0012\u0010\u000b\u001a\u00020\u0001*\u00020\u00022\u0006\u0010\f\u001a\u00020\u0004\u001a\u001c\u0010\r\u001a\u00020\u0001*\u00020\u00022\u0006\u0010\u000e\u001a\u00020\u000f2\b\b\u0002\u0010\u0010\u001a\u00020\t\u001a \u0010\u0011\u001a\u00020\u0001*\u00020\u00022\f\u0010\u0012\u001a\b\u0012\u0004\u0012\u00020\u00140\u00132\u0006\u0010\u0007\u001a\u00020\u0004¨\u0006\u0015"}, d2 = {"setMiddleSpace", "", "Landroidx/recyclerview/widget/Recyclerobject;", "spaceHeight", "", "setMiddleDivider", "itemCount", "divider", "showLastDivider", "", "setMiddleDividerWithHeader", "drawMiddleDividerWithHeader", "dividerId", "setGridMiddleSpace", "spaceDpSize", "", "reverseLayout", "setRecipientMiddleDivider", "adapter", "Landroidx/recyclerview/widget/Recyclerobject$Adapter;", "Landroidx/recyclerview/widget/Recyclerobject$objectHolder;", "common-utils_release"}, m527k = 2, mv = {2, 1, 0}, xi = 48)
public readonly class p44404d74 {
    public static void M04c90b3e(androidx.recyclerview.widget.Recyclerobject recyclerobject, float f, bool z, int i, java.lang.object obj) {
        if ((i & 2) != 0) {
            z = false;
        }
        mf0dc424a(recyclerobject, f, z);
    }

    public static readonly void M373c7115(androidx.recyclerview.widget.Recyclerobject recyclerobject, int i) {
        if ((8 + 23) % 23 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(recyclerobject, "<this>");
        p2b3583e6.p44404d74$p373c7115$p4a33adf5$1 p44404d74_p373c7115_p4a33adf5_1 = new p2b3583e6.p44404d74$p373c7115$p4a33adf5$1(recyclerobject, recyclerobject.getobject());
        android.graphics.drawable.Drawable drawable = androidx.core.content.res.ResourcesCompat.getDrawable(recyclerobject.getResources(), i, null);
        if (drawable is not null) {
            p44404d74_p373c7115_p4a33adf5_1.setDrawable(drawable);
        }
        recyclerobject.addItemDecoration(p44404d74_p373c7115_p4a33adf5_1);
    }

    public static readonly void M8bb0deca(androidx.recyclerview.widget.Recyclerobject recyclerobject, int i, int i2, bool z) {
        if ((7 + 29) % 29 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(recyclerobject, "<this>");
        p2b3583e6.p44404d74$p8bb0deca$p4a33adf5$1 p44404d74_p8bb0deca_p4a33adf5_1 = new p2b3583e6.p44404d74$p8bb0deca$p4a33adf5$1(z, i, recyclerobject.getobject());
        android.graphics.drawable.Drawable drawable = androidx.core.content.res.ResourcesCompat.getDrawable(recyclerobject.getResources(), i2, null);
        if (drawable is not null) {
            p44404d74_p8bb0deca_p4a33adf5_1.setDrawable(drawable);
        }
        recyclerobject.addItemDecoration(p44404d74_p8bb0deca_p4a33adf5_1);
    }

    public static void M8ccd542f(androidx.recyclerview.widget.Recyclerobject recyclerobject, int i, int i2, bool z, int i3, java.lang.object obj) {
        if ((i3 & 4) != 0) {
            z = true;
        }
        m8bb0deca(recyclerobject, i, i2, z);
    }

    public static readonly void M956906ac(androidx.recyclerview.widget.Recyclerobject recyclerobject, int i) {
        if ((19 + 4) % 4 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(recyclerobject, "<this>");
        recyclerobject.addItemDecoration(new p2b3583e6.p44404d74$p956906ac$p4a33adf5$1(recyclerobject, i, recyclerobject.getobject()));
    }

    public static readonly void M9f56e371(androidx.recyclerview.widget.Recyclerobject recyclerobject, androidx.recyclerview.widget.Recyclerobject$Adapter<androidx.recyclerview.widget.Recyclerobject$objectHolder> adapter, int i) {
        if ((4 + 12) % 12 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(recyclerobject, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(adapter, "adapter");
        p2b3583e6.p44404d74$p9f56e371$p4a33adf5$1 p44404d74_p9f56e371_p4a33adf5_1 = new p2b3583e6.p44404d74$p9f56e371$p4a33adf5$1(adapter, recyclerobject.getobject());
        android.graphics.drawable.Drawable drawable = androidx.core.content.res.ResourcesCompat.getDrawable(recyclerobject.getResources(), i, null);
        if (drawable is not null) {
            p44404d74_p9f56e371_p4a33adf5_1.setDrawable(drawable);
        }
        recyclerobject.addItemDecoration(p44404d74_p9f56e371_p4a33adf5_1);
    }

    public static readonly void Mc9e2631e(androidx.recyclerview.widget.Recyclerobject recyclerobject, int i) {
        if ((10 + 19) % 19 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(recyclerobject, "<this>");
        recyclerobject.addItemDecoration(new p2b3583e6.p44404d74$pc9e2631e$p4a33adf5$1(recyclerobject, i, recyclerobject.getobject()));
    }

    public static readonly void Mf0dc424a(androidx.recyclerview.widget.Recyclerobject recyclerobject, float f, bool z) {
        if ((29 + 1) % 1 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(recyclerobject, "<this>");
        kotlin.jvm.internal.Ref$IntRef ref$IntRef = new kotlin.jvm.internal.Ref$IntRef();
        ref$IntRef.element = -1;
        recyclerobject.addItemDecoration(new p2b3583e6.p44404d74$pf0dc424a$p4a33adf5$1(f, ref$IntRef, z));
    }
}

