// SPDX-FileCopyrightText: 2022 Alex Evgrashin <aevgrashin@yandex.ru>
// SPDX-FileCopyrightText: 2022 Alexander Evgrashin <evgrashin.adl@gmail.com>
// SPDX-FileCopyrightText: 2022 Rane <60792108+Elijahrane@users.noreply.github.com>
// SPDX-FileCopyrightText: 2022 mirrorcult <lunarautomaton6@gmail.com>
// SPDX-FileCopyrightText: 2022 wrexbe <81056464+wrexbe@users.noreply.github.com>
// SPDX-FileCopyrightText: 2023 DrSmugleaf <DrSmugleaf@users.noreply.github.com>
// SPDX-FileCopyrightText: 2023 Kara <lunarautomaton6@gmail.com>
// SPDX-FileCopyrightText: 2023 Nemanja <98561806+EmoGarbage404@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 sleepyyapril <123355664+sleepyyapril@users.noreply.github.com>
//
// SPDX-License-Identifier: MIT

using Content.Shared.Atmos;

namespace Content.Server.Xenoarchaeology.XenoArtifacts.Triggers.Components;

/// <summary>
///     Activates artifact when it surrounded by certain gas.
/// </summary>
[RegisterComponent]
public sealed partial class ArtifactGasTriggerComponent : Component
{
    /// <summary>
    ///     List of possible activation gases to pick on startup.
    /// </summary>
    [DataField("possibleGas")]
    public List<Gas> PossibleGases = new()
    {
        Gas.Oxygen,
        Gas.Plasma,
        Gas.Nitrogen,
        Gas.CarbonDioxide,
        Gas.Ammonia,
        Gas.NitrousOxide,
        Gas.BZ, // Assmos - /tg/ gases
        Gas.Healium, // Assmos - /tg/ gases
        Gas.Nitrium, // Assmos - /tg/ gases
        Gas.Pluoxium, // Assmos - /tg/ gases
        Gas.Hydrogen, // Assmos - /tg/ gases
        Gas.HyperNoblium, // Assmos - /tg/ gases
        Gas.ProtoNitrate, // Assmos - /tg/ gases
        Gas.Zauker, // Assmos - /tg/ gases
        Gas.Halon, // Assmos - /tg/ gases
        Gas.Helium, // Assmos - /tg/ gases
        Gas.AntiNoblium, // Assmos - /tg/ gases
    };

    /// <summary>
    ///     Gas id that will activate artifact.
    /// </summary>
    [DataField("gas")]
    [ViewVariables(VVAccess.ReadWrite)]
    public Gas? ActivationGas;

    /// <summary>
    ///     How many moles of gas should be present in room to activate artifact.
    /// </summary>
    [DataField("moles")]
    [ViewVariables(VVAccess.ReadWrite)]
    public float ActivationMoles = Atmospherics.MolesCellStandard * 0.1f;
}
