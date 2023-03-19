namespace McSkin;

/// <summary>
/// IDs of all possible skin sections.
/// </summary>
public enum SkinSectionId
{
    /// <summary>
    /// Entire modern (64x64) skin (maps to <see cref="All32"/> for legacy skins).
    /// </summary>
    All = 0,

    /// <summary>
    /// Entire legacy (64x32) skin.
    /// </summary>
    All32,

    /// <summary>
    /// Entire body.
    /// </summary>
    Body,

    /// <summary>
    /// Back of main body.
    /// </summary>
    BodyBack,

    /// <summary>
    /// Bottom of main body.
    /// </summary>
    BodyBottom,

    /// <summary>
    /// Front of main body.
    /// </summary>
    BodyFront,

    /// <summary>
    /// Left of main body.
    /// </summary>
    BodyLeft,

    /// <summary>
    /// Right of main body.
    /// </summary>
    BodyRight,

    /// <summary>
    /// Top of main body.
    /// </summary>
    BodyTop,

    /// <summary>
    /// Entire hat.
    /// </summary>
    Hat,

    /// <summary>
    /// Back of hat.
    /// </summary>
    HatBack,

    /// <summary>
    /// Bottom of hat.
    /// </summary>
    HatBottom,

    /// <summary>
    /// Front of hat.
    /// </summary>
    HatFront,

    /// <summary>
    /// Left of hat.
    /// </summary>
    HatLeft,

    /// <summary>
    /// Right of hat.
    /// </summary>
    HatRight,

    /// <summary>
    /// Top of hat.
    /// </summary>
    HatTop,

    /// <summary>
    /// Head.
    /// </summary>
    Head,

    /// <summary>
    /// Back of head.
    /// </summary>
    HeadBack,

    /// <summary>
    /// Bottom of head.
    /// </summary>
    HeadBottom,

    /// <summary>
    /// Front of head.
    /// </summary>
    HeadFront,

    /// <summary>
    /// Left of head.
    /// </summary>
    HeadLeft,

    /// <summary>
    /// Right of head.
    /// </summary>
    HeadRight,

    /// <summary>
    /// Top of head.
    /// </summary>
    HeadTop,

    /// <summary>
    /// Entire jacket (not available for legacy skins).
    /// </summary>
    Jacket,

    /// <summary>
    /// Back of jacket (not available for legacy skins).
    /// </summary>
    JacketBack,

    /// <summary>
    /// Bottom of jacket (not available for legacy skins).
    /// </summary>
    JacketBottom,

    /// <summary>
    /// Front of jacket (not available for legacy skins).
    /// </summary>
    JacketFront,

    /// <summary>
    /// Left of jacket (not available for legacy skins).
    /// </summary>
    JacketLeft,

    /// <summary>
    /// Right of jacket (not available for legacy skins).
    /// </summary>
    JacketRight,

    /// <summary>
    /// Top of jacket (not available for legacy skins).
    /// </summary>
    JacketTop,

    /// <summary>
    /// Entire left arm (maps to <see cref="RightArm"/> for legacy skins).
    /// </summary>
    LeftArm,

    /// <summary>
    /// Back of left arm (maps to <see cref="RightArmBack"/> for legacy skins).
    /// </summary>
    LeftArmBack,

    /// <summary>
    /// Bottom of left arm (maps to <see cref="RightArmBottom"/> for legacy skins).
    /// </summary>
    LeftArmBottom,

    /// <summary>
    /// Front of left arm (maps to <see cref="RightArmFront"/> for legacy skins).
    /// </summary>
    LeftArmFront,

    /// <summary>
    /// Entire left arm jacket (not available for legacy skins).
    /// </summary>
    LeftArmJacket,

    /// <summary>
    /// Back of left arm jacket (not available for legacy skins).
    /// </summary>
    LeftArmJacketBack,

    /// <summary>
    /// Bottom of left arm jacket (not available for legacy skins).
    /// </summary>
    LeftArmJacketBottom,

    /// <summary>
    /// Front of left arm jacket (not available for legacy skins).
    /// </summary>
    LeftArmJacketFront,

    /// <summary>
    /// Left of left arm jacket (not available for legacy skins).
    /// </summary>
    LeftArmJacketLeft,

    /// <summary>
    /// Right of left arm jacket (not available for legacy skins).
    /// </summary>
    LeftArmJacketRight,

    /// <summary>
    /// Top of left arm jacket (not available for legacy skins).
    /// </summary>
    LeftArmJacketTop,

    /// <summary>
    /// Left of left arm (maps to <see cref="RightArmLeft"/> for legacy skins).
    /// </summary>
    LeftArmLeft,

    /// <summary>
    /// Right of left arm (maps to <see cref="RightArmRight"/> for legacy skins).
    /// </summary>
    LeftArmRight,

