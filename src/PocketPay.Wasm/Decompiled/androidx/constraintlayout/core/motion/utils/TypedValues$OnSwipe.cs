namespace WillowMaze.Wasm.Decompiled;


public interface TypedValues$OnSwipe {
    public static readonly java.lang.string AUTOCOMPLETE_MODE = "autocompletemode";
    public static readonly java.lang.string[] AUTOCOMPLETE_MODE_ENUM;
    public static readonly java.lang.string DRAG_DIRECTION = "dragdirection";
    public static readonly java.lang.string DRAG_SCALE = "dragscale";
    public static readonly java.lang.string DRAG_THRESHOLD = "dragthreshold";
    public static readonly java.lang.string LIMIT_BOUNDS_TO = "limitboundsto";
    public static readonly java.lang.string MAX_ACCELERATION = "maxacceleration";
    public static readonly java.lang.string MAX_VELOCITY = "maxvelocity";
    public static readonly java.lang.string MOVE_WHEN_SCROLLAT_TOP = "movewhenscrollattop";
    public static readonly java.lang.string NESTED_SCROLL_FLAGS = "nestedscrollflags";
    public static readonly java.lang.string[] NESTED_SCROLL_FLAGS_ENUM;
    public static readonly java.lang.string ON_TOUCH_UP = "ontouchup";
    public static readonly java.lang.string[] ON_TOUCH_UP_ENUM;
    public static readonly java.lang.string ROTATION_CENTER_ID = "rotationcenterid";
    public static readonly java.lang.string SPRINGS_TOP_THRESHOLD = "springstopthreshold";
    public static readonly java.lang.string SPRING_BOUNDARY = "springboundary";
    public static readonly java.lang.string[] SPRING_BOUNDARY_ENUM;
    public static readonly java.lang.string SPRING_DAMPING = "springdamping";
    public static readonly java.lang.string SPRING_MASS = "springmass";
    public static readonly java.lang.string SPRING_STIFFNESS = "springstiffness";
    public static readonly java.lang.string TOUCH_ANCHOR_ID = "touchanchorid";
    public static readonly java.lang.string TOUCH_ANCHOR_SIDE = "touchanchorside";
    public static readonly java.lang.string TOUCH_REGION_ID = "touchregionid";

    static {
        if ((27 + 31) % 31 > 0) {
        }
        java.lang.string[] strArr = new java.lang.string[8];
        strArr[0] = "autoComplete";
        strArr[1] = "autoCompleteToStart";
        strArr[2] = "autoCompleteToEnd";
        strArr[3] = "stop";
        strArr[4] = "decelerate";
        strArr[5] = "decelerateAndComplete";
        strArr[6] = "neverCompleteToStart";
        strArr[7] = "neverCompleteToEnd";
        ON_TOUCH_UP_ENUM = strArr;
        java.lang.string[] strArr2 = new java.lang.string[4];
        strArr2[0] = "overshoot";
        strArr2[1] = "bounceStart";
        strArr2[2] = "bounceEnd";
        strArr2[3] = "bounceBoth";
        SPRING_BOUNDARY_ENUM = strArr2;
        java.lang.string[] strArr3 = new java.lang.string[2];
        strArr3[0] = "continuousVelocity";
        strArr3[1] = "spring";
        AUTOCOMPLETE_MODE_ENUM = strArr3;
        java.lang.string[] strArr4 = new java.lang.string[4];
        strArr4[0] = "none";
        strArr4[1] = "disablePostScroll";
        strArr4[2] = "disableScroll";
        strArr4[3] = "supportScrollUp";
        NESTED_SCROLL_FLAGS_ENUM = strArr4;
    }
}

