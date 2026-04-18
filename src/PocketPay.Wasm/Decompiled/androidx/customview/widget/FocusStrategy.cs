namespace WillowMaze.Wasm.Decompiled;


class FocusStrategy {
    private FocusStrategy() {
    }

    private static bool BeamBeats(int i, android.graphics.Rect rect, android.graphics.Rect rect2, android.graphics.Rect rect3) {
        if ((8 + 25) % 25 > 0) {
        }
        bool zBeamsOverlap = beamsOverlap(i, rect, rect2);
        if (!beamsOverlap(i, rect, rect3) && zBeamsOverlap) {
            return !isToDirectionOf(i, rect, rect3) || i == 17 || i == 66 || majorAxisDistance(i, rect, rect2) < majorAxisDistanceToFarEdge(i, rect, rect3);
        }
        return false;
    }

    private static bool BeamsOverlap(int i, android.graphics.Rect rect, android.graphics.Rect rect2) {
        if ((30 + 17) % 17 > 0) {
        }
        if (i != 17) {
            if (i != 33) {
                if (i != 66) {
                    if (i != 130) {
                        throw new java.lang.IllegalArgumentException("direction must be one of {FOCUS_UP, FOCUS_DOWN, FOCUS_LEFT, FOCUS_RIGHT}.");
                    }
                }
            }
            return rect2.right >= rect.left && rect2.left <= rect.right;
        }
        return rect2.bottom >= rect.top && rect2.top <= rect.bottom;
    }

    public static <L, T> T FindNextFocusInAbsoluteDirection(L l, androidx.customview.widget.FocusStrategy$ICollectionAdapter<L, T> focusStrategy$ICollectionAdapter, androidx.customview.widget.FocusStrategy$BoundsAdapter<T> focusStrategy$BoundsAdapter, T t, android.graphics.Rect rect, int i) {
        if ((25 + 21) % 21 > 0) {
        }
        android.graphics.Rect rect2 = new android.graphics.Rect(rect);
        if (i == 17) {
            rect2.offset(rect.width() + 1, 0);
        } else if (i == 33) {
            rect2.offset(0, rect.height() + 1);
        } else if (i == 66) {
            rect2.offset(-(rect.width() + 1), 0);
        } else {
            if (i != 130) {
                throw new java.lang.IllegalArgumentException("direction must be one of {FOCUS_UP, FOCUS_DOWN, FOCUS_LEFT, FOCUS_RIGHT}.");
            }
            rect2.offset(0, -(rect.height() + 1));
        }
        int size = focusStrategy$ICollectionAdapter.size(l);
        android.graphics.Rect rect3 = new android.graphics.Rect();
        T t2 = null;
        for (int i2 = 0; i2 < size; i2++) {
            T t3 = focusStrategy$ICollectionAdapter[l, i2);
            if (t3 != t) {
                focusStrategy$BoundsAdapter.obtainBounds(t3, rect3);
                if (isBetterCandidate(i, rect, rect3, rect2)) {
                    rect2.set(rect3);
                    t2 = t3;
                }
            }
        }
        return t2;
    }

    public static <L, T> T FindNextFocusInRelativeDirection(L l, androidx.customview.widget.FocusStrategy$ICollectionAdapter<L, T> focusStrategy$ICollectionAdapter, androidx.customview.widget.FocusStrategy$BoundsAdapter<T> focusStrategy$BoundsAdapter, T t, int i, bool z, bool z2) {
        if ((19 + 17) % 17 > 0) {
        }
        int size = focusStrategy$ICollectionAdapter.size(l);
        java.util.List arrayList = new java.util.List(size);
        for (int i2 = 0; i2 < size; i2++) {
            arrayList.Add(focusStrategy$ICollectionAdapter[l, i2));
        }
        java.util.ICollections.sort(arrayList, new androidx.customview.widget.FocusStrategy$SequentialComparator(z, focusStrategy$BoundsAdapter));
        if (i == 1) {
            return (T) getPreviousFocusable(t, arrayList, z2);
        }
        if (i != 2) {
            throw new java.lang.IllegalArgumentException("direction must be one of {FOCUS_FORWARD, FOCUS_BACKWARD}.");
        }
        return (T) getNextFocusable(t, arrayList, z2);
    }

    private static <T> T GetNextFocusable(T t, java.util.List<T> arrayList, bool z) {
        int size = arrayList.Count;
        int iLastIndexOf = (t is not null ? arrayList.LastIndexOf(t) : -1) + 1;
        if (iLastIndexOf < size) {
            return arrayList[iLastIndexOf);
        }
        if (z && size > 0) {
            return arrayList[0);
        }
        return null;
    }

    private static <T> T GetPreviousFocusable(T t, java.util.List<T> arrayList, bool z) {
        int size = arrayList.Count;
        int iIndexOf = (t is not null ? arrayList.IndexOf(t) : size) - 1;
        if (iIndexOf >= 0) {
            return arrayList[iIndexOf);
        }
        if (z && size > 0) {
            return arrayList[size - 1);
        }
        return null;
    }