    /// <summary>
    /// Top of left arm (maps to <see cref="RightArmTop"/> for legacy skins).
    /// </summary>
    LeftArmTop,

    /// <summary>
    /// Entire left leg (maps to <see cref="RightLeg"/> for legacy skins).
    /// </summary>
    LeftLeg,

    /// <summary>
    /// Back of left leg (maps to <see cref="RightLegBack"/> for legacy skins).
    /// </summary>
    LeftLegBack,

    /// <summary>
    /// Bottom of left leg (maps to <see cref="RightLegBottom"/> for legacy skins).
    /// </summary>
    LeftLegBottom,

    /// <summary>
    /// Front of left leg (maps to <see cref="RightLegFront"/> for legacy skins).
    /// </summary>
    LeftLegFront,

    /// <summary>
    /// Entire left leg jacket (not available for legacy skins).
    /// </summary>
    LeftLegJacket,

    /// <summary>
    /// Back of left leg jacket (not available for legacy skins).
    /// </summary>
    LeftLegJacketBack,

    /// <summary>
    /// Bottom of left leg jacket (not available for legacy skins).
    /// </summary>
    LeftLegJacketBottom,

    /// <summary>
    /// Front of left leg jacket (not available for legacy skins).
    /// </summary>
    LeftLegJacketFront,

    /// <summary>
    /// Left of left leg jacket (not available for legacy skins).
    /// </summary>
    LeftLegJacketLeft,

    /// <summary>
    /// Right of left leg jacket (not available for legacy skins).
    /// </summary>
    LeftLegJacketRight,

    /// <summary>
    /// Top of left leg jacket (not available for legacy skins).
    /// </summary>
    LeftLegJacketTop,

    /// <summary>
    /// Left of left leg (maps to <see cref="RightLegLeft"/> for legacy skins).
    /// </summary>
    LeftLegLeft,

    /// <summary>
    /// Right of left leg (maps to <see cref="RightLegRight"/> for legacy skins).
    /// </summary>
    LeftLegRight,

    /// <summary>
    /// Top of left leg (maps to <see cref="RightLegTop"/> for legacy skins).
    /// </summary>
    LeftLegTop,

    /// <summary>
    /// Entire right arm.
    /// </summary>
    RightArm,

    /// <summary>
    /// Back of right arm.
    /// </summary>
    RightArmBack,

    /// <summary>
    /// Bottom of right arm.
    /// </summary>
    RightArmBottom,

    /// <summary>
    /// Front of right arm.
    /// </summary>
    RightArmFront,

    /// <summary>
    /// Entire right arm jacket (not available for legacy skins).
    /// </summary>
    RightArmJacket,

    /// <summary>
    /// Back of right arm jacket (not available for legacy skins).
    /// </summary>
    RightArmJacketBack,

    /// <summary>
    /// Bottom of right arm jacket (not available for legacy skins).
    /// </summary>
    RightArmJacketBottom,

    /// <summary>
    /// Front of right arm jacket (not available for legacy skins).
    /// </summary>
    RightArmJacketFront,

    /// <summary>
    /// Left of right arm jacket (not available for legacy skins).
    /// </summary>
    RightArmJacketLeft,

    /// <summary>
    /// Right of right arm jacket (not available for legacy skins).
    /// </summary>
    RightArmJacketRight,

    /// <summary>
    /// Top of right arm jacket (not available for legacy skins).
    /// </summary>
    RightArmJacketTop,

    /// <summary>
    /// Left of right arm.
    /// </summary>
    RightArmLeft,

    /// <summary>
    /// Right of right arm.
    /// </summary>
    RightArmRight,

    /// <summary>
    /// Top of right arm.
    /// </summary>
    RightArmTop,

    /// <summary>
    /// Entire right leg.
    /// </summary>
    RightLeg,

    /// <summary>
    /// Back of right leg.
    /// </summary>
    RightLegBack,

    /// <summary>
    /// Bottom of right leg.
    /// </summary>
    RightLegBottom,

    /// <summary>
    /// Front of right leg.
    /// </summary>
    RightLegFront,

    /// <summary>
    /// Entire right leg jacket (not available for legacy skins).
    /// </summary>
    RightLegJacket,

    /// <summary>
    /// Back of right leg jacket (not available for legacy skins).
    /// </summary>
    RightLegJacketBack,

    /// <summary>
    /// Bottom of right leg jacket (not available for legacy skins).
    /// </summary>
    RightLegJacketBottom,

    /// <summary>
    /// Front of right leg jacket (not available for legacy skins).
    /// </summary>
    RightLegJacketFront,

    /// <summary>
    /// Left of right leg jacket (not available for legacy skins).
    /// </summary>
    RightLegJacketLeft,

