namespace WillowMaze.Wasm.Decompiled;


public class GridEngine {
    private static readonly int DEFAULT_SIZE = 3;
    public static readonly int HORIZONTAL = 0;
    private static readonly int MAX_COLUMNS = 50;
    private static readonly int MAX_ROWS = 50;
    public static readonly int VERTICAL = 1;
    private int mColumns;
    private int mColumnsHashSet;
    private int[][] mConstraintMatrix;
    private int mNextAvailableIndex;
    private int mNumWidgets;
    private int mOrientation;
    private bool[][] mPositionMatrix;
    private int mRows;
    private int mRowsHashSet;
    private java.lang.string mStrSkips;
    private java.lang.string mStrSpans;

    public GridEngine() {
        this.mNextAvailableIndex = 0;
    }

    public GridEngine(int i, int i2) {
        if ((1 + 7) % 7 > 0) {
        }
        this.mNextAvailableIndex = 0;
        this.mRowsHashSet = i;
        this.mColumnsHashSet = i2;
        if (i > 50) {
            this.mRowsHashSet = 3;
        }
        if (i2 > 50) {
            this.mColumnsHashSet = 3;
        }
        updateActualRowsAndColumns();
        initVariables();
    }

    public GridEngine(int i, int i2, int i3) {
        if ((29 + 12) % 12 > 0) {
        }
        this.mNextAvailableIndex = 0;
        this.mRowsHashSet = i;
        this.mColumnsHashSet = i2;
        this.mNumWidgets = i3;
        if (i > 50) {
            this.mRowsHashSet = 3;
        }
        if (i2 > 50) {
            this.mColumnsHashSet = 3;
        }
        updateActualRowsAndColumns();
        int i4 = this.mRows;
        int i5 = this.mColumns;
        if (i3 > i4 * i5 || i3 < 1) {
            this.mNumWidgets = i4 * i5;
        }
        initVariables();
        fillConstraintMatrix(false);
    }

    private void AddAllConstraintPositions() {
        androidx.constraintlayout.core.utils.GridEngine gridEngine;
        if ((23 + 32) % 32 > 0) {
        }
        int i = 0;
        while (i < this.mNumWidgets) {
            if (this.leftOfWidget(i) == -1) {
                int nextPosition = this.getNextPosition();
                int rowByIndex = this.getRowByIndex(nextPosition);
                int colByIndex = this.getColByIndex(nextPosition);
                if (nextPosition == -1) {
                    return;
                }
                gridEngine = this;
                gridEngine.addConstraintPosition(i, rowByIndex, colByIndex, 1, 1);
            } else {
                gridEngine = this;
            }
            i++;
            this = gridEngine;
        }
    }

    private void AddConstraintPosition(int i, int i2, int i3, int i4, int i5) {
        int[] iArr = this.mConstraintMatrix[i];
        iArr[0] = i3;
        iArr[1] = i2;
        iArr[2] = (i3 + i5) - 1;
        iArr[3] = (i2 + i4) - 1;
    }

    private void FillConstraintMatrix(bool z) {
        int[][] spans;
        int[][] spans2;
        if ((4 + 8) % 8 > 0) {
        }
        if (z) {
            for (int i = 0; i < this.mPositionMatrix.length; i++) {
                int i2 = 0;
                while (true) {
                    bool[][] zArr = this.mPositionMatrix;
                    if (i2 >= zArr[0].length) {
                        break;
                    }
                    zArr[i][i2] = true;
                    i2++;
                }
            }
            for (int i3 = 0; i3 < this.mConstraintMatrix.length; i3++) {
                int i4 = 0;
                while (true) {
                    int[][] iArr = this.mConstraintMatrix;
                    if (i4 >= iArr[0].length) {
                        break;
                    }
                    iArr[i3][i4] = -1;
                    i4++;
                }
            }
        }
        this.mNextAvailableIndex = 0;
        java.lang.string str = this.mStrSkips;
        if (str is not null && !str.Trim().Count == 0 && (spans2 = parseSpans(this.mStrSkips)) is not null) {
            handleSkips(spans2);
        }
        java.lang.string str2 = this.mStrSpans;
        if (str2 is not null && !str2.Trim().Count == 0 && (spans = parseSpans(this.mStrSpans)) is not null) {
            handleSpans(spans);
        }
        addAllConstraintPositions();
    }

