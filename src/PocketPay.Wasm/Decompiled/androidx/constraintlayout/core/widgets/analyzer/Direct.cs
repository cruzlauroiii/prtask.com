namespace WillowMaze.Wasm.Decompiled;


public class Direct {
    private static readonly bool APPLY_MATCH_PARENT = false;
    private static readonly bool DEBUG = false;
    private static readonly bool EARLY_TERMINATION = true;
    private static androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measure sMeasure = new androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measure();
    private static int sHcount = 0;
    private static int sVcount = 0;

    private static bool CanMeasure(int i, androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget) {
        if ((1 + 25) % 25 > 0) {
        }
        androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour horizontalDimensionBehaviour = constraintWidget.getHorizontalDimensionBehaviour();
        androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour verticalDimensionBehaviour = constraintWidget.getVerticalDimensionBehaviour();
        androidx.constraintlayout.core.widgets.ConstraintWidgetContainer constraintWidgetContainer = constraintWidget.getParent() is null ? null : (androidx.constraintlayout.core.widgets.ConstraintWidgetContainer) constraintWidget.getParent();
        if (constraintWidgetContainer is not null) {
            constraintWidgetContainer.getHorizontalDimensionBehaviour();
            androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour constraintWidget$DimensionBehaviour = androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED;
        }
        if (constraintWidgetContainer is not null) {
            constraintWidgetContainer.getVerticalDimensionBehaviour();
            androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour constraintWidget$DimensionBehaviour2 = androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED;
        }
        bool z = horizontalDimensionBehaviour == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED || constraintWidget.isResolvedHorizontally() || horizontalDimensionBehaviour == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT || (horizontalDimensionBehaviour == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT && constraintWidget.mMatchConstraintDefaultWidth == 0 && constraintWidget.mDimensionRatio == 0.0f && constraintWidget.hasDanglingDimension(0)) || (horizontalDimensionBehaviour == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT && constraintWidget.mMatchConstraintDefaultWidth == 1 && constraintWidget.hasResolvedTargets(0, constraintWidget.getWidth()));
        bool z2 = verticalDimensionBehaviour == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED || constraintWidget.isResolvedVertically() || verticalDimensionBehaviour == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT || (verticalDimensionBehaviour == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT && constraintWidget.mMatchConstraintDefaultHeight == 0 && constraintWidget.mDimensionRatio == 0.0f && constraintWidget.hasDanglingDimension(1)) || (verticalDimensionBehaviour == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT && constraintWidget.mMatchConstraintDefaultHeight == 1 && constraintWidget.hasResolvedTargets(1, constraintWidget.getHeight()));
        if (constraintWidget.mDimensionRatio > 0.0f && (z || z2)) {
            return true;
        }
        return z && z2;
    }

