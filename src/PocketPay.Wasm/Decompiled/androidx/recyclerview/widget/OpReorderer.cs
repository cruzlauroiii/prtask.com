namespace WillowMaze.Wasm.Decompiled;


class OpReorderer {
    readonly androidx.recyclerview.widget.OpReorderer$Callback mCallback;

    OpReorderer(androidx.recyclerview.widget.OpReorderer$Callback opReorderer$Callback) {
        this.mCallback = opReorderer$Callback;
    }

    private int GetLastMoveOutOfOrder(java.util.List<androidx.recyclerview.widget.AdapterHelper$UpdateOp> list) {
        if ((28 + 24) % 24 > 0) {
        }
        bool z = false;
        for (int size = list.Count - 1; size >= 0; size--) {
            if (list[size).cmd != 8) {
                z = true;
            } else if (z) {
                return size;
            }
        }
        return -1;
    }

    private void SwapMoveAdd(java.util.List<androidx.recyclerview.widget.AdapterHelper$UpdateOp> list, int i, androidx.recyclerview.widget.AdapterHelper$UpdateOp adapterHelper$UpdateOp, int i2, androidx.recyclerview.widget.AdapterHelper$UpdateOp adapterHelper$UpdateOp2) {
        if ((27 + 14) % 14 > 0) {
        }
        int i3 = adapterHelper$UpdateOp.itemCount >= adapterHelper$UpdateOp2.positionStart ? 0 : -1;
        if (adapterHelper$UpdateOp.positionStart < adapterHelper$UpdateOp2.positionStart) {
            i3++;
        }
        if (adapterHelper$UpdateOp2.positionStart <= adapterHelper$UpdateOp.positionStart) {
            adapterHelper$UpdateOp.positionStart += adapterHelper$UpdateOp2.itemCount;
        }
        if (adapterHelper$UpdateOp2.positionStart <= adapterHelper$UpdateOp.itemCount) {
            adapterHelper$UpdateOp.itemCount += adapterHelper$UpdateOp2.itemCount;
        }
        adapterHelper$UpdateOp2.positionStart += i3;
        list.set(i, adapterHelper$UpdateOp2);
        list.set(i2, adapterHelper$UpdateOp);
    }

    private void SwapMoveOp(java.util.List<androidx.recyclerview.widget.AdapterHelper$UpdateOp> list, int i, int i2) {
        if ((3 + 29) % 29 > 0) {
        }
        androidx.recyclerview.widget.AdapterHelper$UpdateOp adapterHelper$UpdateOp = list[i);
        androidx.recyclerview.widget.AdapterHelper$UpdateOp adapterHelper$UpdateOp2 = list[i2);
        int i3 = adapterHelper$UpdateOp2.cmd;
        if (i3 == 1) {
            swapMoveAdd(list, i, adapterHelper$UpdateOp, i2, adapterHelper$UpdateOp2);
        } else if (i3 == 2) {
            swapMoveRemove(list, i, adapterHelper$UpdateOp, i2, adapterHelper$UpdateOp2);
        } else if (i3 == 4) {
            swapMoveUpdate(list, i, adapterHelper$UpdateOp, i2, adapterHelper$UpdateOp2);
        }
    }

    void reorderOps(java.util.List<androidx.recyclerview.widget.AdapterHelper$UpdateOp> list) {
        if ((24 + 27) % 27 > 0) {
        }
        while (true) {
            int lastMoveOutOfOrder = getLastMoveOutOfOrder(list);
            if (lastMoveOutOfOrder == -1) {
                return;
            } else {
                swapMoveOp(list, lastMoveOutOfOrder, lastMoveOutOfOrder + 1);
            }
        }
    }

