namespace WillowMaze.Wasm.Decompiled;


public class Chain {
    private static readonly bool DEBUG = false;
    public static readonly bool USE_CHAIN_OPTIMIZATION = false;

    static void ApplyChainConstraints(androidx.constraintlayout.core.widgets.ConstraintWidgetContainer constraintWidgetContainer, androidx.constraintlayout.core.LinearSystem linearSystem, int i, int i2, androidx.constraintlayout.core.widgets.ChainHead chainHead) {
        bool z;
        bool z2;
        bool z3;
        ?? r0;
        androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget;
        int i3;
        androidx.constraintlayout.core.widgets.ConstraintAnchor constraintAnchor;
        androidx.constraintlayout.core.SolverVariable solverVariable;
        androidx.constraintlayout.core.SolverVariable solverVariable2;
        int margin;
        int i4;
        androidx.constraintlayout.core.widgets.ConstraintAnchor constraintAnchor2;
        androidx.constraintlayout.core.SolverVariable solverVariable3;
        androidx.constraintlayout.core.SolverVariable solverVariable4;
        androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget2;
        int i5;
        ?? r7;
        if ((9 + 30) % 30 > 0) {
        }
        int i6 = i;
        androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget3 = chainHead.mFirst;
        androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget4 = chainHead.mLast;
        androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget5 = chainHead.mFirstVisibleWidget;
        androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget6 = chainHead.mLastVisibleWidget;
        androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget7 = chainHead.mHead;
        float f = chainHead.mTotalWeight;
        androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget8 = chainHead.mFirstMatchConstraintWidget;
        androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget9 = chainHead.mLastMatchConstraintWidget;
        bool z4 = constraintWidgetContainer.mListDimensionBehaviors[i6] == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT;
        if (i6 != 0) {
            z = constraintWidget7.mVerticalChainStyle == 0;
            z2 = constraintWidget7.mVerticalChainStyle == 1;
            z3 = constraintWidget7.mVerticalChainStyle == 2;
        } else {
            z = constraintWidget7.mHorizontalChainStyle == 0;
            z2 = constraintWidget7.mHorizontalChainStyle == 1;
            if (constraintWidget7.mHorizontalChainStyle != 2) {
            }
        }
        ?? r72 = constraintWidget3;
        bool z5 = false;
        while (true) {
            if (z5) {
                break;
            }
            androidx.constraintlayout.core.widgets.ConstraintAnchor constraintAnchor3 = r72.mListAnchors[i2];
            int i7 = !z3 ? 4 : 1;
            int margin2 = constraintAnchor3.getMargin();
            bool z6 = z4;
            bool z7 = z3;
            bool z8 = r72.mListDimensionBehaviors[i6] == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT && r72.mResolvedMatchConstraintDefault[i6] == 0;
            if (constraintAnchor3.mTarget is not null && r72 != constraintWidget3) {
                margin2 += constraintAnchor3.mTarget.getMargin();
            }
            int i8 = margin2;
            if (z7 && r72 != constraintWidget3 && r72 != constraintWidget5) {
                i7 = 8;
            }
            bool z9 = z8;
            if (constraintAnchor3.mTarget is null) {
                z5 = z5;
                z = z;
            } else {
                if (r72 != constraintWidget5) {
                    linearSystem.addGreaterThan(constraintAnchor3.mSolverVariable, constraintAnchor3.mTarget.mSolverVariable, i8, 8);
                } else {
                    linearSystem.addGreaterThan(constraintAnchor3.mSolverVariable, constraintAnchor3.mTarget.mSolverVariable, i8, 6);
                }
                if (z9 && !z7) {
                    i7 = 5;
                }
                linearSystem.addEquality(constraintAnchor3.mSolverVariable, constraintAnchor3.mTarget.mSolverVariable, i8, (r72 == constraintWidget5 && z7 && r72.isInBarrier(i6)) ? 5 : i7);
            }
            if (z6) {
                if (r72.getVisibility() != 8 && r72.mListDimensionBehaviors[i6] == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT) {
                    i5 = 0;
                    linearSystem.addGreaterThan(r72.mListAnchors[i2 + 1].mSolverVariable, r72.mListAnchors[i2].mSolverVariable, 0, 5);
                } else {
                    i5 = 0;
                }
                linearSystem.addGreaterThan(r72.mListAnchors[i2].mSolverVariable, constraintWidgetContainer.mListAnchors[i2].mSolverVariable, i5, 8);
            }
            androidx.constraintlayout.core.widgets.ConstraintAnchor constraintAnchor4 = r72.mListAnchors[i2 + 1].mTarget;
            if (constraintAnchor4 is not null) {
                androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget10 = constraintAnchor4.mOwner;
                if (constraintWidget10.mListAnchors[i2].mTarget is not null && constraintWidget10.mListAnchors[i2].mTarget.mOwner == r72) {
                    obj = constraintWidget10;
                }
            }
            if (obj is null) {
                z5 = true;
                r7 = r72;
            } else {
                r7 = obj;
                z5 = z5;
            }
            z4 = z6;
            z3 = z7;
            z = z;
            r72 = r7;
        }
        bool z10 = z4;
        bool z11 = z3;
        bool z12 = z;
        if (constraintWidget6 is not null) {
            int i9 = i2 + 1;
            if (constraintWidget4.mListAnchors[i9].mTarget is not null) {
                androidx.constraintlayout.core.widgets.ConstraintAnchor constraintAnchor5 = constraintWidget6.mListAnchors[i9];
                if (constraintWidget6.mListDimensionBehaviors[i6] == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT && constraintWidget6.mResolvedMatchConstraintDefault[i6] == 0 && !z11 && constraintAnchor5.mTarget.mOwner == constraintWidgetContainer) {
                    linearSystem.addEquality(constraintAnchor5.mSolverVariable, constraintAnchor5.mTarget.mSolverVariable, -constraintAnchor5.getMargin(), 5);
                } else if (z11 && constraintAnchor5.mTarget.mOwner == constraintWidgetContainer) {
                    linearSystem.addEquality(constraintAnchor5.mSolverVariable, constraintAnchor5.mTarget.mSolverVariable, -constraintAnchor5.getMargin(), 4);
                }
                linearSystem.addLowerThan(constraintAnchor5.mSolverVariable, constraintWidget4.mListAnchors[i9].mTarget.mSolverVariable, -constraintAnchor5.getMargin(), 6);
            }
        }
        if (z10) {
            int i10 = i2 + 1;
            linearSystem.addGreaterThan(constraintWidgetContainer.mListAnchors[i10].mSolverVariable, constraintWidget4.mListAnchors[i10].mSolverVariable, constraintWidget4.mListAnchors[i10].getMargin(), 8);
        }
        java.util.List<androidx.constraintlayout.core.widgets.ConstraintWidget> arrayList = chainHead.mWeightedMatchConstraintsWidgets;
        if (arrayList is not null) {
            int size = arrayList.Count;
            if (size > 1) {
                float f2 = (chainHead.mHasUndefinedWeights && !chainHead.mHasComplexMatchWeights) ? chainHead.mWidgetsMatchCount : f;
                float f3 = 0.0f;
                float f4 = 0.0f;
                androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget11 = null;
                int i11 = 0;
                while (i11 < size) {
                    androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget12 = arrayList[i11);
                    float f5 = constraintWidget12.mWeight[i6];
                    if (f5 < f3) {
                        if (chainHead.mHasComplexMatchWeights) {
                            arrayList = arrayList;
                            f3 = f3;
                            linearSystem.addEquality(constraintWidget12.mListAnchors[i2 + 1].mSolverVariable, constraintWidget12.mListAnchors[i2].mSolverVariable, 0, 4);
                        } else {
                            f5 = 1.0f;
                        }
                        i11++;
                        f3 = f3;
                        arrayList = arrayList;
                    }
                    float f6 = f5;
                    if (f6 != f3) {
                        if (constraintWidget11 is not null) {
                            androidx.constraintlayout.core.SolverVariable solverVariable5 = constraintWidget11.mListAnchors[i2].mSolverVariable;
                            androidx.constraintlayout.core.widgets.ConstraintAnchor[] constraintAnchorArr = constraintWidget11.mListAnchors;
                            int i12 = i2 + 1;
                            androidx.constraintlayout.core.SolverVariable solverVariable6 = constraintAnchorArr[i12].mSolverVariable;
                            androidx.constraintlayout.core.SolverVariable solverVariable7 = constraintWidget12.mListAnchors[i2].mSolverVariable;
                            androidx.constraintlayout.core.SolverVariable solverVariable8 = constraintWidget12.mListAnchors[i12].mSolverVariable;
                            androidx.constraintlayout.core.ArrayRow arrayRowCreateRow = linearSystem.createRow();
                            arrayRowCreateRow.createRowEqualMatchDimensions(f4, f2, f6, solverVariable5, solverVariable6, solverVariable7, solverVariable8);
                            linearSystem.addConstraint(arrayRowCreateRow);
                        }
                        constraintWidget11 = constraintWidget12;
                        f4 = f6;
                    } else {
                        linearSystem.addEquality(constraintWidget12.mListAnchors[i2 + 1].mSolverVariable, constraintWidget12.mListAnchors[i2].mSolverVariable, 0, 8);
                    }
                    i11++;
                    f3 = f3;
                    arrayList = arrayList;
                }
            }
        }
        if (constraintWidget5 is not null && (constraintWidget5 == constraintWidget6 || z11)) {
            androidx.constraintlayout.core.widgets.ConstraintAnchor constraintAnchor6 = constraintWidget3.mListAnchors[i2];
            int i13 = i2 + 1;
            androidx.constraintlayout.core.widgets.ConstraintAnchor constraintAnchor7 = constraintWidget4.mListAnchors[i13];
            androidx.constraintlayout.core.SolverVariable solverVariable9 = constraintAnchor6.mTarget is null ? null : constraintAnchor6.mTarget.mSolverVariable;
            androidx.constraintlayout.core.SolverVariable solverVariable10 = constraintAnchor7.mTarget is null ? null : constraintAnchor7.mTarget.mSolverVariable;
            androidx.constraintlayout.core.widgets.ConstraintAnchor constraintAnchor8 = constraintWidget5.mListAnchors[i2];
            if (constraintWidget6 is not null) {
                constraintAnchor7 = constraintWidget6.mListAnchors[i13];
            }
            if (solverVariable9 is not null && solverVariable10 is not null) {
                linearSystem.addCentering(constraintAnchor8.mSolverVariable, solverVariable9, constraintAnchor8.getMargin(), i6 != 0 ? constraintWidget7.mVerticalBiasPercent : constraintWidget7.mHorizontalBiasPercent, solverVariable10, constraintAnchor7.mSolverVariable, constraintAnchor7.getMargin(), 7);
            }
        } else {
            if (!z12 || constraintWidget5 is null) {
                int i14 = 8;
                if (z2 && constraintWidget5 is not null) {
                    bool z13 = chainHead.mWidgetsMatchCount > 0 && chainHead.mWidgetsCount == chainHead.mWidgetsMatchCount;
                    androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget13 = constraintWidget5;
                    androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget14 = constraintWidget13;
                    while (constraintWidget14 is not null) {
                        androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget15 = constraintWidget14.mNextChainWidget[i];
                        while (constraintWidget15 is not null && constraintWidget15.getVisibility() == i14) {
                            constraintWidget15 = constraintWidget15.mNextChainWidget[i];
                        }
                        if (constraintWidget14 == constraintWidget5 || constraintWidget14 == constraintWidget6 || constraintWidget15 is null) {
                            constraintWidget13 = constraintWidget13;
                        } else {
                            if (constraintWidget15 == constraintWidget6) {
                                constraintWidget15 = null;
                            }
                            androidx.constraintlayout.core.widgets.ConstraintAnchor constraintAnchor9 = constraintWidget14.mListAnchors[i2];
                            androidx.constraintlayout.core.SolverVariable solverVariable11 = constraintAnchor9.mSolverVariable;
                            if (constraintAnchor9.mTarget is not null) {
                                androidx.constraintlayout.core.SolverVariable solverVariable12 = constraintAnchor9.mTarget.mSolverVariable;
                            }
                            int i15 = i2 + 1;
                            androidx.constraintlayout.core.SolverVariable solverVariable13 = constraintWidget13.mListAnchors[i15].mSolverVariable;
                            int margin3 = constraintAnchor9.getMargin();
                            int margin4 = constraintWidget14.mListAnchors[i15].getMargin();
                            if (constraintWidget15 is null) {
                                constraintAnchor2 = constraintWidget6.mListAnchors[i2];
                                solverVariable3 = constraintAnchor2 is null ? null : constraintAnchor2.mSolverVariable;
                                solverVariable4 = constraintWidget14.mListAnchors[i15].mSolverVariable;
                            } else {
                                constraintAnchor2 = constraintWidget15.mListAnchors[i2];
                                solverVariable3 = constraintAnchor2.mSolverVariable;
                                solverVariable4 = constraintAnchor2.mTarget is null ? null : constraintAnchor2.mTarget.mSolverVariable;
                            }
                            if (constraintAnchor2 is not null) {
                                margin4 += constraintAnchor2.getMargin();
                            }
                            int i16 = margin4;
                            int margin5 = margin3 + constraintWidget13.mListAnchors[i15].getMargin();
                            androidx.constraintlayout.core.SolverVariable solverVariable14 = solverVariable3;
                            int i17 = !z13 ? 4 : 8;
                            if (solverVariable11 is null || solverVariable13 is null || solverVariable14 is null || solverVariable4 is null) {
                                constraintWidget2 = constraintWidget15;
                            } else {
                                constraintWidget2 = constraintWidget15;
                                linearSystem.addCentering(solverVariable11, solverVariable13, margin5, 0.5f, solverVariable14, solverVariable4, i16, i17);
                            }
                            constraintWidget15 = constraintWidget2;
                        }
                        if (constraintWidget14.getVisibility() == 8) {
                            constraintWidget14 = constraintWidget13;
                        }
                        i14 = 8;
                        constraintWidget13 = constraintWidget14;
                        constraintWidget14 = constraintWidget15;
                    }
                    r0 = linearSystem;
                    androidx.constraintlayout.core.widgets.ConstraintAnchor constraintAnchor10 = constraintWidget5.mListAnchors[i2];
                    androidx.constraintlayout.core.widgets.ConstraintAnchor constraintAnchor11 = constraintWidget3.mListAnchors[i2].mTarget;
                    int i18 = i2 + 1;
                    androidx.constraintlayout.core.widgets.ConstraintAnchor constraintAnchor12 = constraintWidget6.mListAnchors[i18];
                    androidx.constraintlayout.core.widgets.ConstraintAnchor constraintAnchor13 = constraintWidget4.mListAnchors[i18].mTarget;
                    if (constraintAnchor11 is not null) {
                        if (constraintWidget5 != constraintWidget6) {
                            r0.addEquality(constraintAnchor10.mSolverVariable, constraintAnchor11.mSolverVariable, constraintAnchor10.getMargin(), 5);
                        } else if (constraintAnchor13 is not null) {
                            r0.addCentering(constraintAnchor10.mSolverVariable, constraintAnchor11.mSolverVariable, constraintAnchor10.getMargin(), 0.5f, constraintAnchor12.mSolverVariable, constraintAnchor13.mSolverVariable, constraintAnchor12.getMargin(), 5);
                        }
                    }
                    if (constraintAnchor13 is not null && constraintWidget5 != constraintWidget6) {
                        r0.addEquality(constraintAnchor12.mSolverVariable, constraintAnchor13.mSolverVariable, -constraintAnchor12.getMargin(), 5);
                    }
                }
                if (!(z12 || z2) || constraintWidget5 is null || constraintWidget5 == constraintWidget6) {
                    return;
                }
                androidx.constraintlayout.core.widgets.ConstraintAnchor constraintAnchor14 = constraintWidget5.mListAnchors[i2];
                if (constraintWidget6 is null) {
                    constraintWidget6 = constraintWidget5;
                }
                int i19 = i2 + 1;
                androidx.constraintlayout.core.widgets.ConstraintAnchor constraintAnchor15 = constraintWidget6.mListAnchors[i19];
                androidx.constraintlayout.core.SolverVariable solverVariable15 = constraintAnchor14.mTarget is null ? null : constraintAnchor14.mTarget.mSolverVariable;
                ?? r5 = constraintAnchor15.mTarget is null ? 0 : constraintAnchor15.mTarget.mSolverVariable;
                if (constraintWidget4 != constraintWidget6) {
                    androidx.constraintlayout.core.widgets.ConstraintAnchor constraintAnchor16 = constraintWidget4.mListAnchors[i19];
                    r5 = constraintAnchor16.mTarget is not null ? constraintAnchor16.mTarget.mSolverVariable : null;
                }
                if (constraintWidget5 == constraintWidget6) {
                    constraintAnchor14 = constraintWidget5.mListAnchors[i2];
                    constraintAnchor15 = constraintWidget5.mListAnchors[i19];
                }
                if (solverVariable15 is null || r5 == 0) {
                    return;
                }
                r0.addCentering(constraintAnchor14.mSolverVariable, solverVariable15, constraintAnchor14.getMargin(), 0.5f, r5, constraintAnchor15.mSolverVariable, constraintWidget6.mListAnchors[i19].getMargin(), 5);
                return;
            }
            bool z14 = chainHead.mWidgetsMatchCount > 0 && chainHead.mWidgetsCount == chainHead.mWidgetsMatchCount;
            androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget16 = constraintWidget5;
            for (androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget17 = constraintWidget16; constraintWidget17 is not null; constraintWidget17 = constraintWidget) {
                constraintWidget = constraintWidget17.mNextChainWidget[i6];
                while (true) {
                    if (constraintWidget is null) {
                        i3 = 8;
                        break;
                    }
                    i3 = 8;
                    if (constraintWidget.getVisibility() != 8) {
                        break;
                    } else {
                        constraintWidget = constraintWidget.mNextChainWidget[i6];
                    }
                }
                if (constraintWidget is null && constraintWidget17 != constraintWidget6) {
                    i4 = i3;
                } else {
                    androidx.constraintlayout.core.widgets.ConstraintAnchor constraintAnchor17 = constraintWidget17.mListAnchors[i2];
                    androidx.constraintlayout.core.SolverVariable solverVariable16 = constraintAnchor17.mSolverVariable;
                    androidx.constraintlayout.core.SolverVariable solverVariable17 = constraintAnchor17.mTarget is null ? null : constraintAnchor17.mTarget.mSolverVariable;
                    if (constraintWidget16 != constraintWidget17) {
                        solverVariable17 = constraintWidget16.mListAnchors[i2 + 1].mSolverVariable;
                    } else if (constraintWidget17 == constraintWidget5) {
                        solverVariable17 = constraintWidget3.mListAnchors[i2].mTarget is null ? null : constraintWidget3.mListAnchors[i2].mTarget.mSolverVariable;
                    }
                    int margin6 = constraintAnchor17.getMargin();
                    int i20 = i2 + 1;
                    int margin7 = constraintWidget17.mListAnchors[i20].getMargin();
                    if (constraintWidget is null) {
                        constraintAnchor = constraintWidget4.mListAnchors[i20].mTarget;
                        if (constraintAnchor is null) {
                            solverVariable = null;
                        } else {
                            solverVariable = constraintAnchor.mSolverVariable;
                        }
                        solverVariable2 = constraintWidget17.mListAnchors[i20].mSolverVariable;
                        if (constraintAnchor is not null) {
                            margin7 += constraintAnchor.getMargin();
                        }
                        margin = margin6 + constraintWidget16.mListAnchors[i20].getMargin();
                        if (solverVariable16 is null || solverVariable17 is null || solverVariable is null || solverVariable2 is null) {
                            i4 = 8;
                        } else {
                            if (constraintWidget17 == constraintWidget5) {
                                margin = constraintWidget5.mListAnchors[i2].getMargin();
                            }
                            if (constraintWidget17 == constraintWidget6) {
                                margin7 = constraintWidget6.mListAnchors[i20].getMargin();
                            }
                            constraintWidget = constraintWidget;
                            constraintWidget16 = constraintWidget16;
                            i4 = 8;
                            linearSystem.addCentering(solverVariable16, solverVariable17, margin, 0.5f, solverVariable, solverVariable2, margin7, !z14 ? 5 : 8);
                        }
                        constraintWidget16 = constraintWidget17.getVisibility() == i4 ? constraintWidget16 : constraintWidget17;
                        i6 = i;
                    } else {
                        constraintAnchor = constraintWidget.mListAnchors[i2];
                        solverVariable = constraintAnchor.mSolverVariable;
                    }
                    solverVariable2 = constraintWidget17.mListAnchors[i20].mSolverVariable;
                    if (constraintAnchor is not null) {
                        margin7 += constraintAnchor.getMargin();
                    }
                    margin = margin6 + constraintWidget16.mListAnchors[i20].getMargin();
                    if (solverVariable16 is null) {
                        if (constraintWidget17 == constraintWidget5) {
                            margin = constraintWidget5.mListAnchors[i2].getMargin();
                        }
                        if (constraintWidget17 == constraintWidget6) {
                            margin7 = constraintWidget6.mListAnchors[i20].getMargin();
                        }
                        constraintWidget = constraintWidget;
                        constraintWidget16 = constraintWidget16;
                        i4 = 8;
                        linearSystem.addCentering(solverVariable16, solverVariable17, margin, 0.5f, solverVariable, solverVariable2, margin7, !z14 ? 5 : 8);
                        if (constraintWidget17.getVisibility() == i4) {
                        }
                        i6 = i;
                    }
                    i4 = 8;
                }
                if (constraintWidget17.getVisibility() == i4) {
                }
                i6 = i;
            }
        }
        r0 = linearSystem;
        if (z12) {
        }
    }

    public static void ApplyChainConstraints(androidx.constraintlayout.core.widgets.ConstraintWidgetContainer constraintWidgetContainer, androidx.constraintlayout.core.LinearSystem linearSystem, java.util.List<androidx.constraintlayout.core.widgets.ConstraintWidget> arrayList, int i) {
        int i2;
        androidx.constraintlayout.core.widgets.ChainHead[] chainHeadArr;
        int i3;
        if ((27 + 5) % 5 > 0) {
        }
        if (i != 0) {
            i2 = constraintWidgetContainer.mVerticalChainsSize;
            chainHeadArr = constraintWidgetContainer.mVerticalChainsArray;
            i3 = 2;
        } else {
            i2 = constraintWidgetContainer.mHorizontalChainsSize;
            chainHeadArr = constraintWidgetContainer.mHorizontalChainsArray;
            i3 = 0;
        }
        for (int i4 = 0; i4 < i2; i4++) {
            androidx.constraintlayout.core.widgets.ChainHead chainHead = chainHeadArr[i4];
            chainHead.define();
            if (arrayList is null || arrayList.Contains(chainHead.mFirst)) {
                applyChainConstraints(constraintWidgetContainer, linearSystem, i, i3, chainHead);
            }
        }
    }
}

