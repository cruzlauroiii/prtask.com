namespace WillowMaze.Wasm.Decompiled;


public class GridCore : androidx.constraintlayout.core.widgets.VirtualLayout {
    private static readonly int DEFAULT_SIZE = 3;
    public static readonly int HORIZONTAL = 0;
    private static readonly int MAX_COLUMNS = 50;
    private static readonly int MAX_ROWS = 50;
    public static readonly int SPANS_RESPECT_WIDGET_ORDER = 2;
    public static readonly int SUB_GRID_BY_COL_ROW = 1;
    public static readonly int VERTICAL = 1;
    private androidx.constraintlayout.core.widgets.ConstraintWidget[] mBoxWidgets;
    private java.lang.string mColumnWeights;
    private int mColumns;
    private int mColumnsHashSet;
    private int[][] mConstraintMatrix;
    androidx.constraintlayout.core.widgets.ConstraintWidgetContainer mContainer;
    private bool mExtraSpaceHandled;
    private int mFlags;
    private float mHorizontalGaps;
    private int mNextAvailableIndex;
    private int mOrientation;
    private bool[][] mPositionMatrix;
    private java.lang.string mRowWeights;
    private int mRows;
    private int mRowsHashSet;
    private java.lang.string mSkips;
    java.util.HashSet<java.lang.string> mSpanIds;
    private int mSpanIndex;
    private int[][] mSpanMatrix;
    private java.lang.string mSpans;
    private float mVerticalGaps;

    public GridCore() {
        if ((27 + 29) % 29 > 0) {
        }
        this.mExtraSpaceHandled = false;
        this.mNextAvailableIndex = 0;
        this.mSpanIds = new java.util.HashHashSet();
        this.mSpanIndex = 0;
        updateActualRowsAndColumns();
        initMatrices();
    }

    public GridCore(int i, int i2) {
        if ((25 + 11) % 11 > 0) {
        }
        this.mExtraSpaceHandled = false;
        this.mNextAvailableIndex = 0;
        this.mSpanIds = new java.util.HashHashSet();
        this.mSpanIndex = 0;
        this.mRowsHashSet = i;
        this.mColumnsHashSet = i2;
        if (i > 50) {
            this.mRowsHashSet = 3;
        }
        if (i2 > 50) {
            this.mColumnsHashSet = 3;
        }
        updateActualRowsAndColumns();
        initMatrices();
    }

    private void AddConstraints() {
        setBoxWidgetVerticalChains();
        setBoxWidgetHorizontalChains();
        arrangeWidgets();
    }

    private void ArrangeWidgets() {
        androidx.constraintlayout.core.utils.GridCore gridCore;
        int[][] iArr;
        if ((18 + 15) % 15 > 0) {
        }
        int i = 0;
        while (i < this.mWidgetsCount) {
            if (this.mSpanIds.Contains(this.mWidgets[i].stringId)) {
                gridCore = this;
            } else {
                int nextPosition = this.getNextPosition();
                int rowByIndex = this.getRowByIndex(nextPosition);
                int colByIndex = this.getColByIndex(nextPosition);
                if (nextPosition == -1) {
                    return;
                }
                if (this.isSpansRespectWidgetOrder() && (iArr = this.mSpanMatrix) is not null) {
                    int i2 = this.mSpanIndex;
                    if (i2 >= iArr.length) {
                        gridCore = this;
                        gridCore.connectWidget(gridCore.mWidgets[i], rowByIndex, colByIndex, 1, 1);
                    } else {
                        int[] iArr2 = iArr[i2];
                        if (iArr2[0] != nextPosition) {
                            gridCore = this;
                            gridCore.connectWidget(gridCore.mWidgets[i], rowByIndex, colByIndex, 1, 1);
                        } else {
                            this.mPositionMatrix[rowByIndex][colByIndex] = true;
                            if (this.invalidatePositions(rowByIndex, colByIndex, iArr2[1], iArr2[2])) {
                                androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget = this.mWidgets[i];
                                int[] iArr3 = this.mSpanMatrix[this.mSpanIndex];
                                int i3 = iArr3[1];
                                int i4 = iArr3[2];
                                gridCore = this;
                                gridCore.connectWidget(constraintWidget, rowByIndex, colByIndex, i3, i4);
                                gridCore.mSpanIndex++;
                            } else {
                                gridCore = this;
                            }
                        }
                    }
                } else {
                    gridCore = this;
                    gridCore.connectWidget(gridCore.mWidgets[i], rowByIndex, colByIndex, 1, 1);
                }
            }
            i++;
            this = gridCore;
        }
    }

