namespace HimelPortfolio.Models;

/// <summary>
/// Dynamic skill status values required by the Technical Arsenal specification.
/// </summary>
public enum SkillStatus
{
    WorkingWith = 1,
    FamiliarWith = 2,
    CurrentlyLearning = 3,
    Exploring = 4,
    Planned = 5
}

public enum ProjectStatus
{
    Completed,
    InProgress,
    Planned
}

public sealed record SkillItem(
    string Name,
    string Category,
    SkillStatus Status,
    string? Description = null,
    string? OfficialDocUrl = null,
    int DisplayOrder = 100,
    string? LastUpdated = "2026-11"
);

public sealed record EducationEntry(
    string Institution,
    string? Faculty,
    string Department,
    string DegreeName,
    string CurrentStageCode,
    string CurrentStageDescription,
    int EnrollmentYear,
    int ExpectedGraduationYear,
    string? CgpaDisplay,
    IReadOnlyList<string> RelevantCoursework,
    IReadOnlyList<string> AcademicNotes
);

public sealed record ProjectItem(
    string Slug,
    string Title,
    string Tagline,
    string Category,
    ProjectStatus Status,
    string ShortDescription,
    string ProblemStatement,
    string Motivation,
    string ProposedSolution,
    string ArchitectureOverview,
    IReadOnlyList<string> TechStack,
    IReadOnlyList<string> EngineeringDecisions,
    IReadOnlyList<string> Challenges,
    IReadOnlyList<string> FutureImprovements,
    string? GitHubUrl,
    string? LiveDemoUrl,
    bool IsFeaturedOnHome = true,
    bool HasPlaceholderNotice = true
);

public sealed record CpPlatformProfile(
    string PlatformName,
    string HandlePlaceholder,
    string ProfileUrl,
    string SolvedCountDisplay,
    string CurrentRatingDisplay,
    string MaxRatingDisplay,
    string RankTitleDisplay,
    string Notes
);

public sealed record ContestEntry(
    string ContestName,
    string Category, // e.g., "ICPC Preliminary", "IUPC", "Intra-University"
    string DateDisplay,
    string TeamName,
    string ParticipationStage, // Honest distinction: Participation / Qualification / Regional
    string ResultOrStandingDisplay,
    string KeyTakeaway
);

public sealed record ClubActivityEntry(
    string OrganizationName,
    string Role,
    string Period,
    string Summary,
    IReadOnlyList<string> ResponsibilitiesAndActivities
);

public sealed record PcBhaiVideoItem(
    string Title,
    string Category,
    string YouTubeVideoId,
    string DurationDisplay,
    string Summary,
    bool IsFeatured = false
);

public sealed record PcBuildShowcaseItem(
    string BuildTitle,
    string TierCategory,
    string ProcessorAndGpu,
    string PurposeSummary,
    string LocationDelivered
);

public sealed record BlogArticleItem(
    string Slug,
    string Title,
    string Category,
    string PublishedDate,
    string ReadingTime,
    bool IsDraftPlaceholder,
    string Excerpt,
    IReadOnlyList<string> Tags,
    IReadOnlyList<string> TableOfContents,
    IReadOnlyList<string> Paragraphs,
    string? CodeSampleCSharp = null
);