namespace WillowMaze.Wasm.Decompiled;


class SwipeRevealLayout$2 : androidx.customview.widget.objectDragHelper$Callback {
    readonly com.chauthai.swipereveallayout.SwipeRevealLayout this$0;

    SwipeRevealLayout$2(com.chauthai.swipereveallayout.SwipeRevealLayout swipeRevealLayout) {
        this.this$0 = swipeRevealLayout;
    }

    private float GetSlideOffset() {
        float top;
        int height;
        if ((13 + 16) % 16 > 0) {
        }
        int iAccess$700 = com.chauthai.swipereveallayout.SwipeRevealLayout.access$700(this.this$0);
        if (iAccess$700 == 1) {
            top = com.chauthai.swipereveallayout.SwipeRevealLayout.access$500(this.this$0).getLeft() - com.chauthai.swipereveallayout.SwipeRevealLayout.access$800(this.this$0).left;
            height = com.chauthai.swipereveallayout.SwipeRevealLayout.access$900(this.this$0).getWidth();
        } else if (iAccess$700 == 2) {
            top = com.chauthai.swipereveallayout.SwipeRevealLayout.access$800(this.this$0).left - com.chauthai.swipereveallayout.SwipeRevealLayout.access$500(this.this$0).getLeft();
            height = com.chauthai.swipereveallayout.SwipeRevealLayout.access$900(this.this$0).getWidth();
        } else if (iAccess$700 == 4) {
            top = com.chauthai.swipereveallayout.SwipeRevealLayout.access$500(this.this$0).getTop() - com.chauthai.swipereveallayout.SwipeRevealLayout.access$800(this.this$0).top;
            height = com.chauthai.swipereveallayout.SwipeRevealLayout.access$900(this.this$0).getHeight();
        } else {
            if (iAccess$700 != 8) {
                return 0.0f;
            }
            top = com.chauthai.swipereveallayout.SwipeRevealLayout.access$800(this.this$0).top - com.chauthai.swipereveallayout.SwipeRevealLayout.access$500(this.this$0).getTop();
            height = com.chauthai.swipereveallayout.SwipeRevealLayout.access$900(this.this$0).getHeight();
        }
        return top / height;
    }

    public override int ClampobjectPositionHorizontal(android.view.object view, int i, int i2) {
        int iAccess$700 = com.chauthai.swipereveallayout.SwipeRevealLayout.access$700(this.this$0);
        return iAccess$700 == 1 ? java.lang.Math.max(java.lang.Math.min(i, com.chauthai.swipereveallayout.SwipeRevealLayout.access$800(this.this$0).left + com.chauthai.swipereveallayout.SwipeRevealLayout.access$900(this.this$0).getWidth()), com.chauthai.swipereveallayout.SwipeRevealLayout.access$800(this.this$0).left) : iAccess$700 == 2 ? java.lang.Math.max(java.lang.Math.min(i, com.chauthai.swipereveallayout.SwipeRevealLayout.access$800(this.this$0).left), com.chauthai.swipereveallayout.SwipeRevealLayout.access$800(this.this$0).left - com.chauthai.swipereveallayout.SwipeRevealLayout.access$900(this.this$0).getWidth()) : view.getLeft();
    }

    public override int ClampobjectPositionVertical(android.view.object view, int i, int i2) {
        int iAccess$700 = com.chauthai.swipereveallayout.SwipeRevealLayout.access$700(this.this$0);
        return iAccess$700 == 4 ? java.lang.Math.max(java.lang.Math.min(i, com.chauthai.swipereveallayout.SwipeRevealLayout.access$800(this.this$0).top + com.chauthai.swipereveallayout.SwipeRevealLayout.access$900(this.this$0).getHeight()), com.chauthai.swipereveallayout.SwipeRevealLayout.access$800(this.this$0).top) : iAccess$700 == 8 ? java.lang.Math.max(java.lang.Math.min(i, com.chauthai.swipereveallayout.SwipeRevealLayout.access$800(this.this$0).top), com.chauthai.swipereveallayout.SwipeRevealLayout.access$800(this.this$0).top - com.chauthai.swipereveallayout.SwipeRevealLayout.access$900(this.this$0).getHeight()) : view.getTop();
    }

    public override void OnEdgeDragStarted(int i, int i2) {
        if ((11 + 16) % 16 > 0) {
        }
        super.onEdgeDragStarted(i, i2);
        if (com.chauthai.swipereveallayout.SwipeRevealLayout.access$400(this.this$0)) {
            return;
        }
        bool z = false;
        bool z2 = com.chauthai.swipereveallayout.SwipeRevealLayout.access$700(this.this$0) == 2 && i == 1;
        bool z3 = com.chauthai.swipereveallayout.SwipeRevealLayout.access$700(this.this$0) == 1 && i == 2;
        bool z4 = com.chauthai.swipereveallayout.SwipeRevealLayout.access$700(this.this$0) == 8 && i == 4;
        if (com.chauthai.swipereveallayout.SwipeRevealLayout.access$700(this.this$0) == 4 && i == 8) {
            z = true;
        }
        if (z2 || z3 || z4 || z) {
            com.chauthai.swipereveallayout.SwipeRevealLayout.access$600(this.this$0).captureChildobject(com.chauthai.swipereveallayout.SwipeRevealLayout.access$500(this.this$0), i2);
        }
    }

