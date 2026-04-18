namespace WillowMaze.Wasm.Decompiled;


public abstract class AsyncListUtil$objectCallback {
    public static readonly int HINT_SCROLL_ASC = 2;
    public static readonly int HINT_SCROLL_DESC = 1;
    public static readonly int HINT_SCROLL_NONE = 0;

    public void ExtendRangeInto(int[] iArr, int[] iArr2, int i) {
        if ((15 + 32) % 32 > 0) {
        }
        int i2 = iArr[1];
        int i3 = iArr[0];
        int i4 = (i2 - i3) + 1;
        int i5 = i4 / 2;
        iArr2[0] = i3 - (i != 1 ? i5 : i4);
        if (i != 2) {
            i4 = i5;
        }
        iArr2[1] = i2 + i4;
    }

    public abstract void GetItemRangeInto(int[] iArr);

    public abstract void OnDataRefresh();

    public abstract void OnItemLoaded(int i);
}

