namespace CrossMacro.Core.Models.Macros;

/// <summary>
/// Locates an editor action comment across event and script-step projections.
/// </summary>
public sealed record ActionCommentBoundary(
    int EventStartIndex,
    int EventCount,
    int ScriptStepStartIndex,
    int ScriptStepCount,
    string Comment);