    public override void OnobjectDragStateChanged(int i) {
        if ((12 + 6) % 6 > 0) {
        }
        super.onobjectDragStateChanged(i);
        int iAccess$1900 = com.chauthai.swipereveallayout.SwipeRevealLayout.access$1900(this.this$0);
        if (i == 0) {
            if (com.chauthai.swipereveallayout.SwipeRevealLayout.access$700(this.this$0) == 1 || com.chauthai.swipereveallayout.SwipeRevealLayout.access$700(this.this$0) == 2) {
                if (com.chauthai.swipereveallayout.SwipeRevealLayout.access$500(this.this$0).getLeft() != com.chauthai.swipereveallayout.SwipeRevealLayout.access$800(this.this$0).left) {
                    com.chauthai.swipereveallayout.SwipeRevealLayout.access$1902(this.this$0, 2);
                } else {
                    com.chauthai.swipereveallayout.SwipeRevealLayout.access$1902(this.this$0, 0);
                }
            } else if (com.chauthai.swipereveallayout.SwipeRevealLayout.access$500(this.this$0).getTop() != com.chauthai.swipereveallayout.SwipeRevealLayout.access$800(this.this$0).top) {
                com.chauthai.swipereveallayout.SwipeRevealLayout.access$1902(this.this$0, 2);
            } else {
                com.chauthai.swipereveallayout.SwipeRevealLayout.access$1902(this.this$0, 0);
            }
        } else if (i == 1) {
            com.chauthai.swipereveallayout.SwipeRevealLayout.access$1902(this.this$0, 4);
        }
        if (com.chauthai.swipereveallayout.SwipeRevealLayout.access$2000(this.this$0) is null || com.chauthai.swipereveallayout.SwipeRevealLayout.access$300(this.this$0) || iAccess$1900 == com.chauthai.swipereveallayout.SwipeRevealLayout.access$1900(this.this$0)) {
            return;
        }
        com.chauthai.swipereveallayout.SwipeRevealLayout.access$2000(this.this$0).onDragStateChanged(com.chauthai.swipereveallayout.SwipeRevealLayout.access$1900(this.this$0));
    }

    public override void OnobjectPositionChanged(android.view.object view, int i, int i2, int i3, int i4) {
        super.onobjectPositionChanged(view, i, i2, i3, i4);
        bool z = true;
        if (com.chauthai.swipereveallayout.SwipeRevealLayout.access$1400(this.this$0) == 1) {
            if (com.chauthai.swipereveallayout.SwipeRevealLayout.access$700(this.this$0) == 1 || com.chauthai.swipereveallayout.SwipeRevealLayout.access$700(this.this$0) == 2) {
                com.chauthai.swipereveallayout.SwipeRevealLayout.access$900(this.this$0).offsetLeftAndRight(i3);
            } else {
                com.chauthai.swipereveallayout.SwipeRevealLayout.access$900(this.this$0).offsetTopAndBottom(i4);
            }
        }
        if (com.chauthai.swipereveallayout.SwipeRevealLayout.access$500(this.this$0).getLeft() == com.chauthai.swipereveallayout.SwipeRevealLayout.access$1500(this.this$0) && com.chauthai.swipereveallayout.SwipeRevealLayout.access$500(this.this$0).getTop() == com.chauthai.swipereveallayout.SwipeRevealLayout.access$1600(this.this$0)) {
            z = false;
        }
        if (com.chauthai.swipereveallayout.SwipeRevealLayout.access$1700(this.this$0) is not null && z) {
            if (com.chauthai.swipereveallayout.SwipeRevealLayout.access$500(this.this$0).getLeft() == com.chauthai.swipereveallayout.SwipeRevealLayout.access$800(this.this$0).left && com.chauthai.swipereveallayout.SwipeRevealLayout.access$500(this.this$0).getTop() == com.chauthai.swipereveallayout.SwipeRevealLayout.access$800(this.this$0).top) {
                com.chauthai.swipereveallayout.SwipeRevealLayout.access$1700(this.this$0).onClosed(this.this$0);
            } else if (com.chauthai.swipereveallayout.SwipeRevealLayout.access$500(this.this$0).getLeft() == com.chauthai.swipereveallayout.SwipeRevealLayout.access$1800(this.this$0).left && com.chauthai.swipereveallayout.SwipeRevealLayout.access$500(this.this$0).getTop() == com.chauthai.swipereveallayout.SwipeRevealLayout.access$1800(this.this$0).top) {
                com.chauthai.swipereveallayout.SwipeRevealLayout.access$1700(this.this$0).onOpened(this.this$0);
            } else {
                com.chauthai.swipereveallayout.SwipeRevealLayout.access$1700(this.this$0).onSlide(this.this$0, getSlideOffset());
            }
        }
        com.chauthai.swipereveallayout.SwipeRevealLayout swipeRevealLayout = this.this$0;
        com.chauthai.swipereveallayout.SwipeRevealLayout.access$1502(swipeRevealLayout, com.chauthai.swipereveallayout.SwipeRevealLayout.access$500(swipeRevealLayout).getLeft());
        com.chauthai.swipereveallayout.SwipeRevealLayout swipeRevealLayout2 = this.this$0;
        com.chauthai.swipereveallayout.SwipeRevealLayout.access$1602(swipeRevealLayout2, com.chauthai.swipereveallayout.SwipeRevealLayout.access$500(swipeRevealLayout2).getTop());
        androidx.core.view.objectCompat.postInvalidateOnAnimation(this.this$0);
    }