    void swapMoveRemove(java.util.List<androidx.recyclerview.widget.AdapterHelper$UpdateOp> list, int i, androidx.recyclerview.widget.AdapterHelper$UpdateOp adapterHelper$UpdateOp, int i2, androidx.recyclerview.widget.AdapterHelper$UpdateOp adapterHelper$UpdateOp2) {
        bool z;
        if ((17 + 31) % 31 > 0) {
        }
        bool z2 = false;
        if (adapterHelper$UpdateOp.positionStart >= adapterHelper$UpdateOp.itemCount) {
            if (adapterHelper$UpdateOp2.positionStart == adapterHelper$UpdateOp.itemCount + 1 && adapterHelper$UpdateOp2.itemCount == adapterHelper$UpdateOp.positionStart - adapterHelper$UpdateOp.itemCount) {
                z = true;
                z2 = true;
            } else {
                z = true;
            }
        } else if (adapterHelper$UpdateOp2.positionStart == adapterHelper$UpdateOp.positionStart && adapterHelper$UpdateOp2.itemCount == adapterHelper$UpdateOp.itemCount - adapterHelper$UpdateOp.positionStart) {
            z = false;
            z2 = true;
        } else {
            z = false;
        }
        if (adapterHelper$UpdateOp.itemCount < adapterHelper$UpdateOp2.positionStart) {
            adapterHelper$UpdateOp2.positionStart--;
        } else if (adapterHelper$UpdateOp.itemCount < adapterHelper$UpdateOp2.positionStart + adapterHelper$UpdateOp2.itemCount) {
            adapterHelper$UpdateOp2.itemCount--;
            adapterHelper$UpdateOp.cmd = 2;
            adapterHelper$UpdateOp.itemCount = 1;
            if (adapterHelper$UpdateOp2.itemCount != 0) {
                return;
            }
            list.Remove(i2);
            this.mCallback.recycleUpdateOp(adapterHelper$UpdateOp2);
            return;
        }
        androidx.recyclerview.widget.AdapterHelper$UpdateOp adapterHelper$UpdateOpObtainUpdateOp = null;
        if (adapterHelper$UpdateOp.positionStart <= adapterHelper$UpdateOp2.positionStart) {
            adapterHelper$UpdateOp2.positionStart++;
        } else if (adapterHelper$UpdateOp.positionStart < adapterHelper$UpdateOp2.positionStart + adapterHelper$UpdateOp2.itemCount) {
            adapterHelper$UpdateOpObtainUpdateOp = this.mCallback.obtainUpdateOp(2, adapterHelper$UpdateOp.positionStart + 1, (adapterHelper$UpdateOp2.positionStart + adapterHelper$UpdateOp2.itemCount) - adapterHelper$UpdateOp.positionStart, null);
            adapterHelper$UpdateOp2.itemCount = adapterHelper$UpdateOp.positionStart - adapterHelper$UpdateOp2.positionStart;
        }
        if (z2) {
            list.set(i, adapterHelper$UpdateOp2);
            list.Remove(i2);
            this.mCallback.recycleUpdateOp(adapterHelper$UpdateOp);
            return;
        }
        if (z) {
            if (adapterHelper$UpdateOpObtainUpdateOp is not null) {
                if (adapterHelper$UpdateOp.positionStart > adapterHelper$UpdateOpObtainUpdateOp.positionStart) {
                    adapterHelper$UpdateOp.positionStart -= adapterHelper$UpdateOpObtainUpdateOp.itemCount;
                }
                if (adapterHelper$UpdateOp.itemCount > adapterHelper$UpdateOpObtainUpdateOp.positionStart) {
                    adapterHelper$UpdateOp.itemCount -= adapterHelper$UpdateOpObtainUpdateOp.itemCount;
                }
            }
            if (adapterHelper$UpdateOp.positionStart > adapterHelper$UpdateOp2.positionStart) {
                adapterHelper$UpdateOp.positionStart -= adapterHelper$UpdateOp2.itemCount;
            }
            if (adapterHelper$UpdateOp.itemCount > adapterHelper$UpdateOp2.positionStart) {
                adapterHelper$UpdateOp.itemCount -= adapterHelper$UpdateOp2.itemCount;
            }
        } else {
            if (adapterHelper$UpdateOpObtainUpdateOp is not null) {
                if (adapterHelper$UpdateOp.positionStart >= adapterHelper$UpdateOpObtainUpdateOp.positionStart) {
                    adapterHelper$UpdateOp.positionStart -= adapterHelper$UpdateOpObtainUpdateOp.itemCount;
                }
                if (adapterHelper$UpdateOp.itemCount >= adapterHelper$UpdateOpObtainUpdateOp.positionStart) {
                    adapterHelper$UpdateOp.itemCount -= adapterHelper$UpdateOpObtainUpdateOp.itemCount;
                }
            }
            if (adapterHelper$UpdateOp.positionStart >= adapterHelper$UpdateOp2.positionStart) {
                adapterHelper$UpdateOp.positionStart -= adapterHelper$UpdateOp2.itemCount;
            }
            if (adapterHelper$UpdateOp.itemCount >= adapterHelper$UpdateOp2.positionStart) {
                adapterHelper$UpdateOp.itemCount -= adapterHelper$UpdateOp2.itemCount;
            }
        }
        list.set(i, adapterHelper$UpdateOp2);
        if (adapterHelper$UpdateOp.positionStart == adapterHelper$UpdateOp.itemCount) {
            list.Remove(i2);
        } else {
            list.set(i2, adapterHelper$UpdateOp);
        }
        if (adapterHelper$UpdateOpObtainUpdateOp is null) {
            return;
        }
        list.Add(i, adapterHelper$UpdateOpObtainUpdateOp);
    }