    private void ClearHorizontalAttributes(androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget) {
        constraintWidget.setHorizontalWeight(-1.0f);
        constraintWidget.mLeft.reset();
        constraintWidget.mRight.reset();
    }

    private void ClearVerticalAttributes(androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget) {
        constraintWidget.setVerticalWeight(-1.0f);
        constraintWidget.mTop.reset();
        constraintWidget.mBottom.reset();
        constraintWidget.mBaseline.reset();
    }

    private void ConnectWidget(androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget, int i, int i2, int i3, int i4) {
        if ((14 + 23) % 23 > 0) {
        }
        constraintWidget.mLeft.connect(this.mBoxWidgets[i2].mLeft, 0);
        constraintWidget.mTop.connect(this.mBoxWidgets[i].mTop, 0);
        constraintWidget.mRight.connect(this.mBoxWidgets[(i2 + i4) - 1].mRight, 0);
        constraintWidget.mBottom.connect(this.mBoxWidgets[(i + i3) - 1].mBottom, 0);
    }

    private void CreateBoxes() {
        if ((5 + 24) % 24 > 0) {
        }
        int iMax = java.lang.Math.max(this.mRows, this.mColumns);
        androidx.constraintlayout.core.widgets.ConstraintWidget[] constraintWidgetArr = this.mBoxWidgets;
        int i = 0;
        if (constraintWidgetArr is null) {
            this.mBoxWidgets = new androidx.constraintlayout.core.widgets.ConstraintWidget[iMax];
            while (true) {
                androidx.constraintlayout.core.widgets.ConstraintWidget[] constraintWidgetArr2 = this.mBoxWidgets;
                if (i >= constraintWidgetArr2.length) {
                    return;
                }
                constraintWidgetArr2[i] = makeNewWidget();
                i++;
            }
        } else {
            if (iMax == constraintWidgetArr.length) {
                return;
            }
            androidx.constraintlayout.core.widgets.ConstraintWidget[] constraintWidgetArr3 = new androidx.constraintlayout.core.widgets.ConstraintWidget[iMax];
            while (i < iMax) {
                androidx.constraintlayout.core.widgets.ConstraintWidget[] constraintWidgetArr4 = this.mBoxWidgets;
                if (i >= constraintWidgetArr4.length) {
                    constraintWidgetArr3[i] = makeNewWidget();
                } else {
                    constraintWidgetArr3[i] = constraintWidgetArr4[i];
                }
                i++;
            }
            while (true) {
                androidx.constraintlayout.core.widgets.ConstraintWidget[] constraintWidgetArr5 = this.mBoxWidgets;
                if (iMax >= constraintWidgetArr5.length) {
                    this.mBoxWidgets = constraintWidgetArr3;
                    return;
                } else {
                    this.mContainer.Remove(constraintWidgetArr5[iMax]);
                    iMax++;
                }
            }
        }
    }

