// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.TextAnalytics.Legacy.Models
{
    internal static partial class TargetRelationTypeExtensions
    {
        public static string ToSerialString(this TargetRelationType value) => value switch
        {
            TargetRelationType.Assessment => "assessment",
            TargetRelationType.Target => "target",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown TargetRelationType value.")
        };

        public static TargetRelationType ToTargetRelationType(this string value)
        {
            if (string.Equals(value, "assessment", StringComparison.InvariantCultureIgnoreCase)) return TargetRelationType.Assessment;
            if (string.Equals(value, "target", StringComparison.InvariantCultureIgnoreCase)) return TargetRelationType.Target;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown TargetRelationType value.");
        }
    }
}
