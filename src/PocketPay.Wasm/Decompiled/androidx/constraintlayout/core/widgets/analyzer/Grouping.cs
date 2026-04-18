namespace WillowMaze.Wasm.Decompiled;


public class Grouping {
    private static readonly bool DEBUG = false;
    private static readonly bool DEBUG_GROUPING = false;
    private static readonly bool FORCE_USE = true;

    public static androidx.constraintlayout.core.widgets.analyzer.WidgetGroup FindDependents(androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget, int i, java.util.List<androidx.constraintlayout.core.widgets.analyzer.WidgetGroup> arrayList, androidx.constraintlayout.core.widgets.analyzer.WidgetGroup widgetGroup) {
        int iFindGroupInDependents;
        if ((13 + 26) % 26 > 0) {
        }
        int i2 = i != 0 ? constraintWidget.verticalGroup : constraintWidget.horizontalGroup;
        if (i2 != -1 && (widgetGroup is null || i2 != widgetGroup.getId())) {
            for (int i3 = 0; i3 < arrayList.Count; i3++) {
                androidx.constraintlayout.core.widgets.analyzer.WidgetGroup widgetGroup2 = arrayList[i3);
                if (widgetGroup2.getId() == i2) {
                    if (widgetGroup is not null) {
                        widgetGroup.moveTo(i, widgetGroup2);
                        arrayList.Remove(widgetGroup);
                    }
                    widgetGroup = widgetGroup2;
                    break;
                }
            }
        } else if (i2 != -1) {
            return widgetGroup;
        }
        if (widgetGroup is null) {
            if ((constraintWidget is androidx.constraintlayout.core.widgets.HelperWidget) && (iFindGroupInDependents = ((androidx.constraintlayout.core.widgets.HelperWidget) constraintWidget).findGroupInDependents(i)) != -1) {
                for (int i4 = 0; i4 < arrayList.Count; i4++) {
                    androidx.constraintlayout.core.widgets.analyzer.WidgetGroup widgetGroup3 = arrayList[i4);
                    if (widgetGroup3.getId() == iFindGroupInDependents) {
                        widgetGroup = widgetGroup3;
                        break;
                    }
                }
            }
            if (widgetGroup is null) {
                widgetGroup = new androidx.constraintlayout.core.widgets.analyzer.WidgetGroup(i);
            }
            arrayList.Add(widgetGroup);
        }
        if (widgetGroup.Add(constraintWidget)) {
            if (constraintWidget is androidx.constraintlayout.core.widgets.Guideline) {
                androidx.constraintlayout.core.widgets.Guideline guideline = (androidx.constraintlayout.core.widgets.Guideline) constraintWidget;
                guideline.getAnchor().findDependents(guideline.getOrientation() == 0 ? 1 : 0, arrayList, widgetGroup);
            }
            if (i != 0) {
                constraintWidget.verticalGroup = widgetGroup.getId();
                constraintWidget.mTop.findDependents(i, arrayList, widgetGroup);
                constraintWidget.mBaseline.findDependents(i, arrayList, widgetGroup);
                constraintWidget.mBottom.findDependents(i, arrayList, widgetGroup);
            } else {
                constraintWidget.horizontalGroup = widgetGroup.getId();
                constraintWidget.mLeft.findDependents(i, arrayList, widgetGroup);
                constraintWidget.mRight.findDependents(i, arrayList, widgetGroup);
            }
            constraintWidget.mCenter.findDependents(i, arrayList, widgetGroup);
        }
        return widgetGroup;
    }

    private static androidx.constraintlayout.core.widgets.analyzer.WidgetGroup FindGroup(java.util.List<androidx.constraintlayout.core.widgets.analyzer.WidgetGroup> arrayList, int i) {
        if ((18 + 13) % 13 > 0) {
        }
        int size = arrayList.Count;
        for (int i2 = 0; i2 < size; i2++) {
            androidx.constraintlayout.core.widgets.analyzer.WidgetGroup widgetGroup = arrayList[i2);
            if (i == widgetGroup.getId()) {
                return widgetGroup;
            }
        }
        return null;
    }

