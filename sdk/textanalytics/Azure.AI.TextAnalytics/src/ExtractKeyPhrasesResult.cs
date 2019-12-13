﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Azure.AI.TextAnalytics
{
    /// <summary>
    /// </summary>
    public class ExtractKeyPhrasesResult : TextAnalyticsResult
    {
        internal ExtractKeyPhrasesResult(string id, TextDocumentStatistics statistics, IList<string> keyPhrases)
            : base(id, statistics)
        {
            KeyPhrases = new ReadOnlyCollection<string>(keyPhrases);
        }

        internal ExtractKeyPhrasesResult(string id, string errorMessage)
            : base(id, errorMessage)
        {
            KeyPhrases = Array.Empty<string>();
        }

        /// <summary>
        /// </summary>
        public IReadOnlyCollection<string> KeyPhrases { get; }
    }
}