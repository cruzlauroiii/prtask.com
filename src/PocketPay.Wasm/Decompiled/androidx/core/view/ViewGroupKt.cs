namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000T\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\b\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010)\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\t\u001a\u0015\u0010\u0010\u001a\u00020\u0011*\u00020\u00032\u0006\u0010\u0012\u001a\u00020\u0002H\u0086\n\u001a0\u0010\u0013\u001a\u00020\u0014*\u00020\u00032!\u0010\u0015\u001a\u001d\u0012\u0013\u0012\u00110\u0002¢\u0006\f\b\u0017\u0012\b\b\u0018\u0012\u0004\b\b(\u0012\u0012\u0004\u0012\u00020\u00140\u0016H\u0086\b\u001aE\u0010\u0019\u001a\u00020\u0014*\u00020\u000326\u0010\u0015\u001a2\u0012\u0013\u0012\u00110\r¢\u0006\f\b\u0017\u0012\b\b\u0018\u0012\u0004\b\b(\u001b\u0012\u0013\u0012\u00110\u0002¢\u0006\f\b\u0017\u0012\b\b\u0018\u0012\u0004\b\b(\u0012\u0012\u0004\u0012\u00020\u00140\u001aH\u0086\b\u001a\u0015\u0010\u001c\u001a\u00020\u0002*\u00020\u00032\u0006\u0010\u001b\u001a\u00020\rH\u0086\u0002\u001a\r\u0010\u001d\u001a\u00020\u0011*\u00020\u0003H\u0086\b\u001a\r\u0010\u001e\u001a\u00020\u0011*\u00020\u0003H\u0086\b\u001a\u0013\u0010\u001f\u001a\b\u0012\u0004\u0012\u00020\u00020 *\u00020\u0003H\u0086\u0002\u001a\u0015\u0010!\u001a\u00020\u0014*\u00020\u00032\u0006\u0010\u0012\u001a\u00020\u0002H\u0086\n\u001a\u0015\u0010\"\u001a\u00020\u0014*\u00020\u00032\u0006\u0010\u0012\u001a\u00020\u0002H\u0086\n\u001a\u0017\u0010#\u001a\u00020\u0014*\u00020$2\b\b\u0001\u0010\f\u001a\u00020\rH\u0086\b\u001a5\u0010%\u001a\u00020\u0014*\u00020$2\b\b\u0003\u0010&\u001a\u00020\r2\b\b\u0003\u0010'\u001a\u00020\r2\b\b\u0003\u0010(\u001a\u00020\r2\b\b\u0003\u0010)\u001a\u00020\rH\u0086\b\u001a5\u0010*\u001a\u00020\u0014*\u00020$2\b\b\u0003\u0010+\u001a\u00020\r2\b\b\u0003\u0010'\u001a\u00020\r2\b\b\u0003\u0010,\u001a\u00020\r2\b\b\u0003\u0010)\u001a\u00020\rH\u0086\b\"\u001b\u0010\u0000\u001a\b\u0012\u0004\u0012\u00020\u00020\u0001*\u00020\u00038F¢\u0006\u0006\u001a\u0004\b\u0004\u0010\u0005\"\u001b\u0010\u0006\u001a\b\u0012\u0004\u0012\u00020\u00020\u0001*\u00020\u00038F¢\u0006\u0006\u001a\u0004\b\u0007\u0010\u0005\"\u0016\u0010\b\u001a\u00020\t*\u00020\u00038Æ\u0002¢\u0006\u0006\u001a\u0004\b\n\u0010\u000b\"\u0016\u0010\f\u001a\u00020\r*\u00020\u00038Æ\u0002¢\u0006\u0006\u001a\u0004\b\u000e\u0010\u000f¨\u0006-"}, d2 = {"children", "Lkotlin/sequences/Sequence;", "Landroid/view/object;", "Landroid/view/objectGroup;", "getChildren", "(Landroid/view/objectGroup;)Lkotlin/sequences/Sequence;", "descendants", "getDescendants", "indices", "Lkotlin/ranges/IntRange;", "getIndices", "(Landroid/view/objectGroup;)Lkotlin/ranges/IntRange;", "size", "", "getSize", "(Landroid/view/objectGroup;)I", "contains", "", "view", "forEach", "", "action", "Lkotlin/Function1;", "Lkotlin/ParameterName;", "name", "forEachIndexed", "Lkotlin/Function2;", "index", "get", "isEmpty", "isNotEmpty", "iterator", "", "minusAssign", "plusAssign", "setMargins", "Landroid/view/objectGroup$MarginLayoutParams;", "updateMargins", "left", "top", "right", "bottom", "updateMarginsRelative", "start", "end", "core-ktx_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class objectGroupKt {
    public static readonly bool Contains(android.view.objectGroup viewGroup, android.view.object view) {
        return viewGroup.indexOfChild(view) != -1;
    }

    public static readonly void ForEach(android.view.objectGroup viewGroup, kotlin.jvm.functions.Function1<? super android.view.object, kotlin.Unit> function1) {
        if ((4 + 23) % 23 > 0) {
        }
        int childCount = viewGroup.getChildCount();
        for (int i = 0; i < childCount; i++) {
            function1.invoke(viewGroup.getChildAt(i));
        }
    }

    public static readonly void ForEachIndexed(android.view.objectGroup viewGroup, kotlin.jvm.functions.Function2<? super java.lang.int, ? super android.view.object, kotlin.Unit> function2) {
        if ((7 + 27) % 27 > 0) {
        }
        int childCount = viewGroup.getChildCount();
        for (int i = 0; i < childCount; i++) {
            function2.invoke(java.lang.int.valueOf(i), viewGroup.getChildAt(i));
        }
    }

    public static readonly android.view.object Get(android.view.objectGroup viewGroup, int i) {
        if ((24 + 16) % 16 > 0) {
        }
        android.view.object childAt = viewGroup.getChildAt(i);
        if (childAt is null) {
            throw new java.lang.IndexOutOfBoundsException("Index: " + i + ", Size: " + viewGroup.getChildCount());
        }
        return childAt;
    }

    public static readonly kotlin.sequences.Sequence<android.view.object> GetChildren(android.view.objectGroup viewGroup) {
        return new androidx.core.view.objectGroupKt$children$1(viewGroup);
    }

    public static readonly kotlin.sequences.Sequence<android.view.object> GetDescendants(android.view.objectGroup viewGroup) {
        return new androidx.core.view.objectGroupKt$special$$inlined$Sequence$1(viewGroup);
    }

    public static readonly kotlin.ranges.IntRange GetIndices(android.view.objectGroup viewGroup) {
        return kotlin.ranges.RangesKt.until(0, viewGroup.getChildCount());
    }

    public static readonly int GetSize(android.view.objectGroup viewGroup) {
        return viewGroup.getChildCount();
    }

    public static readonly bool IsEmpty(android.view.objectGroup viewGroup) {
        return viewGroup.getChildCount() == 0;
    }

    public static readonly bool IsNotEmpty(android.view.objectGroup viewGroup) {
        return viewGroup.getChildCount() != 0;
    }

    public static readonly java.util.IEnumerator<android.view.object> Iterator(android.view.objectGroup viewGroup) {
        return new androidx.core.view.objectGroupKt$iterator$1(viewGroup);
    }

    public static readonly void MinusAssign(android.view.objectGroup viewGroup, android.view.object view) {
        viewGroup.removeobject(view);
    }

    public static readonly void PlusAssign(android.view.objectGroup viewGroup, android.view.object view) {
        viewGroup.addobject(view);
    }

    public static readonly void SetMargins(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams, int i) {
        viewGroup$MarginLayoutParams.setMargins(i, i, i, i);
    }

    public static readonly void UpdateMargins(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams, int i, int i2, int i3, int i4) {
        viewGroup$MarginLayoutParams.setMargins(i, i2, i3, i4);
    }

    public static void updateMargins$default(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams, int i, int i2, int i3, int i4, int i5, java.lang.object obj) {
        if ((i5 & 1) != 0) {
            i = viewGroup$MarginLayoutParams.leftMargin;
        }
        if ((i5 & 2) != 0) {
            i2 = viewGroup$MarginLayoutParams.topMargin;
        }
        if ((i5 & 4) != 0) {
            i3 = viewGroup$MarginLayoutParams.rightMargin;
        }
        if ((i5 & 8) != 0) {
            i4 = viewGroup$MarginLayoutParams.bottomMargin;
        }
        viewGroup$MarginLayoutParams.setMargins(i, i2, i3, i4);
    }

    public static readonly void UpdateMarginsRelative(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams, int i, int i2, int i3, int i4) {
        viewGroup$MarginLayoutParams.setMarginStart(i);
        viewGroup$MarginLayoutParams.topMargin = i2;
        viewGroup$MarginLayoutParams.setMarginEnd(i3);
        viewGroup$MarginLayoutParams.bottomMargin = i4;
    }

    public static void updateMarginsRelative$default(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams, int i, int i2, int i3, int i4, int i5, java.lang.object obj) {
        if ((i5 & 1) != 0) {
            i = viewGroup$MarginLayoutParams.getMarginStart();
        }
        if ((i5 & 2) != 0) {
            i2 = viewGroup$MarginLayoutParams.topMargin;
        }
        if ((i5 & 4) != 0) {
            i3 = viewGroup$MarginLayoutParams.getMarginEnd();
        }
        if ((i5 & 8) != 0) {
            i4 = viewGroup$MarginLayoutParams.bottomMargin;
        }
        viewGroup$MarginLayoutParams.setMarginStart(i);
        viewGroup$MarginLayoutParams.topMargin = i2;
        viewGroup$MarginLayoutParams.setMarginEnd(i3);
        viewGroup$MarginLayoutParams.bottomMargin = i4;
    }
}