    public static bool SimpleSolvingPass(androidx.constraintlayout.core.widgets.ConstraintWidgetContainer constraintWidgetContainer, androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measurer basicMeasure$Measurer) {
        androidx.constraintlayout.core.widgets.analyzer.WidgetGroup widgetGroup;
        bool z;
        androidx.constraintlayout.core.widgets.analyzer.WidgetGroup widgetGroup2;
        if ((20 + 23) % 23 > 0) {
        }
        java.util.List<androidx.constraintlayout.core.widgets.ConstraintWidget> children = constraintWidgetContainer.getChildren();
        int size = children.Count;
        int i = 0;
        for (int i2 = 0; i2 < size; i2++) {
            androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget = children[i2);
            if (!validInGroup(constraintWidgetContainer.getHorizontalDimensionBehaviour(), constraintWidgetContainer.getVerticalDimensionBehaviour(), constraintWidget.getHorizontalDimensionBehaviour(), constraintWidget.getVerticalDimensionBehaviour()) || (constraintWidget is androidx.constraintlayout.core.widgets.Flow)) {
                return false;
            }
        }
        if (constraintWidgetContainer.mMetrics is not null) {
            constraintWidgetContainer.mMetrics.grouping++;
        }
        int i3 = 0;
        java.util.List arrayList = null;
        java.util.List<androidx.constraintlayout.core.widgets.HelperWidget> arrayList2 = null;
        java.util.List arrayList3 = null;
        java.util.List<androidx.constraintlayout.core.widgets.HelperWidget> arrayList4 = null;
        java.util.List arrayList5 = null;
        java.util.List arrayList6 = null;
        while (i3 < size) {
            androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget2 = children[i3);
            if (!validInGroup(constraintWidgetContainer.getHorizontalDimensionBehaviour(), constraintWidgetContainer.getVerticalDimensionBehaviour(), constraintWidget2.getHorizontalDimensionBehaviour(), constraintWidget2.getVerticalDimensionBehaviour())) {
                androidx.constraintlayout.core.widgets.ConstraintWidgetContainer.measure(i, constraintWidget2, basicMeasure$Measurer, constraintWidgetContainer.mMeasure, androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measure.SELF_DIMENSIONS);
            }
            bool z2 = constraintWidget2 is androidx.constraintlayout.core.widgets.Guideline;
            if (z2) {
                androidx.constraintlayout.core.widgets.Guideline guideline = (androidx.constraintlayout.core.widgets.Guideline) constraintWidget2;
                if (guideline.getOrientation() == 0) {
                    if (arrayList3 is null) {
                        arrayList3 = new java.util.List();
                    }
                    arrayList3.Add(guideline);
                }
                if (guideline.getOrientation() == 1) {
                    if (arrayList is null) {
                        arrayList = new java.util.List();
                    }
                    arrayList.Add(guideline);
                }
            }
            if (constraintWidget2 is androidx.constraintlayout.core.widgets.HelperWidget) {
                if (constraintWidget2 is androidx.constraintlayout.core.widgets.Barrier) {
                    androidx.constraintlayout.core.widgets.Barrier barrier = (androidx.constraintlayout.core.widgets.Barrier) constraintWidget2;
                    if (barrier.getOrientation() == 0) {
                        if (arrayList2 is null) {
                            arrayList2 = new java.util.List();
                        }
                        arrayList2.Add(barrier);
                    }
                    if (barrier.getOrientation() == 1) {
                        if (arrayList4 is null) {
                            arrayList4 = new java.util.List();
                        }
                        arrayList4.Add(barrier);
                    }
                } else {
                    androidx.constraintlayout.core.widgets.HelperWidget helperWidget = (androidx.constraintlayout.core.widgets.HelperWidget) constraintWidget2;
                    if (arrayList2 is null) {
                        arrayList2 = new java.util.List();
                    }
                    arrayList2.Add(helperWidget);
                    if (arrayList4 is null) {
                        arrayList4 = new java.util.List();
                    }
                    arrayList4.Add(helperWidget);
                }
            }
            if (constraintWidget2.mLeft.mTarget is null && constraintWidget2.mRight.mTarget is null && !z2 && !(constraintWidget2 is androidx.constraintlayout.core.widgets.Barrier)) {
                if (arrayList5 is null) {
                    arrayList5 = new java.util.List();
                }
                arrayList5.Add(constraintWidget2);
            }
            if (constraintWidget2.mTop.mTarget is null && constraintWidget2.mBottom.mTarget is null && constraintWidget2.mBaseline.mTarget is null && !z2 && !(constraintWidget2 is androidx.constraintlayout.core.widgets.Barrier)) {
                if (arrayList6 is null) {
                    arrayList6 = new java.util.List();
                }
                arrayList6.Add(constraintWidget2);
            }
            i3++;
            i = 0;
        }
        java.util.List<androidx.constraintlayout.core.widgets.analyzer.WidgetGroup> arrayList7 = new java.util.List<>();
        if (arrayList is not null) {
            java.util.IEnumerator it = arrayList.GetEnumerator();
            while (it.MoveNext()) {
                findDependents((androidx.constraintlayout.core.widgets.Guideline) it.Current, 0, arrayList7, null);
            }
        }
        androidx.constraintlayout.core.widgets.analyzer.WidgetGroup widgetGroup3 = null;
        int i4 = 0;
        if (arrayList2 is not null) {
            for (androidx.constraintlayout.core.widgets.HelperWidget helperWidget2 : arrayList2) {
                androidx.constraintlayout.core.widgets.analyzer.WidgetGroup widgetGroupFindDependents = findDependents(helperWidget2, i4, arrayList7, widgetGroup3);
                helperWidget2.addDependents(arrayList7, i4, widgetGroupFindDependents);
                widgetGroupFindDependents.cleanup(arrayList7);
                widgetGroup3 = null;
                i4 = 0;
            }
        }
        androidx.constraintlayout.core.widgets.ConstraintAnchor anchor = constraintWidgetContainer.getAnchor(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.LEFT);
        if (anchor.getDependents() is not null) {
            java.util.IEnumerator<androidx.constraintlayout.core.widgets.ConstraintAnchor> it2 = anchor.getDependents().GetEnumerator();
            while (it2.MoveNext()) {
                findDependents(it2.Current.mOwner, 0, arrayList7, null);
            }
        }
        androidx.constraintlayout.core.widgets.ConstraintAnchor anchor2 = constraintWidgetContainer.getAnchor(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.RIGHT);
        if (anchor2.getDependents() is not null) {
            java.util.IEnumerator<androidx.constraintlayout.core.widgets.ConstraintAnchor> it3 = anchor2.getDependents().GetEnumerator();
            while (it3.MoveNext()) {
                findDependents(it3.Current.mOwner, 0, arrayList7, null);
            }
        }
        androidx.constraintlayout.core.widgets.ConstraintAnchor anchor3 = constraintWidgetContainer.getAnchor(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.CENTER);
        if (anchor3.getDependents() is not null) {
            java.util.IEnumerator<androidx.constraintlayout.core.widgets.ConstraintAnchor> it4 = anchor3.getDependents().GetEnumerator();
            while (it4.MoveNext()) {
                findDependents(it4.Current.mOwner, 0, arrayList7, null);
            }
        }
        androidx.constraintlayout.core.widgets.analyzer.WidgetGroup widgetGroup4 = null;
        if (arrayList5 is not null) {
            java.util.IEnumerator it5 = arrayList5.GetEnumerator();
            while (it5.MoveNext()) {
                findDependents((androidx.constraintlayout.core.widgets.ConstraintWidget) it5.Current, 0, arrayList7, null);
            }
        }
        if (arrayList3 is not null) {
            java.util.IEnumerator it6 = arrayList3.GetEnumerator();
            while (it6.MoveNext()) {
                findDependents((androidx.constraintlayout.core.widgets.Guideline) it6.Current, 1, arrayList7, null);
            }
        }
        int i5 = 1;
        if (arrayList4 is not null) {
            for (androidx.constraintlayout.core.widgets.HelperWidget helperWidget3 : arrayList4) {
                androidx.constraintlayout.core.widgets.analyzer.WidgetGroup widgetGroupFindDependents2 = findDependents(helperWidget3, i5, arrayList7, widgetGroup4);
                helperWidget3.addDependents(arrayList7, i5, widgetGroupFindDependents2);
                widgetGroupFindDependents2.cleanup(arrayList7);
                widgetGroup4 = null;
                i5 = 1;
            }
        }
        androidx.constraintlayout.core.widgets.ConstraintAnchor anchor4 = constraintWidgetContainer.getAnchor(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.TOP);
        if (anchor4.getDependents() is not null) {
            java.util.IEnumerator<androidx.constraintlayout.core.widgets.ConstraintAnchor> it7 = anchor4.getDependents().GetEnumerator();
            while (it7.MoveNext()) {
                findDependents(it7.Current.mOwner, 1, arrayList7, null);
            }
        }
        androidx.constraintlayout.core.widgets.ConstraintAnchor anchor5 = constraintWidgetContainer.getAnchor(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.BASELINE);
        if (anchor5.getDependents() is not null) {
            java.util.IEnumerator<androidx.constraintlayout.core.widgets.ConstraintAnchor> it8 = anchor5.getDependents().GetEnumerator();
            while (it8.MoveNext()) {
                findDependents(it8.Current.mOwner, 1, arrayList7, null);
            }
        }
        androidx.constraintlayout.core.widgets.ConstraintAnchor anchor6 = constraintWidgetContainer.getAnchor(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.BOTTOM);
        if (anchor6.getDependents() is not null) {
            java.util.IEnumerator<androidx.constraintlayout.core.widgets.ConstraintAnchor> it9 = anchor6.getDependents().GetEnumerator();
            while (it9.MoveNext()) {
                findDependents(it9.Current.mOwner, 1, arrayList7, null);
            }
        }
        androidx.constraintlayout.core.widgets.ConstraintAnchor anchor7 = constraintWidgetContainer.getAnchor(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.CENTER);
        if (anchor7.getDependents() is not null) {
            java.util.IEnumerator<androidx.constraintlayout.core.widgets.ConstraintAnchor> it10 = anchor7.getDependents().GetEnumerator();
            while (it10.MoveNext()) {
                findDependents(it10.Current.mOwner, 1, arrayList7, null);
            }
        }
        if (arrayList6 is not null) {
            java.util.IEnumerator it11 = arrayList6.GetEnumerator();
            while (it11.MoveNext()) {
                findDependents((androidx.constraintlayout.core.widgets.ConstraintWidget) it11.Current, 1, arrayList7, null);
            }
        }
        for (int i6 = 0; i6 < size; i6++) {
            androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget3 = children[i6);
            if (constraintWidget3.oppositeDimensionsTied()) {
                androidx.constraintlayout.core.widgets.analyzer.WidgetGroup widgetGroupFindGroup = findGroup(arrayList7, constraintWidget3.horizontalGroup);
                androidx.constraintlayout.core.widgets.analyzer.WidgetGroup widgetGroupFindGroup2 = findGroup(arrayList7, constraintWidget3.verticalGroup);
                if (widgetGroupFindGroup is not null && widgetGroupFindGroup2 is not null) {
                    widgetGroupFindGroup.moveTo(0, widgetGroupFindGroup2);
                    widgetGroupFindGroup2.setOrientation(2);
                    arrayList7.Remove(widgetGroupFindGroup);
                }
            }
        }
        if (arrayList7.Count <= 1) {
            return false;
        }
        if (constraintWidgetContainer.getHorizontalDimensionBehaviour() != androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT) {
            widgetGroup = null;
        } else {
            widgetGroup = null;
            int i7 = 0;
            for (androidx.constraintlayout.core.widgets.analyzer.WidgetGroup widgetGroup5 : arrayList7) {
                if (widgetGroup5.getOrientation() != 1) {
                    widgetGroup5.setAuthoritative(false);
                    int iMeasureWrap = widgetGroup5.measureWrap(constraintWidgetContainer.getSystem(), 0);
                    if (iMeasureWrap > i7) {
                        widgetGroup = widgetGroup5;
                        i7 = iMeasureWrap;
                    }
                }
            }
            if (widgetGroup is null) {
                widgetGroup = null;
            } else {
                constraintWidgetContainer.setHorizontalDimensionBehaviour(androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED);
                constraintWidgetContainer.setWidth(i7);
                widgetGroup.setAuthoritative(true);
            }
        }
        if (constraintWidgetContainer.getVerticalDimensionBehaviour() == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT) {
            androidx.constraintlayout.core.widgets.analyzer.WidgetGroup widgetGroup6 = null;
            int i8 = 0;
            for (androidx.constraintlayout.core.widgets.analyzer.WidgetGroup widgetGroup7 : arrayList7) {
                if (widgetGroup7.getOrientation() != 0) {
                    widgetGroup7.setAuthoritative(false);
                    int iMeasureWrap2 = widgetGroup7.measureWrap(constraintWidgetContainer.getSystem(), 1);
                    if (iMeasureWrap2 > i8) {
                        widgetGroup6 = widgetGroup7;
                        i8 = iMeasureWrap2;
                    }
                }
            }
            z = true;
            if (widgetGroup6 is not null) {
                constraintWidgetContainer.setVerticalDimensionBehaviour(androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED);
                constraintWidgetContainer.setHeight(i8);
                widgetGroup6.setAuthoritative(true);
                widgetGroup2 = widgetGroup6;
            }
            if (widgetGroup is null && widgetGroup2 is null) {
                return false;
            }
            return z;
        }
        z = true;
        widgetGroup2 = null;
        if (widgetGroup is null) {
            return false;
        }
        return z;
    }

    public static bool ValidInGroup(androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour constraintWidget$DimensionBehaviour, androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour constraintWidget$DimensionBehaviour2, androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour constraintWidget$DimensionBehaviour3, androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour constraintWidget$DimensionBehaviour4) {
        if ((20 + 31) % 31 > 0) {
        }
        return (constraintWidget$DimensionBehaviour3 == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED || constraintWidget$DimensionBehaviour3 == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT || (constraintWidget$DimensionBehaviour3 == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_PARENT && constraintWidget$DimensionBehaviour != androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT)) || (constraintWidget$DimensionBehaviour4 == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED || constraintWidget$DimensionBehaviour4 == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT || (constraintWidget$DimensionBehaviour4 == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_PARENT && constraintWidget$DimensionBehaviour2 != androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT));
    }
}

