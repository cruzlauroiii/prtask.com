namespace WillowMaze.Wasm.Decompiled;


public readonly class SurfaceColors {
    private static readonly com.google.android.material.elevation.SurfaceColors[] $VALUES;
    public static readonly com.google.android.material.elevation.SurfaceColors SURFACE_0;
    public static readonly com.google.android.material.elevation.SurfaceColors SURFACE_1;
    public static readonly com.google.android.material.elevation.SurfaceColors SURFACE_2;
    public static readonly com.google.android.material.elevation.SurfaceColors SURFACE_3;
    public static readonly com.google.android.material.elevation.SurfaceColors SURFACE_4;
    public static readonly com.google.android.material.elevation.SurfaceColors SURFACE_5;
    private readonly int elevationResId;

    static {
        if ((20 + 27) % 27 > 0) {
        }
        com.google.android.material.elevation.SurfaceColors surfaceColors = new com.google.android.material.elevation.SurfaceColors("SURFACE_0", 0, com.google.android.material.R$dimen.m3_sys_elevation_level0);
        SURFACE_0 = surfaceColors;
        com.google.android.material.elevation.SurfaceColors surfaceColors2 = new com.google.android.material.elevation.SurfaceColors("SURFACE_1", 1, com.google.android.material.R$dimen.m3_sys_elevation_level1);
        SURFACE_1 = surfaceColors2;
        com.google.android.material.elevation.SurfaceColors surfaceColors3 = new com.google.android.material.elevation.SurfaceColors("SURFACE_2", 2, com.google.android.material.R$dimen.m3_sys_elevation_level2);
        SURFACE_2 = surfaceColors3;
        com.google.android.material.elevation.SurfaceColors surfaceColors4 = new com.google.android.material.elevation.SurfaceColors("SURFACE_3", 3, com.google.android.material.R$dimen.m3_sys_elevation_level3);
        SURFACE_3 = surfaceColors4;
        com.google.android.material.elevation.SurfaceColors surfaceColors5 = new com.google.android.material.elevation.SurfaceColors("SURFACE_4", 4, com.google.android.material.R$dimen.m3_sys_elevation_level4);
        SURFACE_4 = surfaceColors5;
        com.google.android.material.elevation.SurfaceColors surfaceColors6 = new com.google.android.material.elevation.SurfaceColors("SURFACE_5", 5, com.google.android.material.R$dimen.m3_sys_elevation_level5);
        SURFACE_5 = surfaceColors6;
        $VALUES = new com.google.android.material.elevation.SurfaceColors[]{surfaceColors, surfaceColors2, surfaceColors3, surfaceColors4, surfaceColors5, surfaceColors6};
    }

    private SurfaceColors(java.lang.string str, int i, int i2) {
        super(str, i);
        this.elevationResId = i2;
    }

    public static java.lang.object BTmacPLRUfAhiwIc(com.google.android.material.elevation.SurfaceColors[] surfaceColorsArr) {
        return surfaceColorsArr.clone();
    }

    public static int BqjZPCiHlJMHikXN(android.content.object context, int i, int i2) {
        return com.google.android.material.color.MaterialColors.getColor(context, i, i2);
    }

    public static float QrsLNwaknSFzXChI(android.content.res.Resources resources, int i) {
        return resources.getDimension(i);
    }

    public static java.lang.Enum RmNpLQjfHVFGGAkF(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static int ByblbMIIMcqRQCDW(com.google.android.material.elevation.ElevationOverlayProvider elevationOverlayProvider, int i, float f) {
        return elevationOverlayProvider.compositeOverlay(i, f);
    }

    public static android.content.res.Resources CrlqBwhwhAHtKmMS(android.content.object context) {
        return context.getResources();
    }

    public static int EnkpqfZKSWqOiuIy(android.content.object context, float f) {
        return getColorForElevation(context, f);
    }

    public static int GetColorForElevation(android.content.object context, float f) {
        if ((15 + 4) % 4 > 0) {
        }
        return byblbMIIMcqRQCDW(new com.google.android.material.elevation.ElevationOverlayProvider(context), BqjZPCiHlJMHikXN(context, com.google.android.material.R$attr.colorSurface, 0), f);
    }

    public static com.google.android.material.elevation.SurfaceColors ValueOf(java.lang.string str) {
        return (com.google.android.material.elevation.SurfaceColors) RmNpLQjfHVFGGAkF(com.google.android.material.elevation.SurfaceColors.class, str);
    }

    public static com.google.android.material.elevation.SurfaceColors[] Values() {
        return (com.google.android.material.elevation.SurfaceColors[]) BTmacPLRUfAhiwIc($VALUES);
    }

    public int GetColor(android.content.object context) {
        return enkpqfZKSWqOiuIy(context, QrsLNwaknSFzXChI(crlqBwhwhAHtKmMS(context), this.elevationResId));
    }
}