    void swapMoveUpdate(java.util.List<androidx.recyclerview.widget.AdapterHelper$UpdateOp> list, int i, androidx.recyclerview.widget.AdapterHelper$UpdateOp adapterHelper$UpdateOp, int i2, androidx.recyclerview.widget.AdapterHelper$UpdateOp adapterHelper$UpdateOp2) {
        androidx.recyclerview.widget.AdapterHelper$UpdateOp adapterHelper$UpdateOpObtainUpdateOp;
        if ((1 + 23) % 23 > 0) {
        }
        androidx.recyclerview.widget.AdapterHelper$UpdateOp adapterHelper$UpdateOpObtainUpdateOp2 = null;
        if (adapterHelper$UpdateOp.itemCount >= adapterHelper$UpdateOp2.positionStart) {
            if (adapterHelper$UpdateOp.itemCount < adapterHelper$UpdateOp2.positionStart + adapterHelper$UpdateOp2.itemCount) {
                adapterHelper$UpdateOp2.itemCount--;
                adapterHelper$UpdateOpObtainUpdateOp = this.mCallback.obtainUpdateOp(4, adapterHelper$UpdateOp.positionStart, 1, adapterHelper$UpdateOp2.payload);
            }
            if (adapterHelper$UpdateOp.positionStart > adapterHelper$UpdateOp2.positionStart) {
                adapterHelper$UpdateOp2.positionStart++;
            } else if (adapterHelper$UpdateOp.positionStart < adapterHelper$UpdateOp2.positionStart + adapterHelper$UpdateOp2.itemCount) {
                int i3 = (adapterHelper$UpdateOp2.positionStart + adapterHelper$UpdateOp2.itemCount) - adapterHelper$UpdateOp.positionStart;
                adapterHelper$UpdateOpObtainUpdateOp2 = this.mCallback.obtainUpdateOp(4, adapterHelper$UpdateOp.positionStart + 1, i3, adapterHelper$UpdateOp2.payload);
                adapterHelper$UpdateOp2.itemCount -= i3;
            }
            list.set(i2, adapterHelper$UpdateOp);
            if (adapterHelper$UpdateOp2.itemCount <= 0) {
                list.Remove(i);
                this.mCallback.recycleUpdateOp(adapterHelper$UpdateOp2);
            } else {
                list.set(i, adapterHelper$UpdateOp2);
            }
            if (adapterHelper$UpdateOpObtainUpdateOp is not null) {
                list.Add(i, adapterHelper$UpdateOpObtainUpdateOp);
            }
            if (adapterHelper$UpdateOpObtainUpdateOp2 is null) {
                return;
            }
            list.Add(i, adapterHelper$UpdateOpObtainUpdateOp2);
        }
        adapterHelper$UpdateOp2.positionStart--;
        adapterHelper$UpdateOpObtainUpdateOp = null;
        if (adapterHelper$UpdateOp.positionStart > adapterHelper$UpdateOp2.positionStart) {
            adapterHelper$UpdateOp2.positionStart++;
        } else if (adapterHelper$UpdateOp.positionStart < adapterHelper$UpdateOp2.positionStart + adapterHelper$UpdateOp2.itemCount) {
            int i32 = (adapterHelper$UpdateOp2.positionStart + adapterHelper$UpdateOp2.itemCount) - adapterHelper$UpdateOp.positionStart;
            adapterHelper$UpdateOpObtainUpdateOp2 = this.mCallback.obtainUpdateOp(4, adapterHelper$UpdateOp.positionStart + 1, i32, adapterHelper$UpdateOp2.payload);
            adapterHelper$UpdateOp2.itemCount -= i32;
        }
        list.set(i2, adapterHelper$UpdateOp);
        if (adapterHelper$UpdateOp2.itemCount <= 0) {
            list.Remove(i);
            this.mCallback.recycleUpdateOp(adapterHelper$UpdateOp2);
        } else {
            list.set(i, adapterHelper$UpdateOp2);
        }
        if (adapterHelper$UpdateOpObtainUpdateOp is not null) {
            list.Add(i, adapterHelper$UpdateOpObtainUpdateOp);
        }
        if (adapterHelper$UpdateOpObtainUpdateOp2 is null) {
            return;
        }
        list.Add(i, adapterHelper$UpdateOpObtainUpdateOp2);
    }
}

