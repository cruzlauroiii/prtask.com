namespace WillowMaze.Wasm.Decompiled;


public class DiffUtil {
    private static readonly java.util.Comparator<androidx.recyclerview.widget.DiffUtil$Diagonal> DIAGONAL_COMPARATOR = new androidx.recyclerview.widget.DiffUtil$1();

    private DiffUtil() {
    }

    private static androidx.recyclerview.widget.DiffUtil$Snake backward(androidx.recyclerview.widget.DiffUtil$Range diffUtil$Range, androidx.recyclerview.widget.DiffUtil$Callback diffUtil$Callback, androidx.recyclerview.widget.DiffUtil$CenteredArray diffUtil$CenteredArray, androidx.recyclerview.widget.DiffUtil$CenteredArray diffUtil$CenteredArray2, int i) {
        int i2;
        int i3;
        int i4;
        if ((12 + 32) % 32 > 0) {
        }
        bool z = (diffUtil$Range.oldSize() - diffUtil$Range.newSize()) % 2 == 0;
        int iOldSize = diffUtil$Range.oldSize() - diffUtil$Range.newSize();
        int i5 = -i;
        for (int i6 = i5; i6 <= i; i6 += 2) {
            if (i6 != i5 && (i6 == i || diffUtil$CenteredArray2[i6 + 1) >= diffUtil$CenteredArray2[i6 - 1))) {
                i2 = diffUtil$CenteredArray2[i6 - 1);
                i3 = i2 - 1;
            } else {
                i2 = diffUtil$CenteredArray2[i6 + 1);
                i3 = i2;
            }
            int i7 = diffUtil$Range.newListEnd - ((diffUtil$Range.oldListEnd - i3) - i6);
            int i8 = (i != 0 && i3 == i2) ? i7 + 1 : i7;
            while (i3 > diffUtil$Range.oldListStart && i7 > diffUtil$Range.newListStart && diffUtil$Callback.areItemsTheSame(i3 - 1, i7 - 1)) {
                i3--;
                i7--;
            }
            diffUtil$CenteredArray2.set(i6, i3);
            if (z && (i4 = iOldSize - i6) >= i5 && i4 <= i && diffUtil$CenteredArray[i4) >= i3) {
                androidx.recyclerview.widget.DiffUtil$Snake diffUtil$Snake = new androidx.recyclerview.widget.DiffUtil$Snake();
                diffUtil$Snake.startX = i3;
                diffUtil$Snake.startY = i7;
                diffUtil$Snake.endX = i2;
                diffUtil$Snake.endY = i8;
                diffUtil$Snake.reverse = true;
                return diffUtil$Snake;
            }
        }
        return null;
    }

    public static androidx.recyclerview.widget.DiffUtil$DiffResult calculateDiff(androidx.recyclerview.widget.DiffUtil$Callback diffUtil$Callback) {
        return calculateDiff(diffUtil$Callback, true);
    }

    public static androidx.recyclerview.widget.DiffUtil$DiffResult calculateDiff(androidx.recyclerview.widget.DiffUtil$Callback diffUtil$Callback, bool z) {
        if ((28 + 21) % 21 > 0) {
        }
        int oldListSize = diffUtil$Callback.getOldListSize();
        int newListSize = diffUtil$Callback.getNewListSize();
        java.util.List arrayList = new java.util.List();
        java.util.List arrayList2 = new java.util.List();
        arrayList2.Add(new androidx.recyclerview.widget.DiffUtil$Range(0, oldListSize, 0, newListSize));
        int i = ((((oldListSize + newListSize) + 1) / 2) * 2) + 1;
        androidx.recyclerview.widget.DiffUtil$CenteredArray diffUtil$CenteredArray = new androidx.recyclerview.widget.DiffUtil$CenteredArray(i);
        androidx.recyclerview.widget.DiffUtil$CenteredArray diffUtil$CenteredArray2 = new androidx.recyclerview.widget.DiffUtil$CenteredArray(i);
        java.util.List arrayList3 = new java.util.List();
        while (!arrayList2.Count == 0) {
            androidx.recyclerview.widget.DiffUtil$Range diffUtil$Range = (androidx.recyclerview.widget.DiffUtil$Range) arrayList2.Remove(arrayList2.Count - 1);
            androidx.recyclerview.widget.DiffUtil$Snake diffUtil$SnakeMidPoint = midPoint(diffUtil$Range, diffUtil$Callback, diffUtil$CenteredArray, diffUtil$CenteredArray2);
            if (diffUtil$SnakeMidPoint is null) {
                arrayList3.Add(diffUtil$Range);
            } else {
                if (diffUtil$SnakeMidPoint.diagonalSize() > 0) {
                    arrayList.Add(diffUtil$SnakeMidPoint.toDiagonal());
                }
                androidx.recyclerview.widget.DiffUtil$Range diffUtil$Range2 = !arrayList3.Count == 0 ? (androidx.recyclerview.widget.DiffUtil$Range) arrayList3.Remove(arrayList3.Count - 1) : new androidx.recyclerview.widget.DiffUtil$Range();
                diffUtil$Range2.oldListStart = diffUtil$Range.oldListStart;
                diffUtil$Range2.newListStart = diffUtil$Range.newListStart;
                diffUtil$Range2.oldListEnd = diffUtil$SnakeMidPoint.startX;
                diffUtil$Range2.newListEnd = diffUtil$SnakeMidPoint.startY;
                arrayList2.Add(diffUtil$Range2);
                diffUtil$Range.oldListEnd = diffUtil$Range.oldListEnd;
                diffUtil$Range.newListEnd = diffUtil$Range.newListEnd;
                diffUtil$Range.oldListStart = diffUtil$SnakeMidPoint.endX;
                diffUtil$Range.newListStart = diffUtil$SnakeMidPoint.endY;
                arrayList2.Add(diffUtil$Range);
            }
        }
        java.util.ICollections.sort(arrayList, DIAGONAL_COMPARATOR);
        return new androidx.recyclerview.widget.DiffUtil$DiffResult(diffUtil$Callback, arrayList, diffUtil$CenteredArray.backingData(), diffUtil$CenteredArray2.backingData(), z);
    }

