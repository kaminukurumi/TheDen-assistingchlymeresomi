// SPDX-FileCopyrightText: 2025 VMSolidus <evilexecutive@gmail.com>
// SPDX-FileCopyrightText: 2025 sleepyyapril <123355664+sleepyyapril@users.noreply.github.com>
//
// SPDX-License-Identifier: AGPL-3.0-or-later AND MIT

using Robust.Shared.Configuration;

namespace Content.Shared.CCVar;

public sealed partial class CCVars
{
    public static readonly CVarDef<int> MaxMidiEventsPerSecond =
        CVarDef.Create("midi.max_events_per_second", 1000, CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<int> MaxMidiEventsPerBatch =
        CVarDef.Create("midi.max_events_per_batch", 60, CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<int> MaxMidiBatchesDropped =
        CVarDef.Create("midi.max_batches_dropped", 1, CVar.SERVERONLY);

    public static readonly CVarDef<int> MaxMidiLaggedBatches =
        CVarDef.Create("midi.max_lagged_batches", 8, CVar.SERVERONLY);
}