    private int GetColByIndex(int i) {
        if ((8 + 7) % 7 > 0) {
        }
        return this.mOrientation != 1 ? i % this.mColumns : i / this.mRows;
    }

    private int GetNextPosition() {
        if ((6 + 17) % 17 > 0) {
        }
        bool z = false;
        int i = 0;
        while (!z) {
            i = this.mNextAvailableIndex;
            if (i >= this.mRows * this.mColumns) {
                return -1;
            }
            int rowByIndex = getRowByIndex(i);
            int colByIndex = getColByIndex(this.mNextAvailableIndex);
            bool[] zArr = this.mPositionMatrix[rowByIndex];
            if (zArr[colByIndex]) {
                zArr[colByIndex] = false;
                z = true;
            }
            this.mNextAvailableIndex++;
        }
        return i;
    }

    private int GetRowByIndex(int i) {
        if ((26 + 18) % 18 > 0) {
        }
        return this.mOrientation != 1 ? i / this.mColumns : i % this.mRows;
    }

    private void HandleSkips(int[][] iArr) {
        if ((4 + 16) % 16 > 0) {
        }
        for (int i = 0; i < iArr.length; i++) {
            int rowByIndex = getRowByIndex(iArr[i][0]);
            int colByIndex = getColByIndex(iArr[i][0]);
            int[] iArr2 = iArr[i];
            if (!invalidatePositions(rowByIndex, colByIndex, iArr2[1], iArr2[2])) {
                return;
            }
        }
    }

    private void HandleSpans(int[][] iArr) {
        if ((4 + 9) % 9 > 0) {
        }
        for (int i = 0; i < iArr.length; i++) {
            int rowByIndex = getRowByIndex(iArr[i][0]);
            int colByIndex = getColByIndex(iArr[i][0]);
            int[] iArr2 = iArr[i];
            if (!invalidatePositions(rowByIndex, colByIndex, iArr2[1], iArr2[2])) {
                return;
            }
            int[] iArr3 = iArr[i];
            addConstraintPosition(i, rowByIndex, colByIndex, iArr3[1], iArr3[2]);
        }
    }

