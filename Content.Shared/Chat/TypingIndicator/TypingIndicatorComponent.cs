﻿using Robust.Shared.GameStates;
using Robust.Shared.Prototypes;

namespace Content.Shared.Chat.TypingIndicator;

/// <summary>
///     Show typing indicator icon when player typing text in chat box.
///     Added automatically when player poses entity.
/// </summary>
[RegisterComponent, NetworkedComponent, AutoGenerateComponentState(true)] // backmen: TypingIndicator
[Access(typeof(SharedTypingIndicatorSystem))]
public sealed partial class TypingIndicatorComponent : Component
{
    /// <summary>
    ///     Prototype id that store all visual info about typing indicator.
    /// </summary>
    [DataField("proto")]
    public ProtoId<TypingIndicatorPrototype> TypingIndicatorPrototype = "default";

    // start-backmen: TypingIndicator
    [AutoNetworkedField]
    public TypingIndicatorState TypingIndicatorState = TypingIndicatorState.None;
    // end-backmen: TypingIndicator
}
