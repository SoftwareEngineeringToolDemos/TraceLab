﻿using SEMERU.Core.Metrics;
using SEMERU.Types.Dataset;
using TraceLabSDK;
using TraceLabSDK.Types;

/// SEMERU Component Library - TraceLab Component Plugin
/// Copyright © 2012-2013 SEMERU
/// 
/// This file is part of the SEMERU Component Library.
/// 
/// The SEMERU Component Library is free software: you can redistribute it and/or
/// modify it under the terms of the GNU General Public License as published by the
/// Free Software Foundation, either version 3 of the License, or (at your option)
/// any later version.
/// 
/// The SEMERU Component Library is distributed in the hope that it will be useful,
/// but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY
/// or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License for
/// more details.
/// 
/// You should have received a copy of the GNU General Public License along with the
/// SEMERU Component Library.  If not, see <http://www.gnu.org/licenses/>.

namespace SEMERU.Components
{
    [Component(Name = "SEMERU - Metrics per source artifact",
        Description = "Computes precision, recall, and average precision metrics for each source artifact.",
        Author = "SEMERU; Evan Moritz",
        Version = "1.0.0.0",
        ConfigurationType = typeof(MetricsPerSourceArtifactConfig))]
    [IOSpec(IOSpecType.Input, "Similarities", typeof(TLSimilarityMatrix))]
    [IOSpec(IOSpecType.Input, "Oracle", typeof(TLSimilarityMatrix))]
    [IOSpec(IOSpecType.Output, "DataSetPairs", typeof(DataSetPairs))]
    [Tag("SEMERU.Metrics")]
    [Tag("Metrics")]
    public class MetricsPerSourceArtifactComponent : BaseComponent
    {
        private MetricsPerSourceArtifactConfig _config;

        public MetricsPerSourceArtifactComponent(ComponentLogger log)
            : base(log)
        {
            _config = new MetricsPerSourceArtifactConfig();
            Configuration = _config;
        }

        public override void Compute()
        {
            TLSimilarityMatrix sims = (TLSimilarityMatrix)Workspace.Load("Similarities");
            TLSimilarityMatrix oracle = (TLSimilarityMatrix)Workspace.Load("Oracle");
            Workspace.Store("DataSetPairs", MetricsPerSourceArtifact.Compute(sims, oracle, _config.Recall));
        }
    }

    public class MetricsPerSourceArtifactConfig
    {
        public RecallLevel Recall { get; set; }
    }
}