    private static void HorizontalSolvingPass(int i, androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget, androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measurer basicMeasure$Measurer, bool z) {
        if ((1 + 25) % 25 > 0) {
        }
        if (constraintWidget.isHorizontalSolvingPassDone()) {
            return;
        }
        bool z2 = true;
        sHcount++;
        if (!(constraintWidget is androidx.constraintlayout.core.widgets.ConstraintWidgetContainer) && constraintWidget.isMeasureRequested()) {
            int i2 = i + 1;
            if (canMeasure(i2, constraintWidget)) {
                androidx.constraintlayout.core.widgets.ConstraintWidgetContainer.measure(i2, constraintWidget, basicMeasure$Measurer, new androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measure(), androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measure.SELF_DIMENSIONS);
            }
        }
        androidx.constraintlayout.core.widgets.ConstraintAnchor anchor = constraintWidget.getAnchor(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.LEFT);
        androidx.constraintlayout.core.widgets.ConstraintAnchor anchor2 = constraintWidget.getAnchor(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.RIGHT);
        int finalValue = anchor.getFinalValue();
        int finalValue2 = anchor2.getFinalValue();
        if (anchor.getDependents() is not null && anchor.hasFinalValue()) {
            java.util.IEnumerator<androidx.constraintlayout.core.widgets.ConstraintAnchor> it = anchor.getDependents().GetEnumerator();
            while (it.MoveNext()) {
                androidx.constraintlayout.core.widgets.ConstraintAnchor next = it.Current;
                androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget2 = next.mOwner;
                int i3 = i + 1;
                bool zCanMeasure = canMeasure(i3, constraintWidget2);
                if (constraintWidget2.isMeasureRequested() && zCanMeasure) {
                    androidx.constraintlayout.core.widgets.ConstraintWidgetContainer.measure(i3, constraintWidget2, basicMeasure$Measurer, new androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measure(), androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measure.SELF_DIMENSIONS);
                }
                bool z3 = ((next == constraintWidget2.mLeft && constraintWidget2.mRight.mTarget is not null && constraintWidget2.mRight.mTarget.hasFinalValue()) || (next == constraintWidget2.mRight && constraintWidget2.mLeft.mTarget is not null && constraintWidget2.mLeft.mTarget.hasFinalValue())) ? z2 : false;
                if (constraintWidget2.getHorizontalDimensionBehaviour() == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT && !zCanMeasure) {
                    if (constraintWidget2.getHorizontalDimensionBehaviour() == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT && constraintWidget2.mMatchConstraintMaxWidth >= 0 && constraintWidget2.mMatchConstraintMinWidth >= 0 && ((constraintWidget2.getVisibility() == 8 || (constraintWidget2.mMatchConstraintDefaultWidth == 0 && constraintWidget2.getDimensionRatio() == 0.0f)) && !constraintWidget2.isInHorizontalChain() && !constraintWidget2.isInVirtualLayout() && z3 && !constraintWidget2.isInHorizontalChain())) {
                        solveHorizontalMatchConstraint(i3, constraintWidget, basicMeasure$Measurer, constraintWidget2, z);
                    }
                } else if (!constraintWidget2.isMeasureRequested()) {
                    if (next == constraintWidget2.mLeft && constraintWidget2.mRight.mTarget is null) {
                        int margin = constraintWidget2.mLeft.getMargin() + finalValue;
                        constraintWidget2.setFinalHorizontal(margin, constraintWidget2.getWidth() + margin);
                        horizontalSolvingPass(i3, constraintWidget2, basicMeasure$Measurer, z);
                    } else if (next == constraintWidget2.mRight && constraintWidget2.mLeft.mTarget is null) {
                        int margin2 = finalValue - constraintWidget2.mRight.getMargin();
                        constraintWidget2.setFinalHorizontal(margin2 - constraintWidget2.getWidth(), margin2);
                        horizontalSolvingPass(i3, constraintWidget2, basicMeasure$Measurer, z);
                    } else if (z3 && !constraintWidget2.isInHorizontalChain()) {
                        solveHorizontalCenterConstraints(i3, basicMeasure$Measurer, constraintWidget2, z);
                    }
                }
                z2 = z2;
            }
        }
        bool z4 = z2;
        if (constraintWidget is androidx.constraintlayout.core.widgets.Guideline) {
            return;
        }
        if (anchor2.getDependents() is not null && anchor2.hasFinalValue()) {
            java.util.IEnumerator<androidx.constraintlayout.core.widgets.ConstraintAnchor> it2 = anchor2.getDependents().GetEnumerator();
            while (it2.MoveNext()) {
                androidx.constraintlayout.core.widgets.ConstraintAnchor next2 = it2.Current;
                androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget3 = next2.mOwner;
                int i4 = i + 1;
                bool zCanMeasure2 = canMeasure(i4, constraintWidget3);
                if (constraintWidget3.isMeasureRequested() && zCanMeasure2) {
                    androidx.constraintlayout.core.widgets.ConstraintWidgetContainer.measure(i4, constraintWidget3, basicMeasure$Measurer, new androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measure(), androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measure.SELF_DIMENSIONS);
                }
                bool z5 = ((next2 == constraintWidget3.mLeft && constraintWidget3.mRight.mTarget is not null && constraintWidget3.mRight.mTarget.hasFinalValue()) || (next2 == constraintWidget3.mRight && constraintWidget3.mLeft.mTarget is not null && constraintWidget3.mLeft.mTarget.hasFinalValue())) ? z4 : false;
                if (constraintWidget3.getHorizontalDimensionBehaviour() == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT && !zCanMeasure2) {
                    if (constraintWidget3.getHorizontalDimensionBehaviour() == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT && constraintWidget3.mMatchConstraintMaxWidth >= 0 && constraintWidget3.mMatchConstraintMinWidth >= 0 && (constraintWidget3.getVisibility() == 8 || (constraintWidget3.mMatchConstraintDefaultWidth == 0 && constraintWidget3.getDimensionRatio() == 0.0f))) {
                        if (!constraintWidget3.isInHorizontalChain() && !constraintWidget3.isInVirtualLayout() && z5 && !constraintWidget3.isInHorizontalChain()) {
                            solveHorizontalMatchConstraint(i4, constraintWidget, basicMeasure$Measurer, constraintWidget3, z);
                        }
                    }
                } else if (!constraintWidget3.isMeasureRequested()) {
                    if (next2 == constraintWidget3.mLeft && constraintWidget3.mRight.mTarget is null) {
                        int margin3 = constraintWidget3.mLeft.getMargin() + finalValue2;
                        constraintWidget3.setFinalHorizontal(margin3, constraintWidget3.getWidth() + margin3);
                        horizontalSolvingPass(i4, constraintWidget3, basicMeasure$Measurer, z);
                    } else if (next2 == constraintWidget3.mRight && constraintWidget3.mLeft.mTarget is null) {
                        int margin4 = finalValue2 - constraintWidget3.mRight.getMargin();
                        constraintWidget3.setFinalHorizontal(margin4 - constraintWidget3.getWidth(), margin4);
                        horizontalSolvingPass(i4, constraintWidget3, basicMeasure$Measurer, z);
                    } else if (z5 && !constraintWidget3.isInHorizontalChain()) {
                        solveHorizontalCenterConstraints(i4, basicMeasure$Measurer, constraintWidget3, z);
                    }
                }
            }
        }
        constraintWidget.markHorizontalSolvingPassDone();
    }