    /// <summary>
    /// Right of right leg jacket (not available for legacy skins).
    /// </summary>
    RightLegJacketRight,

    /// <summary>
    /// Top of right leg jacket (not available for legacy skins).
    /// </summary>
    RightLegJacketTop,

    /// <summary>
    /// Left of right leg.
    /// </summary>
    RightLegLeft,

    /// <summary>
    /// Right of right leg.
    /// </summary>
    RightLegRight,

    /// <summary>
    /// Top of right leg.
    /// </summary>
    RightLegTop
}

/// <summary>
/// Collection of all possible skin sections.
/// </summary>
public static class SkinSectionCollection
{
    /// <summary>
    /// Internal dictionary.
    /// </summary>
    private static readonly IDictionary<SkinSectionId, SkinSection> Data = new Dictionary<SkinSectionId, SkinSection>
    {
        [SkinSectionId.All32] = new(0, 0, 64, 32),
        [SkinSectionId.Body] = new(16, 16, 24, 16),
        [SkinSectionId.BodyBack] = new(28, 20, 8, 12),
        [SkinSectionId.BodyBottom] = new(28, 16, 8, 4),
        [SkinSectionId.BodyFront] = new(20, 20, 8, 12),
        [SkinSectionId.BodyLeft] = new(36, 20, 4, 12),
        [SkinSectionId.BodyRight] = new(16, 20, 4, 12),
        [SkinSectionId.BodyTop] = new(20, 16, 8, 4),
        [SkinSectionId.Hat] = new(32, 0, 32, 16),
        [SkinSectionId.HatBack] = new(56, 8, 8, 8),
        [SkinSectionId.HatBottom] = new(48, 0, 8, 8),
        [SkinSectionId.HatFront] = new(40, 8, 8, 8),
        [SkinSectionId.HatLeft] = new(48, 8, 8, 8),
        [SkinSectionId.HatRight] = new(32, 8, 8, 8),
        [SkinSectionId.HatTop] = new(40, 0, 8, 8),
        [SkinSectionId.Head] = new(0, 0, 32, 16),
        [SkinSectionId.HeadBack] = new(24, 8, 8, 8),
        [SkinSectionId.HeadBottom] = new(16, 0, 8, 8),
        [SkinSectionId.HeadFront] = new(8, 8, 8, 8),
        [SkinSectionId.HeadLeft] = new(16, 8, 8, 8),
        [SkinSectionId.HeadRight] = new(0, 8, 8, 8),
        [SkinSectionId.HeadTop] = new(8, 0, 8, 8),
        [SkinSectionId.Jacket] = new(16, 32, 24, 16),
        [SkinSectionId.JacketBack] = new(28, 36, 8, 12),
        [SkinSectionId.JacketBottom] = new(28, 32, 8, 4),
        [SkinSectionId.JacketFront] = new(20, 36, 8, 12),
        [SkinSectionId.JacketLeft] = new(36, 36, 4, 12),
        [SkinSectionId.JacketRight] = new(16, 36, 4, 12),
        [SkinSectionId.JacketTop] = new(20, 32, 8, 4),
        [SkinSectionId.LeftArmJacket] = new(48, 48, 16, 16),
        [SkinSectionId.LeftArmJacketBack] = new(60, 52, 4, 12),
        [SkinSectionId.LeftArmJacketBottom] = new(56, 48, 4, 4),
        [SkinSectionId.LeftArmJacketFront] = new(52, 52, 4, 12),
        [SkinSectionId.LeftArmJacketLeft] = new(56, 52, 4, 12),
        [SkinSectionId.LeftArmJacketRight] = new(48, 52, 4, 12),
        [SkinSectionId.LeftArmJacketTop] = new(52, 48, 4, 4),
        [SkinSectionId.LeftLegJacket] = new(0, 48, 16, 16),
        [SkinSectionId.LeftLegJacketBack] = new(12, 52, 4, 12),
        [SkinSectionId.LeftLegJacketBottom] = new(8, 48, 4, 4),
        [SkinSectionId.LeftLegJacketFront] = new(4, 52, 4, 12),
        [SkinSectionId.LeftLegJacketLeft] = new(8, 52, 4, 12),
        [SkinSectionId.LeftLegJacketRight] = new(0, 52, 4, 12),
        [SkinSectionId.LeftLegJacketTop] = new(4, 48, 4, 4),
        [SkinSectionId.RightArm] = new(40, 16, 16, 16),
        [SkinSectionId.RightArmBack] = new(52, 20, 4, 12),
        [SkinSectionId.RightArmBottom] = new(48, 16, 4, 4),
        [SkinSectionId.RightArmFront] = new(44, 20, 4, 12),
        [SkinSectionId.RightArmJacket] = new(40, 32, 16, 16),
        [SkinSectionId.RightArmJacketBack] = new(52, 36, 4, 12),
        [SkinSectionId.RightArmJacketBottom] = new(48, 32, 4, 4),
        [SkinSectionId.RightArmJacketFront] = new(44, 36, 4, 12),
        [SkinSectionId.RightArmJacketLeft] = new(48, 36, 4, 12),
        [SkinSectionId.RightArmJacketRight] = new(40, 36, 4, 12),
        [SkinSectionId.RightArmJacketTop] = new(44, 32, 4, 4),
        [SkinSectionId.RightArmLeft] = new(48, 20, 4, 12),
        [SkinSectionId.RightArmRight] = new(40, 20, 4, 12),
        [SkinSectionId.RightArmTop] = new(44, 16, 4, 4),
        [SkinSectionId.RightLeg] = new(0, 16, 16, 16),
        [SkinSectionId.RightLegBack] = new(12, 20, 4, 12),
        [SkinSectionId.RightLegBottom] = new(8, 16, 4, 4),
        [SkinSectionId.RightLegFront] = new(4, 20, 4, 12),
        [SkinSectionId.RightLegJacket] = new(0, 32, 16, 16),
        [SkinSectionId.RightLegJacketBack] = new(12, 36, 4, 12),
        [SkinSectionId.RightLegJacketBottom] = new(8, 32, 4, 4),
        [SkinSectionId.RightLegJacketFront] = new(4, 36, 4, 12),
        [SkinSectionId.RightLegJacketLeft] = new(8, 36, 4, 12),
        [SkinSectionId.RightLegJacketRight] = new(0, 36, 4, 12),
        [SkinSectionId.RightLegJacketTop] = new(4, 32, 4, 4),
        [SkinSectionId.RightLegLeft] = new(8, 20, 4, 12),
        [SkinSectionId.RightLegRight] = new(0, 20, 4, 12),
        [SkinSectionId.RightLegTop] = new(4, 16, 4, 4)
    };

