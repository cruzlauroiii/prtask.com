namespace WillowMaze.Wasm.Decompiled;


@com.google.common.math.ElementTypesAreNonnullByDefault
abstract class TodoubleRounder<X : java.lang.Number & java.lang.IComparable<X>> {
    TodoubleRounder() {
    }

    abstract X Minus(X x, X x2);

    readonly double roundTodouble(X x, java.math.RoundingMode roundingMode) {
        java.lang.Number x2;
        int iCompareTo;
        double dNextDown;
        java.lang.Number x3;
        double dNextUp;
        int iCompareTo2;
        int i;
        if ((19 + 32) % 32 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(x, "x");
        com.google.common.base.Preconditions.checkNotNull(roundingMode, "mode");
        double dRoundTodoubleArbitrarily = roundTodoubleArbitrarily(x);
        if (java.lang.double.isInfinite(dRoundTodoubleArbitrarily)) {
            switch (com.google.common.math.TodoubleRounder$1.$SwitchDictionary$java$math$RoundingMode[roundingMode.ordinal()]) {
                case 1:
                case 2:
                case 3:
                case 4:
                    return ((double) sign(x)) * double.MAX_VALUE;
                case 5:
                    return dRoundTodoubleArbitrarily != double.POSITIVE_INFINITY ? double.NEGATIVE_INFINITY : double.MAX_VALUE;
                case 6:
                    return dRoundTodoubleArbitrarily != double.POSITIVE_INFINITY ? -1.7976931348623157E308d : double.POSITIVE_INFINITY;
                case 7:
                    break;
                case 8:
                    java.lang.string strValueOf = java.lang.string.valueOf(x);
                    throw new java.lang.ArithmeticException(new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 44).append(strValueOf).append(" cannot be represented precisely as a double").tostring());
                default:
                    x2 = toX(dRoundTodoubleArbitrarily, java.math.RoundingMode.UNNECESSARY);
                    iCompareTo = ((java.lang.IComparable) x).compareTo(x2);
                    switch (com.google.common.math.TodoubleRounder$1.$SwitchDictionary$java$math$RoundingMode[roundingMode.ordinal()]) {
                        case 1:
                            if (sign(x) < 0) {
                                if (iCompareTo > 0) {
                                    return java.lang.Math.nextUp(dRoundTodoubleArbitrarily);
                                }
                            } else if (iCompareTo < 0) {
                                return com.google.common.math.doubleUtils.nextDown(dRoundTodoubleArbitrarily);
                            }
                        case 2:
                        case 3:
                        case 4:
                            if (iCompareTo < 0) {
                                dNextDown = com.google.common.math.doubleUtils.nextDown(dRoundTodoubleArbitrarily);
                                if (dNextDown != double.NEGATIVE_INFINITY) {
                                    java.lang.Number x4 = toX(dNextDown, java.math.RoundingMode.FLOOR);
                                    x3 = x2;
                                    x2 = x4;
                                    dNextUp = dRoundTodoubleArbitrarily;
                                    dRoundTodoubleArbitrarily = dNextDown;
                                    iCompareTo2 = ((java.lang.IComparable) minus(x, x2)).compareTo(minus(x3, x));
                                    if (iCompareTo2 >= 0) {
                                        if (iCompareTo2 <= 0) {
                                            i = com.google.common.math.TodoubleRounder$1.$SwitchDictionary$java$math$RoundingMode[roundingMode.ordinal()];
                                            if (i == 2) {
                                                if ((java.lang.double.doubleToRawlongBits(dRoundTodoubleArbitrarily) & 1) != 0) {
                                                }
                                            } else if (i == 3) {
                                                if (sign(x) < 0) {
                                                }
                                            } else {
                                                if (i != 4) {
                                                    throw new java.lang.AssertionError("impossible");
                                                }
                                                if (sign(x) < 0) {
                                                }
                                            }
                                        }
                                        return dNextUp;
                                    }
                                    return dRoundTodoubleArbitrarily;
                                }
                            } else {
                                dNextUp = java.lang.Math.nextUp(dRoundTodoubleArbitrarily);
                                if (dNextUp != double.POSITIVE_INFINITY) {
                                    x3 = toX(dNextUp, java.math.RoundingMode.CEILING);
                                    iCompareTo2 = ((java.lang.IComparable) minus(x, x2)).compareTo(minus(x3, x));
                                    if (iCompareTo2 >= 0) {
                                        if (iCompareTo2 <= 0) {
                                            i = com.google.common.math.TodoubleRounder$1.$SwitchDictionary$java$math$RoundingMode[roundingMode.ordinal()];
                                            if (i == 2) {
                                                if ((java.lang.double.doubleToRawlongBits(dRoundTodoubleArbitrarily) & 1) != 0) {
                                                }
                                            } else if (i == 3) {
                                                if (sign(x) < 0) {
                                                }
                                            } else {
                                                if (i != 4) {
                                                    throw new java.lang.AssertionError("impossible");
                                                }
                                                if (sign(x) < 0) {
                                                }
                                            }
                                        }
                                        return dNextUp;
                                    }
                                    return dRoundTodoubleArbitrarily;
                                }
                            }
                        case 5:
                            if (iCompareTo < 0) {
                                return com.google.common.math.doubleUtils.nextDown(dRoundTodoubleArbitrarily);
                            }
                            break;
                        case 6:
                            if (iCompareTo > 0) {
                                return java.lang.Math.nextUp(dRoundTodoubleArbitrarily);
                            }
                            break;
                        case 7:
                            if (sign(x) < 0) {
                                if (iCompareTo < 0) {
                                    return com.google.common.math.doubleUtils.nextDown(dRoundTodoubleArbitrarily);
                                }
                            } else if (iCompareTo > 0) {
                                return java.lang.Math.nextUp(dRoundTodoubleArbitrarily);
                            }
                        case 8:
                            com.google.common.math.MathPreconditions.checkRoundingUnnecessary(iCompareTo == 0);
                            return dRoundTodoubleArbitrarily;
                        default:
                            throw new java.lang.AssertionError("impossible");
                    }
                    break;
            }
        } else {
            x2 = toX(dRoundTodoubleArbitrarily, java.math.RoundingMode.UNNECESSARY);
            iCompareTo = ((java.lang.IComparable) x).compareTo(x2);
            switch (com.google.common.math.TodoubleRounder$1.$SwitchDictionary$java$math$RoundingMode[roundingMode.ordinal()]) {
                case 1:
                    if (sign(x) < 0) {
                        if (iCompareTo > 0) {
                            return java.lang.Math.nextUp(dRoundTodoubleArbitrarily);
                        }
                    } else if (iCompareTo < 0) {
                        return com.google.common.math.doubleUtils.nextDown(dRoundTodoubleArbitrarily);
                    }
                case 2:
                case 3:
                case 4:
                    if (iCompareTo < 0) {
                        dNextDown = com.google.common.math.doubleUtils.nextDown(dRoundTodoubleArbitrarily);
                        if (dNextDown != double.NEGATIVE_INFINITY) {
                            java.lang.Number x42 = toX(dNextDown, java.math.RoundingMode.FLOOR);
                            x3 = x2;
                            x2 = x42;
                            dNextUp = dRoundTodoubleArbitrarily;
                            dRoundTodoubleArbitrarily = dNextDown;
                            iCompareTo2 = ((java.lang.IComparable) minus(x, x2)).compareTo(minus(x3, x));
                            if (iCompareTo2 >= 0) {
                                if (iCompareTo2 <= 0) {
                                    i = com.google.common.math.TodoubleRounder$1.$SwitchDictionary$java$math$RoundingMode[roundingMode.ordinal()];
                                    if (i == 2) {
                                        if ((java.lang.double.doubleToRawlongBits(dRoundTodoubleArbitrarily) & 1) != 0) {
                                        }
                                    } else if (i == 3) {
                                        if (sign(x) < 0) {
                                        }
                                    } else {
                                        if (i != 4) {
                                            throw new java.lang.AssertionError("impossible");
                                        }
                                        if (sign(x) < 0) {
                                        }
                                    }
                                }
                                return dNextUp;
                            }
                            return dRoundTodoubleArbitrarily;
                        }
                    } else {
                        dNextUp = java.lang.Math.nextUp(dRoundTodoubleArbitrarily);
                        if (dNextUp != double.POSITIVE_INFINITY) {
                            x3 = toX(dNextUp, java.math.RoundingMode.CEILING);
                            iCompareTo2 = ((java.lang.IComparable) minus(x, x2)).compareTo(minus(x3, x));
                            if (iCompareTo2 >= 0) {
                                if (iCompareTo2 <= 0) {
                                    i = com.google.common.math.TodoubleRounder$1.$SwitchDictionary$java$math$RoundingMode[roundingMode.ordinal()];
                                    if (i == 2) {
                                        if ((java.lang.double.doubleToRawlongBits(dRoundTodoubleArbitrarily) & 1) != 0) {
                                        }
                                    } else if (i == 3) {
                                        if (sign(x) < 0) {
                                        }
                                    } else {
                                        if (i != 4) {
                                            throw new java.lang.AssertionError("impossible");
                                        }
                                        if (sign(x) < 0) {
                                        }
                                    }
                                }
                                return dNextUp;
                            }
                            return dRoundTodoubleArbitrarily;
                        }
                    }
                case 5:
                    if (iCompareTo < 0) {
                        return com.google.common.math.doubleUtils.nextDown(dRoundTodoubleArbitrarily);
                    }
                    break;
                case 6:
                    if (iCompareTo > 0) {
                        return java.lang.Math.nextUp(dRoundTodoubleArbitrarily);
                    }
                    break;
                case 7:
                    if (sign(x) < 0) {
                        if (iCompareTo < 0) {
                            return com.google.common.math.doubleUtils.nextDown(dRoundTodoubleArbitrarily);
                        }
                    } else if (iCompareTo > 0) {
                        return java.lang.Math.nextUp(dRoundTodoubleArbitrarily);
                    }
                case 8:
                    com.google.common.math.MathPreconditions.checkRoundingUnnecessary(iCompareTo == 0);
                    return dRoundTodoubleArbitrarily;
                default:
                    throw new java.lang.AssertionError("impossible");
            }
        }
        return dRoundTodoubleArbitrarily;
    }

    abstract double RoundTodoubleArbitrarily(X x);

    abstract int Sign(X x);

    abstract X ToX(double d, java.math.RoundingMode roundingMode);
}