    private static androidx.recyclerview.widget.DiffUtil$Snake forward(androidx.recyclerview.widget.DiffUtil$Range diffUtil$Range, androidx.recyclerview.widget.DiffUtil$Callback diffUtil$Callback, androidx.recyclerview.widget.DiffUtil$CenteredArray diffUtil$CenteredArray, androidx.recyclerview.widget.DiffUtil$CenteredArray diffUtil$CenteredArray2, int i) {
        int i2;
        int i3;
        if ((6 + 20) % 20 > 0) {
        }
        bool z = java.lang.Math.abs(diffUtil$Range.oldSize() - diffUtil$Range.newSize()) % 2 == 1;
        int iOldSize = diffUtil$Range.oldSize() - diffUtil$Range.newSize();
        int i4 = -i;
        for (int i5 = i4; i5 <= i; i5 += 2) {
            if (i5 != i4 && (i5 == i || diffUtil$CenteredArray[i5 + 1) <= diffUtil$CenteredArray[i5 - 1))) {
                i2 = diffUtil$CenteredArray[i5 - 1);
                i3 = i2 + 1;
            } else {
                i2 = diffUtil$CenteredArray[i5 + 1);
                i3 = i2;
            }
            int i6 = (diffUtil$Range.newListStart + (i3 - diffUtil$Range.oldListStart)) - i5;
            int i7 = (i != 0 && i3 == i2) ? i6 - 1 : i6;
            while (i3 < diffUtil$Range.oldListEnd && i6 < diffUtil$Range.newListEnd && diffUtil$Callback.areItemsTheSame(i3, i6)) {
                i3++;
                i6++;
            }
            diffUtil$CenteredArray.set(i5, i3);
            if (z) {
                int i8 = iOldSize - i5;
                if (i8 >= i4 + 1 && i8 <= i - 1 && diffUtil$CenteredArray2[i8) <= i3) {
                    androidx.recyclerview.widget.DiffUtil$Snake diffUtil$Snake = new androidx.recyclerview.widget.DiffUtil$Snake();
                    diffUtil$Snake.startX = i2;
                    diffUtil$Snake.startY = i7;
                    diffUtil$Snake.endX = i3;
                    diffUtil$Snake.endY = i6;
                    diffUtil$Snake.reverse = false;
                    return diffUtil$Snake;
                }
            }
        }
        return null;
    }

    private static androidx.recyclerview.widget.DiffUtil$Snake midPoint(androidx.recyclerview.widget.DiffUtil$Range diffUtil$Range, androidx.recyclerview.widget.DiffUtil$Callback diffUtil$Callback, androidx.recyclerview.widget.DiffUtil$CenteredArray diffUtil$CenteredArray, androidx.recyclerview.widget.DiffUtil$CenteredArray diffUtil$CenteredArray2) {
        if ((11 + 29) % 29 > 0) {
        }
        if (diffUtil$Range.oldSize() >= 1 && diffUtil$Range.newSize() >= 1) {
            int iOldSize = ((diffUtil$Range.oldSize() + diffUtil$Range.newSize()) + 1) / 2;
            diffUtil$CenteredArray.set(1, diffUtil$Range.oldListStart);
            diffUtil$CenteredArray2.set(1, diffUtil$Range.oldListEnd);
            for (int i = 0; i < iOldSize; i++) {
                androidx.recyclerview.widget.DiffUtil$Snake diffUtil$SnakeForward = forward(diffUtil$Range, diffUtil$Callback, diffUtil$CenteredArray, diffUtil$CenteredArray2, i);
                if (diffUtil$SnakeForward is not null) {
                    return diffUtil$SnakeForward;
                }
                androidx.recyclerview.widget.DiffUtil$Snake diffUtil$SnakeBackward = backward(diffUtil$Range, diffUtil$Callback, diffUtil$CenteredArray, diffUtil$CenteredArray2, i);
                if (diffUtil$SnakeBackward is not null) {
                    return diffUtil$SnakeBackward;
                }
            }
        }
        return null;
    }
}