    /// <summary>
    /// Initialises skin sections that has a legacy equivalent section.
    /// </summary>
    static SkinSectionCollection()
    {
        Data[SkinSectionId.All] = new SkinSection(0, 0, 64, 64, Data[SkinSectionId.All32]);
        Data[SkinSectionId.LeftArm] = new SkinSection(32, 48, 16, 16, Data[SkinSectionId.RightArm]);
        Data[SkinSectionId.LeftArmBack] = new SkinSection(44, 52, 4, 12, Data[SkinSectionId.RightArmBack]);
        Data[SkinSectionId.LeftArmBottom] = new SkinSection(40, 48, 4, 4, Data[SkinSectionId.RightArmBottom]);
        Data[SkinSectionId.LeftArmFront] = new SkinSection(36, 52, 4, 12, Data[SkinSectionId.RightArmFront]);
        Data[SkinSectionId.LeftArmLeft] = new SkinSection(40, 52, 4, 12, Data[SkinSectionId.RightArmLeft]);
        Data[SkinSectionId.LeftArmRight] = new SkinSection(32, 52, 4, 12, Data[SkinSectionId.RightArmRight]);
        Data[SkinSectionId.LeftArmTop] = new SkinSection(36, 48, 4, 4, Data[SkinSectionId.RightArmTop]);
        Data[SkinSectionId.LeftLeg] = new SkinSection(16, 48, 16, 16, Data[SkinSectionId.RightLeg]);
        Data[SkinSectionId.LeftLegBack] = new SkinSection(28, 52, 4, 12, Data[SkinSectionId.RightLegBack]);
        Data[SkinSectionId.LeftLegBottom] = new SkinSection(24, 48, 4, 4, Data[SkinSectionId.RightLegBottom]);
        Data[SkinSectionId.LeftLegFront] = new SkinSection(20, 52, 4, 12, Data[SkinSectionId.RightLegFront]);
        Data[SkinSectionId.LeftLegLeft] = new SkinSection(24, 52, 4, 12, Data[SkinSectionId.RightLegLeft]);
        Data[SkinSectionId.LeftLegRight] = new SkinSection(16, 52, 4, 12, Data[SkinSectionId.RightLegRight]);
        Data[SkinSectionId.LeftLegTop] = new SkinSection(20, 48, 4, 4, Data[SkinSectionId.RightLegTop]);
    }

    /// <summary>
    /// Retrieves a specific skin section.
    /// </summary>
    /// <param name="sectionId">The ID of the section to retrieve.</param>
    /// <returns>The retrieved skin section.</returns>
    public static SkinSection Get(SkinSectionId sectionId)
    {
        return Data[sectionId];
    }
}