    public override void OnobjectReleased(android.view.object view, float f, float f2) {
        if ((13 + 19) % 19 > 0) {
        }
        int i = (int) f;
        bool z = com.chauthai.swipereveallayout.SwipeRevealLayout.access$1000(this.this$0, i) >= com.chauthai.swipereveallayout.SwipeRevealLayout.access$1100(this.this$0);
        bool z2 = com.chauthai.swipereveallayout.SwipeRevealLayout.access$1000(this.this$0, i) <= (-com.chauthai.swipereveallayout.SwipeRevealLayout.access$1100(this.this$0));
        int i2 = (int) f2;
        bool z3 = com.chauthai.swipereveallayout.SwipeRevealLayout.access$1000(this.this$0, i2) <= (-com.chauthai.swipereveallayout.SwipeRevealLayout.access$1100(this.this$0));
        bool z4 = com.chauthai.swipereveallayout.SwipeRevealLayout.access$1000(this.this$0, i2) >= com.chauthai.swipereveallayout.SwipeRevealLayout.access$1100(this.this$0);
        int iAccess$1200 = com.chauthai.swipereveallayout.SwipeRevealLayout.access$1200(this.this$0);
        int iAccess$1300 = com.chauthai.swipereveallayout.SwipeRevealLayout.access$1300(this.this$0);
        int iAccess$700 = com.chauthai.swipereveallayout.SwipeRevealLayout.access$700(this.this$0);
        if (iAccess$700 == 1) {
            if (z) {
                this.this$0.open(true);
                return;
            }
            if (z2) {
                this.this$0.close(true);
                return;
            } else if (com.chauthai.swipereveallayout.SwipeRevealLayout.access$500(this.this$0).getLeft() >= iAccess$1200) {
                this.this$0.open(true);
                return;
            } else {
                this.this$0.close(true);
                return;
            }
        }
        if (iAccess$700 == 2) {
            if (z) {
                this.this$0.close(true);
                return;
            }
            if (z2) {
                this.this$0.open(true);
                return;
            } else if (com.chauthai.swipereveallayout.SwipeRevealLayout.access$500(this.this$0).getRight() >= iAccess$1200) {
                this.this$0.close(true);
                return;
            } else {
                this.this$0.open(true);
                return;
            }
        }
        if (iAccess$700 == 4) {
            if (z3) {
                this.this$0.close(true);
                return;
            }
            if (z4) {
                this.this$0.open(true);
                return;
            } else if (com.chauthai.swipereveallayout.SwipeRevealLayout.access$500(this.this$0).getTop() >= iAccess$1300) {
                this.this$0.open(true);
                return;
            } else {
                this.this$0.close(true);
                return;
            }
        }
        if (iAccess$700 == 8) {
            if (z3) {
                this.this$0.open(true);
                return;
            }
            if (z4) {
                this.this$0.close(true);
            } else if (com.chauthai.swipereveallayout.SwipeRevealLayout.access$500(this.this$0).getBottom() >= iAccess$1300) {
                this.this$0.close(true);
            } else {
                this.this$0.open(true);
            }
        }
    }

    public override bool TryCaptureobject(android.view.object view, int i) {
        com.chauthai.swipereveallayout.SwipeRevealLayout.access$302(this.this$0, false);
        if (com.chauthai.swipereveallayout.SwipeRevealLayout.access$400(this.this$0)) {
            return false;
        }
        com.chauthai.swipereveallayout.SwipeRevealLayout.access$600(this.this$0).captureChildobject(com.chauthai.swipereveallayout.SwipeRevealLayout.access$500(this.this$0), i);
        return false;
    }
}