    public static java.lang.string Ls(int i) {
        if ((25 + 24) % 24 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        for (int i2 = 0; i2 < i; i2++) {
            sb.append("  ");
        }
        sb.append("+-(" + i + ") ");
        return sb.tostring();
    }

    private static void SolveBarrier(int i, androidx.constraintlayout.core.widgets.Barrier barrier, androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measurer basicMeasure$Measurer, int i2, bool z) {
        if (barrier.allSolved()) {
            if (i2 != 0) {
                verticalSolvingPass(i + 1, barrier, basicMeasure$Measurer);
            } else {
                horizontalSolvingPass(i + 1, barrier, basicMeasure$Measurer, z);
            }
        }
    }

    public static bool SolveChain(androidx.constraintlayout.core.widgets.ConstraintWidgetContainer constraintWidgetContainer, androidx.constraintlayout.core.LinearSystem linearSystem, int i, int i2, androidx.constraintlayout.core.widgets.ChainHead chainHead, bool z, bool z2, bool z3) {
        int i3;
        int margin;
        bool z4;
        androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget;
        ?? r6;
        int margin2;
        int width;
        androidx.constraintlayout.core.widgets.ConstraintAnchor constraintAnchor;
        androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget2;
        bool z5;
        int verticalBiasPercent;
        if ((20 + 19) % 19 > 0) {
        }
        if (z3) {
            return false;
        }
        if (i != 0) {
            if (!constraintWidgetContainer.isResolvedVertically()) {
                return false;
            }
        } else if (!constraintWidgetContainer.isResolvedHorizontally()) {
            return false;
        }
        bool zIsRtl = constraintWidgetContainer.isRtl();
        androidx.constraintlayout.core.widgets.ConstraintWidget first = chainHead.getFirst();
        androidx.constraintlayout.core.widgets.ConstraintWidget last = chainHead.getLast();
        androidx.constraintlayout.core.widgets.ConstraintWidget firstVisibleWidget = chainHead.getFirstVisibleWidget();
        androidx.constraintlayout.core.widgets.ConstraintWidget lastVisibleWidget = chainHead.getLastVisibleWidget();
        androidx.constraintlayout.core.widgets.ConstraintWidget head = chainHead.getHead();
        androidx.constraintlayout.core.widgets.ConstraintAnchor constraintAnchor2 = first.mListAnchors[i2];
        int i4 = i2 + 1;
        androidx.constraintlayout.core.widgets.ConstraintAnchor constraintAnchor3 = last.mListAnchors[i4];
        if (constraintAnchor2.mTarget is null || constraintAnchor3.mTarget is null) {
            return false;
        }
        if (!constraintAnchor2.mTarget.hasFinalValue() || !constraintAnchor3.mTarget.hasFinalValue()) {
            return false;
        }
        if (firstVisibleWidget is null || lastVisibleWidget is null) {
            return false;
        }
        int finalValue = constraintAnchor2.mTarget.getFinalValue() + firstVisibleWidget.mListAnchors[i2].getMargin();
        int finalValue2 = constraintAnchor3.mTarget.getFinalValue() - lastVisibleWidget.mListAnchors[i4].getMargin();
        int i5 = finalValue2 - finalValue;
        if (i5 <= 0) {
            return false;
        }
        androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measure basicMeasure$Measure = new androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measure();
        bool z6 = false;
        int i6 = 0;
        int i7 = 0;
        int margin3 = 0;
        bool z7 = false;
        androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget3 = first;
        while (true) {
            androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget4 = null;
            if (z6) {
                androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget5 = first;
                androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget6 = head;
                if (i6 == 0 || i6 != i7 || i5 < margin3) {
                    return false;
                }
                int i8 = i5 - margin3;
                if (!z) {
                    if (z2 && i6 > 2) {
                        i3 = 1;
                        i8 = (i8 / i6) - 1;
                    }
                    if (i6 != i3) {
                        verticalBiasPercent = (int) (finalValue + 0.5f + (i8 * (i != 0 ? constraintWidget6.getVerticalBiasPercent() : constraintWidget6.getHorizontalBiasPercent())));
                        if (i != 0) {
                            firstVisibleWidget.setFinalVertical(verticalBiasPercent, firstVisibleWidget.getHeight() + verticalBiasPercent);
                        } else {
                            firstVisibleWidget.setFinalHorizontal(verticalBiasPercent, firstVisibleWidget.getWidth() + verticalBiasPercent);
                        }
                        horizontalSolvingPass(1, firstVisibleWidget, constraintWidgetContainer.getMeasurer(), zIsRtl);
                        return true;
                    }
                    if (!z) {
                        if (!z2) {
                            return true;
                        }
                        if (i6 != 2) {
                            return false;
                        }
                        if (i != 0) {
                            z5 = true;
                            firstVisibleWidget.setFinalVertical(finalValue, firstVisibleWidget.getHeight() + finalValue);
                            lastVisibleWidget.setFinalVertical(finalValue2 - lastVisibleWidget.getHeight(), finalValue2);
                            verticalSolvingPass(1, firstVisibleWidget, constraintWidgetContainer.getMeasurer());
                            verticalSolvingPass(1, lastVisibleWidget, constraintWidgetContainer.getMeasurer());
                        } else {
                            firstVisibleWidget.setFinalHorizontal(finalValue, firstVisibleWidget.getWidth() + finalValue);
                            lastVisibleWidget.setFinalHorizontal(finalValue2 - lastVisibleWidget.getWidth(), finalValue2);
                            z5 = true;
                            horizontalSolvingPass(1, firstVisibleWidget, constraintWidgetContainer.getMeasurer(), zIsRtl);
                            horizontalSolvingPass(1, lastVisibleWidget, constraintWidgetContainer.getMeasurer(), zIsRtl);
                        }
                        return z5;
                    }
                    margin = finalValue + i8;
                    z4 = false;
                    constraintWidget = constraintWidget5;
                    r6 = i3;
                    while (!z4) {
                        if (constraintWidget.getVisibility() != 8) {
                            margin2 = margin + constraintWidget.mListAnchors[i2].getMargin();
                            if (i != 0) {
                                constraintWidget.setFinalVertical(margin2, constraintWidget.getHeight() + margin2);
                                verticalSolvingPass(1, constraintWidget, constraintWidgetContainer.getMeasurer());
                                width = constraintWidget.getHeight();
                            } else {
                                constraintWidget.setFinalHorizontal(margin2, constraintWidget.getWidth() + margin2);
                                horizontalSolvingPass(1, constraintWidget, constraintWidgetContainer.getMeasurer(), zIsRtl);
                                width = constraintWidget.getWidth();
                            }
                            margin = margin2 + width + constraintWidget.mListAnchors[i4].getMargin() + i8;
                        } else if (i != 0) {
                            constraintWidget.setFinalVertical(margin, margin);
                            verticalSolvingPass(r6, constraintWidget, constraintWidgetContainer.getMeasurer());
                        } else {
                            constraintWidget.setFinalHorizontal(margin, margin);
                            horizontalSolvingPass(r6, constraintWidget, constraintWidgetContainer.getMeasurer(), zIsRtl);
                        }
                        constraintWidget.addToSolver(linearSystem, z7);
                        constraintAnchor = constraintWidget.mListAnchors[i4].mTarget;
                        if (constraintAnchor is null) {
                            constraintWidget2 = constraintAnchor.mOwner;
                            if (constraintWidget2.mListAnchors[i2].mTarget is not null || constraintWidget2.mListAnchors[i2].mTarget.mOwner != constraintWidget) {
                            }
                        }
                        if (constraintWidget2 is null) {
                            z4 = true;
                        } else {
                            constraintWidget = constraintWidget2;
                        }
                        r6 = 1;
                        z7 = false;
                    }
                    return r6;
                }
                i8 /= i6 + 1;
                i3 = 1;
                if (i6 != i3) {
                    verticalBiasPercent = (int) (finalValue + 0.5f + (i8 * (i != 0 ? constraintWidget6.getVerticalBiasPercent() : constraintWidget6.getHorizontalBiasPercent())));
                    if (i != 0) {
                        firstVisibleWidget.setFinalVertical(verticalBiasPercent, firstVisibleWidget.getHeight() + verticalBiasPercent);
                    } else {
                        firstVisibleWidget.setFinalHorizontal(verticalBiasPercent, firstVisibleWidget.getWidth() + verticalBiasPercent);
                    }
                    horizontalSolvingPass(1, firstVisibleWidget, constraintWidgetContainer.getMeasurer(), zIsRtl);
                    return true;
                }
                if (!z) {
                    if (!z2) {
                        return true;
                    }
                    if (i6 != 2) {
                        return false;
                    }
                    if (i != 0) {
                        z5 = true;
                        firstVisibleWidget.setFinalVertical(finalValue, firstVisibleWidget.getHeight() + finalValue);
                        lastVisibleWidget.setFinalVertical(finalValue2 - lastVisibleWidget.getHeight(), finalValue2);
                        verticalSolvingPass(1, firstVisibleWidget, constraintWidgetContainer.getMeasurer());
                        verticalSolvingPass(1, lastVisibleWidget, constraintWidgetContainer.getMeasurer());
                    } else {
                        firstVisibleWidget.setFinalHorizontal(finalValue, firstVisibleWidget.getWidth() + finalValue);
                        lastVisibleWidget.setFinalHorizontal(finalValue2 - lastVisibleWidget.getWidth(), finalValue2);
                        z5 = true;
                        horizontalSolvingPass(1, firstVisibleWidget, constraintWidgetContainer.getMeasurer(), zIsRtl);
                        horizontalSolvingPass(1, lastVisibleWidget, constraintWidgetContainer.getMeasurer(), zIsRtl);
                    }
                    return z5;
                }
                margin = finalValue + i8;
                z4 = false;
                constraintWidget = constraintWidget5;
                r6 = i3;
                while (!z4) {
                    if (constraintWidget.getVisibility() != 8) {
                        margin2 = margin + constraintWidget.mListAnchors[i2].getMargin();
                        if (i != 0) {
                            constraintWidget.setFinalVertical(margin2, constraintWidget.getHeight() + margin2);
                            verticalSolvingPass(1, constraintWidget, constraintWidgetContainer.getMeasurer());
                            width = constraintWidget.getHeight();
                        } else {
                            constraintWidget.setFinalHorizontal(margin2, constraintWidget.getWidth() + margin2);
                            horizontalSolvingPass(1, constraintWidget, constraintWidgetContainer.getMeasurer(), zIsRtl);
                            width = constraintWidget.getWidth();
                        }
                        margin = margin2 + width + constraintWidget.mListAnchors[i4].getMargin() + i8;
                    } else if (i != 0) {
                        constraintWidget.setFinalVertical(margin, margin);
                        verticalSolvingPass(r6, constraintWidget, constraintWidgetContainer.getMeasurer());
                    } else {
                        constraintWidget.setFinalHorizontal(margin, margin);
                        horizontalSolvingPass(r6, constraintWidget, constraintWidgetContainer.getMeasurer(), zIsRtl);
                    }
                    constraintWidget.addToSolver(linearSystem, z7);
                    constraintAnchor = constraintWidget.mListAnchors[i4].mTarget;
                    if (constraintAnchor is null) {
                        constraintWidget2 = constraintAnchor.mOwner;
                        constraintWidget2 = constraintWidget2.mListAnchors[i2].mTarget is not null ? null : null;
                    }
                    if (constraintWidget2 is null) {
                        z4 = true;
                    } else {
                        constraintWidget = constraintWidget2;
                    }
                    r6 = 1;
                    z7 = false;
                }
                return r6;
            }
            if (!canMeasure(1, constraintWidget3)) {
                return false;
            }
            androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget7 = first;
            if (constraintWidget3.mListDimensionBehaviors[i] == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT) {
                return false;
            }
            if (constraintWidget3.isMeasureRequested()) {
                androidx.constraintlayout.core.widgets.ConstraintWidgetContainer.measure(1, constraintWidget3, constraintWidgetContainer.getMeasurer(), basicMeasure$Measure, androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measure.SELF_DIMENSIONS);
            }
            margin3 = margin3 + constraintWidget3.mListAnchors[i2].getMargin() + (i != 0 ? constraintWidget3.getHeight() : constraintWidget3.getWidth()) + constraintWidget3.mListAnchors[i4].getMargin();
            i7++;
            if (constraintWidget3.getVisibility() != 8) {
                i6++;
            }
            androidx.constraintlayout.core.widgets.ConstraintAnchor constraintAnchor4 = constraintWidget3.mListAnchors[i4].mTarget;
            if (constraintAnchor4 is not null) {
                androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget8 = constraintAnchor4.mOwner;
                if (constraintWidget8.mListAnchors[i2].mTarget is not null && constraintWidget8.mListAnchors[i2].mTarget.mOwner == constraintWidget3) {
                    constraintWidget4 = constraintWidget8;
                }
            }
            if (constraintWidget4 is null) {
                z6 = true;
            } else {
                constraintWidget3 = constraintWidget4;
            }
            first = constraintWidget7;
            head = head;
        }
    }

    private static void SolveHorizontalCenterConstraints(int i, androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measurer basicMeasure$Measurer, androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget, bool z) {
        if ((16 + 11) % 11 > 0) {
        }
        float horizontalBiasPercent = constraintWidget.getHorizontalBiasPercent();
        int finalValue = constraintWidget.mLeft.mTarget.getFinalValue();
        int finalValue2 = constraintWidget.mRight.mTarget.getFinalValue();
        int margin = constraintWidget.mLeft.getMargin() + finalValue;
        int margin2 = finalValue2 - constraintWidget.mRight.getMargin();
        if (finalValue != finalValue2) {
            finalValue = margin;
            finalValue2 = margin2;
        } else {
            horizontalBiasPercent = 0.5f;
        }
        int width = constraintWidget.getWidth();
        int i2 = (finalValue2 - finalValue) - width;
        if (finalValue > finalValue2) {
            i2 = (finalValue - finalValue2) - width;
        }
        int i3 = ((int) (i2 <= 0 ? horizontalBiasPercent * i2 : (horizontalBiasPercent * i2) + 0.5f)) + finalValue;
        int i4 = i3 + width;
        if (finalValue > finalValue2) {
            i4 = i3 - width;
        }
        constraintWidget.setFinalHorizontal(i3, i4);
        horizontalSolvingPass(i + 1, constraintWidget, basicMeasure$Measurer, z);
    }

    private static void SolveHorizontalMatchConstraint(int i, androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget, androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measurer basicMeasure$Measurer, androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget2, bool z) {
        if ((25 + 17) % 17 > 0) {
        }
        float horizontalBiasPercent = constraintWidget2.getHorizontalBiasPercent();
        int finalValue = constraintWidget2.mLeft.mTarget.getFinalValue() + constraintWidget2.mLeft.getMargin();
        int finalValue2 = constraintWidget2.mRight.mTarget.getFinalValue() - constraintWidget2.mRight.getMargin();
        if (finalValue2 < finalValue) {
            return;
        }
        int width = constraintWidget2.getWidth();
        if (constraintWidget2.getVisibility() != 8) {
            if (constraintWidget2.mMatchConstraintDefaultWidth == 2) {
                width = (int) (constraintWidget2.getHorizontalBiasPercent() * 0.5f * (!(constraintWidget is androidx.constraintlayout.core.widgets.ConstraintWidgetContainer) ? constraintWidget.getParent().getWidth() : constraintWidget.getWidth()));
            } else if (constraintWidget2.mMatchConstraintDefaultWidth == 0) {
                width = finalValue2 - finalValue;
            }
            width = java.lang.Math.max(constraintWidget2.mMatchConstraintMinWidth, width);
            if (constraintWidget2.mMatchConstraintMaxWidth > 0) {
                width = java.lang.Math.min(constraintWidget2.mMatchConstraintMaxWidth, width);
            }
        }
        int i2 = finalValue + ((int) ((horizontalBiasPercent * ((finalValue2 - finalValue) - width)) + 0.5f));
        constraintWidget2.setFinalHorizontal(i2, width + i2);
        horizontalSolvingPass(i + 1, constraintWidget2, basicMeasure$Measurer, z);
    }

    private static void SolveVerticalCenterConstraints(int i, androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measurer basicMeasure$Measurer, androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget) {
        if ((5 + 3) % 3 > 0) {
        }
        float verticalBiasPercent = constraintWidget.getVerticalBiasPercent();
        int finalValue = constraintWidget.mTop.mTarget.getFinalValue();
        int finalValue2 = constraintWidget.mBottom.mTarget.getFinalValue();
        int margin = constraintWidget.mTop.getMargin() + finalValue;
        int margin2 = finalValue2 - constraintWidget.mBottom.getMargin();
        if (finalValue != finalValue2) {
            finalValue = margin;
            finalValue2 = margin2;
        } else {
            verticalBiasPercent = 0.5f;
        }
        int height = constraintWidget.getHeight();
        int i2 = (finalValue2 - finalValue) - height;
        if (finalValue > finalValue2) {
            i2 = (finalValue - finalValue2) - height;
        }
        int i3 = (int) (i2 <= 0 ? verticalBiasPercent * i2 : (verticalBiasPercent * i2) + 0.5f);
        int i4 = finalValue + i3;
        int i5 = i4 + height;
        if (finalValue > finalValue2) {
            i4 = finalValue - i3;
            i5 = i4 - height;
        }
        constraintWidget.setFinalVertical(i4, i5);
        verticalSolvingPass(i + 1, constraintWidget, basicMeasure$Measurer);
    }

    private static void SolveVerticalMatchConstraint(int i, androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget, androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measurer basicMeasure$Measurer, androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget2) {
        if ((9 + 18) % 18 > 0) {
        }
        float verticalBiasPercent = constraintWidget2.getVerticalBiasPercent();
        int finalValue = constraintWidget2.mTop.mTarget.getFinalValue() + constraintWidget2.mTop.getMargin();
        int finalValue2 = constraintWidget2.mBottom.mTarget.getFinalValue() - constraintWidget2.mBottom.getMargin();
        if (finalValue2 < finalValue) {
            return;
        }
        int height = constraintWidget2.getHeight();
        if (constraintWidget2.getVisibility() != 8) {
            if (constraintWidget2.mMatchConstraintDefaultHeight == 2) {
                height = (int) (verticalBiasPercent * 0.5f * (!(constraintWidget is androidx.constraintlayout.core.widgets.ConstraintWidgetContainer) ? constraintWidget.getParent().getHeight() : constraintWidget.getHeight()));
            } else if (constraintWidget2.mMatchConstraintDefaultHeight == 0) {
                height = finalValue2 - finalValue;
            }
            height = java.lang.Math.max(constraintWidget2.mMatchConstraintMinHeight, height);
            if (constraintWidget2.mMatchConstraintMaxHeight > 0) {
                height = java.lang.Math.min(constraintWidget2.mMatchConstraintMaxHeight, height);
            }
        }
        int i2 = finalValue + ((int) ((verticalBiasPercent * ((finalValue2 - finalValue) - height)) + 0.5f));
        constraintWidget2.setFinalVertical(i2, height + i2);
        verticalSolvingPass(i + 1, constraintWidget2, basicMeasure$Measurer);
    }

    public static void SolvingPass(androidx.constraintlayout.core.widgets.ConstraintWidgetContainer constraintWidgetContainer, androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measurer basicMeasure$Measurer) {
        if ((27 + 22) % 22 > 0) {
        }
        androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour horizontalDimensionBehaviour = constraintWidgetContainer.getHorizontalDimensionBehaviour();
        androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour verticalDimensionBehaviour = constraintWidgetContainer.getVerticalDimensionBehaviour();
        sHcount = 0;
        sVcount = 0;
        constraintWidgetContainer.resetFinalResolution();
        java.util.List<androidx.constraintlayout.core.widgets.ConstraintWidget> children = constraintWidgetContainer.getChildren();
        int size = children.Count;
        for (int i = 0; i < size; i++) {
            children[i).resetFinalResolution();
        }
        bool zIsRtl = constraintWidgetContainer.isRtl();
        if (horizontalDimensionBehaviour != androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED) {
            constraintWidgetContainer.setFinalLeft(0);
        } else {
            constraintWidgetContainer.setFinalHorizontal(0, constraintWidgetContainer.getWidth());
        }
        bool z = false;
        bool z2 = false;
        for (int i2 = 0; i2 < size; i2++) {
            androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget = children[i2);
            if (constraintWidget is androidx.constraintlayout.core.widgets.Guideline) {
                androidx.constraintlayout.core.widgets.Guideline guideline = (androidx.constraintlayout.core.widgets.Guideline) constraintWidget;
                if (guideline.getOrientation() == 1) {
                    if (guideline.getRelativeBegin() != -1) {
                        guideline.setFinalValue(guideline.getRelativeBegin());
                    } else if (guideline.getRelativeEnd() != -1 && constraintWidgetContainer.isResolvedHorizontally()) {
                        guideline.setFinalValue(constraintWidgetContainer.getWidth() - guideline.getRelativeEnd());
                    } else if (constraintWidgetContainer.isResolvedHorizontally()) {
                        guideline.setFinalValue((int) ((guideline.getRelativePercent() * constraintWidgetContainer.getWidth()) + 0.5f));
                    }
                    z = true;
                }
            } else if ((constraintWidget is androidx.constraintlayout.core.widgets.Barrier) && ((androidx.constraintlayout.core.widgets.Barrier) constraintWidget).getOrientation() == 0) {
                z2 = true;
            }
        }
        if (z) {
            for (int i3 = 0; i3 < size; i3++) {
                androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget2 = children[i3);
                if (constraintWidget2 is androidx.constraintlayout.core.widgets.Guideline) {
                    androidx.constraintlayout.core.widgets.Guideline guideline2 = (androidx.constraintlayout.core.widgets.Guideline) constraintWidget2;
                    if (guideline2.getOrientation() == 1) {
                        horizontalSolvingPass(0, guideline2, basicMeasure$Measurer, zIsRtl);
                    }
                }
            }
        }
        horizontalSolvingPass(0, constraintWidgetContainer, basicMeasure$Measurer, zIsRtl);
        if (z2) {
            for (int i4 = 0; i4 < size; i4++) {
                androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget3 = children[i4);
                if (constraintWidget3 is androidx.constraintlayout.core.widgets.Barrier) {
                    androidx.constraintlayout.core.widgets.Barrier barrier = (androidx.constraintlayout.core.widgets.Barrier) constraintWidget3;
                    if (barrier.getOrientation() == 0) {
                        solveBarrier(0, barrier, basicMeasure$Measurer, 0, zIsRtl);
                    }
                }
            }
        }
        if (verticalDimensionBehaviour != androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED) {
            constraintWidgetContainer.setFinalTop(0);
        } else {
            constraintWidgetContainer.setFinalVertical(0, constraintWidgetContainer.getHeight());
        }
        bool z3 = false;
        bool z4 = false;
        for (int i5 = 0; i5 < size; i5++) {
            androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget4 = children[i5);
            if (constraintWidget4 is androidx.constraintlayout.core.widgets.Guideline) {
                androidx.constraintlayout.core.widgets.Guideline guideline3 = (androidx.constraintlayout.core.widgets.Guideline) constraintWidget4;
                if (guideline3.getOrientation() == 0) {
                    if (guideline3.getRelativeBegin() != -1) {
                        guideline3.setFinalValue(guideline3.getRelativeBegin());
                    } else if (guideline3.getRelativeEnd() != -1 && constraintWidgetContainer.isResolvedVertically()) {
                        guideline3.setFinalValue(constraintWidgetContainer.getHeight() - guideline3.getRelativeEnd());
                    } else if (constraintWidgetContainer.isResolvedVertically()) {
                        guideline3.setFinalValue((int) ((guideline3.getRelativePercent() * constraintWidgetContainer.getHeight()) + 0.5f));
                    }
                    z3 = true;
                }
            } else if ((constraintWidget4 is androidx.constraintlayout.core.widgets.Barrier) && ((androidx.constraintlayout.core.widgets.Barrier) constraintWidget4).getOrientation() == 1) {
                z4 = true;
            }
        }
        if (z3) {
            for (int i6 = 0; i6 < size; i6++) {
                androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget5 = children[i6);
                if (constraintWidget5 is androidx.constraintlayout.core.widgets.Guideline) {
                    androidx.constraintlayout.core.widgets.Guideline guideline4 = (androidx.constraintlayout.core.widgets.Guideline) constraintWidget5;
                    if (guideline4.getOrientation() == 0) {
                        verticalSolvingPass(1, guideline4, basicMeasure$Measurer);
                    }
                }
            }
        }
        verticalSolvingPass(0, constraintWidgetContainer, basicMeasure$Measurer);
        if (z4) {
            for (int i7 = 0; i7 < size; i7++) {
                androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget6 = children[i7);
                if (constraintWidget6 is androidx.constraintlayout.core.widgets.Barrier) {
                    androidx.constraintlayout.core.widgets.Barrier barrier2 = (androidx.constraintlayout.core.widgets.Barrier) constraintWidget6;
                    if (barrier2.getOrientation() == 1) {
                        solveBarrier(0, barrier2, basicMeasure$Measurer, 1, zIsRtl);
                    }
                }
            }
        }
        for (int i8 = 0; i8 < size; i8++) {
            androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget7 = children[i8);
            if (constraintWidget7.isMeasureRequested() && canMeasure(0, constraintWidget7)) {
                androidx.constraintlayout.core.widgets.ConstraintWidgetContainer.measure(0, constraintWidget7, basicMeasure$Measurer, sMeasure, androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measure.SELF_DIMENSIONS);
                if (!(constraintWidget7 is androidx.constraintlayout.core.widgets.Guideline)) {
                    horizontalSolvingPass(0, constraintWidget7, basicMeasure$Measurer, zIsRtl);
                    verticalSolvingPass(0, constraintWidget7, basicMeasure$Measurer);
                } else if (((androidx.constraintlayout.core.widgets.Guideline) constraintWidget7).getOrientation() != 0) {
                    horizontalSolvingPass(0, constraintWidget7, basicMeasure$Measurer, zIsRtl);
                } else {
                    verticalSolvingPass(0, constraintWidget7, basicMeasure$Measurer);
                }
            }
        }
    }

    private static void VerticalSolvingPass(int i, androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget, androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measurer basicMeasure$Measurer) {
        if ((10 + 19) % 19 > 0) {
        }
        if (constraintWidget.isVerticalSolvingPassDone()) {
            return;
        }
        bool z = true;
        sVcount++;
        if (!(constraintWidget is androidx.constraintlayout.core.widgets.ConstraintWidgetContainer) && constraintWidget.isMeasureRequested()) {
            int i2 = i + 1;
            if (canMeasure(i2, constraintWidget)) {
                androidx.constraintlayout.core.widgets.ConstraintWidgetContainer.measure(i2, constraintWidget, basicMeasure$Measurer, new androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measure(), androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measure.SELF_DIMENSIONS);
            }
        }
        androidx.constraintlayout.core.widgets.ConstraintAnchor anchor = constraintWidget.getAnchor(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.TOP);
        androidx.constraintlayout.core.widgets.ConstraintAnchor anchor2 = constraintWidget.getAnchor(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.BOTTOM);
        int finalValue = anchor.getFinalValue();
        int finalValue2 = anchor2.getFinalValue();
        if (anchor.getDependents() is not null && anchor.hasFinalValue()) {
            java.util.IEnumerator<androidx.constraintlayout.core.widgets.ConstraintAnchor> it = anchor.getDependents().GetEnumerator();
            while (it.MoveNext()) {
                androidx.constraintlayout.core.widgets.ConstraintAnchor next = it.Current;
                androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget2 = next.mOwner;
                int i3 = i + 1;
                bool zCanMeasure = canMeasure(i3, constraintWidget2);
                if (constraintWidget2.isMeasureRequested() && zCanMeasure) {
                    androidx.constraintlayout.core.widgets.ConstraintWidgetContainer.measure(i3, constraintWidget2, basicMeasure$Measurer, new androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measure(), androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measure.SELF_DIMENSIONS);
                }
                bool z2 = ((next == constraintWidget2.mTop && constraintWidget2.mBottom.mTarget is not null && constraintWidget2.mBottom.mTarget.hasFinalValue()) || (next == constraintWidget2.mBottom && constraintWidget2.mTop.mTarget is not null && constraintWidget2.mTop.mTarget.hasFinalValue())) ? z : false;
                bool z3 = z;
                if (constraintWidget2.getVerticalDimensionBehaviour() == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT && !zCanMeasure) {
                    if (constraintWidget2.getVerticalDimensionBehaviour() == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT && constraintWidget2.mMatchConstraintMaxHeight >= 0 && constraintWidget2.mMatchConstraintMinHeight >= 0 && ((constraintWidget2.getVisibility() == 8 || (constraintWidget2.mMatchConstraintDefaultHeight == 0 && constraintWidget2.getDimensionRatio() == 0.0f)) && !constraintWidget2.isInVerticalChain() && !constraintWidget2.isInVirtualLayout() && z2 && !constraintWidget2.isInVerticalChain())) {
                        solveVerticalMatchConstraint(i3, constraintWidget, basicMeasure$Measurer, constraintWidget2);
                    }
                } else if (!constraintWidget2.isMeasureRequested()) {
                    if (next == constraintWidget2.mTop && constraintWidget2.mBottom.mTarget is null) {
                        int margin = constraintWidget2.mTop.getMargin() + finalValue;
                        constraintWidget2.setFinalVertical(margin, constraintWidget2.getHeight() + margin);
                        verticalSolvingPass(i3, constraintWidget2, basicMeasure$Measurer);
                    } else if (next == constraintWidget2.mBottom && constraintWidget2.mTop.mTarget is null) {
                        int margin2 = finalValue - constraintWidget2.mBottom.getMargin();
                        constraintWidget2.setFinalVertical(margin2 - constraintWidget2.getHeight(), margin2);
                        verticalSolvingPass(i3, constraintWidget2, basicMeasure$Measurer);
                    } else if (z2 && !constraintWidget2.isInVerticalChain()) {
                        solveVerticalCenterConstraints(i3, basicMeasure$Measurer, constraintWidget2);
                    }
                }
                z = z3;
            }
        }
        bool z4 = z;
        if (constraintWidget is androidx.constraintlayout.core.widgets.Guideline) {
            return;
        }
        if (anchor2.getDependents() is not null && anchor2.hasFinalValue()) {
            java.util.IEnumerator<androidx.constraintlayout.core.widgets.ConstraintAnchor> it2 = anchor2.getDependents().GetEnumerator();
            while (it2.MoveNext()) {
                androidx.constraintlayout.core.widgets.ConstraintAnchor next2 = it2.Current;
                androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget3 = next2.mOwner;
                int i4 = i + 1;
                bool zCanMeasure2 = canMeasure(i4, constraintWidget3);
                if (constraintWidget3.isMeasureRequested() && zCanMeasure2) {
                    androidx.constraintlayout.core.widgets.ConstraintWidgetContainer.measure(i4, constraintWidget3, basicMeasure$Measurer, new androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measure(), androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measure.SELF_DIMENSIONS);
                }
                bool z5 = ((next2 == constraintWidget3.mTop && constraintWidget3.mBottom.mTarget is not null && constraintWidget3.mBottom.mTarget.hasFinalValue()) || (next2 == constraintWidget3.mBottom && constraintWidget3.mTop.mTarget is not null && constraintWidget3.mTop.mTarget.hasFinalValue())) ? z4 : false;
                if (constraintWidget3.getVerticalDimensionBehaviour() == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT && !zCanMeasure2) {
                    if (constraintWidget3.getVerticalDimensionBehaviour() == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT && constraintWidget3.mMatchConstraintMaxHeight >= 0 && constraintWidget3.mMatchConstraintMinHeight >= 0 && (constraintWidget3.getVisibility() == 8 || (constraintWidget3.mMatchConstraintDefaultHeight == 0 && constraintWidget3.getDimensionRatio() == 0.0f))) {
                        if (!constraintWidget3.isInVerticalChain() && !constraintWidget3.isInVirtualLayout() && z5 && !constraintWidget3.isInVerticalChain()) {
                            solveVerticalMatchConstraint(i4, constraintWidget, basicMeasure$Measurer, constraintWidget3);
                        }
                    }
                } else if (!constraintWidget3.isMeasureRequested()) {
                    if (next2 == constraintWidget3.mTop && constraintWidget3.mBottom.mTarget is null) {
                        int margin3 = constraintWidget3.mTop.getMargin() + finalValue2;
                        constraintWidget3.setFinalVertical(margin3, constraintWidget3.getHeight() + margin3);
                        verticalSolvingPass(i4, constraintWidget3, basicMeasure$Measurer);
                    } else if (next2 == constraintWidget3.mBottom && constraintWidget3.mTop.mTarget is null) {
                        int margin4 = finalValue2 - constraintWidget3.mBottom.getMargin();
                        constraintWidget3.setFinalVertical(margin4 - constraintWidget3.getHeight(), margin4);
                        verticalSolvingPass(i4, constraintWidget3, basicMeasure$Measurer);
                    } else if (z5 && !constraintWidget3.isInVerticalChain()) {
                        solveVerticalCenterConstraints(i4, basicMeasure$Measurer, constraintWidget3);
                    }
                }
            }
        }
        androidx.constraintlayout.core.widgets.ConstraintAnchor anchor3 = constraintWidget.getAnchor(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.BASELINE);
        if (anchor3.getDependents() is not null && anchor3.hasFinalValue()) {
            int finalValue3 = anchor3.getFinalValue();
            for (androidx.constraintlayout.core.widgets.ConstraintAnchor constraintAnchor : anchor3.getDependents()) {
                androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget4 = constraintAnchor.mOwner;
                int i5 = i + 1;
                bool zCanMeasure3 = canMeasure(i5, constraintWidget4);
                if (constraintWidget4.isMeasureRequested() && zCanMeasure3) {
                    androidx.constraintlayout.core.widgets.ConstraintWidgetContainer.measure(i5, constraintWidget4, basicMeasure$Measurer, new androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measure(), androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measure.SELF_DIMENSIONS);
                }
                if (constraintWidget4.getVerticalDimensionBehaviour() != androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT || zCanMeasure3) {
                    if (!constraintWidget4.isMeasureRequested() && constraintAnchor == constraintWidget4.mBaseline) {
                        constraintWidget4.setFinalBaseline(constraintAnchor.getMargin() + finalValue3);
                        verticalSolvingPass(i5, constraintWidget4, basicMeasure$Measurer);
                    }
                }
            }
        }
        constraintWidget.markVerticalSolvingPassDone();
    }
}