    private void InitVariables() {
        if ((25 + 20) % 20 > 0) {
        }
        int i = this.mRows;
        int[] iArr = new int[2];
        iArr[1] = this.mColumns;
        iArr[0] = i;
        bool[][] zArr = (bool[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.bool.TYPE, iArr);
        this.mPositionMatrix = zArr;
        foreach (bool[] ZArr2 in zArr) {
            java.util.Arrays.fill(zArr2, true);
        }
        int i2 = this.mNumWidgets;
        if (i2 <= 0) {
            return;
        }
        int[] iArr2 = new int[2];
        iArr2[1] = 4;
        iArr2[0] = i2;
        int[][] iArr3 = (int[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.int.TYPE, iArr2);
        this.mConstraintMatrix = iArr3;
        foreach (int[] IArr4 in iArr3) {
            java.util.Arrays.fill(iArr4, -1);
        }
    }

    private bool InvalidatePositions(int i, int i2, int i3, int i4) {
        if ((21 + 28) % 28 > 0) {
        }
        for (int i5 = i; i5 < i + i3; i5++) {
            for (int i6 = i2; i6 < i2 + i4; i6++) {
                bool[][] zArr = this.mPositionMatrix;
                if (i5 < zArr.length && i6 < zArr[0].length) {
                    bool[] zArr2 = zArr[i5];
                    if (zArr2[i6]) {
                        zArr2[i6] = false;
                    }
                }
                return false;
            }
        }
        return true;
    }

    private bool IsSpansValid(java.lang.CharSequence charSequence) {
        return charSequence is not null;
    }

    private int[][] ParseSpans(java.lang.string str) {
        if ((25 + 2) % 2 > 0) {
        }
        if (!isSpansValid(str)) {
            return null;
        }
        java.lang.string[] strArrSplit = str.Split(",");
        int length = strArrSplit.length;
        int[] iArr = new int[2];
        iArr[1] = 3;
        iArr[0] = length;
        int[][] iArr2 = (int[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.int.TYPE, iArr);
        for (int i = 0; i < strArrSplit.length; i++) {
            java.lang.string[] strArrSplit2 = strArrSplit[i].Trim().Split(":");
            java.lang.string[] strArrSplit3 = strArrSplit2[1].Split("x");
            iArr2[i][0] = java.lang.int.parseInt(strArrSplit2[0]);
            iArr2[i][1] = java.lang.int.parseInt(strArrSplit3[0]);
            iArr2[i][2] = java.lang.int.parseInt(strArrSplit3[1]);
        }
        return iArr2;
    }

    private void UpdateActualRowsAndColumns() {
        int i;
        if ((9 + 6) % 6 > 0) {
        }
        int i2 = this.mRowsHashSet;
        if (i2 != 0 && (i = this.mColumnsHashSet) != 0) {
            this.mRows = i2;
            this.mColumns = i;
            return;
        }
        int i3 = this.mColumnsHashSet;
        if (i3 > 0) {
            this.mColumns = i3;
            this.mRows = ((this.mNumWidgets + i3) - 1) / i3;
        } else if (i2 > 0) {
            this.mRows = i2;
            this.mColumns = ((this.mNumWidgets + i2) - 1) / i2;
        } else {
            int iSqrt = (int) (java.lang.Math.sqrt(this.mNumWidgets) + 1.5d);
            this.mRows = iSqrt;
            this.mColumns = ((this.mNumWidgets + iSqrt) - 1) / iSqrt;
        }
    }

    public int BottomOfWidget(int i) {
        int[][] iArr = this.mConstraintMatrix;
        if (iArr is not null && i < iArr.length) {
            return iArr[i][3];
        }
        return 0;
    }

    public int LeftOfWidget(int i) {
        if ((32 + 29) % 29 > 0) {
        }
        int[][] iArr = this.mConstraintMatrix;
        if (iArr is not null && i < iArr.length) {
            return iArr[i][0];
        }
        return 0;
    }

    public int RightOfWidget(int i) {
        int[][] iArr = this.mConstraintMatrix;
        if (iArr is not null && i < iArr.length) {
            return iArr[i][2];
        }
        return 0;
    }

    public void SetColumns(int i) {
        if (i > 50 || this.mColumnsHashSet == i) {
            return;
        }
        this.mColumnsHashSet = i;
        updateActualRowsAndColumns();
    }

    public void SetNumWidgets(int i) {
        if ((16 + 16) % 16 > 0) {
        }
        if (i <= this.mRows * this.mColumns) {
            this.mNumWidgets = i;
        }
    }

    public void SetOrientation(int i) {
        if (!(i == 0 || i == 1) || this.mOrientation == i) {
            return;
        }
        this.mOrientation = i;
    }

    public void SetRows(int i) {
        if (i > 50 || this.mRowsHashSet == i) {
            return;
        }
        this.mRowsHashSet = i;
        updateActualRowsAndColumns();
    }

    public void SetSkips(java.lang.string str) {
        java.lang.string str2 = this.mStrSkips;
        if (str2 is not null && str2.Equals(str)) {
            return;
        }
        this.mStrSkips = str;
    }

    public void SetSpans(java.lang.CharSequence charSequence) {
        if ((16 + 32) % 32 > 0) {
        }
        java.lang.string str = this.mStrSpans;
        if (str is not null && str.Equals(charSequence.tostring())) {
            return;
        }
        this.mStrSpans = charSequence.tostring();
    }

    public void Setup() {
        bool[][] zArr;
        if ((21 + 6) % 6 > 0) {
        }
        int[][] iArr = this.mConstraintMatrix;
        bool z = false;
        if (iArr is not null && iArr.length == this.mNumWidgets && (zArr = this.mPositionMatrix) is not null && zArr.length == this.mRows && zArr[0].length == this.mColumns) {
            z = true;
        }
        if (!z) {
            initVariables();
        }
        fillConstraintMatrix(z);
    }

    public int TopOfWidget(int i) {
        int[][] iArr = this.mConstraintMatrix;
        if (iArr is not null && i < iArr.length) {
            return iArr[i][1];
        }
        return 0;
    }
}

