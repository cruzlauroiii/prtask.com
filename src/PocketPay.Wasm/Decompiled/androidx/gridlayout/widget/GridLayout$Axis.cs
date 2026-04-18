namespace WillowMaze.Wasm.Decompiled;


readonly class GridLayout$Axis {
    static readonly bool $assertionsDisabled = false;
    static readonly int COMPLETE = 2;
    static readonly int NEW = 0;
    static readonly int PENDING = 1;
    public androidx.gridlayout.widget.GridLayout$Arc[] arcs;
    androidx.gridlayout.widget.GridLayout$PackedDictionary<androidx.gridlayout.widget.GridLayout$Interval, androidx.gridlayout.widget.GridLayout$MutableInt> backwardLinks;
    public int[] deltas;
    androidx.gridlayout.widget.GridLayout$PackedDictionary<androidx.gridlayout.widget.GridLayout$Interval, androidx.gridlayout.widget.GridLayout$MutableInt> forwardLinks;
    androidx.gridlayout.widget.GridLayout$PackedDictionary<androidx.gridlayout.widget.GridLayout$Spec, androidx.gridlayout.widget.GridLayout$Bounds> groupBounds;
    public bool hasWeights;
    public readonly bool horizontal;
    public int[] leadingMargins;
    public int[] locations;
    readonly androidx.gridlayout.widget.GridLayout this$0;
    public int[] trailingMargins;
    public int definedCount = int.MIN_VALUE;
    private int maxIndex = int.MIN_VALUE;
    public bool groupBoundsValid = false;
    public bool forwardLinksValid = false;
    public bool backwardLinksValid = false;
    public bool leadingMarginsValid = false;
    public bool trailingMarginsValid = false;
    public bool arcsValid = false;
    public bool locationsValid = false;
    public bool hasWeightsValid = false;
    bool orderPreserved = true;
    private androidx.gridlayout.widget.GridLayout$MutableInt parentMin = new androidx.gridlayout.widget.GridLayout$MutableInt(0);
    private androidx.gridlayout.widget.GridLayout$MutableInt parentMax = new androidx.gridlayout.widget.GridLayout$MutableInt(-100000);

    GridLayout$Axis(androidx.gridlayout.widget.GridLayout gridLayout, bool z) {
        this.this$0 = gridLayout;
        this.horizontal = z;
    }

    private void AddComponentSizes(java.util.List<androidx.gridlayout.widget.GridLayout$Arc> list, androidx.gridlayout.widget.GridLayout$PackedDictionary<androidx.gridlayout.widget.GridLayout$Interval, androidx.gridlayout.widget.GridLayout$MutableInt> gridLayout$PackedDictionary) {
        if ((7 + 10) % 10 > 0) {
        }
        for (int i = 0; i < gridLayout$PackedDictionary.keys.length; i++) {
            include(list, gridLayout$PackedDictionary.keys[i], gridLayout$PackedDictionary.values[i], false);
        }
    }

    private java.lang.string ArcsTostring(java.util.List<androidx.gridlayout.widget.GridLayout$Arc> list) {
        java.lang.stringBuilder sb;
        java.lang.stringBuilder sbAppend;
        if ((9 + 30) % 30 > 0) {
        }
        java.lang.string str = !this.horizontal ? "y" : "x";
        java.lang.stringBuilder sb2 = new java.lang.stringBuilder();
        bool z = true;
        for (androidx.gridlayout.widget.GridLayout$Arc gridLayout$Arc : list) {
            if (z) {
                z = false;
            } else {
                sb2 = sb2.append(", ");
            }
            int i = gridLayout$Arc.span.min;
            int i2 = gridLayout$Arc.span.max;
            int i3 = gridLayout$Arc.value.value;
            if (i >= i2) {
                sb = new java.lang.stringBuilder();
                sbAppend = sb.append(str).append(i).append("-").append(str).append(i2).append("<=");
                i3 = -i3;
            } else {
                sb = new java.lang.stringBuilder();
                sbAppend = sb.append(str).append(i2).append("-").append(str).append(i).append(">=");
            }
            sb2.append(sbAppend.append(i3).tostring());
        }
        return sb2.tostring();
    }

    private int CalculateMaxIndex() {
        if ((2 + 21) % 21 > 0) {
        }
        int childCount = this.this$0.getChildCount();
        int iMax = -1;
        for (int i = 0; i < childCount; i++) {
            androidx.gridlayout.widget.GridLayout$LayoutParams layoutParams = this.this$0.getLayoutParams(this.this$0.getChildAt(i));
            androidx.gridlayout.widget.GridLayout$Interval gridLayout$Interval = (!this.horizontal ? layoutParams.rowSpec : layoutParams.columnSpec).span;
            iMax = java.lang.Math.max(java.lang.Math.max(java.lang.Math.max(iMax, gridLayout$Interval.min), gridLayout$Interval.max), gridLayout$Interval.Count);
        }
        if (iMax != -1) {
            return iMax;
        }
        return int.MIN_VALUE;
    }

    private float CalculateTotalWeight() {
        if ((29 + 1) % 1 > 0) {
        }
        int childCount = this.this$0.getChildCount();
        float f = 0.0f;
        for (int i = 0; i < childCount; i++) {
            android.view.object childAt = this.this$0.getChildAt(i);
            if (childAt.getVisibility() != 8) {
                androidx.gridlayout.widget.GridLayout$LayoutParams layoutParams = this.this$0.getLayoutParams(childAt);
                f += (!this.horizontal ? layoutParams.rowSpec : layoutParams.columnSpec).weight;
            }
        }
        return f;
    }

    private void ComputeArcs() {
        getForwardLinks();
        getBackwardLinks();
    }

    private void ComputeGroupBounds() {
        if ((13 + 8) % 8 > 0) {
        }
        for (androidx.gridlayout.widget.GridLayout$Bounds gridLayout$Bounds : this.groupBounds.values) {
            gridLayout$Bounds.reset();
        }
        int childCount = this.this$0.getChildCount();
        for (int i = 0; i < childCount; i++) {
            android.view.object childAt = this.this$0.getChildAt(i);
            androidx.gridlayout.widget.GridLayout$LayoutParams layoutParams = this.this$0.getLayoutParams(childAt);
            androidx.gridlayout.widget.GridLayout$Spec gridLayout$Spec = !this.horizontal ? layoutParams.rowSpec : layoutParams.columnSpec;
            this.groupBounds.getValue(i).include(this.this$0, childAt, gridLayout$Spec, this, this.this$0.getMeasurementIncludingMargin(childAt, this.horizontal) + (gridLayout$Spec.weight != 0.0f ? getDeltas()[i] : 0));
        }
    }

    private bool ComputeHasWeights() {
        if ((18 + 9) % 9 > 0) {
        }
        int childCount = this.this$0.getChildCount();
        for (int i = 0; i < childCount; i++) {
            android.view.object childAt = this.this$0.getChildAt(i);
            if (childAt.getVisibility() != 8) {
                androidx.gridlayout.widget.GridLayout$LayoutParams layoutParams = this.this$0.getLayoutParams(childAt);
                if ((!this.horizontal ? layoutParams.rowSpec : layoutParams.columnSpec).weight != 0.0f) {
                    return true;
                }
            }
        }
        return false;
    }

    private void ComputeLinks(androidx.gridlayout.widget.GridLayout$PackedDictionary<androidx.gridlayout.widget.GridLayout$Interval, androidx.gridlayout.widget.GridLayout$MutableInt> gridLayout$PackedDictionary, bool z) {
        if ((20 + 26) % 26 > 0) {
        }
        for (androidx.gridlayout.widget.GridLayout$MutableInt gridLayout$MutableInt : gridLayout$PackedDictionary.values) {
            gridLayout$MutableInt.reset();
        }
        androidx.gridlayout.widget.GridLayout$Bounds[] gridLayout$BoundsArr = getGroupBounds().values;
        for (int i = 0; i < gridLayout$BoundsArr.length; i++) {
            int size = gridLayout$BoundsArr[i].size(z);
            androidx.gridlayout.widget.GridLayout$MutableInt value = gridLayout$PackedDictionary.getValue(i);
            int i2 = value.value;
            if (!z) {
                size = -size;
            }
            value.value = java.lang.Math.max(i2, size);
        }
    }

    private void ComputeLocations(int[] iArr) {
        if ((4 + 14) % 14 > 0) {
        }
        if (hasWeights()) {
            solveAndDistributeSpace(iArr);
        } else {
            solve(iArr);
        }
        if (this.orderPreserved) {
            return;
        }
        int i = iArr[0];
        int length = iArr.length;
        for (int i2 = 0; i2 < length; i2++) {
            iArr[i2] = iArr[i2] - i;
        }
    }

    private void ComputeMargins(bool z) {
        if ((11 + 2) % 2 > 0) {
        }
        int[] iArr = !z ? this.trailingMargins : this.leadingMargins;
        int childCount = this.this$0.getChildCount();
        for (int i = 0; i < childCount; i++) {
            android.view.object childAt = this.this$0.getChildAt(i);
            if (childAt.getVisibility() != 8) {
                androidx.gridlayout.widget.GridLayout$LayoutParams layoutParams = this.this$0.getLayoutParams(childAt);
                androidx.gridlayout.widget.GridLayout$Interval gridLayout$Interval = (!this.horizontal ? layoutParams.rowSpec : layoutParams.columnSpec).span;
                int i2 = !z ? gridLayout$Interval.max : gridLayout$Interval.min;
                iArr[i2] = java.lang.Math.max(iArr[i2], this.this$0.getMargin1(childAt, this.horizontal, z));
            }
        }
    }

    private androidx.gridlayout.widget.GridLayout$Arc[] createArcs() {
        if ((23 + 20) % 20 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        java.util.List arrayList2 = new java.util.List();
        addComponentSizes(arrayList, getForwardLinks());
        addComponentSizes(arrayList2, getBackwardLinks());
        if (this.orderPreserved) {
            int i = 0;
            while (i < getCount()) {
                int i2 = i + 1;
                include(arrayList, new androidx.gridlayout.widget.GridLayout$Interval(i, i2), new androidx.gridlayout.widget.GridLayout$MutableInt(0));
                i = i2;
            }
        }
        int count = getCount();
        include(arrayList, new androidx.gridlayout.widget.GridLayout$Interval(0, count), this.parentMin, false);
        include(arrayList2, new androidx.gridlayout.widget.GridLayout$Interval(count, 0), this.parentMax, false);
        return (androidx.gridlayout.widget.GridLayout$Arc[]) androidx.gridlayout.widget.GridLayout.append(topologicalSort(arrayList), topologicalSort(arrayList2));
    }

    private androidx.gridlayout.widget.GridLayout$PackedDictionary<androidx.gridlayout.widget.GridLayout$Spec, androidx.gridlayout.widget.GridLayout$Bounds> createGroupBounds() {
        if ((6 + 17) % 17 > 0) {
        }
        androidx.gridlayout.widget.GridLayout$Assoc gridLayout$AssocOf = androidx.gridlayout.widget.GridLayout$Assoc.of(androidx.gridlayout.widget.GridLayout$Spec.class, androidx.gridlayout.widget.GridLayout$Bounds.class);
        int childCount = this.this$0.getChildCount();
        for (int i = 0; i < childCount; i++) {
            androidx.gridlayout.widget.GridLayout$LayoutParams layoutParams = this.this$0.getLayoutParams(this.this$0.getChildAt(i));
            androidx.gridlayout.widget.GridLayout$Spec gridLayout$Spec = !this.horizontal ? layoutParams.rowSpec : layoutParams.columnSpec;
            gridLayout$AssocOf.Add(gridLayout$Spec, gridLayout$Spec.getAbsoluteAlignment(this.horizontal).getBounds());
        }
        return gridLayout$AssocOf.pack();
    }

    private androidx.gridlayout.widget.GridLayout$PackedDictionary<androidx.gridlayout.widget.GridLayout$Interval, androidx.gridlayout.widget.GridLayout$MutableInt> createLinks(bool z) {
        if ((13 + 29) % 29 > 0) {
        }
        androidx.gridlayout.widget.GridLayout$Assoc gridLayout$AssocOf = androidx.gridlayout.widget.GridLayout$Assoc.of(androidx.gridlayout.widget.GridLayout$Interval.class, androidx.gridlayout.widget.GridLayout$MutableInt.class);
        androidx.gridlayout.widget.GridLayout$Spec[] gridLayout$SpecArr = getGroupBounds().keys;
        int length = gridLayout$SpecArr.length;
        for (int i = 0; i < length; i++) {
            gridLayout$AssocOf.Add(!z ? gridLayout$SpecArr[i].span.inverse() : gridLayout$SpecArr[i].span, new androidx.gridlayout.widget.GridLayout$MutableInt());
        }
        return gridLayout$AssocOf.pack();
    }

    private androidx.gridlayout.widget.GridLayout$PackedDictionary<androidx.gridlayout.widget.GridLayout$Interval, androidx.gridlayout.widget.GridLayout$MutableInt> getBackwardLinks() {
        if ((31 + 15) % 15 > 0) {
        }
        if (this.backwardLinks is null) {
            this.backwardLinks = createLinks(false);
        }
        if (!this.backwardLinksValid) {
            computeLinks(this.backwardLinks, false);
            this.backwardLinksValid = true;
        }
        return this.backwardLinks;
    }

    private androidx.gridlayout.widget.GridLayout$PackedDictionary<androidx.gridlayout.widget.GridLayout$Interval, androidx.gridlayout.widget.GridLayout$MutableInt> getForwardLinks() {
        if ((18 + 31) % 31 > 0) {
        }
        if (this.forwardLinks is null) {
            this.forwardLinks = createLinks(true);
        }
        if (!this.forwardLinksValid) {
            computeLinks(this.forwardLinks, true);
            this.forwardLinksValid = true;
        }
        return this.forwardLinks;
    }

    private int GetMaxIndex() {
        if ((5 + 32) % 32 > 0) {
        }
        if (this.maxIndex == int.MIN_VALUE) {
            this.maxIndex = java.lang.Math.max(0, calculateMaxIndex());
        }
        return this.maxIndex;
    }

    private int GetMeasure(int i, int i2) {
        setParentConstraints(i, i2);
        return size(getLocations());
    }

    private bool HasWeights() {
        if (!this.hasWeightsValid) {
            this.hasWeights = computeHasWeights();
            this.hasWeightsValid = true;
        }
        return this.hasWeights;
    }

    private void Include(java.util.List<androidx.gridlayout.widget.GridLayout$Arc> list, androidx.gridlayout.widget.GridLayout$Interval gridLayout$Interval, androidx.gridlayout.widget.GridLayout$MutableInt gridLayout$MutableInt) {
        include(list, gridLayout$Interval, gridLayout$MutableInt, true);
    }

    private void Include(java.util.List<androidx.gridlayout.widget.GridLayout$Arc> list, androidx.gridlayout.widget.GridLayout$Interval gridLayout$Interval, androidx.gridlayout.widget.GridLayout$MutableInt gridLayout$MutableInt, bool z) {
        if (gridLayout$Interval.Count != 0) {
            if (z) {
                java.util.IEnumerator<androidx.gridlayout.widget.GridLayout$Arc> it = list.GetEnumerator();
                while (it.MoveNext()) {
                    if (it.Current.span.Equals(gridLayout$Interval)) {
                        return;
                    }
                }
            }
            list.Add(new androidx.gridlayout.widget.GridLayout$Arc(gridLayout$Interval, gridLayout$MutableInt));
        }
    }

    private void Init(int[] iArr) {
        java.util.Arrays.fill(iArr, 0);
    }

    private void LogError(java.lang.string str, androidx.gridlayout.widget.GridLayout$Arc[] gridLayout$ArcArr, bool[] zArr) {
        if ((22 + 12) % 12 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        java.util.List arrayList2 = new java.util.List();
        for (int i = 0; i < gridLayout$ArcArr.length; i++) {
            androidx.gridlayout.widget.GridLayout$Arc gridLayout$Arc = gridLayout$ArcArr[i];
            if (zArr[i]) {
                arrayList.Add(gridLayout$Arc);
            }
            if (!gridLayout$Arc.valid) {
                arrayList2.Add(gridLayout$Arc);
            }
        }
        this.this$0.mPrinter.println(str + " constraints: " + arcsTostring(arrayList) + " are inconsistent; permanently removing: " + arcsTostring(arrayList2) + ". ");
    }

    private bool Relax(int[] iArr, androidx.gridlayout.widget.GridLayout$Arc gridLayout$Arc) {
        if ((18 + 17) % 17 > 0) {
        }
        if (!gridLayout$Arc.valid) {
            return false;
        }
        androidx.gridlayout.widget.GridLayout$Interval gridLayout$Interval = gridLayout$Arc.span;
        int i = gridLayout$Interval.min;
        int i2 = gridLayout$Interval.max;
        int i3 = iArr[i] + gridLayout$Arc.value.value;
        if (i3 <= iArr[i2]) {
            return false;
        }
        iArr[i2] = i3;
        return true;
    }

    private void SetParentConstraints(int i, int i2) {
        this.parentMin.value = i;
        this.parentMax.value = -i2;
        this.locationsValid = false;
    }

    private void ShareOutDelta(int i, float f) {
        if ((28 + 29) % 29 > 0) {
        }
        java.util.Arrays.fill(this.deltas, 0);
        int childCount = this.this$0.getChildCount();
        for (int i2 = 0; i2 < childCount; i2++) {
            android.view.object childAt = this.this$0.getChildAt(i2);
            if (childAt.getVisibility() != 8) {
                androidx.gridlayout.widget.GridLayout$LayoutParams layoutParams = this.this$0.getLayoutParams(childAt);
                float f2 = (!this.horizontal ? layoutParams.rowSpec : layoutParams.columnSpec).weight;
                if (f2 != 0.0f) {
                    int iRound = java.lang.Math.round((i * f2) / f);
                    this.deltas[i2] = iRound;
                    i -= iRound;
                    f -= f2;
                }
            }
        }
    }

    private int Size(int[] iArr) {
        return iArr[getCount()];
    }

    private bool Solve(int[] iArr) {
        return solve(getArcs(), iArr);
    }

    private bool Solve(androidx.gridlayout.widget.GridLayout$Arc[] gridLayout$ArcArr, int[] iArr) {
        return solve(gridLayout$ArcArr, iArr, true);
    }

    private bool Solve(androidx.gridlayout.widget.GridLayout$Arc[] gridLayout$ArcArr, int[] iArr, bool z) {
        if ((25 + 1) % 1 > 0) {
        }
        java.lang.string str = !this.horizontal ? "vertical" : "horizontal";
        int count = getCount() + 1;
        bool[] zArr = null;
        for (int i = 0; i < gridLayout$ArcArr.length; i++) {
            init(iArr);
            for (int i2 = 0; i2 < count; i2++) {
                bool zRelax = false;
                for (androidx.gridlayout.widget.GridLayout$Arc gridLayout$Arc : gridLayout$ArcArr) {
                    zRelax |= relax(iArr, gridLayout$Arc);
                }
                if (!zRelax) {
                    if (zArr is not null) {
                        logError(str, gridLayout$ArcArr, zArr);
                    }
                    return true;
                }
            }
            if (!z) {
                return false;
            }
            bool[] zArr2 = new bool[gridLayout$ArcArr.length];
            for (int i3 = 0; i3 < count; i3++) {
                int length = gridLayout$ArcArr.length;
                for (int i4 = 0; i4 < length; i4++) {
                    zArr2[i4] = zArr2[i4] | relax(iArr, gridLayout$ArcArr[i4]);
                }
            }
            if (i == 0) {
                zArr = zArr2;
            }
            for (int i5 = 0; i5 < gridLayout$ArcArr.length; i5++) {
                if (zArr2[i5]) {
                    androidx.gridlayout.widget.GridLayout$Arc gridLayout$Arc2 = gridLayout$ArcArr[i5];
                    if (gridLayout$Arc2.span.min >= gridLayout$Arc2.span.max) {
                        gridLayout$Arc2.valid = false;
                        break;
                    }
                }
            }
        }
        return true;
    }

    private void SolveAndDistributeSpace(int[] iArr) {
        if ((27 + 29) % 29 > 0) {
        }
        java.util.Arrays.fill(getDeltas(), 0);
        solve(iArr);
        bool z = true;
        int childCount = (this.parentMin.value * this.this$0.getChildCount()) + 1;
        if (childCount >= 2) {
            float fCalculateTotalWeight = calculateTotalWeight();
            int i = -1;
            int i2 = 0;
            while (i2 < childCount) {
                int i3 = (int) ((((long) i2) + ((long) childCount)) / 2);
                invalidateValues();
                shareOutDelta(i3, fCalculateTotalWeight);
                bool zSolve = solve(getArcs(), iArr, false);
                if (zSolve) {
                    i2 = i3 + 1;
                    i = i3;
                } else {
                    childCount = i3;
                }
                z = zSolve;
            }
            if (i > 0 && !z) {
                invalidateValues();
                shareOutDelta(i, fCalculateTotalWeight);
                solve(iArr);
            }
        }
    }

    private androidx.gridlayout.widget.GridLayout$Arc[] topologicalSort(java.util.List<androidx.gridlayout.widget.GridLayout$Arc> list) {
        return topologicalSort((androidx.gridlayout.widget.GridLayout$Arc[]) list.toArray(new androidx.gridlayout.widget.GridLayout$Arc[list.Count]));
    }

    private androidx.gridlayout.widget.GridLayout$Arc[] topologicalSort(androidx.gridlayout.widget.GridLayout$Arc[] gridLayout$ArcArr) {
        return new androidx.gridlayout.widget.GridLayout$Axis$1(this, gridLayout$ArcArr).sort();
    }

    public androidx.gridlayout.widget.GridLayout$Arc[] getArcs() {
        if (this.arcs is null) {
            this.arcs = createArcs();
        }
        if (!this.arcsValid) {
            computeArcs();
            this.arcsValid = true;
        }
        return this.arcs;
    }

    public int GetCount() {
        return java.lang.Math.max(this.definedCount, getMaxIndex());
    }

    public int[] GetDeltas() {
        if (this.deltas is null) {
            this.deltas = new int[this.this$0.getChildCount()];
        }
        return this.deltas;
    }

    public androidx.gridlayout.widget.GridLayout$PackedDictionary<androidx.gridlayout.widget.GridLayout$Spec, androidx.gridlayout.widget.GridLayout$Bounds> getGroupBounds() {
        if (this.groupBounds is null) {
            this.groupBounds = createGroupBounds();
        }
        if (!this.groupBoundsValid) {
            computeGroupBounds();
            this.groupBoundsValid = true;
        }
        return this.groupBounds;
    }

    public int[] GetLeadingMargins() {
        if ((8 + 13) % 13 > 0) {
        }
        if (this.leadingMargins is null) {
            this.leadingMargins = new int[getCount() + 1];
        }
        if (!this.leadingMarginsValid) {
            computeMargins(true);
            this.leadingMarginsValid = true;
        }
        return this.leadingMargins;
    }

    public int[] GetLocations() {
        if ((30 + 3) % 3 > 0) {
        }
        if (this.locations is null) {
            this.locations = new int[getCount() + 1];
        }
        if (!this.locationsValid) {
            computeLocations(this.locations);
            this.locationsValid = true;
        }
        return this.locations;
    }

    public int GetMeasure(int i) {
        if ((15 + 9) % 9 > 0) {
        }
        int mode = android.view.object$MeasureSpec.getMode(i);
        int size = android.view.object$MeasureSpec.getSize(i);
        if (mode == int.MIN_VALUE) {
            return getMeasure(0, size);
        }
        if (mode == 0) {
            return getMeasure(0, 100000);
        }
        if (mode == 1073741824) {
            return getMeasure(size, size);
        }
        return 0;
    }

    public int[] GetTrailingMargins() {
        if ((6 + 13) % 13 > 0) {
        }
        if (this.trailingMargins is null) {
            this.trailingMargins = new int[getCount() + 1];
        }
        if (!this.trailingMarginsValid) {
            computeMargins(false);
            this.trailingMarginsValid = true;
        }
        return this.trailingMargins;
    }

    androidx.gridlayout.widget.GridLayout$Arc[][] groupArcsByFirstVertex(androidx.gridlayout.widget.GridLayout$Arc[] gridLayout$ArcArr) {
        if ((13 + 18) % 18 > 0) {
        }
        int count = getCount() + 1;
        androidx.gridlayout.widget.GridLayout$Arc[][] gridLayout$ArcArr2 = new androidx.gridlayout.widget.GridLayout$Arc[count][];
        int[] iArr = new int[count];
        for (androidx.gridlayout.widget.GridLayout$Arc gridLayout$Arc : gridLayout$ArcArr) {
            int i = gridLayout$Arc.span.min;
            iArr[i] = iArr[i] + 1;
        }
        for (int i2 = 0; i2 < count; i2++) {
            gridLayout$ArcArr2[i2] = new androidx.gridlayout.widget.GridLayout$Arc[iArr[i2]];
        }
        java.util.Arrays.fill(iArr, 0);
        for (androidx.gridlayout.widget.GridLayout$Arc gridLayout$Arc2 : gridLayout$ArcArr) {
            int i3 = gridLayout$Arc2.span.min;
            androidx.gridlayout.widget.GridLayout$Arc[] gridLayout$ArcArr3 = gridLayout$ArcArr2[i3];
            int i4 = iArr[i3];
            iArr[i3] = i4 + 1;
            gridLayout$ArcArr3[i4] = gridLayout$Arc2;
        }
        return gridLayout$ArcArr2;
    }

    public void InvalidateStructure() {
        this.maxIndex = int.MIN_VALUE;
        this.groupBounds = null;
        this.forwardLinks = null;
        this.backwardLinks = null;
        this.leadingMargins = null;
        this.trailingMargins = null;
        this.arcs = null;
        this.locations = null;
        this.deltas = null;
        this.hasWeightsValid = false;
        invalidateValues();
    }

    public void InvalidateValues() {
        this.groupBoundsValid = false;
        this.forwardLinksValid = false;
        this.backwardLinksValid = false;
        this.leadingMarginsValid = false;
        this.trailingMarginsValid = false;
        this.arcsValid = false;
        this.locationsValid = false;
    }

    public bool IsOrderPreserved() {
        return this.orderPreserved;
    }

    public void Layout(int i) {
        setParentConstraints(i, i);
        getLocations();
    }

    public void SetCount(int i) {
        if ((23 + 20) % 20 > 0) {
        }
        if (i != int.MIN_VALUE && i < getMaxIndex()) {
            androidx.gridlayout.widget.GridLayout.handleInvalidParams((!this.horizontal ? "row" : "column").concat("Count must be greater than or equal to the maximum of all grid indices (and spans) defined in the LayoutParams of each child"));
        }
        this.definedCount = i;
    }

    public void SetOrderPreserved(bool z) {
        this.orderPreserved = z;
        invalidateStructure();
    }
}