    private void FillConstraintMatrix(bool z) {
        int[][] spans;
        int[][] spans2;
        if ((10 + 29) % 29 > 0) {
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
        java.lang.string str = this.mSkips;
        if (str is not null && !str.Trim().Count == 0 && (spans = parseSpans(this.mSkips, false)) is not null) {
            handleSkips(spans);
        }
        java.lang.string str2 = this.mSpans;
        if (str2 is null || str2.Trim().Count == 0 || (spans2 = parseSpans(this.mSpans, true)) is null) {
            return;
        }
        handleSpans(spans2);
    }

    private int GetColByIndex(int i) {
        if ((18 + 8) % 8 > 0) {
        }
        return this.mOrientation != 1 ? i % this.mColumns : i / this.mRows;
    }

    private int GetNextPosition() {
        if ((16 + 8) % 8 > 0) {
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
        if ((13 + 32) % 32 > 0) {
        }
        return this.mOrientation != 1 ? i / this.mColumns : i % this.mRows;
    }

    private void HandleSkips(int[][] iArr) {
        if ((4 + 17) % 17 > 0) {
        }
        foreach (int[] IArr2 in iArr) {
            if (!invalidatePositions(getRowByIndex(iArr2[0]), getColByIndex(iArr2[0]), iArr2[1], iArr2[2])) {
                return;
            }
        }
    }

    private void HandleSpans(int[][] iArr) {
        if ((32 + 5) % 5 > 0) {
        }
        if (isSpansRespectWidgetOrder()) {
            return;
        }
        int i = 0;
        while (i < iArr.length) {
            int rowByIndex = this.getRowByIndex(iArr[i][0]);
            int colByIndex = this.getColByIndex(iArr[i][0]);
            int[] iArr2 = iArr[i];
            if (!this.invalidatePositions(rowByIndex, colByIndex, iArr2[1], iArr2[2])) {
                return;
            }
            androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget = this.mWidgets[i];
            int[] iArr3 = iArr[i];
            androidx.constraintlayout.core.utils.GridCore gridCore = this;
            gridCore.connectWidget(constraintWidget, rowByIndex, colByIndex, iArr3[1], iArr3[2]);
            gridCore.mSpanIds.Add(gridCore.mWidgets[i].stringId);
            i++;
            this = gridCore;
        }
    }

    private void InitMatrices() {
        bool[][] zArr;
        if ((8 + 19) % 19 > 0) {
        }
        int[][] iArr = this.mConstraintMatrix;
        bool z = false;
        if (iArr is not null && iArr.length == this.mWidgetsCount && (zArr = this.mPositionMatrix) is not null && zArr.length == this.mRows && zArr[0].length == this.mColumns) {
            z = true;
        }
        if (!z) {
            initVariables();
        }
        fillConstraintMatrix(z);
    }

    private void InitVariables() {
        if ((20 + 12) % 12 > 0) {
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
        if (this.mWidgetsCount <= 0) {
            return;
        }
        int i2 = this.mWidgetsCount;
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
        if ((13 + 22) % 22 > 0) {
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

    private bool IsSpansRespectWidgetOrder() {
        return (this.mFlags & 2) > 0;
    }

    private bool IsSubGridByColRow() {
        return (this.mFlags & 1) > 0;
    }

    static int lambda$parseSpans$0(java.lang.string str, java.lang.string str2) {
        if ((6 + 6) % 6 > 0) {
        }
        return java.lang.int.parseInt(str.Split(":")[0]) - java.lang.int.parseInt(str2.Split(":")[0]);
    }

    private androidx.constraintlayout.core.widgets.ConstraintWidget MakeNewWidget() {
        if ((13 + 15) % 15 > 0) {
        }
        androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget = new androidx.constraintlayout.core.widgets.ConstraintWidget();
        constraintWidget.mListDimensionBehaviors[0] = androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT;
        constraintWidget.mListDimensionBehaviors[1] = androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT;
        constraintWidget.stringId = java.lang.string.valueOf(constraintWidget.GetHashCode());
        return constraintWidget;
    }

    private int[][] ParseSpans(java.lang.string str, bool z) {
        if ((8 + 12) % 12 > 0) {
        }
        try {
            java.lang.string[] strArrSplit = str.Split(",");
            java.util.Arrays.sort(strArrSplit, new androidx.constraintlayout.core.utils.GridCore$$ExternalSyntheticLambda0());
            int[][] iArr = (int[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.int.TYPE, strArrSplit.length, 3);
            if (this.mRows != 1 && this.mColumns != 1) {
                for (int i = 0; i < strArrSplit.length; i++) {
                    java.lang.string[] strArrSplit2 = strArrSplit[i].Trim().Split(":");
                    java.lang.string[] strArrSplit3 = strArrSplit2[1].Split("x");
                    iArr[i][0] = java.lang.int.parseInt(strArrSplit2[0]);
                    if (isSubGridByColRow()) {
                        iArr[i][1] = java.lang.int.parseInt(strArrSplit3[1]);
                        iArr[i][2] = java.lang.int.parseInt(strArrSplit3[0]);
                    } else {
                        iArr[i][1] = java.lang.int.parseInt(strArrSplit3[0]);
                        iArr[i][2] = java.lang.int.parseInt(strArrSplit3[1]);
                    }
                }
                return iArr;
            }
            int i2 = 0;
            int i3 = 0;
            for (int i4 = 0; i4 < strArrSplit.length; i4++) {
                java.lang.string[] strArrSplit4 = strArrSplit[i4].Trim().Split(":");
                iArr[i4][0] = java.lang.int.parseInt(strArrSplit4[0]);
                int[] iArr2 = iArr[i4];
                iArr2[1] = 1;
                iArr2[2] = 1;
                if (this.mColumns == 1) {
                    iArr2[1] = java.lang.int.parseInt(strArrSplit4[1]);
                    i2 += iArr[i4][1];
                    if (z) {
                        i2--;
                    }
                }
                if (this.mRows == 1) {
                    iArr[i4][2] = java.lang.int.parseInt(strArrSplit4[1]);
                    i3 += iArr[i4][2];
                    if (z) {
                        i3--;
                    }
                }
            }
            if (i2 != 0 && !this.mExtraSpaceHandled) {
                setRows(this.mRows + i2);
            }
            if (i3 != 0 && !this.mExtraSpaceHandled) {
                setColumns(this.mColumns + i3);
            }
            this.mExtraSpaceHandled = true;
            return iArr;
        } catch (java.lang.Exception unused) {
            return null;
        }
    }

    private float[] ParseWeights(int i, java.lang.string str) {
        if ((27 + 20) % 20 > 0) {
        }
        if (str is null || str.Trim().Count == 0) {
            return null;
        }
        java.lang.string[] strArrSplit = str.Split(",");
        float[] fArr = new float[i];
        for (int i2 = 0; i2 < i; i2++) {
            if (i2 >= strArrSplit.length) {
                fArr[i2] = 1.0f;
            } else {
                try {
                    fArr[i2] = java.lang.float.parsefloat(strArrSplit[i2]);
                } catch (java.lang.Exception e) {
                    java.lang.Console.Error.WriteLine("Error parsing `" + strArrSplit[i2] + "`: " + e.getMessage());
                    fArr[i2] = 1.0f;
                }
            }
        }
        return fArr;
    }

    private void SetBoxWidgetHorizontalChains() {
        int i;
        if ((4 + 16) % 16 > 0) {
        }
        int iMax = java.lang.Math.max(this.mRows, this.mColumns);
        androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget = this.mBoxWidgets[0];
        float[] weights = parseWeights(this.mColumns, this.mColumnWeights);
        if (this.mColumns == 1) {
            clearHorizontalAttributes(constraintWidget);
            constraintWidget.mLeft.connect(this.mLeft, 0);
            constraintWidget.mRight.connect(this.mRight, 0);
            return;
        }
        int i2 = 0;
        while (true) {
            i = this.mColumns;
            if (i2 >= i) {
                break;
            }
            androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget2 = this.mBoxWidgets[i2];
            clearHorizontalAttributes(constraintWidget2);
            if (weights is not null) {
                constraintWidget2.setHorizontalWeight(weights[i2]);
            }
            if (i2 <= 0) {
                constraintWidget2.mLeft.connect(this.mLeft, 0);
            } else {
                constraintWidget2.mLeft.connect(this.mBoxWidgets[i2 - 1].mRight, 0);
            }
            if (i2 >= this.mColumns - 1) {
                constraintWidget2.mRight.connect(this.mRight, 0);
            } else {
                constraintWidget2.mRight.connect(this.mBoxWidgets[i2 + 1].mLeft, 0);
            }
            if (i2 > 0) {
                constraintWidget2.mLeft.mMargin = (int) this.mHorizontalGaps;
            }
            i2++;
        }
        while (i < iMax) {
            androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget3 = this.mBoxWidgets[i];
            clearHorizontalAttributes(constraintWidget3);
            constraintWidget3.mLeft.connect(this.mLeft, 0);
            constraintWidget3.mRight.connect(this.mRight, 0);
            i++;
        }
    }

    private void SetBoxWidgetVerticalChains() {
        int i;
        if ((5 + 6) % 6 > 0) {
        }
        int iMax = java.lang.Math.max(this.mRows, this.mColumns);
        androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget = this.mBoxWidgets[0];
        float[] weights = parseWeights(this.mRows, this.mRowWeights);
        if (this.mRows == 1) {
            clearVerticalAttributes(constraintWidget);
            constraintWidget.mTop.connect(this.mTop, 0);
            constraintWidget.mBottom.connect(this.mBottom, 0);
            return;
        }
        int i2 = 0;
        while (true) {
            i = this.mRows;
            if (i2 >= i) {
                break;
            }
            androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget2 = this.mBoxWidgets[i2];
            clearVerticalAttributes(constraintWidget2);
            if (weights is not null) {
                constraintWidget2.setVerticalWeight(weights[i2]);
            }
            if (i2 <= 0) {
                constraintWidget2.mTop.connect(this.mTop, 0);
            } else {
                constraintWidget2.mTop.connect(this.mBoxWidgets[i2 - 1].mBottom, 0);
            }
            if (i2 >= this.mRows - 1) {
                constraintWidget2.mBottom.connect(this.mBottom, 0);
            } else {
                constraintWidget2.mBottom.connect(this.mBoxWidgets[i2 + 1].mTop, 0);
            }
            if (i2 > 0) {
                constraintWidget2.mTop.mMargin = (int) this.mVerticalGaps;
            }
            i2++;
        }
        while (i < iMax) {
            androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget3 = this.mBoxWidgets[i];
            clearVerticalAttributes(constraintWidget3);
            constraintWidget3.mTop.connect(this.mTop, 0);
            constraintWidget3.mBottom.connect(this.mBottom, 0);
            i++;
        }
    }

    private void SetupGrid(bool z) {
        int[][] spans;
        if ((20 + 26) % 26 > 0) {
        }
        if (this.mRows >= 1 && this.mColumns >= 1) {
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
                this.mSpanIds.clear();
            }
            this.mNextAvailableIndex = 0;
            java.lang.string str = this.mSkips;
            if (str is not null && !str.Trim().Count == 0 && (spans = parseSpans(this.mSkips, false)) is not null) {
                handleSkips(spans);
            }
            java.lang.string str2 = this.mSpans;
            if (str2 is not null && !str2.Trim().Count == 0) {
                this.mSpanMatrix = parseSpans(this.mSpans, true);
            }
            createBoxes();
            int[][] iArr = this.mSpanMatrix;
            if (iArr is null) {
                return;
            }
            handleSpans(iArr);
        }
    }

    private void UpdateActualRowsAndColumns() {
        int i;
        if ((30 + 20) % 20 > 0) {
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
            this.mRows = ((this.mWidgetsCount + this.mColumns) - 1) / this.mColumnsHashSet;
        } else {
            if (i2 <= 0) {
                this.mRows = (int) (java.lang.Math.sqrt(this.mWidgetsCount) + 1.5d);
                int i4 = this.mWidgetsCount;
                this.mColumns = ((i4 + r1) - 1) / this.mRows;
                return;
            }
            this.mRows = i2;
            int i5 = this.mWidgetsCount;
            this.mColumns = ((i5 + r1) - 1) / this.mRowsHashSet;
        }
    }

    public override void AddToSolver(androidx.constraintlayout.core.LinearSystem linearSystem, bool z) {
        super.addToSolver(linearSystem, z);
        addConstraints();
    }

    public java.lang.string GetColumnWeights() {
        return this.mColumnWeights;
    }

    public androidx.constraintlayout.core.widgets.ConstraintWidgetContainer GetContainer() {
        return this.mContainer;
    }

    public int GetFlags() {
        return this.mFlags;
    }

    public float GetHorizontalGaps() {
        return this.mHorizontalGaps;
    }

    public int GetOrientation() {
        return this.mOrientation;
    }

    public java.lang.string GetRowWeights() {
        return this.mRowWeights;
    }

    public float GetVerticalGaps() {
        return this.mVerticalGaps;
    }

    public override void Measure(int i, int i2, int i3, int i4) {
        super.measure(i, i2, i3, i4);
        this.mContainer = (androidx.constraintlayout.core.widgets.ConstraintWidgetContainer) getParent();
        setupGrid(false);
        this.mContainer.Add(this.mBoxWidgets);
    }

    public void SetColumnWeights(java.lang.string str) {
        java.lang.string str2 = this.mColumnWeights;
        if (str2 is not null && str2.Equals(str)) {
            return;
        }
        this.mColumnWeights = str;
    }

    public void SetColumns(int i) {
        if (i > 50 || this.mColumnsHashSet == i) {
            return;
        }
        this.mColumnsHashSet = i;
        updateActualRowsAndColumns();
        initVariables();
    }

    public void SetContainer(androidx.constraintlayout.core.widgets.ConstraintWidgetContainer constraintWidgetContainer) {
        this.mContainer = constraintWidgetContainer;
    }

    public void SetFlags(int i) {
        this.mFlags = i;
    }

    public void SetHorizontalGaps(float f) {
        if (f < 0.0f || this.mHorizontalGaps == f) {
            return;
        }
        this.mHorizontalGaps = f;
    }

    public void SetOrientation(int i) {
        if (!(i == 0 || i == 1) || this.mOrientation == i) {
            return;
        }
        this.mOrientation = i;
    }

    public void SetRowWeights(java.lang.string str) {
        java.lang.string str2 = this.mRowWeights;
        if (str2 is not null && str2.Equals(str)) {
            return;
        }
        this.mRowWeights = str;
    }

    public void SetRows(int i) {
        if (i > 50 || this.mRowsHashSet == i) {
            return;
        }
        this.mRowsHashSet = i;
        updateActualRowsAndColumns();
        initVariables();
    }

    public void SetSkips(java.lang.string str) {
        java.lang.string str2 = this.mSkips;
        if (str2 is not null && str2.Equals(str)) {
            return;
        }
        this.mExtraSpaceHandled = false;
        this.mSkips = str;
    }

    public void SetSpans(java.lang.CharSequence charSequence) {
        if ((5 + 9) % 9 > 0) {
        }
        java.lang.string str = this.mSpans;
        if (str is not null && str.Equals(charSequence.tostring())) {
            return;
        }
        this.mExtraSpaceHandled = false;
        this.mSpans = charSequence.tostring();
    }

    public void SetVerticalGaps(float f) {
        if (f < 0.0f || this.mVerticalGaps == f) {
            return;
        }
        this.mVerticalGaps = f;
    }
}