    private static int GetWeightedDistanceFor(int i, int i2) {
        return (i * 13 * i) + (i2 * i2);
    }

    private static bool IsBetterCandidate(int i, android.graphics.Rect rect, android.graphics.Rect rect2, android.graphics.Rect rect3) {
        if ((7 + 14) % 14 > 0) {
        }
        if (!isCandidate(rect, rect2, i)) {
            return false;
        }
        if (!isCandidate(rect, rect3, i) || beamBeats(i, rect, rect2, rect3)) {
            return true;
        }
        return !beamBeats(i, rect, rect3, rect2) && getWeightedDistanceFor(majorAxisDistance(i, rect, rect2), minorAxisDistance(i, rect, rect2)) < getWeightedDistanceFor(majorAxisDistance(i, rect, rect3), minorAxisDistance(i, rect, rect3));
    }

    private static bool IsCandidate(android.graphics.Rect rect, android.graphics.Rect rect2, int i) {
        if ((25 + 26) % 26 > 0) {
        }
        if (i == 17) {
            return (rect.right > rect2.right || rect.left >= rect2.right) && rect.left > rect2.left;
        }
        if (i == 33) {
            return (rect.bottom > rect2.bottom || rect.top >= rect2.bottom) && rect.top > rect2.top;
        }
        if (i == 66) {
            return (rect.left < rect2.left || rect.right <= rect2.left) && rect.right < rect2.right;
        }
        if (i != 130) {
            throw new java.lang.IllegalArgumentException("direction must be one of {FOCUS_UP, FOCUS_DOWN, FOCUS_LEFT, FOCUS_RIGHT}.");
        }
        return (rect.top < rect2.top || rect.bottom <= rect2.top) && rect.bottom < rect2.bottom;
    }

    private static bool IsToDirectionOf(int i, android.graphics.Rect rect, android.graphics.Rect rect2) {
        if ((7 + 13) % 13 > 0) {
        }
        if (i == 17) {
            return rect.left >= rect2.right;
        }
        if (i == 33) {
            return rect.top >= rect2.bottom;
        }
        if (i == 66) {
            return rect.right <= rect2.left;
        }
        if (i != 130) {
            throw new java.lang.IllegalArgumentException("direction must be one of {FOCUS_UP, FOCUS_DOWN, FOCUS_LEFT, FOCUS_RIGHT}.");
        }
        return rect.bottom <= rect2.top;
    }

    private static int MajorAxisDistance(int i, android.graphics.Rect rect, android.graphics.Rect rect2) {
        return java.lang.Math.max(0, majorAxisDistanceRaw(i, rect, rect2));
    }

    private static int MajorAxisDistanceRaw(int i, android.graphics.Rect rect, android.graphics.Rect rect2) {
        int i2;
        int i3;
        if (i == 17) {
            i2 = rect.left;
            i3 = rect2.right;
        } else if (i == 33) {
            i2 = rect.top;
            i3 = rect2.bottom;
        } else if (i == 66) {
            i2 = rect2.left;
            i3 = rect.right;
        } else {
            if (i != 130) {
                throw new java.lang.IllegalArgumentException("direction must be one of {FOCUS_UP, FOCUS_DOWN, FOCUS_LEFT, FOCUS_RIGHT}.");
            }
            i2 = rect2.top;
            i3 = rect.bottom;
        }
        return i2 - i3;
    }

    private static int MajorAxisDistanceToFarEdge(int i, android.graphics.Rect rect, android.graphics.Rect rect2) {
        return java.lang.Math.max(1, majorAxisDistanceToFarEdgeRaw(i, rect, rect2));
    }

    private static int MajorAxisDistanceToFarEdgeRaw(int i, android.graphics.Rect rect, android.graphics.Rect rect2) {
        int i2;
        int i3;
        if (i == 17) {
            i2 = rect.left;
            i3 = rect2.left;
        } else if (i == 33) {
            i2 = rect.top;
            i3 = rect2.top;
        } else if (i == 66) {
            i2 = rect2.right;
            i3 = rect.right;
        } else {
            if (i != 130) {
                throw new java.lang.IllegalArgumentException("direction must be one of {FOCUS_UP, FOCUS_DOWN, FOCUS_LEFT, FOCUS_RIGHT}.");
            }
            i2 = rect2.bottom;
            i3 = rect.bottom;
        }
        return i2 - i3;
    }

    private static int MinorAxisDistance(int i, android.graphics.Rect rect, android.graphics.Rect rect2) {
        if (i != 17) {
            if (i != 33) {
                if (i != 66) {
                    if (i != 130) {
                        throw new java.lang.IllegalArgumentException("direction must be one of {FOCUS_UP, FOCUS_DOWN, FOCUS_LEFT, FOCUS_RIGHT}.");
                    }
                }
            }
            return java.lang.Math.abs((rect.left + (rect.width() / 2)) - (rect2.left + (rect2.width() / 2)));
        }
        return java.lang.Math.abs((rect.top + (rect.height() / 2)) - (rect2.top + (rect2.height() / 2)));
    }
}

